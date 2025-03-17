using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace JidamVision.Algorithm
{
    public struct BinaryThreshold
    {
        public int lower;
        public int upper;
        public bool invert;
    }
    internal class BlobAlgorithm : InspAlgorithm
    {
        private List<Rect> _findArea;

        public  BinaryThreshold BinThreshold { get; set; } = new BinaryThreshold();

        // min, max 추가해서 Area 범위 지정할 수 있오록, 범위에 해당하는 영역 찾아내기****************
        public int AreaMinFilter { get; set; } = 100;
        //public int AreaMaxFilter { get; set; } = 10000;
        //public int WidthMinFilter { get; set; } = 100;
        //public int WidthMaxFilter { get; set; } = 10000;
        //public int HeightMinFilter { get; set; } = 100;
        //public int HeightMaxFilter { get; set; } = 10000;

        public BlobAlgorithm()
        {
            InspectType = InspectType.InspBinary;
        }

        public override bool DoInspect()
        {
            isInspected = false;

            if (_srcImage == null)
                return false;

            Mat grayImage = new Mat();
            if (_srcImage.Type() == MatType.CV_8UC3)
                Cv2.CvtColor(_srcImage, grayImage, ColorConversionCodes.BGR2GRAY);
            else
                grayImage = _srcImage;

            Mat binaryImage = new Mat();
            //Cv2.Threshold(grayImage, binaryMask, lowerValue, upperValue, ThresholdTypes.Binary);
            Cv2.InRange(grayImage, BinThreshold.lower, BinThreshold.upper, binaryImage);

            if (BinThreshold.invert)
                binaryImage = ~binaryImage;

            if (AreaMinFilter > 0)
            {
                if (!BlobFilter(binaryImage, AreaMinFilter))
                    return false;
            }

            isInspected = true;
            return true;
        }

        private bool BlobFilter(Mat binImage, int areaFilter)
        {
            Point[][] contours;
            HierarchyIndex[] hierarchy;
            // RetrievalModes.External : 어두운곳에서 처음으로 밝은 가장 외곽 경계 검출
            // RetrievalModes 계층구조 응용하기
            // ContourApproximationModes.ApproxSimple 빠르게 찾기 위한 설정
            Cv2.FindContours(binImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            Mat filteredImage = Mat.Zeros(binImage.Size(), MatType.CV_8UC1);
            
            if (_findArea is null)
                _findArea = new List<Rect>();

            _findArea.Clear();

            foreach(var contour in contours)
            {                
                double area = Cv2.ContourArea(contour);
                if (area < areaFilter)
                    continue;

                // 필터링된 객체를 이미지에 그림
                // Contour : 4개의 폐곡선을 이어서 내부영역을 계산
                //Cv2.DrawContours(filteredImage, new Point[][] { contour }, -1, Scalar.White, -1);

                // RotatedRect 정보 계산
                // Bounding : 마름모모양일 경우 min, max x, y값을 기준으로 바운딩 영역 찾기
                // Cv2.MinAreaRect : 마름모모양 그대로 꽉차게, 최외곽을 두르는 박스, RotatedRec 구조체에에 회전값 들어있음
                //RotatedRect rotatedRect = Cv2.MinAreaRect(contour);
                Rect boundingRect = Cv2.BoundingRect(contour);

                _findArea.Add(boundingRect);

                // RotatedRect 정보 출력
                //Console.WriteLine($"RotatedRect - Center: {rotatedRect.Center}, Size: {rotatedRect.Size}, Angle: {rotatedRect.Angle}");

                // BoundingRect 정보 출력
                //Console.WriteLine($"BoundingRect - X: {boundingRect.X}, Y: {boundingRect.Y}, Width: {boundingRect.Width}, Height: {boundingRect.Height}");
            }
            return true;
        }

        //#BINARY FILTER#4 이진화 영역 반환
        public override int GetResultRect(out List<Rect> resultArea)
        {
            resultArea = null;

            //#ABSTRACT ALGORITHM#7 검사가 완료되지 않았다면, 리턴
            if (!isInspected)
                return -1;

            if (_findArea is null || _findArea.Count <= 0)
                return -1;

            resultArea = _findArea;
            return resultArea.Count;
        }
    }
}

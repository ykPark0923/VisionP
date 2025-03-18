using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace JidamVision.Algorithm
{
    public class BlobFilterCondition
    {
        // 면적 필터 사용 여부
        public bool UseAreaFilter { get; set; }
        public int AreaMin { get; set; }
        public int AreaMax { get; set; }

        // 너비 필터 사용 여부
        public bool UseWidthFilter { get; set; }
        public int WidthMin { get; set; }
        public int WidthMax { get; set; }

        // 높이 필터 사용 여부
        public bool UseHeightFilter { get; set; }
        public int HeightMin { get; set; }
        public int HeightMax { get; set; }

        // 필터 조건 초기화 함수
        public void Reset()
        {
            UseAreaFilter = true;
            AreaMin = 100;
            AreaMax = 100000;

            UseWidthFilter = false;
            WidthMin = 100;
            WidthMax = 100000;

            UseHeightFilter = false;
            HeightMin = 100;
            HeightMax = 100000;
        }
    }

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

        public BlobFilterCondition FilterCondition { get; set; } = new BlobFilterCondition();

        public BlobAlgorithm()
        {
            InspectType = InspectType.InspBinary;
            FilterCondition.Reset(); // 필터 조건 기본값 설정
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
            Cv2.InRange(grayImage, BinThreshold.lower, BinThreshold.upper, binaryImage);

            if (BinThreshold.invert)
                binaryImage = ~binaryImage;

            // Blob 필터링 적용 (조건 기반 영역 추출)
            if (!BlobFilter(binaryImage, FilterCondition))
                return false;

            isInspected = true;

            return true;
        }

        private bool BlobFilter(Mat binImage, BlobFilterCondition filter)
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

                Rect boundingRect = Cv2.BoundingRect(contour);
                // [면적 필터 조건] 적용
                if (filter.UseAreaFilter && (area < filter.AreaMin || area > filter.AreaMax))
                    continue;
                // [너비 필터 조건] 적용
                if (filter.UseWidthFilter && (boundingRect.Width < filter.WidthMin || boundingRect.Width > filter.WidthMax))
                    continue;
                // [높이 필터 조건] 적용
                if (filter.UseHeightFilter && (boundingRect.Height < filter.HeightMin || boundingRect.Height > filter.HeightMax))
                    continue;
                _findArea.Add(boundingRect);
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

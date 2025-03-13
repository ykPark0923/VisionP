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

        public BinaryThreshold BinaryThreshold { get; private set; } = new BinaryThreshold();

        public int AreaFilter { get; set; } = 100;

        public BlobAlgorithm() { }

        public bool DoInspect(Mat srcImage)
        {
            if (srcImage == null) return false;

            Mat grayImage = new Mat();
            if (srcImage.Type() == MatType.CV_8UC3)
                Cv2.CvtColor(srcImage, grayImage, ColorConversionCodes.BGR2GRAY);
            else
                grayImage = srcImage;

            Mat binaryImage = new Mat();

            Cv2.InRange(grayImage, BinaryThreshold.lower, BinaryThreshold.upper, binaryImage);

            if (BinaryThreshold.invert)
                binaryImage = ~binaryImage;

            if (AreaFilter > 0)
            {
                if (!BlobFilter(binaryImage, AreaFilter))
                    return false;
            }
            return true;
        }

        private bool BlobFilter(Mat binImage, int areaFilter)
        {
            Point[][] contours;
            HierarchyIndex[] hierarchy;
            Cv2.FindContours(binImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

            Mat filteredImage = Mat.Zeros(binImage.Size(), MatType.CV_8UC1);

            if (_findArea is null)
                _findArea = new List<Rect>();

            _findArea.Clear();

            foreach(var contour in contours)
            {
                double area = Cv2.ContourArea(contour);
                if (area < areaFilter) continue;

                Rect boundingRect = Cv2.BoundingRect(contour);

                _findArea.Add(boundingRect);                   
            }

            return true;
        }

        public int GetResultRect(out List<Rect> resultArea)
        {
            resultArea = null;

            if (_findArea is null || _findArea.Count <= 0) return -1;

            resultArea = _findArea;
            return resultArea.Count;
        }
    }
}

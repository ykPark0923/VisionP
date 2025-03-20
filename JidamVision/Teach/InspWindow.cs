using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JidamVision.Algorithm;
using OpenCvSharp;
using JidamVision.Core;
using System.Security.Policy;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace JidamVision.Teach
{
    //#MATCH PROP#3 InspWindow 클래스 추가, ROI 관리 및 검사를 처리하는 클래스
    //검사 알고리즘를 관리하는 클래스

    public class InspWindow
    {
        //템플릿 매칭할 윈도우 크기
        private System.Drawing.Rectangle _rect;
        //템플릿 매칭 이미지
        private Mat _teachingImage;

        public InspWindowType InspWindowType { get; set; }

        //#MODEL SAVE#5 모델 저장을 위한 Serialize를 위해서, prvate set -> set으로 변경
        //public string Name {  get; private set; }
        public string Name { get;  set; }
        public string UID { get; set; }

        public Rect WindowArea { get; set; }

        //템플릿 매칭으로 찾은 위치 리스트
        //private List<OpenCvSharp.Point> _outPoints;


        [XmlElement("InspAlgorithm")]
        internal List<InspAlgorithm> AlgorithmList { get; set; } = new List<InspAlgorithm>();


        ////#BINARY FILTER#5 이진화 알고리즘 추가
        ////이진화 검사 클래스
        //private BlobAlgorithm _blobAlgorithm;

        //internal BlobAlgorithm BlobAlgorithm => _blobAlgorithm;



        //템플릿 매칭 클래스
        //private MatchAlgorithm _matchAlgorithm;

        // 내부(internal)에서만 접근 가능하며, MatchAlgorithm 타입의 읽기 전용 속성
        //internal MatchAlgorithm MatchAlgorithm => _matchAlgorithm;

        //부모-자식 관계를 위한 변수 추가
        public InspWindow Parent { get; set; }

        [XmlElement("ChildWindow")]
        public List<InspWindow> Children { get; set; } = new List<InspWindow>();

        public InspWindow()
        {
            //_matchAlgorithm = new MatchAlgorithm();

            ////#BINARY FILTER#6 이진화 알고리즘 인스턴스 생성
            //_blobAlgorithm = new BlobAlgorithm();
            AddInspAlgorithm(InspectType.InspMatch);
            AddInspAlgorithm(InspectType.InspBinary);
            AddInspAlgorithm(InspectType.InspFm);

        }

        internal InspWindow(InspWindowType windowType, string name)
        {
            InspWindowType = windowType;
            Name = name;
            AddInspAlgorithm(InspectType.InspMatch);
            AddInspAlgorithm(InspectType.InspBinary);
            AddInspAlgorithm(InspectType.InspFm);
        }


        public bool SetTeachingImage(Mat image, System.Drawing.Rectangle rect)
        {
            _rect = rect;
            _teachingImage = new Mat(image, new Rect(rect.X, rect.Y, rect.Width, rect.Height));
            return true;
        }

        //#MATCH PROP#4 템플릿 매칭 이미지 로딩
        public bool PatternLearn()
        {
            foreach (var algorithm in AlgorithmList)
            {
                if (algorithm.InspectType != InspectType.InspMatch)
                    continue;

                MatchAlgorithm matchAlgo = (MatchAlgorithm)algorithm;

                string templatePath = Path.Combine(Directory.GetCurrentDirectory(), Define.ROI_IMAGE_NAME);
                if (File.Exists(templatePath))
                {
                    _teachingImage = Cv2.ImRead(templatePath);

                    if (_teachingImage != null)
                        matchAlgo.SetTemplateImage(_teachingImage);
                }
            }

            return true;
        }

        public bool AddInspAlgorithm(InspectType inspType)
        {
            InspAlgorithm inspAlgo = null;

            switch (inspType)
            {
                case InspectType.InspBinary:
                    inspAlgo = new BlobAlgorithm();
                    break;
                case InspectType.InspMatch:
                    inspAlgo = new MatchAlgorithm();
                    break;
                case InspectType.InspFm:
                    inspAlgo = new FmInspAlgorithm();
                    break;
            }

            if (inspAlgo is null)
                return false;

            AlgorithmList.Add(inspAlgo);

            return true;
        }

        internal InspAlgorithm FindInspAlgorithm(InspectType inspType)
        {
            //foreach (var algorithm in AlgorithmList)
            //{
            //    if (algorithm.InspectType == inspType) return algorithm;
            //}
            return AlgorithmList.Find(algo => algo.InspectType == inspType); ;
        }

        //#MATCH PROP#5 템플릿 매칭 검사
        public bool DoInpsect(InspectType inspType)
        {
            foreach(var inspAlgo in AlgorithmList)
            {
                if(inspAlgo.InspectType == inspType || inspAlgo.InspectType == InspectType.InspNone)
                {
                    inspAlgo.DoInspect();
                }
            }
            return true;
        }


        #region 부모 - 자식 관계 관리 메서드 추가

        public void AddChild(InspWindow child)
        {
            if (child == null || Children.Contains(child))
                return;

            child.Parent = this;
            Children.Add(child);
        }

        public bool RemoveChild(InspWindow child)
        {
            if (child == null || !Children.Contains(child))
                return false;

            child.Parent = null;
            if (!Children.Remove(child))
                return false;

            return true;
        }

        public InspWindow GetRoot()
        {
            InspWindow root = this;
            while (root.Parent != null)
                root = root.Parent;

            return root;
        }


        #endregion

        //#MATCH PROP#6 템플릿 매칭 검사 결과 위치를 Rectangle 리스트로 반환
        //public int GetMatchRect(out List<Rect> rects)
        //{
        //    rects = new List<Rect>();

        //    int halfWidth = _teachingImage.Width;
        //    int halfHeight = _teachingImage.Height;

        //    foreach (var point in _outPoints)
        //    {
        //        Console.WriteLine($"매칭된 위치: {_outPoints}");
        //        rects.Add(new Rect(point.X - halfWidth, point.Y - halfHeight, _teachingImage.Width, _teachingImage.Height));
        //    }

        //    return rects.Count;
        //}
    }
}

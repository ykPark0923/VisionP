using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JidamVision.Algorithm
{
    //#MATCH PROP#1 InspAlgorithm 클래스를 추가, 여러 알고리즘을 추상화하기 위함
    //추가 내용은 나중에 개발하고, 현재는 비어 있는 상태로 만들것
    public abstract class InspAlgorithm
    {
        public InspectType InspectType { get; set; } = InspectType.InspNone;

        public bool IsUse { get; set; } = false;

        public bool isInspected {  get; set; } = false;

        protected Mat _srcImage = null;

        public virtual void SetInspData(Mat srcImage)
        {
            _srcImage = srcImage;
        }

        public abstract bool DoInspect();

        public virtual int GetResultRect(out List<Rect> resultArea)
        {
            resultArea = null;
            return 0;
        }
    }
}

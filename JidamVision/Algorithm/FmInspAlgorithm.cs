using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace JidamVision.Algorithm
{
    internal class FmInspAlgorithm : InspAlgorithm
    {
        public int DifferenceGV { get; set; } = 50;
        public Size fmInspSize { get; set; } = new Size(10, 10);
        //매칭이 설공했을때, 결과 매칭율
        public string Color { get; set; } = "All";

        public FmInspAlgorithm()
        {
            InspectType = InspectType.InspFm;
        }


        public override bool DoInspect()
        {
            return true;
        }
    }
}

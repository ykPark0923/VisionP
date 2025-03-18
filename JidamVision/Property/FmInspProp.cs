using JidamVision.Algorithm;
using JidamVision.Core;
using JidamVision.Teach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JidamVision.Property
{
    enum FmColorType
    {
        All = 0,
        White,
        Black
    }

    public partial class FmInspProp : UserControl
    {
        public FmInspProp()
        {
            InitializeComponent();
        }

        public void LoadInspParam()
        {
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow is null)
                return;

            //#INSP WORKER#14 inspWindow에서 매칭 알고리즘 찾는 코드
            FmInspAlgorithm fmAlgo = (FmInspAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspFm);
            if (fmAlgo == null) return;


            int diffGV = fmAlgo.DifferenceGV;
            string color = fmAlgo.Color;

            OpenCvSharp.Size fmInspSize = fmAlgo.fmInspSize;


            tbx_diffGV.Text = diffGV.ToString();
            tbx_sizeX.Text = fmInspSize.Width.ToString();
            tbx_sizeY.Text = fmInspSize.Height.ToString();



            cmb_color.Items.Clear();
            foreach (FmColorType colorType in Enum.GetValues(typeof(FmColorType)))
            { 
                  cmb_color.Items.Add(colorType.ToString());
            }

            // color 값이 ComboBox에 있으면 선택
            if (cmb_color.Items.Contains(color))
            {
                cmb_color.SelectedItem = color;
            }
            else
            {
                cmb_color.SelectedIndex = 0; // 기본값
            }
        }
    }
}

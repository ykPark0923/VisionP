using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JidamVision.Algorithm;
using JidamVision.Core;
using JidamVision.Teach;

namespace JidamVision.Property
{
    public partial class SetCamParamInspProp: UserControl
    {
        public SetCamParamInspProp()
        {
            InitializeComponent();
        }

        public void LoadInspParam()
        {
            //이미 설정된 exposureTime Gain값 가져와 뿌려줘야함
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow != null)
            {
                string exposureTime = txt_exposureTime.ToString();
                string Gain = txt_gain.ToString();
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            LoadInspParam();
            // exposureTime, Gaine값 저장
        }

    }
}

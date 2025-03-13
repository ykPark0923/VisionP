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
using static System.Windows.Forms.MonthCalendar;
using JidamVision.Algorithm;

namespace JidamVision.Property
{
    public partial class BinaryInspProp : UserControl
    {
        public event EventHandler<RangeChangedEventArgs> RangeChanged;

        // 속성값을 이용하여 이진화 임계값 설정
        public int LowerValue => trackBarLower.Value;
        public int UpperValue => trackBarUpper.Value;

        public BinaryInspProp()
        {
            InitializeComponent();

            // TrackBar 초기 설정
            trackBarLower.ValueChanged += OnValueChanged;
            trackBarUpper.ValueChanged += OnValueChanged;

            trackBarLower.Value = 0;
            trackBarUpper.Value = 128;
        }

        //#BIN PROP# 이진화 검사 속성값을 GUI에 설정
        public void LoadInspParam()
        {
            // TrackBar 초기 설정
            trackBarLower.ValueChanged += OnValueChanged;
            trackBarUpper.ValueChanged += OnValueChanged;

            trackBarLower.Value = 0;
            trackBarUpper.Value = 128;

            //#BINARY FILTER#8 이진화 필터값을 GUI에 로딩
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow != null)
            {
                BlobAlgorithm blobAlgo = inspWindow.BlobAlgorithm;
                if (blobAlgo != null)
                {
                    int filterArea = blobAlgo.AreaFilter;
                    //txtArea.Text = filterArea.ToString();
                }
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            RangeChanged?.Invoke(this, new RangeChangedEventArgs(LowerValue, UpperValue));
        }
    }
    public class RangeChangedEventArgs : EventArgs
    {
        public int LowerValue { get; }
        public int UpperValue { get; }

        public RangeChangedEventArgs(int lowerValue, int upperValue)
        {
            LowerValue = lowerValue;
            UpperValue = upperValue;
        }
    }
}

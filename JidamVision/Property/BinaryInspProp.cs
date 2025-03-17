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
using OpenCvSharp;

namespace JidamVision.Property
{
    public enum ShowBinaryMode
    {
        ShowBinaryNone = 0,  //이진화 하이라이트 끄기
        ShowBinaryHighlight,  //이진화 하이라이트 보기
        ShowBinaryOnly  //배경 없이 이진화 이미지만 보기
    }
    public partial class BinaryInspProp : UserControl
    {
        public event EventHandler<RangeChangedEventArgs> RangeChanged;

        // 속성값을 이용하여 이진화 임계값 설정
        public int LowerValue => trackBarLower.Value;
        public int UpperValue => trackBarUpper.Value;

        public BinaryInspProp()
        {
            InitializeComponent();

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
                BlobAlgorithm blobAlgo = (BlobAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspBinary);
                if (blobAlgo != null)
                {
                    int filterMinArea = blobAlgo.AreaMinFilter;
                    textBox_areaMin.Text = filterMinArea.ToString();
                    //int filterMaxArea = blobAlgo.AreaMaxFilter;
                    //textBox_areaMax.Text = filterMaxArea.ToString();

                    //int filterMinWidth = blobAlgo.WidthMinFilter;
                    //textBox_widthMin.Text = filterMinWidth.ToString();
                    //int filterMaxWidth = blobAlgo.WidthMaxFilter;
                    //textBox_widthMax.Text = filterMaxWidth.ToString();

                    //int filterMinHeight = blobAlgo.HeightMinFilter;
                    //textBox_heightMin.Text = filterMinHeight.ToString();
                    //int filterMaxHeight = blobAlgo.HeightMaxFilter;
                    //textBox_heightMax.Text = filterMaxHeight.ToString();
                }
            }
        }

        //#BINARY FILTER#10 이진화 옵션을 선택할때마다, 이진화 이미지가 갱신되도록 하는 함수
        private void UpdateBinary()
        {
            bool invert = chkInvert.Checked;
            bool highlight = chkHighlight.Checked;

            ShowBinaryMode showBinaryMode = ShowBinaryMode.ShowBinaryNone;
            if (highlight)
            {
                showBinaryMode = ShowBinaryMode.ShowBinaryHighlight;

                bool showBinary = chkShowBinary.Checked;

                if (showBinary)
                    showBinaryMode = ShowBinaryMode.ShowBinaryOnly;
            }

            RangeChanged?.Invoke(this, new RangeChangedEventArgs(LowerValue, UpperValue, invert, showBinaryMode));
        }

        //#BINARY FILTER#11 GUI 이벤트와 UpdateBinary함수 연동
        private void OnValueChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkShowBinary_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkHighlight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }

        private void chkInvert_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBinary();
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            InspWindow inspWindow = Global.Inst.InspStage.InspWindow;
            if (inspWindow is null)
                return;

            //#INSP WORKER#9 inspWindow에서 이진화 알고리즘 찾는 코드 추가
            BlobAlgorithm blobAlgo = (BlobAlgorithm)inspWindow.FindInspAlgorithm(InspectType.InspBinary);
            if (blobAlgo is null)
                return;

            BinaryThreshold threshold = new BinaryThreshold();
            threshold.upper = UpperValue;
            threshold.lower = LowerValue;
            threshold.invert = chkInvert.Checked;

            blobAlgo.BinThreshold = threshold;

            int filterAreaMin = int.Parse(textBox_areaMin.Text);
            //int filterAreaMax = int.Parse(textBox_areaMax.Text);

            //int filterWidthMin = int.Parse(textBox_widthMin.Text);
            //int filterWidthMax = int.Parse(textBox_widthMax.Text);

            //int filterHeightMin = int.Parse(textBox_heightMin.Text);
            //int filterHeightMax = int.Parse(textBox_heightMax.Text);


            blobAlgo.AreaMinFilter = filterAreaMin;
            //blobAlgo.AreaMaxFilter = filterAreaMax;

            //blobAlgo.WidthMinFilter = filterWidthMin;
            //blobAlgo.WidthMaxFilter = filterWidthMax;

            //blobAlgo.HeightMinFilter = filterHeightMin;
            //blobAlgo.HeightMaxFilter = filterHeightMax;

            //#INSP WORKER#10 이진화 검사시, 해당 InspWindow와 이진화 알고리즘만 실행
            Global.Inst.InspStage.InspWorker.TryInspect(inspWindow, InspectType.InspBinary);

        }

        private void checkBox_area_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_width_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_height_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class RangeChangedEventArgs : EventArgs
    {
        public int LowerValue { get; }
        public int UpperValue { get; }
        public bool Invert { get; }
        public ShowBinaryMode ShowBinMode { get; }

        public RangeChangedEventArgs(int lowerValue, int upperValue, bool invert, ShowBinaryMode showBinaryMode)
        {
            LowerValue = lowerValue;
            UpperValue = upperValue;
            Invert = invert;
            ShowBinMode = showBinaryMode;
        }
    }
}

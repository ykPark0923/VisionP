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
                    var FilterCondition = blobAlgo.FilterCondition;

                    // 면적 필터 UI 반영
                    textBox_areaMin.Text = FilterCondition.AreaMin.ToString();
                    textBox_areaMax.Text = FilterCondition.AreaMax.ToString();
                    checkBox_area.Checked = FilterCondition.isCheckedArea;
                    textBox_areaMin.Enabled = checkBox_area.Checked;
                    textBox_areaMax.Enabled = checkBox_area.Checked;

                    // 너비 필터 UI 반영
                    textBox_widthMin.Text = FilterCondition.WidthMin.ToString();
                    textBox_widthMax.Text = FilterCondition.WidthMax.ToString();
                    checkBox_width.Checked = FilterCondition.isCheckedWidth;
                    textBox_widthMin.Enabled = checkBox_width.Checked;
                    textBox_widthMax.Enabled = checkBox_width.Checked;

                    // 높이 필터 UI 반영
                    textBox_heightMin.Text = FilterCondition.HeightMin.ToString();
                    textBox_heightMax.Text = FilterCondition.HeightMax.ToString();
                    checkBox_height.Checked = FilterCondition.isCheckedHeight;
                    textBox_heightMin.Enabled = checkBox_height.Checked;
                    textBox_heightMax.Enabled = checkBox_height.Checked;

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

            // 필터 조건 업데이트(최소값, 최대값 입력 시 업데이트)
            UpdateBlobFilter(blobAlgo);

            //#INSP WORKER#10 이진화 검사시, 해당 InspWindow와 이진화 알고리즘만 실행
            Global.Inst.InspStage.InspWorker.TryInspect(inspWindow, InspectType.InspBinary);

        }

        private void checkBox_area_CheckedChanged(object sender, EventArgs e)
        {
            textBox_areaMin.Enabled = checkBox_area.Checked;
            textBox_areaMax.Enabled = checkBox_area.Checked;
        }

        private void checkBox_width_CheckedChanged(object sender, EventArgs e)
        {
            textBox_widthMin.Enabled = checkBox_width.Checked;
            textBox_widthMax.Enabled = checkBox_width.Checked;
        }

        private void checkBox_height_CheckedChanged(object sender, EventArgs e)
        {
            textBox_heightMin.Enabled = checkBox_height.Checked;
            textBox_heightMax.Enabled = checkBox_height.Checked;
        }

        private void UpdateBlobFilter(BlobAlgorithm blobAlgo)
        {
            if (blobAlgo == null) return;
            var cond = blobAlgo.FilterCondition;

            try
            {
                // 면적 조건
                cond.isCheckedArea = checkBox_area.Checked;
                if (checkBox_area.Checked)
                {
                    cond.AreaMin = int.Parse(textBox_areaMin.Text);
                    cond.AreaMax = int.Parse(textBox_areaMax.Text);

                    if (cond.AreaMax <= 0) cond.AreaMax = int.MaxValue;
                    if (cond.AreaMin > cond.AreaMax)
                        throw new ArgumentException("면적 최소값이 최대값보다 클 수 없습니다.");
                }

                // 너비 조건
                cond.isCheckedWidth = checkBox_width.Checked;
                if (checkBox_width.Checked)
                {
                    cond.WidthMin = int.Parse(textBox_widthMin.Text);
                    cond.WidthMax = int.Parse(textBox_widthMax.Text);
                    if (cond.WidthMax <= 0) cond.WidthMax = int.MaxValue;
                    if (cond.WidthMin > cond.WidthMax)
                        throw new ArgumentException("너비 최소값이 최대값보다 클 수 없습니다.");
                }

                // 높이 조건
                cond.isCheckedHeight = checkBox_height.Checked;
                if (checkBox_height.Checked)
                {
                    cond.HeightMin = int.Parse(textBox_heightMin.Text);
                    cond.HeightMax = int.Parse(textBox_heightMax.Text);
                    if (cond.HeightMax <= 0) cond.HeightMax = int.MaxValue;
                    if (cond.HeightMin > cond.HeightMax)
                        throw new ArgumentException("높이 최소값이 최대값보다 클 수 없습니다.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("숫자만 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("필터 값이 잘못되었습니다.\n" + ex.Message, "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // 필터 조건 반영
            blobAlgo.FilterCondition = cond;
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

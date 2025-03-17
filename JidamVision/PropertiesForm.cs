using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using JidamVision.Property;
using JidamVision.Core;
using OpenCvSharp.XFeatures2D;

namespace JidamVision
{
    public enum InspectType
    {
        InspNone = -1,
        InspBinary,
        InspMatch,
        InspFilter,
        InspCamParam,
        InspCount  //전체 enum의 count를 알고 있음, InspNone = -1이므로 카운트 제외
    }

    public partial class PropertiesForm : DockContent
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }


        //옵션창에서 입력된 타입의 속성창 생성
        private void LoadOptionControl(InspectType inspType)
        {
            string tabName = inspType.ToString();

            // 이미 있는 TabPage인지 확인
            foreach (TabPage tabPage in tabPropControl.TabPages)
            {
                if (tabPage.Text == tabName)
                {
                    tabPropControl.SelectedTab = tabPage;
                    return;
                }
            }

            // 새로운 UserControl 생성
            UserControl _inspProp = CreateUserControl(inspType);
            if (_inspProp == null)
                return;

            // 새 탭 추가
            TabPage newTab = new TabPage(tabName)
            {
                Dock = DockStyle.Fill
            };
            _inspProp.Dock = DockStyle.Fill;
            newTab.Controls.Add(_inspProp);
            tabPropControl.TabPages.Add(newTab);
            tabPropControl.SelectedTab = newTab; // 새 탭 선택
        }

        private UserControl CreateUserControl(InspectType inspPropType)
        {
            UserControl _InspProp = null;
            switch (inspPropType)
            {
                case InspectType.InspBinary:
                    BinaryInspProp blobProp = new BinaryInspProp(); ;
                    blobProp.LoadInspParam();
                    blobProp.RangeChanged += RangeSlider_RangeChanged;
                    _InspProp = blobProp;
                    break;
                case InspectType.InspMatch:
                    MatchInspProp matchProp = new MatchInspProp();
                    matchProp.LoadInspParam();
                    _InspProp = matchProp;
                    break;
                case InspectType.InspFilter:
                    FilterInspProp filterProp = new FilterInspProp();
                    filterProp.FilterSelected += FilterSelect_FilterChanged;
                    _InspProp = filterProp;
                    break;
                case InspectType.InspCamParam:
                    SetCamParamInspProp camparamProp = new SetCamParamInspProp();
                    camparamProp.LoadInspParam();
                    _InspProp = camparamProp;
                    break;
                default:
                    MessageBox.Show("유효하지 않은 옵션입니다.");
                    return null;
            }
            return _InspProp;
        }
        //public void SetInspType(InspectType inspPropType)
        //{
        //    LoadOptionControl(inspPropType);
        //}

        public void AddInspType(InspectType inspPropType)
        {
            LoadOptionControl(inspPropType);
        }

        private void FilterSelect_FilterChanged(object sender, FilterSelectedEventArgs e)
        {
            //선택된 필터값 inspStage의 ApplyFilter로 보냄
            string filter1 = e.FilterSelected1;
            int filter2 = e.FilterSelected2;
            Global.Inst.InspStage.PreView?.ApplyFilter(filter1, filter2);
        }
        private void PropertiesForm_Resize(object sender, EventArgs e)
        {

        }

        //#BINARY FILTER#16 이진화 속성 변경시 발생하는 이벤트 수정
        private void RangeSlider_RangeChanged(object sender, RangeChangedEventArgs e)
        {
            // 속성값을 이용하여 이진화 임계값 설정
            int lowerValue = e.LowerValue;
            int upperValue = e.UpperValue;
            bool invert = e.Invert;
            ShowBinaryMode showBinMode = e.ShowBinMode;
            Global.Inst.InspStage.PreView?.SetBinary(lowerValue, upperValue, invert, showBinMode);
        }
    }
}

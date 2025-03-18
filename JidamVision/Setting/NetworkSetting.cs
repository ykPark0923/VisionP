using JidamVision.Core;
using JidamVision.Grab;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JidamVision.Setting
{
    public partial class NetworkSetting : UserControl
    {
        public enum CommunicationType
        {
            None = 0,
            WCR
        }

        public NetworkSetting()
        {
            InitializeComponent();
            LoadSetting();
        }

        private void LoadSetting()
        {
            //카메라 타입을 콤보박스에 추가
            cbCommType.DataSource = Enum.GetValues(typeof(CommunicationType)).Cast<CommunicationType>().ToList();
            //환경설정에서 현재 카메라 타입 얻기
            cbCommType.SelectedIndex = (int)SettingXml.Inst.CommType;

            //환경설정에서 모델 저장 경로 얻기
            tbx_gain.Text = SettingXml.Inst.IPAddress;
        }

        private void SaveSetting()
        {
            //환경설정에 카메라 타입 설정
            SettingXml.Inst.CommType = (CommunicationType)cbCommType.SelectedIndex;
            SettingXml.Inst.IPAddress = tbx_gain.Text;
            //환경설정 저장
            SettingXml.Save();
        }

        //적용 버튼 선택시 저장하기
        private void btnApply_Click(object sender, EventArgs e)
        {            
            SaveSetting();
        }
    }
}

using JidamVision.Core;
using JidamVision.Grab;
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
    //#SETUP#3 환경설정창에 추가할 카메라설정 UserContorl 추가
    //카메라 타입 설정

    public partial class CameraSetting : UserControl
    {
        public CameraSetting()
        {
            InitializeComponent();

            //최초 로딩시, 환경설정 정보 로딩
            LoadSetting();
        }

        private void LoadSetting()
        {
            GrabModel grabModel = Global.Inst.InspStage.GrabModel;

            //카메라 타입을 콤보박스에 추가
            cbCameraType.DataSource = Enum.GetValues(typeof(CameraType)).Cast<CameraType>().ToList();
            //환경설정에서 현재 카메라 타입 얻기
            cbCameraType.SelectedIndex = (int)SettingXml.Inst.CamType;
            tbx_exposureTime.Text = SettingXml.Inst.ExposureType;
            tbx_gain.Text = SettingXml.Inst.Gain;

        }

        private void SaveSetting()
        {
            //환경설정에 카메라 타입 설정
            SettingXml.Inst.CamType = (CameraType)cbCameraType.SelectedIndex;
            SettingXml.Inst.ExposureType = tbx_exposureTime.Text;
            SettingXml.Inst.Gain = tbx_gain.Text;
            //환경설정 저장
            SettingXml.Save();
        }

        //적용 버튼 선택시 저장하기
        private void btnApply_Click(object sender, EventArgs e)
        {

            SaveSetting();

            GrabModel grabModel = Global.Inst.InspStage.GrabModel;

            if (grabModel == null) return;


            if((CameraType)cbCameraType.SelectedIndex == CameraType.WebCam)
            {
                grabModel.SetExposureTime(long.Parse(tbx_exposureTime.Text));
                grabModel.SetGain(long.Parse(tbx_gain.Text));
            }
            else if((CameraType)cbCameraType.SelectedIndex == CameraType.HikRobotCam)
            {
                grabModel.SetExposureTime(long.Parse(tbx_exposureTime.Text));
                grabModel.SetGain(long.Parse(tbx_gain.Text));
            }   
        }
    }
}
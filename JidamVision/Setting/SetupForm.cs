﻿using JidamVision.Property;
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

    //#SETUP#2 환경설정창 종류를 구분하기 위한 타입 설정
    public enum SettingType
    {
        SettingPath = 0,
        SettingCamera
    }

    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();

            //#SETUP#5 탭 콘트롤 추가, 아래 함수 함께 구현할것
            InitTabControl();
        }

        private void InitTabControl()
        {
            //카메라 설정 페이지 추가
            CameraSetting cameraSetting = new CameraSetting();
            AddTabControl(cameraSetting, "Camera");

            //경로 설정 페이지 추가
            PathSetting pathSetting = new PathSetting();
            AddTabControl(pathSetting, "Path");

            //기본값으로 카메라 설정 페이지 보이도록 설정
            tabSetting.SelectTab(0);
        }

        //탭 추가 함수
        private void AddTabControl(UserControl control, string tabName)
        {
            // 새 탭 추가
            TabPage newTab = new TabPage(tabName)
            {
                Dock = DockStyle.Fill
            };
            control.Dock = DockStyle.Fill;
            newTab.Controls.Add(control);
            tabSetting.TabPages.Add(newTab);
        }
    }
}

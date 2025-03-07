﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using JidamVision.Core;
using OpenCvSharp.Extensions;
using System.Web;
//using JidamVision.Teach;
using System.IO;
using OpenCvSharp;

namespace JidamVision
{
    public partial class CameraForm : DockContent
    {
        //# SAVE ROI#1 현재 선택된 이미지 채널 저장을 위한 변수
        eImageChannel _currentImageChannel = eImageChannel.Color;

        public CameraForm()
        {
            InitializeComponent();
        }

        //# SAVE ROI#2 GUI상에서 선택된 채널 라디오 버튼에 따른 채널 정보를 반환
        private eImageChannel GetCurrentChannel()
        {
            if (rbtnRedChannel.Checked)
            {
                return eImageChannel.Red;
            }
            else if (rbtnBlueChannel.Checked)
            {
                return eImageChannel.Blue;
            }
            else if (rbtnGreenChannel.Checked)
            {
                return eImageChannel.Green;
            }
            else if (rbtnGrayChannel.Checked)
            {
                return eImageChannel.Gray;
            }

            return eImageChannel.Color;
        }

        public void UpdateDisplay(Bitmap bitmap = null)
        {
            if (bitmap == null)
            {
                //# SAVE ROI#3 채널 정보 변수에 저장
                //참고 프로젝트에서 _currentImageChannel를 모두 찾아서, 수정할것
                _currentImageChannel = GetCurrentChannel();
                bitmap = Global.Inst.InspStage.GetBitmap(0, _currentImageChannel);
                if (bitmap == null)
                    return;
            }

            imageViewer.LoadBitmap(bitmap);
        }

        public OpenCvSharp.Mat GetDisplayImage()
        {
            return Global.Inst.InspStage.ImageSpace.GetMat(0, _currentImageChannel);
        }

        private void CameraForm_Resize(object sender, EventArgs e)
        {
            int margin = 10;

            int xPos = Location.X + this.Width - btnGrab.Width - margin;

            btnGrab.Location = new System.Drawing.Point(xPos, btnGrab.Location.Y);
            btnLive.Location = new System.Drawing.Point(xPos, btnLive.Location.Y);
            btnSetRoi.Location = new System.Drawing.Point(xPos, btnSetRoi.Location.Y);
            btnSave.Location = new System.Drawing.Point(xPos, btnSave.Location.Y);
            groupBox1.Location = new System.Drawing.Point(xPos, groupBox1.Location.Y);

            imageViewer.Width = this.Width - btnGrab.Width - margin * 2;
            imageViewer.Height = this.Height - margin * 2;

            imageViewer.Location = new System.Drawing.Point(margin, margin);
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            Global.Inst.InspStage.Grab(0);
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            Global.Inst.InspStage.LiveMode = !Global.Inst.InspStage.LiveMode;

            if (Global.Inst.InspStage.LiveMode)
                Global.Inst.InspStage.Grab(0);
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {

        }
        private void rbtnRedChannel_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void rbtnBlueChannel_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void rbtnGreenChannel_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void rbtnGrayChannel_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        /*
         #SETROI# - <<<ROI 설정 개발>>> 
        이미지 상에서 ROI(Region of Interest)를 설정하는 기능
         */
        private void btnSetRoi_Click(object sender, EventArgs e)
        {
            //#SETROI#2 ROI 모드 토글 설정
            imageViewer.RoiMode = !imageViewer.RoiMode;
            imageViewer.Invalidate();
        }

        /*
         #SAVE ROI# - <<<ROI 영역 이미지 파일 저장>>> 
        이미지 상에서 ROI 영역을 파일로 저장하여, 템플릿 매칭에서 사용
        */
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //# SAVE ROI#5 현재 채널 이미지에서, 설정된 ROI 영역을 파일로 저장
            OpenCvSharp.Mat currentImage = Global.Inst.InspStage.GetMat(0, _currentImageChannel);
            if (currentImage != null)
            {
                //현재 설정된 ROI 영역을 가져옴s
                Rectangle roiRect = imageViewer.GetRoiRect();


                //전체 이미지에서 ROI 영역만을 roiImage에 저장
                Mat roiImage = new Mat(currentImage, new Rect(roiRect.X, roiRect.Y, roiRect.Width, roiRect.Height));

                if (roiImage.Empty())
                    return;

                //현재 실행파일이 있는 경로에, 저장할 경로 만들기
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), Define.ROI_IMAGE_NAME);

                //이미지 저장
                Cv2.ImWrite(savePath, roiImage);
            }
        }

        //#MATCH PROP#14 템플릿 매칭 위치 입력 받는 함수
        public void AddRect(List<Rectangle> rectangles)
        {
            imageViewer.AddRect(rectangles);

        }


    }
}

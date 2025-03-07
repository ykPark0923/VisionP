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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using OpenCvSharp.Flann;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace JidamVision
{
    public partial class CameraForm : DockContent
    {
        public CameraForm()
        {
            InitializeComponent();
        }

        public void UpdateDisplay(Bitmap bitmap = null)
        {
            if (bitmap == null)
            {
                if (rbtnRedChannel.Checked)
                {
                    bitmap = Global.Inst.InspStage.ImageSpace.GetBitmap(0, eImageChannel.Red);
                }
                else if (rbtnBlueChannel.Checked)
                {
                    bitmap = Global.Inst.InspStage.ImageSpace.GetBitmap(0, eImageChannel.Blue);
                }
                else if (rbtnGreenChannel.Checked)
                {
                    bitmap = Global.Inst.InspStage.ImageSpace.GetBitmap(0, eImageChannel.Green);
                }
                else if (rbtnGrayChannel.Checked)
                {
                    bitmap = Global.Inst.InspStage.ImageSpace.GetBitmap(0, eImageChannel.Gray);
                }
                else
                {
                    bitmap = Global.Inst.InspStage.ImageSpace.GetBitmap(0);
                }

                if (bitmap == null)
                    return;
            }


            imageViewer.LoadBitmap(bitmap);
        }

        //카메라 채널 선택 값 반환
        public eImageChannel GetSelectedChannel()
        {
            if (rbtnRedChannel.Checked) return eImageChannel.Red;
            if (rbtnGreenChannel.Checked) return eImageChannel.Green;
            if (rbtnBlueChannel.Checked) return eImageChannel.Blue;
            if (rbtnGrayChannel.Checked) return eImageChannel.Gray;
            return eImageChannel.Color;
        }

        private void CameraForm_Resize(object sender, EventArgs e)
        {
            int margin = 10;

            int xPos = Location.X + this.Width - btnGrab.Width - margin;

            btnGrab.Location = new Point(xPos, btnGrab.Location.Y);
            btnLive.Location = new Point(xPos, btnLive.Location.Y);
            groupBox1.Location = new Point(xPos, groupBox1.Location.Y);
            //btnSetROI.Location = new Point(xPos, btnSetROI.Location.Y);

            imageViewer.Width = this.Width - btnGrab.Width - margin * 2;
            imageViewer.Height = this.Height - margin * 2;

            imageViewer.Location = new Point(margin, margin);
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

    }
}

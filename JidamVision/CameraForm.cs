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

        private void CameraForm_Resize(object sender, EventArgs e)
        {
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

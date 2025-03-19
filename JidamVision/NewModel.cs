﻿using JidamVision.Core;
using JidamVision.Setting;
using JidamVision.Teach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JidamVision
{
    public partial class NewModel : Form
    {
        public bool _saveAsMode = false;

        public NewModel(bool saveAs = false)
        {
            InitializeComponent();

            _saveAsMode = saveAs;

            if (_saveAsMode)
            {
                this.Text = "모델 다른 이름으로 저장";
                btnCreate.Text = "저장";

                Model model = Global.Inst.InspStage.CurModel;

                txtModelName.Text = model.ModelName;
                txtModelInfo.Text = model.ModelInfo;
            }
            else
            {
                this.Text = "신규 모델 생성";
                btnCreate.Text = "생성";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string modelName = txtModelName.Text.Trim();
            if (modelName == "")
            {
                MessageBox.Show("모덜 이름을 입력하세요.");
                return;
            }

            string modelDir = SettingXml.Inst.ModelDir;
            if (Directory.Exists(modelDir) == false)
            {
                MessageBox.Show("모델 저장 폴더가 존재하지 않습니다.");
                return;
            }

            string modelPath = Path.Combine(modelDir, modelName, modelName + ".xml");
            if (File.Exists(modelPath))
            {
                MessageBox.Show("이미 존재하는 모델 이름입니다.");
                return;
            }

            string saveDir = Path.Combine(modelDir, modelName);
            if (!Directory.Exists(saveDir))
                Directory.CreateDirectory(saveDir);

            string modelInfo = txtModelInfo.Text.Trim();


            if (_saveAsMode)
            {
                Global.Inst.InspStage.CurModel.CreateModel(modelPath, modelName, modelInfo);
                Global.Inst.InspStage.CurModel.Save();
            }
            else
            {
                Global.Inst.InspStage.CurModel.CreateModel(modelPath, modelName, modelInfo);
                Global.Inst.InspStage.CurModel.Save();
            }

            this.Close();
        }
    }
}

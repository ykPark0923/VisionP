using JidamVision.Core;
using JidamVision.Teach;
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
using WeifenLuo.WinFormsUI.Docking;

namespace JidamVision
{
    public partial class ModelTreeForm : DockContent
    {
        private ContextMenuStrip _contextMenu;  // Root 우클릭 메뉴
        private ContextMenuStrip _contextMenu2; // ROI 노드 우클릭 메뉴

        public ModelTreeForm()
        {
            InitializeComponent();

            // 초기 트리 노드 추가
            tvModelTree.Nodes.Add("Root");

            // Root 노드 우클릭 메뉴 (ROI 추가)
            _contextMenu = new ContextMenuStrip();
            ToolStripMenuItem addBaseRoiItem = new ToolStripMenuItem("Base", null, AddNode_Click) { Tag = "Base" };
            ToolStripMenuItem addSubRoiItem = new ToolStripMenuItem("Sub", null, AddNode_Click) { Tag = "Sub" };
            ToolStripMenuItem addIdRoiItem = new ToolStripMenuItem("ID", null, AddNode_Click) { Tag = "ID" };
            ToolStripMenuItem addBodyRoiItem = new ToolStripMenuItem("Body", null, AddNode_Click) { Tag = "Body" };
            ToolStripMenuItem addHeadRoiItem = new ToolStripMenuItem("Head", null, AddNode_Click) { Tag = "Head" };

            _contextMenu.Items.Add(addBaseRoiItem);
            _contextMenu.Items.Add(addSubRoiItem);
            _contextMenu.Items.Add(addIdRoiItem);
            _contextMenu.Items.Add(addBodyRoiItem);
            _contextMenu.Items.Add(addHeadRoiItem);

            // ROI 노드 우클릭 메뉴 (수정/삭제)
            _contextMenu2 = new ContextMenuStrip();
            ToolStripMenuItem modifyItem = new ToolStripMenuItem("Modify", null, ModifyNode_Click);
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete", null, DeleteNode_Click);

            _contextMenu2.Items.Add(modifyItem);
            _contextMenu2.Items.Add(deleteItem);
        }

        private void tvModelTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode clickedNode = tvModelTree.GetNodeAt(e.X, e.Y);
                if (clickedNode != null)
                {
                    tvModelTree.SelectedNode = clickedNode;

                    if (clickedNode.Text == "Root")
                    {
                        _contextMenu.Show(tvModelTree, e.Location); // Root 노드 우클릭 메뉴
                    }
                    else
                    {
                        _contextMenu2.Show(tvModelTree, e.Location); // ROI 노드 우클릭 메뉴
                    }
                }
            }
        }

        // ROI 추가 기능
        private void AddNode_Click(object sender, EventArgs e)
        {
            if (tvModelTree.SelectedNode != null && sender is ToolStripMenuItem menuItem)
            {
                //ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                string nodeType = menuItem.Tag?.ToString();
                InspWindowType inspType;

                switch (nodeType)
                {
                    case "Base": inspType = InspWindowType.Base; break;
                    case "Sub": inspType = InspWindowType.Sub; break;
                    case "ID": inspType = InspWindowType.ID; break;
                    case "Body": inspType = InspWindowType.Body; break;
                    case "Head": inspType = InspWindowType.Head; break;
                    default: return;
                }

                AddNewROI(inspType);
            }
        }

        // ROI 추가를 실행하는 함수
        private void AddNewROI(InspWindowType inspWindowType)
        {
            CameraForm cameraForm = MainForm.GetDockForm<CameraForm>();
            if (cameraForm != null)
            {
                cameraForm.AddRoi(inspWindowType);
            }
        }

        // 모델 전체의 ROI를 트리뷰에 업데이트
        public void UpdateDiagramEntity()
        {
            tvModelTree.Nodes.Clear();
            TreeNode rootNode = tvModelTree.Nodes.Add("Root");

            Model model = Global.Inst.InspStage.CurModel;
            List<InspWindow> windowList = model.InspWindowList;
            if (windowList.Count <= 0) return;

            foreach (InspWindow window in model.InspWindowList)
            {
                if (window == null) continue;

                string uid = window.UID;
                TreeNode node = new TreeNode(uid);
                rootNode.Nodes.Add(node);
            }

            tvModelTree.ExpandAll();
        }

        // ROI 수정 기능
        private void ModifyNode_Click(object sender, EventArgs e)
        {
            if (tvModelTree.SelectedNode != null)
            {
                string newName = ShowInputDialog("새로운 이름을 입력하세요:", tvModelTree.SelectedNode.Text);

                if (!string.IsNullOrEmpty(newName))
                {
                    tvModelTree.SelectedNode.Text = newName;
                }
            }
        }

        // 커스텀 입력창
        private string ShowInputDialog(string prompt, string defaultText)
        {
            Form inputForm = new Form();
            inputForm.Width = 300;
            inputForm.Height = 150;
            inputForm.Text = "노드 수정";

            Label label = new Label() { Left = 10, Top = 10, Text = prompt, Width = 260 };
            TextBox textBox = new TextBox() { Left = 10, Top = 35, Width = 260, Text = defaultText };
            Button okButton = new Button() { Text = "OK", Left = 70, Width = 60, Top = 70, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Cancel", Left = 150, Width = 60, Top = 70, DialogResult = DialogResult.Cancel };

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(okButton);
            inputForm.Controls.Add(cancelButton);

            inputForm.AcceptButton = okButton;
            inputForm.CancelButton = cancelButton;

            return inputForm.ShowDialog() == DialogResult.OK ? textBox.Text : defaultText;
        }

        // ROI 삭제 기능
        //********************************현재 트리폼에서만 delete됨
        private void DeleteNode_Click(object sender, EventArgs e)
        {
            if (tvModelTree.SelectedNode != null)
            {
                DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "노드 삭제",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    tvModelTree.SelectedNode.Remove();
                    //ImageViewCCtrl.RemoveRoi(_roiRect);
                }
            }
        }
    }
}
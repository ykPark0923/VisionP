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
using WeifenLuo.WinFormsUI.Docking;
using static JidamVision.Core.Define;

namespace JidamVision
{
    public partial class ModelTreeForm : DockContent
    {
        private ContextMenuStrip _contextMenu;
        public ModelTreeForm()
        {
            InitializeComponent();

            tvModelTree.Nodes.Add("Root");

            _contextMenu = new ContextMenuStrip();
            ToolStripMenuItem addBaseRoiItem = new ToolStripMenuItem("Base", null, AddNode_Click) { Tag = "Base" };
            ToolStripMenuItem addSubRoiItem = new ToolStripMenuItem("Sub", null, AddNode_Click) { Tag = "Sub" };
            ToolStripMenuItem addIdRoiItem = new ToolStripMenuItem("ID", null, AddNode_Click) { Tag = "ID" };

            _contextMenu.Items.Add(addBaseRoiItem);
            _contextMenu.Items.Add(addSubRoiItem);
            _contextMenu.Items.Add(addIdRoiItem);
        }

        private void tvModelTree_MouseDown(object sender, MouseEventArgs e)
        {
            //Root 노드에서 마우스 오른쪽 버튼 클릭 시에, 팝업 메뉴 생성
            if (e.Button == MouseButtons.Right)
            {
                TreeNode clickedNode = tvModelTree.GetNodeAt(e.X, e.Y);
                if (clickedNode != null && clickedNode.Text == "Root") ;
                {
                    tvModelTree.SelectedNode = clickedNode;
                    _contextMenu.Show(tvModelTree, e.Location);
                }
            }
        }

        private void AddNode_Click(object sender, EventArgs e)
        {
            if (tvModelTree.SelectedNode != null & sender is ToolStripMenuItem)
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                string nodeType = menuItem.Tag?.ToString();
                if (nodeType == "Base")
                {
                    AddNewROI(InspWindowType.Base);
                }
                else if (nodeType == "Sub")
                {
                    AddNewROI(InspWindowType.Sub);
                }
                else if (nodeType == "ID")
                {
                    AddNewROI(InspWindowType.ID);
                }
            }
        }

        private void AddNewROI(InspWindowType InspWindowType)
        {
            CameraForm cameraForm = MainForm.GetDockForm<CameraForm>();
            if (cameraForm != null)
            {
                cameraForm.AddRoi(InspWindowType);
            }
        }

        public void UpdateDiagramEntity()
        {
            tvModelTree.Nodes.Clear();
            TreeNode rootNode = tvModelTree.Nodes.Add("Root");

            Model model = Global.Inst.InspStage.CurModel;
            List<InspWindow> windowList = model.InspWindowList;
            if (windowList.Count <= 0) return;

            foreach(InspWindow window in model.InspWindowList)
            {
                if (window is null) continue;

                string uid = window.UID;

                TreeNode node = new TreeNode(uid);
                rootNode.Nodes.Add(node);
             }

            tvModelTree.ExpandAll();
        }
    }
}

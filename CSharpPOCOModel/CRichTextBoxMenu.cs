using System;
using System.Windows.Forms;

namespace CSharpPOCOModel
{
    /// <summary>
    /// RichTextBox上下文菜单
    /// </summary>
    public class CRichTextBoxMenu
    {
        private ContextMenuStrip richMenu = new ContextMenuStrip();

        private ToolStripMenuItem CMcopy = new ToolStripMenuItem("复制");

        private ToolStripMenuItem CMcut = new ToolStripMenuItem("剪贴");

        private ToolStripMenuItem CMdel = new ToolStripMenuItem("删除");

        private ToolStripMenuItem CMcancle = new ToolStripMenuItem("撤销");

        private ToolStripMenuItem CMpaste = new ToolStripMenuItem("粘贴");

        private ToolStripMenuItem CMselectall = new ToolStripMenuItem("全选");

        private ToolStripMenuItem CMalign = new ToolStripMenuItem("右对齐");

        private RichTextBox richTextBox;

        public CRichTextBoxMenu(RichTextBox rchTBox)
        {
            this.richTextBox = rchTBox;
            this.richTextBox.ContextMenuStrip = this.richMenu;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.richMenu.Items.Add(this.CMcopy);
            this.richMenu.Items.Add(this.CMcut);
            this.richMenu.Items.Add(this.CMdel);
            this.richMenu.Items.Add(this.CMcancle);
            this.richMenu.Items.Add(this.CMselectall);
            this.richMenu.Items.Add(this.CMalign);
            this.CMcopy.Click += new EventHandler(this.CMcopy_Click);
            this.CMcut.Click += new EventHandler(this.CMcut_Click);
            this.CMdel.Click += new EventHandler(this.CMdel_Click);
            this.CMcancle.Click += new EventHandler(this.CMcancle_Click);
            this.CMselectall.Click += new EventHandler(this.CMselectall_Click);
            this.CMalign.Click += new EventHandler(this.CMalign_Click);
            this.richMenu.Opened += new EventHandler(this.contextMenuStrip_Opened);
        }

        private void contextMenuStrip_Opened(object sender, EventArgs e)
        {
            bool flag = this.richTextBox.SelectedText.Length > 0;
            if (flag)
            {
                this.CMcopy.Enabled = true;
                this.CMcut.Enabled = true;
                this.CMdel.Enabled = true;
            }
            else
            {
                this.CMcopy.Enabled = false;
                this.CMcut.Enabled = false;
                this.CMdel.Enabled = false;
            }
            this.CMcancle.Enabled = this.richTextBox.CanUndo;
            this.CMpaste.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
            this.CMselectall.Enabled = (this.richTextBox.Text != "");
        }

        private void CMcancle_Click(object sender, EventArgs e)
        {
            bool enabled = this.CMcancle.Enabled;
            if (enabled)
            {
                this.richTextBox.Undo();
                this.richTextBox.ClearUndo();
            }
        }

        private void CMcut_Click(object sender, EventArgs e)
        {
            bool enabled = this.CMcut.Enabled;
            if (enabled)
            {
                this.richTextBox.Cut();
            }
        }

        private void CMcopy_Click(object sender, EventArgs e)
        {
            bool enabled = this.CMcopy.Enabled;
            if (enabled)
            {
                this.richTextBox.Copy();
            }
        }

        private void CMpaste_Click(object sender, EventArgs e)
        {
            bool enabled = this.CMpaste.Enabled;
            if (enabled)
            {
                this.richTextBox.Paste();
            }
        }

        private void CMdel_Click(object sender, EventArgs e)
        {
            bool enabled = this.CMdel.Enabled;
            if (enabled)
            {
                this.richTextBox.SelectedText = "";
            }
        }

        private void CMselectall_Click(object sender, EventArgs e)
        {
            this.richTextBox.Focus();
            this.richTextBox.SelectAll();
        }

        private void CMalign_Click(object sender, EventArgs e)
        {
            this.CMalign.Checked = !this.CMalign.Checked;
            bool @checked = this.CMalign.Checked;
            if (@checked)
            {
                this.richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                this.richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
    }
}

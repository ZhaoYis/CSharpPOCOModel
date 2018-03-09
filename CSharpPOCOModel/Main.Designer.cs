namespace CSharpPOCOModel
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mlab_staus_tips = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.连接到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mlist_datatable = new System.Windows.Forms.ListBox();
            this.mcb_database = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mrtb_content = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_namespace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_filepath = new System.Windows.Forms.TextBox();
            this.mbtn_selectpath = new System.Windows.Forms.Button();
            this.mbtn_tofile = new System.Windows.Forms.Button();
            this.mbtn_reset = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mlab_staus_tips});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mlab_staus_tips
            // 
            this.mlab_staus_tips.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.mlab_staus_tips.Name = "mlab_staus_tips";
            this.mlab_staus_tips.Size = new System.Drawing.Size(101, 17);
            this.mlab_staus_tips.Text = "未连接到服务器...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接到ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "设置";
            // 
            // 连接到ToolStripMenuItem
            // 
            this.连接到ToolStripMenuItem.Name = "连接到ToolStripMenuItem";
            this.连接到ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.连接到ToolStripMenuItem.Text = "连接到服务器";
            this.连接到ToolStripMenuItem.Click += new System.EventHandler(this.连接到ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作说明ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 操作说明ToolStripMenuItem
            // 
            this.操作说明ToolStripMenuItem.Name = "操作说明ToolStripMenuItem";
            this.操作说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.操作说明ToolStripMenuItem.Text = "操作说明";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于ToolStripMenuItem.Text = "关于软件";
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mlist_datatable);
            this.groupBox1.Controls.Add(this.mcb_database);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 597);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据表";
            // 
            // mlist_datatable
            // 
            this.mlist_datatable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mlist_datatable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlist_datatable.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mlist_datatable.FormattingEnabled = true;
            this.mlist_datatable.Location = new System.Drawing.Point(9, 79);
            this.mlist_datatable.Name = "mlist_datatable";
            this.mlist_datatable.ScrollAlwaysVisible = true;
            this.mlist_datatable.Size = new System.Drawing.Size(203, 509);
            this.mlist_datatable.TabIndex = 2;
            this.mlist_datatable.SelectedIndexChanged += new System.EventHandler(this.mlist_datatable_SelectedIndexChanged);
            // 
            // mcb_database
            // 
            this.mcb_database.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcb_database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcb_database.FormattingEnabled = true;
            this.mcb_database.Location = new System.Drawing.Point(66, 27);
            this.mcb_database.Name = "mcb_database";
            this.mcb_database.Size = new System.Drawing.Size(146, 20);
            this.mcb_database.TabIndex = 1;
            this.mcb_database.DropDownClosed += new System.EventHandler(this.mcb_database_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mbtn_reset);
            this.groupBox2.Controls.Add(this.mbtn_tofile);
            this.groupBox2.Controls.Add(this.mbtn_selectpath);
            this.groupBox2.Controls.Add(this.mtb_filepath);
            this.groupBox2.Controls.Add(this.mtb_namespace);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(243, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.mrtb_content);
            this.groupBox3.Location = new System.Drawing.Point(243, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 447);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实体类";
            // 
            // mrtb_content
            // 
            this.mrtb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mrtb_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrtb_content.Location = new System.Drawing.Point(3, 17);
            this.mrtb_content.Name = "mrtb_content";
            this.mrtb_content.ReadOnly = true;
            this.mrtb_content.Size = new System.Drawing.Size(741, 427);
            this.mrtb_content.TabIndex = 0;
            this.mrtb_content.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择数据表：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "命名空间：";
            // 
            // mtb_namespace
            // 
            this.mtb_namespace.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtb_namespace.Location = new System.Drawing.Point(75, 30);
            this.mtb_namespace.Name = "mtb_namespace";
            this.mtb_namespace.Size = new System.Drawing.Size(183, 23);
            this.mtb_namespace.TabIndex = 1;
            this.mtb_namespace.Text = "App.Entity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "文件保存路径：";
            // 
            // mtb_filepath
            // 
            this.mtb_filepath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtb_filepath.Location = new System.Drawing.Point(359, 30);
            this.mtb_filepath.Name = "mtb_filepath";
            this.mtb_filepath.ReadOnly = true;
            this.mtb_filepath.Size = new System.Drawing.Size(287, 23);
            this.mtb_filepath.TabIndex = 1;
            // 
            // mbtn_selectpath
            // 
            this.mbtn_selectpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtn_selectpath.Location = new System.Drawing.Point(652, 30);
            this.mbtn_selectpath.Name = "mbtn_selectpath";
            this.mbtn_selectpath.Size = new System.Drawing.Size(81, 23);
            this.mbtn_selectpath.TabIndex = 2;
            this.mbtn_selectpath.Text = "选择路径..";
            this.mbtn_selectpath.UseVisualStyleBackColor = true;
            this.mbtn_selectpath.Click += new System.EventHandler(this.mbtn_selectpath_Click);
            // 
            // mbtn_tofile
            // 
            this.mbtn_tofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtn_tofile.Location = new System.Drawing.Point(13, 102);
            this.mbtn_tofile.Name = "mbtn_tofile";
            this.mbtn_tofile.Size = new System.Drawing.Size(92, 35);
            this.mbtn_tofile.TabIndex = 3;
            this.mbtn_tofile.Text = "导出到文件";
            this.mbtn_tofile.UseVisualStyleBackColor = true;
            this.mbtn_tofile.Click += new System.EventHandler(this.mbtn_tofile_Click);
            // 
            // mbtn_reset
            // 
            this.mbtn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtn_reset.Location = new System.Drawing.Point(111, 102);
            this.mbtn_reset.Name = "mbtn_reset";
            this.mbtn_reset.Size = new System.Drawing.Size(92, 35);
            this.mbtn_reset.TabIndex = 3;
            this.mbtn_reset.Text = "重置";
            this.mbtn_reset.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mlab_staus_tips;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 连接到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作说明ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox mrtb_content;
        private System.Windows.Forms.ComboBox mcb_database;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox mlist_datatable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mtb_namespace;
        private System.Windows.Forms.TextBox mtb_filepath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mbtn_selectpath;
        private System.Windows.Forms.Button mbtn_tofile;
        private System.Windows.Forms.Button mbtn_reset;
    }
}
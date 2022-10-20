namespace TaskManager
{
    partial class TaskManager
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
            this.components = new System.ComponentModel.Container();
            this.CpuBar = new System.Windows.Forms.ProgressBar();
            this.RamBar = new System.Windows.Forms.ProgressBar();
            this.ProMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.PerformanceTimer = new System.Windows.Forms.Timer(this.components);
            this.BarTimer = new System.Windows.Forms.Timer(this.components);
            this.ProcessesPage = new System.Windows.Forms.TabPage();
            this.ProcessGridView = new System.Windows.Forms.DataGridView();
            this.PerformancePage = new System.Windows.Forms.TabPage();
            this.MainList = new System.Windows.Forms.ListBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProMenuStrip.SuspendLayout();
            this.SerMenuStrip.SuspendLayout();
            this.ProcessesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            this.PerformancePage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CpuBar
            // 
            this.CpuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CpuBar.Location = new System.Drawing.Point(12, 360);
            this.CpuBar.Name = "CpuBar";
            this.CpuBar.Size = new System.Drawing.Size(913, 23);
            this.CpuBar.TabIndex = 3;
            // 
            // RamBar
            // 
            this.RamBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RamBar.Location = new System.Drawing.Point(13, 390);
            this.RamBar.Name = "RamBar";
            this.RamBar.Size = new System.Drawing.Size(912, 23);
            this.RamBar.TabIndex = 4;
            // 
            // ProMenuStrip
            // 
            this.ProMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.ProMenuStrip.Name = "ProMenuStrip";
            this.ProMenuStrip.Size = new System.Drawing.Size(192, 70);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.killToolStripMenuItem.Text = "Снять задачу";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.locationToolStripMenuItem.Text = "Месторасположение";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.propertiesToolStripMenuItem.Text = "Подробно";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // SerMenuStrip
            // 
            this.SerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.SerMenuStrip.Name = "SerMenuStrip";
            this.SerMenuStrip.Size = new System.Drawing.Size(114, 70);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Interval = 5000;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // PerformanceTimer
            // 
            this.PerformanceTimer.Enabled = true;
            this.PerformanceTimer.Interval = 1000;
            this.PerformanceTimer.Tick += new System.EventHandler(this.PerformanceTimer_Tick);
            // 
            // BarTimer
            // 
            this.BarTimer.Enabled = true;
            this.BarTimer.Interval = 10;
            this.BarTimer.Tick += new System.EventHandler(this.BarTimer_Tick);
            // 
            // ProcessesPage
            // 
            this.ProcessesPage.Controls.Add(this.ProcessGridView);
            this.ProcessesPage.Location = new System.Drawing.Point(4, 22);
            this.ProcessesPage.Name = "ProcessesPage";
            this.ProcessesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessesPage.Size = new System.Drawing.Size(926, 325);
            this.ProcessesPage.TabIndex = 1;
            this.ProcessesPage.Text = "Processes";
            this.ProcessesPage.UseVisualStyleBackColor = true;
            // 
            // ProcessGridView
            // 
            this.ProcessGridView.AllowUserToAddRows = false;
            this.ProcessGridView.AllowUserToDeleteRows = false;
            this.ProcessGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProcessGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGridView.ContextMenuStrip = this.ProMenuStrip;
            this.ProcessGridView.Location = new System.Drawing.Point(3, 3);
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessGridView.Size = new System.Drawing.Size(920, 319);
            this.ProcessGridView.TabIndex = 0;
            // 
            // PerformancePage
            // 
            this.PerformancePage.Controls.Add(this.MainList);
            this.PerformancePage.Location = new System.Drawing.Point(4, 22);
            this.PerformancePage.Name = "PerformancePage";
            this.PerformancePage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformancePage.Size = new System.Drawing.Size(926, 325);
            this.PerformancePage.TabIndex = 0;
            this.PerformancePage.Text = "Performance";
            this.PerformancePage.UseVisualStyleBackColor = true;
            // 
            // MainList
            // 
            this.MainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(0, 0);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(926, 329);
            this.MainList.TabIndex = 1;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.PerformancePage);
            this.MainTabControl.Controls.Add(this.ProcessesPage);
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(934, 351);
            this.MainTabControl.TabIndex = 7;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.CpuBar);
            this.Name = "TaskManager";
            this.Text = "Диспетчер задач";
            this.ProMenuStrip.ResumeLayout(false);
            this.SerMenuStrip.ResumeLayout(false);
            this.ProcessesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            this.PerformancePage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar CpuBar;
        private System.Windows.Forms.ProgressBar RamBar;
        private System.Windows.Forms.ContextMenuStrip ProMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Timer PerformanceTimer;
        private System.Windows.Forms.Timer BarTimer;
        private System.Windows.Forms.TabPage ProcessesPage;
        public System.Windows.Forms.DataGridView ProcessGridView;
        private System.Windows.Forms.TabPage PerformancePage;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.TabControl MainTabControl;
    }
}


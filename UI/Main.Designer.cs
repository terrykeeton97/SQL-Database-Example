namespace SQL_Application
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.connectionLabel = new System.Windows.Forms.ToolStripLabel();
            this.connectionStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.connectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectItem,
            this.disconnectItem,
            this.queryItem,
            this.refreshItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1142, 552);
            this.dataGrid.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 551);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1142, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // connectionLabel
            // 
            this.connectionLabel.BackColor = System.Drawing.Color.Red;
            this.connectionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(96, 22);
            this.connectionLabel.Text = "DISCONNECTED";
            // 
            // connectionStatusTimer
            // 
            this.connectionStatusTimer.Enabled = true;
            this.connectionStatusTimer.Interval = 500;
            this.connectionStatusTimer.Tick += new System.EventHandler(this.connectionStatusTimer_Tick);
            // 
            // connectItem
            // 
            this.connectItem.Image = global::SQL_Application.Properties.Resources.Fatcow_Farm_Fresh_Disconnect_32;
            this.connectItem.Name = "connectItem";
            this.connectItem.Size = new System.Drawing.Size(79, 20);
            this.connectItem.Text = "Connect";
            this.connectItem.Click += new System.EventHandler(this.connectItem_Click);
            // 
            // disconnectItem
            // 
            this.disconnectItem.Enabled = false;
            this.disconnectItem.Image = global::SQL_Application.Properties.Resources.Led24_de_Led_Disconnect_16;
            this.disconnectItem.Name = "disconnectItem";
            this.disconnectItem.Size = new System.Drawing.Size(95, 20);
            this.disconnectItem.Text = "Disconnect";
            this.disconnectItem.Click += new System.EventHandler(this.disconnectItem_Click);
            // 
            // queryItem
            // 
            this.queryItem.Enabled = false;
            this.queryItem.Image = global::SQL_Application.Properties.Resources.Blackvariant_Button_Ui_Microsoft_Office_Apps_Microsoft_Query_64;
            this.queryItem.Name = "queryItem";
            this.queryItem.Size = new System.Drawing.Size(67, 20);
            this.queryItem.Text = "Query";
            this.queryItem.Click += new System.EventHandler(this.queryItem_Click);
            // 
            // refreshItem
            // 
            this.refreshItem.Enabled = false;
            this.refreshItem.Image = global::SQL_Application.Properties.Resources.Double_J_Design_Ravenna_3d_Reload_64;
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(74, 20);
            this.refreshItem.Text = "Refresh";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 576);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectItem;
        private System.Windows.Forms.ToolStripMenuItem queryItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel connectionLabel;
        private System.Windows.Forms.Timer connectionStatusTimer;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
    }
}


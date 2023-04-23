namespace SQL_Application.UI
{
    partial class Query
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
            this.queryTextBox = new System.Windows.Forms.RichTextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.queryTemplateComboBox = new System.Windows.Forms.ComboBox();
            this.templateLabel = new System.Windows.Forms.Label();
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(12, 23);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(416, 126);
            this.queryTextBox.TabIndex = 0;
            this.queryTextBox.Text = "";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryLabel.Location = new System.Drawing.Point(12, 7);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(40, 13);
            this.queryLabel.TabIndex = 1;
            this.queryLabel.Text = "Query:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(353, 181);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // queryTemplateComboBox
            // 
            this.queryTemplateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryTemplateComboBox.FormattingEnabled = true;
            this.queryTemplateComboBox.Items.AddRange(new object[] {
            "SELECT TOP 1000 {table}",
            "DELETE FROM {table}"});
            this.queryTemplateComboBox.Location = new System.Drawing.Point(85, 183);
            this.queryTemplateComboBox.Name = "queryTemplateComboBox";
            this.queryTemplateComboBox.Size = new System.Drawing.Size(163, 21);
            this.queryTemplateComboBox.TabIndex = 3;
            this.queryTemplateComboBox.SelectedIndexChanged += new System.EventHandler(this.queryTemplateComboBox_SelectedIndexChanged);
            // 
            // templateLabel
            // 
            this.templateLabel.AutoSize = true;
            this.templateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateLabel.Location = new System.Drawing.Point(14, 186);
            this.templateLabel.Name = "templateLabel";
            this.templateLabel.Size = new System.Drawing.Size(62, 13);
            this.templateLabel.TabIndex = 4;
            this.templateLabel.Text = "Templates:";
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(85, 155);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(343, 22);
            this.parametersTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parameters:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(272, 181);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 210);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.templateLabel);
            this.Controls.Add(this.queryTemplateComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.queryTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Query";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Query";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Query_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox queryTextBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox queryTemplateComboBox;
        private System.Windows.Forms.Label templateLabel;
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
    }
}
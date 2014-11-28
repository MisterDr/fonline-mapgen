﻿namespace fonline_mapgen
{
    partial class frmPerformance
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRendering = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkCache = new System.Windows.Forms.CheckBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRenderer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendering";
            // 
            // cmbRendering
            // 
            this.cmbRendering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRendering.FormattingEnabled = true;
            this.cmbRendering.Items.AddRange(new object[] {
            "Best Performance",
            "Best Rendering Quality"});
            this.cmbRendering.Location = new System.Drawing.Point(108, 33);
            this.cmbRendering.Name = "cmbRendering";
            this.cmbRendering.Size = new System.Drawing.Size(232, 21);
            this.cmbRendering.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkCache
            // 
            this.chkCache.AutoSize = true;
            this.chkCache.Location = new System.Drawing.Point(12, 60);
            this.chkCache.Name = "chkCache";
            this.chkCache.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCache.Size = new System.Drawing.Size(111, 17);
            this.chkCache.TabIndex = 4;
            this.chkCache.Text = "Cache Resources";
            this.chkCache.UseVisualStyleBackColor = true;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Location = new System.Drawing.Point(12, 83);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(148, 29);
            this.btnClearCache.TabIndex = 5;
            this.btnClearCache.Text = "Clear Resource Cache";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Render API";
            // 
            // cmbRenderer
            // 
            this.cmbRenderer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenderer.FormattingEnabled = true;
            this.cmbRenderer.Items.AddRange(new object[] {
            "OpenGL",
            "GDI+"});
            this.cmbRenderer.Location = new System.Drawing.Point(108, 6);
            this.cmbRenderer.Name = "cmbRenderer";
            this.cmbRenderer.Size = new System.Drawing.Size(232, 21);
            this.cmbRenderer.TabIndex = 7;
            // 
            // frmPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 158);
            this.Controls.Add(this.cmbRenderer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearCache);
            this.Controls.Add(this.chkCache);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbRendering);
            this.Controls.Add(this.label1);
            this.Name = "frmPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRendering;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkCache;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRenderer;
    }
}
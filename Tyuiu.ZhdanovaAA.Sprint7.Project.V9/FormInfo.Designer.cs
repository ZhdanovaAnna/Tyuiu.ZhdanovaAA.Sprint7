﻿namespace WindowsFormsApp1
{
    partial class FormInfo_ZAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo_ZAA));
            this.panelPhoto_ZAA = new System.Windows.Forms.Panel();
            this.splitterInfo_ZAA = new System.Windows.Forms.Splitter();
            this.panelInfo_ZAA = new System.Windows.Forms.Panel();
            this.labelInfo_ZAA = new System.Windows.Forms.Label();
            this.panelInfo_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhoto_ZAA
            // 
            this.panelPhoto_ZAA.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Photo_ZAA;
            this.panelPhoto_ZAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPhoto_ZAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPhoto_ZAA.Location = new System.Drawing.Point(0, 0);
            this.panelPhoto_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPhoto_ZAA.Name = "panelPhoto_ZAA";
            this.panelPhoto_ZAA.Size = new System.Drawing.Size(203, 265);
            this.panelPhoto_ZAA.TabIndex = 0;
            // 
            // splitterInfo_ZAA
            // 
            this.splitterInfo_ZAA.Location = new System.Drawing.Point(203, 0);
            this.splitterInfo_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitterInfo_ZAA.Name = "splitterInfo_ZAA";
            this.splitterInfo_ZAA.Size = new System.Drawing.Size(4, 265);
            this.splitterInfo_ZAA.TabIndex = 1;
            this.splitterInfo_ZAA.TabStop = false;
            // 
            // panelInfo_ZAA
            // 
            this.panelInfo_ZAA.Controls.Add(this.labelInfo_ZAA);
            this.panelInfo_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInfo_ZAA.Location = new System.Drawing.Point(207, 0);
            this.panelInfo_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo_ZAA.Name = "panelInfo_ZAA";
            this.panelInfo_ZAA.Size = new System.Drawing.Size(516, 265);
            this.panelInfo_ZAA.TabIndex = 2;
            // 
            // labelInfo_ZAA
            // 
            this.labelInfo_ZAA.AutoSize = true;
            this.labelInfo_ZAA.Location = new System.Drawing.Point(9, 16);
            this.labelInfo_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_ZAA.Name = "labelInfo_ZAA";
            this.labelInfo_ZAA.Size = new System.Drawing.Size(468, 180);
            this.labelInfo_ZAA.TabIndex = 0;
            this.labelInfo_ZAA.Text = resources.GetString("labelInfo_ZAA.Text");
            // 
            // FormInfo_ZAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 265);
            this.Controls.Add(this.panelInfo_ZAA);
            this.Controls.Add(this.splitterInfo_ZAA);
            this.Controls.Add(this.panelPhoto_ZAA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(805, 312);
            this.MinimumSize = new System.Drawing.Size(741, 312);
            this.Name = "FormInfo_ZAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panelInfo_ZAA.ResumeLayout(false);
            this.panelInfo_ZAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto_ZAA;
        private System.Windows.Forms.Splitter splitterInfo_ZAA;
        private System.Windows.Forms.Panel panelInfo_ZAA;
        private System.Windows.Forms.Label labelInfo_ZAA;
    }
}
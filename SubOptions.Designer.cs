namespace BLU3Sploit
{
    partial class SubOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubOptions));
            this.TopmostBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TopmostBTN
            // 
            this.TopmostBTN.Animated = true;
            this.TopmostBTN.BackColor = System.Drawing.Color.Transparent;
            this.TopmostBTN.BorderRadius = 5;
            this.TopmostBTN.CheckedState.Parent = this.TopmostBTN;
            this.TopmostBTN.CustomBorderColor = System.Drawing.Color.Transparent;
            this.TopmostBTN.CustomImages.Parent = this.TopmostBTN;
            this.TopmostBTN.FillColor = System.Drawing.Color.DimGray;
            this.TopmostBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.TopmostBTN.ForeColor = System.Drawing.Color.White;
            this.TopmostBTN.HoverState.Parent = this.TopmostBTN;
            this.TopmostBTN.Location = new System.Drawing.Point(12, 12);
            this.TopmostBTN.Name = "TopmostBTN";
            this.TopmostBTN.ShadowDecoration.Parent = this.TopmostBTN;
            this.TopmostBTN.Size = new System.Drawing.Size(140, 25);
            this.TopmostBTN.TabIndex = 37;
            this.TopmostBTN.Text = "Topmost";
            this.TopmostBTN.Click += new System.EventHandler(this.TopmostBTN_Click);
            // 
            // SubOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(163, 284);
            this.Controls.Add(this.TopmostBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubOptions";
            this.Text = "SubOptions";
            this.Load += new System.EventHandler(this.SubOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button TopmostBTN;
    }
}
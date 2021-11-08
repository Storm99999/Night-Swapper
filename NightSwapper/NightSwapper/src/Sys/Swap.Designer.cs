
namespace NightSwapper.src.Sys
{
    partial class Swap
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
            this.swapUC1 = new NightSwapper.src.Sys.UserControls.SwapUC();
            this.SuspendLayout();
            // 
            // swapUC1
            // 
            this.swapUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.swapUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapUC1.Location = new System.Drawing.Point(0, 0);
            this.swapUC1.Name = "swapUC1";
            this.swapUC1.Size = new System.Drawing.Size(399, 252);
            this.swapUC1.TabIndex = 0;
            this.swapUC1.Load += new System.EventHandler(this.swapUC1_Load);
            // 
            // Swap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.swapUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Swap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.SwapUC swapUC1;
    }
}
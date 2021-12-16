
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneAndOnlyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneAndOnlyButton
            // 
            this.oneAndOnlyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneAndOnlyButton.Location = new System.Drawing.Point(0, 0);
            this.oneAndOnlyButton.Name = "oneAndOnlyButton";
            this.oneAndOnlyButton.Size = new System.Drawing.Size(482, 453);
            this.oneAndOnlyButton.TabIndex = 0;
            this.oneAndOnlyButton.Text = "уменьшить";
            this.oneAndOnlyButton.UseVisualStyleBackColor = true;
            this.oneAndOnlyButton.Click += new System.EventHandler(this.oneAndOnlyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.oneAndOnlyButton);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oneAndOnlyButton;
    }
}


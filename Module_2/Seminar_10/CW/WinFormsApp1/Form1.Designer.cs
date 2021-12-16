
namespace WinFormsApp1
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
            this.myButton = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(218, 127);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(352, 138);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "тыкни ну";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(334, 306);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(135, 20);
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "Член ряда Пелла: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.Label myLabel;
    }
}


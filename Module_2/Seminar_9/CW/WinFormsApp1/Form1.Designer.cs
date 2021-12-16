
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
            this.myFirstLabel = new System.Windows.Forms.Label();
            this.changeTextButton = new System.Windows.Forms.Button();
            this.pressMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myFirstLabel
            // 
            this.myFirstLabel.AutoSize = true;
            this.myFirstLabel.Location = new System.Drawing.Point(81, 204);
            this.myFirstLabel.Name = "myFirstLabel";
            this.myFirstLabel.Size = new System.Drawing.Size(106, 20);
            this.myFirstLabel.TabIndex = 0;
            this.myFirstLabel.Text = "Мой лейбл=))";
            // 
            // changeTextButton
            // 
            this.changeTextButton.Location = new System.Drawing.Point(518, 204);
            this.changeTextButton.Name = "changeTextButton";
            this.changeTextButton.Size = new System.Drawing.Size(180, 29);
            this.changeTextButton.TabIndex = 1;
            this.changeTextButton.Text = "Поменять текст";
            this.changeTextButton.UseVisualStyleBackColor = true;
            this.changeTextButton.Click += new System.EventHandler(this.changeTextButton_Click);
            // 
            // pressMeButton
            // 
            this.pressMeButton.Location = new System.Drawing.Point(518, 267);
            this.pressMeButton.Name = "pressMeButton";
            this.pressMeButton.Size = new System.Drawing.Size(94, 29);
            this.pressMeButton.TabIndex = 2;
            this.pressMeButton.Text = "нажми!";
            this.pressMeButton.UseVisualStyleBackColor = true;
            this.pressMeButton.Visible = false;
            this.pressMeButton.Click += new System.EventHandler(this.pressMeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pressMeButton);
            this.Controls.Add(this.changeTextButton);
            this.Controls.Add(this.myFirstLabel);
            this.Name = "Form1";
            this.Text = "Моя первая форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myFirstLabel;
        private System.Windows.Forms.Button changeTextButton;
        private System.Windows.Forms.Button pressMeButton;
    }
}


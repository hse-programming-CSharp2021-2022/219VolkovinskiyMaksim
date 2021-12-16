
namespace WinFormsApp2
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
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.readCollectionButton = new System.Windows.Forms.Button();
            this.showResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(267, 138);
            this.myTextBox.Multiline = true;
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(233, 158);
            this.myTextBox.TabIndex = 0;
            // 
            // readCollectionButton
            // 
            this.readCollectionButton.Location = new System.Drawing.Point(294, 71);
            this.readCollectionButton.Name = "readCollectionButton";
            this.readCollectionButton.Size = new System.Drawing.Size(186, 61);
            this.readCollectionButton.TabIndex = 1;
            this.readCollectionButton.Text = "читать? а зачем";
            this.readCollectionButton.UseVisualStyleBackColor = true;
            this.readCollectionButton.Click += new System.EventHandler(this.readCollectionButton_Click);
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(294, 302);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(186, 70);
            this.showResultButton.TabIndex = 2;
            this.showResultButton.Text = "показать стиль";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.readCollectionButton);
            this.Controls.Add(this.myTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button readCollectionButton;
        private System.Windows.Forms.Button showResultButton;
    }
}


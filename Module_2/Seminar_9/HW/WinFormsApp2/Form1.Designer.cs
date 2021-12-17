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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.showInitialArrButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(134, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 264);
            this.listBox1.TabIndex = 0;
            // 
            // showInitialArrButton
            // 
            this.showInitialArrButton.Location = new System.Drawing.Point(134, 12);
            this.showInitialArrButton.Name = "showInitialArrButton";
            this.showInitialArrButton.Size = new System.Drawing.Size(508, 49);
            this.showInitialArrButton.TabIndex = 1;
            this.showInitialArrButton.Text = "Вывести изначальный массив";
            this.showInitialArrButton.UseVisualStyleBackColor = true;
            this.showInitialArrButton.Click += new System.EventHandler(this.showInitialArrButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(134, 369);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(508, 51);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить элемент из списка";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showInitialArrButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button showInitialArrButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

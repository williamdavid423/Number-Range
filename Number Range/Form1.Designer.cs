namespace Number_Range
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startNum = new System.Windows.Forms.Label();
            this.endNum = new System.Windows.Forms.Label();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.valuesButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(95, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(313, 44);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fun With Loops!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startNum
            // 
            this.startNum.AutoSize = true;
            this.startNum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startNum.Location = new System.Drawing.Point(70, 144);
            this.startNum.Name = "startNum";
            this.startNum.Size = new System.Drawing.Size(252, 24);
            this.startNum.TabIndex = 1;
            this.startNum.Text = "Enter a Starting Number";
            this.startNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endNum
            // 
            this.endNum.AutoSize = true;
            this.endNum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endNum.Location = new System.Drawing.Point(70, 226);
            this.endNum.Name = "endNum";
            this.endNum.Size = new System.Drawing.Size(244, 24);
            this.endNum.TabIndex = 2;
            this.endNum.Text = "Enter a Ending Number";
            this.endNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(338, 147);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTextBox.TabIndex = 3;
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(338, 229);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTextBox.TabIndex = 4;
            // 
            // valuesButton
            // 
            this.valuesButton.Location = new System.Drawing.Point(338, 286);
            this.valuesButton.Name = "valuesButton";
            this.valuesButton.Size = new System.Drawing.Size(86, 23);
            this.valuesButton.TabIndex = 5;
            this.valuesButton.Text = "Show Values";
            this.valuesButton.UseVisualStyleBackColor = true;
            this.valuesButton.Click += new System.EventHandler(this.ValuesButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(103, 365);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.valuesButton);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.endNum);
            this.Controls.Add(this.startNum);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startNum;
        private System.Windows.Forms.Label endNum;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.Button valuesButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


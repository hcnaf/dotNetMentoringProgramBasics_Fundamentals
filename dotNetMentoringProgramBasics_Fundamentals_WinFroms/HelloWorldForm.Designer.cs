using HelloWorldLib;

namespace dotNetMentoringProgramBasics_Fundamentals_WinFroms
{
    partial class HelloWorldForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.submitNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.nameTextBox.Location = new System.Drawing.Point(281, 208);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(336, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.PlaceholderText = "Please, enter a name";
            // 
            // button1
            // 
            this.submitNameButton.Location = new System.Drawing.Point(404, 258);
            this.submitNameButton.Name = "submitButton";
            this.submitNameButton.Size = new System.Drawing.Size(94, 29);
            this.submitNameButton.TabIndex = 1;
            this.submitNameButton.Text = "Say Hello!";
            this.submitNameButton.UseVisualStyleBackColor = true;
            this.submitNameButton.Click += (sender, e) => MessageBox.Show(HelloWorldHelper.SayHello(this.nameTextBox.Text));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.submitNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Button submitNameButton;
    }
}
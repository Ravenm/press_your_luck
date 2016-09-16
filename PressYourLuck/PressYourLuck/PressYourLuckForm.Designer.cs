namespace PressYourLuck
{
    partial class PressYourLuckForm
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
            this.GameStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameStart
            // 
            this.GameStart.Location = new System.Drawing.Point(728, 495);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(75, 23);
            this.GameStart.TabIndex = 0;
            this.GameStart.Text = "StartGame";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // PressYourLuckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 530);
            this.Controls.Add(this.GameStart);
            this.Name = "PressYourLuckForm";
            this.Text = "Press You Luck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStart;
    }
}


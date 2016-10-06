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
            this.SpinBtnPlayer1 = new System.Windows.Forms.Button();
            this.StopBtnPlayer1 = new System.Windows.Forms.Button();
            this.BuzzPlayer1 = new System.Windows.Forms.Button();
            this.BuzzPlayer2 = new System.Windows.Forms.Button();
            this.SpinPlayer1 = new System.Windows.Forms.GroupBox();
            this.Player1 = new System.Windows.Forms.GroupBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopBtnPlayer2 = new System.Windows.Forms.Button();
            this.SpinBtnPlayer2 = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.InstructionBox = new System.Windows.Forms.GroupBox();
            this.Instruction = new System.Windows.Forms.TextBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.QuitGameBtn = new System.Windows.Forms.Button();
            this.SpinPlayer1.SuspendLayout();
            this.Player1.SuspendLayout();
            this.Player2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Question.SuspendLayout();
            this.InstructionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameStart
            // 
            this.GameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStart.Location = new System.Drawing.Point(872, 39);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(160, 87);
            this.GameStart.TabIndex = 0;
            this.GameStart.Text = "StartGame";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // SpinBtnPlayer1
            // 
            this.SpinBtnPlayer1.Location = new System.Drawing.Point(20, 27);
            this.SpinBtnPlayer1.Name = "SpinBtnPlayer1";
            this.SpinBtnPlayer1.Size = new System.Drawing.Size(75, 23);
            this.SpinBtnPlayer1.TabIndex = 1;
            this.SpinBtnPlayer1.Text = "Spin";
            this.SpinBtnPlayer1.UseVisualStyleBackColor = true;
            this.SpinBtnPlayer1.Click += new System.EventHandler(this.SpinBtnPlayer1_Click);
            // 
            // StopBtnPlayer1
            // 
            this.StopBtnPlayer1.Location = new System.Drawing.Point(105, 27);
            this.StopBtnPlayer1.Name = "StopBtnPlayer1";
            this.StopBtnPlayer1.Size = new System.Drawing.Size(75, 23);
            this.StopBtnPlayer1.TabIndex = 2;
            this.StopBtnPlayer1.Text = "Stop";
            this.StopBtnPlayer1.UseVisualStyleBackColor = true;
            this.StopBtnPlayer1.Click += new System.EventHandler(this.StopBtnPlayer1_Click);
            // 
            // BuzzPlayer1
            // 
            this.BuzzPlayer1.Location = new System.Drawing.Point(62, 19);
            this.BuzzPlayer1.Name = "BuzzPlayer1";
            this.BuzzPlayer1.Size = new System.Drawing.Size(75, 23);
            this.BuzzPlayer1.TabIndex = 3;
            this.BuzzPlayer1.Text = "Buzz In";
            this.BuzzPlayer1.UseVisualStyleBackColor = true;
            this.BuzzPlayer1.Click += new System.EventHandler(this.BuzzPlayer1_Click);
            // 
            // BuzzPlayer2
            // 
            this.BuzzPlayer2.Location = new System.Drawing.Point(62, 37);
            this.BuzzPlayer2.Name = "BuzzPlayer2";
            this.BuzzPlayer2.Size = new System.Drawing.Size(75, 23);
            this.BuzzPlayer2.TabIndex = 4;
            this.BuzzPlayer2.Text = "Buzz In";
            this.BuzzPlayer2.UseVisualStyleBackColor = true;
            this.BuzzPlayer2.Click += new System.EventHandler(this.BuzzPlayer2_Click);
            // 
            // SpinPlayer1
            // 
            this.SpinPlayer1.Controls.Add(this.StopBtnPlayer1);
            this.SpinPlayer1.Controls.Add(this.SpinBtnPlayer1);
            this.SpinPlayer1.Location = new System.Drawing.Point(0, 57);
            this.SpinPlayer1.Name = "SpinPlayer1";
            this.SpinPlayer1.Size = new System.Drawing.Size(200, 80);
            this.SpinPlayer1.TabIndex = 5;
            this.SpinPlayer1.TabStop = false;
            this.SpinPlayer1.Text = "Prize Wheel";
            // 
            // Player1
            // 
            this.Player1.Controls.Add(this.BuzzPlayer1);
            this.Player1.Controls.Add(this.SpinPlayer1);
            this.Player1.Location = new System.Drawing.Point(853, 284);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(200, 137);
            this.Player1.TabIndex = 6;
            this.Player1.TabStop = false;
            this.Player1.Text = "Player 1";
            // 
            // Player2
            // 
            this.Player2.Controls.Add(this.groupBox1);
            this.Player2.Controls.Add(this.BuzzPlayer2);
            this.Player2.Location = new System.Drawing.Point(853, 427);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(200, 151);
            this.Player2.TabIndex = 7;
            this.Player2.TabStop = false;
            this.Player2.Text = "Player 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopBtnPlayer2);
            this.groupBox1.Controls.Add(this.SpinBtnPlayer2);
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prize Wheel";
            // 
            // StopBtnPlayer2
            // 
            this.StopBtnPlayer2.Location = new System.Drawing.Point(105, 27);
            this.StopBtnPlayer2.Name = "StopBtnPlayer2";
            this.StopBtnPlayer2.Size = new System.Drawing.Size(75, 23);
            this.StopBtnPlayer2.TabIndex = 2;
            this.StopBtnPlayer2.Text = "Stop";
            this.StopBtnPlayer2.UseVisualStyleBackColor = true;
            this.StopBtnPlayer2.Click += new System.EventHandler(this.StopBtnPlayer2_Click);
            // 
            // SpinBtnPlayer2
            // 
            this.SpinBtnPlayer2.Location = new System.Drawing.Point(20, 27);
            this.SpinBtnPlayer2.Name = "SpinBtnPlayer2";
            this.SpinBtnPlayer2.Size = new System.Drawing.Size(75, 23);
            this.SpinBtnPlayer2.TabIndex = 1;
            this.SpinBtnPlayer2.Text = "Spin";
            this.SpinBtnPlayer2.UseVisualStyleBackColor = true;
            this.SpinBtnPlayer2.Click += new System.EventHandler(this.SpinBtnPlayer2_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(40, 44);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(689, 20);
            this.AnswerBox.TabIndex = 8;
            this.AnswerBox.TextChanged += new System.EventHandler(this.AnswerBox_TextChanged);
            // 
            // QuestionBox
            // 
            this.QuestionBox.AutoSize = true;
            this.QuestionBox.Location = new System.Drawing.Point(37, 28);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(0, 13);
            this.QuestionBox.TabIndex = 9;
            // 
            // Question
            // 
            this.Question.Controls.Add(this.ResultLabel);
            this.Question.Controls.Add(this.NextBtn);
            this.Question.Controls.Add(this.SubmitBtn);
            this.Question.Controls.Add(this.QuestionBox);
            this.Question.Controls.Add(this.AnswerBox);
            this.Question.Location = new System.Drawing.Point(12, 478);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(834, 100);
            this.Question.TabIndex = 10;
            this.Question.TabStop = false;
            this.Question.Text = "Question";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(37, 72);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 12;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(753, 71);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 11;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(753, 41);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // InstructionBox
            // 
            this.InstructionBox.Controls.Add(this.Instruction);
            this.InstructionBox.Location = new System.Drawing.Point(12, 584);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(942, 116);
            this.InstructionBox.TabIndex = 11;
            this.InstructionBox.TabStop = false;
            this.InstructionBox.Text = "Instruction";
            // 
            // Instruction
            // 
            this.Instruction.Location = new System.Drawing.Point(7, 19);
            this.Instruction.Multiline = true;
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            this.Instruction.Size = new System.Drawing.Size(929, 91);
            this.Instruction.TabIndex = 0;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(762, 464);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerLabel.TabIndex = 12;
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(853, 132);
            this.ScoreBox.Multiline = true;
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(200, 146);
            this.ScoreBox.TabIndex = 13;
            // 
            // QuitGameBtn
            // 
            this.QuitGameBtn.Location = new System.Drawing.Point(960, 603);
            this.QuitGameBtn.Name = "QuitGameBtn";
            this.QuitGameBtn.Size = new System.Drawing.Size(93, 44);
            this.QuitGameBtn.TabIndex = 14;
            this.QuitGameBtn.Text = "Quit Game";
            this.QuitGameBtn.UseVisualStyleBackColor = true;
            this.QuitGameBtn.Click += new System.EventHandler(this.QuitGameBtn_Click);
            // 
            // PressYourLuckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 718);
            this.Controls.Add(this.QuitGameBtn);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.GameStart);
            this.Name = "PressYourLuckForm";
            this.Text = "Press You Luck";
            this.SpinPlayer1.ResumeLayout(false);
            this.Player1.ResumeLayout(false);
            this.Player2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Question.ResumeLayout(false);
            this.Question.PerformLayout();
            this.InstructionBox.ResumeLayout(false);
            this.InstructionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Button SpinBtnPlayer1;
        private System.Windows.Forms.Button StopBtnPlayer1;
        private System.Windows.Forms.Button BuzzPlayer1;
        private System.Windows.Forms.Button BuzzPlayer2;
        private System.Windows.Forms.GroupBox SpinPlayer1;
        private System.Windows.Forms.GroupBox Player1;
        private System.Windows.Forms.GroupBox Player2;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Label QuestionBox;
        private System.Windows.Forms.GroupBox Question;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.GroupBox InstructionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StopBtnPlayer2;
        private System.Windows.Forms.Button SpinBtnPlayer2;
        private System.Windows.Forms.TextBox Instruction;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button QuitGameBtn;
    }
}


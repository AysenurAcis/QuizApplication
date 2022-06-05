namespace QuizAplication
{
    partial class QuizPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizPage));
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.finishButton = new System.Windows.Forms.Button();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerRadioButton1 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton3 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton4 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton5 = new System.Windows.Forms.RadioButton();
            this.forwardButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.timerMinuteLabel = new System.Windows.Forms.Label();
            this.timerBetweenLabel = new System.Windows.Forms.Label();
            this.timerSecondLabel = new System.Windows.Forms.Label();
            this.questionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(30, 30);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(124, 30);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Kalan Süre:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishButton.Location = new System.Drawing.Point(560, 30);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(130, 30);
            this.finishButton.TabIndex = 1;
            this.finishButton.Text = "SINAVI BİTİR";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.questionLabel);
            this.questionGroupBox.Controls.Add(this.answerRadioButton1);
            this.questionGroupBox.Controls.Add(this.answerRadioButton2);
            this.questionGroupBox.Controls.Add(this.answerRadioButton3);
            this.questionGroupBox.Controls.Add(this.answerRadioButton4);
            this.questionGroupBox.Controls.Add(this.answerRadioButton5);
            this.questionGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionGroupBox.Location = new System.Drawing.Point(30, 66);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(660, 320);
            this.questionGroupBox.TabIndex = 2;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "SORU :";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(10, 30);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(281, 21);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Aşağıdakilerden hangisi doğrudur ?";
            // 
            // answerRadioButton1
            // 
            this.answerRadioButton1.AutoSize = true;
            this.answerRadioButton1.Location = new System.Drawing.Point(20, 70);
            this.answerRadioButton1.Name = "answerRadioButton1";
            this.answerRadioButton1.Size = new System.Drawing.Size(84, 25);
            this.answerRadioButton1.TabIndex = 1;
            this.answerRadioButton1.TabStop = true;
            this.answerRadioButton1.Text = "Cevap 1";
            this.answerRadioButton1.UseVisualStyleBackColor = true;
            this.answerRadioButton1.CheckedChanged += new System.EventHandler(this.answerRadioButton1_CheckedChanged);
            // 
            // answerRadioButton2
            // 
            this.answerRadioButton2.AutoSize = true;
            this.answerRadioButton2.Location = new System.Drawing.Point(20, 101);
            this.answerRadioButton2.Name = "answerRadioButton2";
            this.answerRadioButton2.Size = new System.Drawing.Size(84, 25);
            this.answerRadioButton2.TabIndex = 1;
            this.answerRadioButton2.TabStop = true;
            this.answerRadioButton2.Text = "Cevap 2";
            this.answerRadioButton2.UseVisualStyleBackColor = true;
            this.answerRadioButton2.CheckedChanged += new System.EventHandler(this.answerRadioButton2_CheckedChanged);
            // 
            // answerRadioButton3
            // 
            this.answerRadioButton3.AutoSize = true;
            this.answerRadioButton3.Location = new System.Drawing.Point(20, 132);
            this.answerRadioButton3.Name = "answerRadioButton3";
            this.answerRadioButton3.Size = new System.Drawing.Size(84, 25);
            this.answerRadioButton3.TabIndex = 1;
            this.answerRadioButton3.TabStop = true;
            this.answerRadioButton3.Text = "Cevap 3";
            this.answerRadioButton3.UseVisualStyleBackColor = true;
            this.answerRadioButton3.CheckedChanged += new System.EventHandler(this.answerRadioButton3_CheckedChanged);
            // 
            // answerRadioButton4
            // 
            this.answerRadioButton4.AutoSize = true;
            this.answerRadioButton4.Location = new System.Drawing.Point(20, 163);
            this.answerRadioButton4.Name = "answerRadioButton4";
            this.answerRadioButton4.Size = new System.Drawing.Size(84, 25);
            this.answerRadioButton4.TabIndex = 1;
            this.answerRadioButton4.TabStop = true;
            this.answerRadioButton4.Text = "Cevap 4";
            this.answerRadioButton4.UseVisualStyleBackColor = true;
            this.answerRadioButton4.CheckedChanged += new System.EventHandler(this.answerRadioButton4_CheckedChanged);
            // 
            // answerRadioButton5
            // 
            this.answerRadioButton5.AutoSize = true;
            this.answerRadioButton5.Location = new System.Drawing.Point(21, 194);
            this.answerRadioButton5.Name = "answerRadioButton5";
            this.answerRadioButton5.Size = new System.Drawing.Size(84, 25);
            this.answerRadioButton5.TabIndex = 1;
            this.answerRadioButton5.TabStop = true;
            this.answerRadioButton5.Text = "Cevap 5";
            this.answerRadioButton5.UseVisualStyleBackColor = true;
            this.answerRadioButton5.CheckedChanged += new System.EventHandler(this.answerRadioButton5_CheckedChanged);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forwardButton.Location = new System.Drawing.Point(610, 392);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(80, 30);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "İleri";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousButton.Location = new System.Drawing.Point(524, 392);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(80, 30);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "Geri";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // timerMinuteLabel
            // 
            this.timerMinuteLabel.AutoSize = true;
            this.timerMinuteLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerMinuteLabel.ForeColor = System.Drawing.Color.Red;
            this.timerMinuteLabel.Location = new System.Drawing.Point(150, 30);
            this.timerMinuteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerMinuteLabel.Name = "timerMinuteLabel";
            this.timerMinuteLabel.Size = new System.Drawing.Size(29, 30);
            this.timerMinuteLabel.TabIndex = 4;
            this.timerMinuteLabel.Text = "--";
            // 
            // timerBetweenLabel
            // 
            this.timerBetweenLabel.AutoSize = true;
            this.timerBetweenLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerBetweenLabel.ForeColor = System.Drawing.Color.Red;
            this.timerBetweenLabel.Location = new System.Drawing.Point(170, 30);
            this.timerBetweenLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerBetweenLabel.Name = "timerBetweenLabel";
            this.timerBetweenLabel.Size = new System.Drawing.Size(19, 30);
            this.timerBetweenLabel.TabIndex = 4;
            this.timerBetweenLabel.Text = ":";
            // 
            // timerSecondLabel
            // 
            this.timerSecondLabel.AutoSize = true;
            this.timerSecondLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerSecondLabel.ForeColor = System.Drawing.Color.Red;
            this.timerSecondLabel.Location = new System.Drawing.Point(183, 30);
            this.timerSecondLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerSecondLabel.Name = "timerSecondLabel";
            this.timerSecondLabel.Size = new System.Drawing.Size(29, 30);
            this.timerSecondLabel.TabIndex = 4;
            this.timerSecondLabel.Text = "--";
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerMinuteLabel);
            this.Controls.Add(this.timerBetweenLabel);
            this.Controls.Add(this.timerSecondLabel);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.questionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizPage";
            this.Text = "Ders Adı";
            this.Load += new System.EventHandler(this.QuizPage_Load);
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Label timerLabel;
        private Label timerMinuteLabel;
        private Label timerBetweenLabel;
        private Label timerSecondLabel;
        private Button finishButton;
        private GroupBox questionGroupBox;
        private Label questionLabel;
        private RadioButton answerRadioButton1;
        private RadioButton answerRadioButton2;
        private RadioButton answerRadioButton3;
        private RadioButton answerRadioButton5;
        private RadioButton answerRadioButton4;
        private Button forwardButton;
        private Button previousButton;
    }
}
namespace QuizAplication
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.label1 = new System.Windows.Forms.Label();
            this.quizNameComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Girmek İstediğiniz Sınavı Seçiniz:";
            // 
            // quizNameComboBox
            // 
            this.quizNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quizNameComboBox.FormattingEnabled = true;
            this.quizNameComboBox.Items.AddRange(new object[] {
            "Görsel Programlama",
            "Java",
            "Veri Tabanı"});
            this.quizNameComboBox.Location = new System.Drawing.Point(50, 93);
            this.quizNameComboBox.Name = "quizNameComboBox";
            this.quizNameComboBox.Size = new System.Drawing.Size(236, 29);
            this.quizNameComboBox.TabIndex = 1;
            this.quizNameComboBox.SelectedIndexChanged += new System.EventHandler(this.QuizNameComboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(304, 93);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 29);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "SINAVA BAŞLA";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quizNameComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "SINAVLAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxQuizName;
        private Button startButton;
        private ComboBox quizNamecomboBox;
        private ComboBox quizNameComboBox;
    }
}
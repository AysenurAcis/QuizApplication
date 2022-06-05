using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAplication
{
    public partial class StartPage : Form
    {
        string quizName = "";
        public StartPage()
        {
            InitializeComponent();
        }
        // Sınav seçildiğinde yapılacak işlemler..
        private void QuizNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           quizName = this.quizNameComboBox.GetItemText(this.quizNameComboBox.SelectedItem);
           
        }
        // Sınava başla butonuna tıklandığında yapılacak işlemler..
        private void StartButton_Click(object sender, EventArgs e)
        {
            if(quizName != "")
            {
                var newPage = new QuizPage(quizName);
                newPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Girmek İstediğiniz Sınavı Seçiniz!", "HATA");
            }
        }
    }
}

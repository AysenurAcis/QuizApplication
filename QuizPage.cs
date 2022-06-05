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
    public partial class QuizPage : Form
    {
        string quizName         = "";
        int minute              = 5;
        int second              = 0;
        int questionNumber      = 1;
        int maxQuestionNumber   = 5;
        object[] question       = new object[7];
        object[] currentAnswer  = new object[6];
        public QuizPage(string title)
        {
            InitializeComponent();
            this.Text = title;
            quizName = title;
        }
        // Sayfa Yüklendiğinde Yapılacak işlemler..
        private void QuizPage_Load(object sender, EventArgs e)
        {
            timerMinuteLabel.Text = Convert.ToString(minute);
            timerSecondLabel.Text = Convert.ToString(second);
            timer.Interval = 1000;
            timer.Start();
            showQuestion();
        }
        // Timer Çalışırken ve Sonlandığında yapılacak işlemler..
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(second > 0)
            {                    
                second--;
                timerSecondLabel.Text = Convert.ToString(second);
            }
            else
            {
                if (minute > 0)
                {
                    minute--;
                    second = 59;
                    timerMinuteLabel.Text = Convert.ToString(minute);
                    timerSecondLabel.Text = Convert.ToString(second);
                }
                else
                {
                    FinishedQuiz();
                }
            }
        }
        // Sınavı bitir butonuna tıklandığında yapılacak işlemler..
        private void FinishButton_Click(object sender, EventArgs e)
        {
            FinishedQuiz();
        }
        // Sınav bittiğinde yapılacak işlemler..
        private void FinishedQuiz()
        {
            int trueAnswerCount = 0;
            int falseAnswerCount = 0;
            int nullAnswerCount = 0;

            timer.Stop();
            for(int i = 1; i <= maxQuestionNumber; i++)
            {
                object[] tempQuestion   = getQuestion(i);
                string correctAnswer    = Convert.ToString(tempQuestion[6]);
                if (currentAnswer[i] == correctAnswer)
                {
                    trueAnswerCount++;
                }
                else if(currentAnswer[i] == null)
                {
                    nullAnswerCount++;
                }
                else
                {
                    falseAnswerCount++;
                }
            }
            DialogResult result = MessageBox.Show("Sınav Sona Erdi! \nDoğru Cevap Sayısı: " + Convert.ToString(trueAnswerCount) + "\n" +"Yanlış Cevap Sayısı: " + Convert.ToString(falseAnswerCount)+"\n" + (nullAnswerCount > 0 ? "Boş Soru Sayısı: " + Convert.ToString(nullAnswerCount) : "") , "Sınav Sonucu");
            if(result == DialogResult.OK)
            {
                var newPage = new StartPage();
                newPage.Show();
                this.Hide();
            }
        }
        // İleri butonuna tıklandığında yapılacak işlemler..
        private void forwardButton_Click(object sender, EventArgs e)
        {
            if(questionNumber < maxQuestionNumber)
            {
                questionNumber++;
                showQuestion();
            }
            
        }
        // Geri butonuna tıklandığında yapılacak işlemler..
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (questionNumber > 1)
            {
                questionNumber--;
                showQuestion();
            }
        }
        // Ekranda sorunun görüntülenmesini sağlayan metod..
        private void showQuestion()
        {
            question                = getQuestion(questionNumber);
            questionGroupBox.Text   = "SORU : " + Convert.ToString(questionNumber);
            questionLabel.Text      = Convert.ToString(question[0]);
            answerRadioButton1.Text = Convert.ToString(question[1]);
            answerRadioButton2.Text = Convert.ToString(question[2]);
            answerRadioButton3.Text = Convert.ToString(question[3]);
            answerRadioButton4.Text = Convert.ToString(question[4]);
            answerRadioButton5.Text = Convert.ToString(question[5]);
            checkSelectedAnswer();
            checkEnableButtons();
        }
        // Gösterilen soruya ait önceden seçilmiş cevabı kontrol eden metod..
        private void checkSelectedAnswer()
        {
            string selectedAnswer = Convert.ToString(currentAnswer[questionNumber]);
            if(selectedAnswer == answerRadioButton1.Text)
            {
                answerRadioButton1.Checked = true;
            }
            else if (selectedAnswer == answerRadioButton2.Text)
            {
                answerRadioButton2.Checked = true;
            }
            else if (selectedAnswer == answerRadioButton3.Text)
            {
                answerRadioButton3.Checked = true;
            }
            else if (selectedAnswer == answerRadioButton4.Text)
            {
                answerRadioButton4.Checked = true;
            }
            else if (selectedAnswer == answerRadioButton5.Text)
            {
                answerRadioButton5.Checked = true;
            }
            else
            {
                answerRadioButton1.Checked = false;
                answerRadioButton2.Checked = false;
                answerRadioButton3.Checked = false;
                answerRadioButton4.Checked = false;
                answerRadioButton5.Checked = false;
            }
        }
        // İleri/Geri butonlarının aktif/pasif oluşunu kontrol eder..
        private void checkEnableButtons()
        {
            previousButton.Enabled = true;
            forwardButton.Enabled = true;

            if (questionNumber == 1)
            {
                previousButton.Enabled = false;
            }
            if (questionNumber == maxQuestionNumber)
            {
                forwardButton.Enabled = false;
            }
        }
        // Seçilen cevabı sorunun index değerine kaydeder..
        private void answerRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentAnswer[questionNumber] = answerRadioButton1.Text;
        }
        private void answerRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentAnswer[questionNumber] = answerRadioButton2.Text;
        }
        private void answerRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentAnswer[questionNumber] = answerRadioButton3.Text;
        }
        private void answerRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            currentAnswer[questionNumber] = answerRadioButton4.Text;
        }
        private void answerRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            currentAnswer[questionNumber] = answerRadioButton5.Text;
        }
        // İstenilen soruya ait bilgilerin dönüldüğü metod..
        private object[] getQuestion(int number)
        {
            object[] tempQuestion = new object[7];
            switch (quizName)
            {
                case "Görsel Programlama":
                    switch (number)
                    {
                        case 1:
                            tempQuestion[0] = "C# hakkında aşağıdakilerden hangisi doğrudur ?";
                            tempQuestion[1] = "Bileşen (component) yönelimlidir.";
                            tempQuestion[2] = "Çeşitli bilgisayar platformlarında derlenebilir.";
                            tempQuestion[3] = ".Net Framework'ün bir parçasıdır.";
                            tempQuestion[4] = "Hepsi";
                            tempQuestion[5] = "Görsel programlama dili olarak kullanılabilir.";
                            tempQuestion[6] = "Hepsi";
                            break;
                        case 2:
                            tempQuestion[0] = "Case bloğunu sonlandırmak için kullanılan anahtar kelime aşağıdakilerden hangisidir?";
                            tempQuestion[1] = "break";
                            tempQuestion[2] = "default";
                            tempQuestion[3] = "return";
                            tempQuestion[4] = "string";
                            tempQuestion[5] = "goto";
                            tempQuestion[6] = "break";
                            break;
                        case 3:
                            tempQuestion[0] = "Bir yöntem (method) içindeki bir değeri döndürmek için hangi anahtar kelime kullanılır ?";
                            tempQuestion[1] = "void";
                            tempQuestion[2] = "get";
                            tempQuestion[3] = "return";
                            tempQuestion[4] = "break";
                            tempQuestion[5] = "exit";
                            tempQuestion[6] = "return";
                            break;
                        case 4:
                            tempQuestion[0] = "İki değeri bir araya getirmek için hangi operatör kullanılır ?";
                            tempQuestion[1] = "-";
                            tempQuestion[2] = "+";
                            tempQuestion[3] = "/";
                            tempQuestion[4] = "!";
                            tempQuestion[5] = "*";
                            tempQuestion[6] = "+";
                            break;
                        case 5:
                            tempQuestion[0] = "Aşağıdaki değişken isimlerinden hangisi hatalıdır?";
                            tempQuestion[1] = "ogrenciNo";
                            tempQuestion[2] = "OgrenciAd";
                            tempQuestion[3] = "ogrenci_soyad";
                            tempQuestion[4] = "ogrenci sinif";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "ogrenci sinif";
                            break;
                    }
                    break;
                case "Java":
                    switch (number)
                    {
                        case 1:
                            tempQuestion[0] = "Java’da dizilerin index numarası kaçtan başlar?";
                            tempQuestion[1] = "0";
                            tempQuestion[2] = "1";
                            tempQuestion[3] = "2";
                            tempQuestion[4] = "3";
                            tempQuestion[5] = "4";
                            tempQuestion[6] = "0";
                            break;
                        case 2:
                            tempQuestion[0] = "Hangi anahtar kelime ile sınıf oluşturulur?";
                            tempQuestion[1] = "Class";
                            tempQuestion[2] = "ClassName";
                            tempQuestion[3] = "class()";
                            tempQuestion[4] = "class";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "class";
                            break;
                        case 3:
                            tempQuestion[0] = "Vector aşağıdakilerden hangisinin genişletmesidir?";
                            tempQuestion[1] = "ArrayList";
                            tempQuestion[2] = "LinkedList";
                            tempQuestion[3] = "AbstractList";
                            tempQuestion[4] = "None";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "AbstractList";
                            break;
                        case 4:
                            tempQuestion[0] = "Hangi operatör çarpma için kullanılır?";
                            tempQuestion[1] = "*";
                            tempQuestion[2] = "+";
                            tempQuestion[3] = "-";
                            tempQuestion[4] = "/";
                            tempQuestion[5] = ">";
                            tempQuestion[6] = "*";
                            break;
                        case 5:
                            tempQuestion[0] = "Java API kitaplığından bir paketi içe aktarmak için hangi anahtar sözcük kullanılır?";
                            tempQuestion[1] = "getLib";
                            tempQuestion[2] = "package";
                            tempQuestion[3] = "import";
                            tempQuestion[4] = "include";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "import";
                            break;
                    }
                    break;
                case "Veri Tabanı":
                    switch (number)
                    {
                        case 1:
                            tempQuestion[0] = "Bazı durumlarda aynı veri çeşidi birden fazla kayıtta yer alabilmektedir bu soruna ne ad verilir?";
                            tempQuestion[1] = "Gereksiz tekrar sorunu";
                            tempQuestion[2] = "Mutlak veri fazlalığı sorunu";
                            tempQuestion[3] = "Bilgilerin yenilenmesi sorunu";
                            tempQuestion[4] = "Veri tabanı sorunu";
                            tempQuestion[5] = "Hiç biri";
                            tempQuestion[6] = "Gereksiz tekrar sorunu";
                            break;
                        case 2:
                            tempQuestion[0] = "Tabloların özellikleri ile alakalı hangisi doğrudur?";
                            tempQuestion[1] = "Tablolar yalnızca sütunlardan oluşur.";
                            tempQuestion[2] = "Hücrelerdeki veriler çok uzun olmalıdır.";
                            tempQuestion[3] = "Birbirleri ile tamamen aynı olan kayıtlar olabilir.";
                            tempQuestion[4] = "Her sütunun alacağı isim birbirinden farklı olmalıdır";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "Her sütunun alacağı isim birbirinden farklı olmalıdır";
                            break;
                        case 3:
                            tempQuestion[0] = "Bir tablodaki bir sütuna ait verilerin başka bir tablonun sütunundan getirilmesini sağlayan anahtar aşağıdakilerden hangisidir?";
                            tempQuestion[1] = "Aday Anahtar";
                            tempQuestion[2] = "Yabancı Anahtar";
                            tempQuestion[3] = "Birleşik Anahtar";
                            tempQuestion[4] = "Birincil Anahtar";
                            tempQuestion[5] = "Hepsi";
                            tempQuestion[6] = "Yabancı Anahtar";
                            break;
                        case 4:
                            tempQuestion[0] = "Taslak veri tabanı üzerinde birtakım işlemler yapılarak taslağı son haline yaklaştırma yöntemine ne ad verilir?";
                            tempQuestion[1] = "Foreign Key";
                            tempQuestion[2] = "Primary Key";
                            tempQuestion[3] = "Null";
                            tempQuestion[4] = "Normalizasyon";
                            tempQuestion[5] = "Denormalizasyon";
                            tempQuestion[6] = "Normalizasyon";
                            break;
                        case 5:
                            tempQuestion[0] = "Tablodaki bir alana girilen verinin tekrarsız olmasını sağlamak için kullanılan veri kısıtlama türü hangisidir?";
                            tempQuestion[1] = "Not Null";
                            tempQuestion[2] = "Unique";
                            tempQuestion[3] = "Check";
                            tempQuestion[4] = "Default";
                            tempQuestion[5] = "Break";
                            tempQuestion[6] = "Unique";
                            break;
                    }
                    break;
            }
            return tempQuestion;
        }
    }
}

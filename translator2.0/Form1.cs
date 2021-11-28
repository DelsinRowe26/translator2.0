using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandex.Translator;
using TranslatorService;
using Google.Cloud.Translation.V2;
using GoogleApi;
using Microsoft.Linq.Translations;
using Newtonsoft.Json;

namespace translator2._0
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            TbTrAnS.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, tbTransLate.Text);
            MessageBox.Show("Файл сохранен");
        }
        private void cBcAtolog_TextChanged_1(object sender, EventArgs e)
        {
            index = cBcAtolog.FindString(cBcAtolog.Text);//нахождение индекса 1-го совпадения с вводимым значением
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTtran_Click(object sender, EventArgs e)
        {
            //TranslatorClient client = new TranslatorClient();
            //var response = client.TranslateAsync(TbTrAnS.Text, "ru");
            //GoogleApi.GoogleTranslate translate = new GoogleApi.GoogleTranslate();
            //var response = GoogleTranslate.Translate(TbTrAnS.Text);
            //tbTransLate.Text = response.Result();
            TranslationClient client = TranslationClient.Create();
            var response = client.TranslateText(TbTrAnS.Text, "ru");
            tbTransLate.Text = response.TranslatedText;
            

        }
    }
}

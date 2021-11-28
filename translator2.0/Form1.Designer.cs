
namespace translator2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBcAtolog = new System.Windows.Forms.ComboBox();
            this.TbTrAnS = new System.Windows.Forms.TextBox();
            this.tbTransLate = new System.Windows.Forms.TextBox();
            this.bTtran = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBcAtolog
            // 
            this.cBcAtolog.FormattingEnabled = true;
            this.cBcAtolog.Items.AddRange(new object[] {
            "азербайджанский",
            "албанский",
            "амхарский",
            "английский",
            "арабский",
            "армянский",
            "африкаанс",
            "баскский",
            "белорусский",
            "бенгальский",
            "бирманский",
            "болгарский",
            "боснийский",
            "валлийский",
            "венгерский",
            "вьетнамский",
            "гавайский",
            "галисийский",
            "греческий",
            "грузинский",
            "гуджарати",
            "датский",
            "зулу",
            "иврит",
            "игбо",
            "идиш",
            "индонезийский",
            "ирландский",
            "исландский",
            "испанский",
            "итальянский",
            "йоруба",
            "казахский",
            "каннада",
            "каталанский",
            "киргизский",
            "китайский (традиционный)",
            "китайский (упрощенный)",
            "корейский",
            "корсиканский",
            "креольский (Гаити)",
            "курманджи",
            "кхмерский",
            "кхоса",
            "лаосский",
            "латинский",
            "латышский",
            "литовский",
            "люксембургский",
            "македонский",
            "малагасийский",
            "малайский",
            "малаялам",
            "мальтийский",
            "маори",
            "маратхи",
            "монгольский",
            "немецкий",
            "непальский",
            "нидерландский",
            "норвежский",
            "ория",
            "панджаби",
            "персидский",
            "польский",
            "португальский",
            "пушту",
            "руанда",
            "румынский",
            "русский",
            "самоанский",
            "себуанский",
            "сербский",
            "сесото",
            "сингальский",
            "синдхи",
            "словацкий",
            "словенский",
            "сомалийский",
            "суахили",
            "суданский",
            "таджикский",
            "тайский",
            "тамильский",
            "татарский",
            "телугу",
            "турецкий",
            "туркменский",
            "узбекский",
            "уйгурский",
            "украинский",
            "урду",
            "филиппинский",
            "финский",
            "французский",
            "фризский",
            "хауса",
            "хинди",
            "хмонг",
            "хорватский",
            "чева",
            "чешский",
            "шведский",
            "шона",
            "шотландский (гэльский)",
            "эсперанто",
            "эстонский",
            "яванский",
            "японский"});
            this.cBcAtolog.Location = new System.Drawing.Point(994, 46);
            this.cBcAtolog.Name = "cBcAtolog";
            this.cBcAtolog.Size = new System.Drawing.Size(193, 24);
            this.cBcAtolog.TabIndex = 0;
            this.cBcAtolog.TextChanged += new System.EventHandler(this.cBcAtolog_TextChanged_1);
            // 
            // TbTrAnS
            // 
            this.TbTrAnS.Location = new System.Drawing.Point(12, 46);
            this.TbTrAnS.Multiline = true;
            this.TbTrAnS.Name = "TbTrAnS";
            this.TbTrAnS.Size = new System.Drawing.Size(425, 498);
            this.TbTrAnS.TabIndex = 1;
            // 
            // tbTransLate
            // 
            this.tbTransLate.Location = new System.Drawing.Point(592, 46);
            this.tbTransLate.Multiline = true;
            this.tbTransLate.Name = "tbTransLate";
            this.tbTransLate.Size = new System.Drawing.Size(396, 498);
            this.tbTransLate.TabIndex = 2;
            // 
            // bTtran
            // 
            this.bTtran.Location = new System.Drawing.Point(443, 215);
            this.bTtran.Name = "bTtran";
            this.bTtran.Size = new System.Drawing.Size(143, 68);
            this.bTtran.TabIndex = 3;
            this.bTtran.Text = "Перевести";
            this.bTtran.UseVisualStyleBackColor = true;
            this.bTtran.Click += new System.EventHandler(this.bTtran_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 556);
            this.Controls.Add(this.bTtran);
            this.Controls.Add(this.tbTransLate);
            this.Controls.Add(this.TbTrAnS);
            this.Controls.Add(this.cBcAtolog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBcAtolog;
        private System.Windows.Forms.TextBox TbTrAnS;
        private System.Windows.Forms.TextBox tbTransLate;
        private System.Windows.Forms.Button bTtran;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


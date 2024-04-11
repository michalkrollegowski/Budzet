namespace Budżet
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.historia_konta = new System.Windows.Forms.ListView();
            this.stankonta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wplac = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.wplata = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.wyplac = new System.Windows.Forms.Button();
            this.wyplata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oplac = new System.Windows.Forms.Button();
            this.przelew = new System.Windows.Forms.TabPage();
            this.nowy_wydatek = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.historia_przelewow = new System.Windows.Forms.ListView();
            this.wyslij = new System.Windows.Forms.Button();
            this.kwota_przelewu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nazwa_odbiorcy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numer_konta = new System.Windows.Forms.TextBox();
            this.tytul_przelewu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.przelewch = new System.Windows.Forms.CheckBox();
            this.platonscch = new System.Windows.Forms.CheckBox();
            this.tytul_przelewur = new System.Windows.Forms.RadioButton();
            this.kwota_przelewur = new System.Windows.Forms.RadioButton();
            this.nazwa_odbiorcyr = new System.Windows.Forms.RadioButton();
            this.numer_kontar = new System.Windows.Forms.RadioButton();
            this.kwota_platnoscir = new System.Windows.Forms.RadioButton();
            this.typ_platonscir = new System.Windows.Forms.RadioButton();
            this.wyszukaj = new System.Windows.Forms.Button();
            this.historia_transakcji = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.fraza = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.odswiez = new System.Windows.Forms.Button();
            this.usun_wydatek = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.przelew.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Controls.Add(this.przelew);
            this.tab.Controls.Add(this.TabPage5);
            this.tab.ForeColor = System.Drawing.Color.Chocolate;
            this.tab.Location = new System.Drawing.Point(1, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1065, 517);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.historia_konta);
            this.tabPage1.Controls.Add(this.stankonta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1057, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stan Konta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(117, 295);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "1234 5678 9012 3456";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 295);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "numer konta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Król-Łęgowski";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 261);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "nazwisko:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "imie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Michał";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(755, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Historia Konta";
            // 
            // historia_konta
            // 
            this.historia_konta.BackColor = System.Drawing.SystemColors.Info;
            this.historia_konta.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historia_konta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.historia_konta.HideSelection = false;
            this.historia_konta.Location = new System.Drawing.Point(584, 98);
            this.historia_konta.Margin = new System.Windows.Forms.Padding(4);
            this.historia_konta.Name = "historia_konta";
            this.historia_konta.Size = new System.Drawing.Size(459, 245);
            this.historia_konta.TabIndex = 2;
            this.historia_konta.UseCompatibleStateImageBehavior = false;
            // 
            // stankonta
            // 
            this.stankonta.AutoSize = true;
            this.stankonta.BackColor = System.Drawing.Color.SaddleBrown;
            this.stankonta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stankonta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stankonta.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stankonta.ForeColor = System.Drawing.Color.Bisque;
            this.stankonta.Location = new System.Drawing.Point(21, 98);
            this.stankonta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stankonta.Name = "stankonta";
            this.stankonta.Size = new System.Drawing.Size(258, 109);
            this.stankonta.TabIndex = 1;
            this.stankonta.Text = "0.00zł";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stan Konta";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.wplac);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.wplata);
            this.tabPage2.ForeColor = System.Drawing.Color.Bisque;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wpłata";
            // 
            // wplac
            // 
            this.wplac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wplac.Location = new System.Drawing.Point(631, 268);
            this.wplac.Margin = new System.Windows.Forms.Padding(4);
            this.wplac.Name = "wplac";
            this.wplac.Size = new System.Drawing.Size(100, 28);
            this.wplac.TabIndex = 2;
            this.wplac.Text = "WPŁAĆ";
            this.wplac.UseVisualStyleBackColor = false;
            this.wplac.Click += new System.EventHandler(this.wplac_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Podaj kwote:";
            // 
            // wplata
            // 
            this.wplata.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wplata.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wplata.ForeColor = System.Drawing.SystemColors.Info;
            this.wplata.Location = new System.Drawing.Point(427, 186);
            this.wplata.Margin = new System.Windows.Forms.Padding(4);
            this.wplata.Multiline = true;
            this.wplata.Name = "wplata";
            this.wplata.Size = new System.Drawing.Size(193, 80);
            this.wplata.TabIndex = 0;
            this.toolTip1.SetToolTip(this.wplata, "np: 200,20");
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Bisque;
            this.tabPage3.Controls.Add(this.wyplac);
            this.tabPage3.Controls.Add(this.wyplata);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.ForeColor = System.Drawing.Color.Bisque;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1057, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wypłata";
            // 
            // wyplac
            // 
            this.wyplac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wyplac.Location = new System.Drawing.Point(629, 267);
            this.wyplac.Margin = new System.Windows.Forms.Padding(4);
            this.wyplac.Name = "wyplac";
            this.wyplac.Size = new System.Drawing.Size(100, 28);
            this.wyplac.TabIndex = 2;
            this.wyplac.Text = "WYPŁAĆ";
            this.wyplac.UseVisualStyleBackColor = false;
            this.wyplac.Click += new System.EventHandler(this.wyplac_Click);
            // 
            // wyplata
            // 
            this.wyplata.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wyplata.Font = new System.Drawing.Font("Microsoft Tai Le", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wyplata.ForeColor = System.Drawing.SystemColors.Info;
            this.wyplata.Location = new System.Drawing.Point(427, 185);
            this.wyplata.Margin = new System.Windows.Forms.Padding(4);
            this.wyplata.Multiline = true;
            this.wyplata.Name = "wyplata";
            this.wyplata.Size = new System.Drawing.Size(193, 83);
            this.wyplata.TabIndex = 1;
            this.toolTip2.SetToolTip(this.wyplata, "np: 200,20");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SaddleBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Podaj kwote:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Bisque;
            this.tabPage4.Controls.Add(this.usun_wydatek);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.oplac);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1057, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stałe Wydatki";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(376, 233);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(263, 31);
            this.label17.TabIndex = 8;
            this.label17.Text = "Brak stałych wydatków";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Podaj kwote jeśli się zmieniła:";
            // 
            // oplac
            // 
            this.oplac.Location = new System.Drawing.Point(855, 384);
            this.oplac.Margin = new System.Windows.Forms.Padding(4);
            this.oplac.Name = "oplac";
            this.oplac.Size = new System.Drawing.Size(100, 28);
            this.oplac.TabIndex = 6;
            this.oplac.Text = "OPŁAĆ";
            this.oplac.UseVisualStyleBackColor = true;
            this.oplac.Click += new System.EventHandler(this.oplac_Click);
            // 
            // przelew
            // 
            this.przelew.BackColor = System.Drawing.Color.Bisque;
            this.przelew.Controls.Add(this.nowy_wydatek);
            this.przelew.Controls.Add(this.label11);
            this.przelew.Controls.Add(this.historia_przelewow);
            this.przelew.Controls.Add(this.wyslij);
            this.przelew.Controls.Add(this.kwota_przelewu);
            this.przelew.Controls.Add(this.label9);
            this.przelew.Controls.Add(this.label8);
            this.przelew.Controls.Add(this.nazwa_odbiorcy);
            this.przelew.Controls.Add(this.label7);
            this.przelew.Controls.Add(this.numer_konta);
            this.przelew.Controls.Add(this.tytul_przelewu);
            this.przelew.Controls.Add(this.label6);
            this.przelew.Location = new System.Drawing.Point(4, 25);
            this.przelew.Margin = new System.Windows.Forms.Padding(4);
            this.przelew.Name = "przelew";
            this.przelew.Padding = new System.Windows.Forms.Padding(4);
            this.przelew.Size = new System.Drawing.Size(1057, 488);
            this.przelew.TabIndex = 4;
            this.przelew.Text = "Przelew";
            // 
            // nowy_wydatek
            // 
            this.nowy_wydatek.Location = new System.Drawing.Point(441, 256);
            this.nowy_wydatek.Margin = new System.Windows.Forms.Padding(4);
            this.nowy_wydatek.Name = "nowy_wydatek";
            this.nowy_wydatek.Size = new System.Drawing.Size(179, 28);
            this.nowy_wydatek.TabIndex = 11;
            this.nowy_wydatek.Text = "DODAJ WYDATEK";
            this.nowy_wydatek.UseVisualStyleBackColor = true;
            this.nowy_wydatek.Click += new System.EventHandler(this.nowy_wydatek_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(760, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "HISTORIA PRZELEWÓW";
            // 
            // historia_przelewow
            // 
            this.historia_przelewow.BackColor = System.Drawing.SystemColors.Info;
            this.historia_przelewow.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historia_przelewow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.historia_przelewow.HideSelection = false;
            this.historia_przelewow.Location = new System.Drawing.Point(651, 107);
            this.historia_przelewow.Margin = new System.Windows.Forms.Padding(4);
            this.historia_przelewow.Name = "historia_przelewow";
            this.historia_przelewow.Size = new System.Drawing.Size(392, 222);
            this.historia_przelewow.TabIndex = 9;
            this.historia_przelewow.UseCompatibleStateImageBehavior = false;
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(477, 302);
            this.wyslij.Margin = new System.Windows.Forms.Padding(4);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(100, 28);
            this.wyslij.TabIndex = 8;
            this.wyslij.Text = "WYŚLIJ";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // kwota_przelewu
            // 
            this.kwota_przelewu.BackColor = System.Drawing.SystemColors.Info;
            this.kwota_przelewu.Location = new System.Drawing.Point(45, 198);
            this.kwota_przelewu.Margin = new System.Windows.Forms.Padding(4);
            this.kwota_przelewu.Name = "kwota_przelewu";
            this.kwota_przelewu.Size = new System.Drawing.Size(132, 22);
            this.kwota_przelewu.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "kwota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "nazwa odbiorcy";
            // 
            // nazwa_odbiorcy
            // 
            this.nazwa_odbiorcy.BackColor = System.Drawing.SystemColors.Info;
            this.nazwa_odbiorcy.Location = new System.Drawing.Point(45, 127);
            this.nazwa_odbiorcy.Margin = new System.Windows.Forms.Padding(4);
            this.nazwa_odbiorcy.Name = "nazwa_odbiorcy";
            this.nazwa_odbiorcy.Size = new System.Drawing.Size(132, 22);
            this.nazwa_odbiorcy.TabIndex = 4;
            this.toolTip3.SetToolTip(this.nazwa_odbiorcy, "max(20)znaków");
            this.toolTip4.SetToolTip(this.nazwa_odbiorcy, "max (15) znaków");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "numer konta";
            // 
            // numer_konta
            // 
            this.numer_konta.BackColor = System.Drawing.SystemColors.Info;
            this.numer_konta.Location = new System.Drawing.Point(100, 302);
            this.numer_konta.Margin = new System.Windows.Forms.Padding(4);
            this.numer_konta.Name = "numer_konta";
            this.numer_konta.Size = new System.Drawing.Size(260, 22);
            this.numer_konta.TabIndex = 2;
            this.toolTip4.SetToolTip(this.numer_konta, "max (200) znaków");
            this.toolTip5.SetToolTip(this.numer_konta, "powinno posiadać 16 cyfr");
            // 
            // tytul_przelewu
            // 
            this.tytul_przelewu.BackColor = System.Drawing.SystemColors.Info;
            this.tytul_przelewu.Location = new System.Drawing.Point(228, 127);
            this.tytul_przelewu.Margin = new System.Windows.Forms.Padding(4);
            this.tytul_przelewu.Multiline = true;
            this.tytul_przelewu.Name = "tytul_przelewu";
            this.tytul_przelewu.Size = new System.Drawing.Size(229, 96);
            this.tytul_przelewu.TabIndex = 1;
            this.toolTip4.SetToolTip(this.tytul_przelewu, "max(100)znaków");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "tytuł przelewu";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.Bisque;
            this.TabPage5.Controls.Add(this.przelewch);
            this.TabPage5.Controls.Add(this.platonscch);
            this.TabPage5.Controls.Add(this.tytul_przelewur);
            this.TabPage5.Controls.Add(this.kwota_przelewur);
            this.TabPage5.Controls.Add(this.nazwa_odbiorcyr);
            this.TabPage5.Controls.Add(this.numer_kontar);
            this.TabPage5.Controls.Add(this.kwota_platnoscir);
            this.TabPage5.Controls.Add(this.typ_platonscir);
            this.TabPage5.Controls.Add(this.wyszukaj);
            this.TabPage5.Controls.Add(this.historia_transakcji);
            this.TabPage5.Controls.Add(this.label19);
            this.TabPage5.Controls.Add(this.fraza);
            this.TabPage5.Controls.Add(this.label18);
            this.TabPage5.Location = new System.Drawing.Point(4, 25);
            this.TabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage5.Size = new System.Drawing.Size(1057, 488);
            this.TabPage5.TabIndex = 5;
            this.TabPage5.Text = "Historia Transakcji";
            // 
            // przelewch
            // 
            this.przelewch.AutoSize = true;
            this.przelewch.Location = new System.Drawing.Point(164, 124);
            this.przelewch.Margin = new System.Windows.Forms.Padding(4);
            this.przelewch.Name = "przelewch";
            this.przelewch.Size = new System.Drawing.Size(76, 20);
            this.przelewch.TabIndex = 22;
            this.przelewch.Text = "Przelew";
            this.przelewch.UseVisualStyleBackColor = true;
            this.przelewch.CheckedChanged += new System.EventHandler(this.przelewch_CheckedChanged);
            // 
            // platonscch
            // 
            this.platonscch.AutoSize = true;
            this.platonscch.Location = new System.Drawing.Point(40, 124);
            this.platonscch.Margin = new System.Windows.Forms.Padding(4);
            this.platonscch.Name = "platonscch";
            this.platonscch.Size = new System.Drawing.Size(84, 20);
            this.platonscch.TabIndex = 21;
            this.platonscch.Text = "Płatność";
            this.platonscch.UseVisualStyleBackColor = true;
            this.platonscch.CheckedChanged += new System.EventHandler(this.platonscch_CheckedChanged);
            // 
            // tytul_przelewur
            // 
            this.tytul_przelewur.AutoSize = true;
            this.tytul_przelewur.Location = new System.Drawing.Point(164, 236);
            this.tytul_przelewur.Margin = new System.Windows.Forms.Padding(4);
            this.tytul_przelewur.Name = "tytul_przelewur";
            this.tytul_przelewur.Size = new System.Drawing.Size(110, 20);
            this.tytul_przelewur.TabIndex = 20;
            this.tytul_przelewur.TabStop = true;
            this.tytul_przelewur.Text = "tytuł przelewu";
            this.tytul_przelewur.UseVisualStyleBackColor = true;
            this.tytul_przelewur.Visible = false;
            // 
            // kwota_przelewur
            // 
            this.kwota_przelewur.AutoSize = true;
            this.kwota_przelewur.Location = new System.Drawing.Point(164, 208);
            this.kwota_przelewur.Margin = new System.Windows.Forms.Padding(4);
            this.kwota_przelewur.Name = "kwota_przelewur";
            this.kwota_przelewur.Size = new System.Drawing.Size(63, 20);
            this.kwota_przelewur.TabIndex = 19;
            this.kwota_przelewur.TabStop = true;
            this.kwota_przelewur.Text = "kwota";
            this.kwota_przelewur.UseVisualStyleBackColor = true;
            this.kwota_przelewur.Visible = false;
            // 
            // nazwa_odbiorcyr
            // 
            this.nazwa_odbiorcyr.AutoSize = true;
            this.nazwa_odbiorcyr.Location = new System.Drawing.Point(164, 180);
            this.nazwa_odbiorcyr.Margin = new System.Windows.Forms.Padding(4);
            this.nazwa_odbiorcyr.Name = "nazwa_odbiorcyr";
            this.nazwa_odbiorcyr.Size = new System.Drawing.Size(114, 20);
            this.nazwa_odbiorcyr.TabIndex = 18;
            this.nazwa_odbiorcyr.TabStop = true;
            this.nazwa_odbiorcyr.Text = "nazwa obiorcy";
            this.nazwa_odbiorcyr.UseVisualStyleBackColor = true;
            this.nazwa_odbiorcyr.Visible = false;
            // 
            // numer_kontar
            // 
            this.numer_kontar.AutoSize = true;
            this.numer_kontar.Location = new System.Drawing.Point(164, 151);
            this.numer_kontar.Margin = new System.Windows.Forms.Padding(4);
            this.numer_kontar.Name = "numer_kontar";
            this.numer_kontar.Size = new System.Drawing.Size(101, 20);
            this.numer_kontar.TabIndex = 17;
            this.numer_kontar.TabStop = true;
            this.numer_kontar.Text = "numer konta";
            this.numer_kontar.UseVisualStyleBackColor = true;
            this.numer_kontar.Visible = false;
            // 
            // kwota_platnoscir
            // 
            this.kwota_platnoscir.AutoSize = true;
            this.kwota_platnoscir.Location = new System.Drawing.Point(40, 181);
            this.kwota_platnoscir.Margin = new System.Windows.Forms.Padding(4);
            this.kwota_platnoscir.Name = "kwota_platnoscir";
            this.kwota_platnoscir.Size = new System.Drawing.Size(63, 20);
            this.kwota_platnoscir.TabIndex = 16;
            this.kwota_platnoscir.TabStop = true;
            this.kwota_platnoscir.Text = "kwota";
            this.kwota_platnoscir.UseVisualStyleBackColor = true;
            this.kwota_platnoscir.Visible = false;
            // 
            // typ_platonscir
            // 
            this.typ_platonscir.AutoSize = true;
            this.typ_platonscir.Location = new System.Drawing.Point(40, 151);
            this.typ_platonscir.Margin = new System.Windows.Forms.Padding(4);
            this.typ_platonscir.Name = "typ_platonscir";
            this.typ_platonscir.Size = new System.Drawing.Size(106, 20);
            this.typ_platonscir.TabIndex = 15;
            this.typ_platonscir.TabStop = true;
            this.typ_platonscir.Text = "typ płatności";
            this.typ_platonscir.UseVisualStyleBackColor = true;
            this.typ_platonscir.Visible = false;
            // 
            // wyszukaj
            // 
            this.wyszukaj.Location = new System.Drawing.Point(84, 363);
            this.wyszukaj.Margin = new System.Windows.Forms.Padding(4);
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(129, 36);
            this.wyszukaj.TabIndex = 14;
            this.wyszukaj.Text = "WYSZUKAJ";
            this.wyszukaj.UseVisualStyleBackColor = true;
            this.wyszukaj.Click += new System.EventHandler(this.wyszukaj_Click);
            // 
            // historia_transakcji
            // 
            this.historia_transakcji.BackColor = System.Drawing.SystemColors.Info;
            this.historia_transakcji.HideSelection = false;
            this.historia_transakcji.Location = new System.Drawing.Point(325, 103);
            this.historia_transakcji.Margin = new System.Windows.Forms.Padding(4);
            this.historia_transakcji.Name = "historia_transakcji";
            this.historia_transakcji.Size = new System.Drawing.Size(717, 357);
            this.historia_transakcji.TabIndex = 13;
            this.historia_transakcji.UseCompatibleStateImageBehavior = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 38);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Wyszukiwanie Frazy:";
            // 
            // fraza
            // 
            this.fraza.BackColor = System.Drawing.SystemColors.Info;
            this.fraza.Location = new System.Drawing.Point(27, 60);
            this.fraza.Margin = new System.Windows.Forms.Padding(4);
            this.fraza.Name = "fraza";
            this.fraza.Size = new System.Drawing.Size(215, 22);
            this.fraza.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(584, 38);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 33);
            this.label18.TabIndex = 0;
            this.label18.Text = "Historia Transakcji:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 100;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip2.InitialDelay = 5;
            this.toolTip2.ReshowDelay = 100;
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 5000;
            this.toolTip3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip3.InitialDelay = 5;
            this.toolTip3.ReshowDelay = 100;
            // 
            // toolTip4
            // 
            this.toolTip4.AutoPopDelay = 5000;
            this.toolTip4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip4.InitialDelay = 5;
            this.toolTip4.ReshowDelay = 100;
            // 
            // toolTip5
            // 
            this.toolTip5.AutoPopDelay = 5000;
            this.toolTip5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip5.InitialDelay = 5;
            this.toolTip5.ReshowDelay = 100;
            // 
            // odswiez
            // 
            this.odswiez.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.odswiez.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odswiez.Location = new System.Drawing.Point(484, 519);
            this.odswiez.Margin = new System.Windows.Forms.Padding(4);
            this.odswiez.Name = "odswiez";
            this.odswiez.Size = new System.Drawing.Size(100, 28);
            this.odswiez.TabIndex = 1;
            this.odswiez.Text = "ODŚWIEŻ";
            this.odswiez.UseVisualStyleBackColor = false;
            this.odswiez.Click += new System.EventHandler(this.odswiez_Click);
            // 
            // usun_wydatek
            // 
            this.usun_wydatek.Location = new System.Drawing.Point(829, 420);
            this.usun_wydatek.Margin = new System.Windows.Forms.Padding(4);
            this.usun_wydatek.Name = "usun_wydatek";
            this.usun_wydatek.Size = new System.Drawing.Size(151, 28);
            this.usun_wydatek.TabIndex = 9;
            this.usun_wydatek.Text = "USUŃ WYDATEK";
            this.usun_wydatek.UseVisualStyleBackColor = true;
            this.usun_wydatek.Click += new System.EventHandler(this.usun_wydatek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.odswiez);
            this.Controls.Add(this.tab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.przelew.ResumeLayout(false);
            this.przelew.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label stankonta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wplata;
        private System.Windows.Forms.Button wplac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wyplac;
        private System.Windows.Forms.TextBox wyplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button oplac;
        private System.Windows.Forms.TabPage przelew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nazwa_odbiorcy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numer_konta;
        private System.Windows.Forms.TextBox tytul_przelewu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView historia_konta;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.TextBox kwota_przelewu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView historia_przelewow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button nowy_wydatek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button odswiez;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage TabPage5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox fraza;
        private System.Windows.Forms.ListView historia_transakcji;
        private System.Windows.Forms.Button wyszukaj;
        private System.Windows.Forms.RadioButton tytul_przelewur;
        private System.Windows.Forms.RadioButton kwota_przelewur;
        private System.Windows.Forms.RadioButton nazwa_odbiorcyr;
        private System.Windows.Forms.RadioButton numer_kontar;
        private System.Windows.Forms.RadioButton kwota_platnoscir;
        private System.Windows.Forms.RadioButton typ_platonscir;
        private System.Windows.Forms.CheckBox platonscch;
        private System.Windows.Forms.CheckBox przelewch;
        private System.Windows.Forms.Button usun_wydatek;
    }
}


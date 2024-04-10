using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Budżet.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Budżet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CultureInfo polskaKultura = new CultureInfo("pl-PL");
        public class PrzelewInfo
        {
            public string NazwaOdbiorcy { get; set; }
            public double Kwota { get; set; }
            public string NumerKonta { get; set; }
            public string TytulPrzelewu { get; set; }
        }
        public class PlacenieInfo
        {
            public string Typplacy { get; set; }
            public string Kwota { get; set; }
        }
        private List<PrzelewInfo> listaPrzelewow = new List<PrzelewInfo>();
        private List<PlacenieInfo> listaPlatnosci = new List<PlacenieInfo>();
        private void wyslij_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(nazwa_odbiorcy.Text) || string.IsNullOrEmpty(kwota_przelewu.Text) || string.IsNullOrEmpty(numer_konta.Text) || string.IsNullOrEmpty(tytul_przelewu.Text)))
            {
                PrzelewInfo przelewInfo = new PrzelewInfo
                {
                    NazwaOdbiorcy = nazwa_odbiorcy.Text,
                    Kwota = double.Parse(kwota_przelewu.Text),
                    NumerKonta = numer_konta.Text,
                    TytulPrzelewu = tytul_przelewu.Text
                };
                PlacenieInfo placenieInfo = new PlacenieInfo
                {
                    Typplacy = "przelew",
                    Kwota = "-" + kwota_przelewu.Text + "zł"
                };

                if (double.TryParse(kwota_przelewu.Text, out double kwota))
                {
                    if (!double.IsNaN(kwota))
                    {
                        if (kwota > 0)
                        {
                            if (kwota <= Konwersja(stankonta.Text))
                            {
                                MessageBox.Show("Pomyślnie wykonano przelew");
                                listaPlatnosci.Add(placenieInfo);
                                listaPrzelewow.Add(przelewInfo);
                                double stan = Konwersja(stankonta.Text);
                                stan -= kwota;
                                stankonta.Text = stan.ToString("0.00", polskaKultura) + "zł";

                                nazwa_odbiorcy.Clear();
                                kwota_przelewu.Clear();
                                numer_konta.Clear();
                                tytul_przelewu.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Za mały budżet do wykonania przelewu");
                            }
                        }
                        else if (kwota == 0)
                        {
                            MessageBox.Show("Podano zerową kwotę");
                        }
                        else
                        {
                            MessageBox.Show("Podano ujemną kwotę");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Podano zły format");
                }
            }
            else
            {
                MessageBox.Show("Nie wszystkie pola zostały uzupełnione");
            }
        }
        private void odswiez_Click(object sender, EventArgs e)
        {
            historia_przelewow.Items.Clear();

            foreach (var przelew in listaPrzelewow)
            {
                string itemText = $@"| nr. kon: {przelew.NumerKonta} 
| nazwa odb: {przelew.NazwaOdbiorcy} 
| kwota: {przelew.Kwota}zł |";
                string itemText2 = $"| typ: przelew | kwota: -{przelew.Kwota}zł |";
                historia_przelewow.Items.Add(itemText);
                historia_konta.Items.Add(itemText2);
            }
        }
        static double Konwersja(string stan)
        {
            stan = stan.Trim();

            string[] stank = stan.ToCharArray().Select(c => c.ToString()).ToArray();
            stan = "";
            for (int s = 0; s < stank.Length - 2; s++)
            {
                stan += stank[s];
            }

            double stann = double.Parse(stan.Replace('.', ','));
            return stann;
        }
        private void wplac_Click(object sender, EventArgs e)
        {
            PlacenieInfo placenieInfo = new PlacenieInfo
            {
                Typplacy = "wpłata",
                Kwota = "+" + wplata.Text + "zł"
            };
            if (!string.IsNullOrEmpty(wplata.Text))
            {
                if (double.TryParse(wplata.Text, out double kwota))
                {
                    if (!double.IsNaN(kwota))
                    {
                        if (kwota > 0)
                        {
                            MessageBox.Show("POMYŚLNIE WYKONANO WPŁATĘ");
                            listaPlatnosci.Add(placenieInfo);
                            double stan = Konwersja(stankonta.Text);
                            stan += kwota;
                            stankonta.Text = stan.ToString("0.00", polskaKultura)+"zł" ;
                            historia_konta.Items.Add($"typ: wpłata | +{kwota.ToString("0.00", polskaKultura)}zł");
                        }
                        else if (kwota == 0)
                        {
                            MessageBox.Show("Podano zerową kwotę");
                        }
                        else
                        {
                            MessageBox.Show("Podano ujemną kwotę");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podano złą kwotę");
                    }
                }
                else
                {
                    MessageBox.Show("Podano zły format");
                }
            }
            else
            {
                MessageBox.Show("Nie podano kwoty");
            }
        }

        private void wyplac_Click(object sender, EventArgs e)
        {
            PlacenieInfo placenieInfo = new PlacenieInfo
            {
                Typplacy = "wypłata",
                Kwota = "-" + wyplata.Text + "zł"
            };
            if (!string.IsNullOrEmpty(wyplata.Text))
            {
                if (double.TryParse(wyplata.Text, out double kwota))
                {
                    if (!double.IsNaN(kwota))
                    {
                        if (kwota > 0)
                        {
                            if (kwota <= double.Parse(wplata.Text))
                            {
                                MessageBox.Show("POMYŚLNIE WYKONANO WYPŁATĘ");
                                listaPlatnosci.Add(placenieInfo);
                                double stan = Konwersja(stankonta.Text);
                                stan -= kwota;
                                stankonta.Text = stan.ToString("0.00", polskaKultura) + "zł";
                                historia_konta.Items.Add($"typ: wpłata | -{kwota.ToString("0.00", polskaKultura)}zł");
                            }
                            else
                            {
                                MessageBox.Show("NIE MOŻNA PRZEKROCZYĆ STANU KONTA");
                            }
                        }
                        else if (kwota == 0)
                        {
                            MessageBox.Show("Podano zerową kwotę");
                        }
                        else
                        {
                            MessageBox.Show("Podano ujemną kwotę");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podano złą kwotę");
                    }
                }
                else
                {
                    MessageBox.Show("Podano zły format");
                }
            }
            else
            {
                MessageBox.Show("Nie podano kwoty");
            }
        }

        private int currentX = 50;
        private int currentY = 50;
        private int margin = 150;
        private int spacingY = 30;
        private Dictionary<TextBox, CheckBox> textBoxCheckBoxPairs = new Dictionary<TextBox, CheckBox>();

        private void nowy_wydatek_Click(object sender, EventArgs e)
        {
            if (nazwa_odbiorcy.Text.Length <= 15)
            {
                if (double.TryParse(kwota_przelewu.Text, out double kwota))
                {
                    if (kwota > 0)
                    {


                        if (currentY + spacingY < 290)
                        {
                            label17.Text = "";
                            CheckBox newCheckBox = new CheckBox();
                            TextBox newTextBox = new TextBox();

                            newCheckBox.Text = nazwa_odbiorcy.Text;
                            newTextBox.Text = kwota.ToString();

                            newCheckBox.Location = new Point(currentX, currentY);
                            newTextBox.Location = new Point(currentX, currentY + spacingY);

                            tabPage4.Controls.Add(newCheckBox);
                            tabPage4.Controls.Add(newTextBox);

                            textBoxCheckBoxPairs.Add(newTextBox, newCheckBox);

                            currentX += margin;

                            if (currentX + spacingY > tabPage4.Width)
                            {
                                currentX = 50;
                                currentY += newCheckBox.Height + spacingY;
                            }
                        }
                        else
                        {
                            MessageBox.Show("NIE MOŻNA DODAĆ WIĘCEJ STAŁYCH WYDATKÓW");
                        }
                    }
                    else if (kwota == 0)
                    {
                        MessageBox.Show("Podano zerową kwotę");
                    }
                    else
                    {
                        MessageBox.Show("Podano ujemną kwotę");
                    }
                }
                else
                {
                    MessageBox.Show("Zły format kwoty przelewu");
                }
            }
            else
            {
                MessageBox.Show("Za długa nazwa odbiorcy");
            }
        }

        private void oplac_Click(object sender, EventArgs e)
        {
            PlacenieInfo placenieInfo = new PlacenieInfo
            {
                Typplacy = "przelew automatyczny",
                Kwota = "+" + wplata.Text + "zł"
            };
            double kwota = 0;
            foreach(var check in textBoxCheckBoxPairs)
            {
                if (check.Value.Checked)
                {
                    kwota += double.Parse(check.Key.Text);
                }
            }
            if (kwota > 0)
            {
                MessageBox.Show("Pomyślnie wykonano automatyczny przelew");
                listaPlatnosci.Add(placenieInfo);
                double stan = Konwersja(stankonta.Text);
                stan -= kwota;
                stankonta.Text = stan.ToString("0.00", polskaKultura) + "zł";
                historia_konta.Items.Add($"typ: przelew automatyczny | -{kwota.ToString("0.00", polskaKultura)}zł");
            }
            else if( kwota == 0 )
            {
                MessageBox.Show("Płatność jest zerowa");
            }
            else
            {
                MessageBox.Show("Płatność jest ujemna");
            }
        }


        private void platonscch_CheckedChanged(object sender, EventArgs e)
        {
            if (platonscch.Checked)
            {
                typ_platonscir.Visible = true;
                kwota_platnoscir.Visible = true;
            }
            else
            {
                typ_platonscir.Visible = false;
                kwota_platnoscir.Visible = false;
            }
        }

        private void przelewch_CheckedChanged(object sender, EventArgs e)
        {
            if (przelewch.Checked)
            {
                numer_kontar.Visible = true;
                nazwa_odbiorcyr.Visible = true;
                kwota_przelewur.Visible = true;
                tytul_przelewur.Visible = true;
            }
            else
            {
                numer_kontar.Visible = false;
                nazwa_odbiorcyr.Visible = false;
                kwota_przelewur.Visible = false;
                tytul_przelewur.Visible = false;
            }
        }
        private void wyszukaj_Click(object sender, EventArgs e)
        {
            historia_transakcji.Items.Clear();

            if (przelewch.Checked)
            {
                if (numer_kontar.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.NumerKonta == fraza.Text);

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                if (nazwa_odbiorcyr.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.NazwaOdbiorcy == fraza.Text);

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                if (kwota_przelewur.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.Kwota == double.Parse(fraza.Text));

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                if (tytul_przelewur.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.TytulPrzelewu == fraza.Text);

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
            }
            if (platonscch.Checked)
            {
                if (typ_platonscir.Checked)
                {
                    var wyniki = listaPlatnosci.Where(p => p.Typplacy == fraza.Text);

                    foreach (var platnosc in wyniki)
                    {
                        historia_transakcji.Items.Add($"Typ: {platnosc.Typplacy}, Kwota: {platnosc.Kwota} zł");
                    }
                }
                if (kwota_platnoscir.Checked)
                {
                    var wyniki = listaPlatnosci.Where(p => p.Kwota == fraza.Text);

                    foreach (var platnosc in wyniki)
                    {
                        historia_transakcji.Items.Add($"Typ: {platnosc.Typplacy}, Kwota: {platnosc.Kwota} zł");
                    }
                }
            }
        }

    }

}

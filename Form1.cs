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
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Budżet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
        }
        CultureInfo polskaKultura = new CultureInfo("pl-PL");
        public class PrzelewInfo
        {
            public string NazwaOdbiorcy { get; set; }
            public double Kwota { get; set; }
            public string NumerKonta { get; set; }
            public string TytulPrzelewu { get; set; }
            public bool czyautom {  get; set; }
        }
        public class PlacenieInfo
        {
            public string Typplacy { get; set; }
            public string Kwota { get; set; }
        }
        public class user
        {
            public string ImieiNazw { get; set; }
            public string Haslo { get; set; }
            public string NumerKonta { get; set; }
            public string Pesel { get; set; }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                user otherUser = (user)obj;
                return Pesel == otherUser.Pesel && ImieiNazw == otherUser.ImieiNazw;
            }
            public override int GetHashCode()
            {
                return (ImieiNazw != null ? ImieiNazw.GetHashCode() : 0) ^ (Pesel != null ? Pesel.GetHashCode() : 0);
            }
        }
        private HashSet<user> users = new HashSet<user>();
        private List<PrzelewInfo> listaPrzelewow = new List<PrzelewInfo>();
        private List<PrzelewInfo> listaPrzelewowautom = new List<PrzelewInfo>();
        private List<PlacenieInfo> listaPlatnosci = new List<PlacenieInfo>();
        private Dictionary<int, List<object>> usersDataDictionary = new Dictionary<int, List<object>>();
        private int nextkey = 1;
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Witamy w Programie!!!");
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(documentsPath, "usersDataDictionary.json");
            if (File.Exists(filePath))
            {
                MessageBox.Show("Ścieżka pliku jest poprawna");
                usersDataDictionary = UserDataManager.LoadUsers(filePath);
                Sciaganie();
                File.Delete(filePath);
            }
            else
            {
                MessageBox.Show("Ścieżka pliku nie jest poprawna");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Dowidzenia :-)");
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(documentsPath, "usersDataDictionary.json");
            usersDataDictionary = Laczenie(usersDataDictionary);
            foreach (List<object> value in usersDataDictionary.Values)
            {
                if (value.GetType() is List<user>)
                    value.Distinct();
            }
            UserDataManager.SaveUsers(usersDataDictionary, filePath);
        }

        public Dictionary<int, List<object>> Laczenie(Dictionary<int, List<Object>> usersDataDictionary)
        {
            int key = nextkey++;
            usersDataDictionary.Clear();
            HashSet<object> uniqueValues = new HashSet<object>();
            var uniqueUsers = users.Distinct();
            foreach (var user in uniqueUsers)
            {
                if (!uniqueValues.Contains(user.Pesel))
                {
                    uniqueValues.Add(user);
                }
            }

            foreach (var przelew in listaPrzelewow)
            {
                if (!uniqueValues.Contains(przelew))
                {
                    uniqueValues.Add(przelew);
                }
            }

            foreach (var przelewautom in listaPrzelewowautom)
            {
                if (!uniqueValues.Contains(przelewautom))
                {
                    uniqueValues.Add(przelewautom);
                }
            }

            foreach (var platnosc in listaPlatnosci)
            {
                if (!uniqueValues.Contains(platnosc))
                {
                    uniqueValues.Add(platnosc);
                }
            }

            if (!usersDataDictionary.ContainsKey(key))
            {
                usersDataDictionary.Add(key, new List<object>());
            }

            foreach (var value in uniqueValues)
            {
                if (!usersDataDictionary[key].Contains(value))
                {
                    if (value is user)
                    {
                        foreach (user user in uniqueValues)
                        {
                            if (!usersDataDictionary[key].Contains(user.Pesel))
                            {
                                usersDataDictionary[key].Add(value);
                            }
                        }
                    }
                    else
                    {
                        usersDataDictionary[key].Add(value);
                    }
                }
            }

            return usersDataDictionary;
        }


        public void Sciaganie()
        {
            foreach (var obiekt in usersDataDictionary)
            {
                int key = obiekt.Key;
                List<object> dataList = obiekt.Value;
                foreach (JObject obj in dataList)
                {
                    if (obj is JObject)
                    {
                        if (IsValidUserObject(obj))
                        {
                            user newUser = obj.ToObject<user>();
                            users.Add(newUser);
                        }
                        else if (IsValidprzelewObject(obj))
                        {
                            PrzelewInfo newprzelew = obj.ToObject<PrzelewInfo>();
                            listaPrzelewow.Add(newprzelew);
                        }
                        else if (IsValidplatnoscObject(obj))
                        {
                            PlacenieInfo newplatnosc = obj.ToObject<PlacenieInfo>();
                            listaPlatnosci.Add(newplatnosc);
                        }
                        else if (IsValidprzelewautomObject(obj))
                        {
                            PrzelewInfo newplacenieautom = obj.ToObject<PrzelewInfo>();
                            listaPrzelewowautom.Add(newplacenieautom);
                        }
                        else
                        {
                            MessageBox.Show("Ma inną wartość" + obj.GetType().ToString());
                            MessageBox.Show(obj.ToString());
                        }
                    }
                }
            }
        }

        private static bool IsValidUserObject(JObject obj)=>obj["ImieiNazw"] != null && obj["Haslo"]!=null && obj["NumerKonta"]!=null && obj["Pesel"]!=null;
        private static bool IsValidprzelewObject(JObject obj)=> obj["Nazwa"]!=null &&  obj["Kwota"]!=null && obj["TytulPrzelewu"]!=null && obj["czyautom"].Value<bool>()==false;
        private static bool IsValidplatnoscObject(JObject obj) => obj["Typplacy"]!=null && obj["Kwota"]!=null;
        private static bool IsValidprzelewautomObject(JObject obj) => obj["NazwaOdbiorcy"]!=null && obj["Kwota"]!=null && obj["TytulPrzelewu"]!=null && obj["czyautom"].Value<bool>() == true;
/*        public static bool HasProperty(object obj, string propertyName)
        {
            if (obj == null)
                return false;

            var objectType = obj.GetType();
            var property = objectType.GetProperty(propertyName);

            return property != null;
        }*/
        public class UserDataManager
        {
            public static void SaveUsers(Dictionary<int, List<object>> usersDataDictionary, string filePath)
            {
                string json = JsonConvert.SerializeObject(usersDataDictionary);
                File.WriteAllText(filePath, json);
            }

            public static Dictionary<int, List<object>> LoadUsers(string filePath)
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Pomyślnie Pobrano");
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<Dictionary<int, List<object>>>(json);
                }
                else
                {
                    return new Dictionary<int, List<object>>();
                }
            }
        }
        private void wyslij_Click(object sender, EventArgs e)
        {
            foreach (var usr in users)
            {
                if (numer_konta.Text == usr.NumerKonta)
                {
                    if (!(string.IsNullOrEmpty(nazwa_odbiorcy.Text) || string.IsNullOrEmpty(kwota_przelewu.Text) || string.IsNullOrEmpty(numer_konta.Text) || string.IsNullOrEmpty(tytul_przelewu.Text)))
                    {
                        if (double.TryParse(kwota_przelewu.Text, out double kwota))
                        {
                            if (!double.IsNaN(kwota))
                            {
                                if (kwota > 0)
                                {
                                    if (kwota <= Konwersja(stankonta.Text))
                                    {
                                        PrzelewInfo przelewInfo = new PrzelewInfo
                                        {
                                            NazwaOdbiorcy = nazwa_odbiorcy.Text,
                                            Kwota = double.Parse(kwota_przelewu.Text),
                                            NumerKonta = numer_konta.Text,
                                            TytulPrzelewu = tytul_przelewu.Text,
                                            czyautom = false
                                        };
                                        PlacenieInfo placenieInfo = new PlacenieInfo
                                        {
                                            Typplacy = "przelew",
                                            Kwota = "-" + kwota_przelewu.Text + "zł"
                                        };

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
                else
                {
                    MessageBox.Show("Brak odbiorcy w użytkownikach");
                }
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
            if (!string.IsNullOrEmpty(wplata.Text))
            {
                if (double.TryParse(wplata.Text, out double kwota))
                {
                    if (!double.IsNaN(kwota))
                    {
                        if (kwota > 0)
                        {
                            PlacenieInfo placenieInfo = new PlacenieInfo
                            {
                                Typplacy = "wpłata",
                                Kwota = "+" + wplata.Text + "zł"
                            };
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
                                PlacenieInfo placenieInfo = new PlacenieInfo
                                {
                                    Typplacy = "wypłata",
                                    Kwota = "-" + wyplata.Text + "zł"
                                };
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
            foreach (var usr in users)
            {
                if (numer_konta.Text == usr.NumerKonta)
                {
                    if (nazwa_odbiorcy.Text.Length <= 15 && !(string.IsNullOrEmpty(nazwa_odbiorcy.Text) || string.IsNullOrEmpty(kwota_przelewu.Text) || string.IsNullOrEmpty(numer_konta.Text) || string.IsNullOrEmpty(tytul_przelewu.Text)))
                    {
                        if (double.TryParse(kwota_przelewu.Text, out double kwota))
                        {
                            if (kwota > 0 && Konwersja(stankonta.Text) >= kwota)
                            {


                                if (currentY + spacingY < 290)
                                {
                                    PrzelewInfo przelewInfo = new PrzelewInfo
                                    {
                                        NazwaOdbiorcy = nazwa_odbiorcy.Text,
                                        Kwota = double.Parse(kwota_przelewu.Text),
                                        NumerKonta = numer_konta.Text,
                                        TytulPrzelewu = tytul_przelewu.Text,
                                        czyautom = true
                                    };
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
                                    listaPrzelewowautom.Add(przelewInfo);
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
                        MessageBox.Show("Wprowadzono złe dane");
                    }
                }
                else
                {
                    MessageBox.Show("Brak odbiorcy w użytkownikach");
                }
            }
        }

        private void oplac_Click(object sender, EventArgs e)
        {
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
                if (Konwersja(stankonta.Text) >= kwota)
                {
                    PlacenieInfo placenieInfo = new PlacenieInfo
                    {
                        Typplacy = "przelew automatyczny",
                        Kwota = "+" + wplata.Text + "zł"
                    };
                    MessageBox.Show("Pomyślnie wykonano automatyczny przelew");
                    foreach (var check in textBoxCheckBoxPairs)
                    {
                        if (check.Value.Checked)
                        {
                            foreach (var przelew in listaPrzelewowautom)
                            {
                                przelew.czyautom = true;
                            }
                        }
                    }
                    listaPlatnosci.Add(placenieInfo);
                    double stan = Konwersja(stankonta.Text);
                    stan -= kwota;
                    stankonta.Text = stan.ToString("0.00", polskaKultura) + "zł";
                    historia_konta.Items.Add($"typ: przelew automatyczny | -{kwota.ToString("0.00", polskaKultura)}zł");
                }
                else
                {
                    MessageBox.Show("Kwota przekracza budżet");
                }
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

        private void usun_wydatek_Click(object sender, EventArgs e)
        {
            var pairsToRemove = new List<TextBox>();

            foreach (var pair in textBoxCheckBoxPairs)
            {
                if (pair.Value.Checked)
                {
                    pairsToRemove.Add(pair.Key);
                }
            }

            foreach (var textBoxToRemove in pairsToRemove)
            {
                tabPage4.Controls.Remove(textBoxToRemove);
                tabPage4.Controls.Remove(textBoxCheckBoxPairs[textBoxToRemove]);

                textBoxCheckBoxPairs.Remove(textBoxToRemove);
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
                else if (nazwa_odbiorcyr.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.NazwaOdbiorcy == fraza.Text);

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                else if (kwota_przelewur.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.Kwota == double.Parse(fraza.Text));

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                else if (tytul_przelewur.Checked)
                {
                    var wyniki = listaPrzelewow.Where(p => p.TytulPrzelewu == fraza.Text);

                    foreach (var przelew in wyniki)
                    {
                        historia_transakcji.Items.Add($"Nazwa odbiorcy: {przelew.NazwaOdbiorcy}, Kwota: {przelew.Kwota} zł, Tytuł Przelewu: {przelew.TytulPrzelewu}");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano opcji przelewu");
                }
            }else if (platonscch.Checked)
            {
                if (typ_platonscir.Checked)
                {
                    var wyniki = listaPlatnosci.Where(p => p.Typplacy == fraza.Text);

                    foreach (var platnosc in wyniki)
                    {
                        historia_transakcji.Items.Add($"Typ: {platnosc.Typplacy}, Kwota: {platnosc.Kwota} zł");
                    }
                }
                else if (kwota_platnoscir.Checked)
                {
                    var wyniki = listaPlatnosci.Where(p => p.Kwota == fraza.Text);

                    foreach (var platnosc in wyniki)
                    {
                        historia_transakcji.Items.Add($"Typ: {platnosc.Typplacy}, Kwota: {platnosc.Kwota} zł");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano opcji platnosci");
                }
            }
            else
            {
                MessageBox.Show("Nic nie wybrano");
            }

        }
        private void logowanie_CheckedChanged(object sender, EventArgs e)
        {
            if (logowanie.Checked)
            {
                imieinazw.Text = "Login:";
                podp.SetToolTip(nazwauzytkownia, "Podaj Pesel");
                nazwauzytkownia.Text = "";
                haslobox.Text = "";
                przejdz_dalej.Visible = true;
                doduztyk.Visible = false;
                nazwauzytkownia.Visible = true;
                imieinazw.Visible = true;
                haslo.Visible = true;
                haslobox.Visible = true;
            }
        }

        private void rejestrowanie_CheckedChanged(object sender, EventArgs e)
        {
            if (rejestrowanie.Checked)
            {
                numer_kontalog.Visible = true;
                pesel.Visible = true;
                imieinazw.Text = "Imie i Nazwisko:";
                nr_kon.Visible = true;
                pes.Visible = true;
                podp.SetToolTip(nazwauzytkownia, "Podaj Imie i Nazwisko");
                wymhas.Active = true;
                wymhas.SetToolTip(haslobox, "8 znaków");
                przejdz_dalej.Visible = false;
                doduztyk.Visible = true;
                nazwauzytkownia.Text = "";
                haslobox.Text = "";
                numer_kontalog.Text = "";
                pesel.Text = "";
                nazwauzytkownia.Visible = true;
                imieinazw.Visible = true;
                haslo.Visible = true;
                haslobox.Visible = true;
            }
            else
            {
                numer_kontalog.Visible = false;
                pesel.Visible = false;
                nr_kon.Visible = false;
                pes.Visible = false;
                wymhas.Active = false;
            }
        }

        private void przejdz_dalej_Click(object sender, EventArgs e)
        {
            foreach (var usr in users)
            {
                if (usr.Pesel == nazwauzytkownia.Text.Trim() && usr.Haslo == haslobox.Text.Trim())
                {
                    MessageBox.Show("Pomyślnie Zalogowano");
                    pictureBox1.Visible = false;
                    panel1.Visible = false;
                    konto_imie.Text = usr.ImieiNazw;
                    konto_numerkonta.Text = usr.NumerKonta;
                    return;
                }
            }
        }

        private void doduztyk_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(nazwauzytkownia.Text)) && haslobox.Text.Length >= 8 && numer_kontalog.Text.Length >= 24 && pesel.Text.Length == 11)
            {
                if (users.Any(u => u.Pesel == pesel.Text))
                {
                    MessageBox.Show("Użytkownik o podanym PESEL już istnieje");
                }
                else
                {
                    user user = new user
                    {
                        ImieiNazw = nazwauzytkownia.Text.Trim(),
                        Haslo = haslobox.Text.Trim(),
                        NumerKonta = numer_kontalog.Text.Trim(),
                        Pesel = pesel.Text.Trim(),
                    };
                    users.Add(user);
                    MessageBox.Show("Pomyślnie Utworzono Użytkownika");
                }
            }
            else
            {
                MessageBox.Show("Nie spełniono wymogów");
            }
        }

        private void nazwauzytkownia_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

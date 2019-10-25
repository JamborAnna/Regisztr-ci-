using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Regisztracio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine("Név:{0}", NevTextBox);
                        sw.WriteLine("Születési dátum:{0}", SzulDat);
                        if (RdiButF.Checked)
                        {
                            sw.WriteLine("Nem:Férfi");
                        }
                        else if (RdoBtnN.Checked)
                        {
                            sw.WriteLine("Nem:Nő");
                        }
                        else
                        {
                            MessageBox.Show("Nincs kiválasztva nem!");
                        }
                        sw.WriteLine("Kedvenc hobbi:{0}", HobbiLstBx);
                        sw.WriteLine("Új kedvenc hobbi:{0}", HobbiTxtBx);
                        sw.Close();
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba!Nem sikerült a kiírás");
                }
            };
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);

                    NevTextBox.Text = sorok[0];

                    SzulDat.Text = sorok[1];

                    if (sorok[2] == "férfi")
                    {
                        RdiButF.Checked = true;
                        RdoBtnN.Checked = false;
                    }
                    else
                    {
                        RdoBtnN.Checked = true;
                        RdiButF.Checked = false;
                    }
                    string elem;

                    if (! HobbiLstBx.Items.Contains(sorok[3]))

                    {

                        HobbiLstBx.Items.Add(sorok[3]);

                        HobbiLstBx.SelectedItem = sorok[3];

                    }

                    else

                    {

                        foreach (var item in sorok)
                        {
                            if (item == sorok[3])
                            {
                                HobbiLstBx.SelectedItem.Equals(item);
                            }
                        }
                    }
                }

                catch (IOException)

                {

                    MessageBox.Show("Hiba! Sikertelen betöltés");

                }

            };
        }

        

        private void Mentesbtn_Click(object sender, EventArgs e)
        {
            if (NevTextBox.Text!="" && SzulDat.Text!=" " && (RdiButF.Checked || RdoBtnN.Checked) && HobbiLstBx.SelectedIndex!=-1)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Valami nincs kitöltve!");
            }

        }

        private void NevTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HozzaadBtn_Click(object sender, EventArgs e)
        {
            HobbiLstBx.Items.Add(HobbiTxtBx.Text);

            HobbiTxtBx.Text = "";
        }

        private void HozzaadBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {

                HobbiLstBx.Items.Add(HobbiTxtBx.Text);

                HobbiTxtBx.Text = "";

            }
        }

        private void Betoltesbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}

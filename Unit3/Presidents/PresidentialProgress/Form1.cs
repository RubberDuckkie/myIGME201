using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace PresidentialProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.benjaminHarrisonRadioButton.CheckedChanged += new EventHandler(BenjaminHarrisonRadioButton__CheckedChanged);
            this.franklinDRooseveltRadioButton.CheckedChanged += new EventHandler(FranklinDRooseveltRadioButton__CheckedChanged);
            this.williamJClintonRadioButton.CheckedChanged += new EventHandler(WilliamJClintonRadioButton__CheckedChanged);
            this.jamesBuchananRadioButton.CheckedChanged += new EventHandler(JamesBuchananRadioButton__CheckedChanged);
            this.franklinPierceRadioButton.CheckedChanged += new EventHandler(FranklinPierceRadioButton__CheckedChanged);
            this.georgeWBushRadioButton.CheckedChanged += new EventHandler(GeorgeWBushRadioButton__CheckChanged);
            this.barackObamaRadioButton.CheckedChanged += new EventHandler(BarackObamaRadioButton__CheckedChanged);
            this.johnFKennedyRadioButton.CheckedChanged += new EventHandler(JohnFKennedyRadioButton__CheckedChanged);
            this.williamMcKinleyRadioButton.CheckedChanged += new EventHandler(WilliamMcKinleyRadioButton__CheckedChanged);
            this.ronaldReaganRadioButton.CheckedChanged += new EventHandler(RonaldReaganRadioButton__CheckedChanged);
            this.dwightDEisenhowerRadioButton.CheckedChanged += new EventHandler(DwightDEisenhowerRadioButton__CheckedChanged);
            this.martinVanBurenRadioButton.CheckedChanged += new EventHandler(MartinVanBurenRadioButton__CheckedChanged);
            this.georgeWashingtonRadioButton.CheckedChanged += new EventHandler(GeorgeWashingtonRadioButton__CheckedChanged);
            this.johnAdamsRadioButton.CheckedChanged += new EventHandler(JohnAdamsRadioButton__CheckedChanged);
            this.theodoreRooseveltRadioButton.CheckedChanged += new EventHandler(TheodoreRooseveltRadioButton__CheckedChanged);
            this.thomasJeffersonRadioButton.CheckedChanged += new EventHandler(ThomasJeffersonRadioButton__CheckedChanged);

            this.benjaminHarrisonTextBox.Click += new EventHandler(BenjaminHarrisonTextBox__Click);
            this.franklinDRooseveltTextBox.Click += new EventHandler(FranklinDRooseveltTextBox__Click);
            this.williamJClintonTextBox.Click += new EventHandler(WilliamJClintonTextBox__Click);
            this.jamesBuchananTextBox.Click += new EventHandler(JamesBuchananTextBox__Click);
            this.franklinPierceTextBox.Click += new EventHandler(FranklinPierceTextBox__Click);
            this.georgeWBushTextBox.Click += new EventHandler(GeorgeWBushTextBox__Click);
            this.barackObamaTextBox.Click += new EventHandler(BarackObamaTextBox__Click);
            this.johnFKennedyTextBox.Click += new EventHandler(JohnFKennedyTextBox__Click);
            this.williamMcKinleyTextBox.Click += new EventHandler(WilliamMcKinleyTextBox__Click);
            this.ronaldReaganTextBox.Click += new EventHandler(RonaldReaganTextBox__Click);
            this.dwightDEisenhowerTextBox.Click += new EventHandler(DwightDEisenhowerTextBox__Click);
            this.martinVanBurenTextBox.Click += new EventHandler(MartinVanBurenTextBox__Click);
            this.georgeWashingtonTextBox.Click += new EventHandler(GeorgeWashingtonTextBox__Click);
            this.johnAdamsTextBox.Click += new EventHandler(JohnAdamsTextBox__Click);
            this.theodoreRooseveltTextBox.Click += new EventHandler(TheodoreRooseveltTextBox__Click);
            this.thomasJeffersonTextBox.Click += new EventHandler(ThomasJeffersonTextBox__Click);

            this.allRadioButton.Click += new EventHandler(allRadioButton__Click);
            this.democratRadioButton.Click += new EventHandler(democratRadioButton__Click);
            this.republicanRadioButton.Click += new EventHandler(republicanRadioButton__Click);
            this.demopublicanRadioButton.Click += new EventHandler(demopublicanRadioButton__Click);
            this.federalistRadioButton.Click += new EventHandler(federalistRadioButton__Click);

            

            this.timer1.Tick += new EventHandler(Timer_Tick);

            this.Text = "Presidents";



        }


        private void BenjaminHarrisonRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.BenjaminHarrison;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FranklinDRooseveltRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Franklin_Roosevelt";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.FranklinDRoosevelt;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void WilliamJClintonRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/William_Clinton";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.WilliamJClinton;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void JamesBuchananRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.JamesBuchanan;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FranklinPierceRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.FranklinPierce;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GeorgeWBushRadioButton__CheckChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.GeorgeWBush;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void BarackObamaRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.BarackObama;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void JohnFKennedyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            String address = "https://en.m.wikipedia.org/wiki/John_Kennedy";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.JohnFKennedy;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void WilliamMcKinleyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            String address = "https://en.m.wikipedia.org/wiki/William_McKinley";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.WilliamMcKinley;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RonaldReaganRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.RonaldReagan;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void DwightDEisenhowerRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Dwight_Eisenhower";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.DwightDEisenhower;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MartinVanBurenRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.MartinVanBuren;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GeorgeWashingtonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            String address = "https://en.m.wikipedia.org/wiki/George_Washington";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.GeorgeWashington;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void JohnAdamsRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/John_Adams";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.JohnAdams;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void TheodoreRooseveltRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.TheodoreRoosevelt;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ThomasJeffersonRadioButton__CheckedChanged(object sender, EventArgs e) {
            String address = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            webBrowser1.Navigate(new Uri(address));
            groupBox1.Text = address;
            pictureBox1.BackgroundImage = Properties.Resources.ThomasJefferson;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 500;
            this.toolStripProgressBar1.Value = 60;
            

            --this.toolStripProgressBar1.Value;
        }

        private void BenjaminHarrisonTextBox__Click(object sender, EventArgs e) {
            this.timer1.Start();

        }
        private void FranklinDRooseveltTextBox__Click(object sender, EventArgs e) { }
        private void WilliamJClintonTextBox__Click(object sender, EventArgs e) { }
        private void JamesBuchananTextBox__Click(object sender, EventArgs e) { }
        private void FranklinPierceTextBox__Click(object sender, EventArgs e) { }
        private void GeorgeWBushTextBox__Click(object sender, EventArgs e) { }
        private void BarackObamaTextBox__Click(object sender, EventArgs e) { }
        private void JohnFKennedyTextBox__Click(object sender, EventArgs e) { }
        private void WilliamMcKinleyTextBox__Click(object sender, EventArgs e) { }
        private void RonaldReaganTextBox__Click(object sender, EventArgs e) { }
        private void DwightDEisenhowerTextBox__Click(object sender, EventArgs e) { }
        private void MartinVanBurenTextBox__Click(object sender, EventArgs e) { }
        private void GeorgeWashingtonTextBox__Click(object sender, EventArgs e) { }
        private void JohnAdamsTextBox__Click(object sender, EventArgs e) { }
        private void TheodoreRooseveltTextBox__Click(object sender, EventArgs e) { }
        private void ThomasJeffersonTextBox__Click(object sender, EventArgs e) { }



        private void allRadioButton__Click(object sender, EventArgs e) { }
        private void democratRadioButton__Click(object sender, EventArgs e) { }

        private void republicanRadioButton__Click(object sender, EventArgs e) { }

        private void demopublicanRadioButton__Click(object sender, EventArgs e) { }
        private void federalistRadioButton__Click(object sender, EventArgs e) { }


    
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void jamesBuchananRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogunwale_PE20
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            // if example.html is saved in c:\temp
            this.webBrowser1.Navigate("c:\\temp\\example.html");
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }



         

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "My UFO Page";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "My UFO Info";
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "My UFO Pictures";
            htmlElement = htmlElementCollection[2];
            htmlElement.InnerHtml = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #E1403E";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>UFO!</a>";
            htmlElement.Style += "font-color: #23E73A; font-weight: bold; font-size: 2em; text-fransform: uppercase; text-shadow: 3px 2px #A44";
            htmlElementCollection[1].InnerText = "";

            htmlElement = htmlElementCollection[2];
            htmlElement.SetAttribute("src", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.baynews9.com%2Ffl%2Ftampa%2Falbany-newsmakers%2F2020%2F08%2F27%2Fcalifornia-and-florida-report-most-ufo-sightings&psig=AOvVaw2Yzt9n4cqasTX_aAt_M9pg&ust=1603565678188000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMip5POxy-wCFQAAAAAdAAAAABAD");

            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy;2020 <a href='https://people.rit.edu/mo1439/'>Michael Ogunwale</a>";
            webBrowser.Document.Body.AppendChild(htmlElement);



        }


    }
}

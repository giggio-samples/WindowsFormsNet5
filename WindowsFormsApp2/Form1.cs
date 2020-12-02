using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView21.Source = new("https://mobile.twitter.com/giovannibassi");
            List<Pessoa> pessoas = new()
            {
                new("Giovanni", "https://mobile.twitter.com/giovannibassi"),
                new("VC", "https://mobile.twitter.com/victorhg"),
                new("VH", "https://mobile.twitter.com/vcavalcante"),
            };
            radList.DataSource = pessoas;
            radList.DisplayMember = nameof(Pessoa.Nome);
            radList.Font = new("Consolas", 14);
            radList.ListElement.Font = radList.Font;
            radList.ListElement.Font = new("Consolas", 24);
            radList.ListElement.AutoSizeItems = true;
        }


        private void radList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) =>
            webView21.Source = new(((Pessoa)radList.SelectedItem.DataBoundItem).Url);
    }
    record Pessoa(string Nome, string Url);
}

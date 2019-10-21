using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorris_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategoriesList();
        }

        private async void BtnGetJoke_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show($"{j.JokeText.ToString()}");        
        }

        private async void PopulateCategoriesList() 
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            cboCategories.DataSource = categories.ToList();
        }

 
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_await
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void textLoad_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.Filter = "json | *.json";
            openFileDialog.ShowDialog();
            textLoad.Text = openFileDialog.FileName;
        }

        private void textLoad_TextChanged(object sender, EventArgs e)
        {
            buttonLoad.Enabled = (textLoad.Text.Length != 0);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!People.LoadFromPath(textLoad.Text))
            {
                MessageBox.Show("Aquest arxiu no es valid o no conté el format correcte.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            comboCountry.Items.Add("");
            comboCompany.Items.Add("");
            comboGender.Items.Add("");

            People.PeopleList.ForEach(p =>
            {
                listPeople.Items.Add(p.ToString());

                if (!comboCountry.Items.Contains(p.Country))
                    comboCountry.Items.Add(p.Country);

                if (!comboCompany.Items.Contains(p.Company))
                    comboCompany.Items.Add(p.Company);

                if (!comboGender.Items.Contains(p.Gender))
                    comboGender.Items.Add(p.Gender);
            });
            textSearch.Enabled 
                = buttonSearch.Enabled
                = comboCountry.Enabled 
                = comboCompany.Enabled 
                = comboGender.Enabled = true;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPeople();
        }

        public async void SearchPeople()
        {
            Stopwatch clock = new Stopwatch();
            clock.Restart();

            string strCountry = comboCountry.SelectedItem != null ? comboCountry.SelectedItem.ToString() : "";
            string strGender = comboGender.SelectedItem != null ? comboGender.SelectedItem.ToString() : "";
            string strCompany = comboCompany.SelectedItem != null ? comboCompany.SelectedItem.ToString() : "";
            string strText = textSearch.Text;

            listPeople.Items.Clear();
            List<Person> peopleList = People.PeopleList;
            await Task.Run(() =>
            {
                peopleList = peopleList.Where(p => ((strCountry.Length == 0 || strCountry == p.Country)
                        && (strGender.Length == 0 || strGender == p.Gender)
                        && (strCompany.Length == 0 || strCompany == p.Company)
                        && (strText.Length == 0 || p.ToPureString().IndexOf(strText) != -1))).ToList();
            });
            peopleList.ForEach(p => listPeople.Items.Add(p.ToString()));

            clock.Stop();
            labelLoadTime.Text = clock.Elapsed.TotalSeconds.ToString() + " segons";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LessonFormsCSharp
{
    public partial class Form1 : Form
    {
        Country Russian = new Country("Россия", @"rus.jpg");
        Country USA = new Country("США", @"usa.jpg");
        Country Chine = new Country("Китай", @"chi.jpg");
        Country Englsh = new Country("Англия", @"eng.jpg");
        Country German = new Country("Германия", @"ger.jpg");

        List<Country> countries;
        Image icon;

        public Form1()
        {
            InitializeComponent();

            Russian.AddCity("Москва 5000000", "Петербург 2000000", "Екатеринбург 1000000", "Мурманск 700000", "Омск 300000");
            USA.AddCity("Нью-Йорк 5000000", "Вашингтон 5000000", "Бостон 700000", "Флорида 300000", "Чикаго 300000");
            Chine.AddCity("Шанхай 5000000", "Гонконг 2000000", "Харбин 700000", "Санья 300000", "Пекин 5000000");
            Englsh.AddCity("Лондон 5000000", "Манчестер 1000000", "Ливерпуль 300000", "Ноттингем 700000", "Лестер 300000");
            German.AddCity("Берлин 5000000", "Гамбург 1000000", "Мюнхен 5000000", "Кёльн 300000", "Лейпциг 300000");

            countries = new List<Country>() { Russian, USA, Chine, Englsh, German };

            comboBox1.Text = "Страны: ";
            foreach (var countr in countries)
            {
                comboBox1.Items.Add(countr.GetName());
            }

            listView1.SmallImageList = imageList1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SetListView(countries[0]);
            else if (comboBox1.SelectedIndex == 1) SetListView(countries[1]);
            else if (comboBox1.SelectedIndex == 2) SetListView(countries[2]);
            else if (comboBox1.SelectedIndex == 3) SetListView(countries[3]);
            else if (comboBox1.SelectedIndex == 4) SetListView(countries[4]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) countries[0].AddCity(textBox1.Text);
            else if (comboBox1.SelectedIndex == 1) countries[1].AddCity(textBox1.Text);
            else if (comboBox1.SelectedIndex == 2) countries[2].AddCity(textBox1.Text);
            else if (comboBox1.SelectedIndex == 3) countries[3].AddCity(textBox1.Text);
            else if (comboBox1.SelectedIndex == 4) countries[4].AddCity(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) countries[0].DeleteCity(countries[0].GetCity(listView1.SelectedIndices[0]));
            else if (comboBox1.SelectedIndex == 1) countries[1].DeleteCity(countries[1].GetCity(listView1.SelectedIndices[0]));
            else if (comboBox1.SelectedIndex == 2) countries[2].DeleteCity(countries[2].GetCity(listView1.SelectedIndices[0]));
            else if (comboBox1.SelectedIndex == 3) countries[3].DeleteCity(countries[3].GetCity(listView1.SelectedIndices[0]));
            else if (comboBox1.SelectedIndex == 4) countries[4].DeleteCity(countries[4].GetCity(listView1.SelectedIndices[0]));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SetListView(countries[0], 100000);
            else if (comboBox1.SelectedIndex == 1) SetListView(countries[1], 100000);
            else if (comboBox1.SelectedIndex == 2) SetListView(countries[2], 100000);
            else if (comboBox1.SelectedIndex == 3) SetListView(countries[3], 100000);
            else if (comboBox1.SelectedIndex == 4) SetListView(countries[4], 100000);

            progressBar1.Value = 10;
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SetListView(countries[0], 100000, 500000);
            else if (comboBox1.SelectedIndex == 1) SetListView(countries[1], 100000, 500000);
            else if (comboBox1.SelectedIndex == 2) SetListView(countries[2], 100000, 500000);
            else if (comboBox1.SelectedIndex == 3) SetListView(countries[3], 100000, 500000);
            else if (comboBox1.SelectedIndex == 4) SetListView(countries[4], 100000, 500000);

            progressBar1.Value = 50;
        }
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SetListView(countries[0], 500000, 1000000);
            else if (comboBox1.SelectedIndex == 1) SetListView(countries[1], 500000, 1000000);
            else if (comboBox1.SelectedIndex == 2) SetListView(countries[2], 500000, 1000000);
            else if (comboBox1.SelectedIndex == 3) SetListView(countries[3], 500000, 1000000);
            else if (comboBox1.SelectedIndex == 4) SetListView(countries[4], 500000, 1000000);

            progressBar1.Value = 80;
        }
        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SetListView(countries[0], 1000000, 100000000);
            else if (comboBox1.SelectedIndex == 1) SetListView(countries[1], 1000000, 100000000);
            else if (comboBox1.SelectedIndex == 2) SetListView(countries[2], 1000000, 100000000);
            else if (comboBox1.SelectedIndex == 3) SetListView(countries[3], 1000000, 100000000);
            else if (comboBox1.SelectedIndex == 4) SetListView(countries[4], 1000000, 100000000);

            progressBar1.Value = 100;
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetListView(Country c)
        {
            listView1.Clear();
            icon = Image.FromFile(c.GetPatch());
            imageList1.Images.Clear();
            imageList1.Images.Add(icon);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.GetName();
            lvi.ImageIndex = 0;
            listView1.Items.Add(lvi);

            for (int elem = 0; elem < c.countCities(); elem++)
            {
                listView1.Items.Add(c.GetCity(elem).GetNameCity());
            }
        }
        private void SetListView(Country c, int population)
        {
            listView1.Clear();
            icon = Image.FromFile(c.GetPatch());
            imageList1.Images.Clear();
            imageList1.Images.Add(icon);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.GetName();
            lvi.ImageIndex = 0;
            listView1.Items.Add(lvi);

            for (int elem = 0; elem < c.countCities(); elem++)
            {
                if (c.GetCity(elem).GetPopulation() <= population)
                {
                    listView1.Items.Add(c.GetCity(elem).GetNameCity());
                }
            }
        }
        private void SetListView(Country c, int minPopulation, int maxPopulation)
        {
            listView1.Clear();
            icon = Image.FromFile(c.GetPatch());
            imageList1.Images.Clear();
            imageList1.Images.Add(icon);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.GetName();
            lvi.ImageIndex = 0;
            listView1.Items.Add(lvi);

            for (int elem = 0; elem < c.countCities(); elem++)
            {
                if ((c.GetCity(elem).GetPopulation() >= minPopulation) && 
                    (c.GetCity(elem).GetPopulation() <= maxPopulation))
                {
                    listView1.Items.Add(c.GetCity(elem).GetNameCity());
                }
            }
        }
    }
}


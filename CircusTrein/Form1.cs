using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        List<Animal> AllAnimals = new List<Animal>();
        List<TrainWagon> Train = new List<TrainWagon>();
        public static Random RNGenum = new Random();
        public static Random RNGmeat = new Random();
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 11; i++)
            {
                AllAnimals.Add(new Animal(i, RNGenum.Next(1,4) ,RNGmeat.Next(1,3)));
            }
            foreach (var item in AllAnimals)
            {
                listBox3.Items.Add(item.ID);
            }
            OrderTrain(AllAnimals);
            foreach (var item in Train)
            {
                listBox1.Items.Add(item.ID);
            }
        }

        private void OrderTrain(List<Animal> animals)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in AllAnimals)
            {
                if (item.ID == Convert.ToInt32(listBox3.GetItemText(listBox3.SelectedItem)))
                {
                    AnimalID.Text = Convert.ToString(item.ID);
                    AnimalSize.Text = Convert.ToString(item.Size);
                    AnimalMeatEater.Text = Convert.ToString(item.MeatEater);
                }
            }
            
        }
    }
}

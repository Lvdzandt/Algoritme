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
        Train Train;
        
        public Form1()
        {
            InitializeComponent();

            Train = new Train();
            Train.OrderWagon();
            Train.AddWagons(listBox1);
            Train.AllAnimals(listBox3);
            SizeBox.Items.Add(Animal.AnimalSize.small);
            SizeBox.Items.Add(Animal.AnimalSize.medium);
            SizeBox.Items.Add(Animal.AnimalSize.big);
            MeatEaterBox.Items.Add(true);
            MeatEaterBox.Items.Add(false);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (!int.TryParse(listBox1.GetItemText(listBox1.SelectedItem), out int id))
            {
                Console.WriteLine("{0} is not an integer", id);
            }
            else
            {
                id = Convert.ToInt32(listBox1.GetItemText(listBox1.SelectedItem));
            }

            Train.AddWagonAnimal(listBox2, id);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(listBox3.GetItemText(listBox3.SelectedItem), out int id))
            {
                Console.WriteLine("{0} is not an integer", id);
            }
            else
            {
                id = Convert.ToInt32(listBox3.GetItemText(listBox3.SelectedItem));
            }
            Train.AnimalInfo(listBox3, AnimalID, AnimalSize, AnimalMeatEater, id);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(listBox2.GetItemText(listBox2.SelectedItem), out int id))
            {
                Console.WriteLine("{0} is not an integer", id);
            }
            else
            {
                id = Convert.ToInt32(listBox2.GetItemText(listBox2.SelectedItem));
            }
            Train.AnimalInfo(listBox2, AnimalID, AnimalSize, AnimalMeatEater, id);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Train.OrderWagon();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Train.Animals.Count + 1;
            Animal.AnimalSize sizeget = (Animal.AnimalSize)Enum.Parse(typeof(Animal.AnimalSize), SizeBox.Text);
            bool Meateater = Convert.ToBoolean(MeatEaterBox.Text);
            Train.Animals.Add(new Animal(Train.Animals.Count+1,sizeget,Meateater));
            listBox3.Items.Add(id);
            Train.OrderWagon();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Train.AddWagons(listBox1);
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

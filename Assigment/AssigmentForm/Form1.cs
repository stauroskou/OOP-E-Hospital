using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assigment.Database;
using Assigment.Services;

namespace AssigmentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void roomBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormServices.ShowAllDoctors(dataGridView1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormServices.ShowAllPatients(dataGridView1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormServices.ShowAllRooms(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormServices.ShowAllDiseases(dataGridView1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FormServices.ShowAllAddresses(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
            
            
        }
    }
}

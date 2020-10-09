using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assigment.Database;

namespace Assigment.Services
{
    
    public class FormServices 
    {
        public static void ShowAllDoctors(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.doctors;
            a.DataSource = data;
            a.Columns["address"].Visible = false;
        }
        public static void ShowAllPatients(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.patients;
            a.DataSource = data;
            a.Columns["address"].Visible = false;
            a.Columns["doctor"].Visible = false;
            a.Columns["room"].Visible = false;
            a.Columns["disease"].Visible = false;
        }
        public static void ShowAllRooms(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.rooms;
            a.DataSource = data;
        }
        public static void ShowAllDiseases(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.diseases;
            a.DataSource = data;
        }
        public static void ShowAllAddresses(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.addresses;
            a.DataSource = data;
            
        }
        public static void ShowAlPatientsPerRoom(DataGridView a)
        {
            MyDatabase myDatabase = MyDatabase.GetInstance();
            var data = myDatabase.patients;
            a.DataSource = data;
        }
    }
}

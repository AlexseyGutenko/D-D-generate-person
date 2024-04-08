using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace D_D
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;//открытие окна по центру экрана
            race.Items.Add("Эльф");
            race.Items.Add("Человек");
            race.Items.Add("Гном");
            race.Items.Add("Полурослик");
            race.Items.Add("Дварф");
            race.Items.Add("Полуэльф");
        }

        string Race;

        private void generate_Click(object sender, EventArgs e)
        {
            string rce = $"select Id_Race from Race where Name_of_Race Like'Человек'";
            string name = $"select femalName from FemalName Where race_id='{rce}'";

            SqlDataAdapter adapter = new SqlDataAdapter();//создание адаптора
            DataTable table = new DataTable();//

            SqlCommand comman = new SqlCommand(rce, dataBase.GetConnection());
            SqlCommand command = new SqlCommand(name,dataBase.GetConnection());

            adapter.SelectCommand = comman;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            List<string> list = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(row.ToString());
            }

            int count = list.Count;

            string nam = list[random.Next(0, count - 1)];


            out_person.Text = count.ToString();
            out_person.Text += nam;


        }

        private void out_person_TextChanged(object sender, EventArgs e)
        {

        }

        private void downlode_Click(object sender, EventArgs e)
        {

        }

        private void race_SelectedIndexChanged(object sender, EventArgs e)
        {
            Race = race.Items[race.SelectedIndex].ToString();
        }
        
        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

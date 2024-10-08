using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISUchetPersonala
{
    public partial class FormAddDolg : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public FormAddDolg()
        {
            InitializeComponent();
        }

        public string get_cs()
        {
            return "Data Source=PC223-1;Initial Catalog=uchet_personala;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormDolgnost formadd = (FormDolgnost)this.Owner;

            connection = new SqlConnection("Data Source=pc223-1;Initial Catalog=uchet_personala;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(SELECT * FROM Dolgnosti)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewDolg.DataSource = table;
            this.Close();
        }
        private void BaddDolg_Click(object sender, EventArgs e)
        {
            FormDolgnost f1 = (FormDolgnost)this.Owner;
            f1.PassID_dolgnosti = tbID_Dolgnosti.Text;
            f1.PassNaimenovanie_dolgnosti = tbNaimenovanie_dolgnosti.Text;
            f1.PassOklad = tbOklad.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Должности?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID_Dolgnosti.Text) && !string.IsNullOrWhiteSpace(tbID_Dolgnosti.Text) &&
               !string.IsNullOrEmpty(tbNaimenovanie_dolgnosti.Text) && !string.IsNullOrWhiteSpace(tbNaimenovanie_dolgnosti.Text) &&
               !string.IsNullOrEmpty(tbOklad.Text) && !string.IsNullOrWhiteSpace(tbOklad.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Dolgnosti] (ID_dolgnosti, Naimenovanie_dolgnosti, Oklad) VALUES (@ID_dolgnosti, @Naimenovanie_dolgnosti, @Oklad)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_dolgnosti", tbID_Dolgnosti.Text);
                        cmd.Parameters.AddWithValue("Naimenovanie_dolgnosti", tbNaimenovanie_dolgnosti.Text);
                        cmd.Parameters.AddWithValue("Oklad", tbOklad.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID_Dolgnosti.Clear();
                    tbNaimenovanie_dolgnosti.Clear();
                    tbOklad.Clear();
                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }

        }

        private void BotmenaAddDolg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDolgnost main = new FormDolgnost();
            main.ShowDialog();
            connection.Close();
        }
    }
}


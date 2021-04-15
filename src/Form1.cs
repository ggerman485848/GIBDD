using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GIBDD
{
    public partial class Form1 : Form
    {
        private string connStr = "server=localhost;user=root;database=bd;password=root;";
        public Form1()
        {
            InitializeComponent();
            UpdateButton_Click(null, null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CarNumber.Text != String.Empty && FIO.Text != String.Empty && TypeChooser.SelectedItem != null && Summa.Text != String.Empty)
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    string sql = $"INSERT INTO `gibdd` VALUES('{CarNumber.Text}', '{FIO.Text}', '{DateNarush.Value.ToString("yyyy-MM-dd") + " " + TimeNarsuh.Value.ToString("HH:mm")}', '{TypeChooser.SelectedItem}', '{Summa.Text}')";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteScalar();
                    MessageBox.Show("Успех", "Состояние", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception f) { MessageBox.Show("Не удалось записать данные\nВозможно вы не правильно настроили базу данных"); }
                finally { conn.Close(); }
            }
            else 
            {
                MessageBox.Show("Вы не заполнили все обязательные поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "SELECT `autoID`, COUNT(*) FROM `gibdd` GROUP BY `autoID` HAVING COUNT(*) > 1";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    ListNarush.Items.Add(reader.GetString("autoID") + "   " + reader.GetString("COUNT(*)") + " шт");
                reader.Close();
            }
            catch (Exception f) { MessageBox.Show("Не удалось считать данные: \n" + f.ToString()); }
            finally { conn.Close(); }
        }

        private void Summa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}

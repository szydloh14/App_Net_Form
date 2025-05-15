using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace App_Net_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void wfmrpcDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wFMRPCDataSet1.RCP_register_events'. 
            // Możesz go przenieść lub usunąć.
            this.rCP_register_eventsTableAdapter.Fill(this.wFMRPCDataSet1.RCP_register_events);

            //wskaznik_liczba.TextAlign = ContentAlignment.TopRight;
            wskaznik_liczba.Text = "0 %"; // Domyślny tekst
            wskaznik_liczba.ReadOnly = true; // Ustawienie jako tylko do odczytu

            // 
            // dataGridView_baza
            // 
            //this.dataGridView_baza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.dataGridView_baza.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            //this.dataGridView_baza.CausesValidation = false;
            //this.dataGridView_baza.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dataGridView_baza.Location = new System.Drawing.Point(12, 56);
            //this.dataGridView_baza.Name = "dataGridView_baza";
            //this.dataGridView_baza.Size = new System.Drawing.Size(776, 391);
            //this.dataGridView_baza.TabIndex = 2;
        }

        private void rCPregistereventsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rCPregistereventsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadData()
        {
            string connectionString;

            // Connection string do bazy MySQL
            //connectionString = "Server=your_server;Database=your_database;User ID=your_user;Password=your_password;";
            connectionString = "server=10.10.30.200;uid=szydloh;pwd=Nevada14;database=rcp_wol";


            // Zapytanie SQL
            string query = "SELECT * FROM rcp_buffer";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Otwórz połączenie
                    connection.Open();

                    // Utwórz adapter danych
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    // Wypełnij DataTable
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Przypisz DataTable do DataGridView
                    dataGridView_baza.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Program do obsługi rejestracji zdarzeń w systemie RCP", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tabelaGłównaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program do obsługi rejestracji zdarzeń w systemie RCP", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void plikKonfiguracjyjnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TextEditorForm textEditorForm = new TextEditorForm();
            textEditorForm.Show();

            // Zamknij bieżący formularz
            this.Hide();
            textEditorForm.FormClosed += (s, args) => this.Close();

            
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Boolean     czy_usunac = false;
            int         i = 0;

            
            
                czy_usunac = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone rekordy?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (czy_usunac)
            {
                foreach (DataGridViewRow row in dataGridView_baza.SelectedRows)
                {
                    i++;
                    //dataGridView_baza.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Nie usunięto żadnych rekordów.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //MessageBox.Show("Program do obsługi rejestracji zdarzeń w systemie RCP", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void daneZRCPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void daneZRCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void okno2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Utwórz instancję Form2 (TextEditorForm)
            TextEditorForm textEditorForm = new TextEditorForm();

            // Subskrybuj zdarzenie zamknięcia Form2, aby przywrócić Form1
            textEditorForm.FormClosed += (s, args) => this.Show();

            // Pokaż Form2
            textEditorForm.Show();

            // Ukryj Form1
            this.Hide();
        }

        private void dataGridView_baza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void okno1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();

            // Zamknij bieżący formularz
            //this.Hide();

            this.Close();

            //textEditorForm.FormClosed += (s, args) => this.Close();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5;
                wskaznik_liczba.Text = progressBar1.Value.ToString() + " %";

            }
            else
            {
                progressBar1.Value = 0;
                wskaznik_liczba.Text = "0 " + "%";
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void wskaznik_liczba_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                wskaznik_liczba.Text = progressBar1.Value.ToString() + " %";
            }
            else
            {
                progressBar1.Value += 5;
                wskaznik_liczba.Text = progressBar1.Value.ToString() + " %";
            }
        }

        private void start_timer_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

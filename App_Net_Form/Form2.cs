using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Net_Form
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
        }

        

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Zapisz plik tekstowy";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Zapisz zawartość TextBox do pliku
                        File.WriteAllText(saveFileDialog.FileName, textBoxEditor.Text);
                        MessageBox.Show("Plik został zapisany.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas zapisywania pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Otwórz plik tekstowy";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Wczytaj zawartość pliku do TextBox
                        textBoxEditor.Text = File.ReadAllText(openFileDialog.FileName);
                        this.Text = $"Edytor tekstu - {openFileDialog.FileName}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas otwierania pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            //Close();

            // Pokaż ukryty Form1
            Application.OpenForms["Form1"]?.Show();

            // Zamknij bieżący formularz (TextEditorForm)
            this.Close();
        }

        private void back_to_form_1_button_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();

            // Zamknij bieżący formularz
            this.Hide();
            //this.Close();

            //textEditorForm.FormClosed += (s, args) => this.Close();
        }

        private void TextEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}

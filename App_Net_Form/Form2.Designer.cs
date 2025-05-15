namespace App_Net_Form
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.back_to_form_1_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Location = new System.Drawing.Point(3, 25);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.Size = new System.Drawing.Size(390, 213);
            this.textBoxEditor.TabIndex = 0;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(26, 415);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(114, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Wczytaj plik";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(168, 415);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(114, 23);
            this.saveFileButton.TabIndex = 2;
            this.saveFileButton.Text = "Zapisz";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(655, 415);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(114, 23);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "Zamknij";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // back_to_form_1_button
            // 
            this.back_to_form_1_button.Location = new System.Drawing.Point(386, 415);
            this.back_to_form_1_button.Name = "back_to_form_1_button";
            this.back_to_form_1_button.Size = new System.Drawing.Size(114, 23);
            this.back_to_form_1_button.TabIndex = 4;
            this.back_to_form_1_button.Text = "Wróć";
            this.back_to_form_1_button.UseVisualStyleBackColor = true;
            this.back_to_form_1_button.Click += new System.EventHandler(this.back_to_form_1_button_Click);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_to_form_1_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.textBoxEditor);
            this.Name = "TextEditorForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TextEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button back_to_form_1_button;
    }
}
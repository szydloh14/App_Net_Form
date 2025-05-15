namespace App_Net_Form
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wFMRPCDataSet1 = new App_Net_Form.WFMRPCDataSet1();
            this.rCPregistereventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCP_register_eventsTableAdapter = new App_Net_Form.WFMRPCDataSet1TableAdapters.RCP_register_eventsTableAdapter();
            this.refresh_button = new System.Windows.Forms.Button();
            this.dataGridView_baza = new System.Windows.Forms.DataGridView();
            this.Naglowek = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Menu_Form_1 = new System.Windows.Forms.MenuStrip();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.go_button = new System.Windows.Forms.Button();
            this.wskaznik_liczba = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_timer_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.wFMRPCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCPregistereventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baza)).BeginInit();
            this.Menu_Form_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wFMRPCDataSet1
            // 
            this.wFMRPCDataSet1.DataSetName = "WFMRPCDataSet1";
            this.wFMRPCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rCPregistereventsBindingSource
            // 
            this.rCPregistereventsBindingSource.DataMember = "RCP_register_events";
            this.rCPregistereventsBindingSource.DataSource = this.wFMRPCDataSet1;
            this.rCPregistereventsBindingSource.CurrentChanged += new System.EventHandler(this.rCPregistereventsBindingSource_CurrentChanged_1);
            // 
            // rCP_register_eventsTableAdapter
            // 
            this.rCP_register_eventsTableAdapter.ClearBeforeFill = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refresh_button.Location = new System.Drawing.Point(654, 100);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(144, 39);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Odśwież";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_baza
            // 
            this.dataGridView_baza.AllowUserToOrderColumns = true;
            this.dataGridView_baza.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_baza.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_baza.CausesValidation = false;
            this.dataGridView_baza.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_baza.Location = new System.Drawing.Point(-12, 56);
            this.dataGridView_baza.MultiSelect = false;
            this.dataGridView_baza.Name = "dataGridView_baza";
            this.dataGridView_baza.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView_baza.Size = new System.Drawing.Size(946, 319);
            this.dataGridView_baza.TabIndex = 2;
            this.dataGridView_baza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_baza_CellContentClick);
            // 
            // Naglowek
            // 
            this.Naglowek.Dock = System.Windows.Forms.DockStyle.Top;
            this.Naglowek.Enabled = false;
            this.Naglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naglowek.Location = new System.Drawing.Point(0, 24);
            this.Naglowek.Name = "Naglowek";
            this.Naglowek.Size = new System.Drawing.Size(946, 26);
            this.Naglowek.TabIndex = 4;
            this.Naglowek.Text = "Serwer Mysql - przejścioiwy do obsługi RCP";
            this.Naglowek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Naglowek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete_button.Location = new System.Drawing.Point(23, 100);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(146, 39);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Usuń";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Menu_Form_1
            // 
            this.Menu_Form_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oknaToolStripMenuItem});
            this.Menu_Form_1.Location = new System.Drawing.Point(0, 0);
            this.Menu_Form_1.Name = "Menu_Form_1";
            this.Menu_Form_1.Size = new System.Drawing.Size(946, 24);
            this.Menu_Form_1.TabIndex = 6;
            this.Menu_Form_1.Text = "menuStrip1";
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno1ToolStripMenuItem,
            this.okno2ToolStripMenuItem});
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.oknaToolStripMenuItem.Text = "Okna";
            // 
            // okno1ToolStripMenuItem
            // 
            this.okno1ToolStripMenuItem.Name = "okno1ToolStripMenuItem";
            this.okno1ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.okno1ToolStripMenuItem.Text = "Okno 1";
            this.okno1ToolStripMenuItem.Click += new System.EventHandler(this.okno1ToolStripMenuItem_Click);
            // 
            // okno2ToolStripMenuItem
            // 
            this.okno2ToolStripMenuItem.Name = "okno2ToolStripMenuItem";
            this.okno2ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.okno2ToolStripMenuItem.Text = "Okno 2";
            this.okno2ToolStripMenuItem.Click += new System.EventHandler(this.okno2ToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(793, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // go_button
            // 
            this.go_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.go_button.Location = new System.Drawing.Point(207, 100);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(104, 39);
            this.go_button.TabIndex = 8;
            this.go_button.Text = ">> Do przodu";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // wskaznik_liczba
            // 
            this.wskaznik_liczba.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wskaznik_liczba.Cursor = System.Windows.Forms.Cursors.Cross;
            this.wskaznik_liczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskaznik_liczba.Location = new System.Drawing.Point(363, 48);
            this.wskaznik_liczba.Multiline = true;
            this.wskaznik_liczba.Name = "wskaznik_liczba";
            this.wskaznik_liczba.Size = new System.Drawing.Size(100, 34);
            this.wskaznik_liczba.TabIndex = 9;
            this.wskaznik_liczba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wskaznik_liczba.TextChanged += new System.EventHandler(this.wskaznik_liczba_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_timer_button
            // 
            this.start_timer_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start_timer_button.Location = new System.Drawing.Point(363, 100);
            this.start_timer_button.Name = "start_timer_button";
            this.start_timer_button.Size = new System.Drawing.Size(104, 39);
            this.start_timer_button.TabIndex = 10;
            this.start_timer_button.Text = "Start";
            this.start_timer_button.UseVisualStyleBackColor = true;
            this.start_timer_button.Click += new System.EventHandler(this.start_timer_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stop_button.Location = new System.Drawing.Point(485, 100);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(104, 39);
            this.stop_button.TabIndex = 11;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.stop_button);
            this.groupBox1.Controls.Add(this.wskaznik_liczba);
            this.groupBox1.Controls.Add(this.start_timer_button);
            this.groupBox1.Controls.Add(this.go_button);
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.Delete_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Naglowek);
            this.Controls.Add(this.dataGridView_baza);
            this.Controls.Add(this.Menu_Form_1);
            this.MainMenuStrip = this.Menu_Form_1;
            this.Name = "Form1";
            this.Text = "Serwer RCP - Wolsztyn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wFMRPCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCPregistereventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_baza)).EndInit();
            this.Menu_Form_1.ResumeLayout(false);
            this.Menu_Form_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WFMRPCDataSet1 wFMRPCDataSet1;
        private System.Windows.Forms.BindingSource rCPregistereventsBindingSource;
        private WFMRPCDataSet1TableAdapters.RCP_register_eventsTableAdapter rCP_register_eventsTableAdapter;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView dataGridView_baza;
        private System.Windows.Forms.TextBox Naglowek;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.MenuStrip Menu_Form_1;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okno1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okno2ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.TextBox wskaznik_liczba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_timer_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.GroupBox groupBox1;

        
    }
}


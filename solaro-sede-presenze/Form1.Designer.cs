namespace solaro_sede_presenze
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new System.Data.DataSet();
            this.btnSolaro1 = new System.Windows.Forms.Button();
            this.btnControlloConnesione = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSolaro2 = new System.Windows.Forms.Button();
            this.btnConnessioneSolaro2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // btnSolaro1
            // 
            this.btnSolaro1.Location = new System.Drawing.Point(581, 30);
            this.btnSolaro1.Name = "btnSolaro1";
            this.btnSolaro1.Size = new System.Drawing.Size(83, 92);
            this.btnSolaro1.TabIndex = 0;
            this.btnSolaro1.Text = "importa dati";
            this.btnSolaro1.UseVisualStyleBackColor = true;
            this.btnSolaro1.Click += new System.EventHandler(this.btnSolaro1_Click);
            // 
            // btnControlloConnesione
            // 
            this.btnControlloConnesione.Location = new System.Drawing.Point(469, 30);
            this.btnControlloConnesione.Name = "btnControlloConnesione";
            this.btnControlloConnesione.Size = new System.Drawing.Size(83, 92);
            this.btnControlloConnesione.TabIndex = 1;
            this.btnControlloConnesione.Text = "Controlla Connessione";
            this.btnControlloConnesione.UseVisualStyleBackColor = true;
            this.btnControlloConnesione.Click += new System.EventHandler(this.btnControlloConnesione_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOLARO 1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnSolaro1);
            this.groupBox1.Controls.Add(this.btnControlloConnesione);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solaro 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnSolaro2);
            this.groupBox2.Controls.Add(this.btnConnessioneSolaro2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solaro 2";
            // 
            // btnSolaro2
            // 
            this.btnSolaro2.Location = new System.Drawing.Point(581, 30);
            this.btnSolaro2.Name = "btnSolaro2";
            this.btnSolaro2.Size = new System.Drawing.Size(83, 92);
            this.btnSolaro2.TabIndex = 0;
            this.btnSolaro2.Text = "importa dati";
            this.btnSolaro2.UseVisualStyleBackColor = true;
            this.btnSolaro2.Click += new System.EventHandler(this.btnSolaro2_Click);
            // 
            // btnConnessioneSolaro2
            // 
            this.btnConnessioneSolaro2.Location = new System.Drawing.Point(469, 30);
            this.btnConnessioneSolaro2.Name = "btnConnessioneSolaro2";
            this.btnConnessioneSolaro2.Size = new System.Drawing.Size(83, 92);
            this.btnConnessioneSolaro2.TabIndex = 1;
            this.btnConnessioneSolaro2.Text = "Controlla Connessione";
            this.btnConnessioneSolaro2.UseVisualStyleBackColor = true;
            this.btnConnessioneSolaro2.Click += new System.EventHandler(this.btnConnessioneSolaro2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 92);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOLARO 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Parametri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "esci";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Presenze Solaro";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button btnSolaro1;
        private System.Windows.Forms.Button btnControlloConnesione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSolaro2;
        private System.Windows.Forms.Button btnConnessioneSolaro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


namespace DemoDataBinding1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPrestat = new System.Windows.Forms.CheckBox();
            this.textBoxAny = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.comboBoxLlibre = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonEsborrar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTitol2 = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxPrestat2 = new System.Windows.Forms.CheckBox();
            this.textBoxAny2 = new System.Windows.Forms.TextBox();
            this.textBoxAutor2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 392);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Databinding";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.checkBoxPrestat);
            this.tabPage2.Controls.Add(this.textBoxAny);
            this.tabPage2.Controls.Add(this.textBoxAutor);
            this.tabPage2.Controls.Add(this.comboBoxLlibre);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Any";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Llibre";
            // 
            // checkBoxPrestat
            // 
            this.checkBoxPrestat.AutoSize = true;
            this.checkBoxPrestat.Location = new System.Drawing.Point(244, 134);
            this.checkBoxPrestat.Name = "checkBoxPrestat";
            this.checkBoxPrestat.Size = new System.Drawing.Size(62, 19);
            this.checkBoxPrestat.TabIndex = 3;
            this.checkBoxPrestat.Text = "prestat";
            this.checkBoxPrestat.UseVisualStyleBackColor = true;
            // 
            // textBoxAny
            // 
            this.textBoxAny.Location = new System.Drawing.Point(243, 95);
            this.textBoxAny.Name = "textBoxAny";
            this.textBoxAny.Size = new System.Drawing.Size(152, 23);
            this.textBoxAny.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(243, 49);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(152, 23);
            this.textBoxAutor.TabIndex = 1;
            // 
            // comboBoxLlibre
            // 
            this.comboBoxLlibre.FormattingEnabled = true;
            this.comboBoxLlibre.Location = new System.Drawing.Point(22, 49);
            this.comboBoxLlibre.Name = "comboBoxLlibre";
            this.comboBoxLlibre.Size = new System.Drawing.Size(199, 23);
            this.comboBoxLlibre.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAjuda);
            this.tabPage3.Controls.Add(this.labelError);
            this.tabPage3.Controls.Add(this.buttonEsborrar);
            this.tabPage3.Controls.Add(this.buttonAfegir);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxTitol2);
            this.tabPage3.Controls.Add(this.grid);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.checkBoxPrestat2);
            this.tabPage3.Controls.Add(this.textBoxAny2);
            this.tabPage3.Controls.Add(this.textBoxAutor2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "grid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Location = new System.Drawing.Point(284, 298);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(110, 23);
            this.buttonAjuda.TabIndex = 5;
            this.buttonAjuda.Text = "ajuda";
            this.buttonAjuda.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(400, 255);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(147, 15);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Has de seleccionar una fila";
            // 
            // buttonEsborrar
            // 
            this.buttonEsborrar.Location = new System.Drawing.Point(284, 251);
            this.buttonEsborrar.Name = "buttonEsborrar";
            this.buttonEsborrar.Size = new System.Drawing.Size(110, 23);
            this.buttonEsborrar.TabIndex = 4;
            this.buttonEsborrar.Text = "esborrar";
            this.buttonEsborrar.UseVisualStyleBackColor = true;
            this.buttonEsborrar.Click += new System.EventHandler(this.buttonEsborrar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Location = new System.Drawing.Point(284, 208);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(110, 23);
            this.buttonAfegir.TabIndex = 3;
            this.buttonAfegir.Text = "afegir";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Biblioteca";
            // 
            // textBoxTitol2
            // 
            this.textBoxTitol2.Location = new System.Drawing.Point(17, 208);
            this.textBoxTitol2.Name = "textBoxTitol2";
            this.textBoxTitol2.Size = new System.Drawing.Size(221, 23);
            this.textBoxTitol2.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(8, 31);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(560, 150);
            this.grid.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Any";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Titol";
            // 
            // checkBoxPrestat2
            // 
            this.checkBoxPrestat2.AutoSize = true;
            this.checkBoxPrestat2.Location = new System.Drawing.Point(17, 337);
            this.checkBoxPrestat2.Name = "checkBoxPrestat2";
            this.checkBoxPrestat2.Size = new System.Drawing.Size(62, 19);
            this.checkBoxPrestat2.TabIndex = 11;
            this.checkBoxPrestat2.Text = "prestat";
            this.checkBoxPrestat2.UseVisualStyleBackColor = true;
            // 
            // textBoxAny2
            // 
            this.textBoxAny2.Location = new System.Drawing.Point(16, 298);
            this.textBoxAny2.Name = "textBoxAny2";
            this.textBoxAny2.Size = new System.Drawing.Size(91, 23);
            this.textBoxAny2.TabIndex = 2;
            // 
            // textBoxAutor2
            // 
            this.textBoxAutor2.Location = new System.Drawing.Point(16, 252);
            this.textBoxAutor2.Name = "textBoxAutor2";
            this.textBoxAutor2.Size = new System.Drawing.Size(221, 23);
            this.textBoxAutor2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 384);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxAny;
        private TextBox textBoxAutor;
        private ComboBox comboBoxLlibre;
        private CheckBox checkBoxPrestat;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage3;
        private Label label8;
        private TextBox textBoxTitol2;
        private DataGridView grid;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBoxPrestat2;
        private TextBox textBoxAny2;
        private TextBox textBoxAutor2;
        private Button buttonEsborrar;
        private Button buttonAfegir;
        private Label labelError;
        private Button buttonAjuda;
    }
}
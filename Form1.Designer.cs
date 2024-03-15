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
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBoxPrestat = new CheckBox();
            textBoxAny = new TextBox();
            textBoxAutor = new TextBox();
            comboBoxLlibre = new ComboBox();
            tabPage3 = new TabPage();
            radioComprat = new RadioButton();
            radioPrestat = new RadioButton();
            buttonAjuda = new Button();
            labelError = new Label();
            buttonEsborrar = new Button();
            buttonAfegir = new Button();
            label8 = new Label();
            textBoxTitol2 = new TextBox();
            grid = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxAny2 = new TextBox();
            textBoxAutor2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Location = new Point(171, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(585, 392);
            tabControl1.TabIndex = 2;
            tabControl1.KeyDown += tabControl1_KeyDown;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(577, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Databinding";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(checkBoxPrestat);
            tabPage2.Controls.Add(textBoxAny);
            tabPage2.Controls.Add(textBoxAutor);
            tabPage2.Controls.Add(comboBoxLlibre);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(577, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 77);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "Any";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 31);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 31);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Llibre";
            // 
            // checkBoxPrestat
            // 
            checkBoxPrestat.AutoSize = true;
            checkBoxPrestat.Location = new Point(244, 134);
            checkBoxPrestat.Name = "checkBoxPrestat";
            checkBoxPrestat.Size = new Size(62, 19);
            checkBoxPrestat.TabIndex = 3;
            checkBoxPrestat.Text = "prestat";
            checkBoxPrestat.UseVisualStyleBackColor = true;
            // 
            // textBoxAny
            // 
            textBoxAny.Location = new Point(243, 95);
            textBoxAny.Name = "textBoxAny";
            textBoxAny.Size = new Size(152, 23);
            textBoxAny.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(243, 49);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(152, 23);
            textBoxAutor.TabIndex = 1;
            // 
            // comboBoxLlibre
            // 
            comboBoxLlibre.FormattingEnabled = true;
            comboBoxLlibre.Location = new Point(22, 49);
            comboBoxLlibre.Name = "comboBoxLlibre";
            comboBoxLlibre.Size = new Size(199, 23);
            comboBoxLlibre.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(radioComprat);
            tabPage3.Controls.Add(radioPrestat);
            tabPage3.Controls.Add(buttonAjuda);
            tabPage3.Controls.Add(labelError);
            tabPage3.Controls.Add(buttonEsborrar);
            tabPage3.Controls.Add(buttonAfegir);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(textBoxTitol2);
            tabPage3.Controls.Add(grid);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBoxAny2);
            tabPage3.Controls.Add(textBoxAutor2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(577, 364);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "grid";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioComprat
            // 
            radioComprat.AutoSize = true;
            radioComprat.Location = new Point(146, 317);
            radioComprat.Name = "radioComprat";
            radioComprat.Size = new Size(70, 19);
            radioComprat.TabIndex = 22;
            radioComprat.TabStop = true;
            radioComprat.Text = "comprat";
            radioComprat.UseVisualStyleBackColor = true;
            // 
            // radioPrestat
            // 
            radioPrestat.AutoSize = true;
            radioPrestat.Location = new Point(146, 292);
            radioPrestat.Name = "radioPrestat";
            radioPrestat.Size = new Size(61, 19);
            radioPrestat.TabIndex = 21;
            radioPrestat.TabStop = true;
            radioPrestat.Text = "prestat";
            radioPrestat.UseVisualStyleBackColor = true;
            // 
            // buttonAjuda
            // 
            buttonAjuda.Location = new Point(284, 298);
            buttonAjuda.Name = "buttonAjuda";
            buttonAjuda.Size = new Size(110, 23);
            buttonAjuda.TabIndex = 5;
            buttonAjuda.Text = "ajuda";
            buttonAjuda.UseVisualStyleBackColor = true;
            buttonAjuda.Click += buttonAjuda_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(400, 255);
            labelError.Name = "labelError";
            labelError.Size = new Size(147, 15);
            labelError.TabIndex = 20;
            labelError.Text = "Has de seleccionar una fila";
            // 
            // buttonEsborrar
            // 
            buttonEsborrar.Location = new Point(284, 251);
            buttonEsborrar.Name = "buttonEsborrar";
            buttonEsborrar.Size = new Size(110, 23);
            buttonEsborrar.TabIndex = 4;
            buttonEsborrar.Text = "esborrar";
            buttonEsborrar.UseVisualStyleBackColor = true;
            buttonEsborrar.Click += buttonEsborrar_Click;
            // 
            // buttonAfegir
            // 
            buttonAfegir.Location = new Point(284, 208);
            buttonAfegir.Name = "buttonAfegir";
            buttonAfegir.Size = new Size(110, 23);
            buttonAfegir.TabIndex = 3;
            buttonAfegir.Text = "afegir";
            buttonAfegir.UseVisualStyleBackColor = true;
            buttonAfegir.Click += buttonAfegir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 13);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 17;
            label8.Text = "Biblioteca";
            // 
            // textBoxTitol2
            // 
            textBoxTitol2.Location = new Point(17, 208);
            textBoxTitol2.Name = "textBoxTitol2";
            textBoxTitol2.Size = new Size(221, 23);
            textBoxTitol2.TabIndex = 0;
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(8, 31);
            grid.Name = "grid";
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(560, 150);
            grid.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 280);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 14;
            label5.Text = "Any";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 234);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 13;
            label6.Text = "Autor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 188);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "Titol";
            // 
            // textBoxAny2
            // 
            textBoxAny2.Location = new Point(16, 298);
            textBoxAny2.Name = "textBoxAny2";
            textBoxAny2.Size = new Size(91, 23);
            textBoxAny2.TabIndex = 2;
            // 
            // textBoxAutor2
            // 
            textBoxAutor2.Location = new Point(16, 252);
            textBoxAutor2.Name = "textBoxAutor2";
            textBoxAutor2.Size = new Size(221, 23);
            textBoxAutor2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 384);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
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
        private TextBox textBoxAny2;
        private TextBox textBoxAutor2;
        private Button buttonEsborrar;
        private Button buttonAfegir;
        private Label labelError;
        private Button buttonAjuda;
        private RadioButton radioComprat;
        private RadioButton radioPrestat;
    }
}
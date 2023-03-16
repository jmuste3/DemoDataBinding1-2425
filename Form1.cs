namespace DemoDataBinding1
{
    public partial class Form1 : Form
    {
        //exemple3: afegir la propietat bs
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            //dades exemple 2
            Llibre llibre1 = new Llibre("El Quixot", "Miguel de Cervantes", 1605, false);
            Llibre llibre2 = new Llibre("Mecanoscrit del segon origen", "Manuel de Pedrolo", 1974, false);
            Llibre llibre3 = new Llibre("1984", "George Orwell", 1949, true);

            //afegir els llibres a la llista "llibres"
            List<Llibre> llibres= new List<Llibre>();
            llibres.Add(llibre1);
            llibres.Add(llibre2);
            llibres.Add(llibre3);

            //binding exemple 2
            //BindingSource bs = new BindingSource();

            //binding exemple 3
            bs = new BindingSource();
            bs.DataSource= llibres;
            ////combobox
            //comboBoxLlibre.DataSource= bs;
            //comboBoxLlibre.DisplayMember= "Titol";
            ////
            //textBoxAutor.DataBindings.Add("Text", bs, "Autor");
            ////
            //textBoxAny.DataBindings.Add("Text", bs, "Any");
            ////
            //checkBoxPrestat.DataBindings.Add("Checked", bs, "Prestat");

            //binding exemple 3
            //datagridview
            grid.DataSource = bs;
            //
            textBoxTitol2.DataBindings.Add("Text", bs, "Titol");
            //
            textBoxAutor2.DataBindings.Add("Text", bs, "Autor");
            //
            textBoxAny2.DataBindings.Add("Text", bs, "Any");
            //
            checkBoxPrestat2.DataBindings.Add("Checked", bs, "Prestat");

            //ocultar msg error
            labelError.Visible = false;

            //demo teclat
            ToolTip tip = new ToolTip();
            tip.SetToolTip(buttonAfegir, "Ctrl+F5");
            tip.SetToolTip(buttonEsborrar, "Ctrl+F8");
            //definir shortcut per botó ajuda = Ctrl + F12
            //buttonAjuda.ShortcutKeys = Keys.Control | Keys.F12;
        }

        //exemple 3
        //public BindingSource ComboBindingSource
        //{
        //    get { return bs; }
        //}

    private void Form1_Load(object sender, EventArgs e)
        {
            //exemple 1
            label1.DataBindings.Add("Text", textBox1, "Text");
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            //crear llibre en blanc
            Llibre llibreNou = new Llibre("", "", 0, false);
            //afegir al bs
            bs.Add(llibreNou);
            //seleccionar el llibre nou al grid
            int rowIndex = bs.IndexOf(llibreNou);
            grid.CurrentCell = grid.Rows[rowIndex].Cells[1];
        }

        //exemple 3
        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            // Comprova si hi ha alguna fila seleccionada
            if (grid.SelectedRows.Count > 0)
            {
                // Obté la fila seleccionada
                DataGridViewRow selectedRow = grid.SelectedRows[0];

                // Pregunta si l'usuari està segur de voler esborrar la fila
                DialogResult result = MessageBox.Show("Estàs segur que vols esborrar aquesta fila?", "Confirma acció destructiva", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                // Si l'usuari està segur, esborra la fila
                if (result == DialogResult.Yes)
                {
                    grid.Rows.Remove(selectedRow);
                }
            }
            else
            {
                // Mostra el missatge d'error
                labelError.Visible = true;

                // Inicia el temporitzador per amagar el missatge
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 2500; // 2,5 segons
                timer.Tick += (s, ev) =>
                {
                    labelError.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }


        //no utilitzat - cal que el control tingui el focus
        //i posar la propietat KeyPreview del From a true: this.KeyPreview = true;
        //private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    //gestionar combinació de tecles per Esborrar
        //    if (e.KeyCode == Keys.F8 && e.Modifiers == Keys.Control)
        //    {
        //        // cridar al mateix handler del botó d'esborrar
        //        buttonEsborrar_Click(sender, e);
        //    }
        //    //gestionar combinació de tecles per Afegir
        //    if (e.KeyCode == Keys.F5 && e.Modifiers == Keys.Control)
        //    {
        //        // simular click sobre botó Afegir
        //        buttonAfegir.PerformClick();
        //    }
        //}

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && e.Control)
            {
                //opció1: cridar al mateix event handler del buttonEsborrar
                buttonEsborrar_Click(sender, e);
                //marcar event com a gestionat
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5 && e.Control)
            {
                //opció2: generar un event de click sobre el control
                buttonAfegir.PerformClick();
                //marcar event com a gestionat
                e.Handled = true;
            }
        }
    }
}
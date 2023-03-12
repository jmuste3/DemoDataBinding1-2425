namespace DemoDataBinding1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dades exemple 2
            Llibre llibre1 = new Llibre("El Quixot", "Miguel de Cervantes", 1605, false);
            Llibre llibre2 = new Llibre("Mecanoscrit del segon origen", "Manuel de Pedrolo", 1974, false);
            Llibre llibre3 = new Llibre("1983", "George Orwell", 1949, true);
            List<Llibre> llibres= new List<Llibre>();
            llibres.Add(llibre1);
            llibres.Add(llibre2);
            llibres.Add(llibre3);
            //binding exemple 2
            BindingSource comboBindingSource = new BindingSource();
            comboBindingSource.DataSource= llibres;
            comboBoxLlibre.DataSource= comboBindingSource;
            comboBoxLlibre.DisplayMember= "Titol";
            textBoxAutor.DataBindings.Add("Text", comboBindingSource, "Autor");
            textBoxAny.DataBindings.Add("Text", comboBindingSource, "Any");
            checkBoxPrestat.DataBindings.Add("Checked", comboBindingSource, "Prestat");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //exemple 1
            label1.DataBindings.Add("Text", textBox1, "Text");

            

        }
    }
}
namespace multi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcu_Click(object sender, EventArgs e)
        {
           this.muestraTabla(); 
        }

        public void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxN1.Text);
            string tabla = " "; 
            for(int i=1; i<=10; i++)
            {
                tabla = tabla +n+" X "+i+" = "+(n*i) +"\n"; 
            }
            this.richTextBoxRes.AppendText(tabla);
            
        }
    }
}

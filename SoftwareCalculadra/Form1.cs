
namespace SoftwareCalculadra
{
    public partial class Form1 : Form
    {
        private string num1;
        private string num2;
        private float res;
        private string opc;
        private string opr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ComenzarValor();
        }

        private void Iniciar(object sender, EventArgs e)
        {
            this.ComenzarValor();
        }

        private void ComenzarValor()
        {
            this.num1 = "";
            this.num2 = "";
            this.res = 0;
            this.opc = "";
            this.opr = "";
            textBox1.Text = "";
        }
        private void DefinirValor(string valor)
        {
            if (this.opc == "")
            {
                this.num1 = this.num1 + valor;
                this.mostrarTexto();
            }
            else
            {
                this.num2 = this.num2 + valor;
                this.mostrarTexto();
            }
        }
        private void DefinirTipoCalculo(string operacion, string operador)
        {
            if (this.num2 != "")
            {
                this.ejecutarOperacion();
                this.opc = operacion;
                this.opr = operador;
                this.mostrarTexto();
            }
            else if (this.num1 != "")
            {
                this.opc = operacion;
                this.opr = operador;
                this.mostrarTexto();
            }
        }
        private void ejecutarOperacion()
        {
            switch (this.opc)
            {
                case "sumar":
                    this.sumar();
                    this.mostrarResultado();
                    break;
                case "restar":
                    this.restar();
                    this.mostrarResultado();
                    break;
                case "multiplicar":
                    this.multiplicar();
                    this.mostrarResultado();
                    break;
                case "dividir":
                    if (this.num2 != "")
                    {
                        if (this.num2 != "0")
                        {
                            this.dividir();
                            this.mostrarResultado();
                        }
                        else
                        {
                            this.ComenzarValor();
                            textBox1.Text = "No se puede dividir entre cero.";
                        }
                    }
                    break;
            }
        }
        private void mostrarResultado()
        {
            textBox1.Text = this.res.ToString();
            this.num1 = this.res.ToString();
            this.num2 = "";
            this.opc = "";
        }
        private void mostrarTexto()
        {
            textBox1.Text = this.num1 + " " + this.opr + " " + this.num2;
        }
        private void sumar()
        {
            this.res = float.Parse(this.num1) + float.Parse(this.num2);
        }
        private void restar()
        {
            this.res = float.Parse(this.num1) - float.Parse(this.num2);
        }
        private void multiplicar()
        {
            this.res = float.Parse(this.num1) * float.Parse(this.num2);
        }
        private void dividir()
        {
            this.res = float.Parse(this.num1) / float.Parse(this.num2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.DefinirValor("0");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.DefinirValor("1");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.DefinirValor("2");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.DefinirValor("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.DefinirValor("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.DefinirValor("5");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.DefinirValor("6");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.DefinirValor("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.DefinirValor("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.DefinirValor("9");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.DefinirValor(",");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.num1 != "" && this.num2 != "")
            {
                this.ejecutarOperacion();
            }
            else if (this.num1 != "" && this.opc != "")
            {
                this.num2 = this.num1;
                this.ejecutarOperacion();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DefinirTipoCalculo("sumar", "+");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DefinirTipoCalculo("restar", "-");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.DefinirTipoCalculo("multiplicar", "x");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DefinirTipoCalculo("dividir", "/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ComenzarValor();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            float aux;
            if (this.opc == "")
            {
                if (this.num1 != "")
                {
                    aux = float.Parse(this.num1) * (-1);
                    this.num1 = aux.ToString();
                    this.mostrarTexto();
                }
            }
            else
            {
                if (this.num2 != "")
                {
                    aux = float.Parse(this.num2) * (-1);
                    this.num2 = aux.ToString();
                    this.mostrarTexto();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.num2 != "")
            {
                this.num2 = this.num2.Remove(this.num2.Length - 1);
                this.mostrarTexto();
            }
            else if (this.opr != "")
            {
                this.opr = "";
                this.mostrarTexto();
            }
            else if (this.num1 != "")
            {
                this.num1 = this.num1.Remove(this.num1.Length - 1);
                this.mostrarTexto();
            }

        }
    }
}
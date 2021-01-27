using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Isaac Haro, Alan Guijarro, Martin Guerra, Jack Narvaez
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()//form1
        {
            InitializeComponent();
            Visible(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Visible(bool a)//funcion para hacer visible o no a los objetos
        {
            label3.Visible = a;
            textBox3.Visible = a;
            button2.Visible = a;
            label4.Visible = a;
            label5.Visible = a;
            dataGridView1.Visible = a;
            dataGridView2.Visible = a;
        }
        public class Graph//Clase grafo
        {
            public int n;//int
            public Graph(int x)//agregar datos y constructor
            {
                this.n = x;
            }
        }
        public Graph nodo { get; set; }//Grafo nodo
        public Graph nodo2 { get; set; }//Grafo nodo2
        public int[] arr { get; set; }
        public int aristas { get; set; }
        public int vertices { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            int s, f;//variables int
            aristas = int.Parse(textBox1.Text);
            vertices = int.Parse(textBox2.Text);
            nodo = new Graph(vertices);
            nodo2 = new Graph(vertices);
            arr = new int[aristas * 3];
            label3.Visible = true;
            textBox3.Visible = true;
            button2.Visible = true;
            dataGridView1.ColumnCount = aristas;//dimension de la columna del datagrid
            dataGridView1.RowCount = aristas;//dimension de la fila del datagrid
            dataGridView2.ColumnCount = aristas;//dimension de la columna del datagrid
            dataGridView2.RowCount = aristas;//dimension de la fila del datagrid
            for (int j = 0; j < aristas; j++)//inicializacion del datagrid
            {
                for (int z = 0; z < aristas; z++)
                {
                    dataGridView1.Rows[z].Cells[j].Value = 0;
                    dataGridView2.Rows[z].Cells[j].Value = 0;
                }
            }
            label3.Text = $"Ingrese el peso de su arista, seguido de donde parte su nodo, y hacia donde parte su nodo { h + 1}?\nEjemplo: 2,1,4 ";
            h++;
        }
        public int h = 0;
        public void FOR()
        {
            label3.Visible = true;
            string[] split;
            int i = 0;
            label3.Text = $"Ingrese el peso de su arista, seguido de donde parte su nodo, y hacia donde parte su nodo { h + 1}?\nEjemplo: 2,1,4 ";
            split = textBox3.Text.Split(',');
            arr[i] = int.Parse(split[0]);
            arr[i + 1] = int.Parse(split[1]);
            arr[i + 2] = int.Parse(split[2]);
            dataGridView1.Rows[arr[i + 2]].Cells[arr[i + 1]].Value= 1;//adyacentes
            dataGridView1.Rows[arr[i + 1]].Cells[arr[i + 2]].Value = 1;
            dataGridView2.Rows[arr[i + 2]].Cells[arr[i + 1]].Value = arr[i];//pesos
            dataGridView2.Rows[arr[i + 1]].Cells[arr[i + 2]].Value = arr[i];
            i = i + 2;
            textBox3.Clear();
            if (h == vertices)
            {
                label4.Visible = true;
                label5.Visible = true;
                dataGridView1.Visible = true;//visible para ver en consola
                dataGridView2.Visible = true;
            }
            h++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FOR();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


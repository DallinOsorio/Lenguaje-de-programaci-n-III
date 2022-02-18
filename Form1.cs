using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int contador = 0;
        public static string[] NombreEstudiante = new string[1000];  
        public static string[] Edad = new string[1000];


        private void RegistrarEstudiantebutton_Click(object sender, EventArgs e)
        {
  
            NombreEstudiante[contador] = NombreestudiantetextBox.Text;
            Edad[contador] = EdadtextBox.Text;
            contador++;
            MessageBox.Show("Estudiante registrado con exito");
            NombreestudiantetextBox.Text = "";
            EdadtextBox.Text = "";
            Mostrarbutton.Enabled = true;
            Mostrarbutton.Visible = true;


        }
       
        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La lista de estudiantes ha sido actualizada");
            label3.Visible = true;
            RegistradoslistBox.Enabled = true;
            RegistradoslistBox.Visible = true;
            RegistrarEstudiantebutton.Enabled = false;
            RegistrarEstudiantebutton.Visible = false;
            Mostrarbutton.Enabled = false;
            Mostrarbutton.Visible = false;
            RegistradoslistBox.Items.Add("                  Nombre       Edad");
            RegistradoslistBox.Items.Add("------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < contador; i++)
            {
                RegistradoslistBox.Items.Add("                  " + NombreEstudiante[i].ToString() + "            " + Edad[i].ToString());
            }
        }

        
    }
}

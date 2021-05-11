using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        public List<String> lista = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            lista.Add(txtDato.Text);
            load();
            
        }
        private void load()
        {
            
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lista.Count(); i++)
            {
                dataGridView1.Rows.Add(lista[i]);
            }
           
        }
    }
}

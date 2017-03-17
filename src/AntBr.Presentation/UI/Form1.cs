using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AntBr.Commons.Config;

namespace AntBr.Presentation
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Construtor do Fomulario. Inicializa componentes e parâmetros.
        /// </summary>
        public Form1()
        {
            // Incializa componentes da interface.
            InitializeComponent();
            // Adiciona 20 linhas em branco ao DatagridView
            dataGridView1.Rows.Add(20);
            // Laço para preencher o DataGrid View com os dados da matriz de custos totais.
            for (int i=0; i<ApplicationParameters.TotalCostMatrix.Length; i++)
            {
                for (int j=0; j<ApplicationParameters.TotalCostMatrix.Length; j++)
                {
                    // Adiciona dada a sua célula correpondente.
                    dataGridView1.Rows[i].Cells[j].Value = ApplicationParameters.TotalCostMatrix[i][j];
                }
            }
        }
    }
}
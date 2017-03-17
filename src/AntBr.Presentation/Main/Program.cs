using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AntBr.Commons.Util.XMLFileReader;
using System.Collections;
using AntBr.Commons.Entity;
using AntBr.Commons.Config;


namespace AntBr.Presentation
{
    /// <summary>
    /// Classe que serve como ponte de entrada para execução da aplicação.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Método principal. Ponto de entrada da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurações padrão do visual studio
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Carrega parâmtros de configuração da aplicação
            // Ex: times, custos de viagem e estadia etc.
            ConfigureAntBr.LoadApplicationParameters();
            // Gera a matriz de custos total (estadia + viagem).
            ApplicationParameters.caulculateTotalCostMatrix();
            // Inicia a execução do Form.
            Application.Run(new Form1());

        }
    }
}
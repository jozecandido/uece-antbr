using System;
using System.Collections.Generic;
using System.Text;

namespace AntBr.DatStructures.Graph
{
    /// <summary>
    /// Classe que representa um grafo.
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Armazena o tamanho do grafo.
        /// </summary>
        private int size;
        
        /// <summary>
        /// Construtor. Inicializa tamanho grafo.
        /// </summary>
        public Graph(double[][] matrix)
        {
            GraphNode nodes = new GraphNode[2*matrix.Length];
            double arcCosts = new double[2 * matrix.Length];
            for (int i = 1; i <= matrix.Length; i++)
            {
                nodes[i - 1] = new GraphNode(i);
                nodes[i - 1 + matrix.Length] = new GraphNode(-1*i);
                Array.Copy(matrix[i],arcCosts,0,matrix.Length);
                Array.Copy(matrix[i], arcCosts, matrix.Length, matrix.Length);
                nodes[i - 1].ArcCosts = arcCosts;
                nodes[i - 1 + matrix.Length].ArcCosts = arcCosts;
            }
        }


    }
}

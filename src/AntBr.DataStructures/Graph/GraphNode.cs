using System;
using System.Collections.Generic;
using System.Text;

namespace AntBr.DatStructures.Graph
{
    /// <summary>
    /// Classe que representa o n� de um grafo.
    /// </summary>
    public class GraphNode
    {
        /// <summary>
        /// Array de n�s aos quais o n� tem liga��es
        /// </summary>
        private GraphNode[] nodes;
        /// <summary>
        /// Array com os custos dos arcos que ligam aos outros n�s.
        /// </summary>
        private double[] ArcCost;
        /// <summary>
        /// Label indentificador do grafo.
        /// </summary>
        private int label;

        /// <summary>
        /// Propriedade para obter ou modificar o array de n�s.
        /// </summary>
        public GraphNode[] Nodes
        {
            get { return nodes; }
            set { nodes = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o array de custo dos arcos.
        /// </summary>
        public double[] ArcCost
        {
            get { return ArcCost; }
            set { ArcCost = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o label do n�.
        /// </summary>
        public int Label
        {
            get { return label; }
            set { label = value; }
        }


    }
}

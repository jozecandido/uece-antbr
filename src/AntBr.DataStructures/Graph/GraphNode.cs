using System;
using System.Collections.Generic;
using System.Text;

namespace AntBr.DatStructures.Graph
{
    /// <summary>
    /// Classe que representa o nó de um grafo.
    /// </summary>
    public class GraphNode
    {
        /// <summary>
        /// Array de nós aos quais o nó tem ligações
        /// </summary>
        private GraphNode[] nodes;
        /// <summary>
        /// Array com os custos dos arcos que ligam aos outros nós.
        /// </summary>
        private double[] ArcCost;
        /// <summary>
        /// Label indentificador do grafo.
        /// </summary>
        private int label;

        /// <summary>
        /// Propriedade para obter ou modificar o array de nós.
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
        /// Propriedade para obter ou modificar o label do nó.
        /// </summary>
        public int Label
        {
            get { return label; }
            set { label = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AntBr.Algorithms.AntSystem
{
    /// <summary>
    /// Classe que representa o agente formiga do Ant Conlony Optimization
    /// </summary>
    public class AntAgent
    {
        /// <summary>
        /// Lista tabu para armazenar nós já visitados.
        /// </summary>
        private ArrayList tabuList;
        /// <summary>
        /// Lista para armazenar as possíveis escolhar de um agente a cada interação.
        /// </summary>
        private ArrayList candidateMatches;
        /// <summary>
        /// Armazena o nó atual onde a formiga se encontra
        /// </summary>
        private int actualNode;
        /// <summary>
        /// Armaena o custo total do caminho
        /// </summary>
        private double tripCosts;
        /// <summary>
        /// Contador para controlar o número de partidas fora de casa.
        /// </summary>
        private int awayMatchesCounter;
        /// <summary>
        /// Contador para controlar o número de partidas dentro de casa.
        /// </summary>
        private int homeMatchesCounter;

        /// <summary>
        /// Propriedade para obter ou modificar o contador de partidas fora de casa.
        /// </summary>
        public int AwayMatchesCounter
        {
            get { return awayMatchesCounter; }
            set { awayMatchesCounter = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o contador de partidas dentro de casa.
        /// </summary>
        public int HomeMatchesCounter
        {
            get { return homeMatchesCounter; }
            set { homeMatchesCounter = value; }
        }

        /// <summary>
        /// Propriedade para obter oumodificar a lista tabu.
        /// </summary>
        public ArrayList TabuList
        {
            get { return tabuList; }
            set { tabuList = value; }
        }
        
        /// <summary>
        /// Propriedade para obter ou modificar a lista de confrontos candidatos.
        /// </summary>
        public ArrayList CandidateMatches
        {
            get { return candidateMatches; }
            set { candidateMatches = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o nó atual da formiga.
        /// </summary>
        public int ActualNode
        {
            get { return actualNode; }
            set { actualNode = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar os custos dos jogos.
        /// </summary>
        public double TripCosts
        {
            get { return tripCosts; }
            set { tripCosts = value; }
        }
    }
}

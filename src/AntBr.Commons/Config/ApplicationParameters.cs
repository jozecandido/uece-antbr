using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using AntBr.Commons.Entity;

namespace AntBr.Commons.Config
{
    /// <summary>
    /// Classe que armazenará os parâmetros de configuração da aplicação.
    /// </summary>
    public class ApplicationParameters
    {
        /// <summary>
        /// ArrayList para armazenar os times.
        /// </summary>
        private static ArrayList teams;
        /// <summary>
        /// Valor do fator de multiplicação para o preço
        /// do traslado entre duas cidades.
        /// </summary>
        private static int tripFactor;
        /// <summary>
        /// Valor do fator de multiplicação para o preço
        /// da estadia em uma cidade.
        /// </summary>
        private static int stayFactor;
        /// <summary>
        /// Hashtable que armazena os custos de viagem entre duas cidades.
        /// </summary>
        private static Hashtable tripCosts;
        /// <summary>
        /// Hashtable que armazena os custos de estadia em uma cidade.
        /// </summary>
        private static Hashtable stayCosts;
        /// <summary>
        /// Matriz de custos totais (viagem + estadia).
        /// </summary>
        private static double[][] totalCostMatrix;

        /// <summary>
        /// Propriedade para obter ou modificar a matriz de custos totais (viagem + estadia).
        /// </summary>
        public static double[][] TotalCostMatrix
        {
            get { return totalCostMatrix; }
            set { totalCostMatrix = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o arrayList para armazenar os times.
        /// </summary>
        public static ArrayList TeamsList
        {
            get { return teams; }
            set { teams = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o valor do fator de multiplicação para o preço
        /// do traslado entre duas cidades.
        /// </summary>
        public static int TripFactor
        {
            get { return tripFactor; }
            set { tripFactor = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o valor do fator de multiplicação para o preço
        /// da estadia em uma cidade.
        /// </summary>
        public static int StayFactor
        {
            get { return stayFactor; }
            set { stayFactor = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o hashtable que armazena os custos de viagem entre duas cidades.
        /// </summary>
        public static Hashtable TripCosts
        {
            get { return tripCosts; }
            set { tripCosts = value; }
        }

        /// <summary>
        /// Propriedade para obter ou modificar o hashtable que armazena os custos de estadia em uma cidade.
        /// </summary>
        public static Hashtable StayCosts
        {
            get { return stayCosts; }
            set { stayCosts = value; }
        }

        /// <summary>
        /// Método que calcula a matriz de custos totais.
        /// </summary>
        public static void caulculateTotalCostMatrix()
        {
            // Inicializa a priemeira dimesão da matriz.
            totalCostMatrix = new double[TeamsList.Count][];
            // laço para inicializar a segunda dimensão da matriz e
            // calcular o valor do custo total.
            for (int i = 0; i < TeamsList.Count; i++) 
            {
                // inicializa a segunda dimesão da matriz.
                totalCostMatrix[i] = new double[TeamsList.Count];
                for (int j = 0; j < TeamsList.Count; j++)
                {
                    // Calcula o valor do custo total.
                    double tripCost = (double)TripCosts[((Team)TeamsList[i]).CITY + "-" + ((Team)TeamsList[j]).CITY];
                    double stayCost = (double)StayCosts[((Team)TeamsList[i]).CITY];
                    // Atribui o valor do custo total.
                    totalCostMatrix[i][j] = TripFactor * tripCost + StayFactor * stayCost;
                }
            }
        }
    }
}

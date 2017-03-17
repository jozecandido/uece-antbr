using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using AntBr.Commons.Util.XMLFileReader;
using AntBr.Commons.Entity;

namespace AntBr.Commons.Config
{
    /// <summary>
    /// Classe responsável por gerenciar o processo de configuração da aplicação.
    /// Carregar os parâmetros, etc.
    /// </summary>
    public class ConfigureAntBr
    {
        /// <summary>
        /// Método que Carrega os parâmetros da aplicação.
        /// </summary>
        public static void LoadApplicationParameters()
        {
            // Carrega a lista de times;
            ApplicationParameters.TeamsList = TeamsReader.getTeams();
            // Carrega o valor do fator multiplicativo do preço de estadia.
            ApplicationParameters.StayFactor = CostsReader.getStayFactor();
            // Carrega o valor do fator multiplicativo do preço de viagem.
            ApplicationParameters.TripFactor = CostsReader.getTripFactor();
            // Inicializa o hashtable que armazenará os valores dos custos de viagem.
            Hashtable tripCosts = new Hashtable();
            // Inicializa o hashtable que armazenará os valores dos custos de estadia.
            Hashtable stayCosts = new Hashtable();
            // Laço para montar os hashtables de custo e estadia.
            foreach (ITeam team in ApplicationParameters.TeamsList)
            {
                // Obtém os custos de traslado apartir de uma determinada cidade.
                Hashtable costs = CostsReader.getTripCosts(team.CITY);
                // Laço para adicionar valores ao hashtable de custos de viagem.
                IDictionaryEnumerator enumerator = costs.GetEnumerator();
                while(enumerator.MoveNext())
                {
                    if (!tripCosts.ContainsKey(enumerator.Key))
                    {
                        tripCosts.Add(enumerator.Key, enumerator.Value);
                    }
                }
                // Adiciona custos de estadia ao hashtable
                if (!stayCosts.ContainsKey(team.CITY))
                    stayCosts.Add(team.CITY, CostsReader.getStayCosts(team.CITY));
            }
            // Carrega valores de estadia.
            ApplicationParameters.StayCosts = stayCosts;
            // Carrega valores de viagem.
            ApplicationParameters.TripCosts = tripCosts;
        }
    }
}

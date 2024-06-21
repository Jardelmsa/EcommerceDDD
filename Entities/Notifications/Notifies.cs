﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notificacoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notificacoes;

        public bool ValidaPropriedadeString( string valor, string nomePropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor)|| string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
        {
            if ( valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "O valor deve ser maior que 0.",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "O valor deve ser maior que 0.0",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            else
            {
                return true;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ListaPOO.Models
{
    public class Contato
    {
        //ATRIBUTOS
        private int id;
        private string? nome;
        private string? telefone;
        private string? email;
        //METODOS
        //PROPRIEDADES
        public int Id { get => id; set => id = value; }
        public string? Nome
        {
            get => nome; set
            {
                string teste = (value ?? "").Trim();
                if (teste.Length > 0)
                    nome = teste;
            }
        }
        public string? Telefone
        {
            get => telefone; set
            {
                if (Regex.IsMatch(value, @"^\(?[1-9]{2}\)?\s?9[0-9]{4}-?[0-9]{4}$"))
                    telefone = value;
            }
        }
        public string? Email { get => email; set
            {
                string teste = value.Trim();
                if (teste.Contains("@"))
                    email = teste;
            }
        }
    }
}

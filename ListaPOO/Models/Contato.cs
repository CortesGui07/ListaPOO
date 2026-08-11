using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.RegularExpressions;

namespace ListaPOO.Models
{
    [Table("contatos", Schema = "public")]
    public class Contato
    {
        //ATRIBUTOS
        private int id;
        private string? nome;
        private string? telefone;
        private string? email;
        //METODOS
        //PROPRIEDADES
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string? Nome
        {
            get => nome; set
            {
                string teste = (value ?? "").Trim();
                if (teste.Length > 0)
                    nome = teste;
                else nome = null;
            }
        }
        [Column("telefone")]
        public string? Telefone
        {
            get => telefone; set
            {
                if (Regex.IsMatch(value, @"^\(?[1-9]{2}\)?\s?9[0-9]{4}-?[0-9]{4}$"))
                    telefone = value;
                else telefone = null;
            }
        }
        [Column("email")]
        public string? Email { get => email; set
            {
                string teste = value.Trim();
                if (teste.Contains("@"))
                    email = teste;
                else email = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace teste_de_crud
{
    internal class Pokemon
    {
        int numero;
        string nome;
        string tipo;

        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Pokemon(int numero, string nome, string tipo)
        {
            this.numero = numero;
            this.nome = nome;
            this.tipo = tipo;
        }
    }
}

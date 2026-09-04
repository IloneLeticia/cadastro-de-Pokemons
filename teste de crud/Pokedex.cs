using System;
using System.Collections.Generic;
using System.Text;

namespace teste_de_crud
{
    internal class Pokedex
    {
        private Pokemon[] pokemons;
        private int quantidade = 0;


        public Pokedex(int tamanho)
        {
            pokemons = new Pokemon[tamanho];
        }

        public bool Cadastrar(Pokemon pokemon)
        {
            if (quantidade < pokemons.Length)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    if (pokemons[i].Numero == pokemon.Numero)
                    {
                        
                        return false;
                    }
                }
                pokemons[quantidade] = pokemon; quantidade++;
                return true;
            }
            return false;
        }
        public bool Renomear(int n, string nome)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (pokemons[i].Numero == n)
                {
                    pokemons[i].Nome = nome;

                    return true;
                }
            }
            return false;

        }
        public bool Excluir(int n)
        {
            for (int i = 0; i < quantidade; i++)
            {
                if (pokemons[i].Numero == n)
                {
                    for (int j = i; j < quantidade - 1; j++)
                    {
                        pokemons[j] = pokemons[j + 1];
                    }
                    quantidade--;
                    return true;
                }
            }
            return false;
        }

        public Pokemon[] Listar()
        {
            Pokemon[] lista = new Pokemon[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                lista[i] = pokemons[i];




            }

            return lista;
        }
    }
}


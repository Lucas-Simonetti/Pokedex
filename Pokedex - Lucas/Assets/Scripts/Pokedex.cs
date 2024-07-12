using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pokedex : MonoBehaviour
{
    [Header("Lista de Pokemon")]
    public Pokemon[] listaPokemons;

    [Header("Objetos da Cena Pokedex")]
    public Image imagemPokemon;
    public TMP_Text nomePokemon;
    public TMP_Text descricaoPokemon;
    public TMP_Text tipoPokemon;

    [Header("Objetos da Cena Habilidades")]
    public TMP_Text textoHabilidades;

    [Header("Objetos da Cena Evoluções")]
    public TMP_Text textoEvolucoes;

    [Header("Variáveis para Pokedex")]
    public int pokemonAtual;

    private void Start()
    {
        MudarPokemon(0);
    }

    public void MudarPokemon(int proximo)
    {
        if(proximo == 0)
        {
            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagemPokemon;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].nome + " - ";
            }

            for (int i = 0; i < listaPokemons[pokemonAtual].habilidade.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidade[i].nome + "\n";
            }

            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "Pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "Pre: Não Possui";
            }

            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n Pós: " + listaPokemons[pokemonAtual].evolucao.nome;
            }
            else
            {
                textoEvolucoes.text += "\n Pós: Não possui";
            }
        }
        else
        {
            pokemonAtual += proximo;

            if(pokemonAtual < 0)
            {
                pokemonAtual = listaPokemons.Length - 1;
            }
            if(pokemonAtual > listaPokemons.Length)
            {
                pokemonAtual = 0;
            }

            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagemPokemon;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].nome + " - ";
            }

            for (int i = 0; i < listaPokemons[pokemonAtual].habilidade.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidade[i].nome + "\n";
            }

            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "Pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "Pre: Não Possui";
            }

            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n Pós: " + listaPokemons[pokemonAtual].evolucao.nome;
            }
            else
            {
                textoEvolucoes.text += "\n Pós: Não possui";
            }

        }
    }
}

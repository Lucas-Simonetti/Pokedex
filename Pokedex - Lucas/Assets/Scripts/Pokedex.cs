using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pokedex : MonoBehaviour
{

    public Pokemon[] pokemons;

    public Image background;
    public TMP_Text textoPokedex;

    // Start is called before the first frame update
    void Start()
    {
        MudarPokemon(0);
    }

    public void MudarPokemon(int valor)
    {
        int atual = 0;
        atual += valor;
        if(atual > pokemons.Length)
        {
            atual = 0;
        }
        if(atual < 0)
        {
            atual = pokemons.Length - 1;
        }

        textoPokedex.text = pokemons[atual].nome + "\n Descrição: " + pokemons[atual].descricao + 
            "\n Tipo: " + pokemons[atual].tipo.nome;

        background.color = pokemons[atual].tipo.tipoCor;
    }

}

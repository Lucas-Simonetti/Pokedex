using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Pokemon")]
public class Pokemon : ScriptableObject
{
    public string nome;
    public TipoPokemon tipo;
    public HabilidadePokemon[] habilidade;
    public Pokemon evolucao;
    public Pokemon preEvolucao;
    public string descricao;
}

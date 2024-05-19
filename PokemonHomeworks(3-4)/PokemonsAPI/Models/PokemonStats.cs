﻿namespace PokemonsAPI.Models;

public class PokemonStats : Base
{
    public PokemonDetails Details { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpecialAttack { get; set; }
    public int SpecialDefense { get; set; }
    public int Speed { get; set; }
}

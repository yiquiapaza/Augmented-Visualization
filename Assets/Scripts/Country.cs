using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Country 
{
    public int year;
    public string region;
    public int country_code;
    public string name;
    public string color;
    public string continet;
    public float population;
    public float infant_mortality_rate;
    public float life_expectance;

    public Country(int year, string region, int country_code, string name, string color, string continet, float population, float infant_mortality_rate, float life_expectance)
    {
        this.year = year;
        this.region = region;
        this.country_code = country_code;
        this.name = name;
        this.color = color;
        this.continet = continet;
        this.population = population;
        this.infant_mortality_rate = infant_mortality_rate;
        this.life_expectance = life_expectance;
    }
}

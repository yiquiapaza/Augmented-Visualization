using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Country 
{
    public int year { get; set; }
    public string region { get; set; }
    public int country_code { get; set; }
    public string name { get; set; }
    public string color { get; set; }
    public string continet { get; set; }
    public float population { get; set; }
    public float infant_mortality_rate { get; set; }
    public float life_expectance { get; set; }

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

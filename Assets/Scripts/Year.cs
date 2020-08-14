using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Year 
{

    public int year;
    public float population;
    public float infant_mortality_rate;
    public float life_expetancy;

    public Year(int year, float population, float infant_mortality_rate, float life_expetancy)
    {
        this.year = year;
        this.population = population;
        this.infant_mortality_rate = infant_mortality_rate;
        this.life_expetancy = life_expetancy;
    }
}

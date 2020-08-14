using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Country 
{
    public Country(string region, int country_code, string name, int color, List<Year> years)
    {
        this.region = region;
        this.country_code = country_code;
        this.name = name;
        this.color = color;
        this.years = years;
    }

    public string region;
    public int country_code;
    public string name;
    public int color;
    public List<Year> years;

    public static List<Country> CreateStaticData()
    {
        List<Country> countries = new List<Country>();

        List<Year> yearsArgentina = new List<Year>();
        yearsArgentina.Add(
            new Year(1950, 17037.91f, 63.886f, 62.57f));
        Country countryArgentina = new Country(
            "Latin America and the Caribbean",
            32, 
            "Argentina",
            1, yearsArgentina);
        
        List<Year> yearsBrazil = new List<Year>();
        yearsBrazil.Add(
            new Year(1950, 53974.728f, 136.274f, 50.83f));
        Country countryBrazil = new Country(
            "Latin America and the Caribbean",
            76,
            "Brazil",
            1, yearsBrazil);

        List<Year> yearsPeru = new List<Year>();
        yearsPeru.Add(
            new Year(1950, 7777.452f, 158.531f, 44.11f));
        Country countryPeru = new Country(
            "Latin America and the Caribbean",
            604,
            "Peru",
            1, yearsPeru);

        List<Year> yearsEEUU = new List<Year>();
        yearsEEUU.Add(
            new Year(1950, 158804.397f, 30.162f, 68.71f));
        Country countryEEUU = new Country(
            "Europe and Northern America",
            840,
            "United States of America",
            2, yearsEEUU);

        List<Year> yearsCanada = new List<Year>();
        yearsCanada.Add(
            new Year(1950, 13733.398f, 37.816f, 69.05f));
        Country countryCanada = new Country(
            "Europe and Northern America",
            124,
            "Canada",
            3, yearsCanada);

        List<Year> yearsFrance = new List<Year>();
        yearsFrance.Add(
            new Year(1950, 41833.873f, 44.216f, 67.27f));
        Country countryFrance = new Country(
            "Europe and Northern America",
            250,
            "France",
            4, yearsFrance);

        List<Year> yearsChina = new List<Year>();
        yearsChina.Add(
            new Year(1950, 13733.398f, 37.816f, 69.05f));
        Country countryChina = new Country(
            "Europe and South-Eastern Asia",
            156,
            "China",
            5, yearsChina);

        countries.Add(countryArgentina);
        countries.Add(countryBrazil);
        countries.Add(countryPeru);
        countries.Add(countryEEUU);
        countries.Add(countryCanada);
        countries.Add(countryFrance);
        countries.Add(countryChina);

        return countries;
    }
}

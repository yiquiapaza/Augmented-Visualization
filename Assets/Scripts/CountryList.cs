using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CountryList 
{
    public static List<Country> CreateCoutries()
    {
        List<Country> coutries = new List<Country>();

        var year1950Peru = new Country(1950, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 7777.452f, 158.531f, 44.11f);
        var year1951Peru = new Country(1951, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 7976.478f, 158.531f, 44.11f);
        var year1952Peru = new Country(1952, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 8184.725f, 158.531f, 44.11f);
        var year1953Peru = new Country(1953, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 8401.373f, 158.531f, 44.11f);
        var year1954Peru = new Country(1954, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 8625.982f, 158.531f, 44.11f);
        var year1955Peru = new Country(1955, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 8858.392f, 148.153f, 46.44f);
        var year1956Peru = new Country(1956, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 9098.83f, 148.153f, 46.44f);
        var year1957Peru = new Country(1957, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 9347.833f, 148.153f, 46.44f);
        var year1958Peru = new Country(1958, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 9606.241f, 148.153f, 46.44f);
        var year1959Peru = new Country(1959, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 9875.016f, 148.153f, 46.44f);
        var year1960Peru = new Country(1960, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 10155.011f, 132.947f, 49.64f);
        var year1961Peru = new Country(1961, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 10446.618f, 132.947f, 49.64f);
        var year1962Peru = new Country(1962, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 10749.463f, 132.947f, 49.64f);
        var year1963Peru = new Country(1963, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 11062.295f, 132.947f, 49.64f);
        var year1964Peru = new Country(1964, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 11383.364f, 132.947f, 49.64f);
        var year1965Peru = new Country(1965, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 11711.402f, 120.942f, 52.22f);
        var year1966Peru = new Country(1966, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 12045.783f, 120.942f, 52.22f);
        var year1967Peru = new Country(1967, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 12386.868f, 120.942f, 52.22f);
        var year1968Peru = new Country(1968, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 12735.491f, 120.942f, 52.22f);
        var year1969Peru = new Country(1969, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 13092.846f, 120.942f, 52.22f);
        var year1970Peru = new Country(1970, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 13459.789f, 103.763f, 56.15f);
        var year1971Peru = new Country(1971, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 13836.365f, 103.763f, 56.15f);
        var year1972Peru = new Country(1972, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 14221.954f, 103.763f, 56.15f);
        var year1973Peru = new Country(1973, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 14615.847f, 103.763f, 56.15f);
        var year1974Peru = new Country(1974, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 15017.06f, 103.763f, 56.15f);
        var year1975Peru = new Country(1975, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 15424.745f, 94.937f, 58.84f);
        var year1976Peru = new Country(1976, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 15838.568f, 94.937f, 58.84f);
        var year1977Peru = new Country(1977, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 16258.323f, 94.937f, 58.84f);
        var year1978Peru = new Country(1978, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 16683.451f, 94.937f, 58.84f);
        var year1979Peru = new Country(1979, "Latin America and the Caribbean", 604, "Peru", "#2ecc71", "South America", 17113.393f, 94.937f, 58.84f);

        var year1950Brasil = new Country(1950, "Latin America and the Caribbean", 604, "Brasil", "#2ecc71", "South America", 7777.452f, 158.531f, 44.11f);

        coutries.Add(year1950Peru); coutries.Add(year1951Peru); coutries.Add(year1952Peru); coutries.Add(year1953Peru); coutries.Add(year1954Peru);
        coutries.Add(year1955Peru); coutries.Add(year1956Peru); coutries.Add(year1957Peru); coutries.Add(year1958Peru); coutries.Add(year1959Peru);
        coutries.Add(year1960Peru); coutries.Add(year1961Peru); coutries.Add(year1962Peru); coutries.Add(year1963Peru); coutries.Add(year1964Peru);
        coutries.Add(year1965Peru); coutries.Add(year1966Peru); coutries.Add(year1967Peru); coutries.Add(year1968Peru); coutries.Add(year1969Peru);
        coutries.Add(year1970Peru); coutries.Add(year1971Peru); coutries.Add(year1972Peru); coutries.Add(year1973Peru); coutries.Add(year1974Peru);
        coutries.Add(year1975Peru); coutries.Add(year1976Peru); coutries.Add(year1977Peru); coutries.Add(year1978Peru); coutries.Add(year1979Peru);

        coutries.Add(year1950Brasil);

        return coutries;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CountryInfo 
{
    public int year;
    public string name;
    public float population;
    public float infant_mortality_rate;
    public float life_expectance;
    public string country_code;
    public string continet;

    public static CountryInfo CreateFromJson(string jsonString)
    {
        return JsonUtility.FromJson<CountryInfo>(jsonString);
    }
}

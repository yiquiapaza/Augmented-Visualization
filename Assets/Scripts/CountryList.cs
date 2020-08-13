using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CountryList 
{
    public List<Country> countryList;

    public static CountryList CreateFromJson(string jsonString)
    {
        return JsonUtility.FromJson<CountryList>(jsonString);
    }
}

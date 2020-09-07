using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CountryInfo 
{
    public string country_code;

    public static CountryInfo CreateFromJson(string jsonString)
    {
        return JsonUtility.FromJson<CountryInfo>(jsonString);
    }
}

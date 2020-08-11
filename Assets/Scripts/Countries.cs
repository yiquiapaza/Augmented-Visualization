using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class Countries 
{
    public string region;
    public int contrycode;
    public string name;
    public string color;
    //public List<Data> data;

    public static Countries CreateFromJson(string jsonString)
    {
        return JsonUtility.FromJson<Countries>(jsonString);
    }
}



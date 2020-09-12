using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class YearInfo 
{
    public int year;
    public bool state;
    
    public static YearInfo CreateFromJson(string jsonSring)
    {
        return JsonUtility.FromJson<YearInfo>(jsonSring);
    }
}

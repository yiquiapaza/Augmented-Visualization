﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
using Util;

public class CountryRequest : MonoBehaviour
{
    [Tooltip ("Url name for server")]
    public string url;
    [Tooltip ("Name for find elements")]
    public string CountryName;
    [Tooltip ("GameObject Sphere")]
    public GameObject CountrySphere;

    private List<Country> countryList;
    private float population;
    private float life_expectance;
    private float infant_mortality_rate;

    // Start is called before the first frame update
    void Start()
    {
        //countryList = CountryList.CreateCoutries().Where(country => country.name == CountryName).ToList();
        StartCoroutine(GetColor(url));
        StartCoroutine(GetRequest(url));        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string url)
    {        
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url + CountryName))
        {
            yield return webRequest.SendWebRequest();
            if (!webRequest.isNetworkError)
            {
                if (webRequest.isDone)
                {
                    population = UtilScale.Ascale(CountryInfo.CreateFromJson(webRequest.downloadHandler.text).population);
                    life_expectance = UtilScale.Xscale(CountryInfo.CreateFromJson(webRequest.downloadHandler.text).life_expectance);
                    infant_mortality_rate = UtilScale.Yscale(CountryInfo.CreateFromJson(webRequest.downloadHandler.text).infant_mortality_rate);
                    CountrySphere.transform.localPosition =  new Vector3(0.5F + life_expectance, infant_mortality_rate - 0.25F, 0.3F);
                    CountrySphere.transform.localScale = new Vector3(population, population, population);
                    yield break;
                }              
            }
        }
    }

    IEnumerator GetColor(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url + CountryName))
        {
            yield return webRequest.SendWebRequest();
            if (!webRequest.isNetworkError)
            {
                if (webRequest.isDone)
                {                    
                    CountrySphere.GetComponent<Renderer>().material.color = SetColor(CountryInfo.CreateFromJson(webRequest.downloadHandler.text).continet);
                    yield break;
                }
            }
        }
    }


    private Color SetColor(string color) 
    {
        Color ColorSphere = Color.white;

        switch (color)
        {
            case Constants.CONTINET_ASIA:
                ColorSphere = new Color32(243, 156,18,255);
                break;
            case Constants.CONTINET_EUROPE:
                ColorSphere = new Color32(142, 68, 173, 255);
                break;
            case Constants.CONTINET_AFRICA:
                ColorSphere = new Color32(41, 128, 185, 255);
                break;
            case Constants.CONTINET_MIDDLE_EAST:
                ColorSphere = new Color32(52, 73, 94, 255);
                break;
            case Constants.CONTINET_NORTH_AMERICA:
                ColorSphere = new Color32(93, 173, 226, 255);
                break;
            case Constants.CONTINET_OCEANIA:
                ColorSphere = new Color32(231, 76, 60, 255);
                break;
            case Constants.CONTINET_SOUTH_AMERICA:
                ColorSphere = new Color32(46, 204, 113, 255);
                break;
        }

        return ColorSphere;
    }
}

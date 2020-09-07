using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class CountryRequest : MonoBehaviour
{
    [Tooltip ("Url name for server")]
    public string url;
    [Tooltip ("Name for find elements")]
    public string CountryName;
    [Tooltip ("Choose the Color of the Sphere")]
    public string ColorSphere;

    private List<Country> countryList;
    // Start is called before the first frame update
    void Start()
    {

        countryList = CountryList.CreateCoutries().Where(country => country.name == CountryName).ToList();

        Debug.Log(countryList.Count());
        gameObject.transform.localPosition = new Vector3(
            UtilScale.Xscale(countryList[0].life_expectance),
            UtilScale.Yscale(countryList[0].infant_mortality_rate));
        gameObject.transform.localScale = new Vector3(
            UtilScale.Ascale(countryList[19].population),
            UtilScale.Ascale(countryList[19].population),
            UtilScale.Ascale(countryList[19].population));
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(GetYear(url));
    }

    IEnumerator GetYear(string url)
    {
        using(UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError)
            {
                Debug.LogError("Error " + webRequest.error);
            }
            else
            {
                if (countryList.Where(year => year.year == YearInfo.CreateFromJson(webRequest.downloadHandler.text).year).FirstOrDefault().year == 1950)
                    gameObject.GetComponent<Renderer>().material.color = Color.red;

                if (countryList.Where(year => year.year == YearInfo.CreateFromJson(webRequest.downloadHandler.text).year).FirstOrDefault().year == 1951)
                    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.Log("Data " + webRequest.downloadHandler.text);
            }
        }
    }
}

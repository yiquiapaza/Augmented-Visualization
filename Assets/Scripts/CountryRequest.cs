using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CountryRequest : MonoBehaviour
{
    [Tooltip ("Url name for server")]
    public string url;
    [Tooltip ("Name for find elements")]
    public string CountryName;

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
        
    }
}

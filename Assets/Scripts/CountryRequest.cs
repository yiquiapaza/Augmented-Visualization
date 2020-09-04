using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryRequest : MonoBehaviour
{
    [Tooltip ("Url name for server")]
    public string url;
    [Tooltip ("Name for find elements")]
    public string CountryName;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.transform.localPosition = new Vector3(
            UtilScale.Xscale(PeruCountry.CreatePeruCountry()[0].life_expectance),
            UtilScale.Yscale(PeruCountry.CreatePeruCountry()[0].infant_mortality_rate));
        gameObject.transform.localScale = new Vector3(
            UtilScale.Ascale(PeruCountry.CreatePeruCountry()[19].population),
            UtilScale.Ascale(PeruCountry.CreatePeruCountry()[19].population),
            UtilScale.Ascale(PeruCountry.CreatePeruCountry()[19].population));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateScatterPlot : MonoBehaviour
{

    [SerializeField]
    [Tooltip("Source where is it located the json file:")]
    public string source;

    [SerializeField]
    [Tooltip("GameObject with we work all interaction")]
    public Transform Sphere;

    private CountryList countryListObj;

    // Start is called before the first frame update
    void Start()
    {
        GetObjects(source);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetObjects(string jsonFile)
    {
        if (File.Exists(Application.dataPath + jsonFile))
        {
            string dataContent = File.ReadAllText(Application.dataPath + jsonFile);
            countryListObj = CountryList.CreateFromJson(dataContent);
            foreach(Country country in countryListObj.countryList)
            {
                Transform obj = Instantiate(
                    Sphere,
                    new Vector3(
                        gameObject.transform.position.x + (country.years[0].life_expetancy / 100), 
                        gameObject.transform.position.y + (country.years[0].infant_mortality_rate / 100), 
                        gameObject.transform.position.z + 0.0f),
                    Quaternion.identity);
                obj.gameObject.SetActive(true);
                obj.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                Debug.Log("Create a Sphere");
            }
        }
        else
        {
            Debug.LogError("Error load json file");
        }
           
    }
}

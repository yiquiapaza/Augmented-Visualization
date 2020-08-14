using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class CreateScatterPlot : MonoBehaviour
{
    [SerializeField]
    [Tooltip("GameObject with we work all interaction")]
    public Transform Sphere;

    private CountryList countryListObj;
    private List<Country> coutriesObj;

    // Start is called before the first frame update
    void Start()
    {
        GetObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetObjects()
    {
        if (Country.CreateStaticData().Count != 0)
        {
            foreach (Country country in Country.CreateStaticData())
            {

                Debug.Log(country.name);
                Transform obj = Instantiate(
                    Sphere,
                    new Vector3(
                        gameObject.transform.position.x + (country.years[0].life_expetancy / 100),
                        gameObject.transform.position.y + (country.years[0].infant_mortality_rate / 200),
                        gameObject.transform.position.z + 0.0f),
                    Quaternion.identity);                
                obj.gameObject.SetActive(true);
                obj.localScale = new Vector3(
                    country.years[0].population / (RangeSphere() * 10), 
                    country.years[0].population / (RangeSphere() * 10), 
                    country.years[0].population / (RangeSphere() * 10));
                obj.gameObject.GetComponent<Renderer>().material.color = GetColor(country.color);
                //Debug.Log(country.years[0].population / (RangeSphere() * 10));
            }
        }
        else
        {
            Debug.Log("Nose pudo cagar");
        }        
    }
    private Color GetColor(int num)
    {
        Color color = new Color();
        switch(num)
        {
            case 1:
                color = Color.red;
                break;
            case 2:
                color = Color.blue;
                break;
            case 3:
                color = Color.green;
                break;
            case 4:
                color = Color.yellow;
                break;
            case 5:
                color = Color.cyan;
                break;
            case 6:
                color = Color.magenta;
                break;
        }

        return color;
    }

    private float RangeSphere()
    {
        List<float> listOutData = new List<float>();

        foreach (Country country in Country.CreateStaticData())
        {
            listOutData.Add(country.years.Select(i => i.population).Max());
        }

        return listOutData.Max();
    }
}

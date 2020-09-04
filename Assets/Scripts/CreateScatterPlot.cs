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
       
}

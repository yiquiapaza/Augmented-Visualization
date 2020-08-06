using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClientHttp : MonoBehaviour
{
    [SerializeField]
    public string url;
    [SerializeField]
    public Transform ExampleSphere;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Get(url));
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Get(string url)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError)
            {
                Debug.Log("Error server");
                ExampleSphere.gameObject.SetActive(true);
                ExampleSphere.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                if(www.isDone)
                {
                    Debug.Log("Is Done!!");
                    ExampleSphere.gameObject.SetActive(true);
                    ExampleSphere.GetComponent<Renderer>().material.color = Color.blue;
                }
                else
                {
                    Debug.Log("Error with Data");
                    ExampleSphere.gameObject.SetActive(true);
                    ExampleSphere.GetComponent<Renderer>().material.color = Color.yellow;
                }
            }
        }
    }
}

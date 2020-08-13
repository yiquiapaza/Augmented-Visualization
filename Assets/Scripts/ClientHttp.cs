﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class ClientHttp : MonoBehaviour
{
    [SerializeField]
    public string url;
    [SerializeField]
    public Transform ExampleSphere;

    [SerializeField]
    public string jsonString;

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
                ExampleSphere.position = gameObject.transform.position;
                ExampleSphere.gameObject.SetActive(true);
                ExampleSphere.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                if(www.isDone)
                {
                    Debug.Log("Is Done!!");
                    ExampleSphere.position = gameObject.transform.position;
                    ExampleSphere.gameObject.SetActive(true);
                    ExampleSphere.GetComponent<Renderer>().material.color = Color.blue;
                }
                else
                {
                    Debug.Log("Error with Data");
                    ExampleSphere.position = gameObject.transform.position;
                    ExampleSphere.gameObject.SetActive(true);
                    ExampleSphere.GetComponent<Renderer>().material.color = Color.yellow;
                }
            }
        }
    }
   
}

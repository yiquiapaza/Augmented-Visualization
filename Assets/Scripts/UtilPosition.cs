using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UtilPosition : MonoBehaviour
{
    [SerializeField]
    public Transform PositionTransform;

    // Start is called before the first frame update
    void Start()
    {
        PositionTransform.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

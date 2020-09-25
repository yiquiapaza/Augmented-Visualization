using augmented_visualization;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GenericAxisPrefab : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _tickLabelPrefab = null;
    [SerializeField]
    private TextMeshPro _axisLabelPrefab = null;
    [SerializeField]
    private Transform _axisRoot = null;
    [SerializeField]
    private Canvas _labelCanvas = null;
    [SerializeField]
    private float _tickLabel = 0.03f;
    [SerializeField]
    private float _labelOffset = 0.01f;
    [SerializeField]
    private GameObject _tick = null;

    
    [SerializeField]
    private string[] _labels = null;
       

    [SerializeField]
    private string _nameLabel = null;

    [SerializeField]
    private bool _swapped = false;

    private float _length = 1.0f;
    private float _axisLabelOffset = -0.006f;

    private Vector3 _invCanvasScale = Vector3.one;
    private MeshFilter _meshFilter;

    // Start is called before the first frame update
    void Start()
    {
        CreateAxisLabel(_nameLabel);
        CreateTicks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void CreateAxisLabel(string axisLabel)
    {
        var label = Instantiate(_axisLabelPrefab, _labelCanvas.transform, false);        
        float posX = _length / 2;
        float posY = _length / 8;
        if (!_swapped)
            posY *= -1;
        //label.transform.localScale = Vector3.one;
        label.transform.localPosition = new Vector3(posX, posY, 0.0f);
        label.text = axisLabel;
    }

    private void CreateTicks()
    {
        if(_labels.Length != 0)
        {
            float tickSize = _length / _labels.Length;
            var tmpTick = tickSize;
            for (int i = 0; i < _labels.Length; i++)
            {
                var tick = Instantiate(_tick, _axisRoot.transform, false);
                tick.transform.localPosition = new Vector3(tmpTick, _axisLabelOffset, 0.0f);
                tmpTick += tickSize;
                Debug.Log(tmpTick);
            }
        }
    }
}

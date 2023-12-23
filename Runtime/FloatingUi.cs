using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingUi : MonoBehaviour
{
    private Transform _unit;
    private Transform _mainCamera;
    private Transform _worldSpaceCanvas;

    [SerializeField] private float offset = 10;
    // Start is called before the first frame update
    void Start()
    {
        _unit = transform.parent;
        if (Camera.main != null) _mainCamera = Camera.main.transform;
        var canvases = FindObjectsOfType<Canvas>();
        foreach (var canvas in canvases)
        {
            if (canvas.CompareTag("WorldSpaceCanvas"))
            {
                _worldSpaceCanvas = canvas.transform;
                break;
            }
        }
        
        transform.parent = _worldSpaceCanvas;
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(_mainCamera);
        transform1.position = _unit.position;
    }
}

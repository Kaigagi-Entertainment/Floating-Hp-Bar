using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    private float _percentage = 50;

    public float Percentage
    {
        get => _percentage;
        set
        {
            _percentage = value;
            fill.localScale = new Vector3(_percentage/ 100, 1, 1);
        }
    }

    [SerializeField] private Transform fill;
}

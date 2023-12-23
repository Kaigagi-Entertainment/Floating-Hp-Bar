using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class HPBar : ProgressBar
{
    [SerializeField] private float maxHpValue = 100;

    private float _currentHp = 50;
    public float CurrentHpValue
    {
        get => _currentHp;
        set
        {
            _currentHp = Mathf.Clamp(value, 0, maxHpValue);
            CalculatePercentage(_currentHp, maxHpValue);
        } 
    }

    public float MaxHpValue
    {
        get => maxHpValue;
        set
        {
            maxHpValue = value;
            CalculatePercentage(_currentHp, maxHpValue);
        }
    }

    private void CalculatePercentage(float current, float max)
    {
        Percentage = _currentHp / maxHpValue * 100;
    }
}

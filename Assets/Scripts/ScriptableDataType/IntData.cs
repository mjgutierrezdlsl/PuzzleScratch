using System;
using UnityEngine;

[CreateAssetMenu(fileName = "IntData", menuName = "Data Types/IntData")]
public class IntData : ScriptableObject
{
    private float _value;
    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(_value);
        }
    }
    public event Action<float> OnValueChanged;
}

using System;
using UnityEngine;

[Serializable]
public class ProgressBorder
{
    public int ModelIndex => _modelIndex;
    public string BorderName => _borderName;
    public float BorderValue => _borderValue;

    [SerializeField] [Range(0f,1f)] private float _borderValue;
    [SerializeField] private int _modelIndex;
    [SerializeField] private string _borderName;
}
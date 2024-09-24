using System;
using UnityEngine;

public class ProgressService : MonoBehaviour
{
    public event Action<float> OnProgressChanged;

    [SerializeField] private ProgressBarView _barView;

    [SerializeField] private float _maxValue = 50f;
    [SerializeField] private float _startValue = 0f;

    private float _poorValue = 0f;

    private void Awake()
    {
        _barView.SetValue(_startValue/_maxValue);
    }

    public void AddValue(float value)
    {
        if (value == 0) return;

        _poorValue += value;

        if(_poorValue > _maxValue)
        {
            _poorValue = _maxValue;
        }

        _barView.SetValue(_poorValue / _maxValue);

        OnProgressChanged?.Invoke(_poorValue/_maxValue);
    }
}

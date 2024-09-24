using System.Collections.Generic;
using UnityEngine;

public class ProgressBordersChecker : MonoBehaviour
{
    [SerializeField] private ProgressService _progressService;
    [SerializeField] private ProgressBarView _progressBarView;
    [SerializeField] private PlayerModelSwitcher _modelSwitcher;

    [SerializeField] private List<ProgressBorder> _borders;

    private ProgressBorder _currentProgressBorder;

    private void Awake()
    {
        _currentProgressBorder = _borders[0];
        _progressService.OnProgressChanged += ProgressChangedHandle;
    }

    private void ProgressChangedHandle(float value)
    {
        ProgressBorder newBorder = _currentProgressBorder;

        foreach (ProgressBorder border in _borders)
        {
            if (border.BorderValue <= value)
            {
                newBorder = border;
            }
            else
            {
                break;
            }
        }

        if(newBorder != _currentProgressBorder)
        {
            _currentProgressBorder = newBorder;
            SetView(_currentProgressBorder);
        }
    }

    private void SetView(ProgressBorder border)
    {
        _progressBarView.SetProgressName(border.BorderName);
        _modelSwitcher.SwitchModelByIndex(border.ModelIndex);
    }
}
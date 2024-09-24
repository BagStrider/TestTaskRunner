using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _progressName;

    public void SetValue(float value)
    {
        _image.fillAmount = value;
    }
    
    public void SetProgressName(string name)
    {
        _progressName.text = name;
    }
}

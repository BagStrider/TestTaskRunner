using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyNumbersView : MonoBehaviour
{
    public event Action Fades;

    [SerializeField] private Animator _animator;
    [SerializeField] private TMP_Text _cashText;
    [SerializeField] private Image _plusImage;
    [SerializeField] private Image _dollarImage;

    [SerializeField] private Sprite _dollarGreen;
    [SerializeField] private Sprite _dollarRed;

    public void SetCashText(string text)
    {
        _cashText.text = text;
    }

    public void PlayAppearAnimation()
    {
        _animator.Play("Appear", -1, 0f);
    }

    public void AnimationEndshandle()
    {
        Fades?.Invoke();
    }

    public void ToRed()
    {
        _cashText.color = Color.red;
        _plusImage.color = Color.red;
        _dollarImage.sprite = _dollarRed;
    }    
    public void ToGreen()
    {
        _cashText.color = Color.green;
        _plusImage.color = Color.green;
        _dollarImage.sprite = _dollarGreen;
    }
}
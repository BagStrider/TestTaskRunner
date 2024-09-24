using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapToPlayTrigger : MonoBehaviour, IPointerDownHandler
{
    public event Action OnPlayerTap;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnPlayerTap?.Invoke();
    }
}
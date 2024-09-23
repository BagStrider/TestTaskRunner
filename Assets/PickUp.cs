using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float Price => _price;

    [SerializeField] private float _price;
}
using UnityEngine;

public class PickUpCollector : MonoBehaviour
{
    [SerializeField] private MoneyNumbersView _numbersView;
    [SerializeField] private ProgressService _progressService;

    private float _lastCash = 0f;

    private void Awake()
    {
        _numbersView.Fades += NumbersFadeHandle;
    }

    private void NumbersFadeHandle()
    {
        Debug.Log(_lastCash);
        _lastCash = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PickUp>(out var pickup))
        {
            if(Mathf.Sign( pickup.Price) != Mathf.Sign(_lastCash))
            {
                _lastCash = 0f;
            }

            if (pickup.Price > 0f)
            {
                _numbersView.ToGreen();
            }
            else
            {
                _numbersView.ToRed();
            }

            _lastCash += pickup.Price;

            _progressService.AddValue(pickup.Price);

            _numbersView.SetCashText(_lastCash.ToString());

            _numbersView.PlayAppearAnimation();
        }
    }

    private void OnDisable()
    {
        _numbersView.Fades -= NumbersFadeHandle;
    }
}
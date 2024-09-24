using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private GameObject _startHand;
    [SerializeField] private TapToPlayTrigger _tapToPlayTrigger;
    [SerializeField] private PlayerView _playerView;

    private void Awake()
    {
        //_playerView.PlayIdleAnimation();    
        _playerMovement.MovingActive(false);
        _tapToPlayTrigger.OnPlayerTap += OnPlayerTapHandle;
    }

    private void OnPlayerTapHandle()
    {
        _playerMovement.MovingActive(true);
        _playerView.PlaySadWalkAnimation();
        _startHand.SetActive(false);
    }

    private void OnDisable()
    {
        _tapToPlayTrigger.OnPlayerTap -= OnPlayerTapHandle;
    }
}

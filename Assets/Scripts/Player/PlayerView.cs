using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    public void PlayDanceAnimation()
    {
        _animator.Play("Dance");
    }

    public void PlaySadWalkAnimation()
    {
        _animator.SetBool("Walk", true);
        _animator.Play("SadWalk");
    }

    public void PlayIdleAnimation()
    {
        _animator.Play("Idle");
    }

    public void PlaySwitchAnimation()
    {
        _animator.Play("Switch");
    }
}
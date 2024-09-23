using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private float _speed = 5f;

    private Vector3 _moveDir;
    private bool _canMove = true;

    private void Update()
    {
        JoyStickInput();
    }

    private void FixedUpdate()
    {
        if (_canMove == false)
        {
            _rb.velocity = Vector3.zero;
            return;
        }

        _rb.velocity = (Vector3.forward + _moveDir) * _speed * Time.deltaTime;
    }

    private void JoyStickInput()
    {
        Vector3 joystickDir = _joystick.Direction;

        _moveDir = new Vector3(joystickDir.x, 0, 0);
    }

    public void MovingActive(bool value)
    {
        _canMove = value;
    }
}

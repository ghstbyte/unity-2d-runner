using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActions : MonoBehaviour 
{
    private PlayerInputAction _inputAction;

    private Vector2 _inputActionVector;
    public Vector2 InputVector => _inputActionVector;

    public event EventHandler IsRunning;

    private void Awake() {
        _inputAction = new PlayerInputAction();
    }

    private void OnEnable() {
        _inputAction?.Enable();
    }


    private void Update() {
        _inputActionVector = _inputAction.PlayerActions.Move.ReadValue<Vector2>();
        RunningInputAction();
    }

    public void RunningInputAction() {
        if (_inputActionVector.x > 0) {
            IsRunning?.Invoke(this, EventArgs.Empty);
        }
    }

}

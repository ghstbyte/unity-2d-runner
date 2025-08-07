using UnityEngine;
using UnityEngine.InputSystem;

public class InputActions : MonoBehaviour 
{
    private PlayerInputAction _inputAction;

    private Vector2 _inputActionVector;
    private Vector2 _displacementPosition;

    private void OnEnable() {
        _inputAction.Enable();
    }

    private void Awake() {
        _inputAction = new PlayerInputAction();
    }

    private void FixedUpdate() {
        GetDisplacementPosition();
        MovePlayerPosition();
    }

    private void Update() {
        _inputActionVector = _inputAction.PlayerActions.Move.ReadValue<Vector2>();
    }

    private void GetDisplacementPosition() {
        _displacementPosition = _inputActionVector.normalized * Player.Instance.PlayerSpeed * Time.fixedDeltaTime;
    }

    public void MovePlayerPosition() {
        Player.Instance.rb.position += _displacementPosition;
    }
}

using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] InputActions _inputActionsCopy;
    [SerializeField] float _playerSpeed;
    public static Player Instance { get; private set; }

    private Vector2 _displacementPosition;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        GetDisplacementPosition();
        MovePlayerPosition();
    }

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void GetDisplacementPosition()
    {
        _displacementPosition = _inputActionsCopy.InputVector.normalized * _playerSpeed * Time.fixedDeltaTime;
    }

    public void MovePlayerPosition()
    {
        rb.position += _displacementPosition;
    }

}

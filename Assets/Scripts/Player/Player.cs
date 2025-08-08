using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    [SerializeField] float _playerSpeed;
    private void Awake() {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    public Rigidbody2D rb;
    public float PlayerSpeed => _playerSpeed;

}

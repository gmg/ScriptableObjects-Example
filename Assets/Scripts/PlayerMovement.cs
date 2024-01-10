using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 8.0f;

    private Vector2 movementInput;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue input)
    {
        movementInput = input.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rb2d.velocity = movementInput * movementSpeed;
    }
}

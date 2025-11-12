using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura entrada de movimento (WASD ou setas)
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // Normaliza pra n�o andar mais r�pido na diagonal
        moveInput.Normalize();
    }

    void FixedUpdate()
    {
        // Movimento suave com f�sica
        rb.linearVelocity = moveInput * moveSpeed;
    }
}

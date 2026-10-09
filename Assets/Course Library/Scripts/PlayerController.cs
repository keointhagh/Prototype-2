using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction fireAction;
    public Vector2 moveInput;
    public float moveSpeed = 30.0f;
    public float xRange = 15.0f;
    public GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        if(transform.position.x < -xRange && moveInput.x < 0)
        {
            moveInput.x = 0;
        }
        else if (transform.position.x > xRange && moveInput.x > 0)
        {
            moveInput.x = 0;
        }
        transform.Translate(Vector3.right * moveInput.x * moveSpeed * Time.deltaTime);

        if (fireAction.triggered)
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}

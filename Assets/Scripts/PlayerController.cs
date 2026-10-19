using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    [SerializeField] private Vector2 movementInput;

    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * movementInput.x);
    }
}

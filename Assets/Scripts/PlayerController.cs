using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    [SerializeField] private Vector2 movementInput;
    private bool isFirstPerson = false;

    private void Start()
    {
        firstPersonCamera.SetActive(false);
        thirdPersonCamera.SetActive(true);
    }
    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            isFirstPerson = !isFirstPerson;
            firstPersonCamera.SetActive(isFirstPerson);
            thirdPersonCamera.SetActive(!isFirstPerson);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * movementInput.x);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction changeCameraAction;
    public float speed;
    public float turnSpeed;
    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    [SerializeField] private Vector2 movementInput;
    private bool isFirstPerson = false;

    private void Start()
    {
        firstPersonCamera.SetActive(false);
        //thirdPersonCamera.SetActive(true);
        moveAction.Enable();
        changeCameraAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeCameraAction.WasPressedThisFrame())
        {
            isFirstPerson = !isFirstPerson;
            firstPersonCamera.SetActive(isFirstPerson);
            thirdPersonCamera.SetActive(!isFirstPerson);
        }
        movementInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * movementInput.x);
    }
}

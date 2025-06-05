using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MobileFPSController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sensitivity = 2f;

    public VariableJoystick moveJoystick;
    public VariableJoystick lookJoystick;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float verticalRotation = 0;
    public float upDownRange = 60.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        HandleMovement();
        HandleLooking();
    }

    void HandleMovement()
    {
        float x = moveJoystick.Horizontal;
        float z = moveJoystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }

    void HandleLooking()
    {
        float mouseX = lookJoystick.Horizontal * sensitivity;
        float mouseY = lookJoystick.Vertical * sensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);

        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX);
    }
}
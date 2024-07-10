using UnityEngine;

public class MousLook : MonoBehaviour
{
    [SerializeField] private Transform _playerBody;
    [SerializeField] private float _mouseSensivity = 100f;

    private float xRotaion = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;

        xRotaion -= mouseY;
        xRotaion = Mathf.Clamp(xRotaion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotaion, 0f, 0f);
        _playerBody.Rotate(Vector3.up * mouseX);
    }
}

using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private CharacterController _player;

    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _jumpSila = 3f;
    
    private Vector3 velosity;

    private float gravity = -9.81f;

    private void Update()
    {
        if (_player.isGrounded && Input.GetButton("Jump"))
        {
            velosity.y = 0f;
            velosity.y = Mathf.Sqrt(_jumpSila * -2f * gravity);
        }

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveY;
        velosity.y += gravity * Time.deltaTime;

        _player.Move(move * _speed * Time.deltaTime);
        _player.Move(velosity * Time.deltaTime);
    }
}

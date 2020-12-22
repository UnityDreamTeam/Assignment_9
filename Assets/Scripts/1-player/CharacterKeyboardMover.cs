using System.Collections;
using UnityEngine;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover: MonoBehaviour {
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float _speed = 3.5f;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] KeyCode jump_key;
    readonly float jumpHight = 10;

    private CharacterController _cc;
    void Start() {
        _cc = GetComponent<CharacterController>();
    }

    Vector3 velocity;

    void Update()  {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        velocity.x = x * _speed;
        velocity.z = z * _speed;
        if (!_cc.isGrounded)
        {
            velocity.y -= _gravity * Time.deltaTime;
        }
        else 
        {
            velocity.y = y * _speed;
        }
        if (Input.GetKeyDown(jump_key))
        {
            Debug.Log(_cc.isGrounded);
            y += jumpHight;
        }        
         velocity = transform.TransformDirection(velocity);
        _cc.Move(velocity * Time.deltaTime);
    }
}

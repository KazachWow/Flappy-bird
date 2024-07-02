using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float _jumpForce;

    private Rigidbody2D _rigidBody;

    

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidBody.velocity = Vector2.up * _jumpForce;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rigidBody.velocity = Vector2.right * _jumpForce;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rigidBody.velocity = Vector2.left * _jumpForce;
        }
    }
    
}

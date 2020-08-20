using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Rigidbody2D playerRigidbody2D;

    [Header("目前水平速度")]
    public float speedX;
    public Animator animator;
    [Header("目前水平方向")]
    // public float horizontolDirection;
    // public float verticalDirection;

    const string HORIZONTOL = "chanllegerh1";
    const string VERTICAL = "chanllegerv1";

    Vector2 movement;


    float speedY;

    public float _speed;// Start is called before the first frame update



    void Start()
    {
        // playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void MovementX()
    {
        movement.x = Input.GetAxisRaw(HORIZONTOL);
        movement.y = Input.GetAxisRaw(VERTICAL);
        // horizontolDirection = Input.GetAxis(HORIZONTOL);
        // verticalDirection = Input.GetAxis(VERTICAL);
        transform.Translate(_speed * movement.x * Time.deltaTime, _speed * movement.y * Time.deltaTime, 0);
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

    }
    // Update is called once per frame
    void Update()
    {
        MovementX();
        // speedX = playerRigidbody2D.velocity.x;
    }
}

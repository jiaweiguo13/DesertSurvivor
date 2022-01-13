using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
     private Vector2 movement;
     Vector2 movementDirection;
     private Rigidbody2D rb;
    [SerializeField] float speed = 20;
    // set is walking by using movement direction mgnitude
    public bool isWalking => movementDirection.magnitude > 0f;
    // Getter for movement direction.
    public Vector2 getMovementDirection
    {
        get
        {
            return movementDirection;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x > 0.1f)
        {
            movementDirection.x =1f;
        }else if (movement.x < 0f)
        {
            movementDirection.x = -1f;
        }
        else
        {
            movementDirection.x = 0f;
        }

        if (movement.y > 0.1f)
        {
            movementDirection.y = 1f;
        }
        else if (movement.y < 0f)
        {
            movementDirection.y = -1f;
        }
        else
        {
            movementDirection.y = 0f;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}

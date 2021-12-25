using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersControl : MonoBehaviour
{
    [SerializeField] public float speed; 
    [SerializeField] public float jumpForce = 5.5f;

    private Rigidbody2D rb; 
    private SpriteRenderer sprite;
    
    private float moveInput;


    private bool onGround = false;

    public Joystick joystick;

    private bool faceRight = true;

    void Awake()
    {
        rb  =   GetComponent<Rigidbody2D>(); 
        sprite  =   GetComponentInChildren<SpriteRenderer>(); 
    }

    void FixedUpdate() 
    {
        GroundCheck();
    }

    void Update()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2 (moveInput*speed, rb.velocity.y);
        if(faceRight==false&&moveInput>0)
        {
            Flip();
        }
        else if(faceRight&&moveInput<0)
        {
            Flip();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if(Input.GetButton("Horizontal"))
        {
            if((Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))&&faceRight==false)
            {
                Flip();
            }

            else if((Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))&&faceRight)
            {
                Flip();
            }
            Move();
        }
    }

    void Flip()
    {
        faceRight=!faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x*=-1;
        transform.localScale = Scaler;
    }

    private void Move()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);
    }

    public void Jump()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.42f);
        if(colliders.Length>1)
        {
            rb.AddForce(transform.up*jumpForce, ForceMode2D.Impulse);
        }
    }

    private void GroundCheck()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.42f);
        onGround = colliders.Length>1;
        //Debug.Log(colliders.Length);
    }

    private void OnCollisionEnter2D(Collision2D cross)
    {
        if(cross.gameObject.name.Equals("Movingtile")||cross.gameObject.name.Equals("Box"))
        {
            this.transform.parent = cross.transform;
            speed = 2.7f;

        }
    }
    
    private void OnCollisionExit2D(Collision2D cross)
    {
        if(cross.gameObject.name.Equals("Movingtile")||cross.gameObject.name.Equals("Box"))
        {
            this.transform.parent = null;
            speed = 2.5f;
            
        }
    }
}

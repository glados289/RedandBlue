using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestPlayersControl : MonoBehaviour
{
    [SerializeField] public float speed = 2.5f; 
    [SerializeField] private float jumpForce = 5.5f;
    private float moveInput;

    private Rigidbody2D rb; 
    private SpriteRenderer sprite;
    
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
    }

    /*private void Move()
    {
        Vector3 dir =  transform.right*Input.GetAxis("Horizontal");
        transform.position  =   Vector3.MoveTowards(transform.position, transform.position+dir,    speed*Time.deltaTime);
        sprite.flipX    =   dir.x<0.0f;
    }*/
    void Flip()
    {
        faceRight=!faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x*=-1;
        transform.localScale = Scaler;
    }
    public void Jump()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.42f);
        if(colliders.Length>1)
        {
            rb.AddForce(transform.up*jumpForce, ForceMode2D.Impulse);
        }
        
    }

    public void GroundCheck()
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
            speed = 3.2f;

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

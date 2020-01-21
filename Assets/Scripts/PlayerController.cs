using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float heroSpeed;
    public float jumpForce;
    public Transform groundTester;
    public LayerMask layersToTest;
    Animator anim;
    Rigidbody2D rgBody;
    bool directiontoRight = true;
    public Transform startPoint;

    private bool onTheGround;
    private float radius = 0.1f;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()

    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Dead"))
        {
            rgBody.velocity = Vector2.zero;
            return;
        }
        

        onTheGround = Physics2D.OverlapCircle (groundTester.position, radius,layersToTest);
        float horizontalMove = Input.GetAxis("Horizontal");
        rgBody.velocity = new Vector2(horizontalMove * heroSpeed, rgBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)&& onTheGround){
            rgBody.AddForce (new Vector2 (0f, jumpForce));
            anim.SetTrigger("jump");


        }

        
        anim.SetFloat("speed",Mathf.Abs( horizontalMove));

        if (horizontalMove < 0 && directiontoRight)
        {
            Flip();
        }
        if(horizontalMove > 0 && !directiontoRight)
        {
            Flip();
        }

       


    }

    void Flip()
    {
        directiontoRight = !directiontoRight;
        Vector3 hereoScale = gameObject.transform.localScale;
        hereoScale.x *= -1;
        gameObject.transform.localScale = hereoScale;

    }
    public void RestartHero()
    {
        gameObject.transform.position = startPoint.position;

    }
}

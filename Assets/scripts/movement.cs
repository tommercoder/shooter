using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public Camera cam;
    Vector2 mousePosV;
    Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y= Input.GetAxisRaw("Vertical");
       
       ///// animator.SetFloat("Horizontal", moveVector.x);
        //animator.SetFloat("Vertical", moveVector.y);
        animator.SetFloat("Speed", moveVector.sqrMagnitude);


        var mousePos = Input.mousePosition;
        mousePos.z = 10; // select distance = 10 units from the camera
        //Debug.Log(cam.ScreenToWorldPoint(mousePos));
        mousePosV = cam.ScreenToWorldPoint(mousePos);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVector * speed * Time.fixedDeltaTime);
        
        Vector2 lookdir = mousePosV - rb.position;
        float angle = Mathf.Atan2(lookdir.y,lookdir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.CompareTag("enemy"))
		{
            
			//Debug.Log("enemy collide with player");
//			player.GetComponent<Rigidbody2D>().AddForce(transform.forward * 2);

			
		}
        else if(collision.gameObject.CompareTag("Map"))
        {
            Debug.Log(collision.gameObject.name) ;
        }
        
	}
}
   
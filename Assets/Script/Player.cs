using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{   
    private Rigidbody2D rb;
    private float dirX;
    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] float speed;
    [SerializeField] private AudioSource deathsfx;
    [SerializeField] Text Wrong;
    [SerializeField] Text GameOver;
    private bool grounded;
    [SerializeField] MenuManager menu;
    
    
    
    
    // Start is called before the first frame update
  private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //this makes the character a subject to physics and its laws
        sprite = GetComponent<SpriteRenderer>(); //everything regarding the sprite
        anim = GetComponent<Animator>(); //everything regarding the animations
    }



    // Update is called once per frame
   private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed,rb.velocity.y); //to make the character move left and right using the arrow buttons on the keyboard

        if (Input.GetButtonDown("Jump")) 
        {
            Jump();
            
        }
        anim.SetBool("grounded", grounded); //if the character jumps the jumping animation will be played

        if (dirX > 0f)
        {
            anim.SetBool("running", true); //if the character moves to the right the running animation will be played
            sprite.flipX = false; //makes the character sprite flip

        }

        else if (dirX < 0f)
        {
            anim.SetBool("running", true); //if the character moves to the left the running animation will be played
            sprite.flipX = true; //makes the character sprite flip

        }
        else
        {
            anim.SetBool("running", false); //if the character doesn't move the idle animation will be played instead
        }

    }

   
   
    
   

    private void OnCollisionEnter2D(Collision2D collision) //everything that regards the player when touching a tagged object
    {
        
        if (collision.gameObject.tag == "Wrong")
        {
            deathsfx.Play();//death sound effect will play
            rb.bodyType = RigidbodyType2D.Static;//the player is stopped and can't move anymore
            Wrong.text = "Wrong Ingredient!"; //game over if she picks the wrong ingredient + text that displays that
            menu.gameObject.SetActive(true);//makes the menu appear
        }
        if(collision.gameObject.tag == "Obstacle")
        {
            
            deathsfx.Play();
            anim.SetTrigger("death");//death animation will be played
            rb.bodyType = RigidbodyType2D.Static;
            //gameObject.SetActive(false);
            GameOver.text = "Game Over!"; //character death if she touches the obstacles
            menu.gameObject.SetActive(true);
            
            

        }
        if(collision.gameObject.tag == "Ground")//tags the ground so the jumping anumation can be played
        {
            grounded = true;
        }
        
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 14f); //to make the character jump using the space button on the keyboard
        grounded = false;

    }
    

}

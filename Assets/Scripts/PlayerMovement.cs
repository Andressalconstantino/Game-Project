using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 1;
    public float jumpPower = 1;
    private Rigidbody2D player;
    Animator animator;

     void Start(){
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

     void Animate(){
        var inputX = Input.GetAxis("Horizontal");
        if (Input.GetKey("x")){
            animator.SetBool("isAttacking", true);
        }
        

        else if (Input.GetButton("Jump")){
            animator.SetBool("canFly", true);
            animator.SetBool("isAttacking", false);
        }
        else{
        animator.SetFloat("inputX", Mathf.Abs(inputX));
        animator.SetBool("canFly", false);
        animator.SetBool("isAttacking", false);
        }
     }

     void Update(){
        
        Animate();

        MovePlayer();   

        if (Input.GetButton("Jump"))
            Jump();

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") > 0){
            characterScale.x = 1;
            }
        if (Input.GetAxis("Horizontal") < 0){
            characterScale.x = -1;
        }
        transform.localScale = characterScale;
    }

    
    
    void MovePlayer(){  
        var inputX = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(inputX * playerSpeed, player.velocity.y);
    }
    private void Jump() => player.velocity = new Vector2( 0, jumpPower);
}

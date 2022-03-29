using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public Vector3 velocity;
    
    private Rigidbody rb;
    
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionStay()
         {
             isGrounded = true;
         }
    void OnCollisionExit()
         {
             isGrounded = false;
         }
    
    void jump(int force){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            isGrounded = false;
            rb.velocity = new Vector3(rb.velocity.y, force , 0);
            Debug.Log("jump");
        }
    }
    
    void Update(){
        transform.position += velocity * Time.deltaTime;
        jump(7);


        velocity.x = 0;
        velocity.z = 0;
        
        if(Input.GetKey(KeyCode.A))
        {
            velocity.z = -5;
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            velocity.z = 5;
        }
        
         
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded;
    public Vector3 velocity;
    public GameObject projectile;
    private Rigidbody selfRigidbody;
    
    
    void Start(){
        selfRigidbody = GetComponent<Rigidbody>();
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
            selfRigidbody.AddForce(0, force, 0, ForceMode.Impulse);
            
        }
    }
    
    void Update(){
        transform.position += velocity * Time.deltaTime;
        jump(50);


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
        if (Input.GetKeyDown(KeyCode.LeftShift))
         {
             GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
             bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
         }
         
    }
}

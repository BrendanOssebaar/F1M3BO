using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class HomingMissile : MonoBehaviour
{
    public Camera cam; 
    
    public float speed = 10f;
    private Rigidbody rigidBody;
    public float movementSpeed;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        cam = Camera.main;
    }
    void FixedUpdate()
    {
        
            Vector2 mousePos = Input.mousePosition;
            Vector3 target = cam.ScreenToWorldPoint(new Vector3(cam.nearClipPlane, -mousePos.y+(Screen.height/2), -mousePos.x+(Screen.width/2)));

        Debug.Log(mousePos);
            
            Vector3 direction = target - transform.position;
            target.x = transform.position.x;
            direction.Normalize();
            //transform.LookAt(target);
            rigidBody.velocity = direction * speed;

        
        
    }
}

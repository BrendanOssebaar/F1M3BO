using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject projectile;
    public Transform spawnPoint;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject bullet = Instantiate(projectile, spawnPoint.position , Quaternion.Euler(90,0,0)) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * 1000);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy.
    }
}

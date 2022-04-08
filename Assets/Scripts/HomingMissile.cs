using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject projectile;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject Rocket = Instantiate(projectile, spawnPoint.position, Quaternion.Euler(42.3f, 0, 0)) as GameObject;
            Rocket.GetComponent<Rigidbody>().AddForce(transform.right * 1000);

        }
    }
}

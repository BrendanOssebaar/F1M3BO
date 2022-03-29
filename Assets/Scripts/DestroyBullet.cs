using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Prefab;
    public Transform originalObject;
    public Transform reflectedObject;
    
    
    void Start()
    {

    }

    
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.name != "Character")
            {
                GameObject particle = Instantiate(Prefab, bullet .transform.position, Quaternion.Euler(180,0,0));
                
                Destroy(bullet);
                Destroy(particle, 0.5f);
                
            }
            
            
        }
    }

}

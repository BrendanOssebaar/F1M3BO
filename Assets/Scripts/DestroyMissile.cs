using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissile : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Prefab;
    


    void Start()
    {
        Destroy(Missile, 3f);
    }


    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.name != "Character")
            {
                GameObject particle = Instantiate(Prefab, Missile.transform.position, Quaternion.Euler(180, 0, 0));
                Destroy(Missile);

                Destroy(particle, 0.5f);

            }


        }
    }
}

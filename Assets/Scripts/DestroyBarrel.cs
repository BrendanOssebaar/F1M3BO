using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrel : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject Prefab;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.name == "bullet(Clone)")
            {
                GameObject particle = Instantiate(Prefab, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                GameObject particle2 = Instantiate(Prefab2, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                GameObject particle3 = Instantiate(Prefab3, Barrel.transform.position, Quaternion.Euler(-90, 0, 0));
                GameObject particle4 = Instantiate(Prefab4, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                Destroy(Barrel);
                Destroy(particle, 5f);
                Destroy(particle2, 5f);
                Destroy(particle3, 5f);
                Destroy(particle4, 5f);

            }
            if (collision.gameObject.name == "Missile(Clone)")
            {
                GameObject particle = Instantiate(Prefab, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                GameObject particle2 = Instantiate(Prefab2, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                GameObject particle3 = Instantiate(Prefab3, Barrel.transform.position, Quaternion.Euler(-90, 0, 0));
                GameObject particle4 = Instantiate(Prefab4, Barrel.transform.position, Quaternion.Euler(0, 0, 0));
                Destroy(Barrel);
                Destroy(particle, 5f);
                Destroy(particle2, 5f);
                Destroy(particle3, 5f);
                Destroy(particle4, 5f);

            }

        }
    }
}
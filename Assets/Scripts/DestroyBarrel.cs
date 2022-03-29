using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrel : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject Prefab;



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
                Destroy(Barrel);
                Destroy(particle, 5f);

            }

        }
    }
}
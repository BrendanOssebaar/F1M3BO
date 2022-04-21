using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissile : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Prefab;
    public AudioClip otherClip;


    void Start()
    {
        Destroy(Missile, 3f);
    }
    public void Update()
    {
       
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.name != "Character")
            {
                Debug.Log("apparent collision");
                GameObject particle = Instantiate(Prefab, Missile.transform.position, Quaternion.Euler(180, 0, 0));
                AudioSource audio = GetComponent<AudioSource>();
                AudioSource.PlayClipAtPoint(otherClip,collision.gameObject.transform.position);
                Destroy(Missile);
                Destroy(particle, 0.5f);

            }


        }
    }
}

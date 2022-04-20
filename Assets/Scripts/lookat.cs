using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Barrel");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.FindWithTag("Barrel").transform);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gfawg4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}


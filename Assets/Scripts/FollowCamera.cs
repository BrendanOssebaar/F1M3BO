using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cam;
    public Transform Cylinder;
    public float CamDistance;
 
    public void Update()
    {
        cam.position = Cylinder.position + new Vector3(CamDistance, 3, 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class HomingMissile : MonoBehaviour
{
    [Header("Setup")]
    public Rigidbody RocketRgb;
    public float turnSpeed = 1f;
    public float rocketFlySpeed = 10f;
    private Transform rocketLocalTrans;
    



    void Start()
    {
        
        rocketLocalTrans = GetComponent<Transform>();
        
    }
    
    private void FixedUpdate()
    {
        if (!RocketRgb) 
            return;

        RocketRgb.velocity = rocketLocalTrans.forward * rocketFlySpeed;
        GameObject[] barrels = GameObject.FindGameObjectsWithTag("Barrel");
        if (barrels.Length > 0 && barrels != null)
        {
            float distance = 9000f;
            Transform currentbarrel = barrels[0].transform;
            for (int i = 0; i < barrels.Length; ++i)
            {

                float d = Mathf.Abs(Vector3.Distance(barrels[i].transform.position, RocketRgb.position));

                if (d < distance)
                {
                    distance = d;
                    currentbarrel = barrels[i].transform;
                    

                }
            } 
            var rocketTargetRot = Quaternion.LookRotation(currentbarrel.position - RocketRgb.position);

            RocketRgb.MoveRotation(Quaternion.RotateTowards(RocketRgb.rotation, rocketTargetRot, turnSpeed));

        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrel"))
        {
            Rigidbody plRgb = collision.gameObject.GetComponent<Rigidbody>();
            if (plRgb)
                plRgb.AddForceAtPosition(Vector3.up * 1000f, plRgb.position);

            //Deactivate Rocket..
            this.gameObject.SetActive(false);
        }
    }

}

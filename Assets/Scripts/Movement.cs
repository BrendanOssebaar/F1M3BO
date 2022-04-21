using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;
    public bool isGrounded;
    public Vector3 velocity;
    private Animator animator;
    private Rigidbody rb;
    public Transform MissileSpawner;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    void OnCollisionStay()
    {
        isGrounded = true;
        animator.SetBool("Jump", false);
    }
    void OnCollisionExit()
    {
        isGrounded = false;
        animator.SetBool("Jump", true);
    }

    void jump(int force)
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.velocity = new Vector3(rb.velocity.y, force, 0);
            Debug.Log("jump");

        }
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        jump(7);


        velocity.x = 0;
        velocity.z = 0;
        animator.SetFloat("Speed", 0);

        if (Input.GetKey(KeyCode.A))
        {
            velocity.z = -5;
            animator.SetFloat("Speed", -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity.z = 5;
            animator.SetFloat("Speed", 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject Rocket = Instantiate(projectile, spawnPoint.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Rocket.transform.parent = MissileSpawner;


        }
    }
}

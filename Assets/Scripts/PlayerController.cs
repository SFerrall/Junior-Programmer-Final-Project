using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    float turnSpeed = 100.0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
        }
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * moveInput * moveSpeed * Time.deltaTime);
    }

    private void Turn()
    {
        float turnInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back * turnInput * turnSpeed * Time.deltaTime);
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }

    
}

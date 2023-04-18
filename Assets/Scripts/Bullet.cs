using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up  * bulletSpeed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    { 
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Zombie" )
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            InstanceManager.gameInstance.score += 1;
        }
        
    }
}

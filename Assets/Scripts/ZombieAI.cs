using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject playerTarget;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerTarget = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTarget.transform.position, moveSpeed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Time.timeScale = 0;

           
        }
    }
}

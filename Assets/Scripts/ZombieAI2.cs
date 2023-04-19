using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITENCE
public class ZombieAI2 : ZombieAI
{
    //POLYMORPHISM
    public override void EnemyMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTarget.transform.position, (moveSpeed * 2) * Time.deltaTime);
    }
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
}

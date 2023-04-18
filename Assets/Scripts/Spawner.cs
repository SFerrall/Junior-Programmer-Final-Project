using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
        SpawnZombies();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnZombies()
    {
        Vector3 spawnPos = new Vector3(Random.Range( center.x + (-size.x / 2) , center.x + (size.x / 2) ) , Random.Range( center.y + (-size.y / 2), center.y + (size.y / 2)  )  , 1);
        int index = Random.Range(0, 3);
        Instantiate(enemies[index], spawnPos, Quaternion.identity);
        Invoke("SpawnZombies", 5);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}

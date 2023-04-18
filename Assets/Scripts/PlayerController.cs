using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    float turnSpeed = 100.0f;
    public GameObject bullet;
    public TextMeshProUGUI scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        UpdateScore();
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

    public void UpdateScore()
    {
            scoreboard.text = "Zombie Killz: " + InstanceManager.gameInstance.score;
    }

    public void ExitGame()
    {
        Destroy(GameObject.Find("GameInstance"));
        SceneManager.LoadScene(0);
    }
}

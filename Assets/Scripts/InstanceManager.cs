using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class InstanceManager : MonoBehaviour
{
    public static InstanceManager gameInstance { get; private set; }
    public int score;
    public TextMeshProUGUI scoreboard;

    private void Awake()
    {
        if(gameInstance != null)
        {
            Destroy(gameObject);
        }
        Time.timeScale = 1;
        score = 0;
        gameInstance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    
}

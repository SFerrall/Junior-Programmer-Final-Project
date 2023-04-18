using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstanceManager : MonoBehaviour
{
    public static InstanceManager gameInstance { get; private set; }
    public int score;

    private void Awake()
    {
        if(gameInstance != null)
        {
            Destroy(gameObject);
        }
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

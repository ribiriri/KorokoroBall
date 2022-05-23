using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    private int coinCount;
    public Text textComponent;
    void Start()
    {
        coinCount = 0;
    }

    public void AddCoinCount()
    {
        coinCount++;
        Debug.Log("coinCount:" + coinCount);
        textComponent.text = "CoinCount:" + coinCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

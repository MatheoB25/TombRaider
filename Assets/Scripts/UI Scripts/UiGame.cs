using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class UiGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectDifficulty()
    {
        
    }
    public void SelectName()
    {
        
    }
    public void LaunchPreviousSceneGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LaunchStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}

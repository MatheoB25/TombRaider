using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchControlScene()
    {
        SceneManager.LoadScene("ControlMenu");
    }
    public void LauchSoundScene()
    {
        SceneManager.LoadScene("SoundsMenu");
    }
    public void LaunchPreviousSceneSettings()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

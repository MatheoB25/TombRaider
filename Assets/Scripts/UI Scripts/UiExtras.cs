using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiExtras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchJukeBoxScene()
    {
        SceneManager.LoadScene("MenuJukebox");
    }
    public void LaunchArtBookScene()
    {
        SceneManager.LoadScene("ArtBookMenu");
    }
    public void LaunchCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void LaunchPreviousSceneExtra()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

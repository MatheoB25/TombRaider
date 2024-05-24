using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISelect : MonoBehaviour
{
    public void SelectLevel()

    {
        switch (this.gameObject.name)
        {
            case "Niveau 1":
                SceneManager.LoadScene("LEVEL ONE");
                break;
        }
        switch (this.gameObject.name)
        {
            case "Niveau 2":
                SceneManager.LoadScene("LEVEL TWO");
                break;
        }
        switch (this.gameObject.name)
        {
            case "Niveau 3":
                SceneManager.LoadScene("LEVEL THREE");
                break;
        }
        switch (this.gameObject.name)
        {
            case "Niveau 4":
                SceneManager.LoadScene("LEVEL FOUR");
                break;
        }
        switch (this.gameObject.name)
        {
            case "Niveau 5":
                SceneManager.LoadScene("LEVEL FIVE");
                break;
        }
        switch (this.gameObject.name)
        {
            case "Niveau 6":
                SceneManager.LoadScene("LEVEL SIX");
                break;
        }
    }

    public void LaunchPreviousSceneGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

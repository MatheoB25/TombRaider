using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiMainMenu : MonoBehaviour
    
{
    [SerializeField] private RectTransform PlayButtonRotate;
    private float PlaySpeedRotation = 0.5f;
    private Vector3 PlayRotation;
    private bool RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlaySpeedRotation >= 0.5f)
        {
            RotationSpeed = true;
        }
        else if (PlaySpeedRotation <= 1f)
        {
            RotationSpeed = false;
        }
        if (RotationSpeed == true)
        {
            PlayButtonRotate.localRotation = Quaternion.Euler(0.2f,0.2f, 0f);
        }   
        else if (RotationSpeed == false) 
        {
            PlayButtonRotate.localRotation = Quaternion.Euler(0.2f, 0.2f, 0f);
            PlaySpeedRotation = PlaySpeedRotation - 0.5f;
        }
    }

    public void LaunchGameNew()
    {
        SceneManager.LoadScene("PlayMenu");
    }
    public void LaunchSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
    public void LaunchExtraScene()
    {
        SceneManager.LoadScene("Extra");
    }
    public void LaunchQuitGame()
    {
        Application.Quit();
    }
}

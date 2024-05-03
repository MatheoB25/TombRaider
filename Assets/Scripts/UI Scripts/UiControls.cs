using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchPreviousSceneControls()
    {
        SceneManager.LoadScene("Settings");
    }
    public void LaunchApplyControls()
    {

    }
}

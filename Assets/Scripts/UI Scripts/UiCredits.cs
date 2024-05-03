using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiCredits : MonoBehaviour
{
    [SerializeField] private RectTransform CreditsBack;
    [SerializeField] private RectTransform GrowCredits;
    private float GrowSpeed = 0.5f;
    private Vector3 CreditsScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void CreditsScrollView()
    {

    }
    public void LaunchPreviousSceneCredits()
    {
        SceneManager.LoadScene("Extra");
    }
}

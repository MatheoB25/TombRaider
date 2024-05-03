using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UiStart : MonoBehaviour
{
    [SerializeField] private RectTransform ButtonSize;
    private Vector3 ButtonScale;
    private float SpeedScale = 0.003f;
    private bool ChangeScale = false;


    [SerializeField] private RectTransform TitleMove;
    private bool ChangeTitleMove = false;
    private Vector3 TitleSize;
    private float SpeedTitle = 0.004f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonSize.localScale.x <= 1.5f)
        {
            ChangeScale = true;
        }
        else if (ButtonSize.localScale.x >= 2f)
        {
            ChangeScale = false;
        }
        if (ChangeScale == true) 
        {
            ButtonSize.localScale = new Vector3(ButtonSize.localScale.x + SpeedScale, ButtonSize.localScale.y + SpeedScale, ButtonSize.localScale.z + SpeedScale);
        }
         else if (ChangeScale == false)
        {
            ButtonSize.localScale = new Vector3(ButtonSize.localScale.x - SpeedScale, ButtonSize.localScale.y - SpeedScale, ButtonSize.localScale.z - SpeedScale);
        }
       

        if (TitleMove.localScale.x <= 0.5f)
        {
            ChangeTitleMove = true;
        }
        else if (TitleMove.localScale.x >= 1f)
        {
            ChangeTitleMove = false;
        }
        if (ChangeTitleMove == true)
        {
            TitleMove.localScale = new Vector3(TitleMove.localScale.x + SpeedScale, TitleMove.localScale.y + SpeedScale, TitleMove.localScale.z + SpeedScale);
            
        }
        else if (ChangeScale == false)
        {
            TitleMove.localScale = new Vector3(TitleMove.localScale.x - SpeedScale, TitleMove.localScale.y - SpeedScale, TitleMove.localScale.z - SpeedScale);
            
        }
        if (ChangeTitleMove == true) 
        {
            TitleMove.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            SpeedTitle = 0.005f;
            ChangeTitleMove = false;



        }
    }
    public void LaunchStartScene() 
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string tooltipText = "";

    [SerializeField] private Text tooltipTextGO;
    [SerializeField] private GameObject tooltipText2; 
    [SerializeField] private Font tooltipfont; 

    // Start is called before the first frame update
    void Start()
    {
        tooltipTextGO.text = "Start";

    }

    // Update is called once per frame
    void Update()
    {
        //tooltipTextGO.text = "Update";
        //tooltipTextGO.text = tooltipText;

    }
    public void LaunchGameScene() {
        tooltipTextGO.text = "Lance la scene principale";
        tooltipTextGO.color = Color.magenta;
        tooltipTextGO.font = tooltipfont;
        //tooltipTextGO.text = tooltipText;
    }
    
}

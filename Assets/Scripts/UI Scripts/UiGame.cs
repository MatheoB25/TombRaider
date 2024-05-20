using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiGame : MonoBehaviour
{
    [SerializeField] private Slider _lifeBar;
    [SerializeField] private Slider _lifeBarBot;
    [SerializeField] private LayerCollision _layerCollisionScript;
    // Start is called before the first frame update
    void Start()
    {
        
        _lifeBar.minValue = 0;
        _lifeBar.maxValue = _layerCollisionScript.GetLifeMax();
        _lifeBar.value = _layerCollisionScript.GetCurrentLife();

        
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBar.value = _layerCollisionScript.GetCurrentLife();
       
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

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private int _lifemaxBot = 100;
    [SerializeField] private int _lifecurrentBot = 100;
    [SerializeField] private Slider _lifeBar;
    [SerializeField] private Slider _lifeBarBot;
    [SerializeField] GameObject _enemy;
    [SerializeField] GameObject _bulleto;
    [SerializeField] GameScript _gameScript;
    // Start is called before the first frame update
    void Start()
    {
        _lifeBarBot.minValue = 0;
        _lifeBarBot.maxValue = GetLifeMaxBot();
        _lifeBarBot.value = GetCurrentLifeBot();
    }

    // Update is called once per frame
    void Update()
    {
        _lifeBarBot.value = GetCurrentLifeBot();
        if (_lifecurrentBot == 0 )
            Destroy  (_enemy);
    }
        
    public void ChangeLifeBot(int point)
        {
            _lifecurrentBot = _lifecurrentBot + point;


            if (_lifecurrentBot < 0)
            {
                _lifecurrentBot = 0;
            Destroy (gameObject);
            
            
        }
            if (_lifecurrentBot > _lifemaxBot)
            {
                _lifecurrentBot = _lifemaxBot;
            }
        }
    public int GetLifeMaxBot()
    {
        return _lifemaxBot;
    }
    public int GetCurrentLifeBot()
    {
        return _lifecurrentBot;
       
    }   
    private void OnTriggerEnter(Collider collider)
    {

    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Damage")
        {


            ChangeLifeBot(collider.gameObject.GetComponent<Damage>().GetDamageCostBot());
            Destroy(_bulleto);
            
        }
    }
}

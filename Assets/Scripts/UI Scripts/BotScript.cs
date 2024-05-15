using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _targetBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void InstantiateBullet()
    {
        GameObject bulletinstance = Instantiate(_bullet);

        bulletinstance.transform.position = _targetBullet.transform.position;
        bulletinstance.transform.rotation = _targetBullet.transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

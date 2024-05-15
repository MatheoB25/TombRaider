using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _speedShoot = 1f;
    [SerializeField] private float _Timer = 0f;
    [SerializeField] private float _endBullet = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameObject.transform.forward * _speedShoot * Time.deltaTime);
        _Timer = _Timer + Time.deltaTime;

        if (_Timer > _endBullet)
        {
            Destroy(gameObject);
        }
    }
}

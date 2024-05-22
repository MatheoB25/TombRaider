using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float _speedShoot = 1f;
    [SerializeField] private float _Timer = 0f;
    [SerializeField] private float _endBullet = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, 1f, 0f) * 20f * Time.deltaTime);
        _Timer = _Timer + Time.deltaTime;

        if (_Timer > _endBullet)
        {
            Destroy(gameObject);
        }
       
    }   
    
}

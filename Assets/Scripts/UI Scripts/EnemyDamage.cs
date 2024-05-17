using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private Transform _enemyTransform;
    private Vector3 _velocityEnemy;
    [SerializeField] private float _gravityEnemy = 9.81f;
    [SerializeField] private LayerCollision _scriptCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_scriptCollision.GetColliding() == true && _velocityEnemy.y < 0)
        {
            _velocityEnemy.y = -0f;
        }
        else if (_scriptCollision.GetColliding() == false)
        {
            _velocityEnemy.y = _velocityEnemy.y - _gravityEnemy * Time.deltaTime;
        }
    }
}

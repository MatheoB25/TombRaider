using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LayerCollision : MonoBehaviour
{
    private GameObject _isColliding;
    private GameObject _leverColliding;
    [SerializeField] private int _lifemax = 100;
    [SerializeField] private int _lifecurrent = 100;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            _isColliding = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever")
        {
            _leverColliding = collider.gameObject;
        }
        Debug.Log("Collision enter: " + collider.gameObject.name);

        if (collider.gameObject.tag == "Damage")
        {


            ChangeLife(collider.gameObject.GetComponent<Damage>().GetDamageCost());

            
        }

    }
    public void ChangeLife(int point)
    {
        _lifecurrent = _lifecurrent + point;

        if (_lifecurrent < 0)
        {
            _lifecurrent = 0;
        }
        if (_lifecurrent > _lifemax)
        {
            _lifecurrent = _lifemax;
        }
    }
    public int GetLifeMax()
    {
        return _lifemax;
    }
    public int GetCurrentLife()
    {
        return _lifecurrent;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            _isColliding = collider.gameObject;
        }
        Debug.Log("Collision enter: " + collider.gameObject.name);
    }


    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Ground" && _isColliding.transform.GetInstanceID() == collider.gameObject.transform.GetInstanceID())
        {
            _isColliding = null;
        }

        if (collider.gameObject.tag == "Lever")
        {
            _leverColliding = null; 
        }
        /* private void OnCollisionStay(Collision collision)
          {
              Debug.Log("Collision stay: " + collision.gameObject.name);
          }
        */
    }
    public bool GetColliding()
    {
        return _isColliding != null;
    }
    public bool GetLeverColliding()
    {
        return _leverColliding != null;
    }
}
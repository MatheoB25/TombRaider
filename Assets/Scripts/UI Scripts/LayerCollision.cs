using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LayerCollision : MonoBehaviour
{
    private GameObject _isColliding;
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
        //Debug.Log("Collision enter: " + collision.gameObject.name);
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            _isColliding = collider.gameObject;
        }
        //Debug.Log("Collision enter: " + collision.gameObject.name);
    }


    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Ground" && _isColliding.transform.GetInstanceID() == collider.gameObject.transform.GetInstanceID())
        {
            _isColliding = null;
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
}
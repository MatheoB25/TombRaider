using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LayerCollision : MonoBehaviour
{
    private GameObject _isColliding;
    private bool _leverColliding = false;
    private bool _leverColliding2 = false; 
    private bool _leverColliding3 = false;
    private bool _leverColliding4 = false;
    private bool _leverColliding5 = false;
    private bool _leverColliding6 = false;
    private bool _leverColliding7 = false;
    private bool _leverColliding8 = false;
    private bool _leverColliding9 = false;
    private bool _leverColliding10 = false;
    private bool _leverColliding11 = false;
    private bool _leverColliding12 = false;
    private bool _leverColliding13 = false;
    private bool _leverColliding14 = false;



    private bool _leverElevatorColliding = false;


    
    

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
        if (collider.gameObject.tag == "LeverElevator")
        {
            _leverElevatorColliding = collider.gameObject;
        }
        if (collider.gameObject.tag == "Lever")
        {
            _leverColliding = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever2")
        {
            _leverColliding2 = collider.gameObject;
        }


        if (collider.gameObject.tag == "Lever3")
        {
            _leverColliding3 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever4")
        {
            _leverColliding4 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever5")
        {
            _leverColliding5 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever6")
        {
            _leverColliding6 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever7")
        {
            _leverColliding7 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever8")
        {
            _leverColliding8 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever9")
        {
            _leverColliding9 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever10")
        {
            _leverColliding10 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever11")
        {
            _leverColliding11 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever12")
        {
            _leverColliding12 = collider.gameObject;
        }

        if (collider.gameObject.tag == "Lever13")
        {
            _leverColliding13 = collider.gameObject;
        }
        if (collider.gameObject.tag == "Lever14")
        {
            _leverColliding14 = collider.gameObject;
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

    } public int GetLifeMax()
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

        if (collider.gameObject.tag == "Damage")
        {


            ChangeLife(collider.gameObject.GetComponent<Damage>().GetDamageCost());


        }

        


    }




    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Ground" && _isColliding.transform.GetInstanceID() == collider.gameObject.transform.GetInstanceID())
        {
            _isColliding = null;
        }

        if (collider.gameObject.tag == "LeverElevator")
        {
            _leverElevatorColliding = true;
        }

        if (collider.gameObject.tag == "Lever")
        {
            _leverColliding = true; 
        }


        if (collider.gameObject.tag == "Lever2")
        {
            _leverColliding2 = true;
        }

        if (collider.gameObject.tag == "Lever3")
        {
            _leverColliding3 = true;
        }

        if (collider.gameObject.tag == "Lever4")
        {
            _leverColliding4 = true;
        }

        if (collider.gameObject.tag == "Lever5")
        {
            _leverColliding5 = true;
        }

        if (collider.gameObject.tag == "Lever6")
        {
            _leverColliding6 = true;
        }

        if (collider.gameObject.tag == "Lever7")
        {
            _leverColliding7 = true;
        }

        if (collider.gameObject.tag == "Lever8")
        {
            _leverColliding8 = true;
        }

        if (collider.gameObject.tag == "Lever9")
        {
            _leverColliding9 = true;
        }
        if (collider.gameObject.tag == "Lever10")
        {
            _leverColliding10 = true;
        }

        if (collider.gameObject.tag == "Lever11")
        {
            _leverColliding11 = true;
        }

        if (collider.gameObject.tag == "Lever12")
        {
            _leverColliding12 = true;
        }

        if (collider.gameObject.tag == "Lever13")
        {
            _leverColliding13 = true;
        }

        if (collider.gameObject.tag == "Lever14")
        {
            _leverColliding14 = true;
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

    public bool GetLeverElevatorColliding()
    {
        return _leverElevatorColliding;
    }

    public bool GetLeverColliding()
    {
        return _leverColliding;
    }
    public bool GetLeverColliding2()
    {
        return _leverColliding2;
    }


    public bool GetLeverColliding3()
    {
        return _leverColliding3;
    }

    public bool GetLeverColliding4()
    {
        return _leverColliding4;
    }

    public bool GetLeverColliding5()
    {
        return _leverColliding5;
    }

    public bool GetLeverColliding6()
    {
        return _leverColliding6;
    }

    public bool GetLeverColliding7()
    {
        return _leverColliding7;
    }

    public bool GetLeverColliding8()
    {
        return _leverColliding8;
    }

    public bool GetLeverColliding9()
    {
        return _leverColliding9;
    }

    public bool GetLeverColliding10()
    {
        return _leverColliding10;
    }

    public bool GetLeverColliding11()
    {
        return _leverColliding11;
    }

    public bool GetLeverColliding12()
    {
        return _leverColliding12;
    }

    public bool GetLeverColliding13()
    {
        return _leverColliding13;
    }

    public bool GetLeverColliding14()
    {
        return _leverColliding14;
    }
}
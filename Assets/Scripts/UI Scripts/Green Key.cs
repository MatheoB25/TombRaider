using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : MonoBehaviour
{
    public GameObject _gdCollider;
    public GameObject _gd;

    public GameObject _pdCollider;
    public GameObject _pd;

    public GameObject _ydCollider;
    public GameObject _yd;

    // Start is called before the first frame update
    void Start()
    {
        _gdCollider.SetActive(false);
        _gd.SetActive(true);

        
        
        _pdCollider.SetActive(false);
        _ydCollider.SetActive(false);
        _pd.SetActive(true);
        _yd.SetActive(true);
        
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gdCollider.SetActive(true);
            _gd.SetActive(false);
            Destroy(gameObject);
        }

            if (other.gameObject.tag == "Player")
            {
                _ydCollider.SetActive(true);
                _yd.SetActive(false);
                Destroy(gameObject);
            }

            if (other.gameObject.tag == "Player")
            {
                _pdCollider.SetActive(true);
                _pd.SetActive(false);
                Destroy(gameObject);
            }
        }

    }


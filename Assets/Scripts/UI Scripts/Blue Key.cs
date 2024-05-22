using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueKey : MonoBehaviour
{
    [SerializeField] GameObject _bdCollider;
    [SerializeField] GameObject _bd;

    // Start is called before the first frame update
    void Start()
    {


        _bdCollider.SetActive(false);

        _bd.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _bdCollider.SetActive(true);
            _bd.SetActive(false);
            Destroy(gameObject);
        }
    }
}


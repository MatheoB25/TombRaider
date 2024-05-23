using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : MonoBehaviour
{
    public GameObject _gdCollider;
    public GameObject _gd;

    // Start is called before the first frame update
    void Start()
    {
        _gdCollider.SetActive(false);
        _gd.SetActive(true);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gdCollider.SetActive(true);
            _gd.SetActive(false);
            Destroy(gameObject);
        }
    }
}
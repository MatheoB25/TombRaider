using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKey : MonoBehaviour
{
    [SerializeField] GameObject _ydCollider;
    [SerializeField] GameObject _yd;

    // Start is called before the first frame update
    void Start()
    {


        _ydCollider.SetActive(false);

        _yd.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _ydCollider.SetActive(true);
            _yd.SetActive(false);
            Destroy(gameObject);
        }
    }
}
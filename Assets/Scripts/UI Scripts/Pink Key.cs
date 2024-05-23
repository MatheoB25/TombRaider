using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkKey : MonoBehaviour
{
    [SerializeField] GameObject _pdCollider;
    [SerializeField] GameObject _pd;

    // Start is called before the first frame update
    void Start()
    {


        _pdCollider.SetActive(false);

        _pd.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _pdCollider.SetActive(true);
            _pd.SetActive(false);
            Destroy(gameObject);
        }
    }
}
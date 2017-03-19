using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svängdörr1 : MonoBehaviour { 

    void Start()
    {
        transform.localPosition = new Vector3(0.53F, 0.25F, -0.174F);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    { if (other.gameObject.CompareTag("Dorr"))
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }}

//transform.localPosition = (new Vector3(0.53F, 0.25F, -0.174F));
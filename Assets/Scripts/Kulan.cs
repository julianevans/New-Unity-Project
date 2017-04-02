using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulan : MonoBehaviour {
    private Component dörr1upp;

     void Fest(string meddelande)
       {
         Debug.Log(meddelande);
      }
    // Use this for initialization
    //Svängdörr1 dörr1upp = new Svängdörr1();

    void Start() {
       //dörr1upp = GameObject.Find("Dörr1").GetComponent<Svängdörr1>();
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("svängdörrtrigger"))
                {
            GameObject.Find("Dörr1").GetComponent<Dörröppning>().enabled = true;
          //  gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * 500, ForceMode.Force);
            Fest("detta funkar");
            
                }
 
        if (other.gameObject.CompareTag("Dörr2trigger"))
       {
           GameObject.Find("Dörr2").GetComponent<Dörröppning>().enabled = true;
            Fest("dörr 2 funkar");
        }
        if (other.gameObject.CompareTag("dörr3trigger"))
        {
            GameObject.Find("Dörr3").GetComponent<Dörröppning>().enabled = true;
            Fest("dörr1upp 3 funkar också");
        }

    }
    }

// GameObject.Find("Dörr1").GetComponent<Kulan>().enabled = false; vet ej vad detta är

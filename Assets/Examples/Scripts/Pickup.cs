using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{   
    public Text scoreText;
    private int count;
     void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Pickup") 
        {
            other.gameObject.SetActive(false); 
            count += 10;
            scoreText.text = "Score: " + count;
        }
    }
}       

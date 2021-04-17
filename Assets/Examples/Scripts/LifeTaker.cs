using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTaker : MonoBehaviour
{   
    public Text livesText;
     private int lives = 3;
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Human") 
        {
            lives -= 1;
            livesText.text = "Lives: " + lives;
        }   
    }
}

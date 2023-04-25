using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySneakerOnTouch : MonoBehaviour
{

    public GameObject sneakerObject; 
    
    public string sneakerTag = "Sneaker";

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(sneakerTag))
        {
            Destroy(sneakerObject);
            Debug.Log("Game over Seeker Won!!");
        }
    }
}

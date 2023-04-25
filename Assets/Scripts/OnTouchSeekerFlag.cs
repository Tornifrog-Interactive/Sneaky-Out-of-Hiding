using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchSeekerFlag : MonoBehaviour
{
    public GameObject seekerObject;
    public string seekerFlagTag = "SeekerFlag";

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(seekerFlagTag))
        {
            Destroy(seekerObject);
            Debug.Log("Game over Sneaker Won!!");
        }
    }
}
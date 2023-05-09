using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OnTouchSeekerFlag : MonoBehaviour
{
    public GameObject seekerObject;
    public string seekerFlagTag = "SeekerFlag";

    public TextMeshProUGUI SneakersWinText;
    public TextMeshProUGUI returnMenuText;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(seekerFlagTag))
        {
            Destroy(seekerObject);
            SneakersWinText.gameObject.SetActive(true);
            returnMenuText.gameObject.SetActive(true);
            StartCoroutine(WaitForSeconds(5f)); //5 seconds for game over screen before returning to menu
        }
    }

    private IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Menu");
    }
}

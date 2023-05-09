using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DestroySneakerOnTouch : MonoBehaviour
{
    public GameObject sneakerObject;
    public string sneakerTag = "Sneaker";

    public TextMeshProUGUI SeekerWinText;
    public TextMeshProUGUI returnMenuText;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(sneakerTag))
        {
            Destroy(sneakerObject);
            SeekerWinText.gameObject.SetActive(true);
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

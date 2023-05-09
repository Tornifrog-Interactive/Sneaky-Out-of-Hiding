using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
    // Load a scene by name, used by buttons of the UI
    public string sceneName;
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

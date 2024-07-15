using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene()
    {
        // Trim any leading or trailing whitespaces
        sceneToLoad = sceneToLoad.Trim();

        // Print debug information
        Debug.Log("Loading scene: " + sceneToLoad);

        // Ensure the scene name is not empty
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Load the scene
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Invalid scene name: SceneToLoad is empty");
        }
    }



}

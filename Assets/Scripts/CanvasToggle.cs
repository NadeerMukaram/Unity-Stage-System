using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasToggle : MonoBehaviour
{
    private Canvas canvas; // Assign this in the Inspector

    private void Start()
    {
        canvas = GetComponent<Canvas>();    
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MenuStage")
        {
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }
    }
}

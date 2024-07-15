using UnityEngine;
using UnityEngine.UI;

public class StageUnlocker : MonoBehaviour
{
    public Button[] stageButtons;

    void Start()
    {

            // Load the saved stage unlock statuses and update the buttons
            for (int i = 1; i < stageButtons.Length; i++)
            {
                if (PlayerPrefs.GetInt("Stage" + (i + 1), 0) == 1)
                {
                    stageButtons[i].interactable = true;
                }
                else
                {
                    stageButtons[i].interactable = false;
                }
            }
        

    }

    // Method to unlock a specific stage
    public void UnlockStage(int stageIndex)
    {
        if (stageIndex >= 0 && stageIndex < stageButtons.Length)
        {
            stageButtons[stageIndex].interactable = true;
            PlayerPrefs.SetInt("Stage" + (stageIndex + 1), 1); // Save the unlock status
            PlayerPrefs.Save();
        }
        else
        {
            Debug.LogError("Stage index out of range");
        }
    }
}

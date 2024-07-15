using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;

public class StarUIManager : MonoBehaviour
{
    public List<Button> stageButtons;
    public GameObject starPrefab;

    private void Start()
    {
        string jsonPath = Path.Combine(Application.persistentDataPath, "playerScores.json");

        if (File.Exists(jsonPath))
        {
            string jsonString = File.ReadAllText(jsonPath);
            StarDataList starDataList = JsonUtility.FromJson<StarDataList>(jsonString);

            for (int i = 0; i < stageButtons.Count; i++)
            {
                char stageNumber;

                stageNumber = (char)('1' + i);
                SetStarsForButton(stageButtons[i], GetStarsForScene($"Stage-{stageNumber}", starDataList));
                
            }
        }
        else
        {
            Debug.LogError("JSON file not found at: " + jsonPath);
        }
    }

    private void SetStarsForButton(Button button, int starCount)
    {
        float buttonWidth = button.GetComponent<RectTransform>().rect.width;
        float spacing = 120f;

        for (int i = 0; i < starCount; i++)
        {
            GameObject star = Instantiate(starPrefab, button.transform);
            float xPos = -(starCount - 1) * 0.5f * spacing + i * spacing;
            star.transform.localPosition = new Vector3(xPos, -50, 0);
        }
    }

    private int GetStarsForScene(string sceneName, StarDataList starDataList)
    {
        foreach (StarData starData in starDataList.scores)
        {
            // Check if the sceneName matches
            if (starData.SceneName == sceneName)
            {
                return starData.Stars;
            }
        }

        return 0;
    }

}

[System.Serializable]
public class StarData
{
    public string SceneName;
    public int Stars;
}

[System.Serializable]
public class StarDataList
{
    public List<StarData> scores;
}

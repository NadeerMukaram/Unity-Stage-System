using UnityEngine;

public class StageUnlockerDemo : MonoBehaviour
{
    private StageUnlocker stageUnlocker;

    private void Start()
    {
        stageUnlocker = FindObjectOfType<StageUnlocker>();  
    }

    public void UnlockStage(int stageNumber)
    {
       stageUnlocker.UnlockStage(stageNumber); // Unlock stage 2 (index 1)
    }

}

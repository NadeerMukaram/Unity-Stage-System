using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    private static SingletonManager instance;

    private void Awake()
    {
        // Ensure there's only one instance of this script
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists in another scene, destroy this one
            Destroy(gameObject);
        }
    }

    // You can add other initialization code or variables as needed
}

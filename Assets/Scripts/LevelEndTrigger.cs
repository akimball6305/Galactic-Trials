using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndTrigger : MonoBehaviour
{
    private void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "EndMenu") // Replace 'EndMenu' with the actual final scene name
        {
            Timer.Instance.StopTimer();
            Debug.Log($"Timer stopped in scene {currentSceneName}! Final time: {Timer.Instance.elapsedTime}");
        }
    }
}

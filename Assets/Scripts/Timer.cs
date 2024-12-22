using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer Instance { get; private set; }

    [Header("Timer Settings")]
    public float elapsedTime = 0f; // Tracks the time elapsed
    private bool isRunning = true; // Tracks if the timer is active

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        // Increment the timer only if it is running
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    public void StopTimer()
    {
        isRunning = false; // Stops the timer
    }

    public void StartTimer()
    {
        isRunning = true; // Resumes the timer
    }

    public bool IsRunning()
    {
        return isRunning;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f; // Reset the elapsed time
        isRunning = true; // Ensure timer starts running again
    }
}

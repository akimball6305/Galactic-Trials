using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private bool finalTimeDisplayed = false; // To ensure final time is shown only once

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (Timer.Instance != null)
        {
            if (Timer.Instance.IsRunning())
            {
                // Update timer if it is running
                float time = Timer.Instance.elapsedTime;
                int minutes = Mathf.FloorToInt(time / 60);
                int seconds = Mathf.FloorToInt(time % 60);

                timerText.text = $"{minutes:00}:{seconds:00}";
                finalTimeDisplayed = false; // Reset this flag in case the timer restarts
            }
            else if (!finalTimeDisplayed)
            {
                // Display the final time only once when the timer stops
                float time = Timer.Instance.elapsedTime;
                int minutes = Mathf.FloorToInt(time / 60);
                int seconds = Mathf.FloorToInt(time % 60);

                timerText.text = $"Final Time: {minutes:00}:{seconds:00}";
                finalTimeDisplayed = true;
            }
        }
    }
}

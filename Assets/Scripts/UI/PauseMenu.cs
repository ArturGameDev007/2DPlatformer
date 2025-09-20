using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public static bool IsPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        _panel.SetActive(true);
        IsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        _panel.SetActive(false);
        IsPaused = false;
    }
}

using UnityEngine;

public class PauseManager : MonoBehaviour
{
    #region Properties

    public bool IsPaused { get; private set; } = false;

    #endregion

    #region Unity Lifecycle

    private void Update()
    {
        if (IsEscPressed())
        {
            TogglePause();
        }
    }

    #endregion

    #region Private Methods

    private bool IsEscPressed()
    {
        return Input.GetKeyDown(KeyCode.Escape);
    }

    private void TogglePause()
    {
        IsPaused = !IsPaused;
        Time.timeScale = IsPaused ? 0 : 1;
    }

    #endregion
}
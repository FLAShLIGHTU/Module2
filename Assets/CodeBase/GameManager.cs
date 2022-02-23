using UnityEngine;

public class GameManager : SingletonMonoBehaviur<GameManager>
{
    
    #region Variables

    private bool _isGameOver;

    #endregion


    //Debug for init to github
    //Debug for GitHub

    #region Unity Lifecycle

   // private void OnEnable()
    //{
     //   LevelManager.Instance.OnGameOver += GameOver;
    //}

    //private void OnDisable()
    //{
    //    LevelManager.Instance.OnGameOver -= GameOver;
    //}

    #endregion

    #region Private Methods

    public void GameOver()
    {
        if (_isGameOver)
        {
            return;
        }
        
        _isGameOver = true;
        Debug.Log("GG");
    }

    #endregion
}

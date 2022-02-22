using System;
public class LevelManager : SingletonMonoBehaviur<LevelManager>
{
    #region Events

    #endregion

    #region Unity Lifecycle

    private void Update()
    {
        Block[] blocks = FindObjectsOfType<Block>();

        if (blocks.Length == 0)
        {
            GameManager.Instance.GameOver();
        }
    }

    #endregion
}
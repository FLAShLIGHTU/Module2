using System;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(PlayerStatsSO), menuName = "Configs/Stats")]
public class PlayerStatsSO : ScriptableObject
{
    #region Variables

    [SerializeField] private int ScoreLableSO; 
    public int Score => ScoreLableSO;
    public event Action OnScoreUpdate;

    #endregion

    #region Public Methods

    public void AddScore(int score)
    {
        ScoreLableSO += score;
        OnScoreUpdate?.Invoke();
    }

    public void ResetScore()
    {
        ScoreLableSO = 0;
    }

    #endregion
}
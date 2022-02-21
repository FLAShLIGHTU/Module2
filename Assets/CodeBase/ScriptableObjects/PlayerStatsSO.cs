using System;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(PlayerStatsSO), menuName = "Configs/Stats")]
public class PlayerStatsSO : ScriptableObject
{
    [SerializeField] private int _playerStatsSO;

    public int Score => _playerStatsSO;
    public event Action OnScoreUpdate;

    public void AddScore(int score)
    {
        _playerStatsSO += score;
        OnScoreUpdate?.Invoke();
    }

    public void ResetScore()
    {
        _playerStatsSO = 0;
    }
}
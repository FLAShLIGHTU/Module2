using System;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    #region Variables

    public Text Points;
    public PlayerStatsSO CurrentPoints;

    #endregion

    #region Unity LifeCycle

    public void Start()
    {
        CurrentPoints.ResetScore();
    }

    #endregion

    #region Private Methods

    private void UpdateScoreLabel()
    {
        Points.text = ($"Score: {CurrentPoints.Score}");
    }
    
    
    private void OnEnable()
    {
        CurrentPoints.OnScoreUpdate += UpdateScoreLabel;
    }

    private void OnDisable()
    {
        CurrentPoints.OnScoreUpdate -= UpdateScoreLabel;
    }

    #endregion

}
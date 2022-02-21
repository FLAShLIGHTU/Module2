using System;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text Points;
    public PlayerStatsSO CurrentPoints;

    
    private void OnEnable()
    {
        CurrentPoints.OnScoreUpdate += UpdateScoreLabel;
    }

    private void OnDisable()
    {
        CurrentPoints.OnScoreUpdate -= UpdateScoreLabel;
    }


    public void Start()
    {
        CurrentPoints.ResetScore();
    }
    
    private void UpdateScoreLabel()
    {
        Points.text = ($"Score: {CurrentPoints.Score}");
    }


}
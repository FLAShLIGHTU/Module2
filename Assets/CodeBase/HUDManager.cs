using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text Points;
    public PlayerStatsSO CurrentPoints;
    private void Update()
    {
        Points.text = ($"Score {CurrentPoints._playerStatsSO}");
    }
    
}

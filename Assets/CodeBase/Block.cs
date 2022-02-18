using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public AudioClip AudioClip;

    private void OnCollisionEnter2D(Collision2D col)
    {
        AudioManager.Instance.PlayOnShot(AudioClip);
        Destroy(gameObject);
    }

}

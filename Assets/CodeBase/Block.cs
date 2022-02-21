using UnityEngine;

public class Block : MonoBehaviour
{
    #region Variables

    [Header("Render Settings")] public SpriteRenderer SpriteRenderer;
    public Sprite[] Sprite;


    [Header("Collision settings")] public int Hit;
    public AudioClip AudioClip;
    public int Points;
    public PlayerStatsSO PlayerStatsSO;

    #endregion

    #region Unity Lifecycle

    private void Start()
    {
        
        Hit = Sprite.Length;
        SpriteUpdate();
    }

    #endregion

    #region Private Methods

    private void OnCollisionEnter2D(Collision2D col)
    {
        GetHit();
    }

    private void GetHit()
    {
        Hit--;

        if (Hit <= 0)
        {
            Destroy(gameObject);
            AudioManager.Instance.PlayOnShot(AudioClip);
            PlayerStatsSO.AddScore(Points);
        }
        else
            SpriteUpdate();
    }

    private void SpriteUpdate()
    {
        SpriteRenderer.sprite = Sprite[Hit - 1];
    }

    #endregion
}
using UnityEngine;

public class Block : MonoBehaviour
{
  #region Variables
  
  [Header("Render Settings")]
  public SpriteRenderer SpriteRenderer;
  public Sprite Sprite1;
  public Sprite Sprite2;

  [Header("Collision settings")]
  public int Hit;
  public AudioClip AudioClip;
  public int Points;
  public PlayerStatsSO PlayerStatsSO;

  private int _numberHit;

  #endregion

  #region Unity Lifecycle

  private void Start()
  {
    _numberHit = 0;
  }

  #endregion

  #region Private Regions

  private void OnCollisionEnter2D(Collision2D col)
  {
    ChangeSprite();
    _numberHit++;

    if (_numberHit == Hit)
    {
      AudioManager.Instance.PlayOnShot(AudioClip);
      Destroy(gameObject);
      PlayerStatsSO._playerStatsSO += Points;
    }
  }

  private void ChangeSprite()
  {
    if (SpriteRenderer.sprite == Sprite1)
    {
      SpriteRenderer.sprite = Sprite2;
    }
  }

  #endregion
}
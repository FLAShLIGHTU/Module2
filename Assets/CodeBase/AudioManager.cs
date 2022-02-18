using UnityEngine;

public class AudioManager : MonoBehaviour
{
  #region Variables

  public AudioSource AudioSource;

  private static AudioManager _instance;

  #endregion

  #region Properies

  public static AudioManager Instance => _instance;

  #endregion

  #region Unity Lifecycle

  private void Awake()
  {
    if (_instance != null)
    {
      Destroy(gameObject);

      return;
    }

    _instance = this;
    DontDestroyOnLoad(gameObject);
  }

  #endregion

  #region Public methods

  public void PlayOnShot(AudioClip clip)
  {
    AudioSource.PlayOneShot(clip);
  }

  #endregion
}
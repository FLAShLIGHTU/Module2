using UnityEngine;

public class AudioManager : SingletonMonoBehaviur<AudioManager>
{
  #region Variables

  public AudioSource AudioSource;
  
  #endregion
  
  #region Public methods

  public void PlayOnShot(AudioClip clip)
  {
    AudioSource.PlayOneShot(clip);
  }

  #endregion
}
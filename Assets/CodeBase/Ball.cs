
using UnityEngine;


public class Ball : MonoBehaviour
{
  #region Variables

  public Rigidbody2D Rb;
  public float Speed;
  public Vector2 Direction;

  #endregion

  #region Unity Lifecycle

  private void Start()
  {
    
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      StartBall();
    }
    
    
  }

  #endregion

  #region Private methods

  private void StartBall()
  {
    Rb.velocity = Direction.normalized * Speed;
  }

  #endregion
}

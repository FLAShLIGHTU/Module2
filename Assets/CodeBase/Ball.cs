
using UnityEngine;
using UnityEngine.UIElements;


public class Ball : MonoBehaviour
{
  #region Variables

  public Rigidbody2D Rb;
  public float Speed;
  public Vector2 Direction;

  public Transform PadTransform;
  public float YOffsetFromPad;

  private bool _isStarted;

  #endregion

  #region Unity Lifecycle

  private void Start()
  {
    
  }

  private void Update()
  {
    if (_isStarted)
    {
      return;
    }

    MoveBallWithaPad();
    
    if (Input.GetMouseButtonDown(0))
    {
      StartBall();
    }


  }
  
  private void OnDrawGizmos()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawRay(transform.position, Direction );
  }

  #endregion

  #region Private methods

  private void MoveBallWithaPad()
  {
    Vector3 currentPosition = PadTransform.position;
    currentPosition.y += YOffsetFromPad;
    transform.position = currentPosition;
  }

  private void StartBall()
  {
    Rb.velocity = Direction.normalized * Speed;
    _isStarted = true;
  }

  #endregion
}

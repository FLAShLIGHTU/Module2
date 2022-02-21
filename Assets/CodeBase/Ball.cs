using UnityEngine;


public class Ball : MonoBehaviour
{
    #region Variables

    [Header("Base Settings")] 
    public Rigidbody2D Rb;
    public float Speed;
    

    [Header("Pad Settings")] 
    public Transform PadTransform;
    public float YOffsetFromPad;

    [Header("Audio")]
    public AudioSource AudioSource;

    [Header("Random range")]
    public int XMin;
    public int XMax;
    public int YMin;
    public int YMax;

    private bool _isStarted;
    private Vector2 _direction;

    #endregion

    #region Unity Lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.Play();
    }

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
        Gizmos.DrawRay(transform.position, _direction);
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
        _direction.x = Random.Range(XMin, XMax);
        _direction.y = Random.Range(YMin, YMax);

        Rb.velocity = _direction.normalized * Speed;
        _isStarted = true;
    }

    #endregion
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Ball : MonoBehaviour
{
  public Rigidbody2D Rb;
  public float Speed;
  public Vector2 Direction;

  [Header("Debug")]
  public Vector2 DirectionNormolized;
  public float Velocity;
  
  private void Start()
  {
    DirectionNormolized = Direction.normalized;
    Rb.velocity = Direction.normalized * Speed;
  }

  private void Update()
  {
    Velocity = Rb.velocity.magnitude;
    //Rb.velocity = new Vector2(x:0, y:10);
  }
  
}

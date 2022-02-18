using UnityEngine;
using UnityEngine.UIElements;

public class Pad : MonoBehaviour
{
    #region Unity Lifecycle

    

    #endregion
    void Start()
    {
        
    }

     
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 currentPosition = transform.position;
        currentPosition.x = worldPosition.x;
        transform.position = currentPosition;
    }
}
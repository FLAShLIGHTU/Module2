using UnityEngine;


public class Pad : MonoBehaviour
{
    #region Variables

    public float range;

    #endregion

    #region Unity Lifecycle

    #endregion

    void Update()
    {
        MouseMoove();
    }

    private void MouseMoove()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(worldPosition.x, -range, range);
        transform.position = currentPosition;
    }
}
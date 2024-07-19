using UnityEngine;

public class CameraFollowCursor : MonoBehaviour
{
    public Camera cameraToMove;
    public GameObject planeToMove;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Distance from the camera

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        // Move the camera
        cameraToMove.transform.position = new Vector3(worldPosition.x, worldPosition.y, cameraToMove.transform.position.z);
        
        // Move the plane
        planeToMove.transform.position = new Vector3(worldPosition.x, worldPosition.y, planeToMove.transform.position.z);
    }
}

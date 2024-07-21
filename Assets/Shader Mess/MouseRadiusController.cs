using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Using TextMeshPro

public class CameraFollowCursor : MonoBehaviour
{
    public Camera cameraToMove;
    public GameObject planeToMove;
    private bool toggle = false;
    public GameObject Flashlight;

    public float batteryLife = 100f; // Initial battery life
    public float drainRate = 10f; // Battery drain rate per second
    private bool isFlashlightOn = false;
    public TextMeshProUGUI batteryLifeText; // TextMeshProUGUI to display battery life
    public TextMeshProUGUI gameOverText; // TextMeshProUGUI to display game over message

    void Start()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false); // Hide game over text at the start
        }
    }

    void Update()
    {
        if (batteryLife > 0)
        {
            HandleFlashlightToggle();
            if (toggle)
            {
                DrainBattery();
                FollowCursor();
            }
        }
        UpdateBatteryLifeUI();
    }

    void HandleFlashlightToggle()
    {
        if (Input.GetMouseButtonDown(1) && !Flashlight.activeSelf)
        {
            toggle = !toggle;
            planeToMove.SetActive(toggle);
        }
    }

    void DrainBattery()
    {
        if (batteryLife > 0)
        {
            batteryLife -= drainRate * Time.deltaTime;
            if (batteryLife <= 0)
            {
                batteryLife = 0;
                toggle = false;
                planeToMove.SetActive(toggle);
                ShowGameOver();
            }
        }
    }

    void FollowCursor()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 50f; // Distance from the camera

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Move the camera
        cameraToMove.transform.position = new Vector3(worldPosition.x, worldPosition.y, cameraToMove.transform.position.z);

        // Move the plane
        planeToMove.transform.position = new Vector3(worldPosition.x, worldPosition.y, planeToMove.transform.position.z);
    }

    void UpdateBatteryLifeUI()
    {
        if (batteryLifeText != null)
        {
            batteryLifeText.text = "Battery Life: " + Mathf.Ceil(batteryLife).ToString() + "%";
        }
    }

    void ShowGameOver()
    {
        if (gameOverText != null)
        {
            batteryLifeText.gameObject.SetActive(false);
            // gameOverText.gameObject.SetActive(true);
            // gameOverText.text = "Game Over";

            GameManager.LoadEndScene(false);
        }
    }
}

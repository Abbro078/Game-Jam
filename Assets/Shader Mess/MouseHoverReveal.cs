// using UnityEngine;

// public class MouseColorReveal : MonoBehaviour
// {
//     public Material defaultMaterial;
//     public Material highlightMaterial;
//     public float radius = 0.1f;

//     private Renderer objRenderer;
//     private Camera mainCamera;

//     private void Start()
//     {
//         objRenderer = GetComponent<Renderer>();
//         mainCamera = Camera.main;
//         if (objRenderer != null)
//         {
//             defaultMaterial = objRenderer.material; // Store the initial material
//         }
//     }

//     void Update()
//     {
//         // Get mouse position in screen space and convert it to world space
//         Vector3 mousePos = Input.mousePosition;
//         Ray ray = mainCamera.ScreenPointToRay(mousePos);
//         RaycastHit hit;

//         if (Physics.Raycast(ray, out hit))
//         {
//             // Calculate the distance between the mouse position and the object
//             float distance = Vector3.Distance(hit.point, transform.position);

//             // Change the material if within the radius, otherwise revert to default material
//             if (distance <= radius)
//             {
//                 objRenderer.material = highlightMaterial;
//             }
//             else
//             {
//                 objRenderer.material = defaultMaterial;
//             }
//         }
//     }
// }

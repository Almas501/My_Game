using UnityEngine;

public class ItemDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Rigidbody rb;
    private Camera mainCamera;
    private Vector3 offset;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isDragging)
        {
            // Convert mouse position to world space
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.transform.position.y - transform.position.y));

            // Update object's position
            rb.MovePosition(mousePos + offset);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        rb.isKinematic = true;

        // Calculate offset between object's position and mouse position
        offset = transform.position - mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.transform.position.y - transform.position.y));
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false;
    }
}

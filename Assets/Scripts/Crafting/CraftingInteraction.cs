using UnityEngine;

public class CraftingInteraction : MonoBehaviour
{
    public GameObject woodObject; // Reference to the Wood GameObject
    public GameObject stoneObject; // Reference to the Stone GameObject
    public GameObject firePrefab; // Prefab for the fire interaction
    public float interactionDistance = 1f; // Distance threshold for interaction

    void Update()
    {
        // Check if both wood and stone objects exist and are close enough for interaction
        if (woodObject != null && stoneObject != null && Vector3.Distance(woodObject.transform.position, stoneObject.transform.position) < interactionDistance)
        {
            // Instantiate the fire prefab at the midpoint between wood and stone
            Vector3 midpoint = (woodObject.transform.position + stoneObject.transform.position) / 2f;
            Instantiate(firePrefab, midpoint, Quaternion.identity);
            Debug.Log("Fire created!");

            // Optionally, you can destroy the wood and stone objects after interaction
            Destroy(woodObject);
            Destroy(stoneObject);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

namespace SimpleInventory
{
    public class SwordCounter : MonoBehaviour
    {
        [SerializeField] private Inventory inventory;

        [Header("Scene to Load")]
        [SerializeField] private string sceneToLoadName;

        [Header("Sword Tag")]
        [SerializeField] private string swordTag = "Weapon";

        // Update is called once per frame
        void Update()
        {
            // Check if the inventory has 8 or more swords
            int swordCount = 0;
            foreach (var item in inventory.GetInventory)
            {
                // Check if the item's prefab has the "Sword" tag
                if (item.Key.Prefab != null && item.Key.Prefab.CompareTag(swordTag))
                {
                    swordCount += item.Value;
                }
            }

            if (swordCount >= 8)
            {
                // Load the specified scene by name
                SceneManager.LoadScene(sceneToLoadName);
            }
        }
    }
}

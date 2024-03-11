using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wp;
    //public GameObject hitParticle;

    private int collisionCount = 0; // Counter to keep track of the number of collisions

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && wp.isAttacking)
        {
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");
            //Instantiate(hitParticle, other.transform.position, other.transform.rotation);

            // Increase the collision count
            collisionCount++;

            // Check if 5 collisions have occurred
            if (collisionCount >= 5)
            {
                // Destroy the enemy GameObject
                Destroy(other.gameObject);

                // Reset the collision count for future collisions
                collisionCount = 0;
            }
        }
    }
}

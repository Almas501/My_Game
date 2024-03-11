using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{
    Animator animator;
    Transform player;
    float waveFreq = 60f;
    float cooldown = 0;
    const float WAVE_DIST = 10f;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = FindObjectOfType<PointAndClickMover>().transform;
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < WAVE_DIST)
        {
            // Check if waving animation is not already playing
            if (!animator.GetBool("isWaving"))
            {
                animator.SetBool("isWaving", true);
                Wave();
            }
        }
        else
        {
            animator.SetBool("isWaving", false);
        }

        transform.LookAt(player);

        if (cooldown > 0)
            cooldown -= Time.deltaTime;
    }

    private void Wave()
    {
        if (cooldown > 0)
            return;

        cooldown = waveFreq;
        // Trigger waving animation if needed
        // Uncomment the following line if you want to trigger a waving animation
        // animator.SetTrigger("Wave");
    }
}

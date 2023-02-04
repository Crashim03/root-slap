using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{

    private bool can_kill = false;
    private GameObject enemy;

    public void KillEnemy()
    {
        if(can_kill)
        {
            Destroy(enemy);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        can_kill = true;
        enemy = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other) {
        can_kill = false;
    }
}
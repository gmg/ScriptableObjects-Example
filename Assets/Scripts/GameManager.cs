using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerHealth playerHealth;
    
    void Start()
    {
        playerHealth = FindAnyObjectByType(typeof(PlayerHealth)).GetComponent<PlayerHealth>();
        playerHealth.OnHealthDepleted += PlayerDied;
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthDepleted -= PlayerDied;
    }

    private void PlayerDied()
    {
        Debug.Log("Player Died");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Update()
    {
        PlayerIsDrowned();
    }

    void PlayerIsDrowned()
    {
        if (player.transform.position.y <= -2.0f)
        {
            if (CollisionManager.instance.lastTouchedBoost != null)
            {
                CollisionManager.instance.FinishedOnBoost();
            }
            else
            {
                UIController.instance.RestartLevel();
            }
        }
    }
}

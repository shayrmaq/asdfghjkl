using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEmter(Collider other) 
    {
        Player player = other.GetComponent <Player>();
        player.CollectCoins();
        Destroy(gameObject);
    }
}
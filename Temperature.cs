using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
        public Health health;
        public int playerDamage = 1;
        public float temperatureCurrent = 36.8f;
        public float temperatureNormal = 36.8f;
    public float temperatureCritical = 35.8f;
        public float freezeSpeed = 0.15f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 3;
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                health.TakeDamage(playerDamage);
            }
        }
    }
}

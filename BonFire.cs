using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonFire : MonoBehaviour
{
    public float lifeTime = 5;
        public float heatpower = 0.5f;
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Temperature>() != null)
        {
            Temperature temperature = other.GetComponent<Temperature>();
            if (temperature.temperatureCurrent < temperature.temperatureNormal)
            {
                temperature.temperatureCurrent += heatpower * Time.deltaTime;
            }
        }
    }
}

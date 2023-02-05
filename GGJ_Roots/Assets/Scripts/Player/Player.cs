using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour     // gradient?
{
    public int maxWater = 100;
    public int currentWater;
    
    public WaterGauge waterGauge;

    // Start is called before the first frame update
    void Start()
    {
        currentWater = maxWater;
        waterGauge.SetMaxHealth(maxWater);
    }

    public void TakeDamage(int damage)
    {
        currentWater -= damage;

        waterGauge.SetHealth(currentWater);
    }

}

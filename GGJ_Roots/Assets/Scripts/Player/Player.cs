using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour     // gradient?
{
    public int maxWater = 100;
    public int currentWater;
    
    public WaterGauge waterGauge;

    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentWater = maxWater;
        waterGauge.SetMaxHealth(maxWater);
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= 1f)
        {
            Debug.Log("test");
            TakeDamage(1);
            time = 0f;
        }
    }

    public void TakeDamage(int damage)
    {
        currentWater -= damage;

        waterGauge.SetHealth(currentWater);
    }

    public void GetWater()
    {
        currentWater -= 10;
        waterGauge.SetHealth(currentWater);
    }

}

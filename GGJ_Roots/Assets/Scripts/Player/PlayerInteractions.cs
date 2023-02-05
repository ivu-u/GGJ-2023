using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
    }

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape)) 
    //    { 

    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collider)  // lazy coding so implement different damage here
    {
        if(collider.gameObject.tag == "Enemy")
        {
            player.TakeDamage(20);
            FindObjectOfType<AudioManager>().Play("RootHit");
            collider.GetComponent<ParticleSystem>().Play();

            StartCoroutine(waiter(collider.gameObject));
        }
        else if(collider.gameObject.tag == "Water")
        {
            player.GetWater();
            StartCoroutine(waiter(collider.gameObject));
        }
        else if(collider.gameObject.tag == "Murderbox")
        {
            player.TakeDamage(150);
        }
    }

    IEnumerator waiter(GameObject c)
    {
        yield return new WaitForSeconds((float).2);
        Destroy(c);
    }
}

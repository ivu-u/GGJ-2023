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



    private void OnTriggerEnter2D(Collider2D collider)  // lazy coding so implement different damage here
    {
        if(collider.gameObject.tag == "Enemy")
        {
            player.TakeDamage(20);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murderbox : MonoBehaviour
{
    private GameObject character;
    private Player player;
    // Start is called before the first frame update
    void Awake()
    {
        character = GameObject.Find("Player");
        player = character.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        player.TakeDamage(150);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Vector2 DeadZone;
    
    public Rigidbody2D player;
    private Vector2 pSpawn;

    // Start is called before the first frame update
    void Start()
    {
        DeadZone.y = -10f; //How Low can you go before you should die

        pSpawn = new Vector2(0, 0); // Where the player should spawn
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < DeadZone.y) { //! if too low
            player.transform.position = pSpawn;         //! die lol
            Debug.Log("Player Fell To Below -10 y");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetectorScript : MonoBehaviour
{
    GameObject player;
    bool waiting = false;
    double time = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (waiting)
        {
            time += Time.deltaTime;

            if (time >= 0.1)
            {
                time = 0;
                waiting = false;
                player.GetComponent<PlayerControl>().grounded = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name != "Player")
        {
            player.GetComponent<PlayerControl>().grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name != "Player")
        {
            waiting = true;
        }
    }
}

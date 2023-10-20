using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerObject;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, 0, -10);
        transform.position = newPosition;
    }
}

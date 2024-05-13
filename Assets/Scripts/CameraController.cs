using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float cameraSpeed;
    private Vector3 playerPosition;

    private void Update()
    {
        if (player.gameObject != null)
        {
            playerPosition.Set(player.transform.position.x, player.transform.position.y, this.transform.position.z);

            this.transform.position = playerPosition = Vector3.Lerp(this.transform.position, playerPosition, cameraSpeed * Time.deltaTime);
        }
    }
}

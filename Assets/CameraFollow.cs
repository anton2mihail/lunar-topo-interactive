using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    private Vector3 offset = new Vector3(-5, 1, -5);

    private void Update()
    {
        transform.position = player.position + offset;
    }
}

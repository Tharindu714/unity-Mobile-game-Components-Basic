using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderTeleport : MonoBehaviour
{
    public Transform[] teleportPoints; // Set teleport points in Inspector
    public GameObject player;
    public float teleportInterval = 8f;

    private bool isPlayerWalking = false;
    private float timer;

    void Update()
    {
        // Detect if player is walking (e.g., holding W)
        isPlayerWalking = Input.GetKey(KeyCode.W);

        if (isPlayerWalking)
        {
            timer += Time.deltaTime;
            if (timer >= teleportInterval)
            {
                Teleport();
                timer = 0f;
            }
        }
    }

    void Teleport()
    {
        if (teleportPoints == null || teleportPoints.Length == 0)
        {
            Debug.LogError("Teleport points not assigned or empty!");
            return;
        }

        int index = Random.Range(0, teleportPoints.Length); // Correct
        transform.position = teleportPoints[index].position;
        // Optional: play disappear/reappear effect here
    }
}

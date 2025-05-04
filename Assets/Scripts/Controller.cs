using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 2f; // You can tweak this in Inspector
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector3(0, 0, -1); // This was incorrectly moving right
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector3(1, 0, 0); // This was incorrectly moving backward
        }

        transform.position += direction.normalized * moveSpeed * Time.deltaTime;
    }
}
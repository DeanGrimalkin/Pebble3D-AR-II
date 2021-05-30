using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.E))
            transform.position += -Vector3.up * moveSpeed * Time.deltaTime;
    }
}

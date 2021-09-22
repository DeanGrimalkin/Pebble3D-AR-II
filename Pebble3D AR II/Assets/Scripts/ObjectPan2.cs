using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPan2 : MonoBehaviour
{

    private Touch touch;
    private float speedModifier;
    private bool isPanning;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.0007f;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier);
            }

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3), Mathf.Clamp(transform.position.y, -10, 10), Mathf.Clamp(transform.position.z, -3, 3));
        }
    }
}

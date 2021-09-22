using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPan : MonoBehaviour
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

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y + touch.deltaPosition.y * speedModifier,
                    transform.position.z);
            }

                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -0.5f, 0.5f), Mathf.Clamp(transform.position.y, -0.5f, 0.5f), 0);
        }
    }
}

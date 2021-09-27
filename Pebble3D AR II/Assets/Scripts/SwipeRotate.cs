using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeRotate: MonoBehaviour
{
    private Touch Touch;

    private Vector2 touchPosition;

    private Quaternion rotationY;

    private float rotateSpeed = 0.2f;

    private void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch = Input.GetTouch(0);

            if(Touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(
                    0f, - Touch.deltaPosition.x * rotateSpeed, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }
    }

    public bool IsPointerOverUI(int fingerId)
    {
        EventSystem eventSystem = EventSystem.current;
        return (eventSystem.IsPointerOverGameObject(fingerId)
            && eventSystem.currentSelectedGameObject != null);
    }
}

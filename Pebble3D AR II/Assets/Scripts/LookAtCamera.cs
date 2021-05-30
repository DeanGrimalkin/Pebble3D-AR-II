using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera theCam;

    private void Start()
    {
        theCam = Camera.main;
    }
    void Update()
    {
        //transform.rotation = theCam.transform.rotation;

        //transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);

        transform.LookAt(theCam.transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescanButtonScript : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject rescanButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel1.activeSelf == true)
        {
            rescanButton.SetActive(true);
        }

        else
        {
            rescanButton.SetActive(false);
        }
    }
}

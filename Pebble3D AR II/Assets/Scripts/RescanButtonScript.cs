using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescanButtonScript : MonoBehaviour
{
    public GameObject Panel1;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel1.activeSelf == true)
        {
            this.gameObject.SetActive(true);
        }

        else
        {
            this.gameObject.SetActive(false);
        }
    }
}

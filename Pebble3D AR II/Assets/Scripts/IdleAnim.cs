using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnim : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void S3True()
    {
        anim.SetBool("S3Bool", true);
    }

    public void S3False()
    {
        anim.SetBool("S3Bool", false);
    }

}

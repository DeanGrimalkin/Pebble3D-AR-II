using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompAnim : MonoBehaviour
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

    public void GoS5Top()
    {
        anim.SetBool("S5Top", true);
    }

    public void BackS5Top()
    {
        anim.SetBool("S5Top", false);
    }

    public void PlayS3PrintHead()
    {
        anim.SetBool("S3PrintHead", true);
    }

    public void StopS3PrintHead()
    {
        anim.SetBool("S3PrintHead", false);
    }

    public void PlayS3PrintCore()
    {
        anim.SetBool("S3PrintCore", true);
    }

    public void StopS3PrintCore()
    {
        anim.SetBool("S3PrintCore", false);
    }

    public void PlayThermocoupleBool()
    {
        anim.SetBool("Thermocouple", true);
    }

    public void StopThermocoupleBool()
    {
        anim.SetBool("Thermocouple", false);
    }

    public void PlayHotEndBool()
    {
        anim.SetBool("HotEnd", true);
    }

    public void StopHotEndBool()
    {
        anim.SetBool("HotEnd", false);
    }

    public void PlayRibbonCableBool()
    {
        anim.SetBool("RibbonCable", true);
    }

    public void StopRibbonCableBool()
    {
        anim.SetBool("RibbonCable", false);
    }
}

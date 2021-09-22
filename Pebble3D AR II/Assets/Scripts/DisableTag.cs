using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class DisableTag : MonoBehaviour
{
    public void DisableVideos()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Video");

        foreach (GameObject videoArray in gameObjectArray)
        {
            videoArray.SetActive(false);
        }
    }

    public void DisableErrorCodePanels()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("ErrorCodePanel");

        foreach (GameObject panelArray in gameObjectArray)
        {
            panelArray.SetActive(false);
        }
    }

}

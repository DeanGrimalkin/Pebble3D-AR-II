using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineManager : MonoBehaviour
{
    private PlayableDirector PDVar;
    public void StopPlayableDirector()
    {
        PlayableDirector[] gameObjectArray = GameObject.FindGameObjectsWithTag("Timeline").GetComponentInChildren<PlayableDirector>();
        PDVar = GetComponent<PlayableDirector>();

    }

}z
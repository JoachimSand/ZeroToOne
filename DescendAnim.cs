using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendAnim : MonoBehaviour
{
    public Transform transform;
    public Vector3 start = new Vector3(0, 5, 0);
    static Vector3 end;
    float animStartTime, animEndTime;
    public float animation_duration = 5;

    // Start is called before the first frame update
    void OnEnable()
    {
        /*
        transform = GetComponent<Transform>();
        animStartTime = Time.time;
        animEndTime = animStartTime + animation_duration;
        end = transform.position;
        Debug.Log("End position: " + end.ToString());
        transform.position = transform.position + start;
        Debug.Log("Start position: " + transform.position.ToString());
        */
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(end, start, (animEndTime - Time.time) / (animation_duration));
        //transform.position = end;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Transform transform;

    public List<GameObject> animated_gameobjects = new List<GameObject>();
    public List<Transform> og_transforms = new List<Transform>();

    int child_count = 0;
    int next_child = 0;

    float time_last_anim = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetAxis("Horizontal2") > 0.5f  && next_child < animated_gameobjects.Count && Time.time > time_last_anim + 0.5f)
        {
            animated_gameobjects[next_child].SetActive(true);
            next_child = next_child + 1;
            time_last_anim = Time.time;
            
        }

    }
}
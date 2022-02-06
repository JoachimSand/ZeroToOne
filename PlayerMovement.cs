using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 20f;

    void Update()
    {
        transform.Rotate((Input.GetAxis("Vertical") * speed * Time.deltaTime), 
                        (Input.GetAxis("Horizontal") * speed * Time.deltaTime), 0,
                        Space.World);
    }
}

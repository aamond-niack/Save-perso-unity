using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{

    [SerializeField]
    private float speed = 4f, rot = 80f, curSpeed;

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftControl))
        {
            curSpeed = speed * 2;
        }
        else
        {
            curSpeed = speed;
        }
        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tag")
        {
            GetComponent<Animator>().enabled = true;

        }
    }
}

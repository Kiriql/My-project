using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    public Animator anim;
    public GameObject ingrid;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

            }
        }
    }
}

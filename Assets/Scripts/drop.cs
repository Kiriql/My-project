using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    vari v = new vari();
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Character")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                v.currentIng.SetActive(false);
                v.currentIng = null;
            }

        }
    }
}

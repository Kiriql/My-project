using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    vari v = new vari();
    public GameObject ingrid;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(v.fullArm == false)
                {
                    v.currentIng = ingrid;
                    v.currentIng.SetActive(true);
                    v.fullArm = true;
                }
            }
            
        }
    }
    
}

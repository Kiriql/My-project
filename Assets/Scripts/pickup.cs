using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private vari v;
    public GameObject ingrid;
    public Animator anim;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("body");
        anim = player.GetComponent<Animator>();
        player = GameObject.Find("Player");
        v = player.GetComponent<vari>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {   
                anim.ResetTrigger("PickUp");
                if(!v.fullArm)
                {
                    anim.SetTrigger("PickUp");
                    v.currentIng = ingrid;
                    v.currentIng.SetActive(true);
                    v.fullArm = true;
                }
            }
            
        }
    }
    
}

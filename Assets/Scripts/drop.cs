using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    [SerializeField] private vari v;
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
        if(other.gameObject.name == "Character")
        {
            anim.ResetTrigger("PickUp");
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("PickUp");
                if(v.currentIng != null)
                {
                    v.currentIng.SetActive(false);
                    v.fullArm = false;
                    v.currentIng = null;
                }
            }

        }
    }
}

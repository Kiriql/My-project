using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private vari v;
    public GameObject ingrid;
    public Animator anim;
    GameObject player;
    int i = 0;
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
                    if (v.currentIng.name == "Pot")
                    {
                        if (i == 0)
                        {
                            v.ChangeText();
                        }
                        v.Pot.SetActive(false);
                    }
                    v.currentIng.SetActive(true);
                    v.fullArm = true;
                }
                else if (v.currentIng.name == "Pot")
                {
                    anim.SetTrigger("PickUp");
                    if (i == 0)
                    {
                        v.ChangeText();
                        i++;
                    }
                    v.Pot.SetActive(true);
                    v.currentIng.SetActive(false);
                    v.fullArm = false;
                    v.currentIng = null;
                }
            }
            
        }
    }
    
}

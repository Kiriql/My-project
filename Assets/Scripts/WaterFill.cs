using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFill : MonoBehaviour
{
    [SerializeField] private vari v;
    public Animator anim;
    int i = 0;
    GameObject player;

    public GameObject waterInHand;
    public GameObject waterInPot;

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
                if (v.currentIng.name == "Pot")
                {
                    anim.SetTrigger("PickUp");
                    if (i == 0)
                    {
                        i++;
                        v.ChangeText();
                    }
                    waterInHand.SetActive(true);
                    waterInPot.SetActive(true);
                }
            }

        }
    }

}

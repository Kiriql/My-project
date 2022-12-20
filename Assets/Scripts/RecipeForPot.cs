using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecipeForPot : MonoBehaviour
{
    [SerializeField] private vari v;
    public Animator anim;
    GameObject player;
    public GameObject water;
    public int count;
    public GameObject TimeLine;
    public TMP_Text countPot;

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
            if (Input.GetKeyDown(KeyCode.F))
            {
                anim.ResetTrigger("PickUp");
                if (v.fullArm & water.activeSelf & count < 2)
                {
                    anim.SetTrigger("PickUp");
                    v.currentIng.SetActive(false);
                    v.fullArm = false;
                    v.CheckRecipe += v.currentIng.name;
                    v.currentIng = null;
                    count += 1;
                    countPot.text = count.ToString() + " / 2";
                    if (count == 2)
                    {
                        TimeLine.SetActive(true);
                    }
                    
                }
            }

        }
    }

}

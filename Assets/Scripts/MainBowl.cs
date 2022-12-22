using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class MainBowl : MonoBehaviour
{
    [SerializeField] private vari v;
    public Animator anim;
    GameObject player;
    public int count = 0;
    public int count2 = 0;
    public GameObject TimeLineBowl;
    public TMP_Text countBowl;
    public GameObject water;
    public GameObject waterInHand;
    public GameObject kvas;

    public GameObject galochka;

    public GameObject step1;
    public GameObject step2;
    public GameObject step3;

    public GameObject win;
    public GameObject lose;

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
                if (v.fullArm & count < 3 & v.currentIng.name == "Pot" & water.activeSelf)
                {
                    anim.SetTrigger("PickUp");
                    step1.SetActive(true);
                    v.ChangeText();
                    water.SetActive(false);
                    waterInHand.SetActive(false);
                    //v.fullArm = false;
                    v.CheckRecipe += v.currentIng.name;
                    //v.currentIng = null;
                    count += 1;
                    countBowl.text = count.ToString() + " / 3";
                    if (count == 3)
                    {
                        TimeLineBowl.SetActive(true);
                     
                    }
                }
                else if (v.fullArm & count < 3 & v.currentIng.name != "Pot")
                {
                    anim.SetTrigger("PickUp");
                    v.ChangeText();
                    v.currentIng.SetActive(false);
                    v.fullArm = false;
                    v.CheckRecipe += v.currentIng.name;
                    v.currentIng = null;
                    count += 1;
                    countBowl.text = count.ToString() + " / 3";
                    if (count == 3)
                    {
                        TimeLineBowl.SetActive(true);

                    }
                }
                else if(v.fullArm & count2 < 2 & v.currentIng.name == "Pot" & water.activeSelf)
                {
                    TimeLineBowl.SetActive(false);
                    v.ChangeText();
                    anim.SetTrigger("PickUp");
                    water.SetActive(false);
                    waterInHand.SetActive(false);
                    //v.fullArm = false;
                    v.CheckRecipe += "Water";
                    //v.currentIng = null;
                    count2 += 1;
                    countBowl.text = count2.ToString() + " / 2";
                    if (count2 == 2)
                    {
                        countBowl.text = "Готово!";
                        galochka.SetActive(false);
                        step3.SetActive(true);
                    }
                }
                else if(v.fullArm & count2 < 2 & v.currentIng.name != "Pot")
                {
                    TimeLineBowl.SetActive(false);
                    anim.SetTrigger("PickUp");
                    v.ChangeText();
                    v.currentIng.SetActive(false);
                    v.fullArm = false;
                    v.CheckRecipe += v.currentIng.name;
                    v.currentIng = null;
                    count2 += 1;
                    countBowl.text = count2.ToString() + " / 2";
                    if (count2 == 2)
                    {
                        countBowl.text = "Готово!";
                        galochka.SetActive(false);
                        step3.SetActive(true);
                    }
                }
            }
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (countBowl.text == "Готово!" & !v.fullArm)
                {
                    v.CheckResult();
                    kvas.SetActive(true);
                    if (v.Result)
                    {
                        win.SetActive(true);
                    }
                    else
                    {
                        lose.SetActive(true);
                    }
                }
            }

        }
    }

}

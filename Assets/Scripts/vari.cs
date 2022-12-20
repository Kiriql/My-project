using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vari : MonoBehaviour
{
    public bool fullArm = false;
    public GameObject currentIng;
    public GameObject Pot;
    public string Recipe = "SolodLemon_kislotaPotTrueSugarDrojiTrueWaterTrueSugar";
    public string CheckRecipe = "";
    public bool PotCheck = false;
    public GameObject galochkaPot;
    public bool Result = false;

    public GameObject recipeObj;
    public GameObject timer;
    public GameObject escMenu;

    void Start()
    {
        Pot = GameObject.Find("PotOnScene");
        timer.SetActive(false);
    }

    public void CheckResult()
    {
        if (CheckRecipe == Recipe)
        {
            Result = true;
        }
        else
        {
            Result = false;
        }
    }

    public void RecipeOpen()
    {
        recipeObj.SetActive(true);
    }

    public void RecipeClose()
    {
        recipeObj.SetActive(false);
        timer.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escMenu.SetActive(true);
        }
    }

    public void prodoljit()
    {
        escMenu.SetActive(false);
    }

    public void goToMenu()
    {
        Application.LoadLevel("Menu");
    }
}

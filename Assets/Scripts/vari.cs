using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vari : MonoBehaviour
{
    public bool fullArm = false;
    public GameObject currentIng;
    public GameObject Pot;
    public string Recipe = "SolodLemon_kislotaPotSugarDrojiWaterSugar";
    public string CheckRecipe = "";
    public bool Result = false;

    public string[] tips;
    public int indx = 0;
    public TMP_Text tipsTxt;

    public GameObject recipeObj;
    public GameObject timer;
    public GameObject escMenu;

    void Start()
    {
        Pot = GameObject.Find("PotOnScene");
        timer.SetActive(false);
        tips[0] = "";
        tips[1] = "Налейте в неё воды (подойдите к раковине и нажмите Е)";
        tips[2] = "Поставьте кастрюлю на плиту";
        tips[3] = "Добавьте в кастрюлю солод (возьмите солод, подойдите к кастрюле и нажмите F, чтобы положить его)";
        tips[4] = "Таким же образом добавьте лимонную кислоту (помните: если вы взяли не тот ингридиент, вы всегда можете выбросить его в мусорное ведро, нажав Е)";
        tips[5] = "Дождитесь окончания таймера";
        tips[6] = "Отлично! Теперь возьмите кастрюлю и вылейте содержимое в большую миску (взять - Е, вылить - F)";
        tips[7] = "Поставьте кастрюлю обратно. Добавьте в миску сахар";
        tips[8] = "Теперь добавьте дрожжи";
        tips[9] = "Дождитесь окончания процесса брожения";
        tips[10] = "Теперь добавьте в миску воду (налейте её в кастрюлю, и, нажав F, вылейте её в миску)";
        tips[11] = "Добавьте сахар";
        tips[12] = "Готово! Если вы соблюдали рецепт, то у вас получится квас! Проверьте свой результат - нажмите рядом с миской Е";
    }
    
    public void ChangeText()
    {
        indx++;
        tipsTxt.text = tips[indx];
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

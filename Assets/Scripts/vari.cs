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
        tips[1] = "������� � �� ���� (��������� � �������� � ������� �)";
        tips[2] = "��������� �������� �� �����";
        tips[3] = "�������� � �������� ����� (�������� �����, ��������� � �������� � ������� F, ����� �������� ���)";
        tips[4] = "����� �� ������� �������� �������� ������� (�������: ���� �� ����� �� ��� ����������, �� ������ ������ ��������� ��� � �������� �����, ����� �)";
        tips[5] = "��������� ��������� �������";
        tips[6] = "�������! ������ �������� �������� � ������� ���������� � ������� ����� (����� - �, ������ - F)";
        tips[7] = "��������� �������� �������. �������� � ����� �����";
        tips[8] = "������ �������� ������";
        tips[9] = "��������� ��������� �������� ��������";
        tips[10] = "������ �������� � ����� ���� (������� � � ��������, �, ����� F, ������� � � �����)";
        tips[11] = "�������� �����";
        tips[12] = "������! ���� �� ��������� ������, �� � ��� ��������� ����! ��������� ���� ��������� - ������� ����� � ������ �";
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

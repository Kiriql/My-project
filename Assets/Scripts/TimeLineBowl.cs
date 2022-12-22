using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeLineBowl: MonoBehaviour
{
    Image timerBar;
    public Image image;
    public float maTime = 20f;
    [SerializeField] private vari v;
    GameObject player;
    int i = 0;
    public float timeLeft;
    public GameObject galochka;
    public GameObject step2;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
        player = GameObject.Find("Player");
        v = player.GetComponent<vari>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
        }
        else
        {
            image.color = Color.clear;
            if (i == 0)
            {
                i++;
                v.ChangeText();
            }
            timerBar.color = Color.clear;
            galochka.SetActive(true);
            step2.SetActive(true);
            text.text = "0 / 2";
        }

        if (timeLeft <= 10 & timeLeft >= 5)
        {
            timerBar.color = Color.yellow;
        }

        if (timeLeft <= 5 & timeLeft >= 0)
        {
            timerBar.color = Color.red;
        }

    }
}

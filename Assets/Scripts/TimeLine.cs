using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLine : MonoBehaviour
{
    Image timerBar;
    public Image image;
    public float maTime = 20f;
    public float timeLeft;
    public GameObject krestik;
    public GameObject galochka;

    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
        }
        else if (timeLeft > -5)
        {
            timeLeft -= Time.deltaTime;
            image.color = Color.clear;
            timerBar.color = Color.clear;
            galochka.SetActive(true);
        }
        else
        {
            galochka.SetActive(false);
            krestik.SetActive(true);
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

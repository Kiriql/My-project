using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLine : MonoBehaviour
{
    Image timerBar;
    public Image image;
    [SerializeField] private vari v;
    GameObject player;
    public float maTime = 20f;
    int i = 0;
    public float timeLeft;
    public GameObject galochka;

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
            if (i == 0)
            {
                i++;
                v.ChangeText();
            }
            image.color = Color.clear;
            timerBar.color = Color.clear;
            galochka.SetActive(true);
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

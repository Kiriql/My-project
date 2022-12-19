using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
 
public class TimerText: MonoBehaviour
{
    public float time = 300;
    public TMP_Text timerText;
 
    private float _timeLeft = 0f;
 
    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }
 
    private void Start()
    {
        _timeLeft = time;
        StartCoroutine(StartTimer());
    }
 
    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;
 
        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _timerText;
    enum TimerType { Countdown, Stopwatch }
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timeToDisplay = 180.0f;

    private bool _isRunning;


    [SerializeField] private float money;
    [SerializeField] private GameObject moneyText;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject getMoney;
    [SerializeField] private GameObject monyeRecived;
    private bool _isRecivedMoney = true;
    [SerializeField] private GameObject noteSign;
    #endregion

    //private void Awake() => _timerText = GetComponent<TMP_Text>();

    private void Start()
    {
        EventManager.OnTimerStart();
    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManagerOnTimerStart;
        //EventManager.TimerStop += EventManagerOnTimerStop;
        //EventManager.TimerUpdate += EventManagerOnTimerUpdate;
    }

    private void OnDisable()
    {
        EventManager.TimerStart -= EventManagerOnTimerStart;
        //EventManager.TimerStop -= EventManagerOnTimerStop;
        //EventManager.TimerUpdate -= EventManagerOnTimerUpdate;
    }

    private void EventManagerOnTimerStart() => _isRunning = true;
    private void EventManagerOnTimerStop()
    {
        _isRunning = false;

        timer.SetActive(false);
        getMoney.SetActive(true);
        noteSign.SetActive(true);

    }
    //private void EventManagerOnTimerUpdate(float value) => timeToDisplay += value;

    private void Update()
    {
        if (!_isRunning) return;
        if (timerType == TimerType.Countdown && timeToDisplay < 0.0f)
        {
            //EventManager.OnTimerStop();
            EventManagerOnTimerStop();
            return;
        }

        timeToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(@"mm\:ss");
    }

    public void GetMoney()
    {
        if (!_isRunning && _isRecivedMoney)
        {
            getMoney.SetActive(false);
            moneyText.SetActive(false);
            monyeRecived.SetActive(true);
            noteSign.SetActive(false);
            Score.Instance.UpScorePresent(money);
            _isRecivedMoney = false;
        }
    }
}

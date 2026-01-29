using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerRouLette : MonoBehaviour
{
    public static TimerRouLette Instance { get; set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    #region Variables

    [SerializeField] private TMP_Text _timerText;
    enum TimerType { Countdown, Stopwatch }
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timeToDisplay = 240.0f;

    private bool _isRunning;


    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject startSpine;
    [SerializeField] private GameObject noteSpine;
    public bool isTurne = false;
    #endregion

    //private void Awake() => _timerText = GetComponent<TMP_Text>();

    private void Start()
    {
        EventManager.OnTimerStartRoulette();
    }

    private void OnEnable()
    {
        EventManager.TimerStartRoulette += EventManagerOnTimerStart;
        EventManager.TimerStopRoulette += EventManagerOnTimerStop;
        EventManager.TimerUpdateRoulette += EventManagerOnTimerUpdate;
    }

    private void OnDisable()
    {
        EventManager.TimerStartRoulette -= EventManagerOnTimerStart;
        EventManager.TimerStopRoulette -= EventManagerOnTimerStop;
        EventManager.TimerUpdateRoulette -= EventManagerOnTimerUpdate;
    }

    private void EventManagerOnTimerStart()
    {
        _isRunning = true;

        timer.SetActive(true);
        startSpine.SetActive(false);
        noteSpine.SetActive(false);
    }
    private void EventManagerOnTimerStop()
    {
        _isRunning = false;

        timer.SetActive(false);
        startSpine.SetActive(true);
        noteSpine.SetActive(true);
        isTurne = true;
    }
    private void EventManagerOnTimerUpdate(float value) => timeToDisplay += value;

    private void Update()
    {
        if (!_isRunning) return;
        if (timerType == TimerType.Countdown && timeToDisplay < 0.0f)
        {
            EventManager.OnTimerStopRoulette();
            return;
        }

        timeToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(@"mm\:ss");
    }
}

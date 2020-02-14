using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SEDateTime
{
    public int year;
    public int month;
    public int day;
    public int hour;
    public int minutes;

    public void SetTime(DateTime time)
    {
        year = time.Year;
        month = time.Month;
        day = time.Day;
        hour = time.Hour;
        minutes = time.Minute;
    }
}
[System.Serializable]
public class SleepData
{
    public SEDateTime inBetTime;
    public SEDateTime blackOutTime;
    public int fallAsleepMinute;
    public int sleepAwakeTime;
    public int nextFallAsllepMinutes;
    public SEDateTime awakeTime;
    public SEDateTime goOutBetTime;
    public int howGoodSleep;
    public int howBadEffect;
    public SEDateTime sleepingTime;
    public SEDateTime gasyoTime;
}

public class InputData : MonoBehaviour
{

}

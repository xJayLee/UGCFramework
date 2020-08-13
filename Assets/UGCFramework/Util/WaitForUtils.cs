﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForUtils
{
    public static WaitForEndOfFrame WaitFrame = new WaitForEndOfFrame();
    static Dictionary<float, WaitForSeconds> times = new Dictionary<float, WaitForSeconds>();

    public static WaitForSecondsRealtime WaitForSecondsRealtime(float time)
    {
        return new WaitForSecondsRealtime(time);
    }

    public static WaitForSeconds WaitForSecond(float time)
    {
        if (times.ContainsKey(time))
        {
            return times[time];
        }
        else
        {
            WaitForSeconds waitForSeconds = new WaitForSeconds(time);
            times.Add(time, waitForSeconds);
            return waitForSeconds;
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniInject;

// Disable warning about fields that are never assigned, their values are injected.
#pragma warning disable CS0649

public class SingingResultsTotalScoreText : CountingNumberText, INeedInjection, IInjectionFinishedListener, IExcludeFromSceneInjection
{
    [Inject]
    private PlayerScoreControllerData playerScoreData;

    public void OnInjectionFinished()
    {
        TargetValue = playerScoreData.TotalScore;
    }
}

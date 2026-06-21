using Unity.VisualScripting;
using UnityEngine;
using R3;
using R3.Triggers;
using System;
using UnityEngine.TextCore;
using UnityEngine.InputSystem;

public class R3DoubleClick : MonoBehaviour
{
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => Mouse.current.leftButton.wasPressedThisFrame)
            .TimeInterval()
            .Select(_ => _.Interval.TotalSeconds)
            .Chunk(2,1)
            .Where(time => time[0] > 0.2)
            .Where(time => time[1] <= 0.2)
            .Subscribe(_ => { Debug.Log("double click!"); });
    }


}

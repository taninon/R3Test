using Unity.VisualScripting;
using UnityEngine;
using R3;
using R3.Triggers;
using System;
using UnityEngine.TextCore;

public class R3DoubleClick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.UpdateAsObservable()
            .Where(_ => Input.GetMouseButtonDown(0))
            .TimeInterval()
            .Select(_ => _.Interval.TotalSeconds)
            .Chunk(2,1)
            .Where(time => time[0] > 0.2)
            .Where(time => time[1] <= 0.2)
            .Subscribe(_ => { Debug.Log("double click!"); });
    }

    // Update is called once per frame
    void Update()
    {

    }
}

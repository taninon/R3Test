using R3;
using R3.Triggers;
using System;
using UnityEngine;

public class R3ThrottleFirstTest : MonoBehaviour
{
	void Start()
	{
		this.UpdateAsObservable()
			.Where(_ => Input.GetKeyDown(KeyCode.Space))
			.ThrottleFirst(TimeSpan.FromSeconds(2))
			.Subscribe(_ => Debug.Log("クリックされた！"));
	}
}

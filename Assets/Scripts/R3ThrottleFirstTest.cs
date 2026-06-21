using R3;
using R3.Triggers;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class R3ThrottleFirstTest : MonoBehaviour
{
	void Start()
	{
		this.UpdateAsObservable()
			.Where(_ => Mouse.current.leftButton.wasPressedThisFrame)
			.ThrottleFirst(TimeSpan.FromSeconds(2))
			.Subscribe(_ => Debug.Log("クリックされた！")).AddTo(this);
	}
}

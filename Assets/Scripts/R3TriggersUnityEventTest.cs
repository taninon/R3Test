using R3;
using System;
using UnityEngine;
using UnityEngine.UI;

public class R3TriggersUnityEventTest : MonoBehaviour
{
	[SerializeField] Button uiButton;

	private int count;

	void Start()
	{
		uiButton.OnClickAsObservable()
			.ThrottleFirst(TimeSpan.FromSeconds(0.2f))
			.Subscribe(_ => OnButtonClick());
	}

	void OnButtonClick()
	{
		count++;
		Debug.Log("ƒ{ƒ^ƒ“‚ª”½‰‚µ‚½‰ñ”" + count);
	}

}

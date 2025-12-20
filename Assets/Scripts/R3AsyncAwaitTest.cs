using R3;
using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class R3AsyncAwaitTest : MonoBehaviour
{
	[SerializeField] private Button button;
	void Start()
	{
		button.OnClickAsObservable()
		.ThrottleFirst(async (_, ct) =>
		{
			await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken: ct);
		}).Subscribe(_ =>
		{
			Debug.Log("Clicked");

		});
	}
}

using R3;
using R3.Triggers;
using System.Collections;
using TMPro;
using UnityEngine;

public class R3ObserveEveryValueChanged : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI uiText;

	void Start()
	{
		Observable.EveryValueChanged(uiText, t => t.text)
			.Subscribe(text => Debug.Log("テキストの内容:" + text))
			.AddTo(this);

		uiText.text = "Test1";
		uiText.text = "Test2";
		uiText.text = "Test3";
		uiText.text = "Test4";

		StartCoroutine(Test());

		this.OnCollisionEnterAsObservable()
			.Subscribe(_ => Debug.Log("衝突した！"))
			.AddTo(this);
	}

	IEnumerator Test()
	{
		yield return null;
		uiText.text = "CorTest1";
		yield return null;
		uiText.text = "CorTest2";
		yield return null;
		uiText.text = "CorTest3";
		yield return null;
		uiText.text = "CorTest4";
	}
}

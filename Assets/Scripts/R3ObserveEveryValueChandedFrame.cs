using R3;
using System.Collections;
using TMPro;
using UnityEngine;

public class R3ObserveEveryValueChandedFrame : MonoBehaviour
{

	[SerializeField]
	private TextMeshProUGUI uiText;

	void Start()
	{
		Observable.EveryValueChanged(uiText, t => t.text)
			.Subscribe(text => Debug.Log("テキストの内容:" + text))
			.AddTo(this);

		StartCoroutine(Test());
	}

	IEnumerator Test()
	{
		yield return null; // 1フレーム待つ
		uiText.text = "CorTest1";
		yield return null;
		uiText.text = "CorTest2";
		yield return null;
		uiText.text = "CorTest3";
		yield return null;
		uiText.text = "CorTest4";
	}


}

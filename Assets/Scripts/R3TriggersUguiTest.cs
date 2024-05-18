using R3;
using R3.Triggers;
using TMPro;
using UnityEngine;

public class R3TriggersUguiTest : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI uguiText;
	void Start()
	{
		uguiText.OnPointerClickAsObservable().Subscribe(_ => uguiText.text = "ƒNƒŠƒbƒN‚³‚ê‚½‚æ");
	}
}

using R3;
using R3.Triggers;
using UnityEngine;

public class R3TriggersTest : MonoBehaviour
{
	void Start()
	{
		this.OnMouseEnterAsObservable()
			.Select(_ => Input.mousePosition)
			.Subscribe(pos => Debug.Log("Pos:" + pos));
	}
}

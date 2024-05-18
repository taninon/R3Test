using R3;
using R3.Triggers;
using UnityEngine;

public class R3TriggersTest : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		this.OnMouseEnterAsObservable()
		.Select(_ => Input.mousePosition)
		.Subscribe(pos => Debug.Log("Pos:" + pos));
	}


}

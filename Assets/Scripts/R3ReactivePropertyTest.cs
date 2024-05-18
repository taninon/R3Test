using R3;
using UnityEngine;

public class R3ReactivePropertyTest : MonoBehaviour
{
	private ReactiveProperty<int> _count = new ReactiveProperty<int>();

	private void Start()
	{
		_count
			.Subscribe(count => Debug.Log(count))
			.AddTo(gameObject);

		_count.Value = 1;
		_count.Value = 2;
		_count.Value = 2;
		_count.Value = 4;
	}
}

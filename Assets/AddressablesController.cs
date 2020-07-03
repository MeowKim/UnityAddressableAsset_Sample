using System.Collections.Generic;
using UnityEngine;

public class AddressablesController : MonoBehaviour
{
	public string _label;
	private Transform _parent;
	private List<GameObject> _createdObjs { get; } = new List<GameObject>();

	private void Start()
	{
		_parent = GameObject.Find("Example Assets").transform;
		Instantiate();
	}

	private async void Instantiate()
	{
		await AddressablesLoader.InitAssets(_label, _createdObjs, _parent);
	}
}
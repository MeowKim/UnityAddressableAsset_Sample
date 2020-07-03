using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public static class AddressablesLoader
{
	public static async Task InitAssets<T>(string label, List<T> createdObjs, Transform parent)
		where T : Object
	{
		var locations = await Addressables.LoadResourceLocationsAsync(label).Task;

		foreach (var location in locations)
		{
			createdObjs.Add(await Addressables.InstantiateAsync(location, parent).Task as T);
		}
	}
}
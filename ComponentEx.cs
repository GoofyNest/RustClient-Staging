public static class ComponentEx // TypeDefIndex: 13433
{

	[ExtensionAttribute] 
	public static T Instantiate<T>(T component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.Instantiate<object>
	*/

	[ExtensionAttribute] 
	public static bool HasComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.HasComponent<IndependentScale>
	|-ComponentEx.HasComponent<object>
	*/

}


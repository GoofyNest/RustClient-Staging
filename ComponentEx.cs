public static class ComponentEx // TypeDefIndex: 11702
{
	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static T Instantiate<T>(T component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.Instantiate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool HasComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.HasComponent<IndependentScale>
	|-ComponentEx.HasComponent<object>
	*/

}


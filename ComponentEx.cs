public static class ComponentEx // TypeDefIndex: 11698
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T Instantiate<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159DCB0 Offset: 0x159C2B0 VA: 0x18159DCB0
	|-ComponentEx.Instantiate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool HasComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEF0E0 Offset: 0xBED6E0 VA: 0x180BEF0E0
	|-ComponentEx.HasComponent<IndependentScale>
	|-ComponentEx.HasComponent<object>
	*/

}


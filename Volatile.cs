public static class Volatile // TypeDefIndex: 836
{
	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D50 Offset: 0x76150 VA: 0x180076D50
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-Volatile.Write<object>
	*/

}


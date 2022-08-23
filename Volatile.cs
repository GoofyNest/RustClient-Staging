public static class Volatile // TypeDefIndex: 836
{
	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0F60 Offset: 0xBDF560 VA: 0x180BE0F60
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A850 Offset: 0xF08E50 VA: 0x180F0A850
	|-Volatile.Write<object>
	*/

}


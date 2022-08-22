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
	|-RVA: 0xBE0E60 Offset: 0xBDF460 VA: 0x180BE0E60
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
	|-RVA: 0xF0A750 Offset: 0xF08D50 VA: 0x180F0A750
	|-Volatile.Write<object>
	*/

}


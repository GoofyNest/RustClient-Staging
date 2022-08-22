public static class Volatile // TypeDefIndex: 836
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16094D0 Offset: 0x1607AD0 VA: 0x1816094D0
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16094F0 Offset: 0x1607AF0 VA: 0x1816094F0
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE0E60 Offset: 0xBDF460 VA: 0x180BE0E60
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1609540 Offset: 0x1607B40 VA: 0x181609540
	public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1609510 Offset: 0x1607B10 VA: 0x181609510
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A750 Offset: 0xF08D50 VA: 0x180F0A750
	|-Volatile.Write<object>
	*/

}


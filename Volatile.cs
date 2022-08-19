public static class Volatile // TypeDefIndex: 836
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x161BEF0 Offset: 0x161A4F0 VA: 0x18161BEF0
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x161BF10 Offset: 0x161A510 VA: 0x18161BF10
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE06D0 Offset: 0xBDECD0 VA: 0x180BE06D0
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x161BF60 Offset: 0x161A560 VA: 0x18161BF60
	public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x161BF30 Offset: 0x161A530 VA: 0x18161BF30
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF099F0 Offset: 0xF07FF0 VA: 0x180F099F0
	|-Volatile.Write<object>
	*/

}


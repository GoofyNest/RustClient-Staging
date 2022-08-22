public static class Interlocked // TypeDefIndex: 824
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E60 Offset: 0x1492460 VA: 0x181493E60
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E40 Offset: 0x1492440 VA: 0x181493E40
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E50 Offset: 0x1492450 VA: 0x181493E50
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1493E20 Offset: 0x1492420 VA: 0x181493E20
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E70 Offset: 0x1492470 VA: 0x181493E70
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493ED0 Offset: 0x14924D0 VA: 0x181493ED0
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493EE0 Offset: 0x14924E0 VA: 0x181493EE0
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493EC0 Offset: 0x14924C0 VA: 0x181493EC0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E90 Offset: 0x1492490 VA: 0x181493E90
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x1493EA0 Offset: 0x14924A0 VA: 0x181493EA0
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x1493E10 Offset: 0x1492410 VA: 0x181493E10
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E10 Offset: 0x1492410 VA: 0x181493E10
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x1493E30 Offset: 0x1492430 VA: 0x181493E30
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisibleAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	[ReliabilityContractAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x1493E80 Offset: 0x1492480 VA: 0x181493E80
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E80 Offset: 0x1492480 VA: 0x181493E80
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x1493EB0 Offset: 0x14924B0 VA: 0x181493EB0
	public static double Exchange(ref double location1, double value) { }

	[ComVisibleAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	[ReliabilityContractAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x1493F00 Offset: 0x1492500 VA: 0x181493F00
	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1493E00 Offset: 0x1492400 VA: 0x181493E00
	public static int Add(ref int location1, int value) { }

	// RVA: 0x1493EF0 Offset: 0x14924F0 VA: 0x181493EF0
	public static void MemoryBarrier() { }

}


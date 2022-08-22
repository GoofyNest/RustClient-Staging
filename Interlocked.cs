public static class Interlocked // TypeDefIndex: 824
{
	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static object Exchange(ref object location1, object value) { }

	public static float Exchange(ref float location1, float value) { }

	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisibleAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	[ReliabilityContractAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	public static double Exchange(ref double location1, double value) { }

	[ComVisibleAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	[ReliabilityContractAttribute] // RVA: 0xBB5C0 Offset: 0xBA9C0 VA: 0x1800BB5C0
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	public static int Add(ref int location1, int value) { }

	public static void MemoryBarrier() { }

}


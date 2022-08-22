public static class Interlocked // TypeDefIndex: 824
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494D90 Offset: 0x1493390 VA: 0x181494D90
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494D70 Offset: 0x1493370 VA: 0x181494D70
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494D80 Offset: 0x1493380 VA: 0x181494D80
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1494D50 Offset: 0x1493350 VA: 0x181494D50
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494DA0 Offset: 0x14933A0 VA: 0x181494DA0
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494E00 Offset: 0x1493400 VA: 0x181494E00
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494E10 Offset: 0x1493410 VA: 0x181494E10
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494DF0 Offset: 0x14933F0 VA: 0x181494DF0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494DC0 Offset: 0x14933C0 VA: 0x181494DC0
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x1494DD0 Offset: 0x14933D0 VA: 0x181494DD0
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x1494D40 Offset: 0x1493340 VA: 0x181494D40
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494D40 Offset: 0x1493340 VA: 0x181494D40
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x1494D60 Offset: 0x1493360 VA: 0x181494D60
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

	// RVA: 0x1494DB0 Offset: 0x14933B0 VA: 0x181494DB0
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494DB0 Offset: 0x14933B0 VA: 0x181494DB0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x1494DE0 Offset: 0x14933E0 VA: 0x181494DE0
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

	// RVA: 0x1494E30 Offset: 0x1493430 VA: 0x181494E30
	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1494D30 Offset: 0x1493330 VA: 0x181494D30
	public static int Add(ref int location1, int value) { }

	// RVA: 0x1494E20 Offset: 0x1493420 VA: 0x181494E20
	public static void MemoryBarrier() { }

}


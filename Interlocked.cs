public static class Interlocked // TypeDefIndex: 824
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494AD0 Offset: 0x14930D0 VA: 0x181494AD0
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494AB0 Offset: 0x14930B0 VA: 0x181494AB0
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494AC0 Offset: 0x14930C0 VA: 0x181494AC0
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1494A90 Offset: 0x1493090 VA: 0x181494A90
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494AE0 Offset: 0x14930E0 VA: 0x181494AE0
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494B40 Offset: 0x1493140 VA: 0x181494B40
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494B50 Offset: 0x1493150 VA: 0x181494B50
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494B30 Offset: 0x1493130 VA: 0x181494B30
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494B00 Offset: 0x1493100 VA: 0x181494B00
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x1494B10 Offset: 0x1493110 VA: 0x181494B10
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x1494A80 Offset: 0x1493080 VA: 0x181494A80
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494A80 Offset: 0x1493080 VA: 0x181494A80
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x1494AA0 Offset: 0x14930A0 VA: 0x181494AA0
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisibleAttribute] // RVA: 0xBB630 Offset: 0xBAA30 VA: 0x1800BB630
	[ReliabilityContractAttribute] // RVA: 0xBB630 Offset: 0xBAA30 VA: 0x1800BB630
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x1494AF0 Offset: 0x14930F0 VA: 0x181494AF0
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494AF0 Offset: 0x14930F0 VA: 0x181494AF0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x1494B20 Offset: 0x1493120 VA: 0x181494B20
	public static double Exchange(ref double location1, double value) { }

	[ComVisibleAttribute] // RVA: 0xBB630 Offset: 0xBAA30 VA: 0x1800BB630
	[ReliabilityContractAttribute] // RVA: 0xBB630 Offset: 0xBAA30 VA: 0x1800BB630
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x1494B70 Offset: 0x1493170 VA: 0x181494B70
	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1494A70 Offset: 0x1493070 VA: 0x181494A70
	public static int Add(ref int location1, int value) { }

	// RVA: 0x1494B60 Offset: 0x1493160 VA: 0x181494B60
	public static void MemoryBarrier() { }

}


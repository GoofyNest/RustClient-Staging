internal static class HashHelpers // TypeDefIndex: 747
{	// Fields
	public static readonly int RandomSeed; // 0x13E93

	// Methods

	// RVA: 0x16720A0 Offset: 0x16706A0 VA: 0x1816720A0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x16720C0 Offset: 0x16706C0 VA: 0x1816720C0
	private static void .cctor() { }

}

internal static class HashHelpers // TypeDefIndex: 1396
{
// Namespace: System.Collections
[FriendAccessAllowedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class HashHelpers // TypeDefIndex: 1396
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_SerializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x145FD20 Offset: 0x145E320 VA: 0x18145FD20
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x145FC10 Offset: 0x145E210 VA: 0x18145FC10
	public static bool IsPrime(int candidate) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x145FA70 Offset: 0x145E070 VA: 0x18145FA70
	public static int GetPrime(int min) { }

	// RVA: 0x145F9F0 Offset: 0x145DFF0 VA: 0x18145F9F0
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x145FCB0 Offset: 0x145E2B0 VA: 0x18145FCB0
	private static void .cctor() { }

}


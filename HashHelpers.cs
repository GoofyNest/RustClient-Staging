internal static class HashHelpers // TypeDefIndex: 747
{	// Fields
	public static readonly int RandomSeed; // 0x13E93

	// Methods

	// RVA: 0x1671DE0 Offset: 0x16703E0 VA: 0x181671DE0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x1671E00 Offset: 0x1670400 VA: 0x181671E00
	private static void .cctor() { }

}

internal static class HashHelpers // TypeDefIndex: 1396
{
// Namespace: System.Collections
[FriendAccessAllowedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal static class HashHelpers // TypeDefIndex: 1396
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_SerializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x145FA60 Offset: 0x145E060 VA: 0x18145FA60
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x145F950 Offset: 0x145DF50 VA: 0x18145F950
	public static bool IsPrime(int candidate) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x145F7B0 Offset: 0x145DDB0 VA: 0x18145F7B0
	public static int GetPrime(int min) { }

	// RVA: 0x145F730 Offset: 0x145DD30 VA: 0x18145F730
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x145F9F0 Offset: 0x145DFF0 VA: 0x18145F9F0
	private static void .cctor() { }

}


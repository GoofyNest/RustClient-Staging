public class IPAddress // TypeDefIndex: 2882
{	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	internal long m_Address; // 0x10
	internal string m_ToString; // 0x18
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private AddressFamily m_Family; // 0x20
	private ushort[] m_Numbers; // 0x28
	private long m_ScopeId; // 0x30
	private int m_HashCode; // 0x38
	internal const int IPv4AddressBytes = 4;
	internal const int IPv6AddressBytes = 16;
	internal const int NumberOfLabels = 8;

	// Properties
	[ObsoleteAttribute] // RVA: 0xB3690 Offset: 0xB2A90 VA: 0x1800B3690
	public long Address { get; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }
	internal bool IsBroadcast { get; }

	// Methods

	// RVA: 0x13433A0 Offset: 0x13419A0 VA: 0x1813433A0
	public void .ctor(long newAddress) { }

	// RVA: 0x1343080 Offset: 0x1341680 VA: 0x181343080
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1343290 Offset: 0x1341890 VA: 0x181343290
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x1343330 Offset: 0x1341930 VA: 0x181343330
	internal void .ctor(int newAddress) { }

	// RVA: 0x1342D50 Offset: 0x1341350 VA: 0x181342D50
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1342A60 Offset: 0x1341060 VA: 0x181342A60
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x13424F0 Offset: 0x1340AF0 VA: 0x1813424F0
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x1343450 Offset: 0x1341A50 VA: 0x181343450
	public long get_Address() { }

	// RVA: 0x1342240 Offset: 0x1340840 VA: 0x181342240
	public byte[] GetAddressBytes() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1343550 Offset: 0x1341B50 VA: 0x181343550
	public long get_ScopeId() { }

	// RVA: 0x1342AC0 Offset: 0x13410C0 VA: 0x181342AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1342830 Offset: 0x1340E30 VA: 0x181342830
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x13434C0 Offset: 0x1341AC0 VA: 0x1813434C0
	internal bool get_IsBroadcast() { }

	// RVA: 0x1342100 Offset: 0x1340700 VA: 0x181342100
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1342230 Offset: 0x1340830 VA: 0x181342230 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x13423F0 Offset: 0x13409F0 VA: 0x1813423F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1342930 Offset: 0x1340F30 VA: 0x181342930
	public IPAddress MapToIPv6() { }

	// RVA: 0x1342DD0 Offset: 0x13413D0 VA: 0x181342DD0
	private static void .cctor() { }

}


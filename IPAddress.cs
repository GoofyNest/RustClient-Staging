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

	// RVA: 0x1343FE0 Offset: 0x13425E0 VA: 0x181343FE0
	public void .ctor(long newAddress) { }

	// RVA: 0x1343CC0 Offset: 0x13422C0 VA: 0x181343CC0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1343ED0 Offset: 0x13424D0 VA: 0x181343ED0
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x1343F70 Offset: 0x1342570 VA: 0x181343F70
	internal void .ctor(int newAddress) { }

	// RVA: 0x1343990 Offset: 0x1341F90 VA: 0x181343990
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x13436A0 Offset: 0x1341CA0 VA: 0x1813436A0
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1343130 Offset: 0x1341730 VA: 0x181343130
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x1344090 Offset: 0x1342690 VA: 0x181344090
	public long get_Address() { }

	// RVA: 0x1342E80 Offset: 0x1341480 VA: 0x181342E80
	public byte[] GetAddressBytes() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1344190 Offset: 0x1342790 VA: 0x181344190
	public long get_ScopeId() { }

	// RVA: 0x1343700 Offset: 0x1341D00 VA: 0x181343700 Slot: 3
	public override string ToString() { }

	// RVA: 0x1343470 Offset: 0x1341A70 VA: 0x181343470
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1344100 Offset: 0x1342700 VA: 0x181344100
	internal bool get_IsBroadcast() { }

	// RVA: 0x1342D40 Offset: 0x1341340 VA: 0x181342D40
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1342E70 Offset: 0x1341470 VA: 0x181342E70 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1343030 Offset: 0x1341630 VA: 0x181343030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1343570 Offset: 0x1341B70 VA: 0x181343570
	public IPAddress MapToIPv6() { }

	// RVA: 0x1343A10 Offset: 0x1342010 VA: 0x181343A10
	private static void .cctor() { }

}


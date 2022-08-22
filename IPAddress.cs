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

	// RVA: 0x13442A0 Offset: 0x13428A0 VA: 0x1813442A0
	public void .ctor(long newAddress) { }

	// RVA: 0x1343F80 Offset: 0x1342580 VA: 0x181343F80
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1344190 Offset: 0x1342790 VA: 0x181344190
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x1344230 Offset: 0x1342830 VA: 0x181344230
	internal void .ctor(int newAddress) { }

	// RVA: 0x1343C50 Offset: 0x1342250 VA: 0x181343C50
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1343960 Offset: 0x1341F60 VA: 0x181343960
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x13433F0 Offset: 0x13419F0 VA: 0x1813433F0
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x1344350 Offset: 0x1342950 VA: 0x181344350
	public long get_Address() { }

	// RVA: 0x1343140 Offset: 0x1341740 VA: 0x181343140
	public byte[] GetAddressBytes() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1344450 Offset: 0x1342A50 VA: 0x181344450
	public long get_ScopeId() { }

	// RVA: 0x13439C0 Offset: 0x1341FC0 VA: 0x1813439C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1343730 Offset: 0x1341D30 VA: 0x181343730
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x13443C0 Offset: 0x13429C0 VA: 0x1813443C0
	internal bool get_IsBroadcast() { }

	// RVA: 0x1343000 Offset: 0x1341600 VA: 0x181343000
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1343130 Offset: 0x1341730 VA: 0x181343130 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x13432F0 Offset: 0x13418F0 VA: 0x1813432F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1343830 Offset: 0x1341E30 VA: 0x181343830
	public IPAddress MapToIPv6() { }

	// RVA: 0x1343CD0 Offset: 0x13422D0 VA: 0x181343CD0
	private static void .cctor() { }

}


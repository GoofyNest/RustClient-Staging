public class IPEndPoint : EndPoint // TypeDefIndex: 2883
{	// Fields
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress m_Address; // 0x10
	private int m_Port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x1344CE0 Offset: 0x13432E0 VA: 0x181344CE0 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1344BF0 Offset: 0x13431F0 VA: 0x181344BF0
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IPAddress get_Address() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Port() { }

	// RVA: 0x1344A50 Offset: 0x1343050 VA: 0x181344A50 Slot: 3
	public override string ToString() { }

	// RVA: 0x13449E0 Offset: 0x1342FE0 VA: 0x1813449E0 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x13444C0 Offset: 0x1342AC0 VA: 0x1813444C0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x13447D0 Offset: 0x1342DD0 VA: 0x1813447D0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x13449A0 Offset: 0x1342FA0 VA: 0x1813449A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1344B00 Offset: 0x1343100 VA: 0x181344B00
	private static void .cctor() { }

}


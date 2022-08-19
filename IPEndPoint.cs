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

	// RVA: 0x1344A20 Offset: 0x1343020 VA: 0x181344A20 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1344930 Offset: 0x1342F30 VA: 0x181344930
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IPAddress get_Address() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Port() { }

	// RVA: 0x1344790 Offset: 0x1342D90 VA: 0x181344790 Slot: 3
	public override string ToString() { }

	// RVA: 0x1344720 Offset: 0x1342D20 VA: 0x181344720 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x1344200 Offset: 0x1342800 VA: 0x181344200 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1344510 Offset: 0x1342B10 VA: 0x181344510 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x13446E0 Offset: 0x1342CE0 VA: 0x1813446E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1344840 Offset: 0x1342E40 VA: 0x181344840
	private static void .cctor() { }

}


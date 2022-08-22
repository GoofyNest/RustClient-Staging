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

	// RVA: 0x1343DE0 Offset: 0x13423E0 VA: 0x181343DE0 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1343CF0 Offset: 0x13422F0 VA: 0x181343CF0
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public IPAddress get_Address() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Port() { }

	// RVA: 0x1343B50 Offset: 0x1342150 VA: 0x181343B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1343AE0 Offset: 0x13420E0 VA: 0x181343AE0 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x13435C0 Offset: 0x1341BC0 VA: 0x1813435C0 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x13438D0 Offset: 0x1341ED0 VA: 0x1813438D0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1343AA0 Offset: 0x13420A0 VA: 0x181343AA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1343C00 Offset: 0x1342200 VA: 0x181343C00
	private static void .cctor() { }

}


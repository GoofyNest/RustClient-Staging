public class TcpListener // TypeDefIndex: 3059
{	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Methods

	// RVA: 0x100BEA0 Offset: 0x100A4A0 VA: 0x18100BEA0
	public void .ctor(IPAddress localaddr, int port) { }

	// RVA: 0x100BD30 Offset: 0x100A330 VA: 0x18100BD30
	public void Start() { }

	// RVA: 0x100BB40 Offset: 0x100A140 VA: 0x18100BB40
	public void Start(int backlog) { }

	// RVA: 0x100BD40 Offset: 0x100A340 VA: 0x18100BD40
	public void Stop() { }

	// RVA: 0x100BA10 Offset: 0x100A010 VA: 0x18100BA10
	public bool Pending() { }

	// RVA: 0x100B980 Offset: 0x1009F80 VA: 0x18100B980
	public Socket AcceptSocket() { }

}


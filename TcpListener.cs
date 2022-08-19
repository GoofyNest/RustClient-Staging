public class TcpListener // TypeDefIndex: 3059
{	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Methods

	// RVA: 0x100BBE0 Offset: 0x100A1E0 VA: 0x18100BBE0
	public void .ctor(IPAddress localaddr, int port) { }

	// RVA: 0x100BA70 Offset: 0x100A070 VA: 0x18100BA70
	public void Start() { }

	// RVA: 0x100B880 Offset: 0x1009E80 VA: 0x18100B880
	public void Start(int backlog) { }

	// RVA: 0x100BA80 Offset: 0x100A080 VA: 0x18100BA80
	public void Stop() { }

	// RVA: 0x100B750 Offset: 0x1009D50 VA: 0x18100B750
	public bool Pending() { }

	// RVA: 0x100B6C0 Offset: 0x1009CC0 VA: 0x18100B6C0
	public Socket AcceptSocket() { }

}


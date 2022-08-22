public class TcpListener // TypeDefIndex: 3059
{	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Methods

	// RVA: 0x100C940 Offset: 0x100AF40 VA: 0x18100C940
	public void .ctor(IPAddress localaddr, int port) { }

	// RVA: 0x100C7D0 Offset: 0x100ADD0 VA: 0x18100C7D0
	public void Start() { }

	// RVA: 0x100C5E0 Offset: 0x100ABE0 VA: 0x18100C5E0
	public void Start(int backlog) { }

	// RVA: 0x100C7E0 Offset: 0x100ADE0 VA: 0x18100C7E0
	public void Stop() { }

	// RVA: 0x100C4B0 Offset: 0x100AAB0 VA: 0x18100C4B0
	public bool Pending() { }

	// RVA: 0x100C420 Offset: 0x100AA20 VA: 0x18100C420
	public Socket AcceptSocket() { }

}


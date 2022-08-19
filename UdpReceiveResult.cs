public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 3061
{	// Fields
	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	// Properties
	public byte[] Buffer { get; }

	// Methods

	// RVA: 0x14CE50 Offset: 0x14C250 VA: 0x18014CE50
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public byte[] get_Buffer() { }

	// RVA: 0x14CDE0 Offset: 0x14C1E0 VA: 0x18014CDE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14CD30 Offset: 0x14C130 VA: 0x18014CD30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14CCD0 Offset: 0x14C0D0 VA: 0x18014CCD0 Slot: 4
	public bool Equals(UdpReceiveResult other) { }

}


public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 3061
{	// Fields
	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	// Properties
	public byte[] Buffer { get; }

	// Methods

	// RVA: 0x14CDD0 Offset: 0x14C1D0 VA: 0x18014CDD0
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public byte[] get_Buffer() { }

	// RVA: 0x14CD60 Offset: 0x14C160 VA: 0x18014CD60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14CCB0 Offset: 0x14C0B0 VA: 0x18014CCB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14CC50 Offset: 0x14C050 VA: 0x18014CC50 Slot: 4
	public bool Equals(UdpReceiveResult other) { }

}


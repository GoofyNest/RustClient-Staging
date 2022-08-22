public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 3061
{	// Fields
	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	// Properties
	public byte[] Buffer { get; }

	// Methods

	// RVA: 0x14CBF0 Offset: 0x14BFF0 VA: 0x18014CBF0
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public byte[] get_Buffer() { }

	// RVA: 0x14CB80 Offset: 0x14BF80 VA: 0x18014CB80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14CAD0 Offset: 0x14BED0 VA: 0x18014CAD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14CA70 Offset: 0x14BE70 VA: 0x18014CA70 Slot: 4
	public bool Equals(UdpReceiveResult other) { }

}


public struct SendInfo // TypeDefIndex: 6701
{	// Fields
	public SendMethod method; // 0x0
	public sbyte channel; // 0x4
	public Priority priority; // 0x8
	public List<Connection> connections; // 0x10
	public Connection connection; // 0x18

	// Methods

	// RVA: 0x2374B0 Offset: 0x2368B0 VA: 0x1802374B0
	public void .ctor(List<Connection> connections) { }

	// RVA: 0x237480 Offset: 0x236880 VA: 0x180237480
	public void .ctor(Connection connection) { }

}


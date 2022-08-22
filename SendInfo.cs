public struct SendInfo // TypeDefIndex: 6701
{	// Fields
	public SendMethod method; // 0x0
	public sbyte channel; // 0x4
	public Priority priority; // 0x8
	public List<Connection> connections; // 0x10
	public Connection connection; // 0x18

	// Methods

	// RVA: 0x237430 Offset: 0x236830 VA: 0x180237430
	public void .ctor(List<Connection> connections) { }

	// RVA: 0x237400 Offset: 0x236800 VA: 0x180237400
	public void .ctor(Connection connection) { }

}


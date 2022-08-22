public class ByteMap // TypeDefIndex: 10278
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int bytes; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] values; // 0x18

	// Properties
	public int Size { get; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x6F2BA0 Offset: 0x6F11A0 VA: 0x1806F2BA0
	public void .ctor(int size, int bytes = 1) { }

	// RVA: 0x6F2B50 Offset: 0x6F1150 VA: 0x1806F2B50
	public void .ctor(int size, byte[] values, int bytes = 1) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x6F2C20 Offset: 0x6F1220 VA: 0x1806F2C20
	public uint get_Item(int x, int y) { }

	// RVA: 0x6F2E30 Offset: 0x6F1430 VA: 0x1806F2E30
	public void set_Item(int x, int y, uint value) { }

}


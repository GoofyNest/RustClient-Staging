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

	// RVA: 0x6F2B30 Offset: 0x6F1130 VA: 0x1806F2B30
	public void .ctor(int size, int bytes = 1) { }

	// RVA: 0x6F2AE0 Offset: 0x6F10E0 VA: 0x1806F2AE0
	public void .ctor(int size, byte[] values, int bytes = 1) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x6F2BB0 Offset: 0x6F11B0 VA: 0x1806F2BB0
	public uint get_Item(int x, int y) { }

	// RVA: 0x6F2DC0 Offset: 0x6F13C0 VA: 0x1806F2DC0
	public void set_Item(int x, int y, uint value) { }

}


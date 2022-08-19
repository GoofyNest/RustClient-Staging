public class ByteMap // TypeDefIndex: 10278
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int bytes; // 0x14
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private byte[] values; // 0x18

	// Properties
	public int Size { get; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x6F2A90 Offset: 0x6F1090 VA: 0x1806F2A90
	public void .ctor(int size, int bytes = 1) { }

	// RVA: 0x6F2A40 Offset: 0x6F1040 VA: 0x1806F2A40
	public void .ctor(int size, byte[] values, int bytes = 1) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x6F2B10 Offset: 0x6F1110 VA: 0x1806F2B10
	public uint get_Item(int x, int y) { }

	// RVA: 0x6F2D20 Offset: 0x6F1320 VA: 0x1806F2D20
	public void set_Item(int x, int y, uint value) { }

}


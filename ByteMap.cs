public class ByteMap // TypeDefIndex: 10278
{	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int bytes; // 0x14
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] values; // 0x18

	public int Size { get; }
	public uint Item { get; set; }


	public void .ctor(int size, int bytes = 1) { }

	public void .ctor(int size, byte[] values, int bytes = 1) { }

	public int get_Size() { }

	public uint get_Item(int x, int y) { }

	public void set_Item(int x, int y, uint value) { }

}


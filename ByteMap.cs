public class ByteMap // TypeDefIndex: 10282
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int size; // 0x10
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int bytes; // 0x14
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private byte[] values; // 0x18

	public int Size { get; }
	public uint Item { get; set; }


	public void .ctor(int size, int bytes = 1) { }

	public void .ctor(int size, byte[] values, int bytes = 1) { }

	public int get_Size() { }

	public uint get_Item(int x, int y) { }

	public void set_Item(int x, int y, uint value) { }

}


public class TextBuffer // TypeDefIndex: 6595
{	// Fields
	private Queue<string> buffer; // 0x10
	private StringBuilder builder; // 0x18
	private string text; // 0x20
	private bool dirty; // 0x28
	private int curlines; // 0x2C
	private int maxlines; // 0x30
	private int curchars; // 0x34
	private int maxchars; // 0x38

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	public int get_Count() { }

	// RVA: 0x1BAD280 Offset: 0x1BAB880 VA: 0x181BAD280
	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	// RVA: 0x1BACCA0 Offset: 0x1BAB2A0 VA: 0x181BACCA0
	public void Add(string text) { }

	// RVA: 0x1BAD0A0 Offset: 0x1BAB6A0 VA: 0x181BAD0A0
	public void Remove() { }

	// RVA: 0x1BACFB0 Offset: 0x1BAB5B0 VA: 0x181BACFB0
	public void Clear() { }

	// RVA: 0x1BAD020 Offset: 0x1BAB620 VA: 0x181BAD020
	public string Get(int index) { }

	// RVA: 0x1BAD100 Offset: 0x1BAB700 VA: 0x181BAD100 Slot: 3
	public override string ToString() { }

}


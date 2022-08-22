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

	// RVA: 0x1BAD0C0 Offset: 0x1BAB6C0 VA: 0x181BAD0C0
	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	// RVA: 0x1BACAE0 Offset: 0x1BAB0E0 VA: 0x181BACAE0
	public void Add(string text) { }

	// RVA: 0x1BACEE0 Offset: 0x1BAB4E0 VA: 0x181BACEE0
	public void Remove() { }

	// RVA: 0x1BACDF0 Offset: 0x1BAB3F0 VA: 0x181BACDF0
	public void Clear() { }

	// RVA: 0x1BACE60 Offset: 0x1BAB460 VA: 0x181BACE60
	public string Get(int index) { }

	// RVA: 0x1BACF40 Offset: 0x1BAB540 VA: 0x181BACF40 Slot: 3
	public override string ToString() { }

}


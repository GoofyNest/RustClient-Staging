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

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	public int get_Count() { }

	// RVA: 0x1BADB70 Offset: 0x1BAC170 VA: 0x181BADB70
	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	// RVA: 0x1BAD590 Offset: 0x1BABB90 VA: 0x181BAD590
	public void Add(string text) { }

	// RVA: 0x1BAD990 Offset: 0x1BABF90 VA: 0x181BAD990
	public void Remove() { }

	// RVA: 0x1BAD8A0 Offset: 0x1BABEA0 VA: 0x181BAD8A0
	public void Clear() { }

	// RVA: 0x1BAD910 Offset: 0x1BABF10 VA: 0x181BAD910
	public string Get(int index) { }

	// RVA: 0x1BAD9F0 Offset: 0x1BABFF0 VA: 0x181BAD9F0 Slot: 3
	public override string ToString() { }

}


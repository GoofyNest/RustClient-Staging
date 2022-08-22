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

	// RVA: 0x1BAD380 Offset: 0x1BAB980 VA: 0x181BAD380
	public void .ctor(int maxlines, int maxchars = 2147483647) { }

	// RVA: 0x1BACDA0 Offset: 0x1BAB3A0 VA: 0x181BACDA0
	public void Add(string text) { }

	// RVA: 0x1BAD1A0 Offset: 0x1BAB7A0 VA: 0x181BAD1A0
	public void Remove() { }

	// RVA: 0x1BAD0B0 Offset: 0x1BAB6B0 VA: 0x181BAD0B0
	public void Clear() { }

	// RVA: 0x1BAD120 Offset: 0x1BAB720 VA: 0x181BAD120
	public string Get(int index) { }

	// RVA: 0x1BAD200 Offset: 0x1BAB800 VA: 0x181BAD200 Slot: 3
	public override string ToString() { }

}


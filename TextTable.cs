public class TextTable // TypeDefIndex: 6596
{	// Fields
	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0

	// Methods

	// RVA: 0x1BAD740 Offset: 0x1BABD40 VA: 0x181BAD740
	public void Clear() { }

	// RVA: 0x1BAD420 Offset: 0x1BABA20 VA: 0x181BAD420
	public void AddColumns(string[] values) { }

	// RVA: 0x1BAD360 Offset: 0x1BAB960 VA: 0x181BAD360
	public void AddColumn(string title) { }

	// RVA: 0x1BAD530 Offset: 0x1BABB30 VA: 0x181BAD530
	public void AddRow(string[] values) { }

	// RVA: 0x1BAD800 Offset: 0x1BABE00 VA: 0x181BAD800
	public string ToJson() { }

	// RVA: 0x1BADD70 Offset: 0x1BAC370 VA: 0x181BADD70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAD7C0 Offset: 0x1BABDC0 VA: 0x181BAD7C0
	private void MarkDirty() { }

	// RVA: 0x1BAE0E0 Offset: 0x1BAC6E0 VA: 0x181BAE0E0
	public void .ctor() { }

	// RVA: 0x1BAE080 Offset: 0x1BAC680 VA: 0x181BAE080
	private static void .cctor() { }

}

private class TextTable.Row // TypeDefIndex: 6597
{	// Fields
	public string[] values; // 0x10

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string[] values) { }

}

private class TextTable.Column // TypeDefIndex: 6598
{	// Fields
	public string title; // 0x10
	public int width; // 0x18

	// Methods

	// RVA: 0x1BA2270 Offset: 0x1BA0870 VA: 0x181BA2270
	public void .ctor(string title) { }

}


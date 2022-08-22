public class TextTable // TypeDefIndex: 6596
{	// Fields
	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0

	// Methods

	// RVA: 0x1BAD580 Offset: 0x1BABB80 VA: 0x181BAD580
	public void Clear() { }

	// RVA: 0x1BAD260 Offset: 0x1BAB860 VA: 0x181BAD260
	public void AddColumns(string[] values) { }

	// RVA: 0x1BAD1A0 Offset: 0x1BAB7A0 VA: 0x181BAD1A0
	public void AddColumn(string title) { }

	// RVA: 0x1BAD370 Offset: 0x1BAB970 VA: 0x181BAD370
	public void AddRow(string[] values) { }

	// RVA: 0x1BAD640 Offset: 0x1BABC40 VA: 0x181BAD640
	public string ToJson() { }

	// RVA: 0x1BADBB0 Offset: 0x1BAC1B0 VA: 0x181BADBB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAD600 Offset: 0x1BABC00 VA: 0x181BAD600
	private void MarkDirty() { }

	// RVA: 0x1BADF20 Offset: 0x1BAC520 VA: 0x181BADF20
	public void .ctor() { }

	// RVA: 0x1BADEC0 Offset: 0x1BAC4C0 VA: 0x181BADEC0
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

	// RVA: 0x1BA20B0 Offset: 0x1BA06B0 VA: 0x181BA20B0
	public void .ctor(string title) { }

}


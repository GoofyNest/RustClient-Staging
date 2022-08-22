public class TextTable // TypeDefIndex: 6596
{	// Fields
	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0

	// Methods

	// RVA: 0x1BAD840 Offset: 0x1BABE40 VA: 0x181BAD840
	public void Clear() { }

	// RVA: 0x1BAD520 Offset: 0x1BABB20 VA: 0x181BAD520
	public void AddColumns(string[] values) { }

	// RVA: 0x1BAD460 Offset: 0x1BABA60 VA: 0x181BAD460
	public void AddColumn(string title) { }

	// RVA: 0x1BAD630 Offset: 0x1BABC30 VA: 0x181BAD630
	public void AddRow(string[] values) { }

	// RVA: 0x1BAD900 Offset: 0x1BABF00 VA: 0x181BAD900
	public string ToJson() { }

	// RVA: 0x1BADE70 Offset: 0x1BAC470 VA: 0x181BADE70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAD8C0 Offset: 0x1BABEC0 VA: 0x181BAD8C0
	private void MarkDirty() { }

	// RVA: 0x1BAE1E0 Offset: 0x1BAC7E0 VA: 0x181BAE1E0
	public void .ctor() { }

	// RVA: 0x1BAE180 Offset: 0x1BAC780 VA: 0x181BAE180
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

	// RVA: 0x1BA2370 Offset: 0x1BA0970 VA: 0x181BA2370
	public void .ctor(string title) { }

}


public class TextTable // TypeDefIndex: 6596
{	// Fields
	private List<TextTable.Row> rows; // 0x10
	private List<TextTable.Column> columns; // 0x18
	private StringBuilder builder; // 0x20
	private string text; // 0x28
	private string jsonText; // 0x30
	private static Encoding utf8NoBom; // 0x0

	// Methods

	// RVA: 0x1BAE030 Offset: 0x1BAC630 VA: 0x181BAE030
	public void Clear() { }

	// RVA: 0x1BADD10 Offset: 0x1BAC310 VA: 0x181BADD10
	public void AddColumns(string[] values) { }

	// RVA: 0x1BADC50 Offset: 0x1BAC250 VA: 0x181BADC50
	public void AddColumn(string title) { }

	// RVA: 0x1BADE20 Offset: 0x1BAC420 VA: 0x181BADE20
	public void AddRow(string[] values) { }

	// RVA: 0x1BAE0F0 Offset: 0x1BAC6F0 VA: 0x181BAE0F0
	public string ToJson() { }

	// RVA: 0x1BAE660 Offset: 0x1BACC60 VA: 0x181BAE660 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAE0B0 Offset: 0x1BAC6B0 VA: 0x181BAE0B0
	private void MarkDirty() { }

	// RVA: 0x1BAE9D0 Offset: 0x1BACFD0 VA: 0x181BAE9D0
	public void .ctor() { }

	// RVA: 0x1BAE970 Offset: 0x1BACF70 VA: 0x181BAE970
	private static void .cctor() { }

}

private class TextTable.Row // TypeDefIndex: 6597
{	// Fields
	public string[] values; // 0x10

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(string[] values) { }

}

private class TextTable.Column // TypeDefIndex: 6598
{	// Fields
	public string title; // 0x10
	public int width; // 0x18

	// Methods

	// RVA: 0x1BA2B60 Offset: 0x1BA1160 VA: 0x181BA2B60
	public void .ctor(string title) { }

}


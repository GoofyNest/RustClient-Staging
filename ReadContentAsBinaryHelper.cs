internal class ReadContentAsBinaryHelper // TypeDefIndex: 1860
{	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0xF61660 Offset: 0xF5FC60 VA: 0x180F61660
	internal void Finish() { }

	// RVA: 0xF619F0 Offset: 0xF5FFF0 VA: 0x180F619F0
	internal void Reset() { }

	// RVA: 0xF618B0 Offset: 0xF5FEB0 VA: 0x180F618B0
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 1861
{	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;

}


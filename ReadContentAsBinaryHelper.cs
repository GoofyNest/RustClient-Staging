internal class ReadContentAsBinaryHelper // TypeDefIndex: 1860
{	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0xF60900 Offset: 0xF5EF00 VA: 0x180F60900
	internal void Finish() { }

	// RVA: 0xF60C90 Offset: 0xF5F290 VA: 0x180F60C90
	internal void Reset() { }

	// RVA: 0xF60B50 Offset: 0xF5F150 VA: 0x180F60B50
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 1861
{	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;

}


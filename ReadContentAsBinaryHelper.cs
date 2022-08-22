internal class ReadContentAsBinaryHelper // TypeDefIndex: 1860
{	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0xF60BC0 Offset: 0xF5F1C0 VA: 0x180F60BC0
	internal void Finish() { }

	// RVA: 0xF60F50 Offset: 0xF5F550 VA: 0x180F60F50
	internal void Reset() { }

	// RVA: 0xF60E10 Offset: 0xF5F410 VA: 0x180F60E10
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 1861
{	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;

}


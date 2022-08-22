public class TabControl : RustControl // TypeDefIndex: 7038
{	// Fields
	public RectTransform TabContainer; // 0x30
	public RectTransform PanelContainer; // 0x38
	public RustButton ButtonControl; // 0x40
	public float InnerPadding; // 0x48
	public bool AllowCloseAll; // 0x4C
	public Image Background; // 0x50
	public Image Foreground; // 0x58

	// Methods

	// RVA: 0xFD50F0 Offset: 0xFD36F0 VA: 0x180FD50F0
	public RustLayout Panel(string name) { }

	// RVA: 0xFD5080 Offset: 0xFD3680 VA: 0x180FD5080
	public RustButton Button(string name) { }

	// RVA: 0xFD4AA0 Offset: 0xFD30A0 VA: 0x180FD4AA0
	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	// RVA: 0xFD4F70 Offset: 0xFD3570 VA: 0x180FD4F70 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFD5160 Offset: 0xFD3760 VA: 0x180FD5160
	public void .ctor() { }

}


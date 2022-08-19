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

	// RVA: 0xFD4390 Offset: 0xFD2990 VA: 0x180FD4390
	public RustLayout Panel(string name) { }

	// RVA: 0xFD4320 Offset: 0xFD2920 VA: 0x180FD4320
	public RustButton Button(string name) { }

	// RVA: 0xFD3D40 Offset: 0xFD2340 VA: 0x180FD3D40
	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	// RVA: 0xFD4210 Offset: 0xFD2810 VA: 0x180FD4210 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFD4400 Offset: 0xFD2A00 VA: 0x180FD4400
	public void .ctor() { }

}


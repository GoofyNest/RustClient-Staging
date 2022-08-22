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

	// RVA: 0xFD4650 Offset: 0xFD2C50 VA: 0x180FD4650
	public RustLayout Panel(string name) { }

	// RVA: 0xFD45E0 Offset: 0xFD2BE0 VA: 0x180FD45E0
	public RustButton Button(string name) { }

	// RVA: 0xFD4000 Offset: 0xFD2600 VA: 0x180FD4000
	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	// RVA: 0xFD44D0 Offset: 0xFD2AD0 VA: 0x180FD44D0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFD46C0 Offset: 0xFD2CC0 VA: 0x180FD46C0
	public void .ctor() { }

}


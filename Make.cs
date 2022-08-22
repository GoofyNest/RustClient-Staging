public static class Make // TypeDefIndex: 7049
{	// Fields
	public static string PrefabRoot; // 0x0
	public static Translate.Phrase phrase_on; // 0x8
	public static Translate.Phrase phrase_off; // 0x10
	public static Translate.Phrase phrase_enabled; // 0x18
	public static Translate.Phrase phrase_disabled; // 0x20

	// Methods

	// RVA: 0xFC3F70 Offset: 0xFC2570 VA: 0x180FC3F70
	public static LayoutElement Flex() { }

	// RVA: 0xFC3CB0 Offset: 0xFC22B0 VA: 0x180FC3CB0
	public static RustButton Button(Translate.Phrase label, Icons icon = 61530, bool toggle = False, string style = "Normal", bool autoSize = False) { }

	// RVA: 0xFC4460 Offset: 0xFC2A60 VA: 0x180FC4460
	public static RustButton MenuOption(Translate.Phrase label, Icons icon = 0, string style = "Normal") { }

	// RVA: 0xFC4600 Offset: 0xFC2C00 VA: 0x180FC4600
	public static Menu Menu(Option[] options, Nullable<Option> selectedOption, bool AllowFiltering = False, string style = "Normal") { }

	// RVA: 0xFC4C30 Offset: 0xFC3230 VA: 0x180FC4C30
	public static Video Video(string style = "Normal") { }

	// RVA: 0xFC4010 Offset: 0xFC2610 VA: 0x180FC4010
	public static RustButton HeaderButton(Translate.Phrase label, Translate.Phrase subtitle, string style = "Header") { }

	// RVA: 0xFC4730 Offset: 0xFC2D30 VA: 0x180FC4730
	public static RustOption Option(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC3B70 Offset: 0xFC2170 VA: 0x180FC3B70
	public static RustButtonGroup ButtonGroup(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC3E30 Offset: 0xFC2430 VA: 0x180FC3E30
	public static Dropdown Dropdown(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC42B0 Offset: 0xFC28B0 VA: 0x180FC42B0
	public static RustInput Input(Translate.Phrase placeholder, string style = "Normal") { }

	// RVA: 0xFC41D0 Offset: 0xFC27D0 VA: 0x180FC41D0
	public static RustIcon Icon(Icons icon = 63417, string style = "Normal") { }

	// RVA: 0xFC4870 Offset: 0xFC2E70 VA: 0x180FC4870
	public static RustSlider Slider(float minValue, float maxValue, float currentValue, bool integer = False, string style = "Normal") { }

	// RVA: 0xFC4A70 Offset: 0xFC3070 VA: 0x180FC4A70
	public static RustToggle Toggle(Translate.Phrase on, Translate.Phrase off, string style = "Normal") { }

	// RVA: 0xFC3AC0 Offset: 0xFC20C0 VA: 0x180FC3AC0
	public static Blocker Blocker(string style = "Normal") { }

	// RVA: 0xFC4A00 Offset: 0xFC3000 VA: 0x180FC4A00
	public static RustToggle ToggleOnOff(string style = "Normal") { }

	// RVA: 0xFC4990 Offset: 0xFC2F90 VA: 0x180FC4990
	public static RustToggle ToggleEnabledDisabled(string style = "Normal") { }

	// RVA: 0xFC4CE0 Offset: 0xFC32E0 VA: 0x180FC4CE0
	private static void .cctor() { }

}

public static class Make.Container // TypeDefIndex: 7050
{	// Methods

	// RVA: 0xFBF030 Offset: 0xFBD630 VA: 0x180FBF030
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFBEED0 Offset: 0xFBD4D0 VA: 0x180FBEED0
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFBEE20 Offset: 0xFBD420 VA: 0x180FBEE20
	public static RustWrapper Indent(string style = "Normal") { }

	// RVA: 0xFBEF80 Offset: 0xFBD580 VA: 0x180FBEF80
	public static TabControl TabControl(string style = "Normal") { }

	// RVA: 0xFBF0E0 Offset: 0xFBD6E0 VA: 0x180FBF0E0
	public static RustLayout Vertical(string style = "Normal") { }

}

public static class Make.Form // TypeDefIndex: 7051
{	// Methods

	// RVA: 0xFC21D0 Offset: 0xFC07D0 VA: 0x180FC21D0
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFC2120 Offset: 0xFC0720 VA: 0x180FC2120
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFC2280 Offset: 0xFC0880 VA: 0x180FC2280
	public static RustWrapper Vertical(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

	// RVA: 0xFC1F90 Offset: 0xFC0590 VA: 0x180FC1F90
	public static RustWrapper Horizontal(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

}

public static class Make.Label // TypeDefIndex: 7052
{	// Methods

	// RVA: 0xFC3610 Offset: 0xFC1C10 VA: 0x180FC3610
	public static RustText Normal(Translate.Phrase text) { }

	// RVA: 0xFC3730 Offset: 0xFC1D30 VA: 0x180FC3730
	public static RustText Small(Translate.Phrase text) { }

	// RVA: 0xFC34F0 Offset: 0xFC1AF0 VA: 0x180FC34F0
	public static RustText Large(Translate.Phrase text) { }

}


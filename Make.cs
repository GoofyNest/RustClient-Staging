public static class Make // TypeDefIndex: 7049
{	// Fields
	public static string PrefabRoot; // 0x0
	public static Translate.Phrase phrase_on; // 0x8
	public static Translate.Phrase phrase_off; // 0x10
	public static Translate.Phrase phrase_enabled; // 0x18
	public static Translate.Phrase phrase_disabled; // 0x20

	// Methods

	// RVA: 0xFC34D0 Offset: 0xFC1AD0 VA: 0x180FC34D0
	public static LayoutElement Flex() { }

	// RVA: 0xFC3210 Offset: 0xFC1810 VA: 0x180FC3210
	public static RustButton Button(Translate.Phrase label, Icons icon = 61530, bool toggle = False, string style = "Normal", bool autoSize = False) { }

	// RVA: 0xFC39C0 Offset: 0xFC1FC0 VA: 0x180FC39C0
	public static RustButton MenuOption(Translate.Phrase label, Icons icon = 0, string style = "Normal") { }

	// RVA: 0xFC3B60 Offset: 0xFC2160 VA: 0x180FC3B60
	public static Menu Menu(Option[] options, Nullable<Option> selectedOption, bool AllowFiltering = False, string style = "Normal") { }

	// RVA: 0xFC4190 Offset: 0xFC2790 VA: 0x180FC4190
	public static Video Video(string style = "Normal") { }

	// RVA: 0xFC3570 Offset: 0xFC1B70 VA: 0x180FC3570
	public static RustButton HeaderButton(Translate.Phrase label, Translate.Phrase subtitle, string style = "Header") { }

	// RVA: 0xFC3C90 Offset: 0xFC2290 VA: 0x180FC3C90
	public static RustOption Option(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC30D0 Offset: 0xFC16D0 VA: 0x180FC30D0
	public static RustButtonGroup ButtonGroup(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC3390 Offset: 0xFC1990 VA: 0x180FC3390
	public static Dropdown Dropdown(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC3810 Offset: 0xFC1E10 VA: 0x180FC3810
	public static RustInput Input(Translate.Phrase placeholder, string style = "Normal") { }

	// RVA: 0xFC3730 Offset: 0xFC1D30 VA: 0x180FC3730
	public static RustIcon Icon(Icons icon = 63417, string style = "Normal") { }

	// RVA: 0xFC3DD0 Offset: 0xFC23D0 VA: 0x180FC3DD0
	public static RustSlider Slider(float minValue, float maxValue, float currentValue, bool integer = False, string style = "Normal") { }

	// RVA: 0xFC3FD0 Offset: 0xFC25D0 VA: 0x180FC3FD0
	public static RustToggle Toggle(Translate.Phrase on, Translate.Phrase off, string style = "Normal") { }

	// RVA: 0xFC3020 Offset: 0xFC1620 VA: 0x180FC3020
	public static Blocker Blocker(string style = "Normal") { }

	// RVA: 0xFC3F60 Offset: 0xFC2560 VA: 0x180FC3F60
	public static RustToggle ToggleOnOff(string style = "Normal") { }

	// RVA: 0xFC3EF0 Offset: 0xFC24F0 VA: 0x180FC3EF0
	public static RustToggle ToggleEnabledDisabled(string style = "Normal") { }

	// RVA: 0xFC4240 Offset: 0xFC2840 VA: 0x180FC4240
	private static void .cctor() { }

}

public static class Make.Container // TypeDefIndex: 7050
{	// Methods

	// RVA: 0xFBE590 Offset: 0xFBCB90 VA: 0x180FBE590
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFBE430 Offset: 0xFBCA30 VA: 0x180FBE430
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFBE380 Offset: 0xFBC980 VA: 0x180FBE380
	public static RustWrapper Indent(string style = "Normal") { }

	// RVA: 0xFBE4E0 Offset: 0xFBCAE0 VA: 0x180FBE4E0
	public static TabControl TabControl(string style = "Normal") { }

	// RVA: 0xFBE640 Offset: 0xFBCC40 VA: 0x180FBE640
	public static RustLayout Vertical(string style = "Normal") { }

}

public static class Make.Form // TypeDefIndex: 7051
{	// Methods

	// RVA: 0xFC1730 Offset: 0xFBFD30 VA: 0x180FC1730
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFC1680 Offset: 0xFBFC80 VA: 0x180FC1680
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFC17E0 Offset: 0xFBFDE0 VA: 0x180FC17E0
	public static RustWrapper Vertical(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

	// RVA: 0xFC14F0 Offset: 0xFBFAF0 VA: 0x180FC14F0
	public static RustWrapper Horizontal(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

}

public static class Make.Label // TypeDefIndex: 7052
{	// Methods

	// RVA: 0xFC2B70 Offset: 0xFC1170 VA: 0x180FC2B70
	public static RustText Normal(Translate.Phrase text) { }

	// RVA: 0xFC2C90 Offset: 0xFC1290 VA: 0x180FC2C90
	public static RustText Small(Translate.Phrase text) { }

	// RVA: 0xFC2A50 Offset: 0xFC1050 VA: 0x180FC2A50
	public static RustText Large(Translate.Phrase text) { }

}


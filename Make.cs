public static class Make // TypeDefIndex: 7049
{	// Fields
	public static string PrefabRoot; // 0x0
	public static Translate.Phrase phrase_on; // 0x8
	public static Translate.Phrase phrase_off; // 0x10
	public static Translate.Phrase phrase_enabled; // 0x18
	public static Translate.Phrase phrase_disabled; // 0x20

	// Methods

	// RVA: 0xFC3210 Offset: 0xFC1810 VA: 0x180FC3210
	public static LayoutElement Flex() { }

	// RVA: 0xFC2F50 Offset: 0xFC1550 VA: 0x180FC2F50
	public static RustButton Button(Translate.Phrase label, Icons icon = 61530, bool toggle = False, string style = "Normal", bool autoSize = False) { }

	// RVA: 0xFC3700 Offset: 0xFC1D00 VA: 0x180FC3700
	public static RustButton MenuOption(Translate.Phrase label, Icons icon = 0, string style = "Normal") { }

	// RVA: 0xFC38A0 Offset: 0xFC1EA0 VA: 0x180FC38A0
	public static Menu Menu(Option[] options, Nullable<Option> selectedOption, bool AllowFiltering = False, string style = "Normal") { }

	// RVA: 0xFC3ED0 Offset: 0xFC24D0 VA: 0x180FC3ED0
	public static Video Video(string style = "Normal") { }

	// RVA: 0xFC32B0 Offset: 0xFC18B0 VA: 0x180FC32B0
	public static RustButton HeaderButton(Translate.Phrase label, Translate.Phrase subtitle, string style = "Header") { }

	// RVA: 0xFC39D0 Offset: 0xFC1FD0 VA: 0x180FC39D0
	public static RustOption Option(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC2E10 Offset: 0xFC1410 VA: 0x180FC2E10
	public static RustButtonGroup ButtonGroup(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC30D0 Offset: 0xFC16D0 VA: 0x180FC30D0
	public static Dropdown Dropdown(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFC3550 Offset: 0xFC1B50 VA: 0x180FC3550
	public static RustInput Input(Translate.Phrase placeholder, string style = "Normal") { }

	// RVA: 0xFC3470 Offset: 0xFC1A70 VA: 0x180FC3470
	public static RustIcon Icon(Icons icon = 63417, string style = "Normal") { }

	// RVA: 0xFC3B10 Offset: 0xFC2110 VA: 0x180FC3B10
	public static RustSlider Slider(float minValue, float maxValue, float currentValue, bool integer = False, string style = "Normal") { }

	// RVA: 0xFC3D10 Offset: 0xFC2310 VA: 0x180FC3D10
	public static RustToggle Toggle(Translate.Phrase on, Translate.Phrase off, string style = "Normal") { }

	// RVA: 0xFC2D60 Offset: 0xFC1360 VA: 0x180FC2D60
	public static Blocker Blocker(string style = "Normal") { }

	// RVA: 0xFC3CA0 Offset: 0xFC22A0 VA: 0x180FC3CA0
	public static RustToggle ToggleOnOff(string style = "Normal") { }

	// RVA: 0xFC3C30 Offset: 0xFC2230 VA: 0x180FC3C30
	public static RustToggle ToggleEnabledDisabled(string style = "Normal") { }

	// RVA: 0xFC3F80 Offset: 0xFC2580 VA: 0x180FC3F80
	private static void .cctor() { }

}

public static class Make.Container // TypeDefIndex: 7050
{	// Methods

	// RVA: 0xFBE2D0 Offset: 0xFBC8D0 VA: 0x180FBE2D0
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFBE170 Offset: 0xFBC770 VA: 0x180FBE170
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFBE0C0 Offset: 0xFBC6C0 VA: 0x180FBE0C0
	public static RustWrapper Indent(string style = "Normal") { }

	// RVA: 0xFBE220 Offset: 0xFBC820 VA: 0x180FBE220
	public static TabControl TabControl(string style = "Normal") { }

	// RVA: 0xFBE380 Offset: 0xFBC980 VA: 0x180FBE380
	public static RustLayout Vertical(string style = "Normal") { }

}

public static class Make.Form // TypeDefIndex: 7051
{	// Methods

	// RVA: 0xFC1470 Offset: 0xFBFA70 VA: 0x180FC1470
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFC13C0 Offset: 0xFBF9C0 VA: 0x180FC13C0
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFC1520 Offset: 0xFBFB20 VA: 0x180FC1520
	public static RustWrapper Vertical(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

	// RVA: 0xFC1230 Offset: 0xFBF830 VA: 0x180FC1230
	public static RustWrapper Horizontal(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

}

public static class Make.Label // TypeDefIndex: 7052
{	// Methods

	// RVA: 0xFC28B0 Offset: 0xFC0EB0 VA: 0x180FC28B0
	public static RustText Normal(Translate.Phrase text) { }

	// RVA: 0xFC29D0 Offset: 0xFC0FD0 VA: 0x180FC29D0
	public static RustText Small(Translate.Phrase text) { }

	// RVA: 0xFC2790 Offset: 0xFC0D90 VA: 0x180FC2790
	public static RustText Large(Translate.Phrase text) { }

}


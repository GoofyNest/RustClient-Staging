internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3559
{	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14

}

public class TouchScreenKeyboard // TypeDefIndex: 3560
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public static bool isSupported { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCE0B0 Offset: 0xCD4B0 VA: 0x1800CE0B0
	// RVA: 0x217CF50 Offset: 0x217B550 VA: 0x18217CF50
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x217CD50 Offset: 0x217B350 VA: 0x18217CD50
	private void Destroy() { }

	// RVA: 0x217CDF0 Offset: 0x217B3F0 VA: 0x18217CDF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x217D2F0 Offset: 0x217B8F0 VA: 0x18217D2F0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE1E0 Offset: 0xCD5E0 VA: 0x1800CE1E0
	// RVA: 0x217D290 Offset: 0x217B890 VA: 0x18217D290
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x217D4E0 Offset: 0x217BAE0 VA: 0x18217D4E0
	public static bool get_isSupported() { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x217D100 Offset: 0x217B700 VA: 0x18217D100
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217CF90 Offset: 0x217B590 VA: 0x18217CF90
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFC20 Offset: 0xCF020 VA: 0x1800CFC20
	// RVA: 0x217D5C0 Offset: 0x217BBC0 VA: 0x18217D5C0
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	// RVA: 0x217D7C0 Offset: 0x217BDC0 VA: 0x18217D7C0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD0040 Offset: 0xCF440 VA: 0x1800D0040
	// RVA: 0x217D690 Offset: 0x217BC90 VA: 0x18217D690
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD00A0 Offset: 0xCF4A0 VA: 0x1800D00A0
	// RVA: 0x217D420 Offset: 0x217BA20 VA: 0x18217D420
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0190 Offset: 0xCF590 VA: 0x1800D0190
	// RVA: 0x217D600 Offset: 0x217BC00 VA: 0x18217D600
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0290 Offset: 0xCF690 VA: 0x1800D0290
	// RVA: 0x217D580 Offset: 0x217BB80 VA: 0x18217D580
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD04C0 Offset: 0xCF8C0 VA: 0x1800D04C0
	// RVA: 0x217D650 Offset: 0x217BC50 VA: 0x18217D650
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD04F0 Offset: 0xCF8F0 VA: 0x1800D04F0
	// RVA: 0x217D460 Offset: 0x217BA60 VA: 0x18217D460
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0550 Offset: 0xCF950 VA: 0x1800D0550
	// RVA: 0x217D4A0 Offset: 0x217BAA0 VA: 0x18217D4A0
	public bool get_canSetSelection() { }

	// RVA: 0x217D530 Offset: 0x217BB30 VA: 0x18217D530
	public RangeInt get_selection() { }

	// RVA: 0x217D6D0 Offset: 0x217BCD0 VA: 0x18217D6D0
	public void set_selection(RangeInt value) { }

	// RVA: 0x217CF00 Offset: 0x217B500 VA: 0x18217CF00
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x217D250 Offset: 0x217B850 VA: 0x18217D250
	private static void SetSelection(int start, int length) { }

}

public enum TouchScreenKeyboard.Status // TypeDefIndex: 3561
{	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;

}


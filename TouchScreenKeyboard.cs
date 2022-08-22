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
	// RVA: 0x217D770 Offset: 0x217BD70 VA: 0x18217D770
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x217D570 Offset: 0x217BB70 VA: 0x18217D570
	private void Destroy() { }

	// RVA: 0x217D610 Offset: 0x217BC10 VA: 0x18217D610 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x217DB10 Offset: 0x217C110 VA: 0x18217DB10
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE1E0 Offset: 0xCD5E0 VA: 0x1800CE1E0
	// RVA: 0x217DAB0 Offset: 0x217C0B0 VA: 0x18217DAB0
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x217DD00 Offset: 0x217C300 VA: 0x18217DD00
	public static bool get_isSupported() { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x217D920 Offset: 0x217BF20 VA: 0x18217D920
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217D7B0 Offset: 0x217BDB0 VA: 0x18217D7B0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFC20 Offset: 0xCF020 VA: 0x1800CFC20
	// RVA: 0x217DDE0 Offset: 0x217C3E0 VA: 0x18217DDE0
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	// RVA: 0x217DFE0 Offset: 0x217C5E0 VA: 0x18217DFE0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD0040 Offset: 0xCF440 VA: 0x1800D0040
	// RVA: 0x217DEB0 Offset: 0x217C4B0 VA: 0x18217DEB0
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD00A0 Offset: 0xCF4A0 VA: 0x1800D00A0
	// RVA: 0x217DC40 Offset: 0x217C240 VA: 0x18217DC40
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0190 Offset: 0xCF590 VA: 0x1800D0190
	// RVA: 0x217DE20 Offset: 0x217C420 VA: 0x18217DE20
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0290 Offset: 0xCF690 VA: 0x1800D0290
	// RVA: 0x217DDA0 Offset: 0x217C3A0 VA: 0x18217DDA0
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD04C0 Offset: 0xCF8C0 VA: 0x1800D04C0
	// RVA: 0x217DE70 Offset: 0x217C470 VA: 0x18217DE70
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD04F0 Offset: 0xCF8F0 VA: 0x1800D04F0
	// RVA: 0x217DC80 Offset: 0x217C280 VA: 0x18217DC80
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0550 Offset: 0xCF950 VA: 0x1800D0550
	// RVA: 0x217DCC0 Offset: 0x217C2C0 VA: 0x18217DCC0
	public bool get_canSetSelection() { }

	// RVA: 0x217DD50 Offset: 0x217C350 VA: 0x18217DD50
	public RangeInt get_selection() { }

	// RVA: 0x217DEF0 Offset: 0x217C4F0 VA: 0x18217DEF0
	public void set_selection(RangeInt value) { }

	// RVA: 0x217D720 Offset: 0x217BD20 VA: 0x18217D720
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x217DA70 Offset: 0x217C070 VA: 0x18217DA70
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


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
	// RVA: 0x217CC90 Offset: 0x217B290 VA: 0x18217CC90
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x217CA90 Offset: 0x217B090 VA: 0x18217CA90
	private void Destroy() { }

	// RVA: 0x217CB30 Offset: 0x217B130 VA: 0x18217CB30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x217D030 Offset: 0x217B630 VA: 0x18217D030
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE1E0 Offset: 0xCD5E0 VA: 0x1800CE1E0
	// RVA: 0x217CFD0 Offset: 0x217B5D0 VA: 0x18217CFD0
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x217D220 Offset: 0x217B820 VA: 0x18217D220
	public static bool get_isSupported() { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x217CE40 Offset: 0x217B440 VA: 0x18217CE40
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x217CCD0 Offset: 0x217B2D0 VA: 0x18217CCD0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFC20 Offset: 0xCF020 VA: 0x1800CFC20
	// RVA: 0x217D300 Offset: 0x217B900 VA: 0x18217D300
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	// RVA: 0x217D500 Offset: 0x217BB00 VA: 0x18217D500
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD0040 Offset: 0xCF440 VA: 0x1800D0040
	// RVA: 0x217D3D0 Offset: 0x217B9D0 VA: 0x18217D3D0
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD00A0 Offset: 0xCF4A0 VA: 0x1800D00A0
	// RVA: 0x217D160 Offset: 0x217B760 VA: 0x18217D160
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0190 Offset: 0xCF590 VA: 0x1800D0190
	// RVA: 0x217D340 Offset: 0x217B940 VA: 0x18217D340
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0290 Offset: 0xCF690 VA: 0x1800D0290
	// RVA: 0x217D2C0 Offset: 0x217B8C0 VA: 0x18217D2C0
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD04C0 Offset: 0xCF8C0 VA: 0x1800D04C0
	// RVA: 0x217D390 Offset: 0x217B990 VA: 0x18217D390
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD04F0 Offset: 0xCF8F0 VA: 0x1800D04F0
	// RVA: 0x217D1A0 Offset: 0x217B7A0 VA: 0x18217D1A0
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0550 Offset: 0xCF950 VA: 0x1800D0550
	// RVA: 0x217D1E0 Offset: 0x217B7E0 VA: 0x18217D1E0
	public bool get_canSetSelection() { }

	// RVA: 0x217D270 Offset: 0x217B870 VA: 0x18217D270
	public RangeInt get_selection() { }

	// RVA: 0x217D410 Offset: 0x217BA10 VA: 0x18217D410
	public void set_selection(RangeInt value) { }

	// RVA: 0x217CC40 Offset: 0x217B240 VA: 0x18217CC40
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x217CF90 Offset: 0x217B590 VA: 0x18217CF90
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


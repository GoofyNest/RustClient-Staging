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

	[FreeFunctionAttribute] // RVA: 0xCE020 Offset: 0xCD420 VA: 0x1800CE020
	// RVA: 0x217CE50 Offset: 0x217B450 VA: 0x18217CE50
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x217CC50 Offset: 0x217B250 VA: 0x18217CC50
	private void Destroy() { }

	// RVA: 0x217CCF0 Offset: 0x217B2F0 VA: 0x18217CCF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x217D1F0 Offset: 0x217B7F0 VA: 0x18217D1F0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE150 Offset: 0xCD550 VA: 0x1800CE150
	// RVA: 0x217D190 Offset: 0x217B790 VA: 0x18217D190
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x217D3E0 Offset: 0x217B9E0 VA: 0x18217D3E0
	public static bool get_isSupported() { }

	// RVA: 0x48D660 Offset: 0x48BC60 VA: 0x18048D660
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x217D000 Offset: 0x217B600 VA: 0x18217D000
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x217CE90 Offset: 0x217B490 VA: 0x18217CE90
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFB90 Offset: 0xCEF90 VA: 0x1800CFB90
	// RVA: 0x217D4C0 Offset: 0x217BAC0 VA: 0x18217D4C0
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFE30 Offset: 0xCF230 VA: 0x1800CFE30
	// RVA: 0x217D6C0 Offset: 0x217BCC0 VA: 0x18217D6C0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xCFFE0 Offset: 0xCF3E0 VA: 0x1800CFFE0
	// RVA: 0x217D590 Offset: 0x217BB90 VA: 0x18217D590
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0050 Offset: 0xCF450 VA: 0x1800D0050
	// RVA: 0x217D320 Offset: 0x217B920 VA: 0x18217D320
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0100 Offset: 0xCF500 VA: 0x1800D0100
	// RVA: 0x217D500 Offset: 0x217BB00 VA: 0x18217D500
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0200 Offset: 0xCF600 VA: 0x1800D0200
	// RVA: 0x217D480 Offset: 0x217BA80 VA: 0x18217D480
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD0430 Offset: 0xCF830 VA: 0x1800D0430
	// RVA: 0x217D550 Offset: 0x217BB50 VA: 0x18217D550
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD0460 Offset: 0xCF860 VA: 0x1800D0460
	// RVA: 0x217D360 Offset: 0x217B960 VA: 0x18217D360
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD04C0 Offset: 0xCF8C0 VA: 0x1800D04C0
	// RVA: 0x217D3A0 Offset: 0x217B9A0 VA: 0x18217D3A0
	public bool get_canSetSelection() { }

	// RVA: 0x217D430 Offset: 0x217BA30 VA: 0x18217D430
	public RangeInt get_selection() { }

	// RVA: 0x217D5D0 Offset: 0x217BBD0 VA: 0x18217D5D0
	public void set_selection(RangeInt value) { }

	// RVA: 0x217CE00 Offset: 0x217B400 VA: 0x18217CE00
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x217D150 Offset: 0x217B750 VA: 0x18217D150
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


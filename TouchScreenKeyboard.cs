internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3559
{	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14

}

public class TouchScreenKeyboard // TypeDefIndex: 3560
{	internal IntPtr m_Ptr; // 0x10

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


	[FreeFunctionAttribute] // RVA: 0xCE140 Offset: 0xCD540 VA: 0x1800CE140
	private static void Internal_Destroy(IntPtr ptr) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE280 Offset: 0xCD680 VA: 0x1800CE280
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	public static bool get_isSupported() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFD50 Offset: 0xCF150 VA: 0x1800CFD50
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFFB0 Offset: 0xCF3B0 VA: 0x1800CFFB0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD0130 Offset: 0xCF530 VA: 0x1800D0130
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD01A0 Offset: 0xCF5A0 VA: 0x1800D01A0
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0250 Offset: 0xCF650 VA: 0x1800D0250
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0380 Offset: 0xCF780 VA: 0x1800D0380
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD05F0 Offset: 0xCF9F0 VA: 0x1800D05F0
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD0620 Offset: 0xCFA20 VA: 0x1800D0620
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0680 Offset: 0xCFA80 VA: 0x1800D0680
	public bool get_canSetSelection() { }

	public RangeInt get_selection() { }

	public void set_selection(RangeInt value) { }

	private static void GetSelection(out int start, out int length) { }

	private static void SetSelection(int start, int length) { }

}

public enum TouchScreenKeyboard.Status // TypeDefIndex: 3561
{	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;

}


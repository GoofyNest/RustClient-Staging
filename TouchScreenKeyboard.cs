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


	[FreeFunctionAttribute] // RVA: 0xCE0B0 Offset: 0xCD4B0 VA: 0x1800CE0B0
	private static void Internal_Destroy(IntPtr ptr) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE1E0 Offset: 0xCD5E0 VA: 0x1800CE1E0
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	public static bool get_isSupported() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFC20 Offset: 0xCF020 VA: 0x1800CFC20
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xD0040 Offset: 0xCF440 VA: 0x1800D0040
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xD00A0 Offset: 0xCF4A0 VA: 0x1800D00A0
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xD0190 Offset: 0xCF590 VA: 0x1800D0190
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0290 Offset: 0xCF690 VA: 0x1800D0290
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD04C0 Offset: 0xCF8C0 VA: 0x1800D04C0
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD04F0 Offset: 0xCF8F0 VA: 0x1800D04F0
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0550 Offset: 0xCF950 VA: 0x1800D0550
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


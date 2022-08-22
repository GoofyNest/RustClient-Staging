public sealed class Font : Object // TypeDefIndex: 3959
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230A690 Offset: 0x2308C90 VA: 0x18230A690
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230A800 Offset: 0x2308E00 VA: 0x18230A800
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x230A7C0 Offset: 0x2308DC0 VA: 0x18230A7C0
	public Material get_material() { }

	// RVA: 0x230A740 Offset: 0x2308D40 VA: 0x18230A740
	public bool get_dynamic() { }

	// RVA: 0x230A780 Offset: 0x2308D80 VA: 0x18230A780
	public int get_fontSize() { }

	// RVA: 0x230A610 Offset: 0x2308C10 VA: 0x18230A610
	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230A5A0 Offset: 0x2308BA0 VA: 0x18230A5A0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x230A4C0 Offset: 0x2308AC0 VA: 0x18230A4C0
	public bool HasCharacter(char c) { }

	// RVA: 0x230A510 Offset: 0x2308B10 VA: 0x18230A510
	private bool HasCharacter(int c) { }

	// RVA: 0x230A550 Offset: 0x2308B50 VA: 0x18230A550
	private static void Internal_CreateFont(Font self, string name) { }

}

public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 3960
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1464520 Offset: 0x1462B20 VA: 0x181464520 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}


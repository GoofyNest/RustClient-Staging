public sealed class Font : Object // TypeDefIndex: 3959
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230A850 Offset: 0x2308E50 VA: 0x18230A850
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230A9C0 Offset: 0x2308FC0 VA: 0x18230A9C0
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x230A980 Offset: 0x2308F80 VA: 0x18230A980
	public Material get_material() { }

	// RVA: 0x230A900 Offset: 0x2308F00 VA: 0x18230A900
	public bool get_dynamic() { }

	// RVA: 0x230A940 Offset: 0x2308F40 VA: 0x18230A940
	public int get_fontSize() { }

	// RVA: 0x230A7D0 Offset: 0x2308DD0 VA: 0x18230A7D0
	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230A760 Offset: 0x2308D60 VA: 0x18230A760
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x230A680 Offset: 0x2308C80 VA: 0x18230A680
	public bool HasCharacter(char c) { }

	// RVA: 0x230A6D0 Offset: 0x2308CD0 VA: 0x18230A6D0
	private bool HasCharacter(int c) { }

	// RVA: 0x230A710 Offset: 0x2308D10 VA: 0x18230A710
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


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
	// RVA: 0x230B170 Offset: 0x2309770 VA: 0x18230B170
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230B2E0 Offset: 0x23098E0 VA: 0x18230B2E0
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x230B2A0 Offset: 0x23098A0 VA: 0x18230B2A0
	public Material get_material() { }

	// RVA: 0x230B220 Offset: 0x2309820 VA: 0x18230B220
	public bool get_dynamic() { }

	// RVA: 0x230B260 Offset: 0x2309860 VA: 0x18230B260
	public int get_fontSize() { }

	// RVA: 0x230B0F0 Offset: 0x23096F0 VA: 0x18230B0F0
	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230B080 Offset: 0x2309680 VA: 0x18230B080
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x230AFA0 Offset: 0x23095A0 VA: 0x18230AFA0
	public bool HasCharacter(char c) { }

	// RVA: 0x230AFF0 Offset: 0x23095F0 VA: 0x18230AFF0
	private bool HasCharacter(int c) { }

	// RVA: 0x230B030 Offset: 0x2309630 VA: 0x18230B030
	private static void Internal_CreateFont(Font self, string name) { }

}

public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 3960
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14638B0 Offset: 0x1461EB0 VA: 0x1814638B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}


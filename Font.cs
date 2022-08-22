public sealed class Font : Object // TypeDefIndex: 3959
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void remove_textureRebuilt(Action<Font> value) { }

	public Material get_material() { }

	public bool get_dynamic() { }

	public int get_fontSize() { }

	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	public bool HasCharacter(char c) { }

	private bool HasCharacter(int c) { }

	private static void Internal_CreateFont(Font self, string name) { }

}

public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 3960
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}


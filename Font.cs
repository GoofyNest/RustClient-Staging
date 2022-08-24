public sealed class Font : Object // TypeDefIndex: 3959
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void remove_textureRebuilt(Action<Font> value) { }

	public Material get_material() { }

	public bool get_dynamic() { }

	public int get_fontSize() { }

	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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


public sealed class GUIStyleState // TypeDefIndex: 4047
{	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	[NativePropertyAttribute] // RVA: 0xD1EF0 Offset: 0xD12F0 VA: 0x1800D1EF0
	public Color textColor { get; set; }


	public Color get_textColor() { }

	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1DA0 Offset: 0xD11A0 VA: 0x1800D1DA0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1EB0 Offset: 0xD12B0 VA: 0x1800D1EB0
	private void Cleanup() { }

	public void .ctor() { }

	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	protected override void Finalize() { }

	private void get_textColor_Injected(out Color ret) { }

	private void set_textColor_Injected(ref Color value) { }

}


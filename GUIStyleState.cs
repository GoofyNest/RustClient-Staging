public sealed class GUIStyleState // TypeDefIndex: 4047
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xD1EA0 Offset: 0xD12A0 VA: 0x1800D1EA0
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x1A79620 Offset: 0x1A77C20 VA: 0x181A79620
	public Color get_textColor() { }

	// RVA: 0x1A796C0 Offset: 0x1A77CC0 VA: 0x181A796C0
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1CB0 Offset: 0xD10B0 VA: 0x1800D1CB0
	// RVA: 0x1A79560 Offset: 0x1A77B60 VA: 0x181A79560
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1E10 Offset: 0xD1210 VA: 0x1800D1E10
	// RVA: 0x1A793E0 Offset: 0x1A779E0 VA: 0x181A793E0
	private void Cleanup() { }

	// RVA: 0x1A79590 Offset: 0x1A77B90 VA: 0x181A79590
	public void .ctor() { }

	// RVA: 0x19ABAB0 Offset: 0x19AA0B0 VA: 0x1819ABAB0
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A794F0 Offset: 0x1A77AF0 VA: 0x181A794F0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A79420 Offset: 0x1A77A20 VA: 0x181A79420 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A795D0 Offset: 0x1A77BD0 VA: 0x181A795D0
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x1A79670 Offset: 0x1A77C70 VA: 0x181A79670
	private void set_textColor_Injected(ref Color value) { }

}


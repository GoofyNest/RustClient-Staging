public sealed class GUIStyleState // TypeDefIndex: 4047
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xD1E10 Offset: 0xD1210 VA: 0x1800D1E10
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x1A79660 Offset: 0x1A77C60 VA: 0x181A79660
	public Color get_textColor() { }

	// RVA: 0x1A79700 Offset: 0x1A77D00 VA: 0x181A79700
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1C70 Offset: 0xD1070 VA: 0x1800D1C70
	// RVA: 0x1A795A0 Offset: 0x1A77BA0 VA: 0x181A795A0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1D80 Offset: 0xD1180 VA: 0x1800D1D80
	// RVA: 0x1A79420 Offset: 0x1A77A20 VA: 0x181A79420
	private void Cleanup() { }

	// RVA: 0x1A795D0 Offset: 0x1A77BD0 VA: 0x181A795D0
	public void .ctor() { }

	// RVA: 0x19ABAF0 Offset: 0x19AA0F0 VA: 0x1819ABAF0
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A79530 Offset: 0x1A77B30 VA: 0x181A79530
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A79460 Offset: 0x1A77A60 VA: 0x181A79460 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A79610 Offset: 0x1A77C10 VA: 0x181A79610
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x1A796B0 Offset: 0x1A77CB0 VA: 0x181A796B0
	private void set_textColor_Injected(ref Color value) { }

}


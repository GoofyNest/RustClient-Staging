public sealed class GUIStyleState // TypeDefIndex: 4047
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xD1EA0 Offset: 0xD12A0 VA: 0x1800D1EA0
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x1A798E0 Offset: 0x1A77EE0 VA: 0x181A798E0
	public Color get_textColor() { }

	// RVA: 0x1A79980 Offset: 0x1A77F80 VA: 0x181A79980
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1CB0 Offset: 0xD10B0 VA: 0x1800D1CB0
	// RVA: 0x1A79820 Offset: 0x1A77E20 VA: 0x181A79820
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1E10 Offset: 0xD1210 VA: 0x1800D1E10
	// RVA: 0x1A796A0 Offset: 0x1A77CA0 VA: 0x181A796A0
	private void Cleanup() { }

	// RVA: 0x1A79850 Offset: 0x1A77E50 VA: 0x181A79850
	public void .ctor() { }

	// RVA: 0x19ABD70 Offset: 0x19AA370 VA: 0x1819ABD70
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A797B0 Offset: 0x1A77DB0 VA: 0x181A797B0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A796E0 Offset: 0x1A77CE0 VA: 0x181A796E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A79890 Offset: 0x1A77E90 VA: 0x181A79890
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x1A79930 Offset: 0x1A77F30 VA: 0x181A79930
	private void set_textColor_Injected(ref Color value) { }

}


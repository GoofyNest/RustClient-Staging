public sealed class GUIStyleState // TypeDefIndex: 4047
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xD1EA0 Offset: 0xD12A0 VA: 0x1800D1EA0
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x1A65E10 Offset: 0x1A64410 VA: 0x181A65E10
	public Color get_textColor() { }

	// RVA: 0x1A65EB0 Offset: 0x1A644B0 VA: 0x181A65EB0
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1CB0 Offset: 0xD10B0 VA: 0x1800D1CB0
	// RVA: 0x1A65D50 Offset: 0x1A64350 VA: 0x181A65D50
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1E10 Offset: 0xD1210 VA: 0x1800D1E10
	// RVA: 0x1A65BD0 Offset: 0x1A641D0 VA: 0x181A65BD0
	private void Cleanup() { }

	// RVA: 0x1A65D80 Offset: 0x1A64380 VA: 0x181A65D80
	public void .ctor() { }

	// RVA: 0x1999170 Offset: 0x1997770 VA: 0x181999170
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A65CE0 Offset: 0x1A642E0 VA: 0x181A65CE0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A65C10 Offset: 0x1A64210 VA: 0x181A65C10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A65DC0 Offset: 0x1A643C0 VA: 0x181A65DC0
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x1A65E60 Offset: 0x1A64460 VA: 0x181A65E60
	private void set_textColor_Injected(ref Color value) { }

}


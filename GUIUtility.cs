public class GUIUtility // TypeDefIndex: 4051
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xD6810 Offset: 0xD5C10 VA: 0x1800D6810
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xD69C0 Offset: 0xD5DC0 VA: 0x1800D69C0
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xD6B20 Offset: 0xD5F20 VA: 0x1800D6B20
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xD6C20 Offset: 0xD6020 VA: 0x1800D6C20
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xD6E30 Offset: 0xD6230 VA: 0x1800D6E30
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xD7110 Offset: 0xD6510 VA: 0x1800D7110
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xD7270 Offset: 0xD6670 VA: 0x1800D7270
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xD7390 Offset: 0xD6790 VA: 0x1800D7390
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	// Properties
	[NativePropertyAttribute] // RVA: 0xDAF80 Offset: 0xDA380 VA: 0x1800DAF80
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xDB030 Offset: 0xDA430 VA: 0x1800DB030
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xDB200 Offset: 0xDA600 VA: 0x1800DB200
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xDB340 Offset: 0xDA740 VA: 0x1800DB340
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDB420 Offset: 0xDA820 VA: 0x1800DB420
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xDB420 Offset: 0xDA820 VA: 0x1800DB420
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xD75D0 Offset: 0xD69D0 VA: 0x1800D75D0
	// RVA: 0x1A7DCC0 Offset: 0x1A7C2C0 VA: 0x181A7DCC0
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD76A0 Offset: 0xD6AA0 VA: 0x1800D76A0
	// RVA: 0x1A7DC90 Offset: 0x1A7C290 VA: 0x181A7DC90
	internal static int get_guiDepth() { }

	// RVA: 0x1A7DDE0 Offset: 0x1A7C3E0 VA: 0x181A7DDE0
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1A7DE60 Offset: 0x1A7C460 VA: 0x181A7DE60
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8B30 Offset: 0xD7F30 VA: 0x1800D8B30
	// RVA: 0x1A7DCF0 Offset: 0x1A7C2F0 VA: 0x181A7DCF0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8BB0 Offset: 0xD7FB0 VA: 0x1800D8BB0
	// RVA: 0x1A7DE20 Offset: 0x1A7C420 VA: 0x181A7DE20
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8C30 Offset: 0xD8030 VA: 0x1800D8C30
	// RVA: 0x1A7CDE0 Offset: 0x1A7B3E0 VA: 0x181A7CDE0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8E00 Offset: 0xD8200 VA: 0x1800D8E00
	// RVA: 0x1A7C510 Offset: 0x1A7AB10 VA: 0x181A7C510
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD90C0 Offset: 0xD84C0 VA: 0x1800D90C0
	// RVA: 0x1A7C550 Offset: 0x1A7AB50 VA: 0x181A7C550
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD92E0 Offset: 0xD86E0 VA: 0x1800D92E0
	// RVA: 0x1A7D360 Offset: 0x1A7B960 VA: 0x181A7D360
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9310 Offset: 0xD8710 VA: 0x1800D9310
	// RVA: 0x1A7C720 Offset: 0x1A7AD20 VA: 0x181A7C720
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD95B0 Offset: 0xD89B0 VA: 0x1800D95B0
	// RVA: 0x1A7DBB0 Offset: 0x1A7C1B0 VA: 0x181A7DBB0
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9800 Offset: 0xD8C00 VA: 0x1800D9800
	// RVA: 0x1A7DBE0 Offset: 0x1A7C1E0 VA: 0x181A7DBE0
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9AB0 Offset: 0xD8EB0 VA: 0x1800D9AB0
	// RVA: 0x1A7D000 Offset: 0x1A7B600 VA: 0x181A7D000
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D20 Offset: 0xD9120 VA: 0x1800D9D20
	// RVA: 0x1A7D5B0 Offset: 0x1A7BBB0 VA: 0x181A7D5B0
	internal static bool OwnsId(int id) { }

	// RVA: 0x1A7C430 Offset: 0x1A7AA30 VA: 0x181A7C430
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9E70 Offset: 0xD9270 VA: 0x1800D9E70
	// RVA: 0x1A7DC60 Offset: 0x1A7C260 VA: 0x181A7DC60
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9F70 Offset: 0xD9370 VA: 0x1800D9F70
	// RVA: 0x1A7DD60 Offset: 0x1A7C360 VA: 0x181A7DD60
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A7D400 Offset: 0x1A7BA00 VA: 0x181A7D400
	private static int Internal_GetHotControl() { }

	// RVA: 0x1A7D430 Offset: 0x1A7BA30 VA: 0x181A7D430
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x1A7D460 Offset: 0x1A7BA60 VA: 0x181A7D460
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1A7D4A0 Offset: 0x1A7BAA0 VA: 0x181A7D4A0
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1A7D3C0 Offset: 0x1A7B9C0 VA: 0x181A7D3C0
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1A7D390 Offset: 0x1A7B990 VA: 0x181A7D390
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7D560 Offset: 0x1A7BB60 VA: 0x181A7D560
	private static void MarkGUIChanged() { }

	// RVA: 0x1A7CD90 Offset: 0x1A7B390 VA: 0x181A7CD90
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1A7CD30 Offset: 0x1A7B330 VA: 0x181A7CD30
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1A7CEB0 Offset: 0x1A7B4B0 VA: 0x181A7CEB0
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7DDA0 Offset: 0x1A7C3A0 VA: 0x181A7DDA0
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1A7D400 Offset: 0x1A7BA00 VA: 0x181A7D400
	public static int get_hotControl() { }

	// RVA: 0x1A7D460 Offset: 0x1A7BA60 VA: 0x181A7D460
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7DC10 Offset: 0x1A7C210 VA: 0x181A7DC10
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7D660 Offset: 0x1A7BC60 VA: 0x181A7D660
	internal static void RemoveCapture() { }

	// RVA: 0x1A7D430 Offset: 0x1A7BA30 VA: 0x181A7D430
	public static int get_keyboardControl() { }

	// RVA: 0x1A7D4A0 Offset: 0x1A7BAA0 VA: 0x181A7D4A0
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1A7D030 Offset: 0x1A7B630 VA: 0x181A7D030
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1A7CC90 Offset: 0x1A7B290 VA: 0x181A7CC90
	public static void ExitGUI() { }

	// RVA: 0x1A7CE30 Offset: 0x1A7B430 VA: 0x181A7CE30
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7D5F0 Offset: 0x1A7BBF0 VA: 0x181A7D5F0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA520 Offset: 0xD9920 VA: 0x1800DA520
	// RVA: 0x1A7C850 Offset: 0x1A7AE50 VA: 0x181A7C850
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7C590 Offset: 0x1A7AB90 VA: 0x181A7C590
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7C940 Offset: 0x1A7AF40 VA: 0x181A7C940
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7C8A0 Offset: 0x1A7AEA0 VA: 0x181A7C8A0
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A7C7F0 Offset: 0x1A7ADF0 VA: 0x181A7C7F0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAA40 Offset: 0xD9E40 VA: 0x1800DAA40
	// RVA: 0x1A7D6B0 Offset: 0x1A7BCB0 VA: 0x181A7D6B0
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB00 Offset: 0xD9F00 VA: 0x1800DAB00
	// RVA: 0x1A7D4E0 Offset: 0x1A7BAE0 VA: 0x181A7D4E0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAC70 Offset: 0xDA070 VA: 0x1800DAC70
	// RVA: 0x1A7D4E0 Offset: 0x1A7BAE0 VA: 0x181A7D4E0
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1A7C760 Offset: 0x1A7AD60 VA: 0x181A7C760
	internal static void CheckOnGUI() { }

	// RVA: 0x1A7D7C0 Offset: 0x1A7BDC0 VA: 0x181A7D7C0
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x1A7C4A0 Offset: 0x1A7AAA0 VA: 0x181A7C4A0
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1A7D0C0 Offset: 0x1A7B6C0 VA: 0x181A7D0C0
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1A7D160 Offset: 0x1A7B760 VA: 0x181A7D160
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1A7D210 Offset: 0x1A7B810 VA: 0x181A7D210
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1A7CCE0 Offset: 0x1A7B2E0 VA: 0x181A7CCE0
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x1A7C3C0 Offset: 0x1A7A9C0 VA: 0x181A7C3C0
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x1A7DD20 Offset: 0x1A7C320 VA: 0x181A7DD20
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}


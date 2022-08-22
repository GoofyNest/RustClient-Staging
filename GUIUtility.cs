public class GUIUtility // TypeDefIndex: 4051
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xD6880 Offset: 0xD5C80 VA: 0x1800D6880
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xD6BC0 Offset: 0xD5FC0 VA: 0x1800D6BC0
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xD6C90 Offset: 0xD6090 VA: 0x1800D6C90
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xD6EC0 Offset: 0xD62C0 VA: 0x1800D6EC0
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xD7120 Offset: 0xD6520 VA: 0x1800D7120
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xD72E0 Offset: 0xD66E0 VA: 0x1800D72E0
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xD7400 Offset: 0xD6800 VA: 0x1800D7400
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	// Properties
	[NativePropertyAttribute] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xDB060 Offset: 0xDA460 VA: 0x1800DB060
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xDB270 Offset: 0xDA670 VA: 0x1800DB270
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xDB360 Offset: 0xDA760 VA: 0x1800DB360
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDB490 Offset: 0xDA890 VA: 0x1800DB490
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xDB490 Offset: 0xDA890 VA: 0x1800DB490
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0xD7640 Offset: 0xD6A40 VA: 0x1800D7640
	// RVA: 0x1A7DF40 Offset: 0x1A7C540 VA: 0x181A7DF40
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7710 Offset: 0xD6B10 VA: 0x1800D7710
	// RVA: 0x1A7DF10 Offset: 0x1A7C510 VA: 0x181A7DF10
	internal static int get_guiDepth() { }

	// RVA: 0x1A7E060 Offset: 0x1A7C660 VA: 0x181A7E060
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1A7E0E0 Offset: 0x1A7C6E0 VA: 0x181A7E0E0
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8BA0 Offset: 0xD7FA0 VA: 0x1800D8BA0
	// RVA: 0x1A7DF70 Offset: 0x1A7C570 VA: 0x181A7DF70
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8C40 Offset: 0xD8040 VA: 0x1800D8C40
	// RVA: 0x1A7E0A0 Offset: 0x1A7C6A0 VA: 0x181A7E0A0
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8CA0 Offset: 0xD80A0 VA: 0x1800D8CA0
	// RVA: 0x1A7D060 Offset: 0x1A7B660 VA: 0x181A7D060
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8EB0 Offset: 0xD82B0 VA: 0x1800D8EB0
	// RVA: 0x1A7C790 Offset: 0x1A7AD90 VA: 0x181A7C790
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	// RVA: 0x1A7C7D0 Offset: 0x1A7ADD0 VA: 0x181A7C7D0
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9350 Offset: 0xD8750 VA: 0x1800D9350
	// RVA: 0x1A7D5E0 Offset: 0x1A7BBE0 VA: 0x181A7D5E0
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9380 Offset: 0xD8780 VA: 0x1800D9380
	// RVA: 0x1A7C9A0 Offset: 0x1A7AFA0 VA: 0x181A7C9A0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9610 Offset: 0xD8A10 VA: 0x1800D9610
	// RVA: 0x1A7DE30 Offset: 0x1A7C430 VA: 0x181A7DE30
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9870 Offset: 0xD8C70 VA: 0x1800D9870
	// RVA: 0x1A7DE60 Offset: 0x1A7C460 VA: 0x181A7DE60
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9AC0 Offset: 0xD8EC0 VA: 0x1800D9AC0
	// RVA: 0x1A7D280 Offset: 0x1A7B880 VA: 0x181A7D280
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D90 Offset: 0xD9190 VA: 0x1800D9D90
	// RVA: 0x1A7D830 Offset: 0x1A7BE30 VA: 0x181A7D830
	internal static bool OwnsId(int id) { }

	// RVA: 0x1A7C6B0 Offset: 0x1A7ACB0 VA: 0x181A7C6B0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9F30 Offset: 0xD9330 VA: 0x1800D9F30
	// RVA: 0x1A7DEE0 Offset: 0x1A7C4E0 VA: 0x181A7DEE0
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9FE0 Offset: 0xD93E0 VA: 0x1800D9FE0
	// RVA: 0x1A7DFE0 Offset: 0x1A7C5E0 VA: 0x181A7DFE0
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A7D680 Offset: 0x1A7BC80 VA: 0x181A7D680
	private static int Internal_GetHotControl() { }

	// RVA: 0x1A7D6B0 Offset: 0x1A7BCB0 VA: 0x181A7D6B0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x1A7D6E0 Offset: 0x1A7BCE0 VA: 0x181A7D6E0
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1A7D720 Offset: 0x1A7BD20 VA: 0x181A7D720
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1A7D640 Offset: 0x1A7BC40 VA: 0x181A7D640
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1A7D610 Offset: 0x1A7BC10 VA: 0x181A7D610
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D7E0 Offset: 0x1A7BDE0 VA: 0x181A7D7E0
	private static void MarkGUIChanged() { }

	// RVA: 0x1A7D010 Offset: 0x1A7B610 VA: 0x181A7D010
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1A7CFB0 Offset: 0x1A7B5B0 VA: 0x181A7CFB0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1A7D130 Offset: 0x1A7B730 VA: 0x181A7D130
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7E020 Offset: 0x1A7C620 VA: 0x181A7E020
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1A7D680 Offset: 0x1A7BC80 VA: 0x181A7D680
	public static int get_hotControl() { }

	// RVA: 0x1A7D6E0 Offset: 0x1A7BCE0 VA: 0x181A7D6E0
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7DE90 Offset: 0x1A7C490 VA: 0x181A7DE90
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D8E0 Offset: 0x1A7BEE0 VA: 0x181A7D8E0
	internal static void RemoveCapture() { }

	// RVA: 0x1A7D6B0 Offset: 0x1A7BCB0 VA: 0x181A7D6B0
	public static int get_keyboardControl() { }

	// RVA: 0x1A7D720 Offset: 0x1A7BD20 VA: 0x181A7D720
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1A7D2B0 Offset: 0x1A7B8B0 VA: 0x181A7D2B0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1A7CF10 Offset: 0x1A7B510 VA: 0x181A7CF10
	public static void ExitGUI() { }

	// RVA: 0x1A7D0B0 Offset: 0x1A7B6B0 VA: 0x181A7D0B0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D870 Offset: 0x1A7BE70 VA: 0x181A7D870
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA540 Offset: 0xD9940 VA: 0x1800DA540
	// RVA: 0x1A7CAD0 Offset: 0x1A7B0D0 VA: 0x181A7CAD0
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7C810 Offset: 0x1A7AE10 VA: 0x181A7C810
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7CBC0 Offset: 0x1A7B1C0 VA: 0x181A7CBC0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7CB20 Offset: 0x1A7B120 VA: 0x181A7CB20
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7CA70 Offset: 0x1A7B070 VA: 0x181A7CA70
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAA70 Offset: 0xD9E70 VA: 0x1800DAA70
	// RVA: 0x1A7D930 Offset: 0x1A7BF30 VA: 0x181A7D930
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB70 Offset: 0xD9F70 VA: 0x1800DAB70
	// RVA: 0x1A7D760 Offset: 0x1A7BD60 VA: 0x181A7D760
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACA0 Offset: 0xDA0A0 VA: 0x1800DACA0
	// RVA: 0x1A7D760 Offset: 0x1A7BD60 VA: 0x181A7D760
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1A7C9E0 Offset: 0x1A7AFE0 VA: 0x181A7C9E0
	internal static void CheckOnGUI() { }

	// RVA: 0x1A7DA40 Offset: 0x1A7C040 VA: 0x181A7DA40
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x1A7C720 Offset: 0x1A7AD20 VA: 0x181A7C720
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1A7D340 Offset: 0x1A7B940 VA: 0x181A7D340
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1A7D3E0 Offset: 0x1A7B9E0 VA: 0x181A7D3E0
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1A7D490 Offset: 0x1A7BA90 VA: 0x181A7D490
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1A7CF60 Offset: 0x1A7B560 VA: 0x181A7CF60
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x1A7C640 Offset: 0x1A7AC40 VA: 0x181A7C640
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x1A7DFA0 Offset: 0x1A7C5A0 VA: 0x181A7DFA0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}


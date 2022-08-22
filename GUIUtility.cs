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
	// RVA: 0x1A6A470 Offset: 0x1A68A70 VA: 0x181A6A470
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7710 Offset: 0xD6B10 VA: 0x1800D7710
	// RVA: 0x1A6A440 Offset: 0x1A68A40 VA: 0x181A6A440
	internal static int get_guiDepth() { }

	// RVA: 0x1A6A590 Offset: 0x1A68B90 VA: 0x181A6A590
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1A6A610 Offset: 0x1A68C10 VA: 0x181A6A610
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8BA0 Offset: 0xD7FA0 VA: 0x1800D8BA0
	// RVA: 0x1A6A4A0 Offset: 0x1A68AA0 VA: 0x181A6A4A0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8C40 Offset: 0xD8040 VA: 0x1800D8C40
	// RVA: 0x1A6A5D0 Offset: 0x1A68BD0 VA: 0x181A6A5D0
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8CA0 Offset: 0xD80A0 VA: 0x1800D8CA0
	// RVA: 0x1A69590 Offset: 0x1A67B90 VA: 0x181A69590
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8EB0 Offset: 0xD82B0 VA: 0x1800D8EB0
	// RVA: 0x1A68CC0 Offset: 0x1A672C0 VA: 0x181A68CC0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	// RVA: 0x1A68D00 Offset: 0x1A67300 VA: 0x181A68D00
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9350 Offset: 0xD8750 VA: 0x1800D9350
	// RVA: 0x1A69B10 Offset: 0x1A68110 VA: 0x181A69B10
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9380 Offset: 0xD8780 VA: 0x1800D9380
	// RVA: 0x1A68ED0 Offset: 0x1A674D0 VA: 0x181A68ED0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9610 Offset: 0xD8A10 VA: 0x1800D9610
	// RVA: 0x1A6A360 Offset: 0x1A68960 VA: 0x181A6A360
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9870 Offset: 0xD8C70 VA: 0x1800D9870
	// RVA: 0x1A6A390 Offset: 0x1A68990 VA: 0x181A6A390
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9AC0 Offset: 0xD8EC0 VA: 0x1800D9AC0
	// RVA: 0x1A697B0 Offset: 0x1A67DB0 VA: 0x181A697B0
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D90 Offset: 0xD9190 VA: 0x1800D9D90
	// RVA: 0x1A69D60 Offset: 0x1A68360 VA: 0x181A69D60
	internal static bool OwnsId(int id) { }

	// RVA: 0x1A68BE0 Offset: 0x1A671E0 VA: 0x181A68BE0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9F30 Offset: 0xD9330 VA: 0x1800D9F30
	// RVA: 0x1A6A410 Offset: 0x1A68A10 VA: 0x181A6A410
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9FE0 Offset: 0xD93E0 VA: 0x1800D9FE0
	// RVA: 0x1A6A510 Offset: 0x1A68B10 VA: 0x181A6A510
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A69BB0 Offset: 0x1A681B0 VA: 0x181A69BB0
	private static int Internal_GetHotControl() { }

	// RVA: 0x1A69BE0 Offset: 0x1A681E0 VA: 0x181A69BE0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x1A69C10 Offset: 0x1A68210 VA: 0x181A69C10
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1A69C50 Offset: 0x1A68250 VA: 0x181A69C50
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1A69B70 Offset: 0x1A68170 VA: 0x181A69B70
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1A69B40 Offset: 0x1A68140 VA: 0x181A69B40
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A69D10 Offset: 0x1A68310 VA: 0x181A69D10
	private static void MarkGUIChanged() { }

	// RVA: 0x1A69540 Offset: 0x1A67B40 VA: 0x181A69540
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1A694E0 Offset: 0x1A67AE0 VA: 0x181A694E0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1A69660 Offset: 0x1A67C60 VA: 0x181A69660
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A6A550 Offset: 0x1A68B50 VA: 0x181A6A550
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1A69BB0 Offset: 0x1A681B0 VA: 0x181A69BB0
	public static int get_hotControl() { }

	// RVA: 0x1A69C10 Offset: 0x1A68210 VA: 0x181A69C10
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A6A3C0 Offset: 0x1A689C0 VA: 0x181A6A3C0
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A69E10 Offset: 0x1A68410 VA: 0x181A69E10
	internal static void RemoveCapture() { }

	// RVA: 0x1A69BE0 Offset: 0x1A681E0 VA: 0x181A69BE0
	public static int get_keyboardControl() { }

	// RVA: 0x1A69C50 Offset: 0x1A68250 VA: 0x181A69C50
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1A697E0 Offset: 0x1A67DE0 VA: 0x181A697E0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1A69440 Offset: 0x1A67A40 VA: 0x181A69440
	public static void ExitGUI() { }

	// RVA: 0x1A695E0 Offset: 0x1A67BE0 VA: 0x181A695E0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A69DA0 Offset: 0x1A683A0 VA: 0x181A69DA0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA540 Offset: 0xD9940 VA: 0x1800DA540
	// RVA: 0x1A69000 Offset: 0x1A67600 VA: 0x181A69000
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A68D40 Offset: 0x1A67340 VA: 0x181A68D40
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A690F0 Offset: 0x1A676F0 VA: 0x181A690F0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A69050 Offset: 0x1A67650 VA: 0x181A69050
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A68FA0 Offset: 0x1A675A0 VA: 0x181A68FA0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAA70 Offset: 0xD9E70 VA: 0x1800DAA70
	// RVA: 0x1A69E60 Offset: 0x1A68460 VA: 0x181A69E60
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB70 Offset: 0xD9F70 VA: 0x1800DAB70
	// RVA: 0x1A69C90 Offset: 0x1A68290 VA: 0x181A69C90
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACA0 Offset: 0xDA0A0 VA: 0x1800DACA0
	// RVA: 0x1A69C90 Offset: 0x1A68290 VA: 0x181A69C90
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1A68F10 Offset: 0x1A67510 VA: 0x181A68F10
	internal static void CheckOnGUI() { }

	// RVA: 0x1A69F70 Offset: 0x1A68570 VA: 0x181A69F70
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x1A68C50 Offset: 0x1A67250 VA: 0x181A68C50
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1A69870 Offset: 0x1A67E70 VA: 0x181A69870
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1A69910 Offset: 0x1A67F10 VA: 0x181A69910
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1A699C0 Offset: 0x1A67FC0 VA: 0x181A699C0
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1A69490 Offset: 0x1A67A90 VA: 0x181A69490
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x1A68B70 Offset: 0x1A67170 VA: 0x181A68B70
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x1A6A4D0 Offset: 0x1A68AD0 VA: 0x181A6A4D0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}


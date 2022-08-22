public class GUIUtility // TypeDefIndex: 4051
{	[VisibleToOtherModulesAttribute] // RVA: 0xD6880 Offset: 0xD5C80 VA: 0x1800D6880
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


	[VisibleToOtherModulesAttribute] // RVA: 0xD7640 Offset: 0xD6A40 VA: 0x1800D7640
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7710 Offset: 0xD6B10 VA: 0x1800D7710
	internal static int get_guiDepth() { }

	internal static void set_mouseUsed(bool value) { }

	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8BA0 Offset: 0xD7FA0 VA: 0x1800D8BA0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8C40 Offset: 0xD8040 VA: 0x1800D8C40
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8CA0 Offset: 0xD80A0 VA: 0x1800D8CA0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8EB0 Offset: 0xD82B0 VA: 0x1800D8EB0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9350 Offset: 0xD8750 VA: 0x1800D9350
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9380 Offset: 0xD8780 VA: 0x1800D9380
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9610 Offset: 0xD8A10 VA: 0x1800D9610
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9870 Offset: 0xD8C70 VA: 0x1800D9870
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9AC0 Offset: 0xD8EC0 VA: 0x1800D9AC0
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D90 Offset: 0xD9190 VA: 0x1800D9D90
	internal static bool OwnsId(int id) { }

	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9F30 Offset: 0xD9330 VA: 0x1800D9F30
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9FE0 Offset: 0xD93E0 VA: 0x1800D9FE0
	internal static void set_compositionCursorPos(Vector2 value) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void MarkGUIChanged() { }

	public static int GetControlID(FocusType focus) { }

	public static int GetControlID(int hint, FocusType focus) { }

	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void set_guiIsExiting(bool value) { }

	public static int get_hotControl() { }

	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void RemoveCapture() { }

	public static int get_keyboardControl() { }

	public static void set_keyboardControl(int value) { }

	internal static bool HasKeyFocus(int controlID) { }

	public static void ExitGUI() { }

	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA540 Offset: 0xD9940 VA: 0x1800DA540
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAA70 Offset: 0xD9E70 VA: 0x1800DAA70
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB70 Offset: 0xD9F70 VA: 0x1800DAB70
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACA0 Offset: 0xDA0A0 VA: 0x1800DACA0
	internal static bool ShouldRethrowException(Exception exception) { }

	internal static void CheckOnGUI() { }

	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	public static Rect AlignRectToDevice(Rect rect) { }

	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	internal static bool HitTest(Rect rect, Event evt) { }

	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}


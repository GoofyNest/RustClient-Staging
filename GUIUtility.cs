public class GUIUtility // TypeDefIndex: 4051
{	[VisibleToOtherModulesAttribute] // RVA: 0xD68D0 Offset: 0xD5CD0 VA: 0x1800D68D0
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xD6A30 Offset: 0xD5E30 VA: 0x1800D6A30
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xD6BC0 Offset: 0xD5FC0 VA: 0x1800D6BC0
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xD6D30 Offset: 0xD6130 VA: 0x1800D6D30
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xD6F60 Offset: 0xD6360 VA: 0x1800D6F60
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xD71C0 Offset: 0xD65C0 VA: 0x1800D71C0
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xD7310 Offset: 0xD6710 VA: 0x1800D7310
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xD7480 Offset: 0xD6880 VA: 0x1800D7480
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	[NativePropertyAttribute] // RVA: 0xDB190 Offset: 0xDA590 VA: 0x1800DB190
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xDB270 Offset: 0xDA670 VA: 0x1800DB270
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xDB4B0 Offset: 0xDA8B0 VA: 0x1800DB4B0
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xDB5B0 Offset: 0xDA9B0 VA: 0x1800DB5B0
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDB650 Offset: 0xDAA50 VA: 0x1800DB650
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xDB650 Offset: 0xDAA50 VA: 0x1800DB650
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }


	[VisibleToOtherModulesAttribute] // RVA: 0xD76E0 Offset: 0xD6AE0 VA: 0x1800D76E0
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7760 Offset: 0xD6B60 VA: 0x1800D7760
	internal static int get_guiDepth() { }

	internal static void set_mouseUsed(bool value) { }

	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8BF0 Offset: 0xD7FF0 VA: 0x1800D8BF0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8C70 Offset: 0xD8070 VA: 0x1800D8C70
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8EE0 Offset: 0xD82E0 VA: 0x1800D8EE0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9210 Offset: 0xD8610 VA: 0x1800D9210
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9440 Offset: 0xD8840 VA: 0x1800D9440
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9470 Offset: 0xD8870 VA: 0x1800D9470
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD97C0 Offset: 0xD8BC0 VA: 0x1800D97C0
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD99F0 Offset: 0xD8DF0 VA: 0x1800D99F0
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9C10 Offset: 0xD9010 VA: 0x1800D9C10
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9E50 Offset: 0xD9250 VA: 0x1800D9E50
	internal static bool OwnsId(int id) { }

	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9FE0 Offset: 0xD93E0 VA: 0x1800D9FE0
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA0C0 Offset: 0xD94C0 VA: 0x1800DA0C0
	internal static void set_compositionCursorPos(Vector2 value) { }

	private static int Internal_GetHotControl() { }

	private static int Internal_GetKeyboardControl() { }

	private static void Internal_SetHotControl(int value) { }

	private static void Internal_SetKeyboardControl(int value) { }

	private static object Internal_GetDefaultSkin(int skinMode) { }

	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void MarkGUIChanged() { }

	public static int GetControlID(FocusType focus) { }

	public static int GetControlID(int hint, FocusType focus) { }

	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void set_guiIsExiting(bool value) { }

	public static int get_hotControl() { }

	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void RemoveCapture() { }

	public static int get_keyboardControl() { }

	public static void set_keyboardControl(int value) { }

	internal static bool HasKeyFocus(int controlID) { }

	public static void ExitGUI() { }

	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA6C0 Offset: 0xD9AC0 VA: 0x1800DA6C0
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB30 Offset: 0xD9F30 VA: 0x1800DAB30
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACB0 Offset: 0xDA0B0 VA: 0x1800DACB0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAE50 Offset: 0xDA250 VA: 0x1800DAE50
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


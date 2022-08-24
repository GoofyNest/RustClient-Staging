public class GUIUtility // TypeDefIndex: 4051
{	[VisibleToOtherModulesAttribute] // RVA: 0xD69B0 Offset: 0xD5DB0 VA: 0x1800D69B0
	internal static int s_SkinMode; // 0x0
	[VisibleToOtherModulesAttribute] // RVA: 0xD6B10 Offset: 0xD5F10 VA: 0x1800D6B10
	internal static int s_OriginalID; // 0x4
	[VisibleToOtherModulesAttribute] // RVA: 0xD6CF0 Offset: 0xD60F0 VA: 0x1800D6CF0
	internal static Action takeCapture; // 0x8
	[VisibleToOtherModulesAttribute] // RVA: 0xD6DC0 Offset: 0xD61C0 VA: 0x1800D6DC0
	internal static Action releaseCapture; // 0x10
	[VisibleToOtherModulesAttribute] // RVA: 0xD6FF0 Offset: 0xD63F0 VA: 0x1800D6FF0
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	[VisibleToOtherModulesAttribute] // RVA: 0xD7250 Offset: 0xD6650 VA: 0x1800D7250
	internal static Action cleanupRoots; // 0x20
	[VisibleToOtherModulesAttribute] // RVA: 0xD7410 Offset: 0xD6810 VA: 0x1800D7410
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModulesAttribute] // RVA: 0xD7530 Offset: 0xD6930 VA: 0x1800D7530
	internal static Action guiChanged; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static bool <guiIsExiting>k__BackingField; // 0x38
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x40

	[NativePropertyAttribute] // RVA: 0xDB060 Offset: 0xDA460 VA: 0x1800DB060
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0xDB150 Offset: 0xDA550 VA: 0x1800DB150
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0xDB360 Offset: 0xDA760 VA: 0x1800DB360
	internal static bool mouseUsed { set; }
	[StaticAccessorAttribute] // RVA: 0xDB420 Offset: 0xDA820 VA: 0x1800DB420
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDB490 Offset: 0xDA890 VA: 0x1800DB490
	internal static string compositionString { get; }
	[StaticAccessorAttribute] // RVA: 0xDB490 Offset: 0xDA890 VA: 0x1800DB490
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }


	[VisibleToOtherModulesAttribute] // RVA: 0xD7740 Offset: 0xD6B40 VA: 0x1800D7740
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD77F0 Offset: 0xD6BF0 VA: 0x1800D77F0
	internal static int get_guiDepth() { }

	internal static void set_mouseUsed(bool value) { }

	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8CD0 Offset: 0xD80D0 VA: 0x1800D8CD0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8D20 Offset: 0xD8120 VA: 0x1800D8D20
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8D80 Offset: 0xD8180 VA: 0x1800D8D80
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8FE0 Offset: 0xD83E0 VA: 0x1800D8FE0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD92B0 Offset: 0xD86B0 VA: 0x1800D92B0
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9450 Offset: 0xD8850 VA: 0x1800D9450
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD94B0 Offset: 0xD88B0 VA: 0x1800D94B0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9740 Offset: 0xD8B40 VA: 0x1800D9740
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9940 Offset: 0xD8D40 VA: 0x1800D9940
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9B90 Offset: 0xD8F90 VA: 0x1800D9B90
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9E60 Offset: 0xD9260 VA: 0x1800D9E60
	internal static bool OwnsId(int id) { }

	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA0E0 Offset: 0xD94E0 VA: 0x1800DA0E0
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

	[VisibleToOtherModulesAttribute] // RVA: 0xDA5F0 Offset: 0xD99F0 VA: 0x1800DA5F0
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB20 Offset: 0xD9F20 VA: 0x1800DAB20
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACA0 Offset: 0xDA0A0 VA: 0x1800DACA0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAD50 Offset: 0xDA150 VA: 0x1800DAD50
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


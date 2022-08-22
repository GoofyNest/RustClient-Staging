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
	// RVA: 0x1A7DC80 Offset: 0x1A7C280 VA: 0x181A7DC80
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD7710 Offset: 0xD6B10 VA: 0x1800D7710
	// RVA: 0x1A7DC50 Offset: 0x1A7C250 VA: 0x181A7DC50
	internal static int get_guiDepth() { }

	// RVA: 0x1A7DDA0 Offset: 0x1A7C3A0 VA: 0x181A7DDA0
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1A7DE20 Offset: 0x1A7C420 VA: 0x181A7DE20
	internal static void set_textFieldInput(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD8BA0 Offset: 0xD7FA0 VA: 0x1800D8BA0
	// RVA: 0x1A7DCB0 Offset: 0x1A7C2B0 VA: 0x181A7DCB0
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD8C40 Offset: 0xD8040 VA: 0x1800D8C40
	// RVA: 0x1A7DDE0 Offset: 0x1A7C3E0 VA: 0x181A7DDE0
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0xD8CA0 Offset: 0xD80A0 VA: 0x1800D8CA0
	// RVA: 0x1A7CDA0 Offset: 0x1A7B3A0 VA: 0x181A7CDA0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD8EB0 Offset: 0xD82B0 VA: 0x1800D8EB0
	// RVA: 0x1A7C4D0 Offset: 0x1A7AAD0 VA: 0x181A7C4D0
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9180 Offset: 0xD8580 VA: 0x1800D9180
	// RVA: 0x1A7C510 Offset: 0x1A7AB10 VA: 0x181A7C510
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[NativeMethodAttribute] // RVA: 0xD9350 Offset: 0xD8750 VA: 0x1800D9350
	// RVA: 0x1A7D320 Offset: 0x1A7B920 VA: 0x181A7D320
	internal static void Internal_EndContainer() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9380 Offset: 0xD8780 VA: 0x1800D9380
	// RVA: 0x1A7C6E0 Offset: 0x1A7ACE0 VA: 0x181A7C6E0
	internal static int CheckForTabEvent(Event evt) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9610 Offset: 0xD8A10 VA: 0x1800D9610
	// RVA: 0x1A7DB70 Offset: 0x1A7C170 VA: 0x181A7DB70
	internal static void SetKeyboardControlToFirstControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9870 Offset: 0xD8C70 VA: 0x1800D9870
	// RVA: 0x1A7DBA0 Offset: 0x1A7C1A0 VA: 0x181A7DBA0
	internal static void SetKeyboardControlToLastControlId() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9AC0 Offset: 0xD8EC0 VA: 0x1800D9AC0
	// RVA: 0x1A7CFC0 Offset: 0x1A7B5C0 VA: 0x181A7CFC0
	internal static bool HasFocusableControls() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9D90 Offset: 0xD9190 VA: 0x1800D9D90
	// RVA: 0x1A7D570 Offset: 0x1A7BB70 VA: 0x181A7D570
	internal static bool OwnsId(int id) { }

	// RVA: 0x1A7C3F0 Offset: 0x1A7A9F0 VA: 0x181A7C3F0
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9F30 Offset: 0xD9330 VA: 0x1800D9F30
	// RVA: 0x1A7DC20 Offset: 0x1A7C220 VA: 0x181A7DC20
	internal static string get_compositionString() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xD9FE0 Offset: 0xD93E0 VA: 0x1800D9FE0
	// RVA: 0x1A7DD20 Offset: 0x1A7C320 VA: 0x181A7DD20
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A7D3C0 Offset: 0x1A7B9C0 VA: 0x181A7D3C0
	private static int Internal_GetHotControl() { }

	// RVA: 0x1A7D3F0 Offset: 0x1A7B9F0 VA: 0x181A7D3F0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x1A7D420 Offset: 0x1A7BA20 VA: 0x181A7D420
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1A7D460 Offset: 0x1A7BA60 VA: 0x181A7D460
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1A7D380 Offset: 0x1A7B980 VA: 0x181A7D380
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1A7D350 Offset: 0x1A7B950 VA: 0x181A7D350
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D520 Offset: 0x1A7BB20 VA: 0x181A7D520
	private static void MarkGUIChanged() { }

	// RVA: 0x1A7CD50 Offset: 0x1A7B350 VA: 0x181A7CD50
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1A7CCF0 Offset: 0x1A7B2F0 VA: 0x181A7CCF0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1A7CE70 Offset: 0x1A7B470 VA: 0x181A7CE70
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7DD60 Offset: 0x1A7C360 VA: 0x181A7DD60
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1A7D3C0 Offset: 0x1A7B9C0 VA: 0x181A7D3C0
	public static int get_hotControl() { }

	// RVA: 0x1A7D420 Offset: 0x1A7BA20 VA: 0x181A7D420
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7DBD0 Offset: 0x1A7C1D0 VA: 0x181A7DBD0
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D620 Offset: 0x1A7BC20 VA: 0x181A7D620
	internal static void RemoveCapture() { }

	// RVA: 0x1A7D3F0 Offset: 0x1A7B9F0 VA: 0x181A7D3F0
	public static int get_keyboardControl() { }

	// RVA: 0x1A7D460 Offset: 0x1A7BA60 VA: 0x181A7D460
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1A7CFF0 Offset: 0x1A7B5F0 VA: 0x181A7CFF0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1A7CC50 Offset: 0x1A7B250 VA: 0x181A7CC50
	public static void ExitGUI() { }

	// RVA: 0x1A7CDF0 Offset: 0x1A7B3F0 VA: 0x181A7CDF0
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7D5B0 Offset: 0x1A7BBB0 VA: 0x181A7D5B0
	internal static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDA540 Offset: 0xD9940 VA: 0x1800DA540
	// RVA: 0x1A7C810 Offset: 0x1A7AE10 VA: 0x181A7C810
	internal static void EndContainer() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7C550 Offset: 0x1A7AB50 VA: 0x181A7C550
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7C900 Offset: 0x1A7AF00 VA: 0x181A7C900
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7C860 Offset: 0x1A7AE60 VA: 0x181A7C860
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A7C7B0 Offset: 0x1A7ADB0 VA: 0x181A7C7B0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAA70 Offset: 0xD9E70 VA: 0x1800DAA70
	// RVA: 0x1A7D670 Offset: 0x1A7BC70 VA: 0x181A7D670
	internal static void ResetGlobalState() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDAB70 Offset: 0xD9F70 VA: 0x1800DAB70
	// RVA: 0x1A7D4A0 Offset: 0x1A7BAA0 VA: 0x181A7D4A0
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xDACA0 Offset: 0xDA0A0 VA: 0x1800DACA0
	// RVA: 0x1A7D4A0 Offset: 0x1A7BAA0 VA: 0x181A7D4A0
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1A7C720 Offset: 0x1A7AD20 VA: 0x181A7C720
	internal static void CheckOnGUI() { }

	// RVA: 0x1A7D780 Offset: 0x1A7BD80 VA: 0x181A7D780
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	// RVA: 0x1A7C460 Offset: 0x1A7AA60 VA: 0x181A7C460
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1A7D080 Offset: 0x1A7B680 VA: 0x181A7D080
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1A7D120 Offset: 0x1A7B720 VA: 0x181A7D120
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1A7D1D0 Offset: 0x1A7B7D0 VA: 0x181A7D1D0
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1A7CCA0 Offset: 0x1A7B2A0 VA: 0x181A7CCA0
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x1A7C380 Offset: 0x1A7A980 VA: 0x181A7C380
	private static void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x1A7DCE0 Offset: 0x1A7C2E0 VA: 0x181A7DCE0
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}


public class Input // TypeDefIndex: 4075
{	// Properties
	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	public static bool anyKey { get; }
	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	public static bool anyKeyDown { get; }
	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313A40 Offset: 0x2312040 VA: 0x182313A40
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313A80 Offset: 0x2312080 VA: 0x182313A80
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313A00 Offset: 0x2312000 VA: 0x182313A00
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313980 Offset: 0x2311F80 VA: 0x182313980
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313940 Offset: 0x2311F40 VA: 0x182313940
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x23139C0 Offset: 0x2311FC0 VA: 0x1823139C0
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313B40 Offset: 0x2312140 VA: 0x182313B40
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313AC0 Offset: 0x23120C0 VA: 0x182313AC0
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313B00 Offset: 0x2312100 VA: 0x182313B00
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80A80 Offset: 0x7FE80 VA: 0x180080A80
	// RVA: 0x2313BC0 Offset: 0x23121C0 VA: 0x182313BC0
	public static Touch GetTouch(int index) { }

	// RVA: 0x2313A40 Offset: 0x2312040 VA: 0x182313A40
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x2313A80 Offset: 0x2312080 VA: 0x182313A80
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x2313A00 Offset: 0x2312000 VA: 0x182313A00
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2313C50 Offset: 0x2312250 VA: 0x182313C50
	public static bool get_anyKey() { }

	// RVA: 0x2313C20 Offset: 0x2312220 VA: 0x182313C20
	public static bool get_anyKeyDown() { }

	// RVA: 0x2313DA0 Offset: 0x23123A0 VA: 0x182313DA0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2313E50 Offset: 0x2312450 VA: 0x182313E50
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2313D30 Offset: 0x2312330 VA: 0x182313D30
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x23140A0 Offset: 0x23126A0 VA: 0x1823140A0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2313D00 Offset: 0x2312300 VA: 0x182313D00
	public static string get_compositionString() { }

	// RVA: 0x2313CC0 Offset: 0x23122C0 VA: 0x182313CC0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2314060 Offset: 0x2312660 VA: 0x182314060
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA590 Offset: 0xE9990 VA: 0x1800EA590
	// RVA: 0x2313DE0 Offset: 0x23123E0 VA: 0x182313DE0
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA5C0 Offset: 0xE99C0 VA: 0x1800EA5C0
	// RVA: 0x2313E90 Offset: 0x2312490 VA: 0x182313E90
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA710 Offset: 0xE9B10 VA: 0x1800EA710
	// RVA: 0x2313EC0 Offset: 0x23124C0 VA: 0x182313EC0
	public static bool get_touchSupported() { }

	// RVA: 0x2313EF0 Offset: 0x23124F0 VA: 0x182313EF0
	public static Touch[] get_touches() { }

	// RVA: 0x2313B80 Offset: 0x2312180 VA: 0x182313B80
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2313D60 Offset: 0x2312360 VA: 0x182313D60
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2313E10 Offset: 0x2312410 VA: 0x182313E10
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2313C80 Offset: 0x2312280 VA: 0x182313C80
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2314020 Offset: 0x2312620 VA: 0x182314020
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

public static class Input // TypeDefIndex: 6667
{
// Namespace: Facepunch
public static class Input // TypeDefIndex: 6667
	// Fields
	private static readonly Memoized<string, string> WithoutFirstChar; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Action<string, bool> RunBind; // 0x8
	private static List<Input.Button> buttons; // 0x10
	private static List<Action> frameThinks; // 0x18

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230F460 Offset: 0x230DA60 VA: 0x18230F460
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230F560 Offset: 0x230DB60 VA: 0x18230F560
	public static void remove_RunBind(Action<string, bool> value) { }

	// RVA: 0x230E200 Offset: 0x230C800 VA: 0x18230E200
	public static void Frame() { }

	// RVA: 0x230F1D0 Offset: 0x230D7D0 VA: 0x18230F1D0
	public static void Update() { }

	// RVA: 0x230DEF0 Offset: 0x230C4F0 VA: 0x18230DEF0
	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	// RVA: 0x230EF80 Offset: 0x230D580 VA: 0x18230EF80
	public static bool HasButton(string name) { }

	// RVA: 0x230F0D0 Offset: 0x230D6D0 VA: 0x18230F0D0
	public static void SetBind(string name, string bind, bool cycled = False) { }

	// RVA: 0x230E5E0 Offset: 0x230CBE0 VA: 0x18230E5E0
	public static string GetBind(string name) { }

	// RVA: 0x230E970 Offset: 0x230CF70 VA: 0x18230E970
	public static Input.Button GetButton(string name) { }

	// RVA: 0x230E0C0 Offset: 0x230C6C0 VA: 0x18230E0C0
	public static void ClearBinds() { }

	// RVA: 0x230E2D0 Offset: 0x230C8D0 VA: 0x18230E2D0
	public static Dictionary<string, Input.Button> GetAllBinds() { }

	// RVA: 0x230E4B0 Offset: 0x230CAB0 VA: 0x18230E4B0
	public static string[] GetAllButtons() { }

	// RVA: 0x230ED90 Offset: 0x230D390 VA: 0x18230ED90
	public static string[] GetPressedButtons() { }

	// RVA: 0x230EBE0 Offset: 0x230D1E0 VA: 0x18230EBE0
	public static string[] GetButtonsWithBind(string bind) { }

	// RVA: 0x230EFE0 Offset: 0x230D5E0 VA: 0x18230EFE0
	public static bool IsBindInUse(string bind) { }

	// RVA: 0x230E750 Offset: 0x230CD50 VA: 0x18230E750
	public static string GetButtonWithBind(string bind) { }

	// RVA: 0x230E670 Offset: 0x230CC70 VA: 0x18230E670
	public static Input.Button GetButtonObjectWithBind(string bind) { }

	// RVA: 0x230EA50 Offset: 0x230D050 VA: 0x18230EA50
	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	// RVA: 0x230F320 Offset: 0x230D920 VA: 0x18230F320
	private static void .cctor() { }

}

public class Input.Button // TypeDefIndex: 6668
{	// Fields
	public string Name; // 0x10
	public Func<bool> TestFunction; // 0x18
	public bool CurrentValue; // 0x20
	public bool LastValue; // 0x21
	public string[] Binds; // 0x28
	public bool Transient; // 0x30
	public bool Cycle; // 0x31
	public int CycleIndex; // 0x34
	public KeyCode Code; // 0x38

	// Methods

	// RVA: 0x230DE60 Offset: 0x230C460 VA: 0x18230DE60 Slot: 4
	public virtual void Update() { }

	// RVA: 0x230DD20 Offset: 0x230C320 VA: 0x18230DD20
	private void RunBinds(bool pressed) { }

	// RVA: 0x230DC00 Offset: 0x230C200 VA: 0x18230DC00
	private static void RunBindImpl(string bind, bool pressed) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class Input.<>c__DisplayClass13_0 // TypeDefIndex: 6669
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F6E0 Offset: 0x230DCE0 VA: 0x18230F6E0
	internal bool <GetButton>b__0(Input.Button x) { }

}

private sealed class Input.<>c // TypeDefIndex: 6670
{	// Fields
	public static readonly Input.<>c <>9; // 0x0
	public static Func<Input.Button, bool> <>9__15_0; // 0x8
	public static Func<Input.Button, string> <>9__15_1; // 0x10
	public static Func<Input.Button, string> <>9__16_0; // 0x18
	public static Func<Input.Button, bool> <>9__17_0; // 0x20
	public static Func<Input.Button, string> <>9__17_1; // 0x28
	public static Func<Input.Button, string> <>9__18_1; // 0x30

	// Methods

	// RVA: 0x230F860 Offset: 0x230DE60 VA: 0x18230F860
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F660 Offset: 0x230DC60 VA: 0x18230F660
	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	// RVA: 0x230F690 Offset: 0x230DC90 VA: 0x18230F690
	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	// RVA: 0x230F6B0 Offset: 0x230DCB0 VA: 0x18230F6B0
	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F710 Offset: 0x230DD10 VA: 0x18230F710
	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F780 Offset: 0x230DD80 VA: 0x18230F780
	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F7F0 Offset: 0x230DDF0 VA: 0x18230F7F0
	internal bool <GetButtonObjectWithBind>b__0(Input.Button x) { }

}

public class Input : ConsoleSystem // TypeDefIndex: 11936
{	// Fields
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool flipy; // 0x0
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool autocrouch; // 0x1
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float sensitivity; // 0x4
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float ads_sensitivity; // 0x8
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float vehicle_sensitivity; // 0xC
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool vehicle_flipy; // 0x10
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool toggleDuck; // 0x11
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool alwayssprint; // 0x12
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool toggleAds; // 0x13
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float holdtime; // 0x14

	// Methods

	[ClientVar] // RVA: 0xA79A0 Offset: 0xA6DA0 VA: 0x1800A79A0
	// RVA: 0x364270 Offset: 0x362870 VA: 0x180364270
	public static string bind(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x3644D0 Offset: 0x362AD0 VA: 0x1803644D0
	public static void clearbinds(ConsoleSystem.Arg arg) { }

	// RVA: 0x364210 Offset: 0x362810 VA: 0x180364210
	public void .ctor() { }

	// RVA: 0x364120 Offset: 0x362720 VA: 0x180364120
	private static void .cctor() { }

}


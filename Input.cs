public class Input // TypeDefIndex: 4075
{	// Properties
	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	public static bool anyKey { get; }
	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	public static bool anyKeyDown { get; }
	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313B40 Offset: 0x2312140 VA: 0x182313B40
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313B80 Offset: 0x2312180 VA: 0x182313B80
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313B00 Offset: 0x2312100 VA: 0x182313B00
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313A80 Offset: 0x2312080 VA: 0x182313A80
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313A40 Offset: 0x2312040 VA: 0x182313A40
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313AC0 Offset: 0x23120C0 VA: 0x182313AC0
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313C40 Offset: 0x2312240 VA: 0x182313C40
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313BC0 Offset: 0x23121C0 VA: 0x182313BC0
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313C00 Offset: 0x2312200 VA: 0x182313C00
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313CC0 Offset: 0x23122C0 VA: 0x182313CC0
	public static Touch GetTouch(int index) { }

	// RVA: 0x2313B40 Offset: 0x2312140 VA: 0x182313B40
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x2313B80 Offset: 0x2312180 VA: 0x182313B80
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x2313B00 Offset: 0x2312100 VA: 0x182313B00
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2313D50 Offset: 0x2312350 VA: 0x182313D50
	public static bool get_anyKey() { }

	// RVA: 0x2313D20 Offset: 0x2312320 VA: 0x182313D20
	public static bool get_anyKeyDown() { }

	// RVA: 0x2313EA0 Offset: 0x23124A0 VA: 0x182313EA0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2313F50 Offset: 0x2312550 VA: 0x182313F50
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2313E30 Offset: 0x2312430 VA: 0x182313E30
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x23141A0 Offset: 0x23127A0 VA: 0x1823141A0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2313E00 Offset: 0x2312400 VA: 0x182313E00
	public static string get_compositionString() { }

	// RVA: 0x2313DC0 Offset: 0x23123C0 VA: 0x182313DC0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2314160 Offset: 0x2312760 VA: 0x182314160
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA590 Offset: 0xE9990 VA: 0x1800EA590
	// RVA: 0x2313EE0 Offset: 0x23124E0 VA: 0x182313EE0
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA6C0 Offset: 0xE9AC0 VA: 0x1800EA6C0
	// RVA: 0x2313F90 Offset: 0x2312590 VA: 0x182313F90
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA780 Offset: 0xE9B80 VA: 0x1800EA780
	// RVA: 0x2313FC0 Offset: 0x23125C0 VA: 0x182313FC0
	public static bool get_touchSupported() { }

	// RVA: 0x2313FF0 Offset: 0x23125F0 VA: 0x182313FF0
	public static Touch[] get_touches() { }

	// RVA: 0x2313C80 Offset: 0x2312280 VA: 0x182313C80
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2313E60 Offset: 0x2312460 VA: 0x182313E60
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2313F10 Offset: 0x2312510 VA: 0x182313F10
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2313D80 Offset: 0x2312380 VA: 0x182313D80
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2314120 Offset: 0x2312720 VA: 0x182314120
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

public static class Input // TypeDefIndex: 6667
{
// Namespace: Facepunch
public static class Input // TypeDefIndex: 6667
	// Fields
	private static readonly Memoized<string, string> WithoutFirstChar; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, bool> RunBind; // 0x8
	private static List<Input.Button> buttons; // 0x10
	private static List<Action> frameThinks; // 0x18

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230F560 Offset: 0x230DB60 VA: 0x18230F560
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230F660 Offset: 0x230DC60 VA: 0x18230F660
	public static void remove_RunBind(Action<string, bool> value) { }

	// RVA: 0x230E300 Offset: 0x230C900 VA: 0x18230E300
	public static void Frame() { }

	// RVA: 0x230F2D0 Offset: 0x230D8D0 VA: 0x18230F2D0
	public static void Update() { }

	// RVA: 0x230DFF0 Offset: 0x230C5F0 VA: 0x18230DFF0
	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	// RVA: 0x230F080 Offset: 0x230D680 VA: 0x18230F080
	public static bool HasButton(string name) { }

	// RVA: 0x230F1D0 Offset: 0x230D7D0 VA: 0x18230F1D0
	public static void SetBind(string name, string bind, bool cycled = False) { }

	// RVA: 0x230E6E0 Offset: 0x230CCE0 VA: 0x18230E6E0
	public static string GetBind(string name) { }

	// RVA: 0x230EA70 Offset: 0x230D070 VA: 0x18230EA70
	public static Input.Button GetButton(string name) { }

	// RVA: 0x230E1C0 Offset: 0x230C7C0 VA: 0x18230E1C0
	public static void ClearBinds() { }

	// RVA: 0x230E3D0 Offset: 0x230C9D0 VA: 0x18230E3D0
	public static Dictionary<string, Input.Button> GetAllBinds() { }

	// RVA: 0x230E5B0 Offset: 0x230CBB0 VA: 0x18230E5B0
	public static string[] GetAllButtons() { }

	// RVA: 0x230EE90 Offset: 0x230D490 VA: 0x18230EE90
	public static string[] GetPressedButtons() { }

	// RVA: 0x230ECE0 Offset: 0x230D2E0 VA: 0x18230ECE0
	public static string[] GetButtonsWithBind(string bind) { }

	// RVA: 0x230F0E0 Offset: 0x230D6E0 VA: 0x18230F0E0
	public static bool IsBindInUse(string bind) { }

	// RVA: 0x230E850 Offset: 0x230CE50 VA: 0x18230E850
	public static string GetButtonWithBind(string bind) { }

	// RVA: 0x230E770 Offset: 0x230CD70 VA: 0x18230E770
	public static Input.Button GetButtonObjectWithBind(string bind) { }

	// RVA: 0x230EB50 Offset: 0x230D150 VA: 0x18230EB50
	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	// RVA: 0x230F420 Offset: 0x230DA20 VA: 0x18230F420
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

	// RVA: 0x230DF60 Offset: 0x230C560 VA: 0x18230DF60 Slot: 4
	public virtual void Update() { }

	// RVA: 0x230DE20 Offset: 0x230C420 VA: 0x18230DE20
	private void RunBinds(bool pressed) { }

	// RVA: 0x230DD00 Offset: 0x230C300 VA: 0x18230DD00
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

	// RVA: 0x230F7E0 Offset: 0x230DDE0 VA: 0x18230F7E0
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

	// RVA: 0x230F960 Offset: 0x230DF60 VA: 0x18230F960
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F760 Offset: 0x230DD60 VA: 0x18230F760
	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	// RVA: 0x230F790 Offset: 0x230DD90 VA: 0x18230F790
	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	// RVA: 0x230F7B0 Offset: 0x230DDB0 VA: 0x18230F7B0
	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F810 Offset: 0x230DE10 VA: 0x18230F810
	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F880 Offset: 0x230DE80 VA: 0x18230F880
	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F8F0 Offset: 0x230DEF0 VA: 0x18230F8F0
	internal bool <GetButtonObjectWithBind>b__0(Input.Button x) { }

}

public class Input : ConsoleSystem // TypeDefIndex: 11936
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool flipy; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool autocrouch; // 0x1
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float sensitivity; // 0x4
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float ads_sensitivity; // 0x8
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float vehicle_sensitivity; // 0xC
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool vehicle_flipy; // 0x10
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool toggleDuck; // 0x11
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool alwayssprint; // 0x12
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool toggleAds; // 0x13
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float holdtime; // 0x14

	// Methods

	[ClientVar] // RVA: 0xA7AF0 Offset: 0xA6EF0 VA: 0x1800A7AF0
	// RVA: 0x364270 Offset: 0x362870 VA: 0x180364270
	public static string bind(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x3644D0 Offset: 0x362AD0 VA: 0x1803644D0
	public static void clearbinds(ConsoleSystem.Arg arg) { }

	// RVA: 0x364210 Offset: 0x362810 VA: 0x180364210
	public void .ctor() { }

	// RVA: 0x364120 Offset: 0x362720 VA: 0x180364120
	private static void .cctor() { }

}


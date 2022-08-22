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
	// RVA: 0x2313880 Offset: 0x2311E80 VA: 0x182313880
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23138C0 Offset: 0x2311EC0 VA: 0x1823138C0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313840 Offset: 0x2311E40 VA: 0x182313840
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23137C0 Offset: 0x2311DC0 VA: 0x1823137C0
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313780 Offset: 0x2311D80 VA: 0x182313780
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313800 Offset: 0x2311E00 VA: 0x182313800
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313980 Offset: 0x2311F80 VA: 0x182313980
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313900 Offset: 0x2311F00 VA: 0x182313900
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313940 Offset: 0x2311F40 VA: 0x182313940
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2313A00 Offset: 0x2312000 VA: 0x182313A00
	public static Touch GetTouch(int index) { }

	// RVA: 0x2313880 Offset: 0x2311E80 VA: 0x182313880
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x23138C0 Offset: 0x2311EC0 VA: 0x1823138C0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x2313840 Offset: 0x2311E40 VA: 0x182313840
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2313A90 Offset: 0x2312090 VA: 0x182313A90
	public static bool get_anyKey() { }

	// RVA: 0x2313A60 Offset: 0x2312060 VA: 0x182313A60
	public static bool get_anyKeyDown() { }

	// RVA: 0x2313BE0 Offset: 0x23121E0 VA: 0x182313BE0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2313C90 Offset: 0x2312290 VA: 0x182313C90
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2313B70 Offset: 0x2312170 VA: 0x182313B70
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x2313EE0 Offset: 0x23124E0 VA: 0x182313EE0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2313B40 Offset: 0x2312140 VA: 0x182313B40
	public static string get_compositionString() { }

	// RVA: 0x2313B00 Offset: 0x2312100 VA: 0x182313B00
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2313EA0 Offset: 0x23124A0 VA: 0x182313EA0
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA590 Offset: 0xE9990 VA: 0x1800EA590
	// RVA: 0x2313C20 Offset: 0x2312220 VA: 0x182313C20
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA6C0 Offset: 0xE9AC0 VA: 0x1800EA6C0
	// RVA: 0x2313CD0 Offset: 0x23122D0 VA: 0x182313CD0
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA780 Offset: 0xE9B80 VA: 0x1800EA780
	// RVA: 0x2313D00 Offset: 0x2312300 VA: 0x182313D00
	public static bool get_touchSupported() { }

	// RVA: 0x2313D30 Offset: 0x2312330 VA: 0x182313D30
	public static Touch[] get_touches() { }

	// RVA: 0x23139C0 Offset: 0x2311FC0 VA: 0x1823139C0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2313BA0 Offset: 0x23121A0 VA: 0x182313BA0
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2313C50 Offset: 0x2312250 VA: 0x182313C50
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2313AC0 Offset: 0x23120C0 VA: 0x182313AC0
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2313E60 Offset: 0x2312460 VA: 0x182313E60
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
	// RVA: 0x230F2A0 Offset: 0x230D8A0 VA: 0x18230F2A0
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230F3A0 Offset: 0x230D9A0 VA: 0x18230F3A0
	public static void remove_RunBind(Action<string, bool> value) { }

	// RVA: 0x230E040 Offset: 0x230C640 VA: 0x18230E040
	public static void Frame() { }

	// RVA: 0x230F010 Offset: 0x230D610 VA: 0x18230F010
	public static void Update() { }

	// RVA: 0x230DD30 Offset: 0x230C330 VA: 0x18230DD30
	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	// RVA: 0x230EDC0 Offset: 0x230D3C0 VA: 0x18230EDC0
	public static bool HasButton(string name) { }

	// RVA: 0x230EF10 Offset: 0x230D510 VA: 0x18230EF10
	public static void SetBind(string name, string bind, bool cycled = False) { }

	// RVA: 0x230E420 Offset: 0x230CA20 VA: 0x18230E420
	public static string GetBind(string name) { }

	// RVA: 0x230E7B0 Offset: 0x230CDB0 VA: 0x18230E7B0
	public static Input.Button GetButton(string name) { }

	// RVA: 0x230DF00 Offset: 0x230C500 VA: 0x18230DF00
	public static void ClearBinds() { }

	// RVA: 0x230E110 Offset: 0x230C710 VA: 0x18230E110
	public static Dictionary<string, Input.Button> GetAllBinds() { }

	// RVA: 0x230E2F0 Offset: 0x230C8F0 VA: 0x18230E2F0
	public static string[] GetAllButtons() { }

	// RVA: 0x230EBD0 Offset: 0x230D1D0 VA: 0x18230EBD0
	public static string[] GetPressedButtons() { }

	// RVA: 0x230EA20 Offset: 0x230D020 VA: 0x18230EA20
	public static string[] GetButtonsWithBind(string bind) { }

	// RVA: 0x230EE20 Offset: 0x230D420 VA: 0x18230EE20
	public static bool IsBindInUse(string bind) { }

	// RVA: 0x230E590 Offset: 0x230CB90 VA: 0x18230E590
	public static string GetButtonWithBind(string bind) { }

	// RVA: 0x230E4B0 Offset: 0x230CAB0 VA: 0x18230E4B0
	public static Input.Button GetButtonObjectWithBind(string bind) { }

	// RVA: 0x230E890 Offset: 0x230CE90 VA: 0x18230E890
	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	// RVA: 0x230F160 Offset: 0x230D760 VA: 0x18230F160
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

	// RVA: 0x230DCA0 Offset: 0x230C2A0 VA: 0x18230DCA0 Slot: 4
	public virtual void Update() { }

	// RVA: 0x230DB60 Offset: 0x230C160 VA: 0x18230DB60
	private void RunBinds(bool pressed) { }

	// RVA: 0x230DA40 Offset: 0x230C040 VA: 0x18230DA40
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

	// RVA: 0x230F520 Offset: 0x230DB20 VA: 0x18230F520
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

	// RVA: 0x230F6A0 Offset: 0x230DCA0 VA: 0x18230F6A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F4A0 Offset: 0x230DAA0 VA: 0x18230F4A0
	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	// RVA: 0x230F4D0 Offset: 0x230DAD0 VA: 0x18230F4D0
	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	// RVA: 0x230F4F0 Offset: 0x230DAF0 VA: 0x18230F4F0
	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F550 Offset: 0x230DB50 VA: 0x18230F550
	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F5C0 Offset: 0x230DBC0 VA: 0x18230F5C0
	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230F630 Offset: 0x230DC30 VA: 0x18230F630
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


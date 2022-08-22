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
	// RVA: 0x2314360 Offset: 0x2312960 VA: 0x182314360
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23143A0 Offset: 0x23129A0 VA: 0x1823143A0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2314320 Offset: 0x2312920 VA: 0x182314320
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23142A0 Offset: 0x23128A0 VA: 0x1823142A0
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2314260 Offset: 0x2312860 VA: 0x182314260
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23142E0 Offset: 0x23128E0 VA: 0x1823142E0
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2314460 Offset: 0x2312A60 VA: 0x182314460
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23143E0 Offset: 0x23129E0 VA: 0x1823143E0
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x2314420 Offset: 0x2312A20 VA: 0x182314420
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x80B40 Offset: 0x7FF40 VA: 0x180080B40
	// RVA: 0x23144E0 Offset: 0x2312AE0 VA: 0x1823144E0
	public static Touch GetTouch(int index) { }

	// RVA: 0x2314360 Offset: 0x2312960 VA: 0x182314360
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x23143A0 Offset: 0x23129A0 VA: 0x1823143A0
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x2314320 Offset: 0x2312920 VA: 0x182314320
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x2314570 Offset: 0x2312B70 VA: 0x182314570
	public static bool get_anyKey() { }

	// RVA: 0x2314540 Offset: 0x2312B40 VA: 0x182314540
	public static bool get_anyKeyDown() { }

	// RVA: 0x23146C0 Offset: 0x2312CC0 VA: 0x1823146C0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x2314770 Offset: 0x2312D70 VA: 0x182314770
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x2314650 Offset: 0x2312C50 VA: 0x182314650
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x23149C0 Offset: 0x2312FC0 VA: 0x1823149C0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x2314620 Offset: 0x2312C20 VA: 0x182314620
	public static string get_compositionString() { }

	// RVA: 0x23145E0 Offset: 0x2312BE0 VA: 0x1823145E0
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x2314980 Offset: 0x2312F80 VA: 0x182314980
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0xEA590 Offset: 0xE9990 VA: 0x1800EA590
	// RVA: 0x2314700 Offset: 0x2312D00 VA: 0x182314700
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0xEA6C0 Offset: 0xE9AC0 VA: 0x1800EA6C0
	// RVA: 0x23147B0 Offset: 0x2312DB0 VA: 0x1823147B0
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0xEA780 Offset: 0xE9B80 VA: 0x1800EA780
	// RVA: 0x23147E0 Offset: 0x2312DE0 VA: 0x1823147E0
	public static bool get_touchSupported() { }

	// RVA: 0x2314810 Offset: 0x2312E10 VA: 0x182314810
	public static Touch[] get_touches() { }

	// RVA: 0x23144A0 Offset: 0x2312AA0 VA: 0x1823144A0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x2314680 Offset: 0x2312C80 VA: 0x182314680
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x2314730 Offset: 0x2312D30 VA: 0x182314730
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x23145A0 Offset: 0x2312BA0 VA: 0x1823145A0
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x2314940 Offset: 0x2312F40 VA: 0x182314940
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
	// RVA: 0x230FD80 Offset: 0x230E380 VA: 0x18230FD80
	public static void add_RunBind(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230FE80 Offset: 0x230E480 VA: 0x18230FE80
	public static void remove_RunBind(Action<string, bool> value) { }

	// RVA: 0x230EB20 Offset: 0x230D120 VA: 0x18230EB20
	public static void Frame() { }

	// RVA: 0x230FAF0 Offset: 0x230E0F0 VA: 0x18230FAF0
	public static void Update() { }

	// RVA: 0x230E810 Offset: 0x230CE10 VA: 0x18230E810
	public static void AddButton(string name, KeyCode key, Func<bool> TestFunction, Action FrameThink, bool transient = False) { }

	// RVA: 0x230F8A0 Offset: 0x230DEA0 VA: 0x18230F8A0
	public static bool HasButton(string name) { }

	// RVA: 0x230F9F0 Offset: 0x230DFF0 VA: 0x18230F9F0
	public static void SetBind(string name, string bind, bool cycled = False) { }

	// RVA: 0x230EF00 Offset: 0x230D500 VA: 0x18230EF00
	public static string GetBind(string name) { }

	// RVA: 0x230F290 Offset: 0x230D890 VA: 0x18230F290
	public static Input.Button GetButton(string name) { }

	// RVA: 0x230E9E0 Offset: 0x230CFE0 VA: 0x18230E9E0
	public static void ClearBinds() { }

	// RVA: 0x230EBF0 Offset: 0x230D1F0 VA: 0x18230EBF0
	public static Dictionary<string, Input.Button> GetAllBinds() { }

	// RVA: 0x230EDD0 Offset: 0x230D3D0 VA: 0x18230EDD0
	public static string[] GetAllButtons() { }

	// RVA: 0x230F6B0 Offset: 0x230DCB0 VA: 0x18230F6B0
	public static string[] GetPressedButtons() { }

	// RVA: 0x230F500 Offset: 0x230DB00 VA: 0x18230F500
	public static string[] GetButtonsWithBind(string bind) { }

	// RVA: 0x230F900 Offset: 0x230DF00 VA: 0x18230F900
	public static bool IsBindInUse(string bind) { }

	// RVA: 0x230F070 Offset: 0x230D670 VA: 0x18230F070
	public static string GetButtonWithBind(string bind) { }

	// RVA: 0x230EF90 Offset: 0x230D590 VA: 0x18230EF90
	public static Input.Button GetButtonObjectWithBind(string bind) { }

	// RVA: 0x230F370 Offset: 0x230D970 VA: 0x18230F370
	public static void GetButtonsWithBind(string bind, List<Input.Button> results) { }

	// RVA: 0x230FC40 Offset: 0x230E240 VA: 0x18230FC40
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

	// RVA: 0x230E780 Offset: 0x230CD80 VA: 0x18230E780 Slot: 4
	public virtual void Update() { }

	// RVA: 0x230E640 Offset: 0x230CC40 VA: 0x18230E640
	private void RunBinds(bool pressed) { }

	// RVA: 0x230E520 Offset: 0x230CB20 VA: 0x18230E520
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

	// RVA: 0x2310000 Offset: 0x230E600 VA: 0x182310000
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

	// RVA: 0x2310180 Offset: 0x230E780 VA: 0x182310180
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x230FF80 Offset: 0x230E580 VA: 0x18230FF80
	internal bool <GetAllBinds>b__15_0(Input.Button x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetAllBinds>b__15_1(Input.Button x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetAllButtons>b__16_0(Input.Button x) { }

	// RVA: 0x230FFB0 Offset: 0x230E5B0 VA: 0x18230FFB0
	internal bool <GetPressedButtons>b__17_0(Input.Button x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetPressedButtons>b__17_1(Input.Button x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal string <GetButtonsWithBind>b__18_1(Input.Button x) { }

	// RVA: 0x230FFD0 Offset: 0x230E5D0 VA: 0x18230FFD0
	internal string <.cctor>b__23_0(string s) { }

}

private sealed class Input.<>c__DisplayClass18_0 // TypeDefIndex: 6671
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2310030 Offset: 0x230E630 VA: 0x182310030
	internal bool <GetButtonsWithBind>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass19_0 // TypeDefIndex: 6672
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x23100A0 Offset: 0x230E6A0 VA: 0x1823100A0
	internal bool <IsBindInUse>b__0(Input.Button x) { }

}

private sealed class Input.<>c__DisplayClass21_0 // TypeDefIndex: 6673
{	// Fields
	public string bind; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2310110 Offset: 0x230E710 VA: 0x182310110
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


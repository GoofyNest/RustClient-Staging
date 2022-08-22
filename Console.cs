public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 187
{	// Fields
	private ConsoleSpecialKey _type; // 0x10
	private bool _cancel; // 0x14

	// Properties
	public bool Cancel { get; }

	// Methods

	// RVA: 0x14521D0 Offset: 0x14507D0 VA: 0x1814521D0
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public bool get_Cancel() { }

	// RVA: 0x14521A0 Offset: 0x14507A0 VA: 0x1814521A0
	internal void .ctor() { }

}

public enum ConsoleColor // TypeDefIndex: 188
{	// Fields
	public int value__; // 0x0
	public const ConsoleColor Black = 0;
	public const ConsoleColor DarkBlue = 1;
	public const ConsoleColor DarkGreen = 2;
	public const ConsoleColor DarkCyan = 3;
	public const ConsoleColor DarkRed = 4;
	public const ConsoleColor DarkMagenta = 5;
	public const ConsoleColor DarkYellow = 6;
	public const ConsoleColor Gray = 7;
	public const ConsoleColor DarkGray = 8;
	public const ConsoleColor Blue = 9;
	public const ConsoleColor Green = 10;
	public const ConsoleColor Cyan = 11;
	public const ConsoleColor Red = 12;
	public const ConsoleColor Magenta = 13;
	public const ConsoleColor Yellow = 14;
	public const ConsoleColor White = 15;

}

public enum ConsoleKey // TypeDefIndex: 189
{	// Fields
	public int value__; // 0x0
	public const ConsoleKey Backspace = 8;
	public const ConsoleKey Tab = 9;
	public const ConsoleKey Clear = 12;
	public const ConsoleKey Enter = 13;
	public const ConsoleKey Pause = 19;
	public const ConsoleKey Escape = 27;
	public const ConsoleKey Spacebar = 32;
	public const ConsoleKey PageUp = 33;
	public const ConsoleKey PageDown = 34;
	public const ConsoleKey End = 35;
	public const ConsoleKey Home = 36;
	public const ConsoleKey LeftArrow = 37;
	public const ConsoleKey UpArrow = 38;
	public const ConsoleKey RightArrow = 39;
	public const ConsoleKey DownArrow = 40;
	public const ConsoleKey Select = 41;
	public const ConsoleKey Print = 42;
	public const ConsoleKey Execute = 43;
	public const ConsoleKey PrintScreen = 44;
	public const ConsoleKey Insert = 45;
	public const ConsoleKey Delete = 46;
	public const ConsoleKey Help = 47;
	public const ConsoleKey D0 = 48;
	public const ConsoleKey D1 = 49;
	public const ConsoleKey D2 = 50;
	public const ConsoleKey D3 = 51;
	public const ConsoleKey D4 = 52;
	public const ConsoleKey D5 = 53;
	public const ConsoleKey D6 = 54;
	public const ConsoleKey D7 = 55;
	public const ConsoleKey D8 = 56;
	public const ConsoleKey D9 = 57;
	public const ConsoleKey A = 65;
	public const ConsoleKey B = 66;
	public const ConsoleKey C = 67;
	public const ConsoleKey D = 68;
	public const ConsoleKey E = 69;
	public const ConsoleKey F = 70;
	public const ConsoleKey G = 71;
	public const ConsoleKey H = 72;
	public const ConsoleKey I = 73;
	public const ConsoleKey J = 74;
	public const ConsoleKey K = 75;
	public const ConsoleKey L = 76;
	public const ConsoleKey M = 77;
	public const ConsoleKey N = 78;
	public const ConsoleKey O = 79;
	public const ConsoleKey P = 80;
	public const ConsoleKey Q = 81;
	public const ConsoleKey R = 82;
	public const ConsoleKey S = 83;
	public const ConsoleKey T = 84;
	public const ConsoleKey U = 85;
	public const ConsoleKey V = 86;
	public const ConsoleKey W = 87;
	public const ConsoleKey X = 88;
	public const ConsoleKey Y = 89;
	public const ConsoleKey Z = 90;
	public const ConsoleKey LeftWindows = 91;
	public const ConsoleKey RightWindows = 92;
	public const ConsoleKey Applications = 93;
	public const ConsoleKey Sleep = 95;
	public const ConsoleKey NumPad0 = 96;
	public const ConsoleKey NumPad1 = 97;
	public const ConsoleKey NumPad2 = 98;
	public const ConsoleKey NumPad3 = 99;
	public const ConsoleKey NumPad4 = 100;
	public const ConsoleKey NumPad5 = 101;
	public const ConsoleKey NumPad6 = 102;
	public const ConsoleKey NumPad7 = 103;
	public const ConsoleKey NumPad8 = 104;
	public const ConsoleKey NumPad9 = 105;
	public const ConsoleKey Multiply = 106;
	public const ConsoleKey Add = 107;
	public const ConsoleKey Separator = 108;
	public const ConsoleKey Subtract = 109;
	public const ConsoleKey Decimal = 110;
	public const ConsoleKey Divide = 111;
	public const ConsoleKey F1 = 112;
	public const ConsoleKey F2 = 113;
	public const ConsoleKey F3 = 114;
	public const ConsoleKey F4 = 115;
	public const ConsoleKey F5 = 116;
	public const ConsoleKey F6 = 117;
	public const ConsoleKey F7 = 118;
	public const ConsoleKey F8 = 119;
	public const ConsoleKey F9 = 120;
	public const ConsoleKey F10 = 121;
	public const ConsoleKey F11 = 122;
	public const ConsoleKey F12 = 123;
	public const ConsoleKey F13 = 124;
	public const ConsoleKey F14 = 125;
	public const ConsoleKey F15 = 126;
	public const ConsoleKey F16 = 127;
	public const ConsoleKey F17 = 128;
	public const ConsoleKey F18 = 129;
	public const ConsoleKey F19 = 130;
	public const ConsoleKey F20 = 131;
	public const ConsoleKey F21 = 132;
	public const ConsoleKey F22 = 133;
	public const ConsoleKey F23 = 134;
	public const ConsoleKey F24 = 135;
	public const ConsoleKey BrowserBack = 166;
	public const ConsoleKey BrowserForward = 167;
	public const ConsoleKey BrowserRefresh = 168;
	public const ConsoleKey BrowserStop = 169;
	public const ConsoleKey BrowserSearch = 170;
	public const ConsoleKey BrowserFavorites = 171;
	public const ConsoleKey BrowserHome = 172;
	public const ConsoleKey VolumeMute = 173;
	public const ConsoleKey VolumeDown = 174;
	public const ConsoleKey VolumeUp = 175;
	public const ConsoleKey MediaNext = 176;
	public const ConsoleKey MediaPrevious = 177;
	public const ConsoleKey MediaStop = 178;
	public const ConsoleKey MediaPlay = 179;
	public const ConsoleKey LaunchMail = 180;
	public const ConsoleKey LaunchMediaSelect = 181;
	public const ConsoleKey LaunchApp1 = 182;
	public const ConsoleKey LaunchApp2 = 183;
	public const ConsoleKey Oem1 = 186;
	public const ConsoleKey OemPlus = 187;
	public const ConsoleKey OemComma = 188;
	public const ConsoleKey OemMinus = 189;
	public const ConsoleKey OemPeriod = 190;
	public const ConsoleKey Oem2 = 191;
	public const ConsoleKey Oem3 = 192;
	public const ConsoleKey Oem4 = 219;
	public const ConsoleKey Oem5 = 220;
	public const ConsoleKey Oem6 = 221;
	public const ConsoleKey Oem7 = 222;
	public const ConsoleKey Oem8 = 223;
	public const ConsoleKey Oem102 = 226;
	public const ConsoleKey Process = 229;
	public const ConsoleKey Packet = 231;
	public const ConsoleKey Attention = 246;
	public const ConsoleKey CrSel = 247;
	public const ConsoleKey ExSel = 248;
	public const ConsoleKey EraseEndOfFile = 249;
	public const ConsoleKey Play = 250;
	public const ConsoleKey Zoom = 251;
	public const ConsoleKey NoName = 252;
	public const ConsoleKey Pa1 = 253;
	public const ConsoleKey OemClear = 254;

}

public struct ConsoleKeyInfo // TypeDefIndex: 190
{	// Fields
	private char _keyChar; // 0x0
	private ConsoleKey _key; // 0x4
	private ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x1EFB00 Offset: 0x1EEF00 VA: 0x1801EFB00
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x120EA0 Offset: 0x1202A0 VA: 0x180120EA0
	public char get_KeyChar() { }

	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public ConsoleKey get_Key() { }

	// RVA: 0x1EFA00 Offset: 0x1EEE00 VA: 0x1801EFA00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1EFAB0 Offset: 0x1EEEB0 VA: 0x1801EFAB0
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x1EFAF0 Offset: 0x1EEEF0 VA: 0x1801EFAF0 Slot: 2
	public override int GetHashCode() { }

}

public enum ConsoleModifiers // TypeDefIndex: 191
{	// Fields
	public int value__; // 0x0
	public const ConsoleModifiers Alt = 1;
	public const ConsoleModifiers Shift = 2;
	public const ConsoleModifiers Control = 4;

}

public enum ConsoleSpecialKey // TypeDefIndex: 192
{	// Fields
	public int value__; // 0x0
	public const ConsoleSpecialKey ControlC = 0;
	public const ConsoleSpecialKey ControlBreak = 1;

}

public static class Console // TypeDefIndex: 350
{	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; set; }
	public static ConsoleColor BackgroundColor { get; set; }
	public static int BufferWidth { get; }
	public static int CursorLeft { set; }
	public static int CursorTop { get; set; }
	public static ConsoleColor ForegroundColor { get; set; }
	public static bool KeyAvailable { get; }

	// Methods

	// RVA: 0x14539B0 Offset: 0x1451FB0 VA: 0x1814539B0
	private static void .cctor() { }

	// RVA: 0x1453450 Offset: 0x1451A50 VA: 0x181453450
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	public static TextWriter get_Error() { }

	// RVA: 0x1454030 Offset: 0x1452630 VA: 0x181454030
	public static TextWriter get_Out() { }

	// RVA: 0x1453010 Offset: 0x1451610 VA: 0x181453010
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x1452E60 Offset: 0x1451460 VA: 0x181452E60
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x1452EF0 Offset: 0x14514F0 VA: 0x181452EF0
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x1452F80 Offset: 0x1451580 VA: 0x181452F80
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x14533B0 Offset: 0x14519B0 VA: 0x1814533B0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x1453930 Offset: 0x1451F30 VA: 0x181453930
	public static void Write(string value) { }

	// RVA: 0x1453830 Offset: 0x1451E30 VA: 0x181453830
	public static void WriteLine(object value) { }

	// RVA: 0x14538B0 Offset: 0x1451EB0 VA: 0x1814538B0
	public static void WriteLine(string value) { }

	// RVA: 0x1453F10 Offset: 0x1452510 VA: 0x181453F10
	public static Encoding get_InputEncoding() { }

	// RVA: 0x1454090 Offset: 0x1452690 VA: 0x181454090
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x1454470 Offset: 0x1452A70 VA: 0x181454470
	public static void set_OutputEncoding(Encoding value) { }

	// RVA: 0x1453BB0 Offset: 0x14521B0 VA: 0x181453BB0
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x14540F0 Offset: 0x14526F0 VA: 0x1814540F0
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x1453C70 Offset: 0x1452270 VA: 0x181453C70
	public static int get_BufferWidth() { }

	// RVA: 0x14541F0 Offset: 0x14527F0 VA: 0x1814541F0
	public static void set_CursorLeft(int value) { }

	// RVA: 0x1453D30 Offset: 0x1452330 VA: 0x181453D30
	public static int get_CursorTop() { }

	// RVA: 0x14542B0 Offset: 0x14528B0 VA: 0x1814542B0
	public static void set_CursorTop(int value) { }

	// RVA: 0x1453E50 Offset: 0x1452450 VA: 0x181453E50
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x1454370 Offset: 0x1452970 VA: 0x181454370
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1453F70 Offset: 0x1452570 VA: 0x181453F70
	public static bool get_KeyAvailable() { }

	// RVA: 0x1453230 Offset: 0x1451830 VA: 0x181453230
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x14530E0 Offset: 0x14516E0 VA: 0x1814530E0
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1452C90 Offset: 0x1451290 VA: 0x181452C90
	internal static void DoConsoleCancelEvent() { }

}

private class Console.WindowsConsole // TypeDefIndex: 351
{	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x146D520 Offset: 0x146BB20 VA: 0x18146D520
	private static extern int GetConsoleCP() { }

	// RVA: 0x146D590 Offset: 0x146BB90 VA: 0x18146D590
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x146D4C0 Offset: 0x146BAC0 VA: 0x18146D4C0
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x146D600 Offset: 0x146BC00 VA: 0x18146D600
	public static int GetInputCodePage() { }

	// RVA: 0x146D6A0 Offset: 0x146BCA0 VA: 0x18146D6A0
	public static int GetOutputCodePage() { }

	// RVA: 0x146D740 Offset: 0x146BD40 VA: 0x18146D740
	private static void .cctor() { }

}

private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x146D1D0 Offset: 0x146B7D0 VA: 0x18146D1D0 Slot: 12
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x146D150 Offset: 0x146B750 VA: 0x18146D150 Slot: 13
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 353
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14638B0 Offset: 0x1461EB0 VA: 0x1814638B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class ConsoleDriver // TypeDefIndex: 354
{	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static ConsoleColor BackgroundColor { get; set; }
	public static int BufferWidth { get; }
	public static int CursorLeft { set; }
	public static int CursorTop { get; set; }
	public static bool KeyAvailable { get; }
	public static ConsoleColor ForegroundColor { get; set; }
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x1452480 Offset: 0x1450A80 VA: 0x181452480
	private static void .cctor() { }

	// RVA: 0x1452240 Offset: 0x1450840 VA: 0x181452240
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x14522F0 Offset: 0x14508F0 VA: 0x1814522F0
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x1452290 Offset: 0x1450890 VA: 0x181452290
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x1452540 Offset: 0x1450B40 VA: 0x181452540
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x1452940 Offset: 0x1450F40 VA: 0x181452940
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x14525B0 Offset: 0x1450BB0 VA: 0x1814525B0
	public static int get_BufferWidth() { }

	// RVA: 0x1452A00 Offset: 0x1451000 VA: 0x181452A00
	public static void set_CursorLeft(int value) { }

	// RVA: 0x1452630 Offset: 0x1450C30 VA: 0x181452630
	public static int get_CursorTop() { }

	// RVA: 0x1452A80 Offset: 0x1451080 VA: 0x181452A80
	public static void set_CursorTop(int value) { }

	// RVA: 0x14528C0 Offset: 0x1450EC0 VA: 0x1814528C0
	public static bool get_KeyAvailable() { }

	// RVA: 0x14526B0 Offset: 0x1450CB0 VA: 0x1814526B0
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x1452B00 Offset: 0x1451100 VA: 0x181452B00
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1452350 Offset: 0x1450950 VA: 0x181452350
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1452730 Offset: 0x1450D30 VA: 0x181452730
	public static bool get_IsConsole() { }

	// RVA: 0x1452340 Offset: 0x1450940 VA: 0x181452340
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x10DEAB0 Offset: 0x10DD0B0 VA: 0x1810DEAB0
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x1452470 Offset: 0x1450A70 VA: 0x181452470
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x1452460 Offset: 0x1450A60 VA: 0x181452460
	internal static bool SetEcho(bool wantEcho) { }

}

internal struct ConsoleScreenBufferInfo // TypeDefIndex: 426
{	// Fields
	public Coord Size; // 0x0
	public Coord CursorPosition; // 0x4
	public short Attribute; // 0x8
	public SmallRect Window; // 0xA
	public Coord MaxWindowSize; // 0x12

}

public class ConsoleSystem // TypeDefIndex: 6878
{
// Namespace: 
public class ConsoleSystem // TypeDefIndex: 6878
	// Fields
	public static bool HasChanges; // 0x0
	public static Func<bool> ClientCanRunAdminCommands; // 0x8
	public static Func<string, bool> OnSendToServer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, string> OnReplicatedVarChanged; // 0x18
	public static string LastError; // 0x20
	public static ConsoleSystem.Arg CurrentArgs; // 0x28

	// Methods

	// RVA: 0x22B4FC0 Offset: 0x22B35C0 VA: 0x1822B4FC0
	public static void UpdateValuesFromCommandLine() { }

	// RVA: 0x22B4F10 Offset: 0x22B3510 VA: 0x1822B4F10
	internal static bool SendToServer(string command) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B5220 Offset: 0x22B3820 VA: 0x1822B5220
	public static void add_OnReplicatedVarChanged(Action<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B5320 Offset: 0x22B3920 VA: 0x1822B5320
	public static void remove_OnReplicatedVarChanged(Action<string, string> value) { }

	// RVA: 0x22B4580 Offset: 0x22B2B80 VA: 0x1822B4580
	public static void RunFile(ConsoleSystem.Option options, string strFile) { }

	// RVA: 0x22B4710 Offset: 0x22B2D10 VA: 0x1822B4710
	public static string Run(ConsoleSystem.Option options, string strCommand, object[] args) { }

	// RVA: 0x22B3F80 Offset: 0x22B2580 VA: 0x1822B3F80
	private static bool Internal(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B3B10 Offset: 0x22B2110 VA: 0x1822B3B10
	public static string BuildCommand(string strCommand, object[] args) { }

	// RVA: 0x22B4B10 Offset: 0x22B3110 VA: 0x1822B4B10
	public static string SaveToConfigString(bool bServer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class ConsoleSystem.Arg // TypeDefIndex: 6879
{	// Fields
	public ConsoleSystem.Option Option; // 0x10
	public ConsoleSystem.Command cmd; // 0x20
	public string FullString; // 0x28
	public string[] Args; // 0x30
	public bool Invalid; // 0x38
	public string Reply; // 0x40

	// Properties
	public bool IsClientside { get; }
	public bool IsServerside { get; }
	public Connection Connection { get; }
	public bool IsConnectionAdmin { get; }
	public bool IsAdmin { get; }
	public bool IsRcon { get; }

	// Methods

	// RVA: 0xF8C110 Offset: 0xF8A710 VA: 0x180F8C110
	public bool get_IsClientside() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsServerside() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Connection get_Connection() { }

	// RVA: 0x22B2950 Offset: 0x22B0F50 VA: 0x1822B2950
	public bool get_IsConnectionAdmin() { }

	// RVA: 0x22B2920 Offset: 0x22B0F20 VA: 0x1822B2920
	public bool get_IsAdmin() { }

	// RVA: 0x13A4790 Offset: 0x13A2D90 VA: 0x1813A4790
	public bool get_IsRcon() { }

	// RVA: 0x22B2880 Offset: 0x22B0E80 VA: 0x1822B2880
	internal void .ctor(ConsoleSystem.Option options, string rconCommand) { }

	// RVA: 0x22B1890 Offset: 0x22AFE90 VA: 0x1822B1890
	internal void BuildCommand(string command) { }

	// RVA: 0x22B2560 Offset: 0x22B0B60 VA: 0x1822B2560
	internal bool HasPermission() { }

	// RVA: 0x22B1CB0 Offset: 0x22B02B0 VA: 0x1822B1CB0
	internal bool CanSeeInFind(ConsoleSystem.Command command) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	public void ReplyWith(string strValue) { }

	// RVA: 0x22B27A0 Offset: 0x22B0DA0 VA: 0x1822B27A0
	public void ReplyWith(object obj) { }

	// RVA: 0x22B2540 Offset: 0x22B0B40 VA: 0x1822B2540
	public bool HasArgs(int iMinimum = 1) { }

	// RVA: 0x22B24E0 Offset: 0x22B0AE0 VA: 0x1822B24E0
	public bool HasArg(string value) { }

	// RVA: 0x22B1FB0 Offset: 0x22B05B0 VA: 0x1822B1FB0
	public string GetString(int iArg, string def = "") { }

	// RVA: 0x22B1F40 Offset: 0x22B0540 VA: 0x1822B1F40
	public int GetInt(int iArg, int def = 0) { }

	// RVA: 0x22B2370 Offset: 0x22B0970 VA: 0x1822B2370
	public ulong GetULong(int iArg, ulong def = 0) { }

	// RVA: 0x22B2820 Offset: 0x22B0E20 VA: 0x1822B2820
	public bool TryGetUInt(int iArg, out uint value) { }

	// RVA: 0x22B23F0 Offset: 0x22B09F0 VA: 0x1822B23F0
	public uint GetUInt(int iArg, uint def = 0) { }

	// RVA: 0x22B2370 Offset: 0x22B0970 VA: 0x1822B2370
	public ulong GetUInt64(int iArg, ulong def = 0) { }

	// RVA: 0x22B1EC0 Offset: 0x22B04C0 VA: 0x1822B1EC0
	public float GetFloat(int iArg, float def = 0) { }

	// RVA: 0x22B1CE0 Offset: 0x22B02E0 VA: 0x1822B1CE0
	public bool GetBool(int iArg, bool def = False) { }

	// RVA: 0x22B2190 Offset: 0x22B0790 VA: 0x1822B2190
	public long GetTimestamp(int iArg, long def = 0) { }

	// RVA: 0x22B2000 Offset: 0x22B0600 VA: 0x1822B2000
	public long GetTicks(int iArg, long def = 0) { }

	// RVA: 0x22B26E0 Offset: 0x22B0CE0 VA: 0x1822B26E0
	public void ReplyWithObject(object rval) { }

	// RVA: 0x22B2460 Offset: 0x22B0A60 VA: 0x1822B2460
	public Vector3 GetVector3(int iArg, Vector3 def) { }

	// RVA: 0x22B1E50 Offset: 0x22B0450 VA: 0x1822B1E50
	public Color GetColor(int iArg, Color def) { }

}

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6880
{	// Fields
	public string Name; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string systemName) { }

}

public class ConsoleSystem.Command // TypeDefIndex: 6881
{	// Fields
	public string Name; // 0x10
	public string Parent; // 0x18
	public string FullName; // 0x20
	public Func<string> GetOveride; // 0x28
	public Action<string> SetOveride; // 0x30
	public Action<ConsoleSystem.Arg> Call; // 0x38
	public bool Variable; // 0x40
	public string Default; // 0x48
	public bool Saved; // 0x50
	public bool ServerAdmin; // 0x51
	public bool ServerUser; // 0x52
	public bool Replicated; // 0x53
	public bool ShowInAdminUI; // 0x54
	public bool ClientAdmin; // 0x55
	public bool Client; // 0x56
	public bool ClientInfo; // 0x57
	public bool AllowRunFromServer; // 0x58
	public string Description; // 0x60
	public string Arguments; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<ConsoleSystem.Command> OnValueChanged; // 0x70

	// Properties
	public bool Server { get; }
	public string String { get; }
	public int AsInt { get; }
	public float AsFloat { get; }
	public bool AsBool { get; }
	public Vector3 AsVector3 { get; }

	// Methods

	// RVA: 0x22B3540 Offset: 0x22B1B40 VA: 0x1822B3540
	public bool get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B3270 Offset: 0x22B1870 VA: 0x1822B3270
	public void add_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B35A0 Offset: 0x22B1BA0 VA: 0x1822B35A0
	public void remove_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	// RVA: 0x22B31C0 Offset: 0x22B17C0 VA: 0x1822B31C0
	public void .ctor() { }

	// RVA: 0x22B2FE0 Offset: 0x22B15E0 VA: 0x1822B2FE0
	private void ValueChanged() { }

	// RVA: 0x22B2CB0 Offset: 0x22B12B0 VA: 0x1822B2CB0
	private void DefaultCall(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B3550 Offset: 0x22B1B50 VA: 0x1822B3550
	public string get_String() { }

	// RVA: 0x22B3430 Offset: 0x22B1A30 VA: 0x1822B3430
	public int get_AsInt() { }

	// RVA: 0x22B33A0 Offset: 0x22B19A0 VA: 0x1822B33A0
	public float get_AsFloat() { }

	// RVA: 0x22B3310 Offset: 0x22B1910 VA: 0x1822B3310
	public bool get_AsBool() { }

	// RVA: 0x22B34C0 Offset: 0x22B1AC0 VA: 0x1822B34C0
	public Vector3 get_AsVector3() { }

	// RVA: 0x22B2E40 Offset: 0x22B1440 VA: 0x1822B2E40
	public void Set(string value) { }

	// RVA: 0x22B2F30 Offset: 0x22B1530 VA: 0x1822B2F30
	public void Set(float f) { }

	// RVA: 0x22B2D60 Offset: 0x22B1360 VA: 0x1822B2D60
	public void Set(bool val) { }

}

public static class ConsoleSystem.Index // TypeDefIndex: 6884
{	// Fields
	private static readonly Memoized<string, string> WithGlobal; // 0x0
	private static readonly Memoized<string, string> WithoutGlobal; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static ConsoleSystem.Command[] <All>k__BackingField; // 0x10

	// Properties
	public static ConsoleSystem.Command[] All { get; set; }

	// Methods

	// RVA: 0x22B5420 Offset: 0x22B3A20 VA: 0x1822B5420
	public static void Initialize(ConsoleSystem.Command[] Commands) { }

	// RVA: 0x22B5BB0 Offset: 0x22B41B0 VA: 0x1822B5BB0
	public static void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B5EA0 Offset: 0x22B44A0 VA: 0x1822B5EA0
	public static ConsoleSystem.Command[] get_All() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B5F00 Offset: 0x22B4500 VA: 0x1822B5F00
	private static void set_All(ConsoleSystem.Command[] value) { }

	// RVA: 0x22B5D60 Offset: 0x22B4360 VA: 0x1822B5D60
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6885
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8
	public static List<ConsoleSystem.Command> Replicated; // 0x10

	// Methods

	// RVA: 0x22B6080 Offset: 0x22B4680 VA: 0x1822B6080
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B61C0 Offset: 0x22B47C0 VA: 0x1822B61C0
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6886
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8

	// Methods

	// RVA: 0x22B2990 Offset: 0x22B0F90 VA: 0x1822B2990
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B2B40 Offset: 0x22B1140 VA: 0x1822B2B40
	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6887
{	// Fields
	public static readonly ConsoleSystem.Index.<>c <>9; // 0x0
	public static Action<ConsoleSystem.Command> <>9__4_1; // 0x8
	public static Action<string, bool> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x22B6810 Offset: 0x22B4E10 VA: 0x1822B6810
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B6570 Offset: 0x22B4B70 VA: 0x1822B6570
	internal void <Initialize>b__4_1(ConsoleSystem.Command command) { }

	// RVA: 0x22B6370 Offset: 0x22B4970 VA: 0x1822B6370
	internal void <Initialize>b__4_0(string strCommand, bool pressed) { }

	// RVA: 0x22B66A0 Offset: 0x22B4CA0 VA: 0x1822B66A0
	internal string <.cctor>b__10_0(string s) { }

	// RVA: 0x22B66E0 Offset: 0x22B4CE0 VA: 0x1822B66E0
	internal string <.cctor>b__10_1(string s) { }

}

public struct ConsoleSystem.Option // TypeDefIndex: 6888
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsServer>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsClient>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <ForwardtoServerOnMissing>k__BackingField; // 0x2
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <PrintOutput>k__BackingField; // 0x3
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsUnrestricted>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <FromRcon>k__BackingField; // 0x5
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsFromServer>k__BackingField; // 0x6
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Connection <Connection>k__BackingField; // 0x8

	// Properties
	public static ConsoleSystem.Option Unrestricted { get; }
	public static ConsoleSystem.Option Client { get; }
	public static ConsoleSystem.Option Server { get; }
	public bool IsServer { get; set; }
	public bool IsClient { get; set; }
	public bool ForwardtoServerOnMissing { get; set; }
	public bool PrintOutput { get; set; }
	public bool IsUnrestricted { get; set; }
	public bool FromRcon { get; set; }
	public bool IsFromServer { get; set; }
	public Connection Connection { get; set; }

	// Methods

	// RVA: 0x22B5FD0 Offset: 0x22B45D0 VA: 0x1822B5FD0
	public static ConsoleSystem.Option get_Unrestricted() { }

	// RVA: 0x22B5F90 Offset: 0x22B4590 VA: 0x1822B5F90
	public static ConsoleSystem.Option get_Client() { }

	// RVA: 0x22B5FB0 Offset: 0x22B45B0 VA: 0x1822B5FB0
	public static ConsoleSystem.Option get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x204780 Offset: 0x203B80 VA: 0x180204780
	public void set_IsServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F9DD0 Offset: 0x1F91D0 VA: 0x1801F9DD0
	public bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D60 Offset: 0x236160 VA: 0x180236D60
	public void set_IsClient(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120EE0 Offset: 0x1202E0 VA: 0x180120EE0
	public bool get_ForwardtoServerOnMissing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D50 Offset: 0x236150 VA: 0x180236D50
	public void set_ForwardtoServerOnMissing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120E90 Offset: 0x120290 VA: 0x180120E90
	public bool get_PrintOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23AF00 Offset: 0x23A300 VA: 0x18023AF00
	public void set_PrintOutput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120EB0 Offset: 0x1202B0 VA: 0x180120EB0
	public bool get_IsUnrestricted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122FD0 Offset: 0x1223D0 VA: 0x180122FD0
	public void set_IsUnrestricted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x120EC0 Offset: 0x1202C0 VA: 0x180120EC0
	public bool get_FromRcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23AEE0 Offset: 0x23A2E0 VA: 0x18023AEE0
	public void set_FromRcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23AED0 Offset: 0x23A2D0 VA: 0x18023AED0
	public bool get_IsFromServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23AEF0 Offset: 0x23A2F0 VA: 0x18023AEF0
	public void set_IsFromServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_Connection(Connection value) { }

	// RVA: 0x23AEC0 Offset: 0x23A2C0 VA: 0x18023AEC0
	public ConsoleSystem.Option Quiet() { }

	// RVA: 0x23AEB0 Offset: 0x23A2B0 VA: 0x18023AEB0
	public ConsoleSystem.Option FromServer() { }

	// RVA: 0x23AE70 Offset: 0x23A270 VA: 0x18023AE70
	public ConsoleSystem.Option FromConnection(Connection connection) { }

}

private sealed class ConsoleSystem.<>c // TypeDefIndex: 6889
{	// Fields
	public static readonly ConsoleSystem.<>c <>9; // 0x0
	public static Func<ConsoleSystem.Command, bool> <>9__21_0; // 0x8
	public static Func<ConsoleSystem.Command, bool> <>9__21_1; // 0x10

	// Methods

	// RVA: 0x22B67B0 Offset: 0x22B4DB0 VA: 0x1822B67B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B6640 Offset: 0x22B4C40 VA: 0x1822B6640
	internal bool <SaveToConfigString>b__21_0(ConsoleSystem.Command x) { }

	// RVA: 0x22B6670 Offset: 0x22B4C70 VA: 0x1822B6670
	internal bool <SaveToConfigString>b__21_1(ConsoleSystem.Command x) { }

}

public class ConsoleVar : Attribute // TypeDefIndex: 6890
{	// Fields
	public string Name; // 0x10
	public bool ClientAdmin; // 0x18
	public bool ServerAdmin; // 0x19
	public bool ServerUser; // 0x1A
	public bool Saved; // 0x1B
	public string Help; // 0x20
	public bool ClientInfo; // 0x28
	public bool Replicated; // 0x29
	public bool Clientside; // 0x2A
	public bool Serverside; // 0x2B
	public bool EditorOnly; // 0x2C
	public bool AllowRunFromServer; // 0x2D
	public string Default; // 0x30
	public string[] PreprocessorConditions; // 0x38
	public bool ShowInAdminUI; // 0x40

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public class ConsoleGen // TypeDefIndex: 8299
{	// Fields
	public static ConsoleSystem.Command[] All; // 0x2AC0

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2FD150 Offset: 0x2FB750 VA: 0x1802FD150
	private static void .cctor() { }

}

private sealed class ConsoleGen.<>c // TypeDefIndex: 8300
{	// Fields
	public static readonly ConsoleGen.<>c <>9; // 0x2B27

	// Methods

	// RVA: 0xE2A900 Offset: 0xE28F00 VA: 0x180E2A900
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE08910 Offset: 0xE06F10 VA: 0x180E08910
	internal string <.cctor>b__2_0() { }

	// RVA: 0xE0FB00 Offset: 0xE0E100 VA: 0x180E0FB00
	internal void <.cctor>b__2_1(string str) { }

	// RVA: 0xE13270 Offset: 0xE11870 VA: 0x180E13270
	internal string <.cctor>b__2_2() { }

	// RVA: 0xE16760 Offset: 0xE14D60 VA: 0x180E16760
	internal void <.cctor>b__2_3(string str) { }

	// RVA: 0xE19760 Offset: 0xE17D60 VA: 0x180E19760
	internal string <.cctor>b__2_4() { }

	// RVA: 0xE1CE60 Offset: 0xE1B460 VA: 0x180E1CE60
	internal void <.cctor>b__2_5(string str) { }

	// RVA: 0xE208E0 Offset: 0xE1EEE0 VA: 0x180E208E0
	internal string <.cctor>b__2_6() { }

	// RVA: 0xE23E40 Offset: 0xE22440 VA: 0x180E23E40
	internal void <.cctor>b__2_7(string str) { }

	// RVA: 0xE27220 Offset: 0xE25820 VA: 0x180E27220
	internal string <.cctor>b__2_8() { }

	// RVA: 0xE2A850 Offset: 0xE28E50 VA: 0x180E2A850
	internal void <.cctor>b__2_9(string str) { }

	// RVA: 0xE0B9A0 Offset: 0xE09FA0 VA: 0x180E0B9A0
	internal string <.cctor>b__2_10() { }

	// RVA: 0xE0CED0 Offset: 0xE0B4D0 VA: 0x180E0CED0
	internal void <.cctor>b__2_11(string str) { }

	// RVA: 0xE0D470 Offset: 0xE0BA70 VA: 0x180E0D470
	internal string <.cctor>b__2_12() { }

	// RVA: 0xE0D970 Offset: 0xE0BF70 VA: 0x180E0D970
	internal void <.cctor>b__2_13(string str) { }

	// RVA: 0xE0DF00 Offset: 0xE0C500 VA: 0x180E0DF00
	internal string <.cctor>b__2_14() { }

	// RVA: 0xE0E440 Offset: 0xE0CA40 VA: 0x180E0E440
	internal void <.cctor>b__2_15(string str) { }

	// RVA: 0xE0E9B0 Offset: 0xE0CFB0 VA: 0x180E0E9B0
	internal string <.cctor>b__2_16() { }

	// RVA: 0xE0EF50 Offset: 0xE0D550 VA: 0x180E0EF50
	internal void <.cctor>b__2_17(string str) { }

	// RVA: 0xE0F550 Offset: 0xE0DB50 VA: 0x180E0F550
	internal string <.cctor>b__2_18() { }

	// RVA: 0xE0FA50 Offset: 0xE0E050 VA: 0x180E0FA50
	internal void <.cctor>b__2_19(string str) { }

	// RVA: 0xE100A0 Offset: 0xE0E6A0 VA: 0x180E100A0
	internal string <.cctor>b__2_20() { }

	// RVA: 0xE10570 Offset: 0xE0EB70 VA: 0x180E10570
	internal void <.cctor>b__2_21(string str) { }

	// RVA: 0xE10A50 Offset: 0xE0F050 VA: 0x180E10A50
	internal string <.cctor>b__2_22() { }

	// RVA: 0xE10FF0 Offset: 0xE0F5F0 VA: 0x180E10FF0
	internal void <.cctor>b__2_23(string str) { }

	// RVA: 0xE11560 Offset: 0xE0FB60 VA: 0x180E11560
	internal string <.cctor>b__2_24() { }

	// RVA: 0xE11B30 Offset: 0xE10130 VA: 0x180E11B30
	internal void <.cctor>b__2_25(string str) { }

	// RVA: 0xE120D0 Offset: 0xE106D0 VA: 0x180E120D0
	internal string <.cctor>b__2_26() { }

	// RVA: 0xE12660 Offset: 0xE10C60 VA: 0x180E12660
	internal void <.cctor>b__2_27(string str) { }

	// RVA: 0xE12CB0 Offset: 0xE112B0 VA: 0x180E12CB0
	internal string <.cctor>b__2_28() { }

	// RVA: 0xE131C0 Offset: 0xE117C0 VA: 0x180E131C0
	internal void <.cctor>b__2_29(string str) { }

	// RVA: 0xE13700 Offset: 0xE11D00 VA: 0x180E13700
	internal string <.cctor>b__2_30() { }

	// RVA: 0xE13C20 Offset: 0xE12220 VA: 0x180E13C20
	internal void <.cctor>b__2_31(string str) { }

	// RVA: 0xE14240 Offset: 0xE12840 VA: 0x180E14240
	internal string <.cctor>b__2_32() { }

	// RVA: 0xE146B0 Offset: 0xE12CB0 VA: 0x180E146B0
	internal void <.cctor>b__2_33(string str) { }

	// RVA: 0xE14AA0 Offset: 0xE130A0 VA: 0x180E14AA0
	internal string <.cctor>b__2_34() { }

	// RVA: 0xE15010 Offset: 0xE13610 VA: 0x180E15010
	internal void <.cctor>b__2_35(string str) { }

	// RVA: 0xE155F0 Offset: 0xE13BF0 VA: 0x180E155F0
	internal string <.cctor>b__2_36() { }

	// RVA: 0xE15B50 Offset: 0xE14150 VA: 0x180E15B50
	internal void <.cctor>b__2_37(string str) { }

	// RVA: 0xE160F0 Offset: 0xE146F0 VA: 0x180E160F0
	internal string <.cctor>b__2_38() { }

	// RVA: 0xE166B0 Offset: 0xE14CB0 VA: 0x180E166B0
	internal void <.cctor>b__2_39(string str) { }

	// RVA: 0xE16C50 Offset: 0xE15250 VA: 0x180E16C50
	internal string <.cctor>b__2_40() { }

	// RVA: 0xE17170 Offset: 0xE15770 VA: 0x180E17170
	internal void <.cctor>b__2_41(string str) { }

	// RVA: 0xE17760 Offset: 0xE15D60 VA: 0x180E17760
	internal string <.cctor>b__2_42() { }

	// RVA: 0xE17C60 Offset: 0xE16260 VA: 0x180E17C60
	internal void <.cctor>b__2_43(string str) { }

	// RVA: 0xE18220 Offset: 0xE16820 VA: 0x180E18220
	internal string <.cctor>b__2_44() { }

	// RVA: 0xE187A0 Offset: 0xE16DA0 VA: 0x180E187A0
	internal void <.cctor>b__2_45(string str) { }

	// RVA: 0xE18D50 Offset: 0xE17350 VA: 0x180E18D50
	internal string <.cctor>b__2_46() { }

	// RVA: 0xE19240 Offset: 0xE17840 VA: 0x180E19240
	internal void <.cctor>b__2_47(string str) { }

	// RVA: 0xE193E0 Offset: 0xE179E0 VA: 0x180E193E0
	internal string <.cctor>b__2_48() { }

	// RVA: 0xE196B0 Offset: 0xE17CB0 VA: 0x180E196B0
	internal void <.cctor>b__2_49(string str) { }

	// RVA: 0xE19C60 Offset: 0xE18260 VA: 0x180E19C60
	internal string <.cctor>b__2_50() { }

	// RVA: 0xE1A170 Offset: 0xE18770 VA: 0x180E1A170
	internal void <.cctor>b__2_51(string str) { }

	// RVA: 0xE1A710 Offset: 0xE18D10 VA: 0x180E1A710
	internal string <.cctor>b__2_52() { }

	// RVA: 0xE1ACB0 Offset: 0xE192B0 VA: 0x180E1ACB0
	internal void <.cctor>b__2_53(string str) { }

	// RVA: 0xE1B1F0 Offset: 0xE197F0 VA: 0x180E1B1F0
	internal string <.cctor>b__2_54() { }

	// RVA: 0xE1B720 Offset: 0xE19D20 VA: 0x180E1B720
	internal void <.cctor>b__2_55(string str) { }

	// RVA: 0xE1BD60 Offset: 0xE1A360 VA: 0x180E1BD60
	internal string <.cctor>b__2_56() { }

	// RVA: 0xE1C260 Offset: 0xE1A860 VA: 0x180E1C260
	internal void <.cctor>b__2_57(string str) { }

	// RVA: 0xE1C800 Offset: 0xE1AE00 VA: 0x180E1C800
	internal string <.cctor>b__2_58() { }

	// RVA: 0xE1CDB0 Offset: 0xE1B3B0 VA: 0x180E1CDB0
	internal void <.cctor>b__2_59(string str) { }

	// RVA: 0xE1D3D0 Offset: 0xE1B9D0 VA: 0x180E1D3D0
	internal string <.cctor>b__2_60() { }

	// RVA: 0xE1D940 Offset: 0xE1BF40 VA: 0x180E1D940
	internal void <.cctor>b__2_61(string str) { }

	// RVA: 0xE1DF00 Offset: 0xE1C500 VA: 0x180E1DF00
	internal string <.cctor>b__2_62() { }

	// RVA: 0xE1E5F0 Offset: 0xE1CBF0 VA: 0x180E1E5F0
	internal void <.cctor>b__2_63(string str) { }

	// RVA: 0xE1EBA0 Offset: 0xE1D1A0 VA: 0x180E1EBA0
	internal string <.cctor>b__2_64() { }

	// RVA: 0xE1F110 Offset: 0xE1D710 VA: 0x180E1F110
	internal void <.cctor>b__2_65(string str) { }

	// RVA: 0xE1F6A0 Offset: 0xE1DCA0 VA: 0x180E1F6A0
	internal string <.cctor>b__2_66() { }

	// RVA: 0xE1FC70 Offset: 0xE1E270 VA: 0x180E1FC70
	internal void <.cctor>b__2_67(string str) { }

	// RVA: 0xE20260 Offset: 0xE1E860 VA: 0x180E20260
	internal string <.cctor>b__2_68() { }

	// RVA: 0xE20830 Offset: 0xE1EE30 VA: 0x180E20830
	internal void <.cctor>b__2_69(string str) { }

	// RVA: 0xE20EE0 Offset: 0xE1F4E0 VA: 0x180E20EE0
	internal string <.cctor>b__2_70() { }

	// RVA: 0xE213F0 Offset: 0xE1F9F0 VA: 0x180E213F0
	internal void <.cctor>b__2_71(string str) { }

	// RVA: 0xE21980 Offset: 0xE1FF80 VA: 0x180E21980
	internal string <.cctor>b__2_72() { }

	// RVA: 0xE21F20 Offset: 0xE20520 VA: 0x180E21F20
	internal void <.cctor>b__2_73(string str) { }

	// RVA: 0xE22560 Offset: 0xE20B60 VA: 0x180E22560
	internal string <.cctor>b__2_74() { }

	// RVA: 0xE229E0 Offset: 0xE20FE0 VA: 0x180E229E0
	internal void <.cctor>b__2_75(string str) { }

	// RVA: 0xE22E90 Offset: 0xE21490 VA: 0x180E22E90
	internal string <.cctor>b__2_76() { }

	// RVA: 0xE23210 Offset: 0xE21810 VA: 0x180E23210
	internal void <.cctor>b__2_77(string str) { }

	// RVA: 0xE23830 Offset: 0xE21E30 VA: 0x180E23830
	internal string <.cctor>b__2_78() { }

	// RVA: 0xE23D90 Offset: 0xE22390 VA: 0x180E23D90
	internal void <.cctor>b__2_79(string str) { }

	// RVA: 0xE24210 Offset: 0xE22810 VA: 0x180E24210
	internal string <.cctor>b__2_80() { }

	// RVA: 0xE247A0 Offset: 0xE22DA0 VA: 0x180E247A0
	internal void <.cctor>b__2_81(string str) { }

	// RVA: 0xE24B20 Offset: 0xE23120 VA: 0x180E24B20
	internal string <.cctor>b__2_82() { }

	// RVA: 0xE250B0 Offset: 0xE236B0 VA: 0x180E250B0
	internal void <.cctor>b__2_83(string str) { }

	// RVA: 0xE255D0 Offset: 0xE23BD0 VA: 0x180E255D0
	internal string <.cctor>b__2_84() { }

	// RVA: 0xE25B80 Offset: 0xE24180 VA: 0x180E25B80
	internal void <.cctor>b__2_85(string str) { }

	// RVA: 0xE26110 Offset: 0xE24710 VA: 0x180E26110
	internal string <.cctor>b__2_86() { }

	// RVA: 0xE266E0 Offset: 0xE24CE0 VA: 0x180E266E0
	internal void <.cctor>b__2_87(string str) { }

	// RVA: 0xE26C70 Offset: 0xE25270 VA: 0x180E26C70
	internal string <.cctor>b__2_88() { }

	// RVA: 0xE27170 Offset: 0xE25770 VA: 0x180E27170
	internal void <.cctor>b__2_89(string str) { }

	// RVA: 0xE276B0 Offset: 0xE25CB0 VA: 0x180E276B0
	internal string <.cctor>b__2_90() { }

	// RVA: 0xE27CC0 Offset: 0xE262C0 VA: 0x180E27CC0
	internal void <.cctor>b__2_91(string str) { }

	// RVA: 0xE281C0 Offset: 0xE267C0 VA: 0x180E281C0
	internal string <.cctor>b__2_92() { }

	// RVA: 0xE28770 Offset: 0xE26D70 VA: 0x180E28770
	internal void <.cctor>b__2_93(string str) { }

	// RVA: 0xE28D10 Offset: 0xE27310 VA: 0x180E28D10
	internal string <.cctor>b__2_94() { }

	// RVA: 0xE29280 Offset: 0xE27880 VA: 0x180E29280
	internal void <.cctor>b__2_95(string str) { }

	// RVA: 0xE297E0 Offset: 0xE27DE0 VA: 0x180E297E0
	internal string <.cctor>b__2_96() { }

	// RVA: 0xE29D10 Offset: 0xE28310 VA: 0x180E29D10
	internal void <.cctor>b__2_97(string str) { }

	// RVA: 0xE2A270 Offset: 0xE28870 VA: 0x180E2A270
	internal string <.cctor>b__2_98() { }

	// RVA: 0xE2A7A0 Offset: 0xE28DA0 VA: 0x180E2A7A0
	internal void <.cctor>b__2_99(string str) { }

	// RVA: 0xE08DF0 Offset: 0xE073F0 VA: 0x180E08DF0
	internal string <.cctor>b__2_100() { }

	// RVA: 0xE09210 Offset: 0xE07810 VA: 0x180E09210
	internal void <.cctor>b__2_101(string str) { }

	// RVA: 0xE09760 Offset: 0xE07D60 VA: 0x180E09760
	internal string <.cctor>b__2_102() { }

	// RVA: 0xE09A60 Offset: 0xE08060 VA: 0x180E09A60
	internal void <.cctor>b__2_103(string str) { }

	// RVA: 0xE09E50 Offset: 0xE08450 VA: 0x180E09E50
	internal string <.cctor>b__2_104() { }

	// RVA: 0xE0A3E0 Offset: 0xE089E0 VA: 0x180E0A3E0
	internal void <.cctor>b__2_105(string str) { }

	// RVA: 0xE0AA00 Offset: 0xE09000 VA: 0x180E0AA00
	internal string <.cctor>b__2_106() { }

	// RVA: 0xE0AE70 Offset: 0xE09470 VA: 0x180E0AE70
	internal void <.cctor>b__2_107(string str) { }

	// RVA: 0xE0B390 Offset: 0xE09990 VA: 0x180E0B390
	internal string <.cctor>b__2_108() { }

	// RVA: 0xE0B8F0 Offset: 0xE09EF0 VA: 0x180E0B8F0
	internal void <.cctor>b__2_109(string str) { }

	// RVA: 0xE0BED0 Offset: 0xE0A4D0 VA: 0x180E0BED0
	internal string <.cctor>b__2_110() { }

	// RVA: 0xE0C3F0 Offset: 0xE0A9F0 VA: 0x180E0C3F0
	internal void <.cctor>b__2_111(string str) { }

	// RVA: 0xE0C9B0 Offset: 0xE0AFB0 VA: 0x180E0C9B0
	internal string <.cctor>b__2_112() { }

	// RVA: 0xE0CC20 Offset: 0xE0B220 VA: 0x180E0CC20
	internal void <.cctor>b__2_113(string str) { }

	// RVA: 0xE0CCD0 Offset: 0xE0B2D0 VA: 0x180E0CCD0
	internal void <.cctor>b__2_114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CD30 Offset: 0xE0B330 VA: 0x180E0CD30
	internal void <.cctor>b__2_115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CD80 Offset: 0xE0B380 VA: 0x180E0CD80
	internal void <.cctor>b__2_116(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CDB0 Offset: 0xE0B3B0 VA: 0x180E0CDB0
	internal void <.cctor>b__2_117(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CDC0 Offset: 0xE0B3C0 VA: 0x180E0CDC0
	internal string <.cctor>b__2_118() { }

	// RVA: 0xE0CE20 Offset: 0xE0B420 VA: 0x180E0CE20
	internal void <.cctor>b__2_119(string str) { }

	// RVA: 0xE0CF80 Offset: 0xE0B580 VA: 0x180E0CF80
	internal string <.cctor>b__2_120() { }

	// RVA: 0xE0CFE0 Offset: 0xE0B5E0 VA: 0x180E0CFE0
	internal void <.cctor>b__2_121(string str) { }

	// RVA: 0xE0D070 Offset: 0xE0B670 VA: 0x180E0D070
	internal string <.cctor>b__2_122() { }

	// RVA: 0xE0D0D0 Offset: 0xE0B6D0 VA: 0x180E0D0D0
	internal void <.cctor>b__2_123(string str) { }

	// RVA: 0xE0D160 Offset: 0xE0B760 VA: 0x180E0D160
	internal string <.cctor>b__2_124() { }

	// RVA: 0xE0D1C0 Offset: 0xE0B7C0 VA: 0x180E0D1C0
	internal void <.cctor>b__2_125(string str) { }

	// RVA: 0xE0D270 Offset: 0xE0B870 VA: 0x180E0D270
	internal string <.cctor>b__2_126() { }

	// RVA: 0xE0D2D0 Offset: 0xE0B8D0 VA: 0x180E0D2D0
	internal void <.cctor>b__2_127(string str) { }

	// RVA: 0xE0D360 Offset: 0xE0B960 VA: 0x180E0D360
	internal string <.cctor>b__2_128() { }

	// RVA: 0xE0D3C0 Offset: 0xE0B9C0 VA: 0x180E0D3C0
	internal void <.cctor>b__2_129(string str) { }

	// RVA: 0xE0D4F0 Offset: 0xE0BAF0 VA: 0x180E0D4F0
	internal string <.cctor>b__2_130() { }

	// RVA: 0xE0D550 Offset: 0xE0BB50 VA: 0x180E0D550
	internal void <.cctor>b__2_131(string str) { }

	// RVA: 0xE0D600 Offset: 0xE0BC00 VA: 0x180E0D600
	internal void <.cctor>b__2_132(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D660 Offset: 0xE0BC60 VA: 0x180E0D660
	internal void <.cctor>b__2_133(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D6C0 Offset: 0xE0BCC0 VA: 0x180E0D6C0
	internal void <.cctor>b__2_134(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D720 Offset: 0xE0BD20 VA: 0x180E0D720
	internal void <.cctor>b__2_135(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D780 Offset: 0xE0BD80 VA: 0x180E0D780
	internal string <.cctor>b__2_136() { }

	// RVA: 0xE0D7E0 Offset: 0xE0BDE0 VA: 0x180E0D7E0
	internal void <.cctor>b__2_137(string str) { }

	// RVA: 0xE0D870 Offset: 0xE0BE70 VA: 0x180E0D870
	internal string <.cctor>b__2_138() { }

	// RVA: 0xE0D8D0 Offset: 0xE0BED0 VA: 0x180E0D8D0
	internal void <.cctor>b__2_139(string str) { }

	// RVA: 0xE0DA20 Offset: 0xE0C020 VA: 0x180E0DA20
	internal string <.cctor>b__2_140() { }

	// RVA: 0xE0DA80 Offset: 0xE0C080 VA: 0x180E0DA80
	internal void <.cctor>b__2_141(string str) { }

	// RVA: 0xE0DB20 Offset: 0xE0C120 VA: 0x180E0DB20
	internal void <.cctor>b__2_142(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DB90 Offset: 0xE0C190 VA: 0x180E0DB90
	internal void <.cctor>b__2_143(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DBF0 Offset: 0xE0C1F0 VA: 0x180E0DBF0
	internal string <.cctor>b__2_144() { }

	// RVA: 0xE0DC50 Offset: 0xE0C250 VA: 0x180E0DC50
	internal void <.cctor>b__2_145(string str) { }

	// RVA: 0xE0DCF0 Offset: 0xE0C2F0 VA: 0x180E0DCF0
	internal string <.cctor>b__2_146() { }

	// RVA: 0xE0DD50 Offset: 0xE0C350 VA: 0x180E0DD50
	internal void <.cctor>b__2_147(string str) { }

	// RVA: 0xE0DE00 Offset: 0xE0C400 VA: 0x180E0DE00
	internal string <.cctor>b__2_148() { }

	// RVA: 0xE0DE60 Offset: 0xE0C460 VA: 0x180E0DE60
	internal void <.cctor>b__2_149(string str) { }

	// RVA: 0xE0DF80 Offset: 0xE0C580 VA: 0x180E0DF80
	internal void <.cctor>b__2_150(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DFE0 Offset: 0xE0C5E0 VA: 0x180E0DFE0
	internal void <.cctor>b__2_151(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E040 Offset: 0xE0C640 VA: 0x180E0E040
	internal string <.cctor>b__2_152() { }

	// RVA: 0xE0E0A0 Offset: 0xE0C6A0 VA: 0x180E0E0A0
	internal void <.cctor>b__2_153(string str) { }

	// RVA: 0xE0E140 Offset: 0xE0C740 VA: 0x180E0E140
	internal string <.cctor>b__2_154() { }

	// RVA: 0xE0E1A0 Offset: 0xE0C7A0 VA: 0x180E0E1A0
	internal void <.cctor>b__2_155(string str) { }

	// RVA: 0xE0E240 Offset: 0xE0C840 VA: 0x180E0E240
	internal string <.cctor>b__2_156() { }

	// RVA: 0xE0E2A0 Offset: 0xE0C8A0 VA: 0x180E0E2A0
	internal void <.cctor>b__2_157(string str) { }

	// RVA: 0xE0E340 Offset: 0xE0C940 VA: 0x180E0E340
	internal string <.cctor>b__2_158() { }

	// RVA: 0xE0E3A0 Offset: 0xE0C9A0 VA: 0x180E0E3A0
	internal void <.cctor>b__2_159(string str) { }

	// RVA: 0xE0E4F0 Offset: 0xE0CAF0 VA: 0x180E0E4F0
	internal string <.cctor>b__2_160() { }

	// RVA: 0xE0E550 Offset: 0xE0CB50 VA: 0x180E0E550
	internal void <.cctor>b__2_161(string str) { }

	// RVA: 0xE0E600 Offset: 0xE0CC00 VA: 0x180E0E600
	internal string <.cctor>b__2_162() { }

	// RVA: 0xE0E660 Offset: 0xE0CC60 VA: 0x180E0E660
	internal void <.cctor>b__2_163(string str) { }

	// RVA: 0xE0E700 Offset: 0xE0CD00 VA: 0x180E0E700
	internal void <.cctor>b__2_164(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E760 Offset: 0xE0CD60 VA: 0x180E0E760
	internal string <.cctor>b__2_165() { }

	// RVA: 0xE0E7E0 Offset: 0xE0CDE0 VA: 0x180E0E7E0
	internal void <.cctor>b__2_166(string str) { }

	// RVA: 0xE0E850 Offset: 0xE0CE50 VA: 0x180E0E850
	internal string <.cctor>b__2_167() { }

	// RVA: 0xE0E8B0 Offset: 0xE0CEB0 VA: 0x180E0E8B0
	internal void <.cctor>b__2_168(string str) { }

	// RVA: 0xE0E950 Offset: 0xE0CF50 VA: 0x180E0E950
	internal string <.cctor>b__2_169() { }

	// RVA: 0xE0EA30 Offset: 0xE0D030 VA: 0x180E0EA30
	internal void <.cctor>b__2_170(string str) { }

	// RVA: 0xE0EAD0 Offset: 0xE0D0D0 VA: 0x180E0EAD0
	internal string <.cctor>b__2_171() { }

	// RVA: 0xE0EB30 Offset: 0xE0D130 VA: 0x180E0EB30
	internal void <.cctor>b__2_172(string str) { }

	// RVA: 0xE0EBD0 Offset: 0xE0D1D0 VA: 0x180E0EBD0
	internal string <.cctor>b__2_173() { }

	// RVA: 0xE0EC30 Offset: 0xE0D230 VA: 0x180E0EC30
	internal void <.cctor>b__2_174(string str) { }

	// RVA: 0xE0ECE0 Offset: 0xE0D2E0 VA: 0x180E0ECE0
	internal string <.cctor>b__2_175() { }

	// RVA: 0xE0ED40 Offset: 0xE0D340 VA: 0x180E0ED40
	internal void <.cctor>b__2_176(string str) { }

	// RVA: 0xE0EDF0 Offset: 0xE0D3F0 VA: 0x180E0EDF0
	internal string <.cctor>b__2_177() { }

	// RVA: 0xE0EE50 Offset: 0xE0D450 VA: 0x180E0EE50
	internal void <.cctor>b__2_178(string str) { }

	// RVA: 0xE0EEF0 Offset: 0xE0D4F0 VA: 0x180E0EEF0
	internal string <.cctor>b__2_179() { }

	// RVA: 0xE0F000 Offset: 0xE0D600 VA: 0x180E0F000
	internal void <.cctor>b__2_180(string str) { }

	// RVA: 0xE0F0B0 Offset: 0xE0D6B0 VA: 0x180E0F0B0
	internal string <.cctor>b__2_181() { }

	// RVA: 0xE0F110 Offset: 0xE0D710 VA: 0x180E0F110
	internal void <.cctor>b__2_182(string str) { }

	// RVA: 0xE0F1C0 Offset: 0xE0D7C0 VA: 0x180E0F1C0
	internal string <.cctor>b__2_183() { }

	// RVA: 0xE0F220 Offset: 0xE0D820 VA: 0x180E0F220
	internal void <.cctor>b__2_184(string str) { }

	// RVA: 0xE0F2D0 Offset: 0xE0D8D0 VA: 0x180E0F2D0
	internal string <.cctor>b__2_185() { }

	// RVA: 0xE0F330 Offset: 0xE0D930 VA: 0x180E0F330
	internal void <.cctor>b__2_186(string str) { }

	// RVA: 0xE0F3E0 Offset: 0xE0D9E0 VA: 0x180E0F3E0
	internal string <.cctor>b__2_187() { }

	// RVA: 0xE0F440 Offset: 0xE0DA40 VA: 0x180E0F440
	internal void <.cctor>b__2_188(string str) { }

	// RVA: 0xE0F4F0 Offset: 0xE0DAF0 VA: 0x180E0F4F0
	internal void <.cctor>b__2_189(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F5D0 Offset: 0xE0DBD0 VA: 0x180E0F5D0
	internal void <.cctor>b__2_190(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F630 Offset: 0xE0DC30 VA: 0x180E0F630
	internal string <.cctor>b__2_191() { }

	// RVA: 0xE0F690 Offset: 0xE0DC90 VA: 0x180E0F690
	internal void <.cctor>b__2_192(string str) { }

	// RVA: 0xE0F710 Offset: 0xE0DD10 VA: 0x180E0F710
	internal string <.cctor>b__2_193() { }

	// RVA: 0xE0F770 Offset: 0xE0DD70 VA: 0x180E0F770
	internal void <.cctor>b__2_194(string str) { }

	// RVA: 0xE0F820 Offset: 0xE0DE20 VA: 0x180E0F820
	internal string <.cctor>b__2_195() { }

	// RVA: 0xE0F880 Offset: 0xE0DE80 VA: 0x180E0F880
	internal void <.cctor>b__2_196(string str) { }

	// RVA: 0xE0F930 Offset: 0xE0DF30 VA: 0x180E0F930
	internal void <.cctor>b__2_197(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F990 Offset: 0xE0DF90 VA: 0x180E0F990
	internal void <.cctor>b__2_198(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F9F0 Offset: 0xE0DFF0 VA: 0x180E0F9F0
	internal string <.cctor>b__2_199() { }

	// RVA: 0xE0FBA0 Offset: 0xE0E1A0 VA: 0x180E0FBA0
	internal void <.cctor>b__2_200(string str) { }

	// RVA: 0xE0FC40 Offset: 0xE0E240 VA: 0x180E0FC40
	internal string <.cctor>b__2_201() { }

	// RVA: 0xE0FCA0 Offset: 0xE0E2A0 VA: 0x180E0FCA0
	internal void <.cctor>b__2_202(string str) { }

	// RVA: 0xE0FD40 Offset: 0xE0E340 VA: 0x180E0FD40
	internal string <.cctor>b__2_203() { }

	// RVA: 0xE0FDA0 Offset: 0xE0E3A0 VA: 0x180E0FDA0
	internal void <.cctor>b__2_204(string str) { }

	// RVA: 0xE0FE40 Offset: 0xE0E440 VA: 0x180E0FE40
	internal string <.cctor>b__2_205() { }

	// RVA: 0xE0FEA0 Offset: 0xE0E4A0 VA: 0x180E0FEA0
	internal void <.cctor>b__2_206(string str) { }

	// RVA: 0xE0FF40 Offset: 0xE0E540 VA: 0x180E0FF40
	internal string <.cctor>b__2_207() { }

	// RVA: 0xE0FFA0 Offset: 0xE0E5A0 VA: 0x180E0FFA0
	internal void <.cctor>b__2_208(string str) { }

	// RVA: 0xE10040 Offset: 0xE0E640 VA: 0x180E10040
	internal string <.cctor>b__2_209() { }

	// RVA: 0xE10120 Offset: 0xE0E720 VA: 0x180E10120
	internal void <.cctor>b__2_210(string str) { }

	// RVA: 0xE101C0 Offset: 0xE0E7C0 VA: 0x180E101C0
	internal void <.cctor>b__2_211(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10220 Offset: 0xE0E820 VA: 0x180E10220
	internal void <.cctor>b__2_212(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10280 Offset: 0xE0E880 VA: 0x180E10280
	internal void <.cctor>b__2_213(ConsoleSystem.Arg arg) { }

	// RVA: 0xE102D0 Offset: 0xE0E8D0 VA: 0x180E102D0
	internal string <.cctor>b__2_214() { }

	// RVA: 0xE10330 Offset: 0xE0E930 VA: 0x180E10330
	internal void <.cctor>b__2_215(string str) { }

	// RVA: 0xE103D0 Offset: 0xE0E9D0 VA: 0x180E103D0
	internal void <.cctor>b__2_216(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10430 Offset: 0xE0EA30 VA: 0x180E10430
	internal string <.cctor>b__2_217() { }

	// RVA: 0xE10490 Offset: 0xE0EA90 VA: 0x180E10490
	internal void <.cctor>b__2_218(string str) { }

	// RVA: 0xE10510 Offset: 0xE0EB10 VA: 0x180E10510
	internal void <.cctor>b__2_219(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10620 Offset: 0xE0EC20 VA: 0x180E10620
	internal void <.cctor>b__2_220(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10670 Offset: 0xE0EC70 VA: 0x180E10670
	internal void <.cctor>b__2_221(ConsoleSystem.Arg arg) { }

	// RVA: 0xE106D0 Offset: 0xE0ECD0 VA: 0x180E106D0
	internal void <.cctor>b__2_222(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10730 Offset: 0xE0ED30 VA: 0x180E10730
	internal void <.cctor>b__2_223(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10790 Offset: 0xE0ED90 VA: 0x180E10790
	internal void <.cctor>b__2_224(ConsoleSystem.Arg arg) { }

	// RVA: 0xE107F0 Offset: 0xE0EDF0 VA: 0x180E107F0
	internal string <.cctor>b__2_225() { }

	// RVA: 0xE10870 Offset: 0xE0EE70 VA: 0x180E10870
	internal void <.cctor>b__2_226(string str) { }

	// RVA: 0xE108E0 Offset: 0xE0EEE0 VA: 0x180E108E0
	internal string <.cctor>b__2_227() { }

	// RVA: 0xE10940 Offset: 0xE0EF40 VA: 0x180E10940
	internal void <.cctor>b__2_228(string str) { }

	// RVA: 0xE109F0 Offset: 0xE0EFF0 VA: 0x180E109F0
	internal string <.cctor>b__2_229() { }

	// RVA: 0xE10AD0 Offset: 0xE0F0D0 VA: 0x180E10AD0
	internal void <.cctor>b__2_230(string str) { }

	// RVA: 0xE10B80 Offset: 0xE0F180 VA: 0x180E10B80
	internal string <.cctor>b__2_231() { }

	// RVA: 0xE10BE0 Offset: 0xE0F1E0 VA: 0x180E10BE0
	internal void <.cctor>b__2_232(string str) { }

	// RVA: 0xE10C90 Offset: 0xE0F290 VA: 0x180E10C90
	internal string <.cctor>b__2_233() { }

	// RVA: 0xE10CF0 Offset: 0xE0F2F0 VA: 0x180E10CF0
	internal void <.cctor>b__2_234(string str) { }

	// RVA: 0xE10D90 Offset: 0xE0F390 VA: 0x180E10D90
	internal string <.cctor>b__2_235() { }

	// RVA: 0xE10DF0 Offset: 0xE0F3F0 VA: 0x180E10DF0
	internal void <.cctor>b__2_236(string str) { }

	// RVA: 0xE10EA0 Offset: 0xE0F4A0 VA: 0x180E10EA0
	internal string <.cctor>b__2_237() { }

	// RVA: 0xE10F00 Offset: 0xE0F500 VA: 0x180E10F00
	internal void <.cctor>b__2_238(string str) { }

	// RVA: 0xE10F90 Offset: 0xE0F590 VA: 0x180E10F90
	internal string <.cctor>b__2_239() { }

	// RVA: 0xE110A0 Offset: 0xE0F6A0 VA: 0x180E110A0
	internal void <.cctor>b__2_240(string str) { }

	// RVA: 0xE11140 Offset: 0xE0F740 VA: 0x180E11140
	internal string <.cctor>b__2_241() { }

	// RVA: 0xE111A0 Offset: 0xE0F7A0 VA: 0x180E111A0
	internal void <.cctor>b__2_242(string str) { }

	// RVA: 0xE11220 Offset: 0xE0F820 VA: 0x180E11220
	internal string <.cctor>b__2_243() { }

	// RVA: 0xE11280 Offset: 0xE0F880 VA: 0x180E11280
	internal void <.cctor>b__2_244(string str) { }

	// RVA: 0xE11310 Offset: 0xE0F910 VA: 0x180E11310
	internal string <.cctor>b__2_245() { }

	// RVA: 0xE11370 Offset: 0xE0F970 VA: 0x180E11370
	internal void <.cctor>b__2_246(string str) { }

	// RVA: 0xE113F0 Offset: 0xE0F9F0 VA: 0x180E113F0
	internal void <.cctor>b__2_247(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11450 Offset: 0xE0FA50 VA: 0x180E11450
	internal string <.cctor>b__2_248() { }

	// RVA: 0xE114B0 Offset: 0xE0FAB0 VA: 0x180E114B0
	internal void <.cctor>b__2_249(string str) { }

	// RVA: 0xE115E0 Offset: 0xE0FBE0 VA: 0x180E115E0
	internal string <.cctor>b__2_250() { }

	// RVA: 0xE11640 Offset: 0xE0FC40 VA: 0x180E11640
	internal void <.cctor>b__2_251(string str) { }

	// RVA: 0xE116F0 Offset: 0xE0FCF0 VA: 0x180E116F0
	internal string <.cctor>b__2_252() { }

	// RVA: 0xE11750 Offset: 0xE0FD50 VA: 0x180E11750
	internal void <.cctor>b__2_253(string str) { }

	// RVA: 0xE11800 Offset: 0xE0FE00 VA: 0x180E11800
	internal void <.cctor>b__2_254(ConsoleSystem.Arg arg) { }

	// RVA: 0xE118C0 Offset: 0xE0FEC0 VA: 0x180E118C0
	internal void <.cctor>b__2_255(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11980 Offset: 0xE0FF80 VA: 0x180E11980
	internal void <.cctor>b__2_256(ConsoleSystem.Arg arg) { }

	// RVA: 0xE119D0 Offset: 0xE0FFD0 VA: 0x180E119D0
	internal string <.cctor>b__2_257() { }

	// RVA: 0xE11A30 Offset: 0xE10030 VA: 0x180E11A30
	internal void <.cctor>b__2_258(string str) { }

	// RVA: 0xE11AD0 Offset: 0xE100D0 VA: 0x180E11AD0
	internal string <.cctor>b__2_259() { }

	// RVA: 0xE11BE0 Offset: 0xE101E0 VA: 0x180E11BE0
	internal void <.cctor>b__2_260(string str) { }

	// RVA: 0xE11C80 Offset: 0xE10280 VA: 0x180E11C80
	internal string <.cctor>b__2_261() { }

	// RVA: 0xE11CE0 Offset: 0xE102E0 VA: 0x180E11CE0
	internal void <.cctor>b__2_262(string str) { }

	// RVA: 0xE11D80 Offset: 0xE10380 VA: 0x180E11D80
	internal void <.cctor>b__2_263(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11DF0 Offset: 0xE103F0 VA: 0x180E11DF0
	internal void <.cctor>b__2_264(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11E60 Offset: 0xE10460 VA: 0x180E11E60
	internal string <.cctor>b__2_265() { }

	// RVA: 0xE11EC0 Offset: 0xE104C0 VA: 0x180E11EC0
	internal void <.cctor>b__2_266(string str) { }

	// RVA: 0xE11F60 Offset: 0xE10560 VA: 0x180E11F60
	internal string <.cctor>b__2_267() { }

	// RVA: 0xE11FC0 Offset: 0xE105C0 VA: 0x180E11FC0
	internal void <.cctor>b__2_268(string str) { }

	// RVA: 0xE12070 Offset: 0xE10670 VA: 0x180E12070
	internal string <.cctor>b__2_269() { }

	// RVA: 0xE12150 Offset: 0xE10750 VA: 0x180E12150
	internal void <.cctor>b__2_270(string str) { }

	// RVA: 0xE121F0 Offset: 0xE107F0 VA: 0x180E121F0
	internal string <.cctor>b__2_271() { }

	// RVA: 0xE12250 Offset: 0xE10850 VA: 0x180E12250
	internal void <.cctor>b__2_272(string str) { }

	// RVA: 0xE122F0 Offset: 0xE108F0 VA: 0x180E122F0
	internal string <.cctor>b__2_273() { }

	// RVA: 0xE12350 Offset: 0xE10950 VA: 0x180E12350
	internal void <.cctor>b__2_274(string str) { }

	// RVA: 0xE123F0 Offset: 0xE109F0 VA: 0x180E123F0
	internal string <.cctor>b__2_275() { }

	// RVA: 0xE12450 Offset: 0xE10A50 VA: 0x180E12450
	internal void <.cctor>b__2_276(string str) { }

	// RVA: 0xE12500 Offset: 0xE10B00 VA: 0x180E12500
	internal string <.cctor>b__2_277() { }

	// RVA: 0xE12560 Offset: 0xE10B60 VA: 0x180E12560
	internal void <.cctor>b__2_278(string str) { }

	// RVA: 0xE12600 Offset: 0xE10C00 VA: 0x180E12600
	internal string <.cctor>b__2_279() { }

	// RVA: 0xE12710 Offset: 0xE10D10 VA: 0x180E12710
	internal void <.cctor>b__2_280(string str) { }

	// RVA: 0xE127B0 Offset: 0xE10DB0 VA: 0x180E127B0
	internal string <.cctor>b__2_281() { }

	// RVA: 0xE12810 Offset: 0xE10E10 VA: 0x180E12810
	internal void <.cctor>b__2_282(string str) { }

	// RVA: 0xE128B0 Offset: 0xE10EB0 VA: 0x180E128B0
	internal string <.cctor>b__2_283() { }

	// RVA: 0xE12960 Offset: 0xE10F60 VA: 0x180E12960
	internal void <.cctor>b__2_284(string str) { }

	// RVA: 0xE129F0 Offset: 0xE10FF0 VA: 0x180E129F0
	internal string <.cctor>b__2_285() { }

	// RVA: 0xE12A50 Offset: 0xE11050 VA: 0x180E12A50
	internal void <.cctor>b__2_286(string str) { }

	// RVA: 0xE12AF0 Offset: 0xE110F0 VA: 0x180E12AF0
	internal string <.cctor>b__2_287() { }

	// RVA: 0xE12BA0 Offset: 0xE111A0 VA: 0x180E12BA0
	internal void <.cctor>b__2_288(string str) { }

	// RVA: 0xE12C30 Offset: 0xE11230 VA: 0x180E12C30
	internal void <.cctor>b__2_289(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12D30 Offset: 0xE11330 VA: 0x180E12D30
	internal void <.cctor>b__2_290(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12D90 Offset: 0xE11390 VA: 0x180E12D90
	internal string <.cctor>b__2_291() { }

	// RVA: 0xE12DF0 Offset: 0xE113F0 VA: 0x180E12DF0
	internal void <.cctor>b__2_292(string str) { }

	// RVA: 0xE12E90 Offset: 0xE11490 VA: 0x180E12E90
	internal void <.cctor>b__2_293(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12F00 Offset: 0xE11500 VA: 0x180E12F00
	internal void <.cctor>b__2_294(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12F70 Offset: 0xE11570 VA: 0x180E12F70
	internal void <.cctor>b__2_295(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12FE0 Offset: 0xE115E0 VA: 0x180E12FE0
	internal void <.cctor>b__2_296(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13050 Offset: 0xE11650 VA: 0x180E13050
	internal void <.cctor>b__2_297(ConsoleSystem.Arg arg) { }

	// RVA: 0xE130C0 Offset: 0xE116C0 VA: 0x180E130C0
	internal string <.cctor>b__2_298() { }

	// RVA: 0xE13120 Offset: 0xE11720 VA: 0x180E13120
	internal void <.cctor>b__2_299(string str) { }

	// RVA: 0xE132D0 Offset: 0xE118D0 VA: 0x180E132D0
	internal void <.cctor>b__2_300(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13320 Offset: 0xE11920 VA: 0x180E13320
	internal void <.cctor>b__2_301(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13380 Offset: 0xE11980 VA: 0x180E13380
	internal void <.cctor>b__2_302(ConsoleSystem.Arg arg) { }

	// RVA: 0xE133E0 Offset: 0xE119E0 VA: 0x180E133E0
	internal string <.cctor>b__2_303() { }

	// RVA: 0xE13440 Offset: 0xE11A40 VA: 0x180E13440
	internal void <.cctor>b__2_304(string str) { }

	// RVA: 0xE134E0 Offset: 0xE11AE0 VA: 0x180E134E0
	internal void <.cctor>b__2_305(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13540 Offset: 0xE11B40 VA: 0x180E13540
	internal string <.cctor>b__2_306() { }

	// RVA: 0xE135A0 Offset: 0xE11BA0 VA: 0x180E135A0
	internal void <.cctor>b__2_307(string str) { }

	// RVA: 0xE13640 Offset: 0xE11C40 VA: 0x180E13640
	internal void <.cctor>b__2_308(ConsoleSystem.Arg arg) { }

	// RVA: 0xE136A0 Offset: 0xE11CA0 VA: 0x180E136A0
	internal string <.cctor>b__2_309() { }

	// RVA: 0xE13780 Offset: 0xE11D80 VA: 0x180E13780
	internal void <.cctor>b__2_310(string str) { }

	// RVA: 0xE13820 Offset: 0xE11E20 VA: 0x180E13820
	internal void <.cctor>b__2_311(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13880 Offset: 0xE11E80 VA: 0x180E13880
	internal string <.cctor>b__2_312() { }

	// RVA: 0xE138E0 Offset: 0xE11EE0 VA: 0x180E138E0
	internal void <.cctor>b__2_313(string str) { }

	// RVA: 0xE13980 Offset: 0xE11F80 VA: 0x180E13980
	internal void <.cctor>b__2_314(ConsoleSystem.Arg arg) { }

	// RVA: 0xE139E0 Offset: 0xE11FE0 VA: 0x180E139E0
	internal void <.cctor>b__2_315(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13A40 Offset: 0xE12040 VA: 0x180E13A40
	internal string <.cctor>b__2_316() { }

	// RVA: 0xE13AA0 Offset: 0xE120A0 VA: 0x180E13AA0
	internal void <.cctor>b__2_317(string str) { }

	// RVA: 0xE13B40 Offset: 0xE12140 VA: 0x180E13B40
	internal string <.cctor>b__2_318() { }

	// RVA: 0xE13BA0 Offset: 0xE121A0 VA: 0x180E13BA0
	internal void <.cctor>b__2_319(string str) { }

	// RVA: 0xE13CD0 Offset: 0xE122D0 VA: 0x180E13CD0
	internal string <.cctor>b__2_320() { }

	// RVA: 0xE13D30 Offset: 0xE12330 VA: 0x180E13D30
	internal void <.cctor>b__2_321(string str) { }

	// RVA: 0xE13DE0 Offset: 0xE123E0 VA: 0x180E13DE0
	internal string <.cctor>b__2_322() { }

	// RVA: 0xE13E40 Offset: 0xE12440 VA: 0x180E13E40
	internal void <.cctor>b__2_323(string str) { }

	// RVA: 0xE13EF0 Offset: 0xE124F0 VA: 0x180E13EF0
	internal string <.cctor>b__2_324() { }

	// RVA: 0xE13F50 Offset: 0xE12550 VA: 0x180E13F50
	internal void <.cctor>b__2_325(string str) { }

	// RVA: 0xE14000 Offset: 0xE12600 VA: 0x180E14000
	internal string <.cctor>b__2_326() { }

	// RVA: 0xE14060 Offset: 0xE12660 VA: 0x180E14060
	internal void <.cctor>b__2_327(string str) { }

	// RVA: 0xE14110 Offset: 0xE12710 VA: 0x180E14110
	internal string <.cctor>b__2_328() { }

	// RVA: 0xE141C0 Offset: 0xE127C0 VA: 0x180E141C0
	internal void <.cctor>b__2_329(string str) { }

	// RVA: 0xE142C0 Offset: 0xE128C0 VA: 0x180E142C0
	internal string <.cctor>b__2_330() { }

	// RVA: 0xE14320 Offset: 0xE12920 VA: 0x180E14320
	internal void <.cctor>b__2_331(string str) { }

	// RVA: 0xE143D0 Offset: 0xE129D0 VA: 0x180E143D0
	internal string <.cctor>b__2_332() { }

	// RVA: 0xE14430 Offset: 0xE12A30 VA: 0x180E14430
	internal void <.cctor>b__2_333(string str) { }

	// RVA: 0xE144D0 Offset: 0xE12AD0 VA: 0x180E144D0
	internal string <.cctor>b__2_334() { }

	// RVA: 0xE14530 Offset: 0xE12B30 VA: 0x180E14530
	internal void <.cctor>b__2_335(string str) { }

	// RVA: 0xE145B0 Offset: 0xE12BB0 VA: 0x180E145B0
	internal string <.cctor>b__2_336() { }

	// RVA: 0xE14610 Offset: 0xE12C10 VA: 0x180E14610
	internal void <.cctor>b__2_337(string str) { }

	// RVA: 0xE14690 Offset: 0xE12C90 VA: 0x180E14690
	internal void <.cctor>b__2_338(ConsoleSystem.Arg arg) { }

	// RVA: 0xE146A0 Offset: 0xE12CA0 VA: 0x180E146A0
	internal void <.cctor>b__2_339(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14760 Offset: 0xE12D60 VA: 0x180E14760
	internal void <.cctor>b__2_340(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14770 Offset: 0xE12D70 VA: 0x180E14770
	internal void <.cctor>b__2_341(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14780 Offset: 0xE12D80 VA: 0x180E14780
	internal void <.cctor>b__2_342(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14790 Offset: 0xE12D90 VA: 0x180E14790
	internal void <.cctor>b__2_343(ConsoleSystem.Arg arg) { }

	// RVA: 0xE147A0 Offset: 0xE12DA0 VA: 0x180E147A0
	internal string <.cctor>b__2_344() { }

	// RVA: 0xE14800 Offset: 0xE12E00 VA: 0x180E14800
	internal void <.cctor>b__2_345(string str) { }

	// RVA: 0xE148A0 Offset: 0xE12EA0 VA: 0x180E148A0
	internal string <.cctor>b__2_346() { }

	// RVA: 0xE14900 Offset: 0xE12F00 VA: 0x180E14900
	internal void <.cctor>b__2_347(string str) { }

	// RVA: 0xE149A0 Offset: 0xE12FA0 VA: 0x180E149A0
	internal string <.cctor>b__2_348() { }

	// RVA: 0xE14A00 Offset: 0xE13000 VA: 0x180E14A00
	internal void <.cctor>b__2_349(string str) { }

	// RVA: 0xE14B20 Offset: 0xE13120 VA: 0x180E14B20
	internal void <.cctor>b__2_350(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14B80 Offset: 0xE13180 VA: 0x180E14B80
	internal string <.cctor>b__2_351() { }

	// RVA: 0xE14BE0 Offset: 0xE131E0 VA: 0x180E14BE0
	internal void <.cctor>b__2_352(string str) { }

	// RVA: 0xE14C80 Offset: 0xE13280 VA: 0x180E14C80
	internal string <.cctor>b__2_353() { }

	// RVA: 0xE14CE0 Offset: 0xE132E0 VA: 0x180E14CE0
	internal void <.cctor>b__2_354(string str) { }

	// RVA: 0xE14D80 Offset: 0xE13380 VA: 0x180E14D80
	internal string <.cctor>b__2_355() { }

	// RVA: 0xE14DE0 Offset: 0xE133E0 VA: 0x180E14DE0
	internal void <.cctor>b__2_356(string str) { }

	// RVA: 0xE14E80 Offset: 0xE13480 VA: 0x180E14E80
	internal void <.cctor>b__2_357(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14EE0 Offset: 0xE134E0 VA: 0x180E14EE0
	internal string <.cctor>b__2_358() { }

	// RVA: 0xE14F60 Offset: 0xE13560 VA: 0x180E14F60
	internal void <.cctor>b__2_359(string str) { }

	// RVA: 0xE150C0 Offset: 0xE136C0 VA: 0x180E150C0
	internal string <.cctor>b__2_360() { }

	// RVA: 0xE15140 Offset: 0xE13740 VA: 0x180E15140
	internal void <.cctor>b__2_361(string str) { }

	// RVA: 0xE151F0 Offset: 0xE137F0 VA: 0x180E151F0
	internal string <.cctor>b__2_362() { }

	// RVA: 0xE15270 Offset: 0xE13870 VA: 0x180E15270
	internal void <.cctor>b__2_363(string str) { }

	// RVA: 0xE15320 Offset: 0xE13920 VA: 0x180E15320
	internal string <.cctor>b__2_364() { }

	// RVA: 0xE15380 Offset: 0xE13980 VA: 0x180E15380
	internal void <.cctor>b__2_365(string str) { }

	// RVA: 0xE15430 Offset: 0xE13A30 VA: 0x180E15430
	internal void <.cctor>b__2_366(ConsoleSystem.Arg arg) { }

	// RVA: 0xE154A0 Offset: 0xE13AA0 VA: 0x180E154A0
	internal void <.cctor>b__2_367(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15510 Offset: 0xE13B10 VA: 0x180E15510
	internal void <.cctor>b__2_368(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15580 Offset: 0xE13B80 VA: 0x180E15580
	internal void <.cctor>b__2_369(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15670 Offset: 0xE13C70 VA: 0x180E15670
	internal void <.cctor>b__2_370(ConsoleSystem.Arg arg) { }

	// RVA: 0xE156D0 Offset: 0xE13CD0 VA: 0x180E156D0
	internal void <.cctor>b__2_371(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15730 Offset: 0xE13D30 VA: 0x180E15730
	internal string <.cctor>b__2_372() { }

	// RVA: 0xE15790 Offset: 0xE13D90 VA: 0x180E15790
	internal void <.cctor>b__2_373(string str) { }

	// RVA: 0xE15830 Offset: 0xE13E30 VA: 0x180E15830
	internal string <.cctor>b__2_374() { }

	// RVA: 0xE15890 Offset: 0xE13E90 VA: 0x180E15890
	internal void <.cctor>b__2_375(string str) { }

	// RVA: 0xE15930 Offset: 0xE13F30 VA: 0x180E15930
	internal string <.cctor>b__2_376() { }

	// RVA: 0xE159B0 Offset: 0xE13FB0 VA: 0x180E159B0
	internal void <.cctor>b__2_377(string str) { }

	// RVA: 0xE15A60 Offset: 0xE14060 VA: 0x180E15A60
	internal string <.cctor>b__2_378() { }

	// RVA: 0xE15AC0 Offset: 0xE140C0 VA: 0x180E15AC0
	internal void <.cctor>b__2_379(string str) { }

	// RVA: 0xE15C00 Offset: 0xE14200 VA: 0x180E15C00
	internal string <.cctor>b__2_380() { }

	// RVA: 0xE15C60 Offset: 0xE14260 VA: 0x180E15C60
	internal void <.cctor>b__2_381(string str) { }

	// RVA: 0xE15D00 Offset: 0xE14300 VA: 0x180E15D00
	internal string <.cctor>b__2_382() { }

	// RVA: 0xE15D80 Offset: 0xE14380 VA: 0x180E15D80
	internal void <.cctor>b__2_383(string str) { }

	// RVA: 0xE15E30 Offset: 0xE14430 VA: 0x180E15E30
	internal void <.cctor>b__2_384(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15E90 Offset: 0xE14490 VA: 0x180E15E90
	internal void <.cctor>b__2_385(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15EF0 Offset: 0xE144F0 VA: 0x180E15EF0
	internal void <.cctor>b__2_386(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15FC0 Offset: 0xE145C0 VA: 0x180E15FC0
	internal void <.cctor>b__2_387(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16010 Offset: 0xE14610 VA: 0x180E16010
	internal void <.cctor>b__2_388(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16070 Offset: 0xE14670 VA: 0x180E16070
	internal string <.cctor>b__2_389() { }

	// RVA: 0xE16170 Offset: 0xE14770 VA: 0x180E16170
	internal void <.cctor>b__2_390(string str) { }

	// RVA: 0xE16220 Offset: 0xE14820 VA: 0x180E16220
	internal void <.cctor>b__2_391(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16280 Offset: 0xE14880 VA: 0x180E16280
	internal void <.cctor>b__2_392(ConsoleSystem.Arg arg) { }

	// RVA: 0xE162E0 Offset: 0xE148E0 VA: 0x180E162E0
	internal string <.cctor>b__2_393() { }

	// RVA: 0xE16360 Offset: 0xE14960 VA: 0x180E16360
	internal void <.cctor>b__2_394(string str) { }

	// RVA: 0xE16410 Offset: 0xE14A10 VA: 0x180E16410
	internal string <.cctor>b__2_395() { }

	// RVA: 0xE16490 Offset: 0xE14A90 VA: 0x180E16490
	internal void <.cctor>b__2_396(string str) { }

	// RVA: 0xE16540 Offset: 0xE14B40 VA: 0x180E16540
	internal string <.cctor>b__2_397() { }

	// RVA: 0xE165A0 Offset: 0xE14BA0 VA: 0x180E165A0
	internal void <.cctor>b__2_398(string str) { }

	// RVA: 0xE16640 Offset: 0xE14C40 VA: 0x180E16640
	internal void <.cctor>b__2_399(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16800 Offset: 0xE14E00 VA: 0x180E16800
	internal string <.cctor>b__2_400() { }

	// RVA: 0xE16880 Offset: 0xE14E80 VA: 0x180E16880
	internal void <.cctor>b__2_401(string str) { }

	// RVA: 0xE168F0 Offset: 0xE14EF0 VA: 0x180E168F0
	internal string <.cctor>b__2_402() { }

	// RVA: 0xE16950 Offset: 0xE14F50 VA: 0x180E16950
	internal void <.cctor>b__2_403(string str) { }

	// RVA: 0xE169D0 Offset: 0xE14FD0 VA: 0x180E169D0
	internal void <.cctor>b__2_404(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16A30 Offset: 0xE15030 VA: 0x180E16A30
	internal void <.cctor>b__2_405(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16A90 Offset: 0xE15090 VA: 0x180E16A90
	internal void <.cctor>b__2_406(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16AF0 Offset: 0xE150F0 VA: 0x180E16AF0
	internal string <.cctor>b__2_407() { }

	// RVA: 0xE16B50 Offset: 0xE15150 VA: 0x180E16B50
	internal void <.cctor>b__2_408(string str) { }

	// RVA: 0xE16BF0 Offset: 0xE151F0 VA: 0x180E16BF0
	internal void <.cctor>b__2_409(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16CD0 Offset: 0xE152D0 VA: 0x180E16CD0
	internal string <.cctor>b__2_410() { }

	// RVA: 0xE16D30 Offset: 0xE15330 VA: 0x180E16D30
	internal void <.cctor>b__2_411(string str) { }

	// RVA: 0xE16DB0 Offset: 0xE153B0 VA: 0x180E16DB0
	internal void <.cctor>b__2_412(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16E10 Offset: 0xE15410 VA: 0x180E16E10
	internal string <.cctor>b__2_413() { }

	// RVA: 0xE16E70 Offset: 0xE15470 VA: 0x180E16E70
	internal void <.cctor>b__2_414(string str) { }

	// RVA: 0xE16F10 Offset: 0xE15510 VA: 0x180E16F10
	internal string <.cctor>b__2_415() { }

	// RVA: 0xE16F70 Offset: 0xE15570 VA: 0x180E16F70
	internal void <.cctor>b__2_416(string str) { }

	// RVA: 0xE17010 Offset: 0xE15610 VA: 0x180E17010
	internal void <.cctor>b__2_417(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17070 Offset: 0xE15670 VA: 0x180E17070
	internal string <.cctor>b__2_418() { }

	// RVA: 0xE170D0 Offset: 0xE156D0 VA: 0x180E170D0
	internal void <.cctor>b__2_419(string str) { }

	// RVA: 0xE17220 Offset: 0xE15820 VA: 0x180E17220
	internal string <.cctor>b__2_420() { }

	// RVA: 0xE17280 Offset: 0xE15880 VA: 0x180E17280
	internal void <.cctor>b__2_421(string str) { }

	// RVA: 0xE17320 Offset: 0xE15920 VA: 0x180E17320
	internal string <.cctor>b__2_422() { }

	// RVA: 0xE173D0 Offset: 0xE159D0 VA: 0x180E173D0
	internal void <.cctor>b__2_423(string str) { }

	// RVA: 0xE17460 Offset: 0xE15A60 VA: 0x180E17460
	internal string <.cctor>b__2_424() { }

	// RVA: 0xE174C0 Offset: 0xE15AC0 VA: 0x180E174C0
	internal void <.cctor>b__2_425(string str) { }

	// RVA: 0xE17560 Offset: 0xE15B60 VA: 0x180E17560
	internal void <.cctor>b__2_426(ConsoleSystem.Arg arg) { }

	// RVA: 0xE175B0 Offset: 0xE15BB0 VA: 0x180E175B0
	internal string <.cctor>b__2_427() { }

	// RVA: 0xE17610 Offset: 0xE15C10 VA: 0x180E17610
	internal void <.cctor>b__2_428(string str) { }

	// RVA: 0xE176B0 Offset: 0xE15CB0 VA: 0x180E176B0
	internal string <.cctor>b__2_429() { }

	// RVA: 0xE177E0 Offset: 0xE15DE0 VA: 0x180E177E0
	internal void <.cctor>b__2_430(string str) { }

	// RVA: 0xE17860 Offset: 0xE15E60 VA: 0x180E17860
	internal void <.cctor>b__2_431(ConsoleSystem.Arg arg) { }

	// RVA: 0xE178F0 Offset: 0xE15EF0 VA: 0x180E178F0
	internal void <.cctor>b__2_432(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17960 Offset: 0xE15F60 VA: 0x180E17960
	internal void <.cctor>b__2_433(ConsoleSystem.Arg arg) { }

	// RVA: 0xE179F0 Offset: 0xE15FF0 VA: 0x180E179F0
	internal void <.cctor>b__2_434(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17A60 Offset: 0xE16060 VA: 0x180E17A60
	internal void <.cctor>b__2_435(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17AB0 Offset: 0xE160B0 VA: 0x180E17AB0
	internal void <.cctor>b__2_436(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17B40 Offset: 0xE16140 VA: 0x180E17B40
	internal void <.cctor>b__2_437(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17B90 Offset: 0xE16190 VA: 0x180E17B90
	internal void <.cctor>b__2_438(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17C00 Offset: 0xE16200 VA: 0x180E17C00
	internal string <.cctor>b__2_439() { }

	// RVA: 0xE17D10 Offset: 0xE16310 VA: 0x180E17D10
	internal void <.cctor>b__2_440(string str) { }

	// RVA: 0xE17DB0 Offset: 0xE163B0 VA: 0x180E17DB0
	internal void <.cctor>b__2_441(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17E40 Offset: 0xE16440 VA: 0x180E17E40
	internal void <.cctor>b__2_442(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17EB0 Offset: 0xE164B0 VA: 0x180E17EB0
	internal string <.cctor>b__2_443() { }

	// RVA: 0xE17F10 Offset: 0xE16510 VA: 0x180E17F10
	internal void <.cctor>b__2_444(string str) { }

	// RVA: 0xE17FC0 Offset: 0xE165C0 VA: 0x180E17FC0
	internal void <.cctor>b__2_445(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18020 Offset: 0xE16620 VA: 0x180E18020
	internal void <.cctor>b__2_446(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18090 Offset: 0xE16690 VA: 0x180E18090
	internal string <.cctor>b__2_447() { }

	// RVA: 0xE18140 Offset: 0xE16740 VA: 0x180E18140
	internal void <.cctor>b__2_448(string str) { }

	// RVA: 0xE181C0 Offset: 0xE167C0 VA: 0x180E181C0
	internal string <.cctor>b__2_449() { }

	// RVA: 0xE182A0 Offset: 0xE168A0 VA: 0x180E182A0
	internal void <.cctor>b__2_450(string str) { }

	// RVA: 0xE18340 Offset: 0xE16940 VA: 0x180E18340
	internal string <.cctor>b__2_451() { }

	// RVA: 0xE183A0 Offset: 0xE169A0 VA: 0x180E183A0
	internal void <.cctor>b__2_452(string str) { }

	// RVA: 0xE18440 Offset: 0xE16A40 VA: 0x180E18440
	internal void <.cctor>b__2_453(ConsoleSystem.Arg arg) { }

	// RVA: 0xE184A0 Offset: 0xE16AA0 VA: 0x180E184A0
	internal string <.cctor>b__2_454() { }

	// RVA: 0xE18500 Offset: 0xE16B00 VA: 0x180E18500
	internal void <.cctor>b__2_455(string str) { }

	// RVA: 0xE185A0 Offset: 0xE16BA0 VA: 0x180E185A0
	internal string <.cctor>b__2_456() { }

	// RVA: 0xE18600 Offset: 0xE16C00 VA: 0x180E18600
	internal void <.cctor>b__2_457(string str) { }

	// RVA: 0xE186A0 Offset: 0xE16CA0 VA: 0x180E186A0
	internal string <.cctor>b__2_458() { }

	// RVA: 0xE18700 Offset: 0xE16D00 VA: 0x180E18700
	internal void <.cctor>b__2_459(string str) { }

	// RVA: 0xE18850 Offset: 0xE16E50 VA: 0x180E18850
	internal string <.cctor>b__2_460() { }

	// RVA: 0xE188B0 Offset: 0xE16EB0 VA: 0x180E188B0
	internal void <.cctor>b__2_461(string str) { }

	// RVA: 0xE18950 Offset: 0xE16F50 VA: 0x180E18950
	internal string <.cctor>b__2_462() { }

	// RVA: 0xE189B0 Offset: 0xE16FB0 VA: 0x180E189B0
	internal void <.cctor>b__2_463(string str) { }

	// RVA: 0xE18A50 Offset: 0xE17050 VA: 0x180E18A50
	internal string <.cctor>b__2_464() { }

	// RVA: 0xE18AB0 Offset: 0xE170B0 VA: 0x180E18AB0
	internal void <.cctor>b__2_465(string str) { }

	// RVA: 0xE18B50 Offset: 0xE17150 VA: 0x180E18B50
	internal string <.cctor>b__2_466() { }

	// RVA: 0xE18BB0 Offset: 0xE171B0 VA: 0x180E18BB0
	internal void <.cctor>b__2_467(string str) { }

	// RVA: 0xE18C50 Offset: 0xE17250 VA: 0x180E18C50
	internal string <.cctor>b__2_468() { }

	// RVA: 0xE18CB0 Offset: 0xE172B0 VA: 0x180E18CB0
	internal void <.cctor>b__2_469(string str) { }

	// RVA: 0xE18DD0 Offset: 0xE173D0 VA: 0x180E18DD0
	internal string <.cctor>b__2_470() { }

	// RVA: 0xE18E30 Offset: 0xE17430 VA: 0x180E18E30
	internal void <.cctor>b__2_471(string str) { }

	// RVA: 0xE18ED0 Offset: 0xE174D0 VA: 0x180E18ED0
	internal string <.cctor>b__2_472() { }

	// RVA: 0xE18F30 Offset: 0xE17530 VA: 0x180E18F30
	internal void <.cctor>b__2_473(string str) { }

	// RVA: 0xE18FD0 Offset: 0xE175D0 VA: 0x180E18FD0
	internal string <.cctor>b__2_474() { }

	// RVA: 0xE19030 Offset: 0xE17630 VA: 0x180E19030
	internal void <.cctor>b__2_475(string str) { }

	// RVA: 0xE190D0 Offset: 0xE176D0 VA: 0x180E190D0
	internal string <.cctor>b__2_476() { }

	// RVA: 0xE19130 Offset: 0xE17730 VA: 0x180E19130
	internal void <.cctor>b__2_477(string str) { }

	// RVA: 0xE191D0 Offset: 0xE177D0 VA: 0x180E191D0
	internal void <.cctor>b__2_478(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19230 Offset: 0xE17830 VA: 0x180E19230
	internal void <.cctor>b__2_479(ConsoleSystem.Arg arg) { }

	// RVA: 0xE192F0 Offset: 0xE178F0 VA: 0x180E192F0
	internal void <.cctor>b__2_480(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19300 Offset: 0xE17900 VA: 0x180E19300
	internal void <.cctor>b__2_481(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19360 Offset: 0xE17960 VA: 0x180E19360
	internal void <.cctor>b__2_482(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19370 Offset: 0xE17970 VA: 0x180E19370
	internal void <.cctor>b__2_483(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19380 Offset: 0xE17980 VA: 0x180E19380
	internal void <.cctor>b__2_484(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19390 Offset: 0xE17990 VA: 0x180E19390
	internal void <.cctor>b__2_485(ConsoleSystem.Arg arg) { }

	// RVA: 0xE193A0 Offset: 0xE179A0 VA: 0x180E193A0
	internal void <.cctor>b__2_486(ConsoleSystem.Arg arg) { }

	// RVA: 0xE193B0 Offset: 0xE179B0 VA: 0x180E193B0
	internal void <.cctor>b__2_487(ConsoleSystem.Arg arg) { }

	// RVA: 0xE193C0 Offset: 0xE179C0 VA: 0x180E193C0
	internal void <.cctor>b__2_488(ConsoleSystem.Arg arg) { }

	// RVA: 0xE193D0 Offset: 0xE179D0 VA: 0x180E193D0
	internal void <.cctor>b__2_489(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19460 Offset: 0xE17A60 VA: 0x180E19460
	internal void <.cctor>b__2_490(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19470 Offset: 0xE17A70 VA: 0x180E19470
	internal void <.cctor>b__2_491(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19480 Offset: 0xE17A80 VA: 0x180E19480
	internal string <.cctor>b__2_492() { }

	// RVA: 0xE194A0 Offset: 0xE17AA0 VA: 0x180E194A0
	internal void <.cctor>b__2_493(string str) { }

	// RVA: 0xE19500 Offset: 0xE17B00 VA: 0x180E19500
	internal string <.cctor>b__2_494() { }

	// RVA: 0xE19530 Offset: 0xE17B30 VA: 0x180E19530
	internal void <.cctor>b__2_495(string str) { }

	// RVA: 0xE19590 Offset: 0xE17B90 VA: 0x180E19590
	internal string <.cctor>b__2_496() { }

	// RVA: 0xE195C0 Offset: 0xE17BC0 VA: 0x180E195C0
	internal void <.cctor>b__2_497(string str) { }

	// RVA: 0xE19620 Offset: 0xE17C20 VA: 0x180E19620
	internal string <.cctor>b__2_498() { }

	// RVA: 0xE19650 Offset: 0xE17C50 VA: 0x180E19650
	internal void <.cctor>b__2_499(string str) { }

	// RVA: 0xE197E0 Offset: 0xE17DE0 VA: 0x180E197E0
	internal string <.cctor>b__2_500() { }

	// RVA: 0xE19850 Offset: 0xE17E50 VA: 0x180E19850
	internal void <.cctor>b__2_501(string str) { }

	// RVA: 0xE19900 Offset: 0xE17F00 VA: 0x180E19900
	internal string <.cctor>b__2_502() { }

	// RVA: 0xE19970 Offset: 0xE17F70 VA: 0x180E19970
	internal void <.cctor>b__2_503(string str) { }

	// RVA: 0xE19A20 Offset: 0xE18020 VA: 0x180E19A20
	internal string <.cctor>b__2_504() { }

	// RVA: 0xE19A70 Offset: 0xE18070 VA: 0x180E19A70
	internal void <.cctor>b__2_505(string str) { }

	// RVA: 0xE19AD0 Offset: 0xE180D0 VA: 0x180E19AD0
	internal string <.cctor>b__2_506() { }

	// RVA: 0xE19AF0 Offset: 0xE180F0 VA: 0x180E19AF0
	internal void <.cctor>b__2_507(string str) { }

	// RVA: 0xE19B50 Offset: 0xE18150 VA: 0x180E19B50
	internal void <.cctor>b__2_508(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19BB0 Offset: 0xE181B0 VA: 0x180E19BB0
	internal string <.cctor>b__2_509() { }

	// RVA: 0xE19CE0 Offset: 0xE182E0 VA: 0x180E19CE0
	internal void <.cctor>b__2_510(string str) { }

	// RVA: 0xE19D60 Offset: 0xE18360 VA: 0x180E19D60
	internal string <.cctor>b__2_511() { }

	// RVA: 0xE19DC0 Offset: 0xE183C0 VA: 0x180E19DC0
	internal void <.cctor>b__2_512(string str) { }

	// RVA: 0xE19E60 Offset: 0xE18460 VA: 0x180E19E60
	internal void <.cctor>b__2_513(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19EB0 Offset: 0xE184B0 VA: 0x180E19EB0
	internal string <.cctor>b__2_514() { }

	// RVA: 0xE19F10 Offset: 0xE18510 VA: 0x180E19F10
	internal void <.cctor>b__2_515(string str) { }

	// RVA: 0xE19FB0 Offset: 0xE185B0 VA: 0x180E19FB0
	internal string <.cctor>b__2_516() { }

	// RVA: 0xE1A010 Offset: 0xE18610 VA: 0x180E1A010
	internal void <.cctor>b__2_517(string str) { }

	// RVA: 0xE1A090 Offset: 0xE18690 VA: 0x180E1A090
	internal string <.cctor>b__2_518() { }

	// RVA: 0xE1A0F0 Offset: 0xE186F0 VA: 0x180E1A0F0
	internal void <.cctor>b__2_519(string str) { }

	// RVA: 0xE1A220 Offset: 0xE18820 VA: 0x180E1A220
	internal string <.cctor>b__2_520() { }

	// RVA: 0xE1A280 Offset: 0xE18880 VA: 0x180E1A280
	internal void <.cctor>b__2_521(string str) { }

	// RVA: 0xE1A300 Offset: 0xE18900 VA: 0x180E1A300
	internal void <.cctor>b__2_522(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A350 Offset: 0xE18950 VA: 0x180E1A350
	internal string <.cctor>b__2_523() { }

	// RVA: 0xE1A3B0 Offset: 0xE189B0 VA: 0x180E1A3B0
	internal void <.cctor>b__2_524(string str) { }

	// RVA: 0xE1A450 Offset: 0xE18A50 VA: 0x180E1A450
	internal string <.cctor>b__2_525() { }

	// RVA: 0xE1A4B0 Offset: 0xE18AB0 VA: 0x180E1A4B0
	internal void <.cctor>b__2_526(string str) { }

	// RVA: 0xE1A530 Offset: 0xE18B30 VA: 0x180E1A530
	internal string <.cctor>b__2_527() { }

	// RVA: 0xE1A5E0 Offset: 0xE18BE0 VA: 0x180E1A5E0
	internal void <.cctor>b__2_528(string str) { }

	// RVA: 0xE1A660 Offset: 0xE18C60 VA: 0x180E1A660
	internal string <.cctor>b__2_529() { }

	// RVA: 0xE1A790 Offset: 0xE18D90 VA: 0x180E1A790
	internal void <.cctor>b__2_530(string str) { }

	// RVA: 0xE1A810 Offset: 0xE18E10 VA: 0x180E1A810
	internal void <.cctor>b__2_531(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A870 Offset: 0xE18E70 VA: 0x180E1A870
	internal string <.cctor>b__2_532() { }

	// RVA: 0xE1A920 Offset: 0xE18F20 VA: 0x180E1A920
	internal void <.cctor>b__2_533(string str) { }

	// RVA: 0xE1A9B0 Offset: 0xE18FB0 VA: 0x180E1A9B0
	internal string <.cctor>b__2_534() { }

	// RVA: 0xE1AA10 Offset: 0xE19010 VA: 0x180E1AA10
	internal void <.cctor>b__2_535(string str) { }

	// RVA: 0xE1AAF0 Offset: 0xE190F0 VA: 0x180E1AAF0
	internal void <.cctor>b__2_536(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1AB50 Offset: 0xE19150 VA: 0x180E1AB50
	internal void <.cctor>b__2_537(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1ABB0 Offset: 0xE191B0 VA: 0x180E1ABB0
	internal string <.cctor>b__2_538() { }

	// RVA: 0xE1AC10 Offset: 0xE19210 VA: 0x180E1AC10
	internal void <.cctor>b__2_539(string str) { }

	// RVA: 0xE1AD60 Offset: 0xE19360 VA: 0x180E1AD60
	internal void <.cctor>b__2_540(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1ADC0 Offset: 0xE193C0 VA: 0x180E1ADC0
	internal string <.cctor>b__2_541() { }

	// RVA: 0xE1AE20 Offset: 0xE19420 VA: 0x180E1AE20
	internal void <.cctor>b__2_542(string str) { }

	// RVA: 0xE1AEC0 Offset: 0xE194C0 VA: 0x180E1AEC0
	internal string <.cctor>b__2_543() { }

	// RVA: 0xE1AF30 Offset: 0xE19530 VA: 0x180E1AF30
	internal void <.cctor>b__2_544(string str) { }

	// RVA: 0xE1AF90 Offset: 0xE19590 VA: 0x180E1AF90
	internal string <.cctor>b__2_545() { }

	// RVA: 0xE1AFF0 Offset: 0xE195F0 VA: 0x180E1AFF0
	internal void <.cctor>b__2_546(string str) { }

	// RVA: 0xE1B090 Offset: 0xE19690 VA: 0x180E1B090
	internal string <.cctor>b__2_547() { }

	// RVA: 0xE1B0F0 Offset: 0xE196F0 VA: 0x180E1B0F0
	internal void <.cctor>b__2_548(string str) { }

	// RVA: 0xE1B190 Offset: 0xE19790 VA: 0x180E1B190
	internal void <.cctor>b__2_549(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B270 Offset: 0xE19870 VA: 0x180E1B270
	internal string <.cctor>b__2_550() { }

	// RVA: 0xE1B2D0 Offset: 0xE198D0 VA: 0x180E1B2D0
	internal void <.cctor>b__2_551(string str) { }

	// RVA: 0xE1B370 Offset: 0xE19970 VA: 0x180E1B370
	internal string <.cctor>b__2_552() { }

	// RVA: 0xE1B3D0 Offset: 0xE199D0 VA: 0x180E1B3D0
	internal void <.cctor>b__2_553(string str) { }

	// RVA: 0xE1B470 Offset: 0xE19A70 VA: 0x180E1B470
	internal string <.cctor>b__2_554() { }

	// RVA: 0xE1B520 Offset: 0xE19B20 VA: 0x180E1B520
	internal void <.cctor>b__2_555(string str) { }

	// RVA: 0xE1B5A0 Offset: 0xE19BA0 VA: 0x180E1B5A0
	internal void <.cctor>b__2_556(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B600 Offset: 0xE19C00 VA: 0x180E1B600
	internal void <.cctor>b__2_557(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B660 Offset: 0xE19C60 VA: 0x180E1B660
	internal void <.cctor>b__2_558(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B6C0 Offset: 0xE19CC0 VA: 0x180E1B6C0
	internal string <.cctor>b__2_559() { }

	// RVA: 0xE1B7D0 Offset: 0xE19DD0 VA: 0x180E1B7D0
	internal void <.cctor>b__2_560(string str) { }

	// RVA: 0xE1B870 Offset: 0xE19E70 VA: 0x180E1B870
	internal string <.cctor>b__2_561() { }

	// RVA: 0xE1B920 Offset: 0xE19F20 VA: 0x180E1B920
	internal void <.cctor>b__2_562(string str) { }

	// RVA: 0xE1BA00 Offset: 0xE1A000 VA: 0x180E1BA00
	internal string <.cctor>b__2_563() { }

	// RVA: 0xE1BA60 Offset: 0xE1A060 VA: 0x180E1BA60
	internal void <.cctor>b__2_564(string str) { }

	// RVA: 0xE1BB00 Offset: 0xE1A100 VA: 0x180E1BB00
	internal string <.cctor>b__2_565() { }

	// RVA: 0xE1BB60 Offset: 0xE1A160 VA: 0x180E1BB60
	internal void <.cctor>b__2_566(string str) { }

	// RVA: 0xE1BC00 Offset: 0xE1A200 VA: 0x180E1BC00
	internal string <.cctor>b__2_567() { }

	// RVA: 0xE1BC60 Offset: 0xE1A260 VA: 0x180E1BC60
	internal void <.cctor>b__2_568(string str) { }

	// RVA: 0xE1BD00 Offset: 0xE1A300 VA: 0x180E1BD00
	internal string <.cctor>b__2_569() { }

	// RVA: 0xE1BDE0 Offset: 0xE1A3E0 VA: 0x180E1BDE0
	internal void <.cctor>b__2_570(string str) { }

	// RVA: 0xE1BE80 Offset: 0xE1A480 VA: 0x180E1BE80
	internal string <.cctor>b__2_571() { }

	// RVA: 0xE1BEE0 Offset: 0xE1A4E0 VA: 0x180E1BEE0
	internal void <.cctor>b__2_572(string str) { }

	// RVA: 0xE1BF80 Offset: 0xE1A580 VA: 0x180E1BF80
	internal void <.cctor>b__2_573(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1BFE0 Offset: 0xE1A5E0 VA: 0x180E1BFE0
	internal string <.cctor>b__2_574() { }

	// RVA: 0xE1C040 Offset: 0xE1A640 VA: 0x180E1C040
	internal void <.cctor>b__2_575(string str) { }

	// RVA: 0xE1C0E0 Offset: 0xE1A6E0 VA: 0x180E1C0E0
	internal void <.cctor>b__2_576(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C140 Offset: 0xE1A740 VA: 0x180E1C140
	internal void <.cctor>b__2_577(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C1A0 Offset: 0xE1A7A0 VA: 0x180E1C1A0
	internal void <.cctor>b__2_578(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C200 Offset: 0xE1A800 VA: 0x180E1C200
	internal void <.cctor>b__2_579(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C310 Offset: 0xE1A910 VA: 0x180E1C310
	internal string <.cctor>b__2_580() { }

	// RVA: 0xE1C370 Offset: 0xE1A970 VA: 0x180E1C370
	internal void <.cctor>b__2_581(string str) { }

	// RVA: 0xE1C410 Offset: 0xE1AA10 VA: 0x180E1C410
	internal string <.cctor>b__2_582() { }

	// RVA: 0xE1C470 Offset: 0xE1AA70 VA: 0x180E1C470
	internal void <.cctor>b__2_583(string str) { }

	// RVA: 0xE1C520 Offset: 0xE1AB20 VA: 0x180E1C520
	internal void <.cctor>b__2_584(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C580 Offset: 0xE1AB80 VA: 0x180E1C580
	internal string <.cctor>b__2_585() { }

	// RVA: 0xE1C5E0 Offset: 0xE1ABE0 VA: 0x180E1C5E0
	internal void <.cctor>b__2_586(string str) { }

	// RVA: 0xE1C680 Offset: 0xE1AC80 VA: 0x180E1C680
	internal void <.cctor>b__2_587(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C6D0 Offset: 0xE1ACD0 VA: 0x180E1C6D0
	internal string <.cctor>b__2_588() { }

	// RVA: 0xE1C780 Offset: 0xE1AD80 VA: 0x180E1C780
	internal void <.cctor>b__2_589(string str) { }

	// RVA: 0xE1C880 Offset: 0xE1AE80 VA: 0x180E1C880
	internal string <.cctor>b__2_590() { }

	// RVA: 0xE1C8E0 Offset: 0xE1AEE0 VA: 0x180E1C8E0
	internal void <.cctor>b__2_591(string str) { }

	// RVA: 0xE1C980 Offset: 0xE1AF80 VA: 0x180E1C980
	internal string <.cctor>b__2_592() { }

	// RVA: 0xE1CA30 Offset: 0xE1B030 VA: 0x180E1CA30
	internal void <.cctor>b__2_593(string str) { }

	// RVA: 0xE1CAB0 Offset: 0xE1B0B0 VA: 0x180E1CAB0
	internal string <.cctor>b__2_594() { }

	// RVA: 0xE1CB10 Offset: 0xE1B110 VA: 0x180E1CB10
	internal void <.cctor>b__2_595(string str) { }

	// RVA: 0xE1CBB0 Offset: 0xE1B1B0 VA: 0x180E1CBB0
	internal string <.cctor>b__2_596() { }

	// RVA: 0xE1CC10 Offset: 0xE1B210 VA: 0x180E1CC10
	internal void <.cctor>b__2_597(string str) { }

	// RVA: 0xE1CCB0 Offset: 0xE1B2B0 VA: 0x180E1CCB0
	internal string <.cctor>b__2_598() { }

	// RVA: 0xE1CD10 Offset: 0xE1B310 VA: 0x180E1CD10
	internal void <.cctor>b__2_599(string str) { }

	// RVA: 0xE1CEC0 Offset: 0xE1B4C0 VA: 0x180E1CEC0
	internal string <.cctor>b__2_600() { }

	// RVA: 0xE1CF20 Offset: 0xE1B520 VA: 0x180E1CF20
	internal void <.cctor>b__2_601(string str) { }

	// RVA: 0xE1CFC0 Offset: 0xE1B5C0 VA: 0x180E1CFC0
	internal string <.cctor>b__2_602() { }

	// RVA: 0xE1D020 Offset: 0xE1B620 VA: 0x180E1D020
	internal void <.cctor>b__2_603(string str) { }

	// RVA: 0xE1D0C0 Offset: 0xE1B6C0 VA: 0x180E1D0C0
	internal string <.cctor>b__2_604() { }

	// RVA: 0xE1D120 Offset: 0xE1B720 VA: 0x180E1D120
	internal void <.cctor>b__2_605(string str) { }

	// RVA: 0xE1D1C0 Offset: 0xE1B7C0 VA: 0x180E1D1C0
	internal string <.cctor>b__2_606() { }

	// RVA: 0xE1D220 Offset: 0xE1B820 VA: 0x180E1D220
	internal void <.cctor>b__2_607(string str) { }

	// RVA: 0xE1D2C0 Offset: 0xE1B8C0 VA: 0x180E1D2C0
	internal string <.cctor>b__2_608() { }

	// RVA: 0xE1D320 Offset: 0xE1B920 VA: 0x180E1D320
	internal void <.cctor>b__2_609(string str) { }

	// RVA: 0xE1D450 Offset: 0xE1BA50 VA: 0x180E1D450
	internal string <.cctor>b__2_610() { }

	// RVA: 0xE1D4B0 Offset: 0xE1BAB0 VA: 0x180E1D4B0
	internal void <.cctor>b__2_611(string str) { }

	// RVA: 0xE1D560 Offset: 0xE1BB60 VA: 0x180E1D560
	internal string <.cctor>b__2_612() { }

	// RVA: 0xE1D5C0 Offset: 0xE1BBC0 VA: 0x180E1D5C0
	internal void <.cctor>b__2_613(string str) { }

	// RVA: 0xE1D660 Offset: 0xE1BC60 VA: 0x180E1D660
	internal string <.cctor>b__2_614() { }

	// RVA: 0xE1D6C0 Offset: 0xE1BCC0 VA: 0x180E1D6C0
	internal void <.cctor>b__2_615(string str) { }

	// RVA: 0xE1D770 Offset: 0xE1BD70 VA: 0x180E1D770
	internal void <.cctor>b__2_616(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1D7D0 Offset: 0xE1BDD0 VA: 0x180E1D7D0
	internal void <.cctor>b__2_617(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1D830 Offset: 0xE1BE30 VA: 0x180E1D830
	internal string <.cctor>b__2_618() { }

	// RVA: 0xE1D890 Offset: 0xE1BE90 VA: 0x180E1D890
	internal void <.cctor>b__2_619(string str) { }

	// RVA: 0xE1D9F0 Offset: 0xE1BFF0 VA: 0x180E1D9F0
	internal string <.cctor>b__2_620() { }

	// RVA: 0xE1DA50 Offset: 0xE1C050 VA: 0x180E1DA50
	internal void <.cctor>b__2_621(string str) { }

	// RVA: 0xE1DAF0 Offset: 0xE1C0F0 VA: 0x180E1DAF0
	internal void <.cctor>b__2_622(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DB50 Offset: 0xE1C150 VA: 0x180E1DB50
	internal string <.cctor>b__2_623() { }

	// RVA: 0xE1DBB0 Offset: 0xE1C1B0 VA: 0x180E1DBB0
	internal void <.cctor>b__2_624(string str) { }

	// RVA: 0xE1DC60 Offset: 0xE1C260 VA: 0x180E1DC60
	internal string <.cctor>b__2_625() { }

	// RVA: 0xE1DD10 Offset: 0xE1C310 VA: 0x180E1DD10
	internal void <.cctor>b__2_626(string str) { }

	// RVA: 0xE1DDA0 Offset: 0xE1C3A0 VA: 0x180E1DDA0
	internal string <.cctor>b__2_627() { }

	// RVA: 0xE1DE00 Offset: 0xE1C400 VA: 0x180E1DE00
	internal void <.cctor>b__2_628(string str) { }

	// RVA: 0xE1DEA0 Offset: 0xE1C4A0 VA: 0x180E1DEA0
	internal string <.cctor>b__2_629() { }

	// RVA: 0xE1DF80 Offset: 0xE1C580 VA: 0x180E1DF80
	internal void <.cctor>b__2_630(string str) { }

	// RVA: 0xE1E020 Offset: 0xE1C620 VA: 0x180E1E020
	internal string <.cctor>b__2_631() { }

	// RVA: 0xE1E0D0 Offset: 0xE1C6D0 VA: 0x180E1E0D0
	internal void <.cctor>b__2_632(string str) { }

	// RVA: 0xE1E150 Offset: 0xE1C750 VA: 0x180E1E150
	internal string <.cctor>b__2_633() { }

	// RVA: 0xE1E1F0 Offset: 0xE1C7F0 VA: 0x180E1E1F0
	internal void <.cctor>b__2_634(string str) { }

	// RVA: 0xE1E2B0 Offset: 0xE1C8B0 VA: 0x180E1E2B0
	internal string <.cctor>b__2_635() { }

	// RVA: 0xE1E360 Offset: 0xE1C960 VA: 0x180E1E360
	internal void <.cctor>b__2_636(string str) { }

	// RVA: 0xE1E430 Offset: 0xE1CA30 VA: 0x180E1E430
	internal string <.cctor>b__2_637() { }

	// RVA: 0xE1E4D0 Offset: 0xE1CAD0 VA: 0x180E1E4D0
	internal void <.cctor>b__2_638(string str) { }

	// RVA: 0xE1E590 Offset: 0xE1CB90 VA: 0x180E1E590
	internal string <.cctor>b__2_639() { }

	// RVA: 0xE1E6A0 Offset: 0xE1CCA0 VA: 0x180E1E6A0
	internal void <.cctor>b__2_640(string str) { }

	// RVA: 0xE1E760 Offset: 0xE1CD60 VA: 0x180E1E760
	internal string <.cctor>b__2_641() { }

	// RVA: 0xE1E7C0 Offset: 0xE1CDC0 VA: 0x180E1E7C0
	internal void <.cctor>b__2_642(string str) { }

	// RVA: 0xE1E850 Offset: 0xE1CE50 VA: 0x180E1E850
	internal string <.cctor>b__2_643() { }

	// RVA: 0xE1E8B0 Offset: 0xE1CEB0 VA: 0x180E1E8B0
	internal void <.cctor>b__2_644(string str) { }

	// RVA: 0xE1E930 Offset: 0xE1CF30 VA: 0x180E1E930
	internal string <.cctor>b__2_645() { }

	// RVA: 0xE1E9E0 Offset: 0xE1CFE0 VA: 0x180E1E9E0
	internal void <.cctor>b__2_646(string str) { }

	// RVA: 0xE1EA60 Offset: 0xE1D060 VA: 0x180E1EA60
	internal string <.cctor>b__2_647() { }

	// RVA: 0xE1EAC0 Offset: 0xE1D0C0 VA: 0x180E1EAC0
	internal void <.cctor>b__2_648(string str) { }

	// RVA: 0xE1EB40 Offset: 0xE1D140 VA: 0x180E1EB40
	internal string <.cctor>b__2_649() { }

	// RVA: 0xE1EC20 Offset: 0xE1D220 VA: 0x180E1EC20
	internal void <.cctor>b__2_650(string str) { }

	// RVA: 0xE1ECC0 Offset: 0xE1D2C0 VA: 0x180E1ECC0
	internal string <.cctor>b__2_651() { }

	// RVA: 0xE1ED20 Offset: 0xE1D320 VA: 0x180E1ED20
	internal void <.cctor>b__2_652(string str) { }

	// RVA: 0xE1EDC0 Offset: 0xE1D3C0 VA: 0x180E1EDC0
	internal string <.cctor>b__2_653() { }

	// RVA: 0xE1EE20 Offset: 0xE1D420 VA: 0x180E1EE20
	internal void <.cctor>b__2_654(string str) { }

	// RVA: 0xE1EEC0 Offset: 0xE1D4C0 VA: 0x180E1EEC0
	internal string <.cctor>b__2_655() { }

	// RVA: 0xE1EF70 Offset: 0xE1D570 VA: 0x180E1EF70
	internal void <.cctor>b__2_656(string str) { }

	// RVA: 0xE1F000 Offset: 0xE1D600 VA: 0x180E1F000
	internal void <.cctor>b__2_657(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F060 Offset: 0xE1D660 VA: 0x180E1F060
	internal void <.cctor>b__2_658(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F0C0 Offset: 0xE1D6C0 VA: 0x180E1F0C0
	internal void <.cctor>b__2_659(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F1C0 Offset: 0xE1D7C0 VA: 0x180E1F1C0
	internal string <.cctor>b__2_660() { }

	// RVA: 0xE1F270 Offset: 0xE1D870 VA: 0x180E1F270
	internal void <.cctor>b__2_661(string str) { }

	// RVA: 0xE1F2F0 Offset: 0xE1D8F0 VA: 0x180E1F2F0
	internal void <.cctor>b__2_662(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F350 Offset: 0xE1D950 VA: 0x180E1F350
	internal string <.cctor>b__2_663() { }

	// RVA: 0xE1F400 Offset: 0xE1DA00 VA: 0x180E1F400
	internal void <.cctor>b__2_664(string str) { }

	// RVA: 0xE1F480 Offset: 0xE1DA80 VA: 0x180E1F480
	internal void <.cctor>b__2_665(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F4E0 Offset: 0xE1DAE0 VA: 0x180E1F4E0
	internal string <.cctor>b__2_666() { }

	// RVA: 0xE1F540 Offset: 0xE1DB40 VA: 0x180E1F540
	internal void <.cctor>b__2_667(string str) { }

	// RVA: 0xE1F5C0 Offset: 0xE1DBC0 VA: 0x180E1F5C0
	internal string <.cctor>b__2_668() { }

	// RVA: 0xE1F620 Offset: 0xE1DC20 VA: 0x180E1F620
	internal void <.cctor>b__2_669(string str) { }

	// RVA: 0xE1F720 Offset: 0xE1DD20 VA: 0x180E1F720
	internal string <.cctor>b__2_670() { }

	// RVA: 0xE1F7D0 Offset: 0xE1DDD0 VA: 0x180E1F7D0
	internal void <.cctor>b__2_671(string str) { }

	// RVA: 0xE1F860 Offset: 0xE1DE60 VA: 0x180E1F860
	internal string <.cctor>b__2_672() { }

	// RVA: 0xE1F8C0 Offset: 0xE1DEC0 VA: 0x180E1F8C0
	internal void <.cctor>b__2_673(string str) { }

	// RVA: 0xE1F960 Offset: 0xE1DF60 VA: 0x180E1F960
	internal string <.cctor>b__2_674() { }

	// RVA: 0xE1F9C0 Offset: 0xE1DFC0 VA: 0x180E1F9C0
	internal void <.cctor>b__2_675(string str) { }

	// RVA: 0xE1FA60 Offset: 0xE1E060 VA: 0x180E1FA60
	internal string <.cctor>b__2_676() { }

	// RVA: 0xE1FB10 Offset: 0xE1E110 VA: 0x180E1FB10
	internal void <.cctor>b__2_677(string str) { }

	// RVA: 0xE1FB90 Offset: 0xE1E190 VA: 0x180E1FB90
	internal string <.cctor>b__2_678() { }

	// RVA: 0xE1FBF0 Offset: 0xE1E1F0 VA: 0x180E1FBF0
	internal void <.cctor>b__2_679(string str) { }

	// RVA: 0xE1FD20 Offset: 0xE1E320 VA: 0x180E1FD20
	internal string <.cctor>b__2_680() { }

	// RVA: 0xE1FDD0 Offset: 0xE1E3D0 VA: 0x180E1FDD0
	internal void <.cctor>b__2_681(string str) { }

	// RVA: 0xE1FE60 Offset: 0xE1E460 VA: 0x180E1FE60
	internal string <.cctor>b__2_682() { }

	// RVA: 0xE1FEC0 Offset: 0xE1E4C0 VA: 0x180E1FEC0
	internal void <.cctor>b__2_683(string str) { }

	// RVA: 0xE1FF60 Offset: 0xE1E560 VA: 0x180E1FF60
	internal string <.cctor>b__2_684() { }

	// RVA: 0xE1FFC0 Offset: 0xE1E5C0 VA: 0x180E1FFC0
	internal void <.cctor>b__2_685(string str) { }

	// RVA: 0xE20060 Offset: 0xE1E660 VA: 0x180E20060
	internal string <.cctor>b__2_686() { }

	// RVA: 0xE200C0 Offset: 0xE1E6C0 VA: 0x180E200C0
	internal void <.cctor>b__2_687(string str) { }

	// RVA: 0xE20160 Offset: 0xE1E760 VA: 0x180E20160
	internal string <.cctor>b__2_688() { }

	// RVA: 0xE201C0 Offset: 0xE1E7C0 VA: 0x180E201C0
	internal void <.cctor>b__2_689(string str) { }

	// RVA: 0xE202E0 Offset: 0xE1E8E0 VA: 0x180E202E0
	internal string <.cctor>b__2_690() { }

	// RVA: 0xE20340 Offset: 0xE1E940 VA: 0x180E20340
	internal void <.cctor>b__2_691(string str) { }

	// RVA: 0xE203E0 Offset: 0xE1E9E0 VA: 0x180E203E0
	internal string <.cctor>b__2_692() { }

	// RVA: 0xE20440 Offset: 0xE1EA40 VA: 0x180E20440
	internal void <.cctor>b__2_693(string str) { }

	// RVA: 0xE204C0 Offset: 0xE1EAC0 VA: 0x180E204C0
	internal string <.cctor>b__2_694() { }

	// RVA: 0xE20570 Offset: 0xE1EB70 VA: 0x180E20570
	internal void <.cctor>b__2_695(string str) { }

	// RVA: 0xE205F0 Offset: 0xE1EBF0 VA: 0x180E205F0
	internal string <.cctor>b__2_696() { }

	// RVA: 0xE20650 Offset: 0xE1EC50 VA: 0x180E20650
	internal void <.cctor>b__2_697(string str) { }

	// RVA: 0xE206F0 Offset: 0xE1ECF0 VA: 0x180E206F0
	internal string <.cctor>b__2_698() { }

	// RVA: 0xE207A0 Offset: 0xE1EDA0 VA: 0x180E207A0
	internal void <.cctor>b__2_699(string str) { }

	// RVA: 0xE20960 Offset: 0xE1EF60 VA: 0x180E20960
	internal string <.cctor>b__2_700() { }

	// RVA: 0xE20A10 Offset: 0xE1F010 VA: 0x180E20A10
	internal void <.cctor>b__2_701(string str) { }

	// RVA: 0xE20A90 Offset: 0xE1F090 VA: 0x180E20A90
	internal void <.cctor>b__2_702(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20AF0 Offset: 0xE1F0F0 VA: 0x180E20AF0
	internal string <.cctor>b__2_703() { }

	// RVA: 0xE20BA0 Offset: 0xE1F1A0 VA: 0x180E20BA0
	internal void <.cctor>b__2_704(string str) { }

	// RVA: 0xE20C30 Offset: 0xE1F230 VA: 0x180E20C30
	internal string <.cctor>b__2_705() { }

	// RVA: 0xE20CE0 Offset: 0xE1F2E0 VA: 0x180E20CE0
	internal void <.cctor>b__2_706(string str) { }

	// RVA: 0xE20D70 Offset: 0xE1F370 VA: 0x180E20D70
	internal string <.cctor>b__2_707() { }

	// RVA: 0xE20DF0 Offset: 0xE1F3F0 VA: 0x180E20DF0
	internal void <.cctor>b__2_708(string str) { }

	// RVA: 0xE20E60 Offset: 0xE1F460 VA: 0x180E20E60
	internal string <.cctor>b__2_709() { }

	// RVA: 0xE20F60 Offset: 0xE1F560 VA: 0x180E20F60
	internal void <.cctor>b__2_710(string str) { }

	// RVA: 0xE20FC0 Offset: 0xE1F5C0 VA: 0x180E20FC0
	internal void <.cctor>b__2_711(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21020 Offset: 0xE1F620 VA: 0x180E21020
	internal string <.cctor>b__2_712() { }

	// RVA: 0xE210A0 Offset: 0xE1F6A0 VA: 0x180E210A0
	internal void <.cctor>b__2_713(string str) { }

	// RVA: 0xE21110 Offset: 0xE1F710 VA: 0x180E21110
	internal string <.cctor>b__2_714() { }

	// RVA: 0xE21190 Offset: 0xE1F790 VA: 0x180E21190
	internal void <.cctor>b__2_715(string str) { }

	// RVA: 0xE21200 Offset: 0xE1F800 VA: 0x180E21200
	internal string <.cctor>b__2_716() { }

	// RVA: 0xE21280 Offset: 0xE1F880 VA: 0x180E21280
	internal void <.cctor>b__2_717(string str) { }

	// RVA: 0xE212F0 Offset: 0xE1F8F0 VA: 0x180E212F0
	internal string <.cctor>b__2_718() { }

	// RVA: 0xE21350 Offset: 0xE1F950 VA: 0x180E21350
	internal void <.cctor>b__2_719(string str) { }

	// RVA: 0xE214A0 Offset: 0xE1FAA0 VA: 0x180E214A0
	internal string <.cctor>b__2_720() { }

	// RVA: 0xE21500 Offset: 0xE1FB00 VA: 0x180E21500
	internal void <.cctor>b__2_721(string str) { }

	// RVA: 0xE215A0 Offset: 0xE1FBA0 VA: 0x180E215A0
	internal string <.cctor>b__2_722() { }

	// RVA: 0xE21600 Offset: 0xE1FC00 VA: 0x180E21600
	internal void <.cctor>b__2_723(string str) { }

	// RVA: 0xE216B0 Offset: 0xE1FCB0 VA: 0x180E216B0
	internal string <.cctor>b__2_724() { }

	// RVA: 0xE21710 Offset: 0xE1FD10 VA: 0x180E21710
	internal void <.cctor>b__2_725(string str) { }

	// RVA: 0xE217B0 Offset: 0xE1FDB0 VA: 0x180E217B0
	internal string <.cctor>b__2_726() { }

	// RVA: 0xE21810 Offset: 0xE1FE10 VA: 0x180E21810
	internal void <.cctor>b__2_727(string str) { }

	// RVA: 0xE218B0 Offset: 0xE1FEB0 VA: 0x180E218B0
	internal void <.cctor>b__2_728(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21920 Offset: 0xE1FF20 VA: 0x180E21920
	internal void <.cctor>b__2_729(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21A00 Offset: 0xE20000 VA: 0x180E21A00
	internal string <.cctor>b__2_730() { }

	// RVA: 0xE21A60 Offset: 0xE20060 VA: 0x180E21A60
	internal void <.cctor>b__2_731(string str) { }

	// RVA: 0xE21B00 Offset: 0xE20100 VA: 0x180E21B00
	internal string <.cctor>b__2_732() { }

	// RVA: 0xE21B60 Offset: 0xE20160 VA: 0x180E21B60
	internal void <.cctor>b__2_733(string str) { }

	// RVA: 0xE21C10 Offset: 0xE20210 VA: 0x180E21C10
	internal string <.cctor>b__2_734() { }

	// RVA: 0xE21C70 Offset: 0xE20270 VA: 0x180E21C70
	internal void <.cctor>b__2_735(string str) { }

	// RVA: 0xE21D20 Offset: 0xE20320 VA: 0x180E21D20
	internal string <.cctor>b__2_736() { }

	// RVA: 0xE21D80 Offset: 0xE20380 VA: 0x180E21D80
	internal void <.cctor>b__2_737(string str) { }

	// RVA: 0xE21E20 Offset: 0xE20420 VA: 0x180E21E20
	internal string <.cctor>b__2_738() { }

	// RVA: 0xE21E80 Offset: 0xE20480 VA: 0x180E21E80
	internal void <.cctor>b__2_739(string str) { }

	// RVA: 0xE21FD0 Offset: 0xE205D0 VA: 0x180E21FD0
	internal string <.cctor>b__2_740() { }

	// RVA: 0xE22030 Offset: 0xE20630 VA: 0x180E22030
	internal void <.cctor>b__2_741(string str) { }

	// RVA: 0xE220D0 Offset: 0xE206D0 VA: 0x180E220D0
	internal string <.cctor>b__2_742() { }

	// RVA: 0xE22130 Offset: 0xE20730 VA: 0x180E22130
	internal void <.cctor>b__2_743(string str) { }

	// RVA: 0xE221E0 Offset: 0xE207E0 VA: 0x180E221E0
	internal void <.cctor>b__2_744(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22240 Offset: 0xE20840 VA: 0x180E22240
	internal void <.cctor>b__2_745(ConsoleSystem.Arg arg) { }

	// RVA: 0xE222A0 Offset: 0xE208A0 VA: 0x180E222A0
	internal string <.cctor>b__2_746() { }

	// RVA: 0xE22350 Offset: 0xE20950 VA: 0x180E22350
	internal void <.cctor>b__2_747(string str) { }

	// RVA: 0xE223D0 Offset: 0xE209D0 VA: 0x180E223D0
	internal string <.cctor>b__2_748() { }

	// RVA: 0xE22480 Offset: 0xE20A80 VA: 0x180E22480
	internal void <.cctor>b__2_749(string str) { }

	// RVA: 0xE225E0 Offset: 0xE20BE0 VA: 0x180E225E0
	internal void <.cctor>b__2_750(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22640 Offset: 0xE20C40 VA: 0x180E22640
	internal void <.cctor>b__2_751(ConsoleSystem.Arg arg) { }

	// RVA: 0xE226A0 Offset: 0xE20CA0 VA: 0x180E226A0
	internal void <.cctor>b__2_752(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22700 Offset: 0xE20D00 VA: 0x180E22700
	internal void <.cctor>b__2_753(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22760 Offset: 0xE20D60 VA: 0x180E22760
	internal void <.cctor>b__2_754(ConsoleSystem.Arg arg) { }

	// RVA: 0xE227C0 Offset: 0xE20DC0 VA: 0x180E227C0
	internal void <.cctor>b__2_755(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22820 Offset: 0xE20E20 VA: 0x180E22820
	internal void <.cctor>b__2_756(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22880 Offset: 0xE20E80 VA: 0x180E22880
	internal string <.cctor>b__2_757() { }

	// RVA: 0xE228E0 Offset: 0xE20EE0 VA: 0x180E228E0
	internal void <.cctor>b__2_758(string str) { }

	// RVA: 0xE22980 Offset: 0xE20F80 VA: 0x180E22980
	internal void <.cctor>b__2_759(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22A90 Offset: 0xE21090 VA: 0x180E22A90
	internal void <.cctor>b__2_760(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22AF0 Offset: 0xE210F0 VA: 0x180E22AF0
	internal void <.cctor>b__2_761(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22B50 Offset: 0xE21150 VA: 0x180E22B50
	internal void <.cctor>b__2_762(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22BB0 Offset: 0xE211B0 VA: 0x180E22BB0
	internal void <.cctor>b__2_763(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22C00 Offset: 0xE21200 VA: 0x180E22C00
	internal void <.cctor>b__2_764(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22C50 Offset: 0xE21250 VA: 0x180E22C50
	internal string <.cctor>b__2_765() { }

	// RVA: 0xE22D00 Offset: 0xE21300 VA: 0x180E22D00
	internal void <.cctor>b__2_766(string str) { }

	// RVA: 0xE22D90 Offset: 0xE21390 VA: 0x180E22D90
	internal void <.cctor>b__2_767(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22DF0 Offset: 0xE213F0 VA: 0x180E22DF0
	internal void <.cctor>b__2_768(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22E40 Offset: 0xE21440 VA: 0x180E22E40
	internal void <.cctor>b__2_769(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22F10 Offset: 0xE21510 VA: 0x180E22F10
	internal void <.cctor>b__2_770(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22F60 Offset: 0xE21560 VA: 0x180E22F60
	internal void <.cctor>b__2_771(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22F70 Offset: 0xE21570 VA: 0x180E22F70
	internal void <.cctor>b__2_772(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22F80 Offset: 0xE21580 VA: 0x180E22F80
	internal void <.cctor>b__2_773(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22F90 Offset: 0xE21590 VA: 0x180E22F90
	internal void <.cctor>b__2_774(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22FA0 Offset: 0xE215A0 VA: 0x180E22FA0
	internal string <.cctor>b__2_775() { }

	// RVA: 0xE23000 Offset: 0xE21600 VA: 0x180E23000
	internal void <.cctor>b__2_776(string str) { }

	// RVA: 0xE230A0 Offset: 0xE216A0 VA: 0x180E230A0
	internal string <.cctor>b__2_777() { }

	// RVA: 0xE23100 Offset: 0xE21700 VA: 0x180E23100
	internal void <.cctor>b__2_778(string str) { }

	// RVA: 0xE231B0 Offset: 0xE217B0 VA: 0x180E231B0
	internal string <.cctor>b__2_779() { }

	// RVA: 0xE232C0 Offset: 0xE218C0 VA: 0x180E232C0
	internal void <.cctor>b__2_780(string str) { }

	// RVA: 0xE23370 Offset: 0xE21970 VA: 0x180E23370
	internal string <.cctor>b__2_781() { }

	// RVA: 0xE233D0 Offset: 0xE219D0 VA: 0x180E233D0
	internal void <.cctor>b__2_782(string str) { }

	// RVA: 0xE23480 Offset: 0xE21A80 VA: 0x180E23480
	internal string <.cctor>b__2_783() { }

	// RVA: 0xE234E0 Offset: 0xE21AE0 VA: 0x180E234E0
	internal void <.cctor>b__2_784(string str) { }

	// RVA: 0xE23570 Offset: 0xE21B70 VA: 0x180E23570
	internal string <.cctor>b__2_785() { }

	// RVA: 0xE23610 Offset: 0xE21C10 VA: 0x180E23610
	internal void <.cctor>b__2_786(string str) { }

	// RVA: 0xE236D0 Offset: 0xE21CD0 VA: 0x180E236D0
	internal string <.cctor>b__2_787() { }

	// RVA: 0xE23730 Offset: 0xE21D30 VA: 0x180E23730
	internal void <.cctor>b__2_788(string str) { }

	// RVA: 0xE237D0 Offset: 0xE21DD0 VA: 0x180E237D0
	internal string <.cctor>b__2_789() { }

	// RVA: 0xE238B0 Offset: 0xE21EB0 VA: 0x180E238B0
	internal void <.cctor>b__2_790(string str) { }

	// RVA: 0xE23940 Offset: 0xE21F40 VA: 0x180E23940
	internal string <.cctor>b__2_791() { }

	// RVA: 0xE239A0 Offset: 0xE21FA0 VA: 0x180E239A0
	internal void <.cctor>b__2_792(string str) { }

	// RVA: 0xE23A30 Offset: 0xE22030 VA: 0x180E23A30
	internal string <.cctor>b__2_793() { }

	// RVA: 0xE23A90 Offset: 0xE22090 VA: 0x180E23A90
	internal void <.cctor>b__2_794(string str) { }

	// RVA: 0xE23B20 Offset: 0xE22120 VA: 0x180E23B20
	internal string <.cctor>b__2_795() { }

	// RVA: 0xE23B80 Offset: 0xE22180 VA: 0x180E23B80
	internal void <.cctor>b__2_796(string str) { }

	// RVA: 0xE23C10 Offset: 0xE22210 VA: 0x180E23C10
	internal string <.cctor>b__2_797() { }

	// RVA: 0xE23CB0 Offset: 0xE222B0 VA: 0x180E23CB0
	internal void <.cctor>b__2_798(string str) { }

	// RVA: 0xE23D30 Offset: 0xE22330 VA: 0x180E23D30
	internal void <.cctor>b__2_799(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23EB0 Offset: 0xE224B0 VA: 0x180E23EB0
	internal void <.cctor>b__2_800(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23EE0 Offset: 0xE224E0 VA: 0x180E23EE0
	internal void <.cctor>b__2_801(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23EF0 Offset: 0xE224F0 VA: 0x180E23EF0
	internal void <.cctor>b__2_802(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F00 Offset: 0xE22500 VA: 0x180E23F00
	internal void <.cctor>b__2_803(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F10 Offset: 0xE22510 VA: 0x180E23F10
	internal string <.cctor>b__2_804() { }

	// RVA: 0xE23FC0 Offset: 0xE225C0 VA: 0x180E23FC0
	internal void <.cctor>b__2_805(string str) { }

	// RVA: 0xE24050 Offset: 0xE22650 VA: 0x180E24050
	internal string <.cctor>b__2_806() { }

	// RVA: 0xE240B0 Offset: 0xE226B0 VA: 0x180E240B0
	internal void <.cctor>b__2_807(string str) { }

	// RVA: 0xE24150 Offset: 0xE22750 VA: 0x180E24150
	internal void <.cctor>b__2_808(ConsoleSystem.Arg arg) { }

	// RVA: 0xE241B0 Offset: 0xE227B0 VA: 0x180E241B0
	internal string <.cctor>b__2_809() { }

	// RVA: 0xE24290 Offset: 0xE22890 VA: 0x180E24290
	internal void <.cctor>b__2_810(string str) { }

	// RVA: 0xE24330 Offset: 0xE22930 VA: 0x180E24330
	internal string <.cctor>b__2_811() { }

	// RVA: 0xE24390 Offset: 0xE22990 VA: 0x180E24390
	internal void <.cctor>b__2_812(string str) { }

	// RVA: 0xE24430 Offset: 0xE22A30 VA: 0x180E24430
	internal string <.cctor>b__2_813() { }

	// RVA: 0xE24490 Offset: 0xE22A90 VA: 0x180E24490
	internal void <.cctor>b__2_814(string str) { }

	// RVA: 0xE24530 Offset: 0xE22B30 VA: 0x180E24530
	internal string <.cctor>b__2_815() { }

	// RVA: 0xE24590 Offset: 0xE22B90 VA: 0x180E24590
	internal void <.cctor>b__2_816(string str) { }

	// RVA: 0xE24630 Offset: 0xE22C30 VA: 0x180E24630
	internal string <.cctor>b__2_817() { }

	// RVA: 0xE246B0 Offset: 0xE22CB0 VA: 0x180E246B0
	internal void <.cctor>b__2_818(string str) { }

	// RVA: 0xE24720 Offset: 0xE22D20 VA: 0x180E24720
	internal string <.cctor>b__2_819() { }

	// RVA: 0xE24850 Offset: 0xE22E50 VA: 0x180E24850
	internal void <.cctor>b__2_820(string str) { }

	// RVA: 0xE248C0 Offset: 0xE22EC0 VA: 0x180E248C0
	internal string <.cctor>b__2_821() { }

	// RVA: 0xE24920 Offset: 0xE22F20 VA: 0x180E24920
	internal void <.cctor>b__2_822(string str) { }

	// RVA: 0xE249D0 Offset: 0xE22FD0 VA: 0x180E249D0
	internal void <.cctor>b__2_823(ConsoleSystem.Arg arg) { }

	// RVA: 0xE249E0 Offset: 0xE22FE0 VA: 0x180E249E0
	internal void <.cctor>b__2_824(ConsoleSystem.Arg arg) { }

	// RVA: 0xE249F0 Offset: 0xE22FF0 VA: 0x180E249F0
	internal void <.cctor>b__2_825(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24A00 Offset: 0xE23000 VA: 0x180E24A00
	internal void <.cctor>b__2_826(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24A10 Offset: 0xE23010 VA: 0x180E24A10
	internal void <.cctor>b__2_827(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24A20 Offset: 0xE23020 VA: 0x180E24A20
	internal string <.cctor>b__2_828() { }

	// RVA: 0xE24A80 Offset: 0xE23080 VA: 0x180E24A80
	internal void <.cctor>b__2_829(string str) { }

	// RVA: 0xE24BA0 Offset: 0xE231A0 VA: 0x180E24BA0
	internal string <.cctor>b__2_830() { }

	// RVA: 0xE24C50 Offset: 0xE23250 VA: 0x180E24C50
	internal void <.cctor>b__2_831(string str) { }

	// RVA: 0xE24CE0 Offset: 0xE232E0 VA: 0x180E24CE0
	internal string <.cctor>b__2_832() { }

	// RVA: 0xE24D40 Offset: 0xE23340 VA: 0x180E24D40
	internal void <.cctor>b__2_833(string str) { }

	// RVA: 0xE24DE0 Offset: 0xE233E0 VA: 0x180E24DE0
	internal string <.cctor>b__2_834() { }

	// RVA: 0xE24E40 Offset: 0xE23440 VA: 0x180E24E40
	internal void <.cctor>b__2_835(string str) { }

	// RVA: 0xE24EC0 Offset: 0xE234C0 VA: 0x180E24EC0
	internal string <.cctor>b__2_836() { }

	// RVA: 0xE24F20 Offset: 0xE23520 VA: 0x180E24F20
	internal void <.cctor>b__2_837(string str) { }

	// RVA: 0xE24FC0 Offset: 0xE235C0 VA: 0x180E24FC0
	internal string <.cctor>b__2_838() { }

	// RVA: 0xE25020 Offset: 0xE23620 VA: 0x180E25020
	internal void <.cctor>b__2_839(string str) { }

	// RVA: 0xE25160 Offset: 0xE23760 VA: 0x180E25160
	internal string <.cctor>b__2_840() { }

	// RVA: 0xE251C0 Offset: 0xE237C0 VA: 0x180E251C0
	internal void <.cctor>b__2_841(string str) { }

	// RVA: 0xE25260 Offset: 0xE23860 VA: 0x180E25260
	internal string <.cctor>b__2_842() { }

	// RVA: 0xE252C0 Offset: 0xE238C0 VA: 0x180E252C0
	internal void <.cctor>b__2_843(string str) { }

	// RVA: 0xE25350 Offset: 0xE23950 VA: 0x180E25350
	internal void <.cctor>b__2_844(ConsoleSystem.Arg arg) { }

	// RVA: 0xE253B0 Offset: 0xE239B0 VA: 0x180E253B0
	internal void <.cctor>b__2_845(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25410 Offset: 0xE23A10 VA: 0x180E25410
	internal void <.cctor>b__2_846(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25470 Offset: 0xE23A70 VA: 0x180E25470
	internal string <.cctor>b__2_847() { }

	// RVA: 0xE254D0 Offset: 0xE23AD0 VA: 0x180E254D0
	internal void <.cctor>b__2_848(string str) { }

	// RVA: 0xE25570 Offset: 0xE23B70 VA: 0x180E25570
	internal string <.cctor>b__2_849() { }

	// RVA: 0xE25650 Offset: 0xE23C50 VA: 0x180E25650
	internal void <.cctor>b__2_850(string str) { }

	// RVA: 0xE256F0 Offset: 0xE23CF0 VA: 0x180E256F0
	internal string <.cctor>b__2_851() { }

	// RVA: 0xE25750 Offset: 0xE23D50 VA: 0x180E25750
	internal void <.cctor>b__2_852(string str) { }

	// RVA: 0xE257F0 Offset: 0xE23DF0 VA: 0x180E257F0
	internal string <.cctor>b__2_853() { }

	// RVA: 0xE25850 Offset: 0xE23E50 VA: 0x180E25850
	internal void <.cctor>b__2_854(string str) { }

	// RVA: 0xE25900 Offset: 0xE23F00 VA: 0x180E25900
	internal string <.cctor>b__2_855() { }

	// RVA: 0xE25960 Offset: 0xE23F60 VA: 0x180E25960
	internal void <.cctor>b__2_856(string str) { }

	// RVA: 0xE25A10 Offset: 0xE24010 VA: 0x180E25A10
	internal void <.cctor>b__2_857(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25A70 Offset: 0xE24070 VA: 0x180E25A70
	internal string <.cctor>b__2_858() { }

	// RVA: 0xE25AD0 Offset: 0xE240D0 VA: 0x180E25AD0
	internal void <.cctor>b__2_859(string str) { }

	// RVA: 0xE25C30 Offset: 0xE24230 VA: 0x180E25C30
	internal string <.cctor>b__2_860() { }

	// RVA: 0xE25C90 Offset: 0xE24290 VA: 0x180E25C90
	internal void <.cctor>b__2_861(string str) { }

	// RVA: 0xE25D40 Offset: 0xE24340 VA: 0x180E25D40
	internal string <.cctor>b__2_862() { }

	// RVA: 0xE25DA0 Offset: 0xE243A0 VA: 0x180E25DA0
	internal void <.cctor>b__2_863(string str) { }

	// RVA: 0xE25E50 Offset: 0xE24450 VA: 0x180E25E50
	internal void <.cctor>b__2_864(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25EB0 Offset: 0xE244B0 VA: 0x180E25EB0
	internal string <.cctor>b__2_865() { }

	// RVA: 0xE25F10 Offset: 0xE24510 VA: 0x180E25F10
	internal void <.cctor>b__2_866(string str) { }

	// RVA: 0xE25FB0 Offset: 0xE245B0 VA: 0x180E25FB0
	internal string <.cctor>b__2_867() { }

	// RVA: 0xE26010 Offset: 0xE24610 VA: 0x180E26010
	internal void <.cctor>b__2_868(string str) { }

	// RVA: 0xE260B0 Offset: 0xE246B0 VA: 0x180E260B0
	internal string <.cctor>b__2_869() { }

	// RVA: 0xE26190 Offset: 0xE24790 VA: 0x180E26190
	internal void <.cctor>b__2_870(string str) { }

	// RVA: 0xE26230 Offset: 0xE24830 VA: 0x180E26230
	internal string <.cctor>b__2_871() { }

	// RVA: 0xE26290 Offset: 0xE24890 VA: 0x180E26290
	internal void <.cctor>b__2_872(string str) { }

	// RVA: 0xE26330 Offset: 0xE24930 VA: 0x180E26330
	internal string <.cctor>b__2_873() { }

	// RVA: 0xE263E0 Offset: 0xE249E0 VA: 0x180E263E0
	internal void <.cctor>b__2_874(string str) { }

	// RVA: 0xE26460 Offset: 0xE24A60 VA: 0x180E26460
	internal string <.cctor>b__2_875() { }

	// RVA: 0xE264C0 Offset: 0xE24AC0 VA: 0x180E264C0
	internal void <.cctor>b__2_876(string str) { }

	// RVA: 0xE26570 Offset: 0xE24B70 VA: 0x180E26570
	internal string <.cctor>b__2_877() { }

	// RVA: 0xE265D0 Offset: 0xE24BD0 VA: 0x180E265D0
	internal void <.cctor>b__2_878(string str) { }

	// RVA: 0xE26680 Offset: 0xE24C80 VA: 0x180E26680
	internal string <.cctor>b__2_879() { }

	// RVA: 0xE26790 Offset: 0xE24D90 VA: 0x180E26790
	internal void <.cctor>b__2_880(string str) { }

	// RVA: 0xE26840 Offset: 0xE24E40 VA: 0x180E26840
	internal string <.cctor>b__2_881() { }

	// RVA: 0xE268A0 Offset: 0xE24EA0 VA: 0x180E268A0
	internal void <.cctor>b__2_882(string str) { }

	// RVA: 0xE26950 Offset: 0xE24F50 VA: 0x180E26950
	internal string <.cctor>b__2_883() { }

	// RVA: 0xE269B0 Offset: 0xE24FB0 VA: 0x180E269B0
	internal void <.cctor>b__2_884(string str) { }

	// RVA: 0xE26A50 Offset: 0xE25050 VA: 0x180E26A50
	internal void <.cctor>b__2_885(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26AB0 Offset: 0xE250B0 VA: 0x180E26AB0
	internal void <.cctor>b__2_886(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26B10 Offset: 0xE25110 VA: 0x180E26B10
	internal void <.cctor>b__2_887(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26B70 Offset: 0xE25170 VA: 0x180E26B70
	internal string <.cctor>b__2_888() { }

	// RVA: 0xE26BD0 Offset: 0xE251D0 VA: 0x180E26BD0
	internal void <.cctor>b__2_889(string str) { }

	// RVA: 0xE26CF0 Offset: 0xE252F0 VA: 0x180E26CF0
	internal string <.cctor>b__2_890() { }

	// RVA: 0xE26D50 Offset: 0xE25350 VA: 0x180E26D50
	internal void <.cctor>b__2_891(string str) { }

	// RVA: 0xE26DF0 Offset: 0xE253F0 VA: 0x180E26DF0
	internal void <.cctor>b__2_892(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26E50 Offset: 0xE25450 VA: 0x180E26E50
	internal string <.cctor>b__2_893() { }

	// RVA: 0xE26EB0 Offset: 0xE254B0 VA: 0x180E26EB0
	internal void <.cctor>b__2_894(string str) { }

	// RVA: 0xE26F50 Offset: 0xE25550 VA: 0x180E26F50
	internal string <.cctor>b__2_895() { }

	// RVA: 0xE26FB0 Offset: 0xE255B0 VA: 0x180E26FB0
	internal void <.cctor>b__2_896(string str) { }

	// RVA: 0xE27050 Offset: 0xE25650 VA: 0x180E27050
	internal void <.cctor>b__2_897(ConsoleSystem.Arg arg) { }

	// RVA: 0xE270B0 Offset: 0xE256B0 VA: 0x180E270B0
	internal void <.cctor>b__2_898(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27110 Offset: 0xE25710 VA: 0x180E27110
	internal void <.cctor>b__2_899(ConsoleSystem.Arg arg) { }

	// RVA: 0xE272A0 Offset: 0xE258A0 VA: 0x180E272A0
	internal void <.cctor>b__2_900(ConsoleSystem.Arg arg) { }

	// RVA: 0xE272A0 Offset: 0xE258A0 VA: 0x180E272A0
	internal void <.cctor>b__2_901(ConsoleSystem.Arg arg) { }

	// RVA: 0xE272B0 Offset: 0xE258B0 VA: 0x180E272B0
	internal string <.cctor>b__2_902() { }

	// RVA: 0xE27310 Offset: 0xE25910 VA: 0x180E27310
	internal void <.cctor>b__2_903(string str) { }

	// RVA: 0xE273B0 Offset: 0xE259B0 VA: 0x180E273B0
	internal string <.cctor>b__2_904() { }

	// RVA: 0xE27410 Offset: 0xE25A10 VA: 0x180E27410
	internal void <.cctor>b__2_905(string str) { }

	// RVA: 0xE274B0 Offset: 0xE25AB0 VA: 0x180E274B0
	internal string <.cctor>b__2_906() { }

	// RVA: 0xE27550 Offset: 0xE25B50 VA: 0x180E27550
	internal void <.cctor>b__2_907(string str) { }

	// RVA: 0xE275D0 Offset: 0xE25BD0 VA: 0x180E275D0
	internal string <.cctor>b__2_908() { }

	// RVA: 0xE27630 Offset: 0xE25C30 VA: 0x180E27630
	internal void <.cctor>b__2_909(string str) { }

	// RVA: 0xE27730 Offset: 0xE25D30 VA: 0x180E27730
	internal string <.cctor>b__2_910() { }

	// RVA: 0xE277E0 Offset: 0xE25DE0 VA: 0x180E277E0
	internal void <.cctor>b__2_911(string str) { }

	// RVA: 0xE27870 Offset: 0xE25E70 VA: 0x180E27870
	internal string <.cctor>b__2_912() { }

	// RVA: 0xE278D0 Offset: 0xE25ED0 VA: 0x180E278D0
	internal void <.cctor>b__2_913(string str) { }

	// RVA: 0xE27990 Offset: 0xE25F90 VA: 0x180E27990
	internal string <.cctor>b__2_914() { }

	// RVA: 0xE279F0 Offset: 0xE25FF0 VA: 0x180E279F0
	internal void <.cctor>b__2_915(string str) { }

	// RVA: 0xE27AB0 Offset: 0xE260B0 VA: 0x180E27AB0
	internal string <.cctor>b__2_916() { }

	// RVA: 0xE27B30 Offset: 0xE26130 VA: 0x180E27B30
	internal void <.cctor>b__2_917(string str) { }

	// RVA: 0xE27BA0 Offset: 0xE261A0 VA: 0x180E27BA0
	internal string <.cctor>b__2_918() { }

	// RVA: 0xE27C00 Offset: 0xE26200 VA: 0x180E27C00
	internal void <.cctor>b__2_919(string str) { }

	// RVA: 0xE27D70 Offset: 0xE26370 VA: 0x180E27D70
	internal string <.cctor>b__2_920() { }

	// RVA: 0xE27DD0 Offset: 0xE263D0 VA: 0x180E27DD0
	internal void <.cctor>b__2_921(string str) { }

	// RVA: 0xE27E70 Offset: 0xE26470 VA: 0x180E27E70
	internal string <.cctor>b__2_922() { }

	// RVA: 0xE27ED0 Offset: 0xE264D0 VA: 0x180E27ED0
	internal void <.cctor>b__2_923(string str) { }

	// RVA: 0xE27F70 Offset: 0xE26570 VA: 0x180E27F70
	internal string <.cctor>b__2_924() { }

	// RVA: 0xE27FD0 Offset: 0xE265D0 VA: 0x180E27FD0
	internal void <.cctor>b__2_925(string str) { }

	// RVA: 0xE28070 Offset: 0xE26670 VA: 0x180E28070
	internal string <.cctor>b__2_926() { }

	// RVA: 0xE280D0 Offset: 0xE266D0 VA: 0x180E280D0
	internal void <.cctor>b__2_927(string str) { }

	// RVA: 0xE28180 Offset: 0xE26780 VA: 0x180E28180
	internal void <.cctor>b__2_928(ConsoleSystem.Arg arg) { }

	// RVA: 0xE281B0 Offset: 0xE267B0 VA: 0x180E281B0
	internal void <.cctor>b__2_929(ConsoleSystem.Arg arg) { }

	// RVA: 0xE28240 Offset: 0xE26840 VA: 0x180E28240
	internal string <.cctor>b__2_930() { }

	// RVA: 0xE282A0 Offset: 0xE268A0 VA: 0x180E282A0
	internal void <.cctor>b__2_931(string str) { }

	// RVA: 0xE28350 Offset: 0xE26950 VA: 0x180E28350
	internal void <.cctor>b__2_932(ConsoleSystem.Arg arg) { }

	// RVA: 0xE283B0 Offset: 0xE269B0 VA: 0x180E283B0
	internal string <.cctor>b__2_933() { }

	// RVA: 0xE28410 Offset: 0xE26A10 VA: 0x180E28410
	internal void <.cctor>b__2_934(string str) { }

	// RVA: 0xE28490 Offset: 0xE26A90 VA: 0x180E28490
	internal string <.cctor>b__2_935() { }

	// RVA: 0xE284F0 Offset: 0xE26AF0 VA: 0x180E284F0
	internal void <.cctor>b__2_936(string str) { }

	// RVA: 0xE28590 Offset: 0xE26B90 VA: 0x180E28590
	internal string <.cctor>b__2_937() { }

	// RVA: 0xE28640 Offset: 0xE26C40 VA: 0x180E28640
	internal void <.cctor>b__2_938(string str) { }

	// RVA: 0xE286C0 Offset: 0xE26CC0 VA: 0x180E286C0
	internal string <.cctor>b__2_939() { }

	// RVA: 0xE28820 Offset: 0xE26E20 VA: 0x180E28820
	internal void <.cctor>b__2_940(string str) { }

	// RVA: 0xE288B0 Offset: 0xE26EB0 VA: 0x180E288B0
	internal string <.cctor>b__2_941() { }

	// RVA: 0xE28910 Offset: 0xE26F10 VA: 0x180E28910
	internal void <.cctor>b__2_942(string str) { }

	// RVA: 0xE289B0 Offset: 0xE26FB0 VA: 0x180E289B0
	internal string <.cctor>b__2_943() { }

	// RVA: 0xE28A10 Offset: 0xE27010 VA: 0x180E28A10
	internal void <.cctor>b__2_944(string str) { }

	// RVA: 0xE28AB0 Offset: 0xE270B0 VA: 0x180E28AB0
	internal string <.cctor>b__2_945() { }

	// RVA: 0xE28B10 Offset: 0xE27110 VA: 0x180E28B10
	internal void <.cctor>b__2_946(string str) { }

	// RVA: 0xE28BB0 Offset: 0xE271B0 VA: 0x180E28BB0
	internal string <.cctor>b__2_947() { }

	// RVA: 0xE28C10 Offset: 0xE27210 VA: 0x180E28C10
	internal void <.cctor>b__2_948(string str) { }

	// RVA: 0xE28CB0 Offset: 0xE272B0 VA: 0x180E28CB0
	internal string <.cctor>b__2_949() { }

	// RVA: 0xE28D90 Offset: 0xE27390 VA: 0x180E28D90
	internal void <.cctor>b__2_950(string str) { }

	// RVA: 0xE28E30 Offset: 0xE27430 VA: 0x180E28E30
	internal string <.cctor>b__2_951() { }

	// RVA: 0xE28E90 Offset: 0xE27490 VA: 0x180E28E90
	internal void <.cctor>b__2_952(string str) { }

	// RVA: 0xE28F30 Offset: 0xE27530 VA: 0x180E28F30
	internal string <.cctor>b__2_953() { }

	// RVA: 0xE28F90 Offset: 0xE27590 VA: 0x180E28F90
	internal void <.cctor>b__2_954(string str) { }

	// RVA: 0xE29030 Offset: 0xE27630 VA: 0x180E29030
	internal string <.cctor>b__2_955() { }

	// RVA: 0xE29090 Offset: 0xE27690 VA: 0x180E29090
	internal void <.cctor>b__2_956(string str) { }

	// RVA: 0xE29130 Offset: 0xE27730 VA: 0x180E29130
	internal string <.cctor>b__2_957() { }

	// RVA: 0xE29190 Offset: 0xE27790 VA: 0x180E29190
	internal void <.cctor>b__2_958(string str) { }

	// RVA: 0xE29220 Offset: 0xE27820 VA: 0x180E29220
	internal string <.cctor>b__2_959() { }

	// RVA: 0xE29330 Offset: 0xE27930 VA: 0x180E29330
	internal void <.cctor>b__2_960(string str) { }

	// RVA: 0xE293C0 Offset: 0xE279C0 VA: 0x180E293C0
	internal string <.cctor>b__2_961() { }

	// RVA: 0xE29420 Offset: 0xE27A20 VA: 0x180E29420
	internal void <.cctor>b__2_962(string str) { }

	// RVA: 0xE294B0 Offset: 0xE27AB0 VA: 0x180E294B0
	internal string <.cctor>b__2_963() { }

	// RVA: 0xE29510 Offset: 0xE27B10 VA: 0x180E29510
	internal void <.cctor>b__2_964(string str) { }

	// RVA: 0xE295A0 Offset: 0xE27BA0 VA: 0x180E295A0
	internal string <.cctor>b__2_965() { }

	// RVA: 0xE29600 Offset: 0xE27C00 VA: 0x180E29600
	internal void <.cctor>b__2_966(string str) { }

	// RVA: 0xE29690 Offset: 0xE27C90 VA: 0x180E29690
	internal string <.cctor>b__2_967() { }

	// RVA: 0xE296F0 Offset: 0xE27CF0 VA: 0x180E296F0
	internal void <.cctor>b__2_968(string str) { }

	// RVA: 0xE29780 Offset: 0xE27D80 VA: 0x180E29780
	internal string <.cctor>b__2_969() { }

	// RVA: 0xE29860 Offset: 0xE27E60 VA: 0x180E29860
	internal void <.cctor>b__2_970(string str) { }

	// RVA: 0xE298F0 Offset: 0xE27EF0 VA: 0x180E298F0
	internal string <.cctor>b__2_971() { }

	// RVA: 0xE29950 Offset: 0xE27F50 VA: 0x180E29950
	internal void <.cctor>b__2_972(string str) { }

	// RVA: 0xE299E0 Offset: 0xE27FE0 VA: 0x180E299E0
	internal string <.cctor>b__2_973() { }

	// RVA: 0xE29A40 Offset: 0xE28040 VA: 0x180E29A40
	internal void <.cctor>b__2_974(string str) { }

	// RVA: 0xE29AD0 Offset: 0xE280D0 VA: 0x180E29AD0
	internal string <.cctor>b__2_975() { }

	// RVA: 0xE29B30 Offset: 0xE28130 VA: 0x180E29B30
	internal void <.cctor>b__2_976(string str) { }

	// RVA: 0xE29BC0 Offset: 0xE281C0 VA: 0x180E29BC0
	internal string <.cctor>b__2_977() { }

	// RVA: 0xE29C20 Offset: 0xE28220 VA: 0x180E29C20
	internal void <.cctor>b__2_978(string str) { }

	// RVA: 0xE29CB0 Offset: 0xE282B0 VA: 0x180E29CB0
	internal string <.cctor>b__2_979() { }

	// RVA: 0xE29DC0 Offset: 0xE283C0 VA: 0x180E29DC0
	internal void <.cctor>b__2_980(string str) { }

	// RVA: 0xE29E50 Offset: 0xE28450 VA: 0x180E29E50
	internal string <.cctor>b__2_981() { }

	// RVA: 0xE29EB0 Offset: 0xE284B0 VA: 0x180E29EB0
	internal void <.cctor>b__2_982(string str) { }

	// RVA: 0xE29F40 Offset: 0xE28540 VA: 0x180E29F40
	internal string <.cctor>b__2_983() { }

	// RVA: 0xE29FA0 Offset: 0xE285A0 VA: 0x180E29FA0
	internal void <.cctor>b__2_984(string str) { }

	// RVA: 0xE2A030 Offset: 0xE28630 VA: 0x180E2A030
	internal string <.cctor>b__2_985() { }

	// RVA: 0xE2A090 Offset: 0xE28690 VA: 0x180E2A090
	internal void <.cctor>b__2_986(string str) { }

	// RVA: 0xE2A120 Offset: 0xE28720 VA: 0x180E2A120
	internal string <.cctor>b__2_987() { }

	// RVA: 0xE2A180 Offset: 0xE28780 VA: 0x180E2A180
	internal void <.cctor>b__2_988(string str) { }

	// RVA: 0xE2A210 Offset: 0xE28810 VA: 0x180E2A210
	internal string <.cctor>b__2_989() { }

	// RVA: 0xE2A2F0 Offset: 0xE288F0 VA: 0x180E2A2F0
	internal void <.cctor>b__2_990(string str) { }

	// RVA: 0xE2A380 Offset: 0xE28980 VA: 0x180E2A380
	internal string <.cctor>b__2_991() { }

	// RVA: 0xE2A3E0 Offset: 0xE289E0 VA: 0x180E2A3E0
	internal void <.cctor>b__2_992(string str) { }

	// RVA: 0xE2A470 Offset: 0xE28A70 VA: 0x180E2A470
	internal void <.cctor>b__2_993(ConsoleSystem.Arg arg) { }

	// RVA: 0xE2A4D0 Offset: 0xE28AD0 VA: 0x180E2A4D0
	internal string <.cctor>b__2_994() { }

	// RVA: 0xE2A530 Offset: 0xE28B30 VA: 0x180E2A530
	internal void <.cctor>b__2_995(string str) { }

	// RVA: 0xE2A5C0 Offset: 0xE28BC0 VA: 0x180E2A5C0
	internal string <.cctor>b__2_996() { }

	// RVA: 0xE2A620 Offset: 0xE28C20 VA: 0x180E2A620
	internal void <.cctor>b__2_997(string str) { }

	// RVA: 0xE2A6B0 Offset: 0xE28CB0 VA: 0x180E2A6B0
	internal string <.cctor>b__2_998() { }

	// RVA: 0xE2A710 Offset: 0xE28D10 VA: 0x180E2A710
	internal void <.cctor>b__2_999(string str) { }

	// RVA: 0xE08970 Offset: 0xE06F70 VA: 0x180E08970
	internal string <.cctor>b__2_1000() { }

	// RVA: 0xE089D0 Offset: 0xE06FD0 VA: 0x180E089D0
	internal void <.cctor>b__2_1001(string str) { }

	// RVA: 0xE08A60 Offset: 0xE07060 VA: 0x180E08A60
	internal void <.cctor>b__2_1002(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08AC0 Offset: 0xE070C0 VA: 0x180E08AC0
	internal void <.cctor>b__2_1003(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08B20 Offset: 0xE07120 VA: 0x180E08B20
	internal string <.cctor>b__2_1004() { }

	// RVA: 0xE08B80 Offset: 0xE07180 VA: 0x180E08B80
	internal void <.cctor>b__2_1005(string str) { }

	// RVA: 0xE08C10 Offset: 0xE07210 VA: 0x180E08C10
	internal string <.cctor>b__2_1006() { }

	// RVA: 0xE08C70 Offset: 0xE07270 VA: 0x180E08C70
	internal void <.cctor>b__2_1007(string str) { }

	// RVA: 0xE08D00 Offset: 0xE07300 VA: 0x180E08D00
	internal string <.cctor>b__2_1008() { }

	// RVA: 0xE08D60 Offset: 0xE07360 VA: 0x180E08D60
	internal void <.cctor>b__2_1009(string str) { }

	// RVA: 0xE08E70 Offset: 0xE07470 VA: 0x180E08E70
	internal void <.cctor>b__2_1010(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08E80 Offset: 0xE07480 VA: 0x180E08E80
	internal string <.cctor>b__2_1011() { }

	// RVA: 0xE08EE0 Offset: 0xE074E0 VA: 0x180E08EE0
	internal void <.cctor>b__2_1012(string str) { }

	// RVA: 0xE08F80 Offset: 0xE07580 VA: 0x180E08F80
	internal void <.cctor>b__2_1013(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08FE0 Offset: 0xE075E0 VA: 0x180E08FE0
	internal void <.cctor>b__2_1014(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09040 Offset: 0xE07640 VA: 0x180E09040
	internal void <.cctor>b__2_1015(ConsoleSystem.Arg arg) { }

	// RVA: 0xE090A0 Offset: 0xE076A0 VA: 0x180E090A0
	internal void <.cctor>b__2_1016(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09100 Offset: 0xE07700 VA: 0x180E09100
	internal string <.cctor>b__2_1017() { }

	// RVA: 0xE09160 Offset: 0xE07760 VA: 0x180E09160
	internal void <.cctor>b__2_1018(string str) { }

	// RVA: 0xE09200 Offset: 0xE07800 VA: 0x180E09200
	internal void <.cctor>b__2_1019(ConsoleSystem.Arg arg) { }

	// RVA: 0xE092C0 Offset: 0xE078C0 VA: 0x180E092C0
	internal string <.cctor>b__2_1020() { }

	// RVA: 0xE09320 Offset: 0xE07920 VA: 0x180E09320
	internal void <.cctor>b__2_1021(string str) { }

	// RVA: 0xE093C0 Offset: 0xE079C0 VA: 0x180E093C0
	internal string <.cctor>b__2_1022() { }

	// RVA: 0xE09420 Offset: 0xE07A20 VA: 0x180E09420
	internal void <.cctor>b__2_1023(string str) { }

	// RVA: 0xE094D0 Offset: 0xE07AD0 VA: 0x180E094D0
	internal string <.cctor>b__2_1024() { }

	// RVA: 0xE09530 Offset: 0xE07B30 VA: 0x180E09530
	internal void <.cctor>b__2_1025(string str) { }

	// RVA: 0xE095E0 Offset: 0xE07BE0 VA: 0x180E095E0
	internal string <.cctor>b__2_1026() { }

	// RVA: 0xE09640 Offset: 0xE07C40 VA: 0x180E09640
	internal void <.cctor>b__2_1027(string str) { }

	// RVA: 0xE096E0 Offset: 0xE07CE0 VA: 0x180E096E0
	internal string <.cctor>b__2_1028() { }

	// RVA: 0xE09700 Offset: 0xE07D00 VA: 0x180E09700
	internal void <.cctor>b__2_1029(string str) { }

	// RVA: 0xE097E0 Offset: 0xE07DE0 VA: 0x180E097E0
	internal string <.cctor>b__2_1030() { }

	// RVA: 0xE09800 Offset: 0xE07E00 VA: 0x180E09800
	internal void <.cctor>b__2_1031(string str) { }

	// RVA: 0xE09860 Offset: 0xE07E60 VA: 0x180E09860
	internal string <.cctor>b__2_1032() { }

	// RVA: 0xE09880 Offset: 0xE07E80 VA: 0x180E09880
	internal void <.cctor>b__2_1033(string str) { }

	// RVA: 0xE098E0 Offset: 0xE07EE0 VA: 0x180E098E0
	internal string <.cctor>b__2_1034() { }

	// RVA: 0xE09900 Offset: 0xE07F00 VA: 0x180E09900
	internal void <.cctor>b__2_1035(string str) { }

	// RVA: 0xE09960 Offset: 0xE07F60 VA: 0x180E09960
	internal string <.cctor>b__2_1036() { }

	// RVA: 0xE09980 Offset: 0xE07F80 VA: 0x180E09980
	internal void <.cctor>b__2_1037(string str) { }

	// RVA: 0xE099E0 Offset: 0xE07FE0 VA: 0x180E099E0
	internal string <.cctor>b__2_1038() { }

	// RVA: 0xE09A00 Offset: 0xE08000 VA: 0x180E09A00
	internal void <.cctor>b__2_1039(string str) { }

	// RVA: 0xE09B10 Offset: 0xE08110 VA: 0x180E09B10
	internal string <.cctor>b__2_1040() { }

	// RVA: 0xE09B30 Offset: 0xE08130 VA: 0x180E09B30
	internal void <.cctor>b__2_1041(string str) { }

	// RVA: 0xE09B90 Offset: 0xE08190 VA: 0x180E09B90
	internal string <.cctor>b__2_1042() { }

	// RVA: 0xE09BB0 Offset: 0xE081B0 VA: 0x180E09BB0
	internal void <.cctor>b__2_1043(string str) { }

	// RVA: 0xE09C10 Offset: 0xE08210 VA: 0x180E09C10
	internal void <.cctor>b__2_1044(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09C20 Offset: 0xE08220 VA: 0x180E09C20
	internal void <.cctor>b__2_1045(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09C50 Offset: 0xE08250 VA: 0x180E09C50
	internal string <.cctor>b__2_1046() { }

	// RVA: 0xE09CB0 Offset: 0xE082B0 VA: 0x180E09CB0
	internal void <.cctor>b__2_1047(string str) { }

	// RVA: 0xE09D50 Offset: 0xE08350 VA: 0x180E09D50
	internal string <.cctor>b__2_1048() { }

	// RVA: 0xE09DB0 Offset: 0xE083B0 VA: 0x180E09DB0
	internal void <.cctor>b__2_1049(string str) { }

	// RVA: 0xE09ED0 Offset: 0xE084D0 VA: 0x180E09ED0
	internal string <.cctor>b__2_1050() { }

	// RVA: 0xE09F30 Offset: 0xE08530 VA: 0x180E09F30
	internal void <.cctor>b__2_1051(string str) { }

	// RVA: 0xE09FE0 Offset: 0xE085E0 VA: 0x180E09FE0
	internal string <.cctor>b__2_1052() { }

	// RVA: 0xE0A040 Offset: 0xE08640 VA: 0x180E0A040
	internal void <.cctor>b__2_1053(string str) { }

	// RVA: 0xE0A0E0 Offset: 0xE086E0 VA: 0x180E0A0E0
	internal string <.cctor>b__2_1054() { }

	// RVA: 0xE0A140 Offset: 0xE08740 VA: 0x180E0A140
	internal void <.cctor>b__2_1055(string str) { }

	// RVA: 0xE0A1F0 Offset: 0xE087F0 VA: 0x180E0A1F0
	internal void <.cctor>b__2_1056(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A240 Offset: 0xE08840 VA: 0x180E0A240
	internal void <.cctor>b__2_1057(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A300 Offset: 0xE08900 VA: 0x180E0A300
	internal void <.cctor>b__2_1058(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A380 Offset: 0xE08980 VA: 0x180E0A380
	internal string <.cctor>b__2_1059() { }

	// RVA: 0xE0A490 Offset: 0xE08A90 VA: 0x180E0A490
	internal void <.cctor>b__2_1060(string str) { }

	// RVA: 0xE0A530 Offset: 0xE08B30 VA: 0x180E0A530
	internal void <.cctor>b__2_1061(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A5D0 Offset: 0xE08BD0 VA: 0x180E0A5D0
	internal void <.cctor>b__2_1062(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A690 Offset: 0xE08C90 VA: 0x180E0A690
	internal string <.cctor>b__2_1063() { }

	// RVA: 0xE0A6F0 Offset: 0xE08CF0 VA: 0x180E0A6F0
	internal void <.cctor>b__2_1064(string str) { }

	// RVA: 0xE0A790 Offset: 0xE08D90 VA: 0x180E0A790
	internal string <.cctor>b__2_1065() { }

	// RVA: 0xE0A7F0 Offset: 0xE08DF0 VA: 0x180E0A7F0
	internal void <.cctor>b__2_1066(string str) { }

	// RVA: 0xE0A8A0 Offset: 0xE08EA0 VA: 0x180E0A8A0
	internal void <.cctor>b__2_1067(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A900 Offset: 0xE08F00 VA: 0x180E0A900
	internal string <.cctor>b__2_1068() { }

	// RVA: 0xE0A960 Offset: 0xE08F60 VA: 0x180E0A960
	internal void <.cctor>b__2_1069(string str) { }

	// RVA: 0xE0AA80 Offset: 0xE09080 VA: 0x180E0AA80
	internal string <.cctor>b__2_1070() { }

	// RVA: 0xE0AB30 Offset: 0xE09130 VA: 0x180E0AB30
	internal void <.cctor>b__2_1071(string str) { }

	// RVA: 0xE0AC10 Offset: 0xE09210 VA: 0x180E0AC10
	internal string <.cctor>b__2_1072() { }

	// RVA: 0xE0AC70 Offset: 0xE09270 VA: 0x180E0AC70
	internal void <.cctor>b__2_1073(string str) { }

	// RVA: 0xE0AD20 Offset: 0xE09320 VA: 0x180E0AD20
	internal string <.cctor>b__2_1074() { }

	// RVA: 0xE0AD80 Offset: 0xE09380 VA: 0x180E0AD80
	internal void <.cctor>b__2_1075(string str) { }

	// RVA: 0xE0AE30 Offset: 0xE09430 VA: 0x180E0AE30
	internal void <.cctor>b__2_1076(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AE40 Offset: 0xE09440 VA: 0x180E0AE40
	internal void <.cctor>b__2_1077(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AE50 Offset: 0xE09450 VA: 0x180E0AE50
	internal void <.cctor>b__2_1078(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AE60 Offset: 0xE09460 VA: 0x180E0AE60
	internal void <.cctor>b__2_1079(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AF20 Offset: 0xE09520 VA: 0x180E0AF20
	internal void <.cctor>b__2_1080(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AF80 Offset: 0xE09580 VA: 0x180E0AF80
	internal void <.cctor>b__2_1081(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AFE0 Offset: 0xE095E0 VA: 0x180E0AFE0
	internal void <.cctor>b__2_1082(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B040 Offset: 0xE09640 VA: 0x180E0B040
	internal void <.cctor>b__2_1083(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B0A0 Offset: 0xE096A0 VA: 0x180E0B0A0
	internal void <.cctor>b__2_1084(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B100 Offset: 0xE09700 VA: 0x180E0B100
	internal string <.cctor>b__2_1085() { }

	// RVA: 0xE0B160 Offset: 0xE09760 VA: 0x180E0B160
	internal void <.cctor>b__2_1086(string str) { }

	// RVA: 0xE0B200 Offset: 0xE09800 VA: 0x180E0B200
	internal string <.cctor>b__2_1087() { }

	// RVA: 0xE0B2B0 Offset: 0xE098B0 VA: 0x180E0B2B0
	internal void <.cctor>b__2_1088(string str) { }

	// RVA: 0xE0B330 Offset: 0xE09930 VA: 0x180E0B330
	internal void <.cctor>b__2_1089(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B410 Offset: 0xE09A10 VA: 0x180E0B410
	internal void <.cctor>b__2_1090(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B470 Offset: 0xE09A70 VA: 0x180E0B470
	internal string <.cctor>b__2_1091() { }

	// RVA: 0xE0B4D0 Offset: 0xE09AD0 VA: 0x180E0B4D0
	internal void <.cctor>b__2_1092(string str) { }

	// RVA: 0xE0B570 Offset: 0xE09B70 VA: 0x180E0B570
	internal string <.cctor>b__2_1093() { }

	// RVA: 0xE0B5D0 Offset: 0xE09BD0 VA: 0x180E0B5D0
	internal void <.cctor>b__2_1094(string str) { }

	// RVA: 0xE0B680 Offset: 0xE09C80 VA: 0x180E0B680
	internal string <.cctor>b__2_1095() { }

	// RVA: 0xE0B6E0 Offset: 0xE09CE0 VA: 0x180E0B6E0
	internal void <.cctor>b__2_1096(string str) { }

	// RVA: 0xE0B790 Offset: 0xE09D90 VA: 0x180E0B790
	internal string <.cctor>b__2_1097() { }

	// RVA: 0xE0B7F0 Offset: 0xE09DF0 VA: 0x180E0B7F0
	internal void <.cctor>b__2_1098(string str) { }

	// RVA: 0xE0B890 Offset: 0xE09E90 VA: 0x180E0B890
	internal string <.cctor>b__2_1099() { }

	// RVA: 0xE0BA20 Offset: 0xE0A020 VA: 0x180E0BA20
	internal void <.cctor>b__2_1100(string str) { }

	// RVA: 0xE0BAD0 Offset: 0xE0A0D0 VA: 0x180E0BAD0
	internal string <.cctor>b__2_1101() { }

	// RVA: 0xE0BB30 Offset: 0xE0A130 VA: 0x180E0BB30
	internal void <.cctor>b__2_1102(string str) { }

	// RVA: 0xE0BBC0 Offset: 0xE0A1C0 VA: 0x180E0BBC0
	internal string <.cctor>b__2_1103() { }

	// RVA: 0xE0BC20 Offset: 0xE0A220 VA: 0x180E0BC20
	internal void <.cctor>b__2_1104(string str) { }

	// RVA: 0xE0BCB0 Offset: 0xE0A2B0 VA: 0x180E0BCB0
	internal void <.cctor>b__2_1105(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BD10 Offset: 0xE0A310 VA: 0x180E0BD10
	internal void <.cctor>b__2_1106(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BD70 Offset: 0xE0A370 VA: 0x180E0BD70
	internal string <.cctor>b__2_1107() { }

	// RVA: 0xE0BDD0 Offset: 0xE0A3D0 VA: 0x180E0BDD0
	internal void <.cctor>b__2_1108(string str) { }

	// RVA: 0xE0BE70 Offset: 0xE0A470 VA: 0x180E0BE70
	internal string <.cctor>b__2_1109() { }

	// RVA: 0xE0BF30 Offset: 0xE0A530 VA: 0x180E0BF30
	internal void <.cctor>b__2_1110(string str) { }

	// RVA: 0xE0BFD0 Offset: 0xE0A5D0 VA: 0x180E0BFD0
	internal string <.cctor>b__2_1111() { }

	// RVA: 0xE0C050 Offset: 0xE0A650 VA: 0x180E0C050
	internal void <.cctor>b__2_1112(string str) { }

	// RVA: 0xE0C0B0 Offset: 0xE0A6B0 VA: 0x180E0C0B0
	internal void <.cctor>b__2_1113(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C100 Offset: 0xE0A700 VA: 0x180E0C100
	internal void <.cctor>b__2_1114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C160 Offset: 0xE0A760 VA: 0x180E0C160
	internal void <.cctor>b__2_1115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C1C0 Offset: 0xE0A7C0 VA: 0x180E0C1C0
	internal string <.cctor>b__2_1116() { }

	// RVA: 0xE0C270 Offset: 0xE0A870 VA: 0x180E0C270
	internal void <.cctor>b__2_1117(string str) { }

	// RVA: 0xE0C2F0 Offset: 0xE0A8F0 VA: 0x180E0C2F0
	internal string <.cctor>b__2_1118() { }

	// RVA: 0xE0C350 Offset: 0xE0A950 VA: 0x180E0C350
	internal void <.cctor>b__2_1119(string str) { }

	// RVA: 0xE0C4A0 Offset: 0xE0AAA0 VA: 0x180E0C4A0
	internal string <.cctor>b__2_1120() { }

	// RVA: 0xE0C500 Offset: 0xE0AB00 VA: 0x180E0C500
	internal void <.cctor>b__2_1121(string str) { }

	// RVA: 0xE0C5A0 Offset: 0xE0ABA0 VA: 0x180E0C5A0
	internal string <.cctor>b__2_1122() { }

	// RVA: 0xE0C600 Offset: 0xE0AC00 VA: 0x180E0C600
	internal void <.cctor>b__2_1123(string str) { }

	// RVA: 0xE0C6A0 Offset: 0xE0ACA0 VA: 0x180E0C6A0
	internal string <.cctor>b__2_1124() { }

	// RVA: 0xE0C700 Offset: 0xE0AD00 VA: 0x180E0C700
	internal void <.cctor>b__2_1125(string str) { }

	// RVA: 0xE0C7B0 Offset: 0xE0ADB0 VA: 0x180E0C7B0
	internal string <.cctor>b__2_1126() { }

	// RVA: 0xE0C810 Offset: 0xE0AE10 VA: 0x180E0C810
	internal void <.cctor>b__2_1127(string str) { }

	// RVA: 0xE0C8B0 Offset: 0xE0AEB0 VA: 0x180E0C8B0
	internal string <.cctor>b__2_1128() { }

	// RVA: 0xE0C910 Offset: 0xE0AF10 VA: 0x180E0C910
	internal void <.cctor>b__2_1129(string str) { }

	// RVA: 0xE0CA10 Offset: 0xE0B010 VA: 0x180E0CA10
	internal string <.cctor>b__2_1130() { }

	// RVA: 0xE0CA70 Offset: 0xE0B070 VA: 0x180E0CA70
	internal void <.cctor>b__2_1131(string str) { }

	// RVA: 0xE0CB10 Offset: 0xE0B110 VA: 0x180E0CB10
	internal string <.cctor>b__2_1132() { }

	// RVA: 0xE0CB70 Offset: 0xE0B170 VA: 0x180E0CB70
	internal void <.cctor>b__2_1133(string str) { }

	// RVA: 0xE0CC10 Offset: 0xE0B210 VA: 0x180E0CC10
	internal void <.cctor>b__2_1134(ConsoleSystem.Arg arg) { }

}

public static class ConsoleNetwork // TypeDefIndex: 9370
{	// Methods

	// RVA: 0x6AE110 Offset: 0x6AC710 VA: 0x1806AE110
	internal static void Init() { }

	// RVA: 0x6ADED0 Offset: 0x6AC4D0 VA: 0x1806ADED0
	public static bool ClientRunOnServer(string strCommand) { }

	// RVA: 0x6AE2A0 Offset: 0x6AC8A0 VA: 0x1806AE2A0
	internal static void OnConsoleMessageFromServer(Message packet) { }

	// RVA: 0x6AE1A0 Offset: 0x6AC7A0 VA: 0x1806AE1A0
	internal static void OnConsoleCommandfromServer(Message packet) { }

}

public class ConsoleUI : SingletonComponent<ConsoleUI> // TypeDefIndex: 10836
{	// Fields
	public RustText text; // 0x18
	public InputField outputField; // 0x20
	public InputField inputField; // 0x28
	public GameObject AutocompleteDropDown; // 0x30
	public GameObject ItemTemplate; // 0x38
	public Color errorColor; // 0x40
	public Color warningColor; // 0x50
	public Color inputColor; // 0x60
	private TextBuffer buffer; // 0x70
	private TextBuffer history; // 0x78
	private string historyTemp; // 0x80
	private string historyText; // 0x88
	private int historyIndex; // 0x90
	private Button[] autocompleteButtons; // 0x98
	private int autocompleteIndex; // 0xA0
	private bool dirty; // 0xA4

	// Methods

	// RVA: 0x6AE380 Offset: 0x6AC980 VA: 0x1806AE380 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6AEBD0 Offset: 0x6AD1D0 VA: 0x1806AEBD0
	protected void OnEnable() { }

	// RVA: 0x6AEAD0 Offset: 0x6AD0D0 VA: 0x1806AEAD0
	protected void OnDisable() { }

	// RVA: 0x6B0080 Offset: 0x6AE680 VA: 0x1806B0080
	protected void Update() { }

	// RVA: 0x6AFBA0 Offset: 0x6AE1A0 VA: 0x1806AFBA0
	public void SetTextSize(float newSize) { }

	// RVA: 0x6AE660 Offset: 0x6ACC60 VA: 0x1806AE660
	public void CloseAutocomplete() { }

	// RVA: 0x6AEE90 Offset: 0x6AD490 VA: 0x1806AEE90
	public void OnTextTypes(string str) { }

	// RVA: 0x6AE320 Offset: 0x6AC920 VA: 0x1806AE320
	private void AutocompleteButtonClicked(Button button) { }

	// RVA: 0x6AEDB0 Offset: 0x6AD3B0 VA: 0x1806AEDB0
	private void OnOpenDevTools() { }

	// RVA: 0x6AF580 Offset: 0x6ADB80 VA: 0x1806AF580
	private void OutputHandler_OnMessage(string message, string stack, LogType type = 0) { }

	// RVA: 0x6AEA40 Offset: 0x6AD040 VA: 0x1806AEA40
	private void Log(string message) { }

	// RVA: 0x6AFA50 Offset: 0x6AE050 VA: 0x1806AFA50
	private void Refresh() { }

	// RVA: 0x6AE900 Offset: 0x6ACF00 VA: 0x1806AE900
	private void LoadHistory(int delta) { }

	// RVA: 0x6AFC80 Offset: 0x6AE280 VA: 0x1806AFC80
	public void SubmitCommand(string command) { }

	// RVA: 0x6AFAA0 Offset: 0x6AE0A0 VA: 0x1806AFAA0
	private void SelectInputField(bool updateAutoComplete = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x7F590 Offset: 0x7E990 VA: 0x18007F590
	// RVA: 0x6AFB20 Offset: 0x6AE120 VA: 0x1806AFB20
	private IEnumerator SetSelected(bool updateAutoComplete = False) { }

	// RVA: 0x6AE600 Offset: 0x6ACC00 VA: 0x1806AE600
	public void ClearContents() { }

	// RVA: 0x6AE770 Offset: 0x6ACD70 VA: 0x1806AE770
	public void Copy() { }

	// RVA: 0x6AF4C0 Offset: 0x6ADAC0 VA: 0x1806AF4C0
	public void OpenLogFolder() { }

	// RVA: 0x6AF400 Offset: 0x6ADA00 VA: 0x1806AF400
	public void OpenLogFile() { }

	// RVA: 0x6B0510 Offset: 0x6AEB10 VA: 0x1806B0510
	public void .ctor() { }

}

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 10837
{	// Fields
	public Button btn; // 0x10
	public ConsoleUI <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F80 Offset: 0x6C7580 VA: 0x1806C8F80
	internal void <Awake>b__0() { }

}

private sealed class ConsoleUI.<>c__DisplayClass22_0 // TypeDefIndex: 10838
{	// Fields
	public string str; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8FE0 Offset: 0x6C75E0 VA: 0x1806C8FE0
	internal bool <OnTextTypes>b__0(ConsoleSystem.Command x) { }

}

private sealed class ConsoleUI.<SetSelected>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10839
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ConsoleUI <>4__this; // 0x20
	public bool updateAutoComplete; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8CA0 Offset: 0x6C72A0 VA: 0x1806C8CA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6C8E80 Offset: 0x6C7480 VA: 0x1806C8E80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ConsoleInput // TypeDefIndex: 11681
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<string> OnInputText; // 0x10
	public string inputString; // 0x18
	public string[] statusText; // 0x20
	internal float nextUpdate; // 0x28

	// Properties
	public bool valid { get; }
	public int lineWidth { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8E9000 Offset: 0x8E7600 VA: 0x1808E9000
	public void add_OnInputText(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8E9140 Offset: 0x8E7740 VA: 0x1808E9140
	public void remove_OnInputText(Action<string> value) { }

	// RVA: 0x8E90F0 Offset: 0x8E76F0 VA: 0x1808E90F0
	public bool get_valid() { }

	// RVA: 0x8E90A0 Offset: 0x8E76A0 VA: 0x1808E90A0
	public int get_lineWidth() { }

	// RVA: 0x8E85B0 Offset: 0x8E6BB0 VA: 0x1808E85B0
	public void ClearLine(int numLines) { }

	// RVA: 0x8E8810 Offset: 0x8E6E10 VA: 0x1808E8810
	public void RedrawInputLine() { }

	// RVA: 0x8E8680 Offset: 0x8E6C80 VA: 0x1808E8680
	internal void OnBackspace() { }

	// RVA: 0x8E87C0 Offset: 0x8E6DC0 VA: 0x1808E87C0
	internal void OnEscape() { }

	// RVA: 0x8E86E0 Offset: 0x8E6CE0 VA: 0x1808E86E0
	internal void OnEnter() { }

	// RVA: 0x8E8B90 Offset: 0x8E7190 VA: 0x1808E8B90
	public void Update() { }

	// RVA: 0x8E8E50 Offset: 0x8E7450 VA: 0x1808E8E50
	public void .ctor() { }

}

public class ConsoleWindow // TypeDefIndex: 11682
{	// Fields
	private TextWriter oldOutput; // 0x10
	private const int STD_INPUT_HANDLE = -10;
	private const int STD_OUTPUT_HANDLE = -11;

	// Methods

	// RVA: 0x8E9400 Offset: 0x8E7A00 VA: 0x1808E9400
	public void Initialize() { }

	// RVA: 0x8E9870 Offset: 0x8E7E70 VA: 0x1808E9870
	public void Shutdown() { }

	// RVA: 0x8E97E0 Offset: 0x8E7DE0 VA: 0x1808E97E0
	public void SetTitle(string strName) { }

	// RVA: 0x8E9260 Offset: 0x8E7860 VA: 0x1808E9260
	private static extern bool AttachConsole(uint dwProcessId) { }

	// RVA: 0x8E91E0 Offset: 0x8E77E0 VA: 0x1808E91E0
	private static extern bool AllocConsole() { }

	// RVA: 0x8E92F0 Offset: 0x8E78F0 VA: 0x1808E92F0
	private static extern bool FreeConsole() { }

	// RVA: 0x8E9370 Offset: 0x8E7970 VA: 0x1808E9370
	private static extern IntPtr GetStdHandle(int nStdHandle) { }

	// RVA: 0x8E9740 Offset: 0x8E7D40 VA: 0x1808E9740
	private static extern bool SetConsoleTitleA(string lpConsoleTitle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Console : ConsoleSystem // TypeDefIndex: 11894
{	// Fields
	[ClientVar] // RVA: 0x90AA0 Offset: 0x8FEA0 VA: 0x180090AA0
	[HelpAttribute] // RVA: 0x90AA0 Offset: 0x8FEA0 VA: 0x180090AA0
	public static bool erroroverlay; // 0x1E52F

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D4870 Offset: 0x6D2E70 VA: 0x1806D4870
	public static void clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D48E0 Offset: 0x6D2EE0 VA: 0x1806D48E0
	public static void copy(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D4810 Offset: 0x6D2E10 VA: 0x1806D4810
	public void .ctor() { }

	// RVA: 0x6D47D0 Offset: 0x6D2DD0 VA: 0x1806D47D0
	private static void .cctor() { }

}


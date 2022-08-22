public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x1453100 Offset: 0x1451700 VA: 0x181453100
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0xA110C0 Offset: 0xA0F6C0 VA: 0x180A110C0
	public bool get_Cancel() { }

	// RVA: 0x14530D0 Offset: 0x14516D0 VA: 0x1814530D0
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

	// RVA: 0x1EF6E0 Offset: 0x1EEAE0 VA: 0x1801EF6E0
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x121080 Offset: 0x120480 VA: 0x180121080
	public char get_KeyChar() { }

	// RVA: 0x14B7E0 Offset: 0x14ABE0 VA: 0x18014B7E0
	public ConsoleKey get_Key() { }

	// RVA: 0x1EF5E0 Offset: 0x1EE9E0 VA: 0x1801EF5E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1EF690 Offset: 0x1EEA90 VA: 0x1801EF690
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x1EF6D0 Offset: 0x1EEAD0 VA: 0x1801EF6D0 Slot: 2
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

	// RVA: 0x14548E0 Offset: 0x1452EE0 VA: 0x1814548E0
	private static void .cctor() { }

	// RVA: 0x1454380 Offset: 0x1452980 VA: 0x181454380
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x1454D20 Offset: 0x1453320 VA: 0x181454D20
	public static TextWriter get_Error() { }

	// RVA: 0x1454F60 Offset: 0x1453560 VA: 0x181454F60
	public static TextWriter get_Out() { }

	// RVA: 0x1453F40 Offset: 0x1452540 VA: 0x181453F40
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x1453D90 Offset: 0x1452390 VA: 0x181453D90
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x1453E20 Offset: 0x1452420 VA: 0x181453E20
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x1453EB0 Offset: 0x14524B0 VA: 0x181453EB0
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x14542E0 Offset: 0x14528E0 VA: 0x1814542E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x1454860 Offset: 0x1452E60 VA: 0x181454860
	public static void Write(string value) { }

	// RVA: 0x1454760 Offset: 0x1452D60 VA: 0x181454760
	public static void WriteLine(object value) { }

	// RVA: 0x14547E0 Offset: 0x1452DE0 VA: 0x1814547E0
	public static void WriteLine(string value) { }

	// RVA: 0x1454E40 Offset: 0x1453440 VA: 0x181454E40
	public static Encoding get_InputEncoding() { }

	// RVA: 0x1454FC0 Offset: 0x14535C0 VA: 0x181454FC0
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x14553A0 Offset: 0x14539A0 VA: 0x1814553A0
	public static void set_OutputEncoding(Encoding value) { }

	// RVA: 0x1454AE0 Offset: 0x14530E0 VA: 0x181454AE0
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x1455020 Offset: 0x1453620 VA: 0x181455020
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x1454BA0 Offset: 0x14531A0 VA: 0x181454BA0
	public static int get_BufferWidth() { }

	// RVA: 0x1455120 Offset: 0x1453720 VA: 0x181455120
	public static void set_CursorLeft(int value) { }

	// RVA: 0x1454C60 Offset: 0x1453260 VA: 0x181454C60
	public static int get_CursorTop() { }

	// RVA: 0x14551E0 Offset: 0x14537E0 VA: 0x1814551E0
	public static void set_CursorTop(int value) { }

	// RVA: 0x1454D80 Offset: 0x1453380 VA: 0x181454D80
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x14552A0 Offset: 0x14538A0 VA: 0x1814552A0
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1454EA0 Offset: 0x14534A0 VA: 0x181454EA0
	public static bool get_KeyAvailable() { }

	// RVA: 0x1454160 Offset: 0x1452760 VA: 0x181454160
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x1454010 Offset: 0x1452610 VA: 0x181454010
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1453BC0 Offset: 0x14521C0 VA: 0x181453BC0
	internal static void DoConsoleCancelEvent() { }

}

private class Console.WindowsConsole // TypeDefIndex: 351
{	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x146E450 Offset: 0x146CA50 VA: 0x18146E450
	private static extern int GetConsoleCP() { }

	// RVA: 0x146E4C0 Offset: 0x146CAC0 VA: 0x18146E4C0
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x146E3F0 Offset: 0x146C9F0 VA: 0x18146E3F0
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x146E530 Offset: 0x146CB30 VA: 0x18146E530
	public static int GetInputCodePage() { }

	// RVA: 0x146E5D0 Offset: 0x146CBD0 VA: 0x18146E5D0
	public static int GetOutputCodePage() { }

	// RVA: 0x146E670 Offset: 0x146CC70 VA: 0x18146E670
	private static void .cctor() { }

}

private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x146E100 Offset: 0x146C700 VA: 0x18146E100 Slot: 12
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x146E080 Offset: 0x146C680 VA: 0x18146E080 Slot: 13
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 353
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14647E0 Offset: 0x1462DE0 VA: 0x1814647E0 Slot: 12
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

	// RVA: 0x14533B0 Offset: 0x14519B0 VA: 0x1814533B0
	private static void .cctor() { }

	// RVA: 0x1453170 Offset: 0x1451770 VA: 0x181453170
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x1453220 Offset: 0x1451820 VA: 0x181453220
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x14531C0 Offset: 0x14517C0 VA: 0x1814531C0
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x1453470 Offset: 0x1451A70 VA: 0x181453470
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x1453870 Offset: 0x1451E70 VA: 0x181453870
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x14534E0 Offset: 0x1451AE0 VA: 0x1814534E0
	public static int get_BufferWidth() { }

	// RVA: 0x1453930 Offset: 0x1451F30 VA: 0x181453930
	public static void set_CursorLeft(int value) { }

	// RVA: 0x1453560 Offset: 0x1451B60 VA: 0x181453560
	public static int get_CursorTop() { }

	// RVA: 0x14539B0 Offset: 0x1451FB0 VA: 0x1814539B0
	public static void set_CursorTop(int value) { }

	// RVA: 0x14537F0 Offset: 0x1451DF0 VA: 0x1814537F0
	public static bool get_KeyAvailable() { }

	// RVA: 0x14535E0 Offset: 0x1451BE0 VA: 0x1814535E0
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x1453A30 Offset: 0x1452030 VA: 0x181453A30
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1453280 Offset: 0x1451880 VA: 0x181453280
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1453660 Offset: 0x1451C60 VA: 0x181453660
	public static bool get_IsConsole() { }

	// RVA: 0x1453270 Offset: 0x1451870 VA: 0x181453270
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x10DE040 Offset: 0x10DC640 VA: 0x1810DE040
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x14533A0 Offset: 0x14519A0 VA: 0x1814533A0
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x1453390 Offset: 0x1451990 VA: 0x181453390
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

	// RVA: 0x22B47A0 Offset: 0x22B2DA0 VA: 0x1822B47A0
	public static void UpdateValuesFromCommandLine() { }

	// RVA: 0x22B46F0 Offset: 0x22B2CF0 VA: 0x1822B46F0
	internal static bool SendToServer(string command) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B4A00 Offset: 0x22B3000 VA: 0x1822B4A00
	public static void add_OnReplicatedVarChanged(Action<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B4B00 Offset: 0x22B3100 VA: 0x1822B4B00
	public static void remove_OnReplicatedVarChanged(Action<string, string> value) { }

	// RVA: 0x22B3D60 Offset: 0x22B2360 VA: 0x1822B3D60
	public static void RunFile(ConsoleSystem.Option options, string strFile) { }

	// RVA: 0x22B3EF0 Offset: 0x22B24F0 VA: 0x1822B3EF0
	public static string Run(ConsoleSystem.Option options, string strCommand, object[] args) { }

	// RVA: 0x22B3760 Offset: 0x22B1D60 VA: 0x1822B3760
	private static bool Internal(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B32F0 Offset: 0x22B18F0 VA: 0x1822B32F0
	public static string BuildCommand(string strCommand, object[] args) { }

	// RVA: 0x22B42F0 Offset: 0x22B28F0 VA: 0x1822B42F0
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

	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public bool get_IsClientside() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsServerside() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Connection get_Connection() { }

	// RVA: 0x22B2130 Offset: 0x22B0730 VA: 0x1822B2130
	public bool get_IsConnectionAdmin() { }

	// RVA: 0x22B2100 Offset: 0x22B0700 VA: 0x1822B2100
	public bool get_IsAdmin() { }

	// RVA: 0x13A5690 Offset: 0x13A3C90 VA: 0x1813A5690
	public bool get_IsRcon() { }

	// RVA: 0x22B2060 Offset: 0x22B0660 VA: 0x1822B2060
	internal void .ctor(ConsoleSystem.Option options, string rconCommand) { }

	// RVA: 0x22B1070 Offset: 0x22AF670 VA: 0x1822B1070
	internal void BuildCommand(string command) { }

	// RVA: 0x22B1D40 Offset: 0x22B0340 VA: 0x1822B1D40
	internal bool HasPermission() { }

	// RVA: 0x22B1490 Offset: 0x22AFA90 VA: 0x1822B1490
	internal bool CanSeeInFind(ConsoleSystem.Command command) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void ReplyWith(string strValue) { }

	// RVA: 0x22B1F80 Offset: 0x22B0580 VA: 0x1822B1F80
	public void ReplyWith(object obj) { }

	// RVA: 0x22B1D20 Offset: 0x22B0320 VA: 0x1822B1D20
	public bool HasArgs(int iMinimum = 1) { }

	// RVA: 0x22B1CC0 Offset: 0x22B02C0 VA: 0x1822B1CC0
	public bool HasArg(string value) { }

	// RVA: 0x22B1790 Offset: 0x22AFD90 VA: 0x1822B1790
	public string GetString(int iArg, string def = "") { }

	// RVA: 0x22B1720 Offset: 0x22AFD20 VA: 0x1822B1720
	public int GetInt(int iArg, int def = 0) { }

	// RVA: 0x22B1B50 Offset: 0x22B0150 VA: 0x1822B1B50
	public ulong GetULong(int iArg, ulong def = 0) { }

	// RVA: 0x22B2000 Offset: 0x22B0600 VA: 0x1822B2000
	public bool TryGetUInt(int iArg, out uint value) { }

	// RVA: 0x22B1BD0 Offset: 0x22B01D0 VA: 0x1822B1BD0
	public uint GetUInt(int iArg, uint def = 0) { }

	// RVA: 0x22B1B50 Offset: 0x22B0150 VA: 0x1822B1B50
	public ulong GetUInt64(int iArg, ulong def = 0) { }

	// RVA: 0x22B16A0 Offset: 0x22AFCA0 VA: 0x1822B16A0
	public float GetFloat(int iArg, float def = 0) { }

	// RVA: 0x22B14C0 Offset: 0x22AFAC0 VA: 0x1822B14C0
	public bool GetBool(int iArg, bool def = False) { }

	// RVA: 0x22B1970 Offset: 0x22AFF70 VA: 0x1822B1970
	public long GetTimestamp(int iArg, long def = 0) { }

	// RVA: 0x22B17E0 Offset: 0x22AFDE0 VA: 0x1822B17E0
	public long GetTicks(int iArg, long def = 0) { }

	// RVA: 0x22B1EC0 Offset: 0x22B04C0 VA: 0x1822B1EC0
	public void ReplyWithObject(object rval) { }

	// RVA: 0x22B1C40 Offset: 0x22B0240 VA: 0x1822B1C40
	public Vector3 GetVector3(int iArg, Vector3 def) { }

	// RVA: 0x22B1630 Offset: 0x22AFC30 VA: 0x1822B1630
	public Color GetColor(int iArg, Color def) { }

}

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6880
{	// Fields
	public string Name; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
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

	// RVA: 0x22B2D20 Offset: 0x22B1320 VA: 0x1822B2D20
	public bool get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B2A50 Offset: 0x22B1050 VA: 0x1822B2A50
	public void add_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B2D80 Offset: 0x22B1380 VA: 0x1822B2D80
	public void remove_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	// RVA: 0x22B29A0 Offset: 0x22B0FA0 VA: 0x1822B29A0
	public void .ctor() { }

	// RVA: 0x22B27C0 Offset: 0x22B0DC0 VA: 0x1822B27C0
	private void ValueChanged() { }

	// RVA: 0x22B2490 Offset: 0x22B0A90 VA: 0x1822B2490
	private void DefaultCall(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B2D30 Offset: 0x22B1330 VA: 0x1822B2D30
	public string get_String() { }

	// RVA: 0x22B2C10 Offset: 0x22B1210 VA: 0x1822B2C10
	public int get_AsInt() { }

	// RVA: 0x22B2B80 Offset: 0x22B1180 VA: 0x1822B2B80
	public float get_AsFloat() { }

	// RVA: 0x22B2AF0 Offset: 0x22B10F0 VA: 0x1822B2AF0
	public bool get_AsBool() { }

	// RVA: 0x22B2CA0 Offset: 0x22B12A0 VA: 0x1822B2CA0
	public Vector3 get_AsVector3() { }

	// RVA: 0x22B2620 Offset: 0x22B0C20 VA: 0x1822B2620
	public void Set(string value) { }

	// RVA: 0x22B2710 Offset: 0x22B0D10 VA: 0x1822B2710
	public void Set(float f) { }

	// RVA: 0x22B2540 Offset: 0x22B0B40 VA: 0x1822B2540
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

	// RVA: 0x22B4C00 Offset: 0x22B3200 VA: 0x1822B4C00
	public static void Initialize(ConsoleSystem.Command[] Commands) { }

	// RVA: 0x22B5390 Offset: 0x22B3990 VA: 0x1822B5390
	public static void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B5680 Offset: 0x22B3C80 VA: 0x1822B5680
	public static ConsoleSystem.Command[] get_All() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22B56E0 Offset: 0x22B3CE0 VA: 0x1822B56E0
	private static void set_All(ConsoleSystem.Command[] value) { }

	// RVA: 0x22B5540 Offset: 0x22B3B40 VA: 0x1822B5540
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6885
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8
	public static List<ConsoleSystem.Command> Replicated; // 0x10

	// Methods

	// RVA: 0x22B5860 Offset: 0x22B3E60 VA: 0x1822B5860
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B59A0 Offset: 0x22B3FA0 VA: 0x1822B59A0
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6886
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8

	// Methods

	// RVA: 0x22B2170 Offset: 0x22B0770 VA: 0x1822B2170
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B2320 Offset: 0x22B0920 VA: 0x1822B2320
	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6887
{	// Fields
	public static readonly ConsoleSystem.Index.<>c <>9; // 0x0
	public static Action<ConsoleSystem.Command> <>9__4_1; // 0x8
	public static Action<string, bool> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x22B5FF0 Offset: 0x22B45F0 VA: 0x1822B5FF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B5D50 Offset: 0x22B4350 VA: 0x1822B5D50
	internal void <Initialize>b__4_1(ConsoleSystem.Command command) { }

	// RVA: 0x22B5B50 Offset: 0x22B4150 VA: 0x1822B5B50
	internal void <Initialize>b__4_0(string strCommand, bool pressed) { }

	// RVA: 0x22B5E80 Offset: 0x22B4480 VA: 0x1822B5E80
	internal string <.cctor>b__10_0(string s) { }

	// RVA: 0x22B5EC0 Offset: 0x22B44C0 VA: 0x1822B5EC0
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

	// RVA: 0x22B57B0 Offset: 0x22B3DB0 VA: 0x1822B57B0
	public static ConsoleSystem.Option get_Unrestricted() { }

	// RVA: 0x22B5770 Offset: 0x22B3D70 VA: 0x1822B5770
	public static ConsoleSystem.Option get_Client() { }

	// RVA: 0x22B5790 Offset: 0x22B3D90 VA: 0x1822B5790
	public static ConsoleSystem.Option get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x204B50 Offset: 0x203F50 VA: 0x180204B50
	public void set_IsServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1FA1A0 Offset: 0x1F95A0 VA: 0x1801FA1A0
	public bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D60 Offset: 0x236160 VA: 0x180236D60
	public void set_IsClient(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1210C0 Offset: 0x1204C0 VA: 0x1801210C0
	public bool get_ForwardtoServerOnMissing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236D50 Offset: 0x236150 VA: 0x180236D50
	public void set_ForwardtoServerOnMissing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x121070 Offset: 0x120470 VA: 0x180121070
	public bool get_PrintOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23AF00 Offset: 0x23A300 VA: 0x18023AF00
	public void set_PrintOutput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x121090 Offset: 0x120490 VA: 0x180121090
	public bool get_IsUnrestricted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1231B0 Offset: 0x1225B0 VA: 0x1801231B0
	public void set_IsUnrestricted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1210A0 Offset: 0x1204A0 VA: 0x1801210A0
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

	// RVA: 0x22B5F90 Offset: 0x22B4590 VA: 0x1822B5F90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B5E20 Offset: 0x22B4420 VA: 0x1822B5E20
	internal bool <SaveToConfigString>b__21_0(ConsoleSystem.Command x) { }

	// RVA: 0x22B5E50 Offset: 0x22B4450 VA: 0x1822B5E50
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

public class ConsoleGen // TypeDefIndex: 8299
{	// Fields
	public static ConsoleSystem.Command[] All; // 0x2CDB

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2FD150 Offset: 0x2FB750 VA: 0x1802FD150
	private static void .cctor() { }

}

private sealed class ConsoleGen.<>c // TypeDefIndex: 8300
{	// Fields
	public static readonly ConsoleGen.<>c <>9; // 0x2B111F4

	// Methods

	// RVA: 0xE29E50 Offset: 0xE28450 VA: 0x180E29E50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE07E60 Offset: 0xE06460 VA: 0x180E07E60
	internal string <.cctor>b__2_0() { }

	// RVA: 0xE0F050 Offset: 0xE0D650 VA: 0x180E0F050
	internal void <.cctor>b__2_1(string str) { }

	// RVA: 0xE127C0 Offset: 0xE10DC0 VA: 0x180E127C0
	internal string <.cctor>b__2_2() { }

	// RVA: 0xE15CB0 Offset: 0xE142B0 VA: 0x180E15CB0
	internal void <.cctor>b__2_3(string str) { }

	// RVA: 0xE18CB0 Offset: 0xE172B0 VA: 0x180E18CB0
	internal string <.cctor>b__2_4() { }

	// RVA: 0xE1C3B0 Offset: 0xE1A9B0 VA: 0x180E1C3B0
	internal void <.cctor>b__2_5(string str) { }

	// RVA: 0xE1FE30 Offset: 0xE1E430 VA: 0x180E1FE30
	internal string <.cctor>b__2_6() { }

	// RVA: 0xE23390 Offset: 0xE21990 VA: 0x180E23390
	internal void <.cctor>b__2_7(string str) { }

	// RVA: 0xE26770 Offset: 0xE24D70 VA: 0x180E26770
	internal string <.cctor>b__2_8() { }

	// RVA: 0xE29DA0 Offset: 0xE283A0 VA: 0x180E29DA0
	internal void <.cctor>b__2_9(string str) { }

	// RVA: 0xE0AEF0 Offset: 0xE094F0 VA: 0x180E0AEF0
	internal string <.cctor>b__2_10() { }

	// RVA: 0xE0C420 Offset: 0xE0AA20 VA: 0x180E0C420
	internal void <.cctor>b__2_11(string str) { }

	// RVA: 0xE0C9C0 Offset: 0xE0AFC0 VA: 0x180E0C9C0
	internal string <.cctor>b__2_12() { }

	// RVA: 0xE0CEC0 Offset: 0xE0B4C0 VA: 0x180E0CEC0
	internal void <.cctor>b__2_13(string str) { }

	// RVA: 0xE0D450 Offset: 0xE0BA50 VA: 0x180E0D450
	internal string <.cctor>b__2_14() { }

	// RVA: 0xE0D990 Offset: 0xE0BF90 VA: 0x180E0D990
	internal void <.cctor>b__2_15(string str) { }

	// RVA: 0xE0DF00 Offset: 0xE0C500 VA: 0x180E0DF00
	internal string <.cctor>b__2_16() { }

	// RVA: 0xE0E4A0 Offset: 0xE0CAA0 VA: 0x180E0E4A0
	internal void <.cctor>b__2_17(string str) { }

	// RVA: 0xE0EAA0 Offset: 0xE0D0A0 VA: 0x180E0EAA0
	internal string <.cctor>b__2_18() { }

	// RVA: 0xE0EFA0 Offset: 0xE0D5A0 VA: 0x180E0EFA0
	internal void <.cctor>b__2_19(string str) { }

	// RVA: 0xE0F5F0 Offset: 0xE0DBF0 VA: 0x180E0F5F0
	internal string <.cctor>b__2_20() { }

	// RVA: 0xE0FAC0 Offset: 0xE0E0C0 VA: 0x180E0FAC0
	internal void <.cctor>b__2_21(string str) { }

	// RVA: 0xE0FFA0 Offset: 0xE0E5A0 VA: 0x180E0FFA0
	internal string <.cctor>b__2_22() { }

	// RVA: 0xE10540 Offset: 0xE0EB40 VA: 0x180E10540
	internal void <.cctor>b__2_23(string str) { }

	// RVA: 0xE10AB0 Offset: 0xE0F0B0 VA: 0x180E10AB0
	internal string <.cctor>b__2_24() { }

	// RVA: 0xE11080 Offset: 0xE0F680 VA: 0x180E11080
	internal void <.cctor>b__2_25(string str) { }

	// RVA: 0xE11620 Offset: 0xE0FC20 VA: 0x180E11620
	internal string <.cctor>b__2_26() { }

	// RVA: 0xE11BB0 Offset: 0xE101B0 VA: 0x180E11BB0
	internal void <.cctor>b__2_27(string str) { }

	// RVA: 0xE12200 Offset: 0xE10800 VA: 0x180E12200
	internal string <.cctor>b__2_28() { }

	// RVA: 0xE12710 Offset: 0xE10D10 VA: 0x180E12710
	internal void <.cctor>b__2_29(string str) { }

	// RVA: 0xE12C50 Offset: 0xE11250 VA: 0x180E12C50
	internal string <.cctor>b__2_30() { }

	// RVA: 0xE13170 Offset: 0xE11770 VA: 0x180E13170
	internal void <.cctor>b__2_31(string str) { }

	// RVA: 0xE13790 Offset: 0xE11D90 VA: 0x180E13790
	internal string <.cctor>b__2_32() { }

	// RVA: 0xE13C00 Offset: 0xE12200 VA: 0x180E13C00
	internal void <.cctor>b__2_33(string str) { }

	// RVA: 0xE13FF0 Offset: 0xE125F0 VA: 0x180E13FF0
	internal string <.cctor>b__2_34() { }

	// RVA: 0xE14560 Offset: 0xE12B60 VA: 0x180E14560
	internal void <.cctor>b__2_35(string str) { }

	// RVA: 0xE14B40 Offset: 0xE13140 VA: 0x180E14B40
	internal string <.cctor>b__2_36() { }

	// RVA: 0xE150A0 Offset: 0xE136A0 VA: 0x180E150A0
	internal void <.cctor>b__2_37(string str) { }

	// RVA: 0xE15640 Offset: 0xE13C40 VA: 0x180E15640
	internal string <.cctor>b__2_38() { }

	// RVA: 0xE15C00 Offset: 0xE14200 VA: 0x180E15C00
	internal void <.cctor>b__2_39(string str) { }

	// RVA: 0xE161A0 Offset: 0xE147A0 VA: 0x180E161A0
	internal string <.cctor>b__2_40() { }

	// RVA: 0xE166C0 Offset: 0xE14CC0 VA: 0x180E166C0
	internal void <.cctor>b__2_41(string str) { }

	// RVA: 0xE16CB0 Offset: 0xE152B0 VA: 0x180E16CB0
	internal string <.cctor>b__2_42() { }

	// RVA: 0xE171B0 Offset: 0xE157B0 VA: 0x180E171B0
	internal void <.cctor>b__2_43(string str) { }

	// RVA: 0xE17770 Offset: 0xE15D70 VA: 0x180E17770
	internal string <.cctor>b__2_44() { }

	// RVA: 0xE17CF0 Offset: 0xE162F0 VA: 0x180E17CF0
	internal void <.cctor>b__2_45(string str) { }

	// RVA: 0xE182A0 Offset: 0xE168A0 VA: 0x180E182A0
	internal string <.cctor>b__2_46() { }

	// RVA: 0xE18790 Offset: 0xE16D90 VA: 0x180E18790
	internal void <.cctor>b__2_47(string str) { }

	// RVA: 0xE18930 Offset: 0xE16F30 VA: 0x180E18930
	internal string <.cctor>b__2_48() { }

	// RVA: 0xE18C00 Offset: 0xE17200 VA: 0x180E18C00
	internal void <.cctor>b__2_49(string str) { }

	// RVA: 0xE191B0 Offset: 0xE177B0 VA: 0x180E191B0
	internal string <.cctor>b__2_50() { }

	// RVA: 0xE196C0 Offset: 0xE17CC0 VA: 0x180E196C0
	internal void <.cctor>b__2_51(string str) { }

	// RVA: 0xE19C60 Offset: 0xE18260 VA: 0x180E19C60
	internal string <.cctor>b__2_52() { }

	// RVA: 0xE1A200 Offset: 0xE18800 VA: 0x180E1A200
	internal void <.cctor>b__2_53(string str) { }

	// RVA: 0xE1A740 Offset: 0xE18D40 VA: 0x180E1A740
	internal string <.cctor>b__2_54() { }

	// RVA: 0xE1AC70 Offset: 0xE19270 VA: 0x180E1AC70
	internal void <.cctor>b__2_55(string str) { }

	// RVA: 0xE1B2B0 Offset: 0xE198B0 VA: 0x180E1B2B0
	internal string <.cctor>b__2_56() { }

	// RVA: 0xE1B7B0 Offset: 0xE19DB0 VA: 0x180E1B7B0
	internal void <.cctor>b__2_57(string str) { }

	// RVA: 0xE1BD50 Offset: 0xE1A350 VA: 0x180E1BD50
	internal string <.cctor>b__2_58() { }

	// RVA: 0xE1C300 Offset: 0xE1A900 VA: 0x180E1C300
	internal void <.cctor>b__2_59(string str) { }

	// RVA: 0xE1C920 Offset: 0xE1AF20 VA: 0x180E1C920
	internal string <.cctor>b__2_60() { }

	// RVA: 0xE1CE90 Offset: 0xE1B490 VA: 0x180E1CE90
	internal void <.cctor>b__2_61(string str) { }

	// RVA: 0xE1D450 Offset: 0xE1BA50 VA: 0x180E1D450
	internal string <.cctor>b__2_62() { }

	// RVA: 0xE1DB40 Offset: 0xE1C140 VA: 0x180E1DB40
	internal void <.cctor>b__2_63(string str) { }

	// RVA: 0xE1E0F0 Offset: 0xE1C6F0 VA: 0x180E1E0F0
	internal string <.cctor>b__2_64() { }

	// RVA: 0xE1E660 Offset: 0xE1CC60 VA: 0x180E1E660
	internal void <.cctor>b__2_65(string str) { }

	// RVA: 0xE1EBF0 Offset: 0xE1D1F0 VA: 0x180E1EBF0
	internal string <.cctor>b__2_66() { }

	// RVA: 0xE1F1C0 Offset: 0xE1D7C0 VA: 0x180E1F1C0
	internal void <.cctor>b__2_67(string str) { }

	// RVA: 0xE1F7B0 Offset: 0xE1DDB0 VA: 0x180E1F7B0
	internal string <.cctor>b__2_68() { }

	// RVA: 0xE1FD80 Offset: 0xE1E380 VA: 0x180E1FD80
	internal void <.cctor>b__2_69(string str) { }

	// RVA: 0xE20430 Offset: 0xE1EA30 VA: 0x180E20430
	internal string <.cctor>b__2_70() { }

	// RVA: 0xE20940 Offset: 0xE1EF40 VA: 0x180E20940
	internal void <.cctor>b__2_71(string str) { }

	// RVA: 0xE20ED0 Offset: 0xE1F4D0 VA: 0x180E20ED0
	internal string <.cctor>b__2_72() { }

	// RVA: 0xE21470 Offset: 0xE1FA70 VA: 0x180E21470
	internal void <.cctor>b__2_73(string str) { }

	// RVA: 0xE21AB0 Offset: 0xE200B0 VA: 0x180E21AB0
	internal string <.cctor>b__2_74() { }

	// RVA: 0xE21F30 Offset: 0xE20530 VA: 0x180E21F30
	internal void <.cctor>b__2_75(string str) { }

	// RVA: 0xE223E0 Offset: 0xE209E0 VA: 0x180E223E0
	internal string <.cctor>b__2_76() { }

	// RVA: 0xE22760 Offset: 0xE20D60 VA: 0x180E22760
	internal void <.cctor>b__2_77(string str) { }

	// RVA: 0xE22D80 Offset: 0xE21380 VA: 0x180E22D80
	internal string <.cctor>b__2_78() { }

	// RVA: 0xE232E0 Offset: 0xE218E0 VA: 0x180E232E0
	internal void <.cctor>b__2_79(string str) { }

	// RVA: 0xE23760 Offset: 0xE21D60 VA: 0x180E23760
	internal string <.cctor>b__2_80() { }

	// RVA: 0xE23CF0 Offset: 0xE222F0 VA: 0x180E23CF0
	internal void <.cctor>b__2_81(string str) { }

	// RVA: 0xE24070 Offset: 0xE22670 VA: 0x180E24070
	internal string <.cctor>b__2_82() { }

	// RVA: 0xE24600 Offset: 0xE22C00 VA: 0x180E24600
	internal void <.cctor>b__2_83(string str) { }

	// RVA: 0xE24B20 Offset: 0xE23120 VA: 0x180E24B20
	internal string <.cctor>b__2_84() { }

	// RVA: 0xE250D0 Offset: 0xE236D0 VA: 0x180E250D0
	internal void <.cctor>b__2_85(string str) { }

	// RVA: 0xE25660 Offset: 0xE23C60 VA: 0x180E25660
	internal string <.cctor>b__2_86() { }

	// RVA: 0xE25C30 Offset: 0xE24230 VA: 0x180E25C30
	internal void <.cctor>b__2_87(string str) { }

	// RVA: 0xE261C0 Offset: 0xE247C0 VA: 0x180E261C0
	internal string <.cctor>b__2_88() { }

	// RVA: 0xE266C0 Offset: 0xE24CC0 VA: 0x180E266C0
	internal void <.cctor>b__2_89(string str) { }

	// RVA: 0xE26C00 Offset: 0xE25200 VA: 0x180E26C00
	internal string <.cctor>b__2_90() { }

	// RVA: 0xE27210 Offset: 0xE25810 VA: 0x180E27210
	internal void <.cctor>b__2_91(string str) { }

	// RVA: 0xE27710 Offset: 0xE25D10 VA: 0x180E27710
	internal string <.cctor>b__2_92() { }

	// RVA: 0xE27CC0 Offset: 0xE262C0 VA: 0x180E27CC0
	internal void <.cctor>b__2_93(string str) { }

	// RVA: 0xE28260 Offset: 0xE26860 VA: 0x180E28260
	internal string <.cctor>b__2_94() { }

	// RVA: 0xE287D0 Offset: 0xE26DD0 VA: 0x180E287D0
	internal void <.cctor>b__2_95(string str) { }

	// RVA: 0xE28D30 Offset: 0xE27330 VA: 0x180E28D30
	internal string <.cctor>b__2_96() { }

	// RVA: 0xE29260 Offset: 0xE27860 VA: 0x180E29260
	internal void <.cctor>b__2_97(string str) { }

	// RVA: 0xE297C0 Offset: 0xE27DC0 VA: 0x180E297C0
	internal string <.cctor>b__2_98() { }

	// RVA: 0xE29CF0 Offset: 0xE282F0 VA: 0x180E29CF0
	internal void <.cctor>b__2_99(string str) { }

	// RVA: 0xE08340 Offset: 0xE06940 VA: 0x180E08340
	internal string <.cctor>b__2_100() { }

	// RVA: 0xE08760 Offset: 0xE06D60 VA: 0x180E08760
	internal void <.cctor>b__2_101(string str) { }

	// RVA: 0xE08CB0 Offset: 0xE072B0 VA: 0x180E08CB0
	internal string <.cctor>b__2_102() { }

	// RVA: 0xE08FB0 Offset: 0xE075B0 VA: 0x180E08FB0
	internal void <.cctor>b__2_103(string str) { }

	// RVA: 0xE093A0 Offset: 0xE079A0 VA: 0x180E093A0
	internal string <.cctor>b__2_104() { }

	// RVA: 0xE09930 Offset: 0xE07F30 VA: 0x180E09930
	internal void <.cctor>b__2_105(string str) { }

	// RVA: 0xE09F50 Offset: 0xE08550 VA: 0x180E09F50
	internal string <.cctor>b__2_106() { }

	// RVA: 0xE0A3C0 Offset: 0xE089C0 VA: 0x180E0A3C0
	internal void <.cctor>b__2_107(string str) { }

	// RVA: 0xE0A8E0 Offset: 0xE08EE0 VA: 0x180E0A8E0
	internal string <.cctor>b__2_108() { }

	// RVA: 0xE0AE40 Offset: 0xE09440 VA: 0x180E0AE40
	internal void <.cctor>b__2_109(string str) { }

	// RVA: 0xE0B420 Offset: 0xE09A20 VA: 0x180E0B420
	internal string <.cctor>b__2_110() { }

	// RVA: 0xE0B940 Offset: 0xE09F40 VA: 0x180E0B940
	internal void <.cctor>b__2_111(string str) { }

	// RVA: 0xE0BF00 Offset: 0xE0A500 VA: 0x180E0BF00
	internal string <.cctor>b__2_112() { }

	// RVA: 0xE0C170 Offset: 0xE0A770 VA: 0x180E0C170
	internal void <.cctor>b__2_113(string str) { }

	// RVA: 0xE0C220 Offset: 0xE0A820 VA: 0x180E0C220
	internal void <.cctor>b__2_114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C280 Offset: 0xE0A880 VA: 0x180E0C280
	internal void <.cctor>b__2_115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C2D0 Offset: 0xE0A8D0 VA: 0x180E0C2D0
	internal void <.cctor>b__2_116(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C300 Offset: 0xE0A900 VA: 0x180E0C300
	internal void <.cctor>b__2_117(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C310 Offset: 0xE0A910 VA: 0x180E0C310
	internal string <.cctor>b__2_118() { }

	// RVA: 0xE0C370 Offset: 0xE0A970 VA: 0x180E0C370
	internal void <.cctor>b__2_119(string str) { }

	// RVA: 0xE0C4D0 Offset: 0xE0AAD0 VA: 0x180E0C4D0
	internal string <.cctor>b__2_120() { }

	// RVA: 0xE0C530 Offset: 0xE0AB30 VA: 0x180E0C530
	internal void <.cctor>b__2_121(string str) { }

	// RVA: 0xE0C5C0 Offset: 0xE0ABC0 VA: 0x180E0C5C0
	internal string <.cctor>b__2_122() { }

	// RVA: 0xE0C620 Offset: 0xE0AC20 VA: 0x180E0C620
	internal void <.cctor>b__2_123(string str) { }

	// RVA: 0xE0C6B0 Offset: 0xE0ACB0 VA: 0x180E0C6B0
	internal string <.cctor>b__2_124() { }

	// RVA: 0xE0C710 Offset: 0xE0AD10 VA: 0x180E0C710
	internal void <.cctor>b__2_125(string str) { }

	// RVA: 0xE0C7C0 Offset: 0xE0ADC0 VA: 0x180E0C7C0
	internal string <.cctor>b__2_126() { }

	// RVA: 0xE0C820 Offset: 0xE0AE20 VA: 0x180E0C820
	internal void <.cctor>b__2_127(string str) { }

	// RVA: 0xE0C8B0 Offset: 0xE0AEB0 VA: 0x180E0C8B0
	internal string <.cctor>b__2_128() { }

	// RVA: 0xE0C910 Offset: 0xE0AF10 VA: 0x180E0C910
	internal void <.cctor>b__2_129(string str) { }

	// RVA: 0xE0CA40 Offset: 0xE0B040 VA: 0x180E0CA40
	internal string <.cctor>b__2_130() { }

	// RVA: 0xE0CAA0 Offset: 0xE0B0A0 VA: 0x180E0CAA0
	internal void <.cctor>b__2_131(string str) { }

	// RVA: 0xE0CB50 Offset: 0xE0B150 VA: 0x180E0CB50
	internal void <.cctor>b__2_132(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CBB0 Offset: 0xE0B1B0 VA: 0x180E0CBB0
	internal void <.cctor>b__2_133(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CC10 Offset: 0xE0B210 VA: 0x180E0CC10
	internal void <.cctor>b__2_134(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CC70 Offset: 0xE0B270 VA: 0x180E0CC70
	internal void <.cctor>b__2_135(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CCD0 Offset: 0xE0B2D0 VA: 0x180E0CCD0
	internal string <.cctor>b__2_136() { }

	// RVA: 0xE0CD30 Offset: 0xE0B330 VA: 0x180E0CD30
	internal void <.cctor>b__2_137(string str) { }

	// RVA: 0xE0CDC0 Offset: 0xE0B3C0 VA: 0x180E0CDC0
	internal string <.cctor>b__2_138() { }

	// RVA: 0xE0CE20 Offset: 0xE0B420 VA: 0x180E0CE20
	internal void <.cctor>b__2_139(string str) { }

	// RVA: 0xE0CF70 Offset: 0xE0B570 VA: 0x180E0CF70
	internal string <.cctor>b__2_140() { }

	// RVA: 0xE0CFD0 Offset: 0xE0B5D0 VA: 0x180E0CFD0
	internal void <.cctor>b__2_141(string str) { }

	// RVA: 0xE0D070 Offset: 0xE0B670 VA: 0x180E0D070
	internal void <.cctor>b__2_142(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D0E0 Offset: 0xE0B6E0 VA: 0x180E0D0E0
	internal void <.cctor>b__2_143(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D140 Offset: 0xE0B740 VA: 0x180E0D140
	internal string <.cctor>b__2_144() { }

	// RVA: 0xE0D1A0 Offset: 0xE0B7A0 VA: 0x180E0D1A0
	internal void <.cctor>b__2_145(string str) { }

	// RVA: 0xE0D240 Offset: 0xE0B840 VA: 0x180E0D240
	internal string <.cctor>b__2_146() { }

	// RVA: 0xE0D2A0 Offset: 0xE0B8A0 VA: 0x180E0D2A0
	internal void <.cctor>b__2_147(string str) { }

	// RVA: 0xE0D350 Offset: 0xE0B950 VA: 0x180E0D350
	internal string <.cctor>b__2_148() { }

	// RVA: 0xE0D3B0 Offset: 0xE0B9B0 VA: 0x180E0D3B0
	internal void <.cctor>b__2_149(string str) { }

	// RVA: 0xE0D4D0 Offset: 0xE0BAD0 VA: 0x180E0D4D0
	internal void <.cctor>b__2_150(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D530 Offset: 0xE0BB30 VA: 0x180E0D530
	internal void <.cctor>b__2_151(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D590 Offset: 0xE0BB90 VA: 0x180E0D590
	internal string <.cctor>b__2_152() { }

	// RVA: 0xE0D5F0 Offset: 0xE0BBF0 VA: 0x180E0D5F0
	internal void <.cctor>b__2_153(string str) { }

	// RVA: 0xE0D690 Offset: 0xE0BC90 VA: 0x180E0D690
	internal string <.cctor>b__2_154() { }

	// RVA: 0xE0D6F0 Offset: 0xE0BCF0 VA: 0x180E0D6F0
	internal void <.cctor>b__2_155(string str) { }

	// RVA: 0xE0D790 Offset: 0xE0BD90 VA: 0x180E0D790
	internal string <.cctor>b__2_156() { }

	// RVA: 0xE0D7F0 Offset: 0xE0BDF0 VA: 0x180E0D7F0
	internal void <.cctor>b__2_157(string str) { }

	// RVA: 0xE0D890 Offset: 0xE0BE90 VA: 0x180E0D890
	internal string <.cctor>b__2_158() { }

	// RVA: 0xE0D8F0 Offset: 0xE0BEF0 VA: 0x180E0D8F0
	internal void <.cctor>b__2_159(string str) { }

	// RVA: 0xE0DA40 Offset: 0xE0C040 VA: 0x180E0DA40
	internal string <.cctor>b__2_160() { }

	// RVA: 0xE0DAA0 Offset: 0xE0C0A0 VA: 0x180E0DAA0
	internal void <.cctor>b__2_161(string str) { }

	// RVA: 0xE0DB50 Offset: 0xE0C150 VA: 0x180E0DB50
	internal string <.cctor>b__2_162() { }

	// RVA: 0xE0DBB0 Offset: 0xE0C1B0 VA: 0x180E0DBB0
	internal void <.cctor>b__2_163(string str) { }

	// RVA: 0xE0DC50 Offset: 0xE0C250 VA: 0x180E0DC50
	internal void <.cctor>b__2_164(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DCB0 Offset: 0xE0C2B0 VA: 0x180E0DCB0
	internal string <.cctor>b__2_165() { }

	// RVA: 0xE0DD30 Offset: 0xE0C330 VA: 0x180E0DD30
	internal void <.cctor>b__2_166(string str) { }

	// RVA: 0xE0DDA0 Offset: 0xE0C3A0 VA: 0x180E0DDA0
	internal string <.cctor>b__2_167() { }

	// RVA: 0xE0DE00 Offset: 0xE0C400 VA: 0x180E0DE00
	internal void <.cctor>b__2_168(string str) { }

	// RVA: 0xE0DEA0 Offset: 0xE0C4A0 VA: 0x180E0DEA0
	internal string <.cctor>b__2_169() { }

	// RVA: 0xE0DF80 Offset: 0xE0C580 VA: 0x180E0DF80
	internal void <.cctor>b__2_170(string str) { }

	// RVA: 0xE0E020 Offset: 0xE0C620 VA: 0x180E0E020
	internal string <.cctor>b__2_171() { }

	// RVA: 0xE0E080 Offset: 0xE0C680 VA: 0x180E0E080
	internal void <.cctor>b__2_172(string str) { }

	// RVA: 0xE0E120 Offset: 0xE0C720 VA: 0x180E0E120
	internal string <.cctor>b__2_173() { }

	// RVA: 0xE0E180 Offset: 0xE0C780 VA: 0x180E0E180
	internal void <.cctor>b__2_174(string str) { }

	// RVA: 0xE0E230 Offset: 0xE0C830 VA: 0x180E0E230
	internal string <.cctor>b__2_175() { }

	// RVA: 0xE0E290 Offset: 0xE0C890 VA: 0x180E0E290
	internal void <.cctor>b__2_176(string str) { }

	// RVA: 0xE0E340 Offset: 0xE0C940 VA: 0x180E0E340
	internal string <.cctor>b__2_177() { }

	// RVA: 0xE0E3A0 Offset: 0xE0C9A0 VA: 0x180E0E3A0
	internal void <.cctor>b__2_178(string str) { }

	// RVA: 0xE0E440 Offset: 0xE0CA40 VA: 0x180E0E440
	internal string <.cctor>b__2_179() { }

	// RVA: 0xE0E550 Offset: 0xE0CB50 VA: 0x180E0E550
	internal void <.cctor>b__2_180(string str) { }

	// RVA: 0xE0E600 Offset: 0xE0CC00 VA: 0x180E0E600
	internal string <.cctor>b__2_181() { }

	// RVA: 0xE0E660 Offset: 0xE0CC60 VA: 0x180E0E660
	internal void <.cctor>b__2_182(string str) { }

	// RVA: 0xE0E710 Offset: 0xE0CD10 VA: 0x180E0E710
	internal string <.cctor>b__2_183() { }

	// RVA: 0xE0E770 Offset: 0xE0CD70 VA: 0x180E0E770
	internal void <.cctor>b__2_184(string str) { }

	// RVA: 0xE0E820 Offset: 0xE0CE20 VA: 0x180E0E820
	internal string <.cctor>b__2_185() { }

	// RVA: 0xE0E880 Offset: 0xE0CE80 VA: 0x180E0E880
	internal void <.cctor>b__2_186(string str) { }

	// RVA: 0xE0E930 Offset: 0xE0CF30 VA: 0x180E0E930
	internal string <.cctor>b__2_187() { }

	// RVA: 0xE0E990 Offset: 0xE0CF90 VA: 0x180E0E990
	internal void <.cctor>b__2_188(string str) { }

	// RVA: 0xE0EA40 Offset: 0xE0D040 VA: 0x180E0EA40
	internal void <.cctor>b__2_189(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EB20 Offset: 0xE0D120 VA: 0x180E0EB20
	internal void <.cctor>b__2_190(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EB80 Offset: 0xE0D180 VA: 0x180E0EB80
	internal string <.cctor>b__2_191() { }

	// RVA: 0xE0EBE0 Offset: 0xE0D1E0 VA: 0x180E0EBE0
	internal void <.cctor>b__2_192(string str) { }

	// RVA: 0xE0EC60 Offset: 0xE0D260 VA: 0x180E0EC60
	internal string <.cctor>b__2_193() { }

	// RVA: 0xE0ECC0 Offset: 0xE0D2C0 VA: 0x180E0ECC0
	internal void <.cctor>b__2_194(string str) { }

	// RVA: 0xE0ED70 Offset: 0xE0D370 VA: 0x180E0ED70
	internal string <.cctor>b__2_195() { }

	// RVA: 0xE0EDD0 Offset: 0xE0D3D0 VA: 0x180E0EDD0
	internal void <.cctor>b__2_196(string str) { }

	// RVA: 0xE0EE80 Offset: 0xE0D480 VA: 0x180E0EE80
	internal void <.cctor>b__2_197(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EEE0 Offset: 0xE0D4E0 VA: 0x180E0EEE0
	internal void <.cctor>b__2_198(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EF40 Offset: 0xE0D540 VA: 0x180E0EF40
	internal string <.cctor>b__2_199() { }

	// RVA: 0xE0F0F0 Offset: 0xE0D6F0 VA: 0x180E0F0F0
	internal void <.cctor>b__2_200(string str) { }

	// RVA: 0xE0F190 Offset: 0xE0D790 VA: 0x180E0F190
	internal string <.cctor>b__2_201() { }

	// RVA: 0xE0F1F0 Offset: 0xE0D7F0 VA: 0x180E0F1F0
	internal void <.cctor>b__2_202(string str) { }

	// RVA: 0xE0F290 Offset: 0xE0D890 VA: 0x180E0F290
	internal string <.cctor>b__2_203() { }

	// RVA: 0xE0F2F0 Offset: 0xE0D8F0 VA: 0x180E0F2F0
	internal void <.cctor>b__2_204(string str) { }

	// RVA: 0xE0F390 Offset: 0xE0D990 VA: 0x180E0F390
	internal string <.cctor>b__2_205() { }

	// RVA: 0xE0F3F0 Offset: 0xE0D9F0 VA: 0x180E0F3F0
	internal void <.cctor>b__2_206(string str) { }

	// RVA: 0xE0F490 Offset: 0xE0DA90 VA: 0x180E0F490
	internal string <.cctor>b__2_207() { }

	// RVA: 0xE0F4F0 Offset: 0xE0DAF0 VA: 0x180E0F4F0
	internal void <.cctor>b__2_208(string str) { }

	// RVA: 0xE0F590 Offset: 0xE0DB90 VA: 0x180E0F590
	internal string <.cctor>b__2_209() { }

	// RVA: 0xE0F670 Offset: 0xE0DC70 VA: 0x180E0F670
	internal void <.cctor>b__2_210(string str) { }

	// RVA: 0xE0F710 Offset: 0xE0DD10 VA: 0x180E0F710
	internal void <.cctor>b__2_211(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F770 Offset: 0xE0DD70 VA: 0x180E0F770
	internal void <.cctor>b__2_212(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F7D0 Offset: 0xE0DDD0 VA: 0x180E0F7D0
	internal void <.cctor>b__2_213(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F820 Offset: 0xE0DE20 VA: 0x180E0F820
	internal string <.cctor>b__2_214() { }

	// RVA: 0xE0F880 Offset: 0xE0DE80 VA: 0x180E0F880
	internal void <.cctor>b__2_215(string str) { }

	// RVA: 0xE0F920 Offset: 0xE0DF20 VA: 0x180E0F920
	internal void <.cctor>b__2_216(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F980 Offset: 0xE0DF80 VA: 0x180E0F980
	internal string <.cctor>b__2_217() { }

	// RVA: 0xE0F9E0 Offset: 0xE0DFE0 VA: 0x180E0F9E0
	internal void <.cctor>b__2_218(string str) { }

	// RVA: 0xE0FA60 Offset: 0xE0E060 VA: 0x180E0FA60
	internal void <.cctor>b__2_219(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FB70 Offset: 0xE0E170 VA: 0x180E0FB70
	internal void <.cctor>b__2_220(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FBC0 Offset: 0xE0E1C0 VA: 0x180E0FBC0
	internal void <.cctor>b__2_221(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FC20 Offset: 0xE0E220 VA: 0x180E0FC20
	internal void <.cctor>b__2_222(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FC80 Offset: 0xE0E280 VA: 0x180E0FC80
	internal void <.cctor>b__2_223(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FCE0 Offset: 0xE0E2E0 VA: 0x180E0FCE0
	internal void <.cctor>b__2_224(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FD40 Offset: 0xE0E340 VA: 0x180E0FD40
	internal string <.cctor>b__2_225() { }

	// RVA: 0xE0FDC0 Offset: 0xE0E3C0 VA: 0x180E0FDC0
	internal void <.cctor>b__2_226(string str) { }

	// RVA: 0xE0FE30 Offset: 0xE0E430 VA: 0x180E0FE30
	internal string <.cctor>b__2_227() { }

	// RVA: 0xE0FE90 Offset: 0xE0E490 VA: 0x180E0FE90
	internal void <.cctor>b__2_228(string str) { }

	// RVA: 0xE0FF40 Offset: 0xE0E540 VA: 0x180E0FF40
	internal string <.cctor>b__2_229() { }

	// RVA: 0xE10020 Offset: 0xE0E620 VA: 0x180E10020
	internal void <.cctor>b__2_230(string str) { }

	// RVA: 0xE100D0 Offset: 0xE0E6D0 VA: 0x180E100D0
	internal string <.cctor>b__2_231() { }

	// RVA: 0xE10130 Offset: 0xE0E730 VA: 0x180E10130
	internal void <.cctor>b__2_232(string str) { }

	// RVA: 0xE101E0 Offset: 0xE0E7E0 VA: 0x180E101E0
	internal string <.cctor>b__2_233() { }

	// RVA: 0xE10240 Offset: 0xE0E840 VA: 0x180E10240
	internal void <.cctor>b__2_234(string str) { }

	// RVA: 0xE102E0 Offset: 0xE0E8E0 VA: 0x180E102E0
	internal string <.cctor>b__2_235() { }

	// RVA: 0xE10340 Offset: 0xE0E940 VA: 0x180E10340
	internal void <.cctor>b__2_236(string str) { }

	// RVA: 0xE103F0 Offset: 0xE0E9F0 VA: 0x180E103F0
	internal string <.cctor>b__2_237() { }

	// RVA: 0xE10450 Offset: 0xE0EA50 VA: 0x180E10450
	internal void <.cctor>b__2_238(string str) { }

	// RVA: 0xE104E0 Offset: 0xE0EAE0 VA: 0x180E104E0
	internal string <.cctor>b__2_239() { }

	// RVA: 0xE105F0 Offset: 0xE0EBF0 VA: 0x180E105F0
	internal void <.cctor>b__2_240(string str) { }

	// RVA: 0xE10690 Offset: 0xE0EC90 VA: 0x180E10690
	internal string <.cctor>b__2_241() { }

	// RVA: 0xE106F0 Offset: 0xE0ECF0 VA: 0x180E106F0
	internal void <.cctor>b__2_242(string str) { }

	// RVA: 0xE10770 Offset: 0xE0ED70 VA: 0x180E10770
	internal string <.cctor>b__2_243() { }

	// RVA: 0xE107D0 Offset: 0xE0EDD0 VA: 0x180E107D0
	internal void <.cctor>b__2_244(string str) { }

	// RVA: 0xE10860 Offset: 0xE0EE60 VA: 0x180E10860
	internal string <.cctor>b__2_245() { }

	// RVA: 0xE108C0 Offset: 0xE0EEC0 VA: 0x180E108C0
	internal void <.cctor>b__2_246(string str) { }

	// RVA: 0xE10940 Offset: 0xE0EF40 VA: 0x180E10940
	internal void <.cctor>b__2_247(ConsoleSystem.Arg arg) { }

	// RVA: 0xE109A0 Offset: 0xE0EFA0 VA: 0x180E109A0
	internal string <.cctor>b__2_248() { }

	// RVA: 0xE10A00 Offset: 0xE0F000 VA: 0x180E10A00
	internal void <.cctor>b__2_249(string str) { }

	// RVA: 0xE10B30 Offset: 0xE0F130 VA: 0x180E10B30
	internal string <.cctor>b__2_250() { }

	// RVA: 0xE10B90 Offset: 0xE0F190 VA: 0x180E10B90
	internal void <.cctor>b__2_251(string str) { }

	// RVA: 0xE10C40 Offset: 0xE0F240 VA: 0x180E10C40
	internal string <.cctor>b__2_252() { }

	// RVA: 0xE10CA0 Offset: 0xE0F2A0 VA: 0x180E10CA0
	internal void <.cctor>b__2_253(string str) { }

	// RVA: 0xE10D50 Offset: 0xE0F350 VA: 0x180E10D50
	internal void <.cctor>b__2_254(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10E10 Offset: 0xE0F410 VA: 0x180E10E10
	internal void <.cctor>b__2_255(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10ED0 Offset: 0xE0F4D0 VA: 0x180E10ED0
	internal void <.cctor>b__2_256(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10F20 Offset: 0xE0F520 VA: 0x180E10F20
	internal string <.cctor>b__2_257() { }

	// RVA: 0xE10F80 Offset: 0xE0F580 VA: 0x180E10F80
	internal void <.cctor>b__2_258(string str) { }

	// RVA: 0xE11020 Offset: 0xE0F620 VA: 0x180E11020
	internal string <.cctor>b__2_259() { }

	// RVA: 0xE11130 Offset: 0xE0F730 VA: 0x180E11130
	internal void <.cctor>b__2_260(string str) { }

	// RVA: 0xE111D0 Offset: 0xE0F7D0 VA: 0x180E111D0
	internal string <.cctor>b__2_261() { }

	// RVA: 0xE11230 Offset: 0xE0F830 VA: 0x180E11230
	internal void <.cctor>b__2_262(string str) { }

	// RVA: 0xE112D0 Offset: 0xE0F8D0 VA: 0x180E112D0
	internal void <.cctor>b__2_263(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11340 Offset: 0xE0F940 VA: 0x180E11340
	internal void <.cctor>b__2_264(ConsoleSystem.Arg arg) { }

	// RVA: 0xE113B0 Offset: 0xE0F9B0 VA: 0x180E113B0
	internal string <.cctor>b__2_265() { }

	// RVA: 0xE11410 Offset: 0xE0FA10 VA: 0x180E11410
	internal void <.cctor>b__2_266(string str) { }

	// RVA: 0xE114B0 Offset: 0xE0FAB0 VA: 0x180E114B0
	internal string <.cctor>b__2_267() { }

	// RVA: 0xE11510 Offset: 0xE0FB10 VA: 0x180E11510
	internal void <.cctor>b__2_268(string str) { }

	// RVA: 0xE115C0 Offset: 0xE0FBC0 VA: 0x180E115C0
	internal string <.cctor>b__2_269() { }

	// RVA: 0xE116A0 Offset: 0xE0FCA0 VA: 0x180E116A0
	internal void <.cctor>b__2_270(string str) { }

	// RVA: 0xE11740 Offset: 0xE0FD40 VA: 0x180E11740
	internal string <.cctor>b__2_271() { }

	// RVA: 0xE117A0 Offset: 0xE0FDA0 VA: 0x180E117A0
	internal void <.cctor>b__2_272(string str) { }

	// RVA: 0xE11840 Offset: 0xE0FE40 VA: 0x180E11840
	internal string <.cctor>b__2_273() { }

	// RVA: 0xE118A0 Offset: 0xE0FEA0 VA: 0x180E118A0
	internal void <.cctor>b__2_274(string str) { }

	// RVA: 0xE11940 Offset: 0xE0FF40 VA: 0x180E11940
	internal string <.cctor>b__2_275() { }

	// RVA: 0xE119A0 Offset: 0xE0FFA0 VA: 0x180E119A0
	internal void <.cctor>b__2_276(string str) { }

	// RVA: 0xE11A50 Offset: 0xE10050 VA: 0x180E11A50
	internal string <.cctor>b__2_277() { }

	// RVA: 0xE11AB0 Offset: 0xE100B0 VA: 0x180E11AB0
	internal void <.cctor>b__2_278(string str) { }

	// RVA: 0xE11B50 Offset: 0xE10150 VA: 0x180E11B50
	internal string <.cctor>b__2_279() { }

	// RVA: 0xE11C60 Offset: 0xE10260 VA: 0x180E11C60
	internal void <.cctor>b__2_280(string str) { }

	// RVA: 0xE11D00 Offset: 0xE10300 VA: 0x180E11D00
	internal string <.cctor>b__2_281() { }

	// RVA: 0xE11D60 Offset: 0xE10360 VA: 0x180E11D60
	internal void <.cctor>b__2_282(string str) { }

	// RVA: 0xE11E00 Offset: 0xE10400 VA: 0x180E11E00
	internal string <.cctor>b__2_283() { }

	// RVA: 0xE11EB0 Offset: 0xE104B0 VA: 0x180E11EB0
	internal void <.cctor>b__2_284(string str) { }

	// RVA: 0xE11F40 Offset: 0xE10540 VA: 0x180E11F40
	internal string <.cctor>b__2_285() { }

	// RVA: 0xE11FA0 Offset: 0xE105A0 VA: 0x180E11FA0
	internal void <.cctor>b__2_286(string str) { }

	// RVA: 0xE12040 Offset: 0xE10640 VA: 0x180E12040
	internal string <.cctor>b__2_287() { }

	// RVA: 0xE120F0 Offset: 0xE106F0 VA: 0x180E120F0
	internal void <.cctor>b__2_288(string str) { }

	// RVA: 0xE12180 Offset: 0xE10780 VA: 0x180E12180
	internal void <.cctor>b__2_289(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12280 Offset: 0xE10880 VA: 0x180E12280
	internal void <.cctor>b__2_290(ConsoleSystem.Arg arg) { }

	// RVA: 0xE122E0 Offset: 0xE108E0 VA: 0x180E122E0
	internal string <.cctor>b__2_291() { }

	// RVA: 0xE12340 Offset: 0xE10940 VA: 0x180E12340
	internal void <.cctor>b__2_292(string str) { }

	// RVA: 0xE123E0 Offset: 0xE109E0 VA: 0x180E123E0
	internal void <.cctor>b__2_293(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12450 Offset: 0xE10A50 VA: 0x180E12450
	internal void <.cctor>b__2_294(ConsoleSystem.Arg arg) { }

	// RVA: 0xE124C0 Offset: 0xE10AC0 VA: 0x180E124C0
	internal void <.cctor>b__2_295(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12530 Offset: 0xE10B30 VA: 0x180E12530
	internal void <.cctor>b__2_296(ConsoleSystem.Arg arg) { }

	// RVA: 0xE125A0 Offset: 0xE10BA0 VA: 0x180E125A0
	internal void <.cctor>b__2_297(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12610 Offset: 0xE10C10 VA: 0x180E12610
	internal string <.cctor>b__2_298() { }

	// RVA: 0xE12670 Offset: 0xE10C70 VA: 0x180E12670
	internal void <.cctor>b__2_299(string str) { }

	// RVA: 0xE12820 Offset: 0xE10E20 VA: 0x180E12820
	internal void <.cctor>b__2_300(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12870 Offset: 0xE10E70 VA: 0x180E12870
	internal void <.cctor>b__2_301(ConsoleSystem.Arg arg) { }

	// RVA: 0xE128D0 Offset: 0xE10ED0 VA: 0x180E128D0
	internal void <.cctor>b__2_302(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12930 Offset: 0xE10F30 VA: 0x180E12930
	internal string <.cctor>b__2_303() { }

	// RVA: 0xE12990 Offset: 0xE10F90 VA: 0x180E12990
	internal void <.cctor>b__2_304(string str) { }

	// RVA: 0xE12A30 Offset: 0xE11030 VA: 0x180E12A30
	internal void <.cctor>b__2_305(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12A90 Offset: 0xE11090 VA: 0x180E12A90
	internal string <.cctor>b__2_306() { }

	// RVA: 0xE12AF0 Offset: 0xE110F0 VA: 0x180E12AF0
	internal void <.cctor>b__2_307(string str) { }

	// RVA: 0xE12B90 Offset: 0xE11190 VA: 0x180E12B90
	internal void <.cctor>b__2_308(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12BF0 Offset: 0xE111F0 VA: 0x180E12BF0
	internal string <.cctor>b__2_309() { }

	// RVA: 0xE12CD0 Offset: 0xE112D0 VA: 0x180E12CD0
	internal void <.cctor>b__2_310(string str) { }

	// RVA: 0xE12D70 Offset: 0xE11370 VA: 0x180E12D70
	internal void <.cctor>b__2_311(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12DD0 Offset: 0xE113D0 VA: 0x180E12DD0
	internal string <.cctor>b__2_312() { }

	// RVA: 0xE12E30 Offset: 0xE11430 VA: 0x180E12E30
	internal void <.cctor>b__2_313(string str) { }

	// RVA: 0xE12ED0 Offset: 0xE114D0 VA: 0x180E12ED0
	internal void <.cctor>b__2_314(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12F30 Offset: 0xE11530 VA: 0x180E12F30
	internal void <.cctor>b__2_315(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12F90 Offset: 0xE11590 VA: 0x180E12F90
	internal string <.cctor>b__2_316() { }

	// RVA: 0xE12FF0 Offset: 0xE115F0 VA: 0x180E12FF0
	internal void <.cctor>b__2_317(string str) { }

	// RVA: 0xE13090 Offset: 0xE11690 VA: 0x180E13090
	internal string <.cctor>b__2_318() { }

	// RVA: 0xE130F0 Offset: 0xE116F0 VA: 0x180E130F0
	internal void <.cctor>b__2_319(string str) { }

	// RVA: 0xE13220 Offset: 0xE11820 VA: 0x180E13220
	internal string <.cctor>b__2_320() { }

	// RVA: 0xE13280 Offset: 0xE11880 VA: 0x180E13280
	internal void <.cctor>b__2_321(string str) { }

	// RVA: 0xE13330 Offset: 0xE11930 VA: 0x180E13330
	internal string <.cctor>b__2_322() { }

	// RVA: 0xE13390 Offset: 0xE11990 VA: 0x180E13390
	internal void <.cctor>b__2_323(string str) { }

	// RVA: 0xE13440 Offset: 0xE11A40 VA: 0x180E13440
	internal string <.cctor>b__2_324() { }

	// RVA: 0xE134A0 Offset: 0xE11AA0 VA: 0x180E134A0
	internal void <.cctor>b__2_325(string str) { }

	// RVA: 0xE13550 Offset: 0xE11B50 VA: 0x180E13550
	internal string <.cctor>b__2_326() { }

	// RVA: 0xE135B0 Offset: 0xE11BB0 VA: 0x180E135B0
	internal void <.cctor>b__2_327(string str) { }

	// RVA: 0xE13660 Offset: 0xE11C60 VA: 0x180E13660
	internal string <.cctor>b__2_328() { }

	// RVA: 0xE13710 Offset: 0xE11D10 VA: 0x180E13710
	internal void <.cctor>b__2_329(string str) { }

	// RVA: 0xE13810 Offset: 0xE11E10 VA: 0x180E13810
	internal string <.cctor>b__2_330() { }

	// RVA: 0xE13870 Offset: 0xE11E70 VA: 0x180E13870
	internal void <.cctor>b__2_331(string str) { }

	// RVA: 0xE13920 Offset: 0xE11F20 VA: 0x180E13920
	internal string <.cctor>b__2_332() { }

	// RVA: 0xE13980 Offset: 0xE11F80 VA: 0x180E13980
	internal void <.cctor>b__2_333(string str) { }

	// RVA: 0xE13A20 Offset: 0xE12020 VA: 0x180E13A20
	internal string <.cctor>b__2_334() { }

	// RVA: 0xE13A80 Offset: 0xE12080 VA: 0x180E13A80
	internal void <.cctor>b__2_335(string str) { }

	// RVA: 0xE13B00 Offset: 0xE12100 VA: 0x180E13B00
	internal string <.cctor>b__2_336() { }

	// RVA: 0xE13B60 Offset: 0xE12160 VA: 0x180E13B60
	internal void <.cctor>b__2_337(string str) { }

	// RVA: 0xE13BE0 Offset: 0xE121E0 VA: 0x180E13BE0
	internal void <.cctor>b__2_338(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13BF0 Offset: 0xE121F0 VA: 0x180E13BF0
	internal void <.cctor>b__2_339(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13CB0 Offset: 0xE122B0 VA: 0x180E13CB0
	internal void <.cctor>b__2_340(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13CC0 Offset: 0xE122C0 VA: 0x180E13CC0
	internal void <.cctor>b__2_341(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13CD0 Offset: 0xE122D0 VA: 0x180E13CD0
	internal void <.cctor>b__2_342(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13CE0 Offset: 0xE122E0 VA: 0x180E13CE0
	internal void <.cctor>b__2_343(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13CF0 Offset: 0xE122F0 VA: 0x180E13CF0
	internal string <.cctor>b__2_344() { }

	// RVA: 0xE13D50 Offset: 0xE12350 VA: 0x180E13D50
	internal void <.cctor>b__2_345(string str) { }

	// RVA: 0xE13DF0 Offset: 0xE123F0 VA: 0x180E13DF0
	internal string <.cctor>b__2_346() { }

	// RVA: 0xE13E50 Offset: 0xE12450 VA: 0x180E13E50
	internal void <.cctor>b__2_347(string str) { }

	// RVA: 0xE13EF0 Offset: 0xE124F0 VA: 0x180E13EF0
	internal string <.cctor>b__2_348() { }

	// RVA: 0xE13F50 Offset: 0xE12550 VA: 0x180E13F50
	internal void <.cctor>b__2_349(string str) { }

	// RVA: 0xE14070 Offset: 0xE12670 VA: 0x180E14070
	internal void <.cctor>b__2_350(ConsoleSystem.Arg arg) { }

	// RVA: 0xE140D0 Offset: 0xE126D0 VA: 0x180E140D0
	internal string <.cctor>b__2_351() { }

	// RVA: 0xE14130 Offset: 0xE12730 VA: 0x180E14130
	internal void <.cctor>b__2_352(string str) { }

	// RVA: 0xE141D0 Offset: 0xE127D0 VA: 0x180E141D0
	internal string <.cctor>b__2_353() { }

	// RVA: 0xE14230 Offset: 0xE12830 VA: 0x180E14230
	internal void <.cctor>b__2_354(string str) { }

	// RVA: 0xE142D0 Offset: 0xE128D0 VA: 0x180E142D0
	internal string <.cctor>b__2_355() { }

	// RVA: 0xE14330 Offset: 0xE12930 VA: 0x180E14330
	internal void <.cctor>b__2_356(string str) { }

	// RVA: 0xE143D0 Offset: 0xE129D0 VA: 0x180E143D0
	internal void <.cctor>b__2_357(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14430 Offset: 0xE12A30 VA: 0x180E14430
	internal string <.cctor>b__2_358() { }

	// RVA: 0xE144B0 Offset: 0xE12AB0 VA: 0x180E144B0
	internal void <.cctor>b__2_359(string str) { }

	// RVA: 0xE14610 Offset: 0xE12C10 VA: 0x180E14610
	internal string <.cctor>b__2_360() { }

	// RVA: 0xE14690 Offset: 0xE12C90 VA: 0x180E14690
	internal void <.cctor>b__2_361(string str) { }

	// RVA: 0xE14740 Offset: 0xE12D40 VA: 0x180E14740
	internal string <.cctor>b__2_362() { }

	// RVA: 0xE147C0 Offset: 0xE12DC0 VA: 0x180E147C0
	internal void <.cctor>b__2_363(string str) { }

	// RVA: 0xE14870 Offset: 0xE12E70 VA: 0x180E14870
	internal string <.cctor>b__2_364() { }

	// RVA: 0xE148D0 Offset: 0xE12ED0 VA: 0x180E148D0
	internal void <.cctor>b__2_365(string str) { }

	// RVA: 0xE14980 Offset: 0xE12F80 VA: 0x180E14980
	internal void <.cctor>b__2_366(ConsoleSystem.Arg arg) { }

	// RVA: 0xE149F0 Offset: 0xE12FF0 VA: 0x180E149F0
	internal void <.cctor>b__2_367(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14A60 Offset: 0xE13060 VA: 0x180E14A60
	internal void <.cctor>b__2_368(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14AD0 Offset: 0xE130D0 VA: 0x180E14AD0
	internal void <.cctor>b__2_369(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14BC0 Offset: 0xE131C0 VA: 0x180E14BC0
	internal void <.cctor>b__2_370(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14C20 Offset: 0xE13220 VA: 0x180E14C20
	internal void <.cctor>b__2_371(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14C80 Offset: 0xE13280 VA: 0x180E14C80
	internal string <.cctor>b__2_372() { }

	// RVA: 0xE14CE0 Offset: 0xE132E0 VA: 0x180E14CE0
	internal void <.cctor>b__2_373(string str) { }

	// RVA: 0xE14D80 Offset: 0xE13380 VA: 0x180E14D80
	internal string <.cctor>b__2_374() { }

	// RVA: 0xE14DE0 Offset: 0xE133E0 VA: 0x180E14DE0
	internal void <.cctor>b__2_375(string str) { }

	// RVA: 0xE14E80 Offset: 0xE13480 VA: 0x180E14E80
	internal string <.cctor>b__2_376() { }

	// RVA: 0xE14F00 Offset: 0xE13500 VA: 0x180E14F00
	internal void <.cctor>b__2_377(string str) { }

	// RVA: 0xE14FB0 Offset: 0xE135B0 VA: 0x180E14FB0
	internal string <.cctor>b__2_378() { }

	// RVA: 0xE15010 Offset: 0xE13610 VA: 0x180E15010
	internal void <.cctor>b__2_379(string str) { }

	// RVA: 0xE15150 Offset: 0xE13750 VA: 0x180E15150
	internal string <.cctor>b__2_380() { }

	// RVA: 0xE151B0 Offset: 0xE137B0 VA: 0x180E151B0
	internal void <.cctor>b__2_381(string str) { }

	// RVA: 0xE15250 Offset: 0xE13850 VA: 0x180E15250
	internal string <.cctor>b__2_382() { }

	// RVA: 0xE152D0 Offset: 0xE138D0 VA: 0x180E152D0
	internal void <.cctor>b__2_383(string str) { }

	// RVA: 0xE15380 Offset: 0xE13980 VA: 0x180E15380
	internal void <.cctor>b__2_384(ConsoleSystem.Arg arg) { }

	// RVA: 0xE153E0 Offset: 0xE139E0 VA: 0x180E153E0
	internal void <.cctor>b__2_385(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15440 Offset: 0xE13A40 VA: 0x180E15440
	internal void <.cctor>b__2_386(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15510 Offset: 0xE13B10 VA: 0x180E15510
	internal void <.cctor>b__2_387(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15560 Offset: 0xE13B60 VA: 0x180E15560
	internal void <.cctor>b__2_388(ConsoleSystem.Arg arg) { }

	// RVA: 0xE155C0 Offset: 0xE13BC0 VA: 0x180E155C0
	internal string <.cctor>b__2_389() { }

	// RVA: 0xE156C0 Offset: 0xE13CC0 VA: 0x180E156C0
	internal void <.cctor>b__2_390(string str) { }

	// RVA: 0xE15770 Offset: 0xE13D70 VA: 0x180E15770
	internal void <.cctor>b__2_391(ConsoleSystem.Arg arg) { }

	// RVA: 0xE157D0 Offset: 0xE13DD0 VA: 0x180E157D0
	internal void <.cctor>b__2_392(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15830 Offset: 0xE13E30 VA: 0x180E15830
	internal string <.cctor>b__2_393() { }

	// RVA: 0xE158B0 Offset: 0xE13EB0 VA: 0x180E158B0
	internal void <.cctor>b__2_394(string str) { }

	// RVA: 0xE15960 Offset: 0xE13F60 VA: 0x180E15960
	internal string <.cctor>b__2_395() { }

	// RVA: 0xE159E0 Offset: 0xE13FE0 VA: 0x180E159E0
	internal void <.cctor>b__2_396(string str) { }

	// RVA: 0xE15A90 Offset: 0xE14090 VA: 0x180E15A90
	internal string <.cctor>b__2_397() { }

	// RVA: 0xE15AF0 Offset: 0xE140F0 VA: 0x180E15AF0
	internal void <.cctor>b__2_398(string str) { }

	// RVA: 0xE15B90 Offset: 0xE14190 VA: 0x180E15B90
	internal void <.cctor>b__2_399(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15D50 Offset: 0xE14350 VA: 0x180E15D50
	internal string <.cctor>b__2_400() { }

	// RVA: 0xE15DD0 Offset: 0xE143D0 VA: 0x180E15DD0
	internal void <.cctor>b__2_401(string str) { }

	// RVA: 0xE15E40 Offset: 0xE14440 VA: 0x180E15E40
	internal string <.cctor>b__2_402() { }

	// RVA: 0xE15EA0 Offset: 0xE144A0 VA: 0x180E15EA0
	internal void <.cctor>b__2_403(string str) { }

	// RVA: 0xE15F20 Offset: 0xE14520 VA: 0x180E15F20
	internal void <.cctor>b__2_404(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15F80 Offset: 0xE14580 VA: 0x180E15F80
	internal void <.cctor>b__2_405(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15FE0 Offset: 0xE145E0 VA: 0x180E15FE0
	internal void <.cctor>b__2_406(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16040 Offset: 0xE14640 VA: 0x180E16040
	internal string <.cctor>b__2_407() { }

	// RVA: 0xE160A0 Offset: 0xE146A0 VA: 0x180E160A0
	internal void <.cctor>b__2_408(string str) { }

	// RVA: 0xE16140 Offset: 0xE14740 VA: 0x180E16140
	internal void <.cctor>b__2_409(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16220 Offset: 0xE14820 VA: 0x180E16220
	internal string <.cctor>b__2_410() { }

	// RVA: 0xE16280 Offset: 0xE14880 VA: 0x180E16280
	internal void <.cctor>b__2_411(string str) { }

	// RVA: 0xE16300 Offset: 0xE14900 VA: 0x180E16300
	internal void <.cctor>b__2_412(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16360 Offset: 0xE14960 VA: 0x180E16360
	internal string <.cctor>b__2_413() { }

	// RVA: 0xE163C0 Offset: 0xE149C0 VA: 0x180E163C0
	internal void <.cctor>b__2_414(string str) { }

	// RVA: 0xE16460 Offset: 0xE14A60 VA: 0x180E16460
	internal string <.cctor>b__2_415() { }

	// RVA: 0xE164C0 Offset: 0xE14AC0 VA: 0x180E164C0
	internal void <.cctor>b__2_416(string str) { }

	// RVA: 0xE16560 Offset: 0xE14B60 VA: 0x180E16560
	internal void <.cctor>b__2_417(ConsoleSystem.Arg arg) { }

	// RVA: 0xE165C0 Offset: 0xE14BC0 VA: 0x180E165C0
	internal string <.cctor>b__2_418() { }

	// RVA: 0xE16620 Offset: 0xE14C20 VA: 0x180E16620
	internal void <.cctor>b__2_419(string str) { }

	// RVA: 0xE16770 Offset: 0xE14D70 VA: 0x180E16770
	internal string <.cctor>b__2_420() { }

	// RVA: 0xE167D0 Offset: 0xE14DD0 VA: 0x180E167D0
	internal void <.cctor>b__2_421(string str) { }

	// RVA: 0xE16870 Offset: 0xE14E70 VA: 0x180E16870
	internal string <.cctor>b__2_422() { }

	// RVA: 0xE16920 Offset: 0xE14F20 VA: 0x180E16920
	internal void <.cctor>b__2_423(string str) { }

	// RVA: 0xE169B0 Offset: 0xE14FB0 VA: 0x180E169B0
	internal string <.cctor>b__2_424() { }

	// RVA: 0xE16A10 Offset: 0xE15010 VA: 0x180E16A10
	internal void <.cctor>b__2_425(string str) { }

	// RVA: 0xE16AB0 Offset: 0xE150B0 VA: 0x180E16AB0
	internal void <.cctor>b__2_426(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16B00 Offset: 0xE15100 VA: 0x180E16B00
	internal string <.cctor>b__2_427() { }

	// RVA: 0xE16B60 Offset: 0xE15160 VA: 0x180E16B60
	internal void <.cctor>b__2_428(string str) { }

	// RVA: 0xE16C00 Offset: 0xE15200 VA: 0x180E16C00
	internal string <.cctor>b__2_429() { }

	// RVA: 0xE16D30 Offset: 0xE15330 VA: 0x180E16D30
	internal void <.cctor>b__2_430(string str) { }

	// RVA: 0xE16DB0 Offset: 0xE153B0 VA: 0x180E16DB0
	internal void <.cctor>b__2_431(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16E40 Offset: 0xE15440 VA: 0x180E16E40
	internal void <.cctor>b__2_432(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16EB0 Offset: 0xE154B0 VA: 0x180E16EB0
	internal void <.cctor>b__2_433(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16F40 Offset: 0xE15540 VA: 0x180E16F40
	internal void <.cctor>b__2_434(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16FB0 Offset: 0xE155B0 VA: 0x180E16FB0
	internal void <.cctor>b__2_435(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17000 Offset: 0xE15600 VA: 0x180E17000
	internal void <.cctor>b__2_436(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17090 Offset: 0xE15690 VA: 0x180E17090
	internal void <.cctor>b__2_437(ConsoleSystem.Arg arg) { }

	// RVA: 0xE170E0 Offset: 0xE156E0 VA: 0x180E170E0
	internal void <.cctor>b__2_438(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17150 Offset: 0xE15750 VA: 0x180E17150
	internal string <.cctor>b__2_439() { }

	// RVA: 0xE17260 Offset: 0xE15860 VA: 0x180E17260
	internal void <.cctor>b__2_440(string str) { }

	// RVA: 0xE17300 Offset: 0xE15900 VA: 0x180E17300
	internal void <.cctor>b__2_441(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17390 Offset: 0xE15990 VA: 0x180E17390
	internal void <.cctor>b__2_442(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17400 Offset: 0xE15A00 VA: 0x180E17400
	internal string <.cctor>b__2_443() { }

	// RVA: 0xE17460 Offset: 0xE15A60 VA: 0x180E17460
	internal void <.cctor>b__2_444(string str) { }

	// RVA: 0xE17510 Offset: 0xE15B10 VA: 0x180E17510
	internal void <.cctor>b__2_445(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17570 Offset: 0xE15B70 VA: 0x180E17570
	internal void <.cctor>b__2_446(ConsoleSystem.Arg arg) { }

	// RVA: 0xE175E0 Offset: 0xE15BE0 VA: 0x180E175E0
	internal string <.cctor>b__2_447() { }

	// RVA: 0xE17690 Offset: 0xE15C90 VA: 0x180E17690
	internal void <.cctor>b__2_448(string str) { }

	// RVA: 0xE17710 Offset: 0xE15D10 VA: 0x180E17710
	internal string <.cctor>b__2_449() { }

	// RVA: 0xE177F0 Offset: 0xE15DF0 VA: 0x180E177F0
	internal void <.cctor>b__2_450(string str) { }

	// RVA: 0xE17890 Offset: 0xE15E90 VA: 0x180E17890
	internal string <.cctor>b__2_451() { }

	// RVA: 0xE178F0 Offset: 0xE15EF0 VA: 0x180E178F0
	internal void <.cctor>b__2_452(string str) { }

	// RVA: 0xE17990 Offset: 0xE15F90 VA: 0x180E17990
	internal void <.cctor>b__2_453(ConsoleSystem.Arg arg) { }

	// RVA: 0xE179F0 Offset: 0xE15FF0 VA: 0x180E179F0
	internal string <.cctor>b__2_454() { }

	// RVA: 0xE17A50 Offset: 0xE16050 VA: 0x180E17A50
	internal void <.cctor>b__2_455(string str) { }

	// RVA: 0xE17AF0 Offset: 0xE160F0 VA: 0x180E17AF0
	internal string <.cctor>b__2_456() { }

	// RVA: 0xE17B50 Offset: 0xE16150 VA: 0x180E17B50
	internal void <.cctor>b__2_457(string str) { }

	// RVA: 0xE17BF0 Offset: 0xE161F0 VA: 0x180E17BF0
	internal string <.cctor>b__2_458() { }

	// RVA: 0xE17C50 Offset: 0xE16250 VA: 0x180E17C50
	internal void <.cctor>b__2_459(string str) { }

	// RVA: 0xE17DA0 Offset: 0xE163A0 VA: 0x180E17DA0
	internal string <.cctor>b__2_460() { }

	// RVA: 0xE17E00 Offset: 0xE16400 VA: 0x180E17E00
	internal void <.cctor>b__2_461(string str) { }

	// RVA: 0xE17EA0 Offset: 0xE164A0 VA: 0x180E17EA0
	internal string <.cctor>b__2_462() { }

	// RVA: 0xE17F00 Offset: 0xE16500 VA: 0x180E17F00
	internal void <.cctor>b__2_463(string str) { }

	// RVA: 0xE17FA0 Offset: 0xE165A0 VA: 0x180E17FA0
	internal string <.cctor>b__2_464() { }

	// RVA: 0xE18000 Offset: 0xE16600 VA: 0x180E18000
	internal void <.cctor>b__2_465(string str) { }

	// RVA: 0xE180A0 Offset: 0xE166A0 VA: 0x180E180A0
	internal string <.cctor>b__2_466() { }

	// RVA: 0xE18100 Offset: 0xE16700 VA: 0x180E18100
	internal void <.cctor>b__2_467(string str) { }

	// RVA: 0xE181A0 Offset: 0xE167A0 VA: 0x180E181A0
	internal string <.cctor>b__2_468() { }

	// RVA: 0xE18200 Offset: 0xE16800 VA: 0x180E18200
	internal void <.cctor>b__2_469(string str) { }

	// RVA: 0xE18320 Offset: 0xE16920 VA: 0x180E18320
	internal string <.cctor>b__2_470() { }

	// RVA: 0xE18380 Offset: 0xE16980 VA: 0x180E18380
	internal void <.cctor>b__2_471(string str) { }

	// RVA: 0xE18420 Offset: 0xE16A20 VA: 0x180E18420
	internal string <.cctor>b__2_472() { }

	// RVA: 0xE18480 Offset: 0xE16A80 VA: 0x180E18480
	internal void <.cctor>b__2_473(string str) { }

	// RVA: 0xE18520 Offset: 0xE16B20 VA: 0x180E18520
	internal string <.cctor>b__2_474() { }

	// RVA: 0xE18580 Offset: 0xE16B80 VA: 0x180E18580
	internal void <.cctor>b__2_475(string str) { }

	// RVA: 0xE18620 Offset: 0xE16C20 VA: 0x180E18620
	internal string <.cctor>b__2_476() { }

	// RVA: 0xE18680 Offset: 0xE16C80 VA: 0x180E18680
	internal void <.cctor>b__2_477(string str) { }

	// RVA: 0xE18720 Offset: 0xE16D20 VA: 0x180E18720
	internal void <.cctor>b__2_478(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18780 Offset: 0xE16D80 VA: 0x180E18780
	internal void <.cctor>b__2_479(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18840 Offset: 0xE16E40 VA: 0x180E18840
	internal void <.cctor>b__2_480(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18850 Offset: 0xE16E50 VA: 0x180E18850
	internal void <.cctor>b__2_481(ConsoleSystem.Arg arg) { }

	// RVA: 0xE188B0 Offset: 0xE16EB0 VA: 0x180E188B0
	internal void <.cctor>b__2_482(ConsoleSystem.Arg arg) { }

	// RVA: 0xE188C0 Offset: 0xE16EC0 VA: 0x180E188C0
	internal void <.cctor>b__2_483(ConsoleSystem.Arg arg) { }

	// RVA: 0xE188D0 Offset: 0xE16ED0 VA: 0x180E188D0
	internal void <.cctor>b__2_484(ConsoleSystem.Arg arg) { }

	// RVA: 0xE188E0 Offset: 0xE16EE0 VA: 0x180E188E0
	internal void <.cctor>b__2_485(ConsoleSystem.Arg arg) { }

	// RVA: 0xE188F0 Offset: 0xE16EF0 VA: 0x180E188F0
	internal void <.cctor>b__2_486(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18900 Offset: 0xE16F00 VA: 0x180E18900
	internal void <.cctor>b__2_487(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18910 Offset: 0xE16F10 VA: 0x180E18910
	internal void <.cctor>b__2_488(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18920 Offset: 0xE16F20 VA: 0x180E18920
	internal void <.cctor>b__2_489(ConsoleSystem.Arg arg) { }

	// RVA: 0xE189B0 Offset: 0xE16FB0 VA: 0x180E189B0
	internal void <.cctor>b__2_490(ConsoleSystem.Arg arg) { }

	// RVA: 0xE189C0 Offset: 0xE16FC0 VA: 0x180E189C0
	internal void <.cctor>b__2_491(ConsoleSystem.Arg arg) { }

	// RVA: 0xE189D0 Offset: 0xE16FD0 VA: 0x180E189D0
	internal string <.cctor>b__2_492() { }

	// RVA: 0xE189F0 Offset: 0xE16FF0 VA: 0x180E189F0
	internal void <.cctor>b__2_493(string str) { }

	// RVA: 0xE18A50 Offset: 0xE17050 VA: 0x180E18A50
	internal string <.cctor>b__2_494() { }

	// RVA: 0xE18A80 Offset: 0xE17080 VA: 0x180E18A80
	internal void <.cctor>b__2_495(string str) { }

	// RVA: 0xE18AE0 Offset: 0xE170E0 VA: 0x180E18AE0
	internal string <.cctor>b__2_496() { }

	// RVA: 0xE18B10 Offset: 0xE17110 VA: 0x180E18B10
	internal void <.cctor>b__2_497(string str) { }

	// RVA: 0xE18B70 Offset: 0xE17170 VA: 0x180E18B70
	internal string <.cctor>b__2_498() { }

	// RVA: 0xE18BA0 Offset: 0xE171A0 VA: 0x180E18BA0
	internal void <.cctor>b__2_499(string str) { }

	// RVA: 0xE18D30 Offset: 0xE17330 VA: 0x180E18D30
	internal string <.cctor>b__2_500() { }

	// RVA: 0xE18DA0 Offset: 0xE173A0 VA: 0x180E18DA0
	internal void <.cctor>b__2_501(string str) { }

	// RVA: 0xE18E50 Offset: 0xE17450 VA: 0x180E18E50
	internal string <.cctor>b__2_502() { }

	// RVA: 0xE18EC0 Offset: 0xE174C0 VA: 0x180E18EC0
	internal void <.cctor>b__2_503(string str) { }

	// RVA: 0xE18F70 Offset: 0xE17570 VA: 0x180E18F70
	internal string <.cctor>b__2_504() { }

	// RVA: 0xE18FC0 Offset: 0xE175C0 VA: 0x180E18FC0
	internal void <.cctor>b__2_505(string str) { }

	// RVA: 0xE19020 Offset: 0xE17620 VA: 0x180E19020
	internal string <.cctor>b__2_506() { }

	// RVA: 0xE19040 Offset: 0xE17640 VA: 0x180E19040
	internal void <.cctor>b__2_507(string str) { }

	// RVA: 0xE190A0 Offset: 0xE176A0 VA: 0x180E190A0
	internal void <.cctor>b__2_508(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19100 Offset: 0xE17700 VA: 0x180E19100
	internal string <.cctor>b__2_509() { }

	// RVA: 0xE19230 Offset: 0xE17830 VA: 0x180E19230
	internal void <.cctor>b__2_510(string str) { }

	// RVA: 0xE192B0 Offset: 0xE178B0 VA: 0x180E192B0
	internal string <.cctor>b__2_511() { }

	// RVA: 0xE19310 Offset: 0xE17910 VA: 0x180E19310
	internal void <.cctor>b__2_512(string str) { }

	// RVA: 0xE193B0 Offset: 0xE179B0 VA: 0x180E193B0
	internal void <.cctor>b__2_513(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19400 Offset: 0xE17A00 VA: 0x180E19400
	internal string <.cctor>b__2_514() { }

	// RVA: 0xE19460 Offset: 0xE17A60 VA: 0x180E19460
	internal void <.cctor>b__2_515(string str) { }

	// RVA: 0xE19500 Offset: 0xE17B00 VA: 0x180E19500
	internal string <.cctor>b__2_516() { }

	// RVA: 0xE19560 Offset: 0xE17B60 VA: 0x180E19560
	internal void <.cctor>b__2_517(string str) { }

	// RVA: 0xE195E0 Offset: 0xE17BE0 VA: 0x180E195E0
	internal string <.cctor>b__2_518() { }

	// RVA: 0xE19640 Offset: 0xE17C40 VA: 0x180E19640
	internal void <.cctor>b__2_519(string str) { }

	// RVA: 0xE19770 Offset: 0xE17D70 VA: 0x180E19770
	internal string <.cctor>b__2_520() { }

	// RVA: 0xE197D0 Offset: 0xE17DD0 VA: 0x180E197D0
	internal void <.cctor>b__2_521(string str) { }

	// RVA: 0xE19850 Offset: 0xE17E50 VA: 0x180E19850
	internal void <.cctor>b__2_522(ConsoleSystem.Arg arg) { }

	// RVA: 0xE198A0 Offset: 0xE17EA0 VA: 0x180E198A0
	internal string <.cctor>b__2_523() { }

	// RVA: 0xE19900 Offset: 0xE17F00 VA: 0x180E19900
	internal void <.cctor>b__2_524(string str) { }

	// RVA: 0xE199A0 Offset: 0xE17FA0 VA: 0x180E199A0
	internal string <.cctor>b__2_525() { }

	// RVA: 0xE19A00 Offset: 0xE18000 VA: 0x180E19A00
	internal void <.cctor>b__2_526(string str) { }

	// RVA: 0xE19A80 Offset: 0xE18080 VA: 0x180E19A80
	internal string <.cctor>b__2_527() { }

	// RVA: 0xE19B30 Offset: 0xE18130 VA: 0x180E19B30
	internal void <.cctor>b__2_528(string str) { }

	// RVA: 0xE19BB0 Offset: 0xE181B0 VA: 0x180E19BB0
	internal string <.cctor>b__2_529() { }

	// RVA: 0xE19CE0 Offset: 0xE182E0 VA: 0x180E19CE0
	internal void <.cctor>b__2_530(string str) { }

	// RVA: 0xE19D60 Offset: 0xE18360 VA: 0x180E19D60
	internal void <.cctor>b__2_531(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19DC0 Offset: 0xE183C0 VA: 0x180E19DC0
	internal string <.cctor>b__2_532() { }

	// RVA: 0xE19E70 Offset: 0xE18470 VA: 0x180E19E70
	internal void <.cctor>b__2_533(string str) { }

	// RVA: 0xE19F00 Offset: 0xE18500 VA: 0x180E19F00
	internal string <.cctor>b__2_534() { }

	// RVA: 0xE19F60 Offset: 0xE18560 VA: 0x180E19F60
	internal void <.cctor>b__2_535(string str) { }

	// RVA: 0xE1A040 Offset: 0xE18640 VA: 0x180E1A040
	internal void <.cctor>b__2_536(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A0A0 Offset: 0xE186A0 VA: 0x180E1A0A0
	internal void <.cctor>b__2_537(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A100 Offset: 0xE18700 VA: 0x180E1A100
	internal string <.cctor>b__2_538() { }

	// RVA: 0xE1A160 Offset: 0xE18760 VA: 0x180E1A160
	internal void <.cctor>b__2_539(string str) { }

	// RVA: 0xE1A2B0 Offset: 0xE188B0 VA: 0x180E1A2B0
	internal void <.cctor>b__2_540(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A310 Offset: 0xE18910 VA: 0x180E1A310
	internal string <.cctor>b__2_541() { }

	// RVA: 0xE1A370 Offset: 0xE18970 VA: 0x180E1A370
	internal void <.cctor>b__2_542(string str) { }

	// RVA: 0xE1A410 Offset: 0xE18A10 VA: 0x180E1A410
	internal string <.cctor>b__2_543() { }

	// RVA: 0xE1A480 Offset: 0xE18A80 VA: 0x180E1A480
	internal void <.cctor>b__2_544(string str) { }

	// RVA: 0xE1A4E0 Offset: 0xE18AE0 VA: 0x180E1A4E0
	internal string <.cctor>b__2_545() { }

	// RVA: 0xE1A540 Offset: 0xE18B40 VA: 0x180E1A540
	internal void <.cctor>b__2_546(string str) { }

	// RVA: 0xE1A5E0 Offset: 0xE18BE0 VA: 0x180E1A5E0
	internal string <.cctor>b__2_547() { }

	// RVA: 0xE1A640 Offset: 0xE18C40 VA: 0x180E1A640
	internal void <.cctor>b__2_548(string str) { }

	// RVA: 0xE1A6E0 Offset: 0xE18CE0 VA: 0x180E1A6E0
	internal void <.cctor>b__2_549(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A7C0 Offset: 0xE18DC0 VA: 0x180E1A7C0
	internal string <.cctor>b__2_550() { }

	// RVA: 0xE1A820 Offset: 0xE18E20 VA: 0x180E1A820
	internal void <.cctor>b__2_551(string str) { }

	// RVA: 0xE1A8C0 Offset: 0xE18EC0 VA: 0x180E1A8C0
	internal string <.cctor>b__2_552() { }

	// RVA: 0xE1A920 Offset: 0xE18F20 VA: 0x180E1A920
	internal void <.cctor>b__2_553(string str) { }

	// RVA: 0xE1A9C0 Offset: 0xE18FC0 VA: 0x180E1A9C0
	internal string <.cctor>b__2_554() { }

	// RVA: 0xE1AA70 Offset: 0xE19070 VA: 0x180E1AA70
	internal void <.cctor>b__2_555(string str) { }

	// RVA: 0xE1AAF0 Offset: 0xE190F0 VA: 0x180E1AAF0
	internal void <.cctor>b__2_556(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1AB50 Offset: 0xE19150 VA: 0x180E1AB50
	internal void <.cctor>b__2_557(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1ABB0 Offset: 0xE191B0 VA: 0x180E1ABB0
	internal void <.cctor>b__2_558(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1AC10 Offset: 0xE19210 VA: 0x180E1AC10
	internal string <.cctor>b__2_559() { }

	// RVA: 0xE1AD20 Offset: 0xE19320 VA: 0x180E1AD20
	internal void <.cctor>b__2_560(string str) { }

	// RVA: 0xE1ADC0 Offset: 0xE193C0 VA: 0x180E1ADC0
	internal string <.cctor>b__2_561() { }

	// RVA: 0xE1AE70 Offset: 0xE19470 VA: 0x180E1AE70
	internal void <.cctor>b__2_562(string str) { }

	// RVA: 0xE1AF50 Offset: 0xE19550 VA: 0x180E1AF50
	internal string <.cctor>b__2_563() { }

	// RVA: 0xE1AFB0 Offset: 0xE195B0 VA: 0x180E1AFB0
	internal void <.cctor>b__2_564(string str) { }

	// RVA: 0xE1B050 Offset: 0xE19650 VA: 0x180E1B050
	internal string <.cctor>b__2_565() { }

	// RVA: 0xE1B0B0 Offset: 0xE196B0 VA: 0x180E1B0B0
	internal void <.cctor>b__2_566(string str) { }

	// RVA: 0xE1B150 Offset: 0xE19750 VA: 0x180E1B150
	internal string <.cctor>b__2_567() { }

	// RVA: 0xE1B1B0 Offset: 0xE197B0 VA: 0x180E1B1B0
	internal void <.cctor>b__2_568(string str) { }

	// RVA: 0xE1B250 Offset: 0xE19850 VA: 0x180E1B250
	internal string <.cctor>b__2_569() { }

	// RVA: 0xE1B330 Offset: 0xE19930 VA: 0x180E1B330
	internal void <.cctor>b__2_570(string str) { }

	// RVA: 0xE1B3D0 Offset: 0xE199D0 VA: 0x180E1B3D0
	internal string <.cctor>b__2_571() { }

	// RVA: 0xE1B430 Offset: 0xE19A30 VA: 0x180E1B430
	internal void <.cctor>b__2_572(string str) { }

	// RVA: 0xE1B4D0 Offset: 0xE19AD0 VA: 0x180E1B4D0
	internal void <.cctor>b__2_573(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B530 Offset: 0xE19B30 VA: 0x180E1B530
	internal string <.cctor>b__2_574() { }

	// RVA: 0xE1B590 Offset: 0xE19B90 VA: 0x180E1B590
	internal void <.cctor>b__2_575(string str) { }

	// RVA: 0xE1B630 Offset: 0xE19C30 VA: 0x180E1B630
	internal void <.cctor>b__2_576(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B690 Offset: 0xE19C90 VA: 0x180E1B690
	internal void <.cctor>b__2_577(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B6F0 Offset: 0xE19CF0 VA: 0x180E1B6F0
	internal void <.cctor>b__2_578(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B750 Offset: 0xE19D50 VA: 0x180E1B750
	internal void <.cctor>b__2_579(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B860 Offset: 0xE19E60 VA: 0x180E1B860
	internal string <.cctor>b__2_580() { }

	// RVA: 0xE1B8C0 Offset: 0xE19EC0 VA: 0x180E1B8C0
	internal void <.cctor>b__2_581(string str) { }

	// RVA: 0xE1B960 Offset: 0xE19F60 VA: 0x180E1B960
	internal string <.cctor>b__2_582() { }

	// RVA: 0xE1B9C0 Offset: 0xE19FC0 VA: 0x180E1B9C0
	internal void <.cctor>b__2_583(string str) { }

	// RVA: 0xE1BA70 Offset: 0xE1A070 VA: 0x180E1BA70
	internal void <.cctor>b__2_584(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1BAD0 Offset: 0xE1A0D0 VA: 0x180E1BAD0
	internal string <.cctor>b__2_585() { }

	// RVA: 0xE1BB30 Offset: 0xE1A130 VA: 0x180E1BB30
	internal void <.cctor>b__2_586(string str) { }

	// RVA: 0xE1BBD0 Offset: 0xE1A1D0 VA: 0x180E1BBD0
	internal void <.cctor>b__2_587(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1BC20 Offset: 0xE1A220 VA: 0x180E1BC20
	internal string <.cctor>b__2_588() { }

	// RVA: 0xE1BCD0 Offset: 0xE1A2D0 VA: 0x180E1BCD0
	internal void <.cctor>b__2_589(string str) { }

	// RVA: 0xE1BDD0 Offset: 0xE1A3D0 VA: 0x180E1BDD0
	internal string <.cctor>b__2_590() { }

	// RVA: 0xE1BE30 Offset: 0xE1A430 VA: 0x180E1BE30
	internal void <.cctor>b__2_591(string str) { }

	// RVA: 0xE1BED0 Offset: 0xE1A4D0 VA: 0x180E1BED0
	internal string <.cctor>b__2_592() { }

	// RVA: 0xE1BF80 Offset: 0xE1A580 VA: 0x180E1BF80
	internal void <.cctor>b__2_593(string str) { }

	// RVA: 0xE1C000 Offset: 0xE1A600 VA: 0x180E1C000
	internal string <.cctor>b__2_594() { }

	// RVA: 0xE1C060 Offset: 0xE1A660 VA: 0x180E1C060
	internal void <.cctor>b__2_595(string str) { }

	// RVA: 0xE1C100 Offset: 0xE1A700 VA: 0x180E1C100
	internal string <.cctor>b__2_596() { }

	// RVA: 0xE1C160 Offset: 0xE1A760 VA: 0x180E1C160
	internal void <.cctor>b__2_597(string str) { }

	// RVA: 0xE1C200 Offset: 0xE1A800 VA: 0x180E1C200
	internal string <.cctor>b__2_598() { }

	// RVA: 0xE1C260 Offset: 0xE1A860 VA: 0x180E1C260
	internal void <.cctor>b__2_599(string str) { }

	// RVA: 0xE1C410 Offset: 0xE1AA10 VA: 0x180E1C410
	internal string <.cctor>b__2_600() { }

	// RVA: 0xE1C470 Offset: 0xE1AA70 VA: 0x180E1C470
	internal void <.cctor>b__2_601(string str) { }

	// RVA: 0xE1C510 Offset: 0xE1AB10 VA: 0x180E1C510
	internal string <.cctor>b__2_602() { }

	// RVA: 0xE1C570 Offset: 0xE1AB70 VA: 0x180E1C570
	internal void <.cctor>b__2_603(string str) { }

	// RVA: 0xE1C610 Offset: 0xE1AC10 VA: 0x180E1C610
	internal string <.cctor>b__2_604() { }

	// RVA: 0xE1C670 Offset: 0xE1AC70 VA: 0x180E1C670
	internal void <.cctor>b__2_605(string str) { }

	// RVA: 0xE1C710 Offset: 0xE1AD10 VA: 0x180E1C710
	internal string <.cctor>b__2_606() { }

	// RVA: 0xE1C770 Offset: 0xE1AD70 VA: 0x180E1C770
	internal void <.cctor>b__2_607(string str) { }

	// RVA: 0xE1C810 Offset: 0xE1AE10 VA: 0x180E1C810
	internal string <.cctor>b__2_608() { }

	// RVA: 0xE1C870 Offset: 0xE1AE70 VA: 0x180E1C870
	internal void <.cctor>b__2_609(string str) { }

	// RVA: 0xE1C9A0 Offset: 0xE1AFA0 VA: 0x180E1C9A0
	internal string <.cctor>b__2_610() { }

	// RVA: 0xE1CA00 Offset: 0xE1B000 VA: 0x180E1CA00
	internal void <.cctor>b__2_611(string str) { }

	// RVA: 0xE1CAB0 Offset: 0xE1B0B0 VA: 0x180E1CAB0
	internal string <.cctor>b__2_612() { }

	// RVA: 0xE1CB10 Offset: 0xE1B110 VA: 0x180E1CB10
	internal void <.cctor>b__2_613(string str) { }

	// RVA: 0xE1CBB0 Offset: 0xE1B1B0 VA: 0x180E1CBB0
	internal string <.cctor>b__2_614() { }

	// RVA: 0xE1CC10 Offset: 0xE1B210 VA: 0x180E1CC10
	internal void <.cctor>b__2_615(string str) { }

	// RVA: 0xE1CCC0 Offset: 0xE1B2C0 VA: 0x180E1CCC0
	internal void <.cctor>b__2_616(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CD20 Offset: 0xE1B320 VA: 0x180E1CD20
	internal void <.cctor>b__2_617(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CD80 Offset: 0xE1B380 VA: 0x180E1CD80
	internal string <.cctor>b__2_618() { }

	// RVA: 0xE1CDE0 Offset: 0xE1B3E0 VA: 0x180E1CDE0
	internal void <.cctor>b__2_619(string str) { }

	// RVA: 0xE1CF40 Offset: 0xE1B540 VA: 0x180E1CF40
	internal string <.cctor>b__2_620() { }

	// RVA: 0xE1CFA0 Offset: 0xE1B5A0 VA: 0x180E1CFA0
	internal void <.cctor>b__2_621(string str) { }

	// RVA: 0xE1D040 Offset: 0xE1B640 VA: 0x180E1D040
	internal void <.cctor>b__2_622(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1D0A0 Offset: 0xE1B6A0 VA: 0x180E1D0A0
	internal string <.cctor>b__2_623() { }

	// RVA: 0xE1D100 Offset: 0xE1B700 VA: 0x180E1D100
	internal void <.cctor>b__2_624(string str) { }

	// RVA: 0xE1D1B0 Offset: 0xE1B7B0 VA: 0x180E1D1B0
	internal string <.cctor>b__2_625() { }

	// RVA: 0xE1D260 Offset: 0xE1B860 VA: 0x180E1D260
	internal void <.cctor>b__2_626(string str) { }

	// RVA: 0xE1D2F0 Offset: 0xE1B8F0 VA: 0x180E1D2F0
	internal string <.cctor>b__2_627() { }

	// RVA: 0xE1D350 Offset: 0xE1B950 VA: 0x180E1D350
	internal void <.cctor>b__2_628(string str) { }

	// RVA: 0xE1D3F0 Offset: 0xE1B9F0 VA: 0x180E1D3F0
	internal string <.cctor>b__2_629() { }

	// RVA: 0xE1D4D0 Offset: 0xE1BAD0 VA: 0x180E1D4D0
	internal void <.cctor>b__2_630(string str) { }

	// RVA: 0xE1D570 Offset: 0xE1BB70 VA: 0x180E1D570
	internal string <.cctor>b__2_631() { }

	// RVA: 0xE1D620 Offset: 0xE1BC20 VA: 0x180E1D620
	internal void <.cctor>b__2_632(string str) { }

	// RVA: 0xE1D6A0 Offset: 0xE1BCA0 VA: 0x180E1D6A0
	internal string <.cctor>b__2_633() { }

	// RVA: 0xE1D740 Offset: 0xE1BD40 VA: 0x180E1D740
	internal void <.cctor>b__2_634(string str) { }

	// RVA: 0xE1D800 Offset: 0xE1BE00 VA: 0x180E1D800
	internal string <.cctor>b__2_635() { }

	// RVA: 0xE1D8B0 Offset: 0xE1BEB0 VA: 0x180E1D8B0
	internal void <.cctor>b__2_636(string str) { }

	// RVA: 0xE1D980 Offset: 0xE1BF80 VA: 0x180E1D980
	internal string <.cctor>b__2_637() { }

	// RVA: 0xE1DA20 Offset: 0xE1C020 VA: 0x180E1DA20
	internal void <.cctor>b__2_638(string str) { }

	// RVA: 0xE1DAE0 Offset: 0xE1C0E0 VA: 0x180E1DAE0
	internal string <.cctor>b__2_639() { }

	// RVA: 0xE1DBF0 Offset: 0xE1C1F0 VA: 0x180E1DBF0
	internal void <.cctor>b__2_640(string str) { }

	// RVA: 0xE1DCB0 Offset: 0xE1C2B0 VA: 0x180E1DCB0
	internal string <.cctor>b__2_641() { }

	// RVA: 0xE1DD10 Offset: 0xE1C310 VA: 0x180E1DD10
	internal void <.cctor>b__2_642(string str) { }

	// RVA: 0xE1DDA0 Offset: 0xE1C3A0 VA: 0x180E1DDA0
	internal string <.cctor>b__2_643() { }

	// RVA: 0xE1DE00 Offset: 0xE1C400 VA: 0x180E1DE00
	internal void <.cctor>b__2_644(string str) { }

	// RVA: 0xE1DE80 Offset: 0xE1C480 VA: 0x180E1DE80
	internal string <.cctor>b__2_645() { }

	// RVA: 0xE1DF30 Offset: 0xE1C530 VA: 0x180E1DF30
	internal void <.cctor>b__2_646(string str) { }

	// RVA: 0xE1DFB0 Offset: 0xE1C5B0 VA: 0x180E1DFB0
	internal string <.cctor>b__2_647() { }

	// RVA: 0xE1E010 Offset: 0xE1C610 VA: 0x180E1E010
	internal void <.cctor>b__2_648(string str) { }

	// RVA: 0xE1E090 Offset: 0xE1C690 VA: 0x180E1E090
	internal string <.cctor>b__2_649() { }

	// RVA: 0xE1E170 Offset: 0xE1C770 VA: 0x180E1E170
	internal void <.cctor>b__2_650(string str) { }

	// RVA: 0xE1E210 Offset: 0xE1C810 VA: 0x180E1E210
	internal string <.cctor>b__2_651() { }

	// RVA: 0xE1E270 Offset: 0xE1C870 VA: 0x180E1E270
	internal void <.cctor>b__2_652(string str) { }

	// RVA: 0xE1E310 Offset: 0xE1C910 VA: 0x180E1E310
	internal string <.cctor>b__2_653() { }

	// RVA: 0xE1E370 Offset: 0xE1C970 VA: 0x180E1E370
	internal void <.cctor>b__2_654(string str) { }

	// RVA: 0xE1E410 Offset: 0xE1CA10 VA: 0x180E1E410
	internal string <.cctor>b__2_655() { }

	// RVA: 0xE1E4C0 Offset: 0xE1CAC0 VA: 0x180E1E4C0
	internal void <.cctor>b__2_656(string str) { }

	// RVA: 0xE1E550 Offset: 0xE1CB50 VA: 0x180E1E550
	internal void <.cctor>b__2_657(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E5B0 Offset: 0xE1CBB0 VA: 0x180E1E5B0
	internal void <.cctor>b__2_658(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E610 Offset: 0xE1CC10 VA: 0x180E1E610
	internal void <.cctor>b__2_659(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E710 Offset: 0xE1CD10 VA: 0x180E1E710
	internal string <.cctor>b__2_660() { }

	// RVA: 0xE1E7C0 Offset: 0xE1CDC0 VA: 0x180E1E7C0
	internal void <.cctor>b__2_661(string str) { }

	// RVA: 0xE1E840 Offset: 0xE1CE40 VA: 0x180E1E840
	internal void <.cctor>b__2_662(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E8A0 Offset: 0xE1CEA0 VA: 0x180E1E8A0
	internal string <.cctor>b__2_663() { }

	// RVA: 0xE1E950 Offset: 0xE1CF50 VA: 0x180E1E950
	internal void <.cctor>b__2_664(string str) { }

	// RVA: 0xE1E9D0 Offset: 0xE1CFD0 VA: 0x180E1E9D0
	internal void <.cctor>b__2_665(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1EA30 Offset: 0xE1D030 VA: 0x180E1EA30
	internal string <.cctor>b__2_666() { }

	// RVA: 0xE1EA90 Offset: 0xE1D090 VA: 0x180E1EA90
	internal void <.cctor>b__2_667(string str) { }

	// RVA: 0xE1EB10 Offset: 0xE1D110 VA: 0x180E1EB10
	internal string <.cctor>b__2_668() { }

	// RVA: 0xE1EB70 Offset: 0xE1D170 VA: 0x180E1EB70
	internal void <.cctor>b__2_669(string str) { }

	// RVA: 0xE1EC70 Offset: 0xE1D270 VA: 0x180E1EC70
	internal string <.cctor>b__2_670() { }

	// RVA: 0xE1ED20 Offset: 0xE1D320 VA: 0x180E1ED20
	internal void <.cctor>b__2_671(string str) { }

	// RVA: 0xE1EDB0 Offset: 0xE1D3B0 VA: 0x180E1EDB0
	internal string <.cctor>b__2_672() { }

	// RVA: 0xE1EE10 Offset: 0xE1D410 VA: 0x180E1EE10
	internal void <.cctor>b__2_673(string str) { }

	// RVA: 0xE1EEB0 Offset: 0xE1D4B0 VA: 0x180E1EEB0
	internal string <.cctor>b__2_674() { }

	// RVA: 0xE1EF10 Offset: 0xE1D510 VA: 0x180E1EF10
	internal void <.cctor>b__2_675(string str) { }

	// RVA: 0xE1EFB0 Offset: 0xE1D5B0 VA: 0x180E1EFB0
	internal string <.cctor>b__2_676() { }

	// RVA: 0xE1F060 Offset: 0xE1D660 VA: 0x180E1F060
	internal void <.cctor>b__2_677(string str) { }

	// RVA: 0xE1F0E0 Offset: 0xE1D6E0 VA: 0x180E1F0E0
	internal string <.cctor>b__2_678() { }

	// RVA: 0xE1F140 Offset: 0xE1D740 VA: 0x180E1F140
	internal void <.cctor>b__2_679(string str) { }

	// RVA: 0xE1F270 Offset: 0xE1D870 VA: 0x180E1F270
	internal string <.cctor>b__2_680() { }

	// RVA: 0xE1F320 Offset: 0xE1D920 VA: 0x180E1F320
	internal void <.cctor>b__2_681(string str) { }

	// RVA: 0xE1F3B0 Offset: 0xE1D9B0 VA: 0x180E1F3B0
	internal string <.cctor>b__2_682() { }

	// RVA: 0xE1F410 Offset: 0xE1DA10 VA: 0x180E1F410
	internal void <.cctor>b__2_683(string str) { }

	// RVA: 0xE1F4B0 Offset: 0xE1DAB0 VA: 0x180E1F4B0
	internal string <.cctor>b__2_684() { }

	// RVA: 0xE1F510 Offset: 0xE1DB10 VA: 0x180E1F510
	internal void <.cctor>b__2_685(string str) { }

	// RVA: 0xE1F5B0 Offset: 0xE1DBB0 VA: 0x180E1F5B0
	internal string <.cctor>b__2_686() { }

	// RVA: 0xE1F610 Offset: 0xE1DC10 VA: 0x180E1F610
	internal void <.cctor>b__2_687(string str) { }

	// RVA: 0xE1F6B0 Offset: 0xE1DCB0 VA: 0x180E1F6B0
	internal string <.cctor>b__2_688() { }

	// RVA: 0xE1F710 Offset: 0xE1DD10 VA: 0x180E1F710
	internal void <.cctor>b__2_689(string str) { }

	// RVA: 0xE1F830 Offset: 0xE1DE30 VA: 0x180E1F830
	internal string <.cctor>b__2_690() { }

	// RVA: 0xE1F890 Offset: 0xE1DE90 VA: 0x180E1F890
	internal void <.cctor>b__2_691(string str) { }

	// RVA: 0xE1F930 Offset: 0xE1DF30 VA: 0x180E1F930
	internal string <.cctor>b__2_692() { }

	// RVA: 0xE1F990 Offset: 0xE1DF90 VA: 0x180E1F990
	internal void <.cctor>b__2_693(string str) { }

	// RVA: 0xE1FA10 Offset: 0xE1E010 VA: 0x180E1FA10
	internal string <.cctor>b__2_694() { }

	// RVA: 0xE1FAC0 Offset: 0xE1E0C0 VA: 0x180E1FAC0
	internal void <.cctor>b__2_695(string str) { }

	// RVA: 0xE1FB40 Offset: 0xE1E140 VA: 0x180E1FB40
	internal string <.cctor>b__2_696() { }

	// RVA: 0xE1FBA0 Offset: 0xE1E1A0 VA: 0x180E1FBA0
	internal void <.cctor>b__2_697(string str) { }

	// RVA: 0xE1FC40 Offset: 0xE1E240 VA: 0x180E1FC40
	internal string <.cctor>b__2_698() { }

	// RVA: 0xE1FCF0 Offset: 0xE1E2F0 VA: 0x180E1FCF0
	internal void <.cctor>b__2_699(string str) { }

	// RVA: 0xE1FEB0 Offset: 0xE1E4B0 VA: 0x180E1FEB0
	internal string <.cctor>b__2_700() { }

	// RVA: 0xE1FF60 Offset: 0xE1E560 VA: 0x180E1FF60
	internal void <.cctor>b__2_701(string str) { }

	// RVA: 0xE1FFE0 Offset: 0xE1E5E0 VA: 0x180E1FFE0
	internal void <.cctor>b__2_702(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20040 Offset: 0xE1E640 VA: 0x180E20040
	internal string <.cctor>b__2_703() { }

	// RVA: 0xE200F0 Offset: 0xE1E6F0 VA: 0x180E200F0
	internal void <.cctor>b__2_704(string str) { }

	// RVA: 0xE20180 Offset: 0xE1E780 VA: 0x180E20180
	internal string <.cctor>b__2_705() { }

	// RVA: 0xE20230 Offset: 0xE1E830 VA: 0x180E20230
	internal void <.cctor>b__2_706(string str) { }

	// RVA: 0xE202C0 Offset: 0xE1E8C0 VA: 0x180E202C0
	internal string <.cctor>b__2_707() { }

	// RVA: 0xE20340 Offset: 0xE1E940 VA: 0x180E20340
	internal void <.cctor>b__2_708(string str) { }

	// RVA: 0xE203B0 Offset: 0xE1E9B0 VA: 0x180E203B0
	internal string <.cctor>b__2_709() { }

	// RVA: 0xE204B0 Offset: 0xE1EAB0 VA: 0x180E204B0
	internal void <.cctor>b__2_710(string str) { }

	// RVA: 0xE20510 Offset: 0xE1EB10 VA: 0x180E20510
	internal void <.cctor>b__2_711(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20570 Offset: 0xE1EB70 VA: 0x180E20570
	internal string <.cctor>b__2_712() { }

	// RVA: 0xE205F0 Offset: 0xE1EBF0 VA: 0x180E205F0
	internal void <.cctor>b__2_713(string str) { }

	// RVA: 0xE20660 Offset: 0xE1EC60 VA: 0x180E20660
	internal string <.cctor>b__2_714() { }

	// RVA: 0xE206E0 Offset: 0xE1ECE0 VA: 0x180E206E0
	internal void <.cctor>b__2_715(string str) { }

	// RVA: 0xE20750 Offset: 0xE1ED50 VA: 0x180E20750
	internal string <.cctor>b__2_716() { }

	// RVA: 0xE207D0 Offset: 0xE1EDD0 VA: 0x180E207D0
	internal void <.cctor>b__2_717(string str) { }

	// RVA: 0xE20840 Offset: 0xE1EE40 VA: 0x180E20840
	internal string <.cctor>b__2_718() { }

	// RVA: 0xE208A0 Offset: 0xE1EEA0 VA: 0x180E208A0
	internal void <.cctor>b__2_719(string str) { }

	// RVA: 0xE209F0 Offset: 0xE1EFF0 VA: 0x180E209F0
	internal string <.cctor>b__2_720() { }

	// RVA: 0xE20A50 Offset: 0xE1F050 VA: 0x180E20A50
	internal void <.cctor>b__2_721(string str) { }

	// RVA: 0xE20AF0 Offset: 0xE1F0F0 VA: 0x180E20AF0
	internal string <.cctor>b__2_722() { }

	// RVA: 0xE20B50 Offset: 0xE1F150 VA: 0x180E20B50
	internal void <.cctor>b__2_723(string str) { }

	// RVA: 0xE20C00 Offset: 0xE1F200 VA: 0x180E20C00
	internal string <.cctor>b__2_724() { }

	// RVA: 0xE20C60 Offset: 0xE1F260 VA: 0x180E20C60
	internal void <.cctor>b__2_725(string str) { }

	// RVA: 0xE20D00 Offset: 0xE1F300 VA: 0x180E20D00
	internal string <.cctor>b__2_726() { }

	// RVA: 0xE20D60 Offset: 0xE1F360 VA: 0x180E20D60
	internal void <.cctor>b__2_727(string str) { }

	// RVA: 0xE20E00 Offset: 0xE1F400 VA: 0x180E20E00
	internal void <.cctor>b__2_728(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20E70 Offset: 0xE1F470 VA: 0x180E20E70
	internal void <.cctor>b__2_729(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20F50 Offset: 0xE1F550 VA: 0x180E20F50
	internal string <.cctor>b__2_730() { }

	// RVA: 0xE20FB0 Offset: 0xE1F5B0 VA: 0x180E20FB0
	internal void <.cctor>b__2_731(string str) { }

	// RVA: 0xE21050 Offset: 0xE1F650 VA: 0x180E21050
	internal string <.cctor>b__2_732() { }

	// RVA: 0xE210B0 Offset: 0xE1F6B0 VA: 0x180E210B0
	internal void <.cctor>b__2_733(string str) { }

	// RVA: 0xE21160 Offset: 0xE1F760 VA: 0x180E21160
	internal string <.cctor>b__2_734() { }

	// RVA: 0xE211C0 Offset: 0xE1F7C0 VA: 0x180E211C0
	internal void <.cctor>b__2_735(string str) { }

	// RVA: 0xE21270 Offset: 0xE1F870 VA: 0x180E21270
	internal string <.cctor>b__2_736() { }

	// RVA: 0xE212D0 Offset: 0xE1F8D0 VA: 0x180E212D0
	internal void <.cctor>b__2_737(string str) { }

	// RVA: 0xE21370 Offset: 0xE1F970 VA: 0x180E21370
	internal string <.cctor>b__2_738() { }

	// RVA: 0xE213D0 Offset: 0xE1F9D0 VA: 0x180E213D0
	internal void <.cctor>b__2_739(string str) { }

	// RVA: 0xE21520 Offset: 0xE1FB20 VA: 0x180E21520
	internal string <.cctor>b__2_740() { }

	// RVA: 0xE21580 Offset: 0xE1FB80 VA: 0x180E21580
	internal void <.cctor>b__2_741(string str) { }

	// RVA: 0xE21620 Offset: 0xE1FC20 VA: 0x180E21620
	internal string <.cctor>b__2_742() { }

	// RVA: 0xE21680 Offset: 0xE1FC80 VA: 0x180E21680
	internal void <.cctor>b__2_743(string str) { }

	// RVA: 0xE21730 Offset: 0xE1FD30 VA: 0x180E21730
	internal void <.cctor>b__2_744(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21790 Offset: 0xE1FD90 VA: 0x180E21790
	internal void <.cctor>b__2_745(ConsoleSystem.Arg arg) { }

	// RVA: 0xE217F0 Offset: 0xE1FDF0 VA: 0x180E217F0
	internal string <.cctor>b__2_746() { }

	// RVA: 0xE218A0 Offset: 0xE1FEA0 VA: 0x180E218A0
	internal void <.cctor>b__2_747(string str) { }

	// RVA: 0xE21920 Offset: 0xE1FF20 VA: 0x180E21920
	internal string <.cctor>b__2_748() { }

	// RVA: 0xE219D0 Offset: 0xE1FFD0 VA: 0x180E219D0
	internal void <.cctor>b__2_749(string str) { }

	// RVA: 0xE21B30 Offset: 0xE20130 VA: 0x180E21B30
	internal void <.cctor>b__2_750(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21B90 Offset: 0xE20190 VA: 0x180E21B90
	internal void <.cctor>b__2_751(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21BF0 Offset: 0xE201F0 VA: 0x180E21BF0
	internal void <.cctor>b__2_752(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21C50 Offset: 0xE20250 VA: 0x180E21C50
	internal void <.cctor>b__2_753(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21CB0 Offset: 0xE202B0 VA: 0x180E21CB0
	internal void <.cctor>b__2_754(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21D10 Offset: 0xE20310 VA: 0x180E21D10
	internal void <.cctor>b__2_755(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21D70 Offset: 0xE20370 VA: 0x180E21D70
	internal void <.cctor>b__2_756(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21DD0 Offset: 0xE203D0 VA: 0x180E21DD0
	internal string <.cctor>b__2_757() { }

	// RVA: 0xE21E30 Offset: 0xE20430 VA: 0x180E21E30
	internal void <.cctor>b__2_758(string str) { }

	// RVA: 0xE21ED0 Offset: 0xE204D0 VA: 0x180E21ED0
	internal void <.cctor>b__2_759(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21FE0 Offset: 0xE205E0 VA: 0x180E21FE0
	internal void <.cctor>b__2_760(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22040 Offset: 0xE20640 VA: 0x180E22040
	internal void <.cctor>b__2_761(ConsoleSystem.Arg arg) { }

	// RVA: 0xE220A0 Offset: 0xE206A0 VA: 0x180E220A0
	internal void <.cctor>b__2_762(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22100 Offset: 0xE20700 VA: 0x180E22100
	internal void <.cctor>b__2_763(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22150 Offset: 0xE20750 VA: 0x180E22150
	internal void <.cctor>b__2_764(ConsoleSystem.Arg arg) { }

	// RVA: 0xE221A0 Offset: 0xE207A0 VA: 0x180E221A0
	internal string <.cctor>b__2_765() { }

	// RVA: 0xE22250 Offset: 0xE20850 VA: 0x180E22250
	internal void <.cctor>b__2_766(string str) { }

	// RVA: 0xE222E0 Offset: 0xE208E0 VA: 0x180E222E0
	internal void <.cctor>b__2_767(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22340 Offset: 0xE20940 VA: 0x180E22340
	internal void <.cctor>b__2_768(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22390 Offset: 0xE20990 VA: 0x180E22390
	internal void <.cctor>b__2_769(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22460 Offset: 0xE20A60 VA: 0x180E22460
	internal void <.cctor>b__2_770(ConsoleSystem.Arg arg) { }

	// RVA: 0xE224B0 Offset: 0xE20AB0 VA: 0x180E224B0
	internal void <.cctor>b__2_771(ConsoleSystem.Arg arg) { }

	// RVA: 0xE224C0 Offset: 0xE20AC0 VA: 0x180E224C0
	internal void <.cctor>b__2_772(ConsoleSystem.Arg arg) { }

	// RVA: 0xE224D0 Offset: 0xE20AD0 VA: 0x180E224D0
	internal void <.cctor>b__2_773(ConsoleSystem.Arg arg) { }

	// RVA: 0xE224E0 Offset: 0xE20AE0 VA: 0x180E224E0
	internal void <.cctor>b__2_774(ConsoleSystem.Arg arg) { }

	// RVA: 0xE224F0 Offset: 0xE20AF0 VA: 0x180E224F0
	internal string <.cctor>b__2_775() { }

	// RVA: 0xE22550 Offset: 0xE20B50 VA: 0x180E22550
	internal void <.cctor>b__2_776(string str) { }

	// RVA: 0xE225F0 Offset: 0xE20BF0 VA: 0x180E225F0
	internal string <.cctor>b__2_777() { }

	// RVA: 0xE22650 Offset: 0xE20C50 VA: 0x180E22650
	internal void <.cctor>b__2_778(string str) { }

	// RVA: 0xE22700 Offset: 0xE20D00 VA: 0x180E22700
	internal string <.cctor>b__2_779() { }

	// RVA: 0xE22810 Offset: 0xE20E10 VA: 0x180E22810
	internal void <.cctor>b__2_780(string str) { }

	// RVA: 0xE228C0 Offset: 0xE20EC0 VA: 0x180E228C0
	internal string <.cctor>b__2_781() { }

	// RVA: 0xE22920 Offset: 0xE20F20 VA: 0x180E22920
	internal void <.cctor>b__2_782(string str) { }

	// RVA: 0xE229D0 Offset: 0xE20FD0 VA: 0x180E229D0
	internal string <.cctor>b__2_783() { }

	// RVA: 0xE22A30 Offset: 0xE21030 VA: 0x180E22A30
	internal void <.cctor>b__2_784(string str) { }

	// RVA: 0xE22AC0 Offset: 0xE210C0 VA: 0x180E22AC0
	internal string <.cctor>b__2_785() { }

	// RVA: 0xE22B60 Offset: 0xE21160 VA: 0x180E22B60
	internal void <.cctor>b__2_786(string str) { }

	// RVA: 0xE22C20 Offset: 0xE21220 VA: 0x180E22C20
	internal string <.cctor>b__2_787() { }

	// RVA: 0xE22C80 Offset: 0xE21280 VA: 0x180E22C80
	internal void <.cctor>b__2_788(string str) { }

	// RVA: 0xE22D20 Offset: 0xE21320 VA: 0x180E22D20
	internal string <.cctor>b__2_789() { }

	// RVA: 0xE22E00 Offset: 0xE21400 VA: 0x180E22E00
	internal void <.cctor>b__2_790(string str) { }

	// RVA: 0xE22E90 Offset: 0xE21490 VA: 0x180E22E90
	internal string <.cctor>b__2_791() { }

	// RVA: 0xE22EF0 Offset: 0xE214F0 VA: 0x180E22EF0
	internal void <.cctor>b__2_792(string str) { }

	// RVA: 0xE22F80 Offset: 0xE21580 VA: 0x180E22F80
	internal string <.cctor>b__2_793() { }

	// RVA: 0xE22FE0 Offset: 0xE215E0 VA: 0x180E22FE0
	internal void <.cctor>b__2_794(string str) { }

	// RVA: 0xE23070 Offset: 0xE21670 VA: 0x180E23070
	internal string <.cctor>b__2_795() { }

	// RVA: 0xE230D0 Offset: 0xE216D0 VA: 0x180E230D0
	internal void <.cctor>b__2_796(string str) { }

	// RVA: 0xE23160 Offset: 0xE21760 VA: 0x180E23160
	internal string <.cctor>b__2_797() { }

	// RVA: 0xE23200 Offset: 0xE21800 VA: 0x180E23200
	internal void <.cctor>b__2_798(string str) { }

	// RVA: 0xE23280 Offset: 0xE21880 VA: 0x180E23280
	internal void <.cctor>b__2_799(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23400 Offset: 0xE21A00 VA: 0x180E23400
	internal void <.cctor>b__2_800(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23430 Offset: 0xE21A30 VA: 0x180E23430
	internal void <.cctor>b__2_801(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23440 Offset: 0xE21A40 VA: 0x180E23440
	internal void <.cctor>b__2_802(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23450 Offset: 0xE21A50 VA: 0x180E23450
	internal void <.cctor>b__2_803(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23460 Offset: 0xE21A60 VA: 0x180E23460
	internal string <.cctor>b__2_804() { }

	// RVA: 0xE23510 Offset: 0xE21B10 VA: 0x180E23510
	internal void <.cctor>b__2_805(string str) { }

	// RVA: 0xE235A0 Offset: 0xE21BA0 VA: 0x180E235A0
	internal string <.cctor>b__2_806() { }

	// RVA: 0xE23600 Offset: 0xE21C00 VA: 0x180E23600
	internal void <.cctor>b__2_807(string str) { }

	// RVA: 0xE236A0 Offset: 0xE21CA0 VA: 0x180E236A0
	internal void <.cctor>b__2_808(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23700 Offset: 0xE21D00 VA: 0x180E23700
	internal string <.cctor>b__2_809() { }

	// RVA: 0xE237E0 Offset: 0xE21DE0 VA: 0x180E237E0
	internal void <.cctor>b__2_810(string str) { }

	// RVA: 0xE23880 Offset: 0xE21E80 VA: 0x180E23880
	internal string <.cctor>b__2_811() { }

	// RVA: 0xE238E0 Offset: 0xE21EE0 VA: 0x180E238E0
	internal void <.cctor>b__2_812(string str) { }

	// RVA: 0xE23980 Offset: 0xE21F80 VA: 0x180E23980
	internal string <.cctor>b__2_813() { }

	// RVA: 0xE239E0 Offset: 0xE21FE0 VA: 0x180E239E0
	internal void <.cctor>b__2_814(string str) { }

	// RVA: 0xE23A80 Offset: 0xE22080 VA: 0x180E23A80
	internal string <.cctor>b__2_815() { }

	// RVA: 0xE23AE0 Offset: 0xE220E0 VA: 0x180E23AE0
	internal void <.cctor>b__2_816(string str) { }

	// RVA: 0xE23B80 Offset: 0xE22180 VA: 0x180E23B80
	internal string <.cctor>b__2_817() { }

	// RVA: 0xE23C00 Offset: 0xE22200 VA: 0x180E23C00
	internal void <.cctor>b__2_818(string str) { }

	// RVA: 0xE23C70 Offset: 0xE22270 VA: 0x180E23C70
	internal string <.cctor>b__2_819() { }

	// RVA: 0xE23DA0 Offset: 0xE223A0 VA: 0x180E23DA0
	internal void <.cctor>b__2_820(string str) { }

	// RVA: 0xE23E10 Offset: 0xE22410 VA: 0x180E23E10
	internal string <.cctor>b__2_821() { }

	// RVA: 0xE23E70 Offset: 0xE22470 VA: 0x180E23E70
	internal void <.cctor>b__2_822(string str) { }

	// RVA: 0xE23F20 Offset: 0xE22520 VA: 0x180E23F20
	internal void <.cctor>b__2_823(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F30 Offset: 0xE22530 VA: 0x180E23F30
	internal void <.cctor>b__2_824(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F40 Offset: 0xE22540 VA: 0x180E23F40
	internal void <.cctor>b__2_825(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F50 Offset: 0xE22550 VA: 0x180E23F50
	internal void <.cctor>b__2_826(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F60 Offset: 0xE22560 VA: 0x180E23F60
	internal void <.cctor>b__2_827(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23F70 Offset: 0xE22570 VA: 0x180E23F70
	internal string <.cctor>b__2_828() { }

	// RVA: 0xE23FD0 Offset: 0xE225D0 VA: 0x180E23FD0
	internal void <.cctor>b__2_829(string str) { }

	// RVA: 0xE240F0 Offset: 0xE226F0 VA: 0x180E240F0
	internal string <.cctor>b__2_830() { }

	// RVA: 0xE241A0 Offset: 0xE227A0 VA: 0x180E241A0
	internal void <.cctor>b__2_831(string str) { }

	// RVA: 0xE24230 Offset: 0xE22830 VA: 0x180E24230
	internal string <.cctor>b__2_832() { }

	// RVA: 0xE24290 Offset: 0xE22890 VA: 0x180E24290
	internal void <.cctor>b__2_833(string str) { }

	// RVA: 0xE24330 Offset: 0xE22930 VA: 0x180E24330
	internal string <.cctor>b__2_834() { }

	// RVA: 0xE24390 Offset: 0xE22990 VA: 0x180E24390
	internal void <.cctor>b__2_835(string str) { }

	// RVA: 0xE24410 Offset: 0xE22A10 VA: 0x180E24410
	internal string <.cctor>b__2_836() { }

	// RVA: 0xE24470 Offset: 0xE22A70 VA: 0x180E24470
	internal void <.cctor>b__2_837(string str) { }

	// RVA: 0xE24510 Offset: 0xE22B10 VA: 0x180E24510
	internal string <.cctor>b__2_838() { }

	// RVA: 0xE24570 Offset: 0xE22B70 VA: 0x180E24570
	internal void <.cctor>b__2_839(string str) { }

	// RVA: 0xE246B0 Offset: 0xE22CB0 VA: 0x180E246B0
	internal string <.cctor>b__2_840() { }

	// RVA: 0xE24710 Offset: 0xE22D10 VA: 0x180E24710
	internal void <.cctor>b__2_841(string str) { }

	// RVA: 0xE247B0 Offset: 0xE22DB0 VA: 0x180E247B0
	internal string <.cctor>b__2_842() { }

	// RVA: 0xE24810 Offset: 0xE22E10 VA: 0x180E24810
	internal void <.cctor>b__2_843(string str) { }

	// RVA: 0xE248A0 Offset: 0xE22EA0 VA: 0x180E248A0
	internal void <.cctor>b__2_844(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24900 Offset: 0xE22F00 VA: 0x180E24900
	internal void <.cctor>b__2_845(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24960 Offset: 0xE22F60 VA: 0x180E24960
	internal void <.cctor>b__2_846(ConsoleSystem.Arg arg) { }

	// RVA: 0xE249C0 Offset: 0xE22FC0 VA: 0x180E249C0
	internal string <.cctor>b__2_847() { }

	// RVA: 0xE24A20 Offset: 0xE23020 VA: 0x180E24A20
	internal void <.cctor>b__2_848(string str) { }

	// RVA: 0xE24AC0 Offset: 0xE230C0 VA: 0x180E24AC0
	internal string <.cctor>b__2_849() { }

	// RVA: 0xE24BA0 Offset: 0xE231A0 VA: 0x180E24BA0
	internal void <.cctor>b__2_850(string str) { }

	// RVA: 0xE24C40 Offset: 0xE23240 VA: 0x180E24C40
	internal string <.cctor>b__2_851() { }

	// RVA: 0xE24CA0 Offset: 0xE232A0 VA: 0x180E24CA0
	internal void <.cctor>b__2_852(string str) { }

	// RVA: 0xE24D40 Offset: 0xE23340 VA: 0x180E24D40
	internal string <.cctor>b__2_853() { }

	// RVA: 0xE24DA0 Offset: 0xE233A0 VA: 0x180E24DA0
	internal void <.cctor>b__2_854(string str) { }

	// RVA: 0xE24E50 Offset: 0xE23450 VA: 0x180E24E50
	internal string <.cctor>b__2_855() { }

	// RVA: 0xE24EB0 Offset: 0xE234B0 VA: 0x180E24EB0
	internal void <.cctor>b__2_856(string str) { }

	// RVA: 0xE24F60 Offset: 0xE23560 VA: 0x180E24F60
	internal void <.cctor>b__2_857(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24FC0 Offset: 0xE235C0 VA: 0x180E24FC0
	internal string <.cctor>b__2_858() { }

	// RVA: 0xE25020 Offset: 0xE23620 VA: 0x180E25020
	internal void <.cctor>b__2_859(string str) { }

	// RVA: 0xE25180 Offset: 0xE23780 VA: 0x180E25180
	internal string <.cctor>b__2_860() { }

	// RVA: 0xE251E0 Offset: 0xE237E0 VA: 0x180E251E0
	internal void <.cctor>b__2_861(string str) { }

	// RVA: 0xE25290 Offset: 0xE23890 VA: 0x180E25290
	internal string <.cctor>b__2_862() { }

	// RVA: 0xE252F0 Offset: 0xE238F0 VA: 0x180E252F0
	internal void <.cctor>b__2_863(string str) { }

	// RVA: 0xE253A0 Offset: 0xE239A0 VA: 0x180E253A0
	internal void <.cctor>b__2_864(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25400 Offset: 0xE23A00 VA: 0x180E25400
	internal string <.cctor>b__2_865() { }

	// RVA: 0xE25460 Offset: 0xE23A60 VA: 0x180E25460
	internal void <.cctor>b__2_866(string str) { }

	// RVA: 0xE25500 Offset: 0xE23B00 VA: 0x180E25500
	internal string <.cctor>b__2_867() { }

	// RVA: 0xE25560 Offset: 0xE23B60 VA: 0x180E25560
	internal void <.cctor>b__2_868(string str) { }

	// RVA: 0xE25600 Offset: 0xE23C00 VA: 0x180E25600
	internal string <.cctor>b__2_869() { }

	// RVA: 0xE256E0 Offset: 0xE23CE0 VA: 0x180E256E0
	internal void <.cctor>b__2_870(string str) { }

	// RVA: 0xE25780 Offset: 0xE23D80 VA: 0x180E25780
	internal string <.cctor>b__2_871() { }

	// RVA: 0xE257E0 Offset: 0xE23DE0 VA: 0x180E257E0
	internal void <.cctor>b__2_872(string str) { }

	// RVA: 0xE25880 Offset: 0xE23E80 VA: 0x180E25880
	internal string <.cctor>b__2_873() { }

	// RVA: 0xE25930 Offset: 0xE23F30 VA: 0x180E25930
	internal void <.cctor>b__2_874(string str) { }

	// RVA: 0xE259B0 Offset: 0xE23FB0 VA: 0x180E259B0
	internal string <.cctor>b__2_875() { }

	// RVA: 0xE25A10 Offset: 0xE24010 VA: 0x180E25A10
	internal void <.cctor>b__2_876(string str) { }

	// RVA: 0xE25AC0 Offset: 0xE240C0 VA: 0x180E25AC0
	internal string <.cctor>b__2_877() { }

	// RVA: 0xE25B20 Offset: 0xE24120 VA: 0x180E25B20
	internal void <.cctor>b__2_878(string str) { }

	// RVA: 0xE25BD0 Offset: 0xE241D0 VA: 0x180E25BD0
	internal string <.cctor>b__2_879() { }

	// RVA: 0xE25CE0 Offset: 0xE242E0 VA: 0x180E25CE0
	internal void <.cctor>b__2_880(string str) { }

	// RVA: 0xE25D90 Offset: 0xE24390 VA: 0x180E25D90
	internal string <.cctor>b__2_881() { }

	// RVA: 0xE25DF0 Offset: 0xE243F0 VA: 0x180E25DF0
	internal void <.cctor>b__2_882(string str) { }

	// RVA: 0xE25EA0 Offset: 0xE244A0 VA: 0x180E25EA0
	internal string <.cctor>b__2_883() { }

	// RVA: 0xE25F00 Offset: 0xE24500 VA: 0x180E25F00
	internal void <.cctor>b__2_884(string str) { }

	// RVA: 0xE25FA0 Offset: 0xE245A0 VA: 0x180E25FA0
	internal void <.cctor>b__2_885(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26000 Offset: 0xE24600 VA: 0x180E26000
	internal void <.cctor>b__2_886(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26060 Offset: 0xE24660 VA: 0x180E26060
	internal void <.cctor>b__2_887(ConsoleSystem.Arg arg) { }

	// RVA: 0xE260C0 Offset: 0xE246C0 VA: 0x180E260C0
	internal string <.cctor>b__2_888() { }

	// RVA: 0xE26120 Offset: 0xE24720 VA: 0x180E26120
	internal void <.cctor>b__2_889(string str) { }

	// RVA: 0xE26240 Offset: 0xE24840 VA: 0x180E26240
	internal string <.cctor>b__2_890() { }

	// RVA: 0xE262A0 Offset: 0xE248A0 VA: 0x180E262A0
	internal void <.cctor>b__2_891(string str) { }

	// RVA: 0xE26340 Offset: 0xE24940 VA: 0x180E26340
	internal void <.cctor>b__2_892(ConsoleSystem.Arg arg) { }

	// RVA: 0xE263A0 Offset: 0xE249A0 VA: 0x180E263A0
	internal string <.cctor>b__2_893() { }

	// RVA: 0xE26400 Offset: 0xE24A00 VA: 0x180E26400
	internal void <.cctor>b__2_894(string str) { }

	// RVA: 0xE264A0 Offset: 0xE24AA0 VA: 0x180E264A0
	internal string <.cctor>b__2_895() { }

	// RVA: 0xE26500 Offset: 0xE24B00 VA: 0x180E26500
	internal void <.cctor>b__2_896(string str) { }

	// RVA: 0xE265A0 Offset: 0xE24BA0 VA: 0x180E265A0
	internal void <.cctor>b__2_897(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26600 Offset: 0xE24C00 VA: 0x180E26600
	internal void <.cctor>b__2_898(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26660 Offset: 0xE24C60 VA: 0x180E26660
	internal void <.cctor>b__2_899(ConsoleSystem.Arg arg) { }

	// RVA: 0xE267F0 Offset: 0xE24DF0 VA: 0x180E267F0
	internal void <.cctor>b__2_900(ConsoleSystem.Arg arg) { }

	// RVA: 0xE267F0 Offset: 0xE24DF0 VA: 0x180E267F0
	internal void <.cctor>b__2_901(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26800 Offset: 0xE24E00 VA: 0x180E26800
	internal string <.cctor>b__2_902() { }

	// RVA: 0xE26860 Offset: 0xE24E60 VA: 0x180E26860
	internal void <.cctor>b__2_903(string str) { }

	// RVA: 0xE26900 Offset: 0xE24F00 VA: 0x180E26900
	internal string <.cctor>b__2_904() { }

	// RVA: 0xE26960 Offset: 0xE24F60 VA: 0x180E26960
	internal void <.cctor>b__2_905(string str) { }

	// RVA: 0xE26A00 Offset: 0xE25000 VA: 0x180E26A00
	internal string <.cctor>b__2_906() { }

	// RVA: 0xE26AA0 Offset: 0xE250A0 VA: 0x180E26AA0
	internal void <.cctor>b__2_907(string str) { }

	// RVA: 0xE26B20 Offset: 0xE25120 VA: 0x180E26B20
	internal string <.cctor>b__2_908() { }

	// RVA: 0xE26B80 Offset: 0xE25180 VA: 0x180E26B80
	internal void <.cctor>b__2_909(string str) { }

	// RVA: 0xE26C80 Offset: 0xE25280 VA: 0x180E26C80
	internal string <.cctor>b__2_910() { }

	// RVA: 0xE26D30 Offset: 0xE25330 VA: 0x180E26D30
	internal void <.cctor>b__2_911(string str) { }

	// RVA: 0xE26DC0 Offset: 0xE253C0 VA: 0x180E26DC0
	internal string <.cctor>b__2_912() { }

	// RVA: 0xE26E20 Offset: 0xE25420 VA: 0x180E26E20
	internal void <.cctor>b__2_913(string str) { }

	// RVA: 0xE26EE0 Offset: 0xE254E0 VA: 0x180E26EE0
	internal string <.cctor>b__2_914() { }

	// RVA: 0xE26F40 Offset: 0xE25540 VA: 0x180E26F40
	internal void <.cctor>b__2_915(string str) { }

	// RVA: 0xE27000 Offset: 0xE25600 VA: 0x180E27000
	internal string <.cctor>b__2_916() { }

	// RVA: 0xE27080 Offset: 0xE25680 VA: 0x180E27080
	internal void <.cctor>b__2_917(string str) { }

	// RVA: 0xE270F0 Offset: 0xE256F0 VA: 0x180E270F0
	internal string <.cctor>b__2_918() { }

	// RVA: 0xE27150 Offset: 0xE25750 VA: 0x180E27150
	internal void <.cctor>b__2_919(string str) { }

	// RVA: 0xE272C0 Offset: 0xE258C0 VA: 0x180E272C0
	internal string <.cctor>b__2_920() { }

	// RVA: 0xE27320 Offset: 0xE25920 VA: 0x180E27320
	internal void <.cctor>b__2_921(string str) { }

	// RVA: 0xE273C0 Offset: 0xE259C0 VA: 0x180E273C0
	internal string <.cctor>b__2_922() { }

	// RVA: 0xE27420 Offset: 0xE25A20 VA: 0x180E27420
	internal void <.cctor>b__2_923(string str) { }

	// RVA: 0xE274C0 Offset: 0xE25AC0 VA: 0x180E274C0
	internal string <.cctor>b__2_924() { }

	// RVA: 0xE27520 Offset: 0xE25B20 VA: 0x180E27520
	internal void <.cctor>b__2_925(string str) { }

	// RVA: 0xE275C0 Offset: 0xE25BC0 VA: 0x180E275C0
	internal string <.cctor>b__2_926() { }

	// RVA: 0xE27620 Offset: 0xE25C20 VA: 0x180E27620
	internal void <.cctor>b__2_927(string str) { }

	// RVA: 0xE276D0 Offset: 0xE25CD0 VA: 0x180E276D0
	internal void <.cctor>b__2_928(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27700 Offset: 0xE25D00 VA: 0x180E27700
	internal void <.cctor>b__2_929(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27790 Offset: 0xE25D90 VA: 0x180E27790
	internal string <.cctor>b__2_930() { }

	// RVA: 0xE277F0 Offset: 0xE25DF0 VA: 0x180E277F0
	internal void <.cctor>b__2_931(string str) { }

	// RVA: 0xE278A0 Offset: 0xE25EA0 VA: 0x180E278A0
	internal void <.cctor>b__2_932(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27900 Offset: 0xE25F00 VA: 0x180E27900
	internal string <.cctor>b__2_933() { }

	// RVA: 0xE27960 Offset: 0xE25F60 VA: 0x180E27960
	internal void <.cctor>b__2_934(string str) { }

	// RVA: 0xE279E0 Offset: 0xE25FE0 VA: 0x180E279E0
	internal string <.cctor>b__2_935() { }

	// RVA: 0xE27A40 Offset: 0xE26040 VA: 0x180E27A40
	internal void <.cctor>b__2_936(string str) { }

	// RVA: 0xE27AE0 Offset: 0xE260E0 VA: 0x180E27AE0
	internal string <.cctor>b__2_937() { }

	// RVA: 0xE27B90 Offset: 0xE26190 VA: 0x180E27B90
	internal void <.cctor>b__2_938(string str) { }

	// RVA: 0xE27C10 Offset: 0xE26210 VA: 0x180E27C10
	internal string <.cctor>b__2_939() { }

	// RVA: 0xE27D70 Offset: 0xE26370 VA: 0x180E27D70
	internal void <.cctor>b__2_940(string str) { }

	// RVA: 0xE27E00 Offset: 0xE26400 VA: 0x180E27E00
	internal string <.cctor>b__2_941() { }

	// RVA: 0xE27E60 Offset: 0xE26460 VA: 0x180E27E60
	internal void <.cctor>b__2_942(string str) { }

	// RVA: 0xE27F00 Offset: 0xE26500 VA: 0x180E27F00
	internal string <.cctor>b__2_943() { }

	// RVA: 0xE27F60 Offset: 0xE26560 VA: 0x180E27F60
	internal void <.cctor>b__2_944(string str) { }

	// RVA: 0xE28000 Offset: 0xE26600 VA: 0x180E28000
	internal string <.cctor>b__2_945() { }

	// RVA: 0xE28060 Offset: 0xE26660 VA: 0x180E28060
	internal void <.cctor>b__2_946(string str) { }

	// RVA: 0xE28100 Offset: 0xE26700 VA: 0x180E28100
	internal string <.cctor>b__2_947() { }

	// RVA: 0xE28160 Offset: 0xE26760 VA: 0x180E28160
	internal void <.cctor>b__2_948(string str) { }

	// RVA: 0xE28200 Offset: 0xE26800 VA: 0x180E28200
	internal string <.cctor>b__2_949() { }

	// RVA: 0xE282E0 Offset: 0xE268E0 VA: 0x180E282E0
	internal void <.cctor>b__2_950(string str) { }

	// RVA: 0xE28380 Offset: 0xE26980 VA: 0x180E28380
	internal string <.cctor>b__2_951() { }

	// RVA: 0xE283E0 Offset: 0xE269E0 VA: 0x180E283E0
	internal void <.cctor>b__2_952(string str) { }

	// RVA: 0xE28480 Offset: 0xE26A80 VA: 0x180E28480
	internal string <.cctor>b__2_953() { }

	// RVA: 0xE284E0 Offset: 0xE26AE0 VA: 0x180E284E0
	internal void <.cctor>b__2_954(string str) { }

	// RVA: 0xE28580 Offset: 0xE26B80 VA: 0x180E28580
	internal string <.cctor>b__2_955() { }

	// RVA: 0xE285E0 Offset: 0xE26BE0 VA: 0x180E285E0
	internal void <.cctor>b__2_956(string str) { }

	// RVA: 0xE28680 Offset: 0xE26C80 VA: 0x180E28680
	internal string <.cctor>b__2_957() { }

	// RVA: 0xE286E0 Offset: 0xE26CE0 VA: 0x180E286E0
	internal void <.cctor>b__2_958(string str) { }

	// RVA: 0xE28770 Offset: 0xE26D70 VA: 0x180E28770
	internal string <.cctor>b__2_959() { }

	// RVA: 0xE28880 Offset: 0xE26E80 VA: 0x180E28880
	internal void <.cctor>b__2_960(string str) { }

	// RVA: 0xE28910 Offset: 0xE26F10 VA: 0x180E28910
	internal string <.cctor>b__2_961() { }

	// RVA: 0xE28970 Offset: 0xE26F70 VA: 0x180E28970
	internal void <.cctor>b__2_962(string str) { }

	// RVA: 0xE28A00 Offset: 0xE27000 VA: 0x180E28A00
	internal string <.cctor>b__2_963() { }

	// RVA: 0xE28A60 Offset: 0xE27060 VA: 0x180E28A60
	internal void <.cctor>b__2_964(string str) { }

	// RVA: 0xE28AF0 Offset: 0xE270F0 VA: 0x180E28AF0
	internal string <.cctor>b__2_965() { }

	// RVA: 0xE28B50 Offset: 0xE27150 VA: 0x180E28B50
	internal void <.cctor>b__2_966(string str) { }

	// RVA: 0xE28BE0 Offset: 0xE271E0 VA: 0x180E28BE0
	internal string <.cctor>b__2_967() { }

	// RVA: 0xE28C40 Offset: 0xE27240 VA: 0x180E28C40
	internal void <.cctor>b__2_968(string str) { }

	// RVA: 0xE28CD0 Offset: 0xE272D0 VA: 0x180E28CD0
	internal string <.cctor>b__2_969() { }

	// RVA: 0xE28DB0 Offset: 0xE273B0 VA: 0x180E28DB0
	internal void <.cctor>b__2_970(string str) { }

	// RVA: 0xE28E40 Offset: 0xE27440 VA: 0x180E28E40
	internal string <.cctor>b__2_971() { }

	// RVA: 0xE28EA0 Offset: 0xE274A0 VA: 0x180E28EA0
	internal void <.cctor>b__2_972(string str) { }

	// RVA: 0xE28F30 Offset: 0xE27530 VA: 0x180E28F30
	internal string <.cctor>b__2_973() { }

	// RVA: 0xE28F90 Offset: 0xE27590 VA: 0x180E28F90
	internal void <.cctor>b__2_974(string str) { }

	// RVA: 0xE29020 Offset: 0xE27620 VA: 0x180E29020
	internal string <.cctor>b__2_975() { }

	// RVA: 0xE29080 Offset: 0xE27680 VA: 0x180E29080
	internal void <.cctor>b__2_976(string str) { }

	// RVA: 0xE29110 Offset: 0xE27710 VA: 0x180E29110
	internal string <.cctor>b__2_977() { }

	// RVA: 0xE29170 Offset: 0xE27770 VA: 0x180E29170
	internal void <.cctor>b__2_978(string str) { }

	// RVA: 0xE29200 Offset: 0xE27800 VA: 0x180E29200
	internal string <.cctor>b__2_979() { }

	// RVA: 0xE29310 Offset: 0xE27910 VA: 0x180E29310
	internal void <.cctor>b__2_980(string str) { }

	// RVA: 0xE293A0 Offset: 0xE279A0 VA: 0x180E293A0
	internal string <.cctor>b__2_981() { }

	// RVA: 0xE29400 Offset: 0xE27A00 VA: 0x180E29400
	internal void <.cctor>b__2_982(string str) { }

	// RVA: 0xE29490 Offset: 0xE27A90 VA: 0x180E29490
	internal string <.cctor>b__2_983() { }

	// RVA: 0xE294F0 Offset: 0xE27AF0 VA: 0x180E294F0
	internal void <.cctor>b__2_984(string str) { }

	// RVA: 0xE29580 Offset: 0xE27B80 VA: 0x180E29580
	internal string <.cctor>b__2_985() { }

	// RVA: 0xE295E0 Offset: 0xE27BE0 VA: 0x180E295E0
	internal void <.cctor>b__2_986(string str) { }

	// RVA: 0xE29670 Offset: 0xE27C70 VA: 0x180E29670
	internal string <.cctor>b__2_987() { }

	// RVA: 0xE296D0 Offset: 0xE27CD0 VA: 0x180E296D0
	internal void <.cctor>b__2_988(string str) { }

	// RVA: 0xE29760 Offset: 0xE27D60 VA: 0x180E29760
	internal string <.cctor>b__2_989() { }

	// RVA: 0xE29840 Offset: 0xE27E40 VA: 0x180E29840
	internal void <.cctor>b__2_990(string str) { }

	// RVA: 0xE298D0 Offset: 0xE27ED0 VA: 0x180E298D0
	internal string <.cctor>b__2_991() { }

	// RVA: 0xE29930 Offset: 0xE27F30 VA: 0x180E29930
	internal void <.cctor>b__2_992(string str) { }

	// RVA: 0xE299C0 Offset: 0xE27FC0 VA: 0x180E299C0
	internal void <.cctor>b__2_993(ConsoleSystem.Arg arg) { }

	// RVA: 0xE29A20 Offset: 0xE28020 VA: 0x180E29A20
	internal string <.cctor>b__2_994() { }

	// RVA: 0xE29A80 Offset: 0xE28080 VA: 0x180E29A80
	internal void <.cctor>b__2_995(string str) { }

	// RVA: 0xE29B10 Offset: 0xE28110 VA: 0x180E29B10
	internal string <.cctor>b__2_996() { }

	// RVA: 0xE29B70 Offset: 0xE28170 VA: 0x180E29B70
	internal void <.cctor>b__2_997(string str) { }

	// RVA: 0xE29C00 Offset: 0xE28200 VA: 0x180E29C00
	internal string <.cctor>b__2_998() { }

	// RVA: 0xE29C60 Offset: 0xE28260 VA: 0x180E29C60
	internal void <.cctor>b__2_999(string str) { }

	// RVA: 0xE07EC0 Offset: 0xE064C0 VA: 0x180E07EC0
	internal string <.cctor>b__2_1000() { }

	// RVA: 0xE07F20 Offset: 0xE06520 VA: 0x180E07F20
	internal void <.cctor>b__2_1001(string str) { }

	// RVA: 0xE07FB0 Offset: 0xE065B0 VA: 0x180E07FB0
	internal void <.cctor>b__2_1002(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08010 Offset: 0xE06610 VA: 0x180E08010
	internal void <.cctor>b__2_1003(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08070 Offset: 0xE06670 VA: 0x180E08070
	internal string <.cctor>b__2_1004() { }

	// RVA: 0xE080D0 Offset: 0xE066D0 VA: 0x180E080D0
	internal void <.cctor>b__2_1005(string str) { }

	// RVA: 0xE08160 Offset: 0xE06760 VA: 0x180E08160
	internal string <.cctor>b__2_1006() { }

	// RVA: 0xE081C0 Offset: 0xE067C0 VA: 0x180E081C0
	internal void <.cctor>b__2_1007(string str) { }

	// RVA: 0xE08250 Offset: 0xE06850 VA: 0x180E08250
	internal string <.cctor>b__2_1008() { }

	// RVA: 0xE082B0 Offset: 0xE068B0 VA: 0x180E082B0
	internal void <.cctor>b__2_1009(string str) { }

	// RVA: 0xE083C0 Offset: 0xE069C0 VA: 0x180E083C0
	internal void <.cctor>b__2_1010(ConsoleSystem.Arg arg) { }

	// RVA: 0xE083D0 Offset: 0xE069D0 VA: 0x180E083D0
	internal string <.cctor>b__2_1011() { }

	// RVA: 0xE08430 Offset: 0xE06A30 VA: 0x180E08430
	internal void <.cctor>b__2_1012(string str) { }

	// RVA: 0xE084D0 Offset: 0xE06AD0 VA: 0x180E084D0
	internal void <.cctor>b__2_1013(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08530 Offset: 0xE06B30 VA: 0x180E08530
	internal void <.cctor>b__2_1014(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08590 Offset: 0xE06B90 VA: 0x180E08590
	internal void <.cctor>b__2_1015(ConsoleSystem.Arg arg) { }

	// RVA: 0xE085F0 Offset: 0xE06BF0 VA: 0x180E085F0
	internal void <.cctor>b__2_1016(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08650 Offset: 0xE06C50 VA: 0x180E08650
	internal string <.cctor>b__2_1017() { }

	// RVA: 0xE086B0 Offset: 0xE06CB0 VA: 0x180E086B0
	internal void <.cctor>b__2_1018(string str) { }

	// RVA: 0xE08750 Offset: 0xE06D50 VA: 0x180E08750
	internal void <.cctor>b__2_1019(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08810 Offset: 0xE06E10 VA: 0x180E08810
	internal string <.cctor>b__2_1020() { }

	// RVA: 0xE08870 Offset: 0xE06E70 VA: 0x180E08870
	internal void <.cctor>b__2_1021(string str) { }

	// RVA: 0xE08910 Offset: 0xE06F10 VA: 0x180E08910
	internal string <.cctor>b__2_1022() { }

	// RVA: 0xE08970 Offset: 0xE06F70 VA: 0x180E08970
	internal void <.cctor>b__2_1023(string str) { }

	// RVA: 0xE08A20 Offset: 0xE07020 VA: 0x180E08A20
	internal string <.cctor>b__2_1024() { }

	// RVA: 0xE08A80 Offset: 0xE07080 VA: 0x180E08A80
	internal void <.cctor>b__2_1025(string str) { }

	// RVA: 0xE08B30 Offset: 0xE07130 VA: 0x180E08B30
	internal string <.cctor>b__2_1026() { }

	// RVA: 0xE08B90 Offset: 0xE07190 VA: 0x180E08B90
	internal void <.cctor>b__2_1027(string str) { }

	// RVA: 0xE08C30 Offset: 0xE07230 VA: 0x180E08C30
	internal string <.cctor>b__2_1028() { }

	// RVA: 0xE08C50 Offset: 0xE07250 VA: 0x180E08C50
	internal void <.cctor>b__2_1029(string str) { }

	// RVA: 0xE08D30 Offset: 0xE07330 VA: 0x180E08D30
	internal string <.cctor>b__2_1030() { }

	// RVA: 0xE08D50 Offset: 0xE07350 VA: 0x180E08D50
	internal void <.cctor>b__2_1031(string str) { }

	// RVA: 0xE08DB0 Offset: 0xE073B0 VA: 0x180E08DB0
	internal string <.cctor>b__2_1032() { }

	// RVA: 0xE08DD0 Offset: 0xE073D0 VA: 0x180E08DD0
	internal void <.cctor>b__2_1033(string str) { }

	// RVA: 0xE08E30 Offset: 0xE07430 VA: 0x180E08E30
	internal string <.cctor>b__2_1034() { }

	// RVA: 0xE08E50 Offset: 0xE07450 VA: 0x180E08E50
	internal void <.cctor>b__2_1035(string str) { }

	// RVA: 0xE08EB0 Offset: 0xE074B0 VA: 0x180E08EB0
	internal string <.cctor>b__2_1036() { }

	// RVA: 0xE08ED0 Offset: 0xE074D0 VA: 0x180E08ED0
	internal void <.cctor>b__2_1037(string str) { }

	// RVA: 0xE08F30 Offset: 0xE07530 VA: 0x180E08F30
	internal string <.cctor>b__2_1038() { }

	// RVA: 0xE08F50 Offset: 0xE07550 VA: 0x180E08F50
	internal void <.cctor>b__2_1039(string str) { }

	// RVA: 0xE09060 Offset: 0xE07660 VA: 0x180E09060
	internal string <.cctor>b__2_1040() { }

	// RVA: 0xE09080 Offset: 0xE07680 VA: 0x180E09080
	internal void <.cctor>b__2_1041(string str) { }

	// RVA: 0xE090E0 Offset: 0xE076E0 VA: 0x180E090E0
	internal string <.cctor>b__2_1042() { }

	// RVA: 0xE09100 Offset: 0xE07700 VA: 0x180E09100
	internal void <.cctor>b__2_1043(string str) { }

	// RVA: 0xE09160 Offset: 0xE07760 VA: 0x180E09160
	internal void <.cctor>b__2_1044(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09170 Offset: 0xE07770 VA: 0x180E09170
	internal void <.cctor>b__2_1045(ConsoleSystem.Arg arg) { }

	// RVA: 0xE091A0 Offset: 0xE077A0 VA: 0x180E091A0
	internal string <.cctor>b__2_1046() { }

	// RVA: 0xE09200 Offset: 0xE07800 VA: 0x180E09200
	internal void <.cctor>b__2_1047(string str) { }

	// RVA: 0xE092A0 Offset: 0xE078A0 VA: 0x180E092A0
	internal string <.cctor>b__2_1048() { }

	// RVA: 0xE09300 Offset: 0xE07900 VA: 0x180E09300
	internal void <.cctor>b__2_1049(string str) { }

	// RVA: 0xE09420 Offset: 0xE07A20 VA: 0x180E09420
	internal string <.cctor>b__2_1050() { }

	// RVA: 0xE09480 Offset: 0xE07A80 VA: 0x180E09480
	internal void <.cctor>b__2_1051(string str) { }

	// RVA: 0xE09530 Offset: 0xE07B30 VA: 0x180E09530
	internal string <.cctor>b__2_1052() { }

	// RVA: 0xE09590 Offset: 0xE07B90 VA: 0x180E09590
	internal void <.cctor>b__2_1053(string str) { }

	// RVA: 0xE09630 Offset: 0xE07C30 VA: 0x180E09630
	internal string <.cctor>b__2_1054() { }

	// RVA: 0xE09690 Offset: 0xE07C90 VA: 0x180E09690
	internal void <.cctor>b__2_1055(string str) { }

	// RVA: 0xE09740 Offset: 0xE07D40 VA: 0x180E09740
	internal void <.cctor>b__2_1056(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09790 Offset: 0xE07D90 VA: 0x180E09790
	internal void <.cctor>b__2_1057(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09850 Offset: 0xE07E50 VA: 0x180E09850
	internal void <.cctor>b__2_1058(ConsoleSystem.Arg arg) { }

	// RVA: 0xE098D0 Offset: 0xE07ED0 VA: 0x180E098D0
	internal string <.cctor>b__2_1059() { }

	// RVA: 0xE099E0 Offset: 0xE07FE0 VA: 0x180E099E0
	internal void <.cctor>b__2_1060(string str) { }

	// RVA: 0xE09A80 Offset: 0xE08080 VA: 0x180E09A80
	internal void <.cctor>b__2_1061(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09B20 Offset: 0xE08120 VA: 0x180E09B20
	internal void <.cctor>b__2_1062(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09BE0 Offset: 0xE081E0 VA: 0x180E09BE0
	internal string <.cctor>b__2_1063() { }

	// RVA: 0xE09C40 Offset: 0xE08240 VA: 0x180E09C40
	internal void <.cctor>b__2_1064(string str) { }

	// RVA: 0xE09CE0 Offset: 0xE082E0 VA: 0x180E09CE0
	internal string <.cctor>b__2_1065() { }

	// RVA: 0xE09D40 Offset: 0xE08340 VA: 0x180E09D40
	internal void <.cctor>b__2_1066(string str) { }

	// RVA: 0xE09DF0 Offset: 0xE083F0 VA: 0x180E09DF0
	internal void <.cctor>b__2_1067(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09E50 Offset: 0xE08450 VA: 0x180E09E50
	internal string <.cctor>b__2_1068() { }

	// RVA: 0xE09EB0 Offset: 0xE084B0 VA: 0x180E09EB0
	internal void <.cctor>b__2_1069(string str) { }

	// RVA: 0xE09FD0 Offset: 0xE085D0 VA: 0x180E09FD0
	internal string <.cctor>b__2_1070() { }

	// RVA: 0xE0A080 Offset: 0xE08680 VA: 0x180E0A080
	internal void <.cctor>b__2_1071(string str) { }

	// RVA: 0xE0A160 Offset: 0xE08760 VA: 0x180E0A160
	internal string <.cctor>b__2_1072() { }

	// RVA: 0xE0A1C0 Offset: 0xE087C0 VA: 0x180E0A1C0
	internal void <.cctor>b__2_1073(string str) { }

	// RVA: 0xE0A270 Offset: 0xE08870 VA: 0x180E0A270
	internal string <.cctor>b__2_1074() { }

	// RVA: 0xE0A2D0 Offset: 0xE088D0 VA: 0x180E0A2D0
	internal void <.cctor>b__2_1075(string str) { }

	// RVA: 0xE0A380 Offset: 0xE08980 VA: 0x180E0A380
	internal void <.cctor>b__2_1076(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A390 Offset: 0xE08990 VA: 0x180E0A390
	internal void <.cctor>b__2_1077(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A3A0 Offset: 0xE089A0 VA: 0x180E0A3A0
	internal void <.cctor>b__2_1078(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A3B0 Offset: 0xE089B0 VA: 0x180E0A3B0
	internal void <.cctor>b__2_1079(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A470 Offset: 0xE08A70 VA: 0x180E0A470
	internal void <.cctor>b__2_1080(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A4D0 Offset: 0xE08AD0 VA: 0x180E0A4D0
	internal void <.cctor>b__2_1081(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A530 Offset: 0xE08B30 VA: 0x180E0A530
	internal void <.cctor>b__2_1082(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A590 Offset: 0xE08B90 VA: 0x180E0A590
	internal void <.cctor>b__2_1083(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A5F0 Offset: 0xE08BF0 VA: 0x180E0A5F0
	internal void <.cctor>b__2_1084(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A650 Offset: 0xE08C50 VA: 0x180E0A650
	internal string <.cctor>b__2_1085() { }

	// RVA: 0xE0A6B0 Offset: 0xE08CB0 VA: 0x180E0A6B0
	internal void <.cctor>b__2_1086(string str) { }

	// RVA: 0xE0A750 Offset: 0xE08D50 VA: 0x180E0A750
	internal string <.cctor>b__2_1087() { }

	// RVA: 0xE0A800 Offset: 0xE08E00 VA: 0x180E0A800
	internal void <.cctor>b__2_1088(string str) { }

	// RVA: 0xE0A880 Offset: 0xE08E80 VA: 0x180E0A880
	internal void <.cctor>b__2_1089(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A960 Offset: 0xE08F60 VA: 0x180E0A960
	internal void <.cctor>b__2_1090(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A9C0 Offset: 0xE08FC0 VA: 0x180E0A9C0
	internal string <.cctor>b__2_1091() { }

	// RVA: 0xE0AA20 Offset: 0xE09020 VA: 0x180E0AA20
	internal void <.cctor>b__2_1092(string str) { }

	// RVA: 0xE0AAC0 Offset: 0xE090C0 VA: 0x180E0AAC0
	internal string <.cctor>b__2_1093() { }

	// RVA: 0xE0AB20 Offset: 0xE09120 VA: 0x180E0AB20
	internal void <.cctor>b__2_1094(string str) { }

	// RVA: 0xE0ABD0 Offset: 0xE091D0 VA: 0x180E0ABD0
	internal string <.cctor>b__2_1095() { }

	// RVA: 0xE0AC30 Offset: 0xE09230 VA: 0x180E0AC30
	internal void <.cctor>b__2_1096(string str) { }

	// RVA: 0xE0ACE0 Offset: 0xE092E0 VA: 0x180E0ACE0
	internal string <.cctor>b__2_1097() { }

	// RVA: 0xE0AD40 Offset: 0xE09340 VA: 0x180E0AD40
	internal void <.cctor>b__2_1098(string str) { }

	// RVA: 0xE0ADE0 Offset: 0xE093E0 VA: 0x180E0ADE0
	internal string <.cctor>b__2_1099() { }

	// RVA: 0xE0AF70 Offset: 0xE09570 VA: 0x180E0AF70
	internal void <.cctor>b__2_1100(string str) { }

	// RVA: 0xE0B020 Offset: 0xE09620 VA: 0x180E0B020
	internal string <.cctor>b__2_1101() { }

	// RVA: 0xE0B080 Offset: 0xE09680 VA: 0x180E0B080
	internal void <.cctor>b__2_1102(string str) { }

	// RVA: 0xE0B110 Offset: 0xE09710 VA: 0x180E0B110
	internal string <.cctor>b__2_1103() { }

	// RVA: 0xE0B170 Offset: 0xE09770 VA: 0x180E0B170
	internal void <.cctor>b__2_1104(string str) { }

	// RVA: 0xE0B200 Offset: 0xE09800 VA: 0x180E0B200
	internal void <.cctor>b__2_1105(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B260 Offset: 0xE09860 VA: 0x180E0B260
	internal void <.cctor>b__2_1106(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B2C0 Offset: 0xE098C0 VA: 0x180E0B2C0
	internal string <.cctor>b__2_1107() { }

	// RVA: 0xE0B320 Offset: 0xE09920 VA: 0x180E0B320
	internal void <.cctor>b__2_1108(string str) { }

	// RVA: 0xE0B3C0 Offset: 0xE099C0 VA: 0x180E0B3C0
	internal string <.cctor>b__2_1109() { }

	// RVA: 0xE0B480 Offset: 0xE09A80 VA: 0x180E0B480
	internal void <.cctor>b__2_1110(string str) { }

	// RVA: 0xE0B520 Offset: 0xE09B20 VA: 0x180E0B520
	internal string <.cctor>b__2_1111() { }

	// RVA: 0xE0B5A0 Offset: 0xE09BA0 VA: 0x180E0B5A0
	internal void <.cctor>b__2_1112(string str) { }

	// RVA: 0xE0B600 Offset: 0xE09C00 VA: 0x180E0B600
	internal void <.cctor>b__2_1113(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B650 Offset: 0xE09C50 VA: 0x180E0B650
	internal void <.cctor>b__2_1114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B6B0 Offset: 0xE09CB0 VA: 0x180E0B6B0
	internal void <.cctor>b__2_1115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B710 Offset: 0xE09D10 VA: 0x180E0B710
	internal string <.cctor>b__2_1116() { }

	// RVA: 0xE0B7C0 Offset: 0xE09DC0 VA: 0x180E0B7C0
	internal void <.cctor>b__2_1117(string str) { }

	// RVA: 0xE0B840 Offset: 0xE09E40 VA: 0x180E0B840
	internal string <.cctor>b__2_1118() { }

	// RVA: 0xE0B8A0 Offset: 0xE09EA0 VA: 0x180E0B8A0
	internal void <.cctor>b__2_1119(string str) { }

	// RVA: 0xE0B9F0 Offset: 0xE09FF0 VA: 0x180E0B9F0
	internal string <.cctor>b__2_1120() { }

	// RVA: 0xE0BA50 Offset: 0xE0A050 VA: 0x180E0BA50
	internal void <.cctor>b__2_1121(string str) { }

	// RVA: 0xE0BAF0 Offset: 0xE0A0F0 VA: 0x180E0BAF0
	internal string <.cctor>b__2_1122() { }

	// RVA: 0xE0BB50 Offset: 0xE0A150 VA: 0x180E0BB50
	internal void <.cctor>b__2_1123(string str) { }

	// RVA: 0xE0BBF0 Offset: 0xE0A1F0 VA: 0x180E0BBF0
	internal string <.cctor>b__2_1124() { }

	// RVA: 0xE0BC50 Offset: 0xE0A250 VA: 0x180E0BC50
	internal void <.cctor>b__2_1125(string str) { }

	// RVA: 0xE0BD00 Offset: 0xE0A300 VA: 0x180E0BD00
	internal string <.cctor>b__2_1126() { }

	// RVA: 0xE0BD60 Offset: 0xE0A360 VA: 0x180E0BD60
	internal void <.cctor>b__2_1127(string str) { }

	// RVA: 0xE0BE00 Offset: 0xE0A400 VA: 0x180E0BE00
	internal string <.cctor>b__2_1128() { }

	// RVA: 0xE0BE60 Offset: 0xE0A460 VA: 0x180E0BE60
	internal void <.cctor>b__2_1129(string str) { }

	// RVA: 0xE0BF60 Offset: 0xE0A560 VA: 0x180E0BF60
	internal string <.cctor>b__2_1130() { }

	// RVA: 0xE0BFC0 Offset: 0xE0A5C0 VA: 0x180E0BFC0
	internal void <.cctor>b__2_1131(string str) { }

	// RVA: 0xE0C060 Offset: 0xE0A660 VA: 0x180E0C060
	internal string <.cctor>b__2_1132() { }

	// RVA: 0xE0C0C0 Offset: 0xE0A6C0 VA: 0x180E0C0C0
	internal void <.cctor>b__2_1133(string str) { }

	// RVA: 0xE0C160 Offset: 0xE0A760 VA: 0x180E0C160
	internal void <.cctor>b__2_1134(ConsoleSystem.Arg arg) { }

}

public static class ConsoleNetwork // TypeDefIndex: 9370
{	// Methods

	// RVA: 0x6AE180 Offset: 0x6AC780 VA: 0x1806AE180
	internal static void Init() { }

	// RVA: 0x6ADF40 Offset: 0x6AC540 VA: 0x1806ADF40
	public static bool ClientRunOnServer(string strCommand) { }

	// RVA: 0x6AE310 Offset: 0x6AC910 VA: 0x1806AE310
	internal static void OnConsoleMessageFromServer(Message packet) { }

	// RVA: 0x6AE210 Offset: 0x6AC810 VA: 0x1806AE210
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

	// RVA: 0x6AE3F0 Offset: 0x6AC9F0 VA: 0x1806AE3F0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6AEC40 Offset: 0x6AD240 VA: 0x1806AEC40
	protected void OnEnable() { }

	// RVA: 0x6AEB40 Offset: 0x6AD140 VA: 0x1806AEB40
	protected void OnDisable() { }

	// RVA: 0x6B00F0 Offset: 0x6AE6F0 VA: 0x1806B00F0
	protected void Update() { }

	// RVA: 0x6AFC10 Offset: 0x6AE210 VA: 0x1806AFC10
	public void SetTextSize(float newSize) { }

	// RVA: 0x6AE6D0 Offset: 0x6ACCD0 VA: 0x1806AE6D0
	public void CloseAutocomplete() { }

	// RVA: 0x6AEF00 Offset: 0x6AD500 VA: 0x1806AEF00
	public void OnTextTypes(string str) { }

	// RVA: 0x6AE390 Offset: 0x6AC990 VA: 0x1806AE390
	private void AutocompleteButtonClicked(Button button) { }

	// RVA: 0x6AEE20 Offset: 0x6AD420 VA: 0x1806AEE20
	private void OnOpenDevTools() { }

	// RVA: 0x6AF5F0 Offset: 0x6ADBF0 VA: 0x1806AF5F0
	private void OutputHandler_OnMessage(string message, string stack, LogType type = 0) { }

	// RVA: 0x6AEAB0 Offset: 0x6AD0B0 VA: 0x1806AEAB0
	private void Log(string message) { }

	// RVA: 0x6AFAC0 Offset: 0x6AE0C0 VA: 0x1806AFAC0
	private void Refresh() { }

	// RVA: 0x6AE970 Offset: 0x6ACF70 VA: 0x1806AE970
	private void LoadHistory(int delta) { }

	// RVA: 0x6AFCF0 Offset: 0x6AE2F0 VA: 0x1806AFCF0
	public void SubmitCommand(string command) { }

	// RVA: 0x6AFB10 Offset: 0x6AE110 VA: 0x1806AFB10
	private void SelectInputField(bool updateAutoComplete = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x7F590 Offset: 0x7E990 VA: 0x18007F590
	// RVA: 0x6AFB90 Offset: 0x6AE190 VA: 0x1806AFB90
	private IEnumerator SetSelected(bool updateAutoComplete = False) { }

	// RVA: 0x6AE670 Offset: 0x6ACC70 VA: 0x1806AE670
	public void ClearContents() { }

	// RVA: 0x6AE7E0 Offset: 0x6ACDE0 VA: 0x1806AE7E0
	public void Copy() { }

	// RVA: 0x6AF530 Offset: 0x6ADB30 VA: 0x1806AF530
	public void OpenLogFolder() { }

	// RVA: 0x6AF470 Offset: 0x6ADA70 VA: 0x1806AF470
	public void OpenLogFile() { }

	// RVA: 0x6B0580 Offset: 0x6AEB80 VA: 0x1806B0580
	public void .ctor() { }

}

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 10837
{	// Fields
	public Button btn; // 0x10
	public ConsoleUI <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8FF0 Offset: 0x6C75F0 VA: 0x1806C8FF0
	internal void <Awake>b__0() { }

}

private sealed class ConsoleUI.<>c__DisplayClass22_0 // TypeDefIndex: 10838
{	// Fields
	public string str; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C9050 Offset: 0x6C7650 VA: 0x1806C9050
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

	// RVA: 0x6C8D10 Offset: 0x6C7310 VA: 0x1806C8D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6C8EF0 Offset: 0x6C74F0 VA: 0x1806C8EF0 Slot: 8
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
	// RVA: 0x8E8AF0 Offset: 0x8E70F0 VA: 0x1808E8AF0
	public void add_OnInputText(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8E8C30 Offset: 0x8E7230 VA: 0x1808E8C30
	public void remove_OnInputText(Action<string> value) { }

	// RVA: 0x8E8BE0 Offset: 0x8E71E0 VA: 0x1808E8BE0
	public bool get_valid() { }

	// RVA: 0x8E8B90 Offset: 0x8E7190 VA: 0x1808E8B90
	public int get_lineWidth() { }

	// RVA: 0x8E80A0 Offset: 0x8E66A0 VA: 0x1808E80A0
	public void ClearLine(int numLines) { }

	// RVA: 0x8E8300 Offset: 0x8E6900 VA: 0x1808E8300
	public void RedrawInputLine() { }

	// RVA: 0x8E8170 Offset: 0x8E6770 VA: 0x1808E8170
	internal void OnBackspace() { }

	// RVA: 0x8E82B0 Offset: 0x8E68B0 VA: 0x1808E82B0
	internal void OnEscape() { }

	// RVA: 0x8E81D0 Offset: 0x8E67D0 VA: 0x1808E81D0
	internal void OnEnter() { }

	// RVA: 0x8E8680 Offset: 0x8E6C80 VA: 0x1808E8680
	public void Update() { }

	// RVA: 0x8E8940 Offset: 0x8E6F40 VA: 0x1808E8940
	public void .ctor() { }

}

public class ConsoleWindow // TypeDefIndex: 11682
{	// Fields
	private TextWriter oldOutput; // 0x10
	private const int STD_INPUT_HANDLE = -10;
	private const int STD_OUTPUT_HANDLE = -11;

	// Methods

	// RVA: 0x8E8EF0 Offset: 0x8E74F0 VA: 0x1808E8EF0
	public void Initialize() { }

	// RVA: 0x8E9360 Offset: 0x8E7960 VA: 0x1808E9360
	public void Shutdown() { }

	// RVA: 0x8E92D0 Offset: 0x8E78D0 VA: 0x1808E92D0
	public void SetTitle(string strName) { }

	// RVA: 0x8E8D50 Offset: 0x8E7350 VA: 0x1808E8D50
	private static extern bool AttachConsole(uint dwProcessId) { }

	// RVA: 0x8E8CD0 Offset: 0x8E72D0 VA: 0x1808E8CD0
	private static extern bool AllocConsole() { }

	// RVA: 0x8E8DE0 Offset: 0x8E73E0 VA: 0x1808E8DE0
	private static extern bool FreeConsole() { }

	// RVA: 0x8E8E60 Offset: 0x8E7460 VA: 0x1808E8E60
	private static extern IntPtr GetStdHandle(int nStdHandle) { }

	// RVA: 0x8E9230 Offset: 0x8E7830 VA: 0x1808E9230
	private static extern bool SetConsoleTitleA(string lpConsoleTitle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Console : ConsoleSystem // TypeDefIndex: 11894
{	// Fields
	[ClientVar] // RVA: 0x90AA0 Offset: 0x8FEA0 VA: 0x180090AA0
	[HelpAttribute] // RVA: 0x90AA0 Offset: 0x8FEA0 VA: 0x180090AA0
	public static bool erroroverlay; // 0x2B111C0

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D48E0 Offset: 0x6D2EE0 VA: 0x1806D48E0
	public static void clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D4950 Offset: 0x6D2F50 VA: 0x1806D4950
	public static void copy(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D4880 Offset: 0x6D2E80 VA: 0x1806D4880
	public void .ctor() { }

	// RVA: 0x6D4840 Offset: 0x6D2E40 VA: 0x1806D4840
	private static void .cctor() { }

}


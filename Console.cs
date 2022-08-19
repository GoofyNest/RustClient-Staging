public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 186
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
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

	// RVA: 0x1452E40 Offset: 0x1451440 VA: 0x181452E40
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	public bool get_Cancel() { }

	// RVA: 0x1452E10 Offset: 0x1451410 VA: 0x181452E10
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

	// RVA: 0x1EF760 Offset: 0x1EEB60 VA: 0x1801EF760
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x121100 Offset: 0x120500 VA: 0x180121100
	public char get_KeyChar() { }

	// RVA: 0x14B860 Offset: 0x14AC60 VA: 0x18014B860
	public ConsoleKey get_Key() { }

	// RVA: 0x1EF660 Offset: 0x1EEA60 VA: 0x1801EF660 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1EF710 Offset: 0x1EEB10 VA: 0x1801EF710
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x1EF750 Offset: 0x1EEB50 VA: 0x1801EF750 Slot: 2
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

	// RVA: 0x1454620 Offset: 0x1452C20 VA: 0x181454620
	private static void .cctor() { }

	// RVA: 0x14540C0 Offset: 0x14526C0 VA: 0x1814540C0
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x1454A60 Offset: 0x1453060 VA: 0x181454A60
	public static TextWriter get_Error() { }

	// RVA: 0x1454CA0 Offset: 0x14532A0 VA: 0x181454CA0
	public static TextWriter get_Out() { }

	// RVA: 0x1453C80 Offset: 0x1452280 VA: 0x181453C80
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x1453AD0 Offset: 0x14520D0 VA: 0x181453AD0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x1453B60 Offset: 0x1452160 VA: 0x181453B60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x1453BF0 Offset: 0x14521F0 VA: 0x181453BF0
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x1454020 Offset: 0x1452620 VA: 0x181454020
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x14545A0 Offset: 0x1452BA0 VA: 0x1814545A0
	public static void Write(string value) { }

	// RVA: 0x14544A0 Offset: 0x1452AA0 VA: 0x1814544A0
	public static void WriteLine(object value) { }

	// RVA: 0x1454520 Offset: 0x1452B20 VA: 0x181454520
	public static void WriteLine(string value) { }

	// RVA: 0x1454B80 Offset: 0x1453180 VA: 0x181454B80
	public static Encoding get_InputEncoding() { }

	// RVA: 0x1454D00 Offset: 0x1453300 VA: 0x181454D00
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x14550E0 Offset: 0x14536E0 VA: 0x1814550E0
	public static void set_OutputEncoding(Encoding value) { }

	// RVA: 0x1454820 Offset: 0x1452E20 VA: 0x181454820
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x1454D60 Offset: 0x1453360 VA: 0x181454D60
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x14548E0 Offset: 0x1452EE0 VA: 0x1814548E0
	public static int get_BufferWidth() { }

	// RVA: 0x1454E60 Offset: 0x1453460 VA: 0x181454E60
	public static void set_CursorLeft(int value) { }

	// RVA: 0x14549A0 Offset: 0x1452FA0 VA: 0x1814549A0
	public static int get_CursorTop() { }

	// RVA: 0x1454F20 Offset: 0x1453520 VA: 0x181454F20
	public static void set_CursorTop(int value) { }

	// RVA: 0x1454AC0 Offset: 0x14530C0 VA: 0x181454AC0
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x1454FE0 Offset: 0x14535E0 VA: 0x181454FE0
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1454BE0 Offset: 0x14531E0 VA: 0x181454BE0
	public static bool get_KeyAvailable() { }

	// RVA: 0x1453EA0 Offset: 0x14524A0 VA: 0x181453EA0
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x1453D50 Offset: 0x1452350 VA: 0x181453D50
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1453900 Offset: 0x1451F00 VA: 0x181453900
	internal static void DoConsoleCancelEvent() { }

}

private class Console.WindowsConsole // TypeDefIndex: 351
{	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x146E190 Offset: 0x146C790 VA: 0x18146E190
	private static extern int GetConsoleCP() { }

	// RVA: 0x146E200 Offset: 0x146C800 VA: 0x18146E200
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x146E130 Offset: 0x146C730 VA: 0x18146E130
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x146E270 Offset: 0x146C870 VA: 0x18146E270
	public static int GetInputCodePage() { }

	// RVA: 0x146E310 Offset: 0x146C910 VA: 0x18146E310
	public static int GetOutputCodePage() { }

	// RVA: 0x146E3B0 Offset: 0x146C9B0 VA: 0x18146E3B0
	private static void .cctor() { }

}

private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x146DE40 Offset: 0x146C440 VA: 0x18146DE40 Slot: 12
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x146DDC0 Offset: 0x146C3C0 VA: 0x18146DDC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 353
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1464520 Offset: 0x1462B20 VA: 0x181464520 Slot: 12
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

	// RVA: 0x14530F0 Offset: 0x14516F0 VA: 0x1814530F0
	private static void .cctor() { }

	// RVA: 0x1452EB0 Offset: 0x14514B0 VA: 0x181452EB0
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x1452F60 Offset: 0x1451560 VA: 0x181452F60
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x1452F00 Offset: 0x1451500 VA: 0x181452F00
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x14531B0 Offset: 0x14517B0 VA: 0x1814531B0
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x14535B0 Offset: 0x1451BB0 VA: 0x1814535B0
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x1453220 Offset: 0x1451820 VA: 0x181453220
	public static int get_BufferWidth() { }

	// RVA: 0x1453670 Offset: 0x1451C70 VA: 0x181453670
	public static void set_CursorLeft(int value) { }

	// RVA: 0x14532A0 Offset: 0x14518A0 VA: 0x1814532A0
	public static int get_CursorTop() { }

	// RVA: 0x14536F0 Offset: 0x1451CF0 VA: 0x1814536F0
	public static void set_CursorTop(int value) { }

	// RVA: 0x1453530 Offset: 0x1451B30 VA: 0x181453530
	public static bool get_KeyAvailable() { }

	// RVA: 0x1453320 Offset: 0x1451920 VA: 0x181453320
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x1453770 Offset: 0x1451D70 VA: 0x181453770
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x1452FC0 Offset: 0x14515C0 VA: 0x181452FC0
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x14533A0 Offset: 0x14519A0 VA: 0x1814533A0
	public static bool get_IsConsole() { }

	// RVA: 0x1452FB0 Offset: 0x14515B0 VA: 0x181452FB0
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x10DDD80 Offset: 0x10DC380 VA: 0x1810DDD80
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x14530E0 Offset: 0x14516E0 VA: 0x1814530E0
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x14530D0 Offset: 0x14516D0 VA: 0x1814530D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Action<string, string> OnReplicatedVarChanged; // 0x18
	public static string LastError; // 0x20
	public static ConsoleSystem.Arg CurrentArgs; // 0x28

	// Methods

	// RVA: 0x22B46A0 Offset: 0x22B2CA0 VA: 0x1822B46A0
	public static void UpdateValuesFromCommandLine() { }

	// RVA: 0x22B45F0 Offset: 0x22B2BF0 VA: 0x1822B45F0
	internal static bool SendToServer(string command) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B4900 Offset: 0x22B2F00 VA: 0x1822B4900
	public static void add_OnReplicatedVarChanged(Action<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B4A00 Offset: 0x22B3000 VA: 0x1822B4A00
	public static void remove_OnReplicatedVarChanged(Action<string, string> value) { }

	// RVA: 0x22B3C60 Offset: 0x22B2260 VA: 0x1822B3C60
	public static void RunFile(ConsoleSystem.Option options, string strFile) { }

	// RVA: 0x22B3DF0 Offset: 0x22B23F0 VA: 0x1822B3DF0
	public static string Run(ConsoleSystem.Option options, string strCommand, object[] args) { }

	// RVA: 0x22B3660 Offset: 0x22B1C60 VA: 0x1822B3660
	private static bool Internal(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B31F0 Offset: 0x22B17F0 VA: 0x1822B31F0
	public static string BuildCommand(string strCommand, object[] args) { }

	// RVA: 0x22B41F0 Offset: 0x22B27F0 VA: 0x1822B41F0
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

	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public bool get_IsClientside() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsServerside() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Connection get_Connection() { }

	// RVA: 0x22B2030 Offset: 0x22B0630 VA: 0x1822B2030
	public bool get_IsConnectionAdmin() { }

	// RVA: 0x22B2000 Offset: 0x22B0600 VA: 0x1822B2000
	public bool get_IsAdmin() { }

	// RVA: 0x13A53D0 Offset: 0x13A39D0 VA: 0x1813A53D0
	public bool get_IsRcon() { }

	// RVA: 0x22B1F60 Offset: 0x22B0560 VA: 0x1822B1F60
	internal void .ctor(ConsoleSystem.Option options, string rconCommand) { }

	// RVA: 0x22B0F70 Offset: 0x22AF570 VA: 0x1822B0F70
	internal void BuildCommand(string command) { }

	// RVA: 0x22B1C40 Offset: 0x22B0240 VA: 0x1822B1C40
	internal bool HasPermission() { }

	// RVA: 0x22B1390 Offset: 0x22AF990 VA: 0x1822B1390
	internal bool CanSeeInFind(ConsoleSystem.Command command) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	public void ReplyWith(string strValue) { }

	// RVA: 0x22B1E80 Offset: 0x22B0480 VA: 0x1822B1E80
	public void ReplyWith(object obj) { }

	// RVA: 0x22B1C20 Offset: 0x22B0220 VA: 0x1822B1C20
	public bool HasArgs(int iMinimum = 1) { }

	// RVA: 0x22B1BC0 Offset: 0x22B01C0 VA: 0x1822B1BC0
	public bool HasArg(string value) { }

	// RVA: 0x22B1690 Offset: 0x22AFC90 VA: 0x1822B1690
	public string GetString(int iArg, string def = "") { }

	// RVA: 0x22B1620 Offset: 0x22AFC20 VA: 0x1822B1620
	public int GetInt(int iArg, int def = 0) { }

	// RVA: 0x22B1A50 Offset: 0x22B0050 VA: 0x1822B1A50
	public ulong GetULong(int iArg, ulong def = 0) { }

	// RVA: 0x22B1F00 Offset: 0x22B0500 VA: 0x1822B1F00
	public bool TryGetUInt(int iArg, out uint value) { }

	// RVA: 0x22B1AD0 Offset: 0x22B00D0 VA: 0x1822B1AD0
	public uint GetUInt(int iArg, uint def = 0) { }

	// RVA: 0x22B1A50 Offset: 0x22B0050 VA: 0x1822B1A50
	public ulong GetUInt64(int iArg, ulong def = 0) { }

	// RVA: 0x22B15A0 Offset: 0x22AFBA0 VA: 0x1822B15A0
	public float GetFloat(int iArg, float def = 0) { }

	// RVA: 0x22B13C0 Offset: 0x22AF9C0 VA: 0x1822B13C0
	public bool GetBool(int iArg, bool def = False) { }

	// RVA: 0x22B1870 Offset: 0x22AFE70 VA: 0x1822B1870
	public long GetTimestamp(int iArg, long def = 0) { }

	// RVA: 0x22B16E0 Offset: 0x22AFCE0 VA: 0x1822B16E0
	public long GetTicks(int iArg, long def = 0) { }

	// RVA: 0x22B1DC0 Offset: 0x22B03C0 VA: 0x1822B1DC0
	public void ReplyWithObject(object rval) { }

	// RVA: 0x22B1B40 Offset: 0x22B0140 VA: 0x1822B1B40
	public Vector3 GetVector3(int iArg, Vector3 def) { }

	// RVA: 0x22B1530 Offset: 0x22AFB30 VA: 0x1822B1530
	public Color GetColor(int iArg, Color def) { }

}

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6880
{	// Fields
	public string Name; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action<ConsoleSystem.Command> OnValueChanged; // 0x70

	// Properties
	public bool Server { get; }
	public string String { get; }
	public int AsInt { get; }
	public float AsFloat { get; }
	public bool AsBool { get; }
	public Vector3 AsVector3 { get; }

	// Methods

	// RVA: 0x22B2C20 Offset: 0x22B1220 VA: 0x1822B2C20
	public bool get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B2950 Offset: 0x22B0F50 VA: 0x1822B2950
	public void add_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B2C80 Offset: 0x22B1280 VA: 0x1822B2C80
	public void remove_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	// RVA: 0x22B28A0 Offset: 0x22B0EA0 VA: 0x1822B28A0
	public void .ctor() { }

	// RVA: 0x22B26C0 Offset: 0x22B0CC0 VA: 0x1822B26C0
	private void ValueChanged() { }

	// RVA: 0x22B2390 Offset: 0x22B0990 VA: 0x1822B2390
	private void DefaultCall(ConsoleSystem.Arg arg) { }

	// RVA: 0x22B2C30 Offset: 0x22B1230 VA: 0x1822B2C30
	public string get_String() { }

	// RVA: 0x22B2B10 Offset: 0x22B1110 VA: 0x1822B2B10
	public int get_AsInt() { }

	// RVA: 0x22B2A80 Offset: 0x22B1080 VA: 0x1822B2A80
	public float get_AsFloat() { }

	// RVA: 0x22B29F0 Offset: 0x22B0FF0 VA: 0x1822B29F0
	public bool get_AsBool() { }

	// RVA: 0x22B2BA0 Offset: 0x22B11A0 VA: 0x1822B2BA0
	public Vector3 get_AsVector3() { }

	// RVA: 0x22B2520 Offset: 0x22B0B20 VA: 0x1822B2520
	public void Set(string value) { }

	// RVA: 0x22B2610 Offset: 0x22B0C10 VA: 0x1822B2610
	public void Set(float f) { }

	// RVA: 0x22B2440 Offset: 0x22B0A40 VA: 0x1822B2440
	public void Set(bool val) { }

}

public static class ConsoleSystem.Index // TypeDefIndex: 6884
{	// Fields
	private static readonly Memoized<string, string> WithGlobal; // 0x0
	private static readonly Memoized<string, string> WithoutGlobal; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static ConsoleSystem.Command[] <All>k__BackingField; // 0x10

	// Properties
	public static ConsoleSystem.Command[] All { get; set; }

	// Methods

	// RVA: 0x22B4B00 Offset: 0x22B3100 VA: 0x1822B4B00
	public static void Initialize(ConsoleSystem.Command[] Commands) { }

	// RVA: 0x22B5290 Offset: 0x22B3890 VA: 0x1822B5290
	public static void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B5580 Offset: 0x22B3B80 VA: 0x1822B5580
	public static ConsoleSystem.Command[] get_All() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22B55E0 Offset: 0x22B3BE0 VA: 0x1822B55E0
	private static void set_All(ConsoleSystem.Command[] value) { }

	// RVA: 0x22B5440 Offset: 0x22B3A40 VA: 0x1822B5440
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6885
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8
	public static List<ConsoleSystem.Command> Replicated; // 0x10

	// Methods

	// RVA: 0x22B5760 Offset: 0x22B3D60 VA: 0x1822B5760
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B58A0 Offset: 0x22B3EA0 VA: 0x1822B58A0
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6886
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8

	// Methods

	// RVA: 0x22B2070 Offset: 0x22B0670 VA: 0x1822B2070
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B2220 Offset: 0x22B0820 VA: 0x1822B2220
	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6887
{	// Fields
	public static readonly ConsoleSystem.Index.<>c <>9; // 0x0
	public static Action<ConsoleSystem.Command> <>9__4_1; // 0x8
	public static Action<string, bool> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x22B5EF0 Offset: 0x22B44F0 VA: 0x1822B5EF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B5C50 Offset: 0x22B4250 VA: 0x1822B5C50
	internal void <Initialize>b__4_1(ConsoleSystem.Command command) { }

	// RVA: 0x22B5A50 Offset: 0x22B4050 VA: 0x1822B5A50
	internal void <Initialize>b__4_0(string strCommand, bool pressed) { }

	// RVA: 0x22B5D80 Offset: 0x22B4380 VA: 0x1822B5D80
	internal string <.cctor>b__10_0(string s) { }

	// RVA: 0x22B5DC0 Offset: 0x22B43C0 VA: 0x1822B5DC0
	internal string <.cctor>b__10_1(string s) { }

}

public struct ConsoleSystem.Option // TypeDefIndex: 6888
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsServer>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsClient>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <ForwardtoServerOnMissing>k__BackingField; // 0x2
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <PrintOutput>k__BackingField; // 0x3
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsUnrestricted>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <FromRcon>k__BackingField; // 0x5
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsFromServer>k__BackingField; // 0x6
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x22B56B0 Offset: 0x22B3CB0 VA: 0x1822B56B0
	public static ConsoleSystem.Option get_Unrestricted() { }

	// RVA: 0x22B5670 Offset: 0x22B3C70 VA: 0x1822B5670
	public static ConsoleSystem.Option get_Client() { }

	// RVA: 0x22B5690 Offset: 0x22B3C90 VA: 0x1822B5690
	public static ConsoleSystem.Option get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14CC90 Offset: 0x14C090 VA: 0x18014CC90
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x204BD0 Offset: 0x203FD0 VA: 0x180204BD0
	public void set_IsServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1FA220 Offset: 0x1F9620 VA: 0x1801FA220
	public bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236DE0 Offset: 0x2361E0 VA: 0x180236DE0
	public void set_IsClient(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x121140 Offset: 0x120540 VA: 0x180121140
	public bool get_ForwardtoServerOnMissing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236DD0 Offset: 0x2361D0 VA: 0x180236DD0
	public void set_ForwardtoServerOnMissing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1210F0 Offset: 0x1204F0 VA: 0x1801210F0
	public bool get_PrintOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23AF80 Offset: 0x23A380 VA: 0x18023AF80
	public void set_PrintOutput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x121110 Offset: 0x120510 VA: 0x180121110
	public bool get_IsUnrestricted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123230 Offset: 0x122630 VA: 0x180123230
	public void set_IsUnrestricted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x121120 Offset: 0x120520 VA: 0x180121120
	public bool get_FromRcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23AF60 Offset: 0x23A360 VA: 0x18023AF60
	public void set_FromRcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23AF50 Offset: 0x23A350 VA: 0x18023AF50
	public bool get_IsFromServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23AF70 Offset: 0x23A370 VA: 0x18023AF70
	public void set_IsFromServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_Connection(Connection value) { }

	// RVA: 0x23AF40 Offset: 0x23A340 VA: 0x18023AF40
	public ConsoleSystem.Option Quiet() { }

	// RVA: 0x23AF30 Offset: 0x23A330 VA: 0x18023AF30
	public ConsoleSystem.Option FromServer() { }

	// RVA: 0x23AEF0 Offset: 0x23A2F0 VA: 0x18023AEF0
	public ConsoleSystem.Option FromConnection(Connection connection) { }

}

private sealed class ConsoleSystem.<>c // TypeDefIndex: 6889
{	// Fields
	public static readonly ConsoleSystem.<>c <>9; // 0x0
	public static Func<ConsoleSystem.Command, bool> <>9__21_0; // 0x8
	public static Func<ConsoleSystem.Command, bool> <>9__21_1; // 0x10

	// Methods

	// RVA: 0x22B5E90 Offset: 0x22B4490 VA: 0x1822B5E90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22B5D20 Offset: 0x22B4320 VA: 0x1822B5D20
	internal bool <SaveToConfigString>b__21_0(ConsoleSystem.Command x) { }

	// RVA: 0x22B5D50 Offset: 0x22B4350 VA: 0x1822B5D50
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

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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
	public static readonly ConsoleGen.<>c <>9; // 0x2B11194

	// Methods

	// RVA: 0xE29B90 Offset: 0xE28190 VA: 0x180E29B90
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE07BA0 Offset: 0xE061A0 VA: 0x180E07BA0
	internal string <.cctor>b__2_0() { }

	// RVA: 0xE0ED90 Offset: 0xE0D390 VA: 0x180E0ED90
	internal void <.cctor>b__2_1(string str) { }

	// RVA: 0xE12500 Offset: 0xE10B00 VA: 0x180E12500
	internal string <.cctor>b__2_2() { }

	// RVA: 0xE159F0 Offset: 0xE13FF0 VA: 0x180E159F0
	internal void <.cctor>b__2_3(string str) { }

	// RVA: 0xE189F0 Offset: 0xE16FF0 VA: 0x180E189F0
	internal string <.cctor>b__2_4() { }

	// RVA: 0xE1C0F0 Offset: 0xE1A6F0 VA: 0x180E1C0F0
	internal void <.cctor>b__2_5(string str) { }

	// RVA: 0xE1FB70 Offset: 0xE1E170 VA: 0x180E1FB70
	internal string <.cctor>b__2_6() { }

	// RVA: 0xE230D0 Offset: 0xE216D0 VA: 0x180E230D0
	internal void <.cctor>b__2_7(string str) { }

	// RVA: 0xE264B0 Offset: 0xE24AB0 VA: 0x180E264B0
	internal string <.cctor>b__2_8() { }

	// RVA: 0xE29AE0 Offset: 0xE280E0 VA: 0x180E29AE0
	internal void <.cctor>b__2_9(string str) { }

	// RVA: 0xE0AC30 Offset: 0xE09230 VA: 0x180E0AC30
	internal string <.cctor>b__2_10() { }

	// RVA: 0xE0C160 Offset: 0xE0A760 VA: 0x180E0C160
	internal void <.cctor>b__2_11(string str) { }

	// RVA: 0xE0C700 Offset: 0xE0AD00 VA: 0x180E0C700
	internal string <.cctor>b__2_12() { }

	// RVA: 0xE0CC00 Offset: 0xE0B200 VA: 0x180E0CC00
	internal void <.cctor>b__2_13(string str) { }

	// RVA: 0xE0D190 Offset: 0xE0B790 VA: 0x180E0D190
	internal string <.cctor>b__2_14() { }

	// RVA: 0xE0D6D0 Offset: 0xE0BCD0 VA: 0x180E0D6D0
	internal void <.cctor>b__2_15(string str) { }

	// RVA: 0xE0DC40 Offset: 0xE0C240 VA: 0x180E0DC40
	internal string <.cctor>b__2_16() { }

	// RVA: 0xE0E1E0 Offset: 0xE0C7E0 VA: 0x180E0E1E0
	internal void <.cctor>b__2_17(string str) { }

	// RVA: 0xE0E7E0 Offset: 0xE0CDE0 VA: 0x180E0E7E0
	internal string <.cctor>b__2_18() { }

	// RVA: 0xE0ECE0 Offset: 0xE0D2E0 VA: 0x180E0ECE0
	internal void <.cctor>b__2_19(string str) { }

	// RVA: 0xE0F330 Offset: 0xE0D930 VA: 0x180E0F330
	internal string <.cctor>b__2_20() { }

	// RVA: 0xE0F800 Offset: 0xE0DE00 VA: 0x180E0F800
	internal void <.cctor>b__2_21(string str) { }

	// RVA: 0xE0FCE0 Offset: 0xE0E2E0 VA: 0x180E0FCE0
	internal string <.cctor>b__2_22() { }

	// RVA: 0xE10280 Offset: 0xE0E880 VA: 0x180E10280
	internal void <.cctor>b__2_23(string str) { }

	// RVA: 0xE107F0 Offset: 0xE0EDF0 VA: 0x180E107F0
	internal string <.cctor>b__2_24() { }

	// RVA: 0xE10DC0 Offset: 0xE0F3C0 VA: 0x180E10DC0
	internal void <.cctor>b__2_25(string str) { }

	// RVA: 0xE11360 Offset: 0xE0F960 VA: 0x180E11360
	internal string <.cctor>b__2_26() { }

	// RVA: 0xE118F0 Offset: 0xE0FEF0 VA: 0x180E118F0
	internal void <.cctor>b__2_27(string str) { }

	// RVA: 0xE11F40 Offset: 0xE10540 VA: 0x180E11F40
	internal string <.cctor>b__2_28() { }

	// RVA: 0xE12450 Offset: 0xE10A50 VA: 0x180E12450
	internal void <.cctor>b__2_29(string str) { }

	// RVA: 0xE12990 Offset: 0xE10F90 VA: 0x180E12990
	internal string <.cctor>b__2_30() { }

	// RVA: 0xE12EB0 Offset: 0xE114B0 VA: 0x180E12EB0
	internal void <.cctor>b__2_31(string str) { }

	// RVA: 0xE134D0 Offset: 0xE11AD0 VA: 0x180E134D0
	internal string <.cctor>b__2_32() { }

	// RVA: 0xE13940 Offset: 0xE11F40 VA: 0x180E13940
	internal void <.cctor>b__2_33(string str) { }

	// RVA: 0xE13D30 Offset: 0xE12330 VA: 0x180E13D30
	internal string <.cctor>b__2_34() { }

	// RVA: 0xE142A0 Offset: 0xE128A0 VA: 0x180E142A0
	internal void <.cctor>b__2_35(string str) { }

	// RVA: 0xE14880 Offset: 0xE12E80 VA: 0x180E14880
	internal string <.cctor>b__2_36() { }

	// RVA: 0xE14DE0 Offset: 0xE133E0 VA: 0x180E14DE0
	internal void <.cctor>b__2_37(string str) { }

	// RVA: 0xE15380 Offset: 0xE13980 VA: 0x180E15380
	internal string <.cctor>b__2_38() { }

	// RVA: 0xE15940 Offset: 0xE13F40 VA: 0x180E15940
	internal void <.cctor>b__2_39(string str) { }

	// RVA: 0xE15EE0 Offset: 0xE144E0 VA: 0x180E15EE0
	internal string <.cctor>b__2_40() { }

	// RVA: 0xE16400 Offset: 0xE14A00 VA: 0x180E16400
	internal void <.cctor>b__2_41(string str) { }

	// RVA: 0xE169F0 Offset: 0xE14FF0 VA: 0x180E169F0
	internal string <.cctor>b__2_42() { }

	// RVA: 0xE16EF0 Offset: 0xE154F0 VA: 0x180E16EF0
	internal void <.cctor>b__2_43(string str) { }

	// RVA: 0xE174B0 Offset: 0xE15AB0 VA: 0x180E174B0
	internal string <.cctor>b__2_44() { }

	// RVA: 0xE17A30 Offset: 0xE16030 VA: 0x180E17A30
	internal void <.cctor>b__2_45(string str) { }

	// RVA: 0xE17FE0 Offset: 0xE165E0 VA: 0x180E17FE0
	internal string <.cctor>b__2_46() { }

	// RVA: 0xE184D0 Offset: 0xE16AD0 VA: 0x180E184D0
	internal void <.cctor>b__2_47(string str) { }

	// RVA: 0xE18670 Offset: 0xE16C70 VA: 0x180E18670
	internal string <.cctor>b__2_48() { }

	// RVA: 0xE18940 Offset: 0xE16F40 VA: 0x180E18940
	internal void <.cctor>b__2_49(string str) { }

	// RVA: 0xE18EF0 Offset: 0xE174F0 VA: 0x180E18EF0
	internal string <.cctor>b__2_50() { }

	// RVA: 0xE19400 Offset: 0xE17A00 VA: 0x180E19400
	internal void <.cctor>b__2_51(string str) { }

	// RVA: 0xE199A0 Offset: 0xE17FA0 VA: 0x180E199A0
	internal string <.cctor>b__2_52() { }

	// RVA: 0xE19F40 Offset: 0xE18540 VA: 0x180E19F40
	internal void <.cctor>b__2_53(string str) { }

	// RVA: 0xE1A480 Offset: 0xE18A80 VA: 0x180E1A480
	internal string <.cctor>b__2_54() { }

	// RVA: 0xE1A9B0 Offset: 0xE18FB0 VA: 0x180E1A9B0
	internal void <.cctor>b__2_55(string str) { }

	// RVA: 0xE1AFF0 Offset: 0xE195F0 VA: 0x180E1AFF0
	internal string <.cctor>b__2_56() { }

	// RVA: 0xE1B4F0 Offset: 0xE19AF0 VA: 0x180E1B4F0
	internal void <.cctor>b__2_57(string str) { }

	// RVA: 0xE1BA90 Offset: 0xE1A090 VA: 0x180E1BA90
	internal string <.cctor>b__2_58() { }

	// RVA: 0xE1C040 Offset: 0xE1A640 VA: 0x180E1C040
	internal void <.cctor>b__2_59(string str) { }

	// RVA: 0xE1C660 Offset: 0xE1AC60 VA: 0x180E1C660
	internal string <.cctor>b__2_60() { }

	// RVA: 0xE1CBD0 Offset: 0xE1B1D0 VA: 0x180E1CBD0
	internal void <.cctor>b__2_61(string str) { }

	// RVA: 0xE1D190 Offset: 0xE1B790 VA: 0x180E1D190
	internal string <.cctor>b__2_62() { }

	// RVA: 0xE1D880 Offset: 0xE1BE80 VA: 0x180E1D880
	internal void <.cctor>b__2_63(string str) { }

	// RVA: 0xE1DE30 Offset: 0xE1C430 VA: 0x180E1DE30
	internal string <.cctor>b__2_64() { }

	// RVA: 0xE1E3A0 Offset: 0xE1C9A0 VA: 0x180E1E3A0
	internal void <.cctor>b__2_65(string str) { }

	// RVA: 0xE1E930 Offset: 0xE1CF30 VA: 0x180E1E930
	internal string <.cctor>b__2_66() { }

	// RVA: 0xE1EF00 Offset: 0xE1D500 VA: 0x180E1EF00
	internal void <.cctor>b__2_67(string str) { }

	// RVA: 0xE1F4F0 Offset: 0xE1DAF0 VA: 0x180E1F4F0
	internal string <.cctor>b__2_68() { }

	// RVA: 0xE1FAC0 Offset: 0xE1E0C0 VA: 0x180E1FAC0
	internal void <.cctor>b__2_69(string str) { }

	// RVA: 0xE20170 Offset: 0xE1E770 VA: 0x180E20170
	internal string <.cctor>b__2_70() { }

	// RVA: 0xE20680 Offset: 0xE1EC80 VA: 0x180E20680
	internal void <.cctor>b__2_71(string str) { }

	// RVA: 0xE20C10 Offset: 0xE1F210 VA: 0x180E20C10
	internal string <.cctor>b__2_72() { }

	// RVA: 0xE211B0 Offset: 0xE1F7B0 VA: 0x180E211B0
	internal void <.cctor>b__2_73(string str) { }

	// RVA: 0xE217F0 Offset: 0xE1FDF0 VA: 0x180E217F0
	internal string <.cctor>b__2_74() { }

	// RVA: 0xE21C70 Offset: 0xE20270 VA: 0x180E21C70
	internal void <.cctor>b__2_75(string str) { }

	// RVA: 0xE22120 Offset: 0xE20720 VA: 0x180E22120
	internal string <.cctor>b__2_76() { }

	// RVA: 0xE224A0 Offset: 0xE20AA0 VA: 0x180E224A0
	internal void <.cctor>b__2_77(string str) { }

	// RVA: 0xE22AC0 Offset: 0xE210C0 VA: 0x180E22AC0
	internal string <.cctor>b__2_78() { }

	// RVA: 0xE23020 Offset: 0xE21620 VA: 0x180E23020
	internal void <.cctor>b__2_79(string str) { }

	// RVA: 0xE234A0 Offset: 0xE21AA0 VA: 0x180E234A0
	internal string <.cctor>b__2_80() { }

	// RVA: 0xE23A30 Offset: 0xE22030 VA: 0x180E23A30
	internal void <.cctor>b__2_81(string str) { }

	// RVA: 0xE23DB0 Offset: 0xE223B0 VA: 0x180E23DB0
	internal string <.cctor>b__2_82() { }

	// RVA: 0xE24340 Offset: 0xE22940 VA: 0x180E24340
	internal void <.cctor>b__2_83(string str) { }

	// RVA: 0xE24860 Offset: 0xE22E60 VA: 0x180E24860
	internal string <.cctor>b__2_84() { }

	// RVA: 0xE24E10 Offset: 0xE23410 VA: 0x180E24E10
	internal void <.cctor>b__2_85(string str) { }

	// RVA: 0xE253A0 Offset: 0xE239A0 VA: 0x180E253A0
	internal string <.cctor>b__2_86() { }

	// RVA: 0xE25970 Offset: 0xE23F70 VA: 0x180E25970
	internal void <.cctor>b__2_87(string str) { }

	// RVA: 0xE25F00 Offset: 0xE24500 VA: 0x180E25F00
	internal string <.cctor>b__2_88() { }

	// RVA: 0xE26400 Offset: 0xE24A00 VA: 0x180E26400
	internal void <.cctor>b__2_89(string str) { }

	// RVA: 0xE26940 Offset: 0xE24F40 VA: 0x180E26940
	internal string <.cctor>b__2_90() { }

	// RVA: 0xE26F50 Offset: 0xE25550 VA: 0x180E26F50
	internal void <.cctor>b__2_91(string str) { }

	// RVA: 0xE27450 Offset: 0xE25A50 VA: 0x180E27450
	internal string <.cctor>b__2_92() { }

	// RVA: 0xE27A00 Offset: 0xE26000 VA: 0x180E27A00
	internal void <.cctor>b__2_93(string str) { }

	// RVA: 0xE27FA0 Offset: 0xE265A0 VA: 0x180E27FA0
	internal string <.cctor>b__2_94() { }

	// RVA: 0xE28510 Offset: 0xE26B10 VA: 0x180E28510
	internal void <.cctor>b__2_95(string str) { }

	// RVA: 0xE28A70 Offset: 0xE27070 VA: 0x180E28A70
	internal string <.cctor>b__2_96() { }

	// RVA: 0xE28FA0 Offset: 0xE275A0 VA: 0x180E28FA0
	internal void <.cctor>b__2_97(string str) { }

	// RVA: 0xE29500 Offset: 0xE27B00 VA: 0x180E29500
	internal string <.cctor>b__2_98() { }

	// RVA: 0xE29A30 Offset: 0xE28030 VA: 0x180E29A30
	internal void <.cctor>b__2_99(string str) { }

	// RVA: 0xE08080 Offset: 0xE06680 VA: 0x180E08080
	internal string <.cctor>b__2_100() { }

	// RVA: 0xE084A0 Offset: 0xE06AA0 VA: 0x180E084A0
	internal void <.cctor>b__2_101(string str) { }

	// RVA: 0xE089F0 Offset: 0xE06FF0 VA: 0x180E089F0
	internal string <.cctor>b__2_102() { }

	// RVA: 0xE08CF0 Offset: 0xE072F0 VA: 0x180E08CF0
	internal void <.cctor>b__2_103(string str) { }

	// RVA: 0xE090E0 Offset: 0xE076E0 VA: 0x180E090E0
	internal string <.cctor>b__2_104() { }

	// RVA: 0xE09670 Offset: 0xE07C70 VA: 0x180E09670
	internal void <.cctor>b__2_105(string str) { }

	// RVA: 0xE09C90 Offset: 0xE08290 VA: 0x180E09C90
	internal string <.cctor>b__2_106() { }

	// RVA: 0xE0A100 Offset: 0xE08700 VA: 0x180E0A100
	internal void <.cctor>b__2_107(string str) { }

	// RVA: 0xE0A620 Offset: 0xE08C20 VA: 0x180E0A620
	internal string <.cctor>b__2_108() { }

	// RVA: 0xE0AB80 Offset: 0xE09180 VA: 0x180E0AB80
	internal void <.cctor>b__2_109(string str) { }

	// RVA: 0xE0B160 Offset: 0xE09760 VA: 0x180E0B160
	internal string <.cctor>b__2_110() { }

	// RVA: 0xE0B680 Offset: 0xE09C80 VA: 0x180E0B680
	internal void <.cctor>b__2_111(string str) { }

	// RVA: 0xE0BC40 Offset: 0xE0A240 VA: 0x180E0BC40
	internal string <.cctor>b__2_112() { }

	// RVA: 0xE0BEB0 Offset: 0xE0A4B0 VA: 0x180E0BEB0
	internal void <.cctor>b__2_113(string str) { }

	// RVA: 0xE0BF60 Offset: 0xE0A560 VA: 0x180E0BF60
	internal void <.cctor>b__2_114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BFC0 Offset: 0xE0A5C0 VA: 0x180E0BFC0
	internal void <.cctor>b__2_115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C010 Offset: 0xE0A610 VA: 0x180E0C010
	internal void <.cctor>b__2_116(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C040 Offset: 0xE0A640 VA: 0x180E0C040
	internal void <.cctor>b__2_117(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C050 Offset: 0xE0A650 VA: 0x180E0C050
	internal string <.cctor>b__2_118() { }

	// RVA: 0xE0C0B0 Offset: 0xE0A6B0 VA: 0x180E0C0B0
	internal void <.cctor>b__2_119(string str) { }

	// RVA: 0xE0C210 Offset: 0xE0A810 VA: 0x180E0C210
	internal string <.cctor>b__2_120() { }

	// RVA: 0xE0C270 Offset: 0xE0A870 VA: 0x180E0C270
	internal void <.cctor>b__2_121(string str) { }

	// RVA: 0xE0C300 Offset: 0xE0A900 VA: 0x180E0C300
	internal string <.cctor>b__2_122() { }

	// RVA: 0xE0C360 Offset: 0xE0A960 VA: 0x180E0C360
	internal void <.cctor>b__2_123(string str) { }

	// RVA: 0xE0C3F0 Offset: 0xE0A9F0 VA: 0x180E0C3F0
	internal string <.cctor>b__2_124() { }

	// RVA: 0xE0C450 Offset: 0xE0AA50 VA: 0x180E0C450
	internal void <.cctor>b__2_125(string str) { }

	// RVA: 0xE0C500 Offset: 0xE0AB00 VA: 0x180E0C500
	internal string <.cctor>b__2_126() { }

	// RVA: 0xE0C560 Offset: 0xE0AB60 VA: 0x180E0C560
	internal void <.cctor>b__2_127(string str) { }

	// RVA: 0xE0C5F0 Offset: 0xE0ABF0 VA: 0x180E0C5F0
	internal string <.cctor>b__2_128() { }

	// RVA: 0xE0C650 Offset: 0xE0AC50 VA: 0x180E0C650
	internal void <.cctor>b__2_129(string str) { }

	// RVA: 0xE0C780 Offset: 0xE0AD80 VA: 0x180E0C780
	internal string <.cctor>b__2_130() { }

	// RVA: 0xE0C7E0 Offset: 0xE0ADE0 VA: 0x180E0C7E0
	internal void <.cctor>b__2_131(string str) { }

	// RVA: 0xE0C890 Offset: 0xE0AE90 VA: 0x180E0C890
	internal void <.cctor>b__2_132(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C8F0 Offset: 0xE0AEF0 VA: 0x180E0C8F0
	internal void <.cctor>b__2_133(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C950 Offset: 0xE0AF50 VA: 0x180E0C950
	internal void <.cctor>b__2_134(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0C9B0 Offset: 0xE0AFB0 VA: 0x180E0C9B0
	internal void <.cctor>b__2_135(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CA10 Offset: 0xE0B010 VA: 0x180E0CA10
	internal string <.cctor>b__2_136() { }

	// RVA: 0xE0CA70 Offset: 0xE0B070 VA: 0x180E0CA70
	internal void <.cctor>b__2_137(string str) { }

	// RVA: 0xE0CB00 Offset: 0xE0B100 VA: 0x180E0CB00
	internal string <.cctor>b__2_138() { }

	// RVA: 0xE0CB60 Offset: 0xE0B160 VA: 0x180E0CB60
	internal void <.cctor>b__2_139(string str) { }

	// RVA: 0xE0CCB0 Offset: 0xE0B2B0 VA: 0x180E0CCB0
	internal string <.cctor>b__2_140() { }

	// RVA: 0xE0CD10 Offset: 0xE0B310 VA: 0x180E0CD10
	internal void <.cctor>b__2_141(string str) { }

	// RVA: 0xE0CDB0 Offset: 0xE0B3B0 VA: 0x180E0CDB0
	internal void <.cctor>b__2_142(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CE20 Offset: 0xE0B420 VA: 0x180E0CE20
	internal void <.cctor>b__2_143(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CE80 Offset: 0xE0B480 VA: 0x180E0CE80
	internal string <.cctor>b__2_144() { }

	// RVA: 0xE0CEE0 Offset: 0xE0B4E0 VA: 0x180E0CEE0
	internal void <.cctor>b__2_145(string str) { }

	// RVA: 0xE0CF80 Offset: 0xE0B580 VA: 0x180E0CF80
	internal string <.cctor>b__2_146() { }

	// RVA: 0xE0CFE0 Offset: 0xE0B5E0 VA: 0x180E0CFE0
	internal void <.cctor>b__2_147(string str) { }

	// RVA: 0xE0D090 Offset: 0xE0B690 VA: 0x180E0D090
	internal string <.cctor>b__2_148() { }

	// RVA: 0xE0D0F0 Offset: 0xE0B6F0 VA: 0x180E0D0F0
	internal void <.cctor>b__2_149(string str) { }

	// RVA: 0xE0D210 Offset: 0xE0B810 VA: 0x180E0D210
	internal void <.cctor>b__2_150(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D270 Offset: 0xE0B870 VA: 0x180E0D270
	internal void <.cctor>b__2_151(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D2D0 Offset: 0xE0B8D0 VA: 0x180E0D2D0
	internal string <.cctor>b__2_152() { }

	// RVA: 0xE0D330 Offset: 0xE0B930 VA: 0x180E0D330
	internal void <.cctor>b__2_153(string str) { }

	// RVA: 0xE0D3D0 Offset: 0xE0B9D0 VA: 0x180E0D3D0
	internal string <.cctor>b__2_154() { }

	// RVA: 0xE0D430 Offset: 0xE0BA30 VA: 0x180E0D430
	internal void <.cctor>b__2_155(string str) { }

	// RVA: 0xE0D4D0 Offset: 0xE0BAD0 VA: 0x180E0D4D0
	internal string <.cctor>b__2_156() { }

	// RVA: 0xE0D530 Offset: 0xE0BB30 VA: 0x180E0D530
	internal void <.cctor>b__2_157(string str) { }

	// RVA: 0xE0D5D0 Offset: 0xE0BBD0 VA: 0x180E0D5D0
	internal string <.cctor>b__2_158() { }

	// RVA: 0xE0D630 Offset: 0xE0BC30 VA: 0x180E0D630
	internal void <.cctor>b__2_159(string str) { }

	// RVA: 0xE0D780 Offset: 0xE0BD80 VA: 0x180E0D780
	internal string <.cctor>b__2_160() { }

	// RVA: 0xE0D7E0 Offset: 0xE0BDE0 VA: 0x180E0D7E0
	internal void <.cctor>b__2_161(string str) { }

	// RVA: 0xE0D890 Offset: 0xE0BE90 VA: 0x180E0D890
	internal string <.cctor>b__2_162() { }

	// RVA: 0xE0D8F0 Offset: 0xE0BEF0 VA: 0x180E0D8F0
	internal void <.cctor>b__2_163(string str) { }

	// RVA: 0xE0D990 Offset: 0xE0BF90 VA: 0x180E0D990
	internal void <.cctor>b__2_164(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D9F0 Offset: 0xE0BFF0 VA: 0x180E0D9F0
	internal string <.cctor>b__2_165() { }

	// RVA: 0xE0DA70 Offset: 0xE0C070 VA: 0x180E0DA70
	internal void <.cctor>b__2_166(string str) { }

	// RVA: 0xE0DAE0 Offset: 0xE0C0E0 VA: 0x180E0DAE0
	internal string <.cctor>b__2_167() { }

	// RVA: 0xE0DB40 Offset: 0xE0C140 VA: 0x180E0DB40
	internal void <.cctor>b__2_168(string str) { }

	// RVA: 0xE0DBE0 Offset: 0xE0C1E0 VA: 0x180E0DBE0
	internal string <.cctor>b__2_169() { }

	// RVA: 0xE0DCC0 Offset: 0xE0C2C0 VA: 0x180E0DCC0
	internal void <.cctor>b__2_170(string str) { }

	// RVA: 0xE0DD60 Offset: 0xE0C360 VA: 0x180E0DD60
	internal string <.cctor>b__2_171() { }

	// RVA: 0xE0DDC0 Offset: 0xE0C3C0 VA: 0x180E0DDC0
	internal void <.cctor>b__2_172(string str) { }

	// RVA: 0xE0DE60 Offset: 0xE0C460 VA: 0x180E0DE60
	internal string <.cctor>b__2_173() { }

	// RVA: 0xE0DEC0 Offset: 0xE0C4C0 VA: 0x180E0DEC0
	internal void <.cctor>b__2_174(string str) { }

	// RVA: 0xE0DF70 Offset: 0xE0C570 VA: 0x180E0DF70
	internal string <.cctor>b__2_175() { }

	// RVA: 0xE0DFD0 Offset: 0xE0C5D0 VA: 0x180E0DFD0
	internal void <.cctor>b__2_176(string str) { }

	// RVA: 0xE0E080 Offset: 0xE0C680 VA: 0x180E0E080
	internal string <.cctor>b__2_177() { }

	// RVA: 0xE0E0E0 Offset: 0xE0C6E0 VA: 0x180E0E0E0
	internal void <.cctor>b__2_178(string str) { }

	// RVA: 0xE0E180 Offset: 0xE0C780 VA: 0x180E0E180
	internal string <.cctor>b__2_179() { }

	// RVA: 0xE0E290 Offset: 0xE0C890 VA: 0x180E0E290
	internal void <.cctor>b__2_180(string str) { }

	// RVA: 0xE0E340 Offset: 0xE0C940 VA: 0x180E0E340
	internal string <.cctor>b__2_181() { }

	// RVA: 0xE0E3A0 Offset: 0xE0C9A0 VA: 0x180E0E3A0
	internal void <.cctor>b__2_182(string str) { }

	// RVA: 0xE0E450 Offset: 0xE0CA50 VA: 0x180E0E450
	internal string <.cctor>b__2_183() { }

	// RVA: 0xE0E4B0 Offset: 0xE0CAB0 VA: 0x180E0E4B0
	internal void <.cctor>b__2_184(string str) { }

	// RVA: 0xE0E560 Offset: 0xE0CB60 VA: 0x180E0E560
	internal string <.cctor>b__2_185() { }

	// RVA: 0xE0E5C0 Offset: 0xE0CBC0 VA: 0x180E0E5C0
	internal void <.cctor>b__2_186(string str) { }

	// RVA: 0xE0E670 Offset: 0xE0CC70 VA: 0x180E0E670
	internal string <.cctor>b__2_187() { }

	// RVA: 0xE0E6D0 Offset: 0xE0CCD0 VA: 0x180E0E6D0
	internal void <.cctor>b__2_188(string str) { }

	// RVA: 0xE0E780 Offset: 0xE0CD80 VA: 0x180E0E780
	internal void <.cctor>b__2_189(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E860 Offset: 0xE0CE60 VA: 0x180E0E860
	internal void <.cctor>b__2_190(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E8C0 Offset: 0xE0CEC0 VA: 0x180E0E8C0
	internal string <.cctor>b__2_191() { }

	// RVA: 0xE0E920 Offset: 0xE0CF20 VA: 0x180E0E920
	internal void <.cctor>b__2_192(string str) { }

	// RVA: 0xE0E9A0 Offset: 0xE0CFA0 VA: 0x180E0E9A0
	internal string <.cctor>b__2_193() { }

	// RVA: 0xE0EA00 Offset: 0xE0D000 VA: 0x180E0EA00
	internal void <.cctor>b__2_194(string str) { }

	// RVA: 0xE0EAB0 Offset: 0xE0D0B0 VA: 0x180E0EAB0
	internal string <.cctor>b__2_195() { }

	// RVA: 0xE0EB10 Offset: 0xE0D110 VA: 0x180E0EB10
	internal void <.cctor>b__2_196(string str) { }

	// RVA: 0xE0EBC0 Offset: 0xE0D1C0 VA: 0x180E0EBC0
	internal void <.cctor>b__2_197(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EC20 Offset: 0xE0D220 VA: 0x180E0EC20
	internal void <.cctor>b__2_198(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EC80 Offset: 0xE0D280 VA: 0x180E0EC80
	internal string <.cctor>b__2_199() { }

	// RVA: 0xE0EE30 Offset: 0xE0D430 VA: 0x180E0EE30
	internal void <.cctor>b__2_200(string str) { }

	// RVA: 0xE0EED0 Offset: 0xE0D4D0 VA: 0x180E0EED0
	internal string <.cctor>b__2_201() { }

	// RVA: 0xE0EF30 Offset: 0xE0D530 VA: 0x180E0EF30
	internal void <.cctor>b__2_202(string str) { }

	// RVA: 0xE0EFD0 Offset: 0xE0D5D0 VA: 0x180E0EFD0
	internal string <.cctor>b__2_203() { }

	// RVA: 0xE0F030 Offset: 0xE0D630 VA: 0x180E0F030
	internal void <.cctor>b__2_204(string str) { }

	// RVA: 0xE0F0D0 Offset: 0xE0D6D0 VA: 0x180E0F0D0
	internal string <.cctor>b__2_205() { }

	// RVA: 0xE0F130 Offset: 0xE0D730 VA: 0x180E0F130
	internal void <.cctor>b__2_206(string str) { }

	// RVA: 0xE0F1D0 Offset: 0xE0D7D0 VA: 0x180E0F1D0
	internal string <.cctor>b__2_207() { }

	// RVA: 0xE0F230 Offset: 0xE0D830 VA: 0x180E0F230
	internal void <.cctor>b__2_208(string str) { }

	// RVA: 0xE0F2D0 Offset: 0xE0D8D0 VA: 0x180E0F2D0
	internal string <.cctor>b__2_209() { }

	// RVA: 0xE0F3B0 Offset: 0xE0D9B0 VA: 0x180E0F3B0
	internal void <.cctor>b__2_210(string str) { }

	// RVA: 0xE0F450 Offset: 0xE0DA50 VA: 0x180E0F450
	internal void <.cctor>b__2_211(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F4B0 Offset: 0xE0DAB0 VA: 0x180E0F4B0
	internal void <.cctor>b__2_212(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F510 Offset: 0xE0DB10 VA: 0x180E0F510
	internal void <.cctor>b__2_213(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F560 Offset: 0xE0DB60 VA: 0x180E0F560
	internal string <.cctor>b__2_214() { }

	// RVA: 0xE0F5C0 Offset: 0xE0DBC0 VA: 0x180E0F5C0
	internal void <.cctor>b__2_215(string str) { }

	// RVA: 0xE0F660 Offset: 0xE0DC60 VA: 0x180E0F660
	internal void <.cctor>b__2_216(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F6C0 Offset: 0xE0DCC0 VA: 0x180E0F6C0
	internal string <.cctor>b__2_217() { }

	// RVA: 0xE0F720 Offset: 0xE0DD20 VA: 0x180E0F720
	internal void <.cctor>b__2_218(string str) { }

	// RVA: 0xE0F7A0 Offset: 0xE0DDA0 VA: 0x180E0F7A0
	internal void <.cctor>b__2_219(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F8B0 Offset: 0xE0DEB0 VA: 0x180E0F8B0
	internal void <.cctor>b__2_220(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F900 Offset: 0xE0DF00 VA: 0x180E0F900
	internal void <.cctor>b__2_221(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F960 Offset: 0xE0DF60 VA: 0x180E0F960
	internal void <.cctor>b__2_222(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F9C0 Offset: 0xE0DFC0 VA: 0x180E0F9C0
	internal void <.cctor>b__2_223(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FA20 Offset: 0xE0E020 VA: 0x180E0FA20
	internal void <.cctor>b__2_224(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FA80 Offset: 0xE0E080 VA: 0x180E0FA80
	internal string <.cctor>b__2_225() { }

	// RVA: 0xE0FB00 Offset: 0xE0E100 VA: 0x180E0FB00
	internal void <.cctor>b__2_226(string str) { }

	// RVA: 0xE0FB70 Offset: 0xE0E170 VA: 0x180E0FB70
	internal string <.cctor>b__2_227() { }

	// RVA: 0xE0FBD0 Offset: 0xE0E1D0 VA: 0x180E0FBD0
	internal void <.cctor>b__2_228(string str) { }

	// RVA: 0xE0FC80 Offset: 0xE0E280 VA: 0x180E0FC80
	internal string <.cctor>b__2_229() { }

	// RVA: 0xE0FD60 Offset: 0xE0E360 VA: 0x180E0FD60
	internal void <.cctor>b__2_230(string str) { }

	// RVA: 0xE0FE10 Offset: 0xE0E410 VA: 0x180E0FE10
	internal string <.cctor>b__2_231() { }

	// RVA: 0xE0FE70 Offset: 0xE0E470 VA: 0x180E0FE70
	internal void <.cctor>b__2_232(string str) { }

	// RVA: 0xE0FF20 Offset: 0xE0E520 VA: 0x180E0FF20
	internal string <.cctor>b__2_233() { }

	// RVA: 0xE0FF80 Offset: 0xE0E580 VA: 0x180E0FF80
	internal void <.cctor>b__2_234(string str) { }

	// RVA: 0xE10020 Offset: 0xE0E620 VA: 0x180E10020
	internal string <.cctor>b__2_235() { }

	// RVA: 0xE10080 Offset: 0xE0E680 VA: 0x180E10080
	internal void <.cctor>b__2_236(string str) { }

	// RVA: 0xE10130 Offset: 0xE0E730 VA: 0x180E10130
	internal string <.cctor>b__2_237() { }

	// RVA: 0xE10190 Offset: 0xE0E790 VA: 0x180E10190
	internal void <.cctor>b__2_238(string str) { }

	// RVA: 0xE10220 Offset: 0xE0E820 VA: 0x180E10220
	internal string <.cctor>b__2_239() { }

	// RVA: 0xE10330 Offset: 0xE0E930 VA: 0x180E10330
	internal void <.cctor>b__2_240(string str) { }

	// RVA: 0xE103D0 Offset: 0xE0E9D0 VA: 0x180E103D0
	internal string <.cctor>b__2_241() { }

	// RVA: 0xE10430 Offset: 0xE0EA30 VA: 0x180E10430
	internal void <.cctor>b__2_242(string str) { }

	// RVA: 0xE104B0 Offset: 0xE0EAB0 VA: 0x180E104B0
	internal string <.cctor>b__2_243() { }

	// RVA: 0xE10510 Offset: 0xE0EB10 VA: 0x180E10510
	internal void <.cctor>b__2_244(string str) { }

	// RVA: 0xE105A0 Offset: 0xE0EBA0 VA: 0x180E105A0
	internal string <.cctor>b__2_245() { }

	// RVA: 0xE10600 Offset: 0xE0EC00 VA: 0x180E10600
	internal void <.cctor>b__2_246(string str) { }

	// RVA: 0xE10680 Offset: 0xE0EC80 VA: 0x180E10680
	internal void <.cctor>b__2_247(ConsoleSystem.Arg arg) { }

	// RVA: 0xE106E0 Offset: 0xE0ECE0 VA: 0x180E106E0
	internal string <.cctor>b__2_248() { }

	// RVA: 0xE10740 Offset: 0xE0ED40 VA: 0x180E10740
	internal void <.cctor>b__2_249(string str) { }

	// RVA: 0xE10870 Offset: 0xE0EE70 VA: 0x180E10870
	internal string <.cctor>b__2_250() { }

	// RVA: 0xE108D0 Offset: 0xE0EED0 VA: 0x180E108D0
	internal void <.cctor>b__2_251(string str) { }

	// RVA: 0xE10980 Offset: 0xE0EF80 VA: 0x180E10980
	internal string <.cctor>b__2_252() { }

	// RVA: 0xE109E0 Offset: 0xE0EFE0 VA: 0x180E109E0
	internal void <.cctor>b__2_253(string str) { }

	// RVA: 0xE10A90 Offset: 0xE0F090 VA: 0x180E10A90
	internal void <.cctor>b__2_254(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10B50 Offset: 0xE0F150 VA: 0x180E10B50
	internal void <.cctor>b__2_255(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10C10 Offset: 0xE0F210 VA: 0x180E10C10
	internal void <.cctor>b__2_256(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10C60 Offset: 0xE0F260 VA: 0x180E10C60
	internal string <.cctor>b__2_257() { }

	// RVA: 0xE10CC0 Offset: 0xE0F2C0 VA: 0x180E10CC0
	internal void <.cctor>b__2_258(string str) { }

	// RVA: 0xE10D60 Offset: 0xE0F360 VA: 0x180E10D60
	internal string <.cctor>b__2_259() { }

	// RVA: 0xE10E70 Offset: 0xE0F470 VA: 0x180E10E70
	internal void <.cctor>b__2_260(string str) { }

	// RVA: 0xE10F10 Offset: 0xE0F510 VA: 0x180E10F10
	internal string <.cctor>b__2_261() { }

	// RVA: 0xE10F70 Offset: 0xE0F570 VA: 0x180E10F70
	internal void <.cctor>b__2_262(string str) { }

	// RVA: 0xE11010 Offset: 0xE0F610 VA: 0x180E11010
	internal void <.cctor>b__2_263(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11080 Offset: 0xE0F680 VA: 0x180E11080
	internal void <.cctor>b__2_264(ConsoleSystem.Arg arg) { }

	// RVA: 0xE110F0 Offset: 0xE0F6F0 VA: 0x180E110F0
	internal string <.cctor>b__2_265() { }

	// RVA: 0xE11150 Offset: 0xE0F750 VA: 0x180E11150
	internal void <.cctor>b__2_266(string str) { }

	// RVA: 0xE111F0 Offset: 0xE0F7F0 VA: 0x180E111F0
	internal string <.cctor>b__2_267() { }

	// RVA: 0xE11250 Offset: 0xE0F850 VA: 0x180E11250
	internal void <.cctor>b__2_268(string str) { }

	// RVA: 0xE11300 Offset: 0xE0F900 VA: 0x180E11300
	internal string <.cctor>b__2_269() { }

	// RVA: 0xE113E0 Offset: 0xE0F9E0 VA: 0x180E113E0
	internal void <.cctor>b__2_270(string str) { }

	// RVA: 0xE11480 Offset: 0xE0FA80 VA: 0x180E11480
	internal string <.cctor>b__2_271() { }

	// RVA: 0xE114E0 Offset: 0xE0FAE0 VA: 0x180E114E0
	internal void <.cctor>b__2_272(string str) { }

	// RVA: 0xE11580 Offset: 0xE0FB80 VA: 0x180E11580
	internal string <.cctor>b__2_273() { }

	// RVA: 0xE115E0 Offset: 0xE0FBE0 VA: 0x180E115E0
	internal void <.cctor>b__2_274(string str) { }

	// RVA: 0xE11680 Offset: 0xE0FC80 VA: 0x180E11680
	internal string <.cctor>b__2_275() { }

	// RVA: 0xE116E0 Offset: 0xE0FCE0 VA: 0x180E116E0
	internal void <.cctor>b__2_276(string str) { }

	// RVA: 0xE11790 Offset: 0xE0FD90 VA: 0x180E11790
	internal string <.cctor>b__2_277() { }

	// RVA: 0xE117F0 Offset: 0xE0FDF0 VA: 0x180E117F0
	internal void <.cctor>b__2_278(string str) { }

	// RVA: 0xE11890 Offset: 0xE0FE90 VA: 0x180E11890
	internal string <.cctor>b__2_279() { }

	// RVA: 0xE119A0 Offset: 0xE0FFA0 VA: 0x180E119A0
	internal void <.cctor>b__2_280(string str) { }

	// RVA: 0xE11A40 Offset: 0xE10040 VA: 0x180E11A40
	internal string <.cctor>b__2_281() { }

	// RVA: 0xE11AA0 Offset: 0xE100A0 VA: 0x180E11AA0
	internal void <.cctor>b__2_282(string str) { }

	// RVA: 0xE11B40 Offset: 0xE10140 VA: 0x180E11B40
	internal string <.cctor>b__2_283() { }

	// RVA: 0xE11BF0 Offset: 0xE101F0 VA: 0x180E11BF0
	internal void <.cctor>b__2_284(string str) { }

	// RVA: 0xE11C80 Offset: 0xE10280 VA: 0x180E11C80
	internal string <.cctor>b__2_285() { }

	// RVA: 0xE11CE0 Offset: 0xE102E0 VA: 0x180E11CE0
	internal void <.cctor>b__2_286(string str) { }

	// RVA: 0xE11D80 Offset: 0xE10380 VA: 0x180E11D80
	internal string <.cctor>b__2_287() { }

	// RVA: 0xE11E30 Offset: 0xE10430 VA: 0x180E11E30
	internal void <.cctor>b__2_288(string str) { }

	// RVA: 0xE11EC0 Offset: 0xE104C0 VA: 0x180E11EC0
	internal void <.cctor>b__2_289(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11FC0 Offset: 0xE105C0 VA: 0x180E11FC0
	internal void <.cctor>b__2_290(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12020 Offset: 0xE10620 VA: 0x180E12020
	internal string <.cctor>b__2_291() { }

	// RVA: 0xE12080 Offset: 0xE10680 VA: 0x180E12080
	internal void <.cctor>b__2_292(string str) { }

	// RVA: 0xE12120 Offset: 0xE10720 VA: 0x180E12120
	internal void <.cctor>b__2_293(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12190 Offset: 0xE10790 VA: 0x180E12190
	internal void <.cctor>b__2_294(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12200 Offset: 0xE10800 VA: 0x180E12200
	internal void <.cctor>b__2_295(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12270 Offset: 0xE10870 VA: 0x180E12270
	internal void <.cctor>b__2_296(ConsoleSystem.Arg arg) { }

	// RVA: 0xE122E0 Offset: 0xE108E0 VA: 0x180E122E0
	internal void <.cctor>b__2_297(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12350 Offset: 0xE10950 VA: 0x180E12350
	internal string <.cctor>b__2_298() { }

	// RVA: 0xE123B0 Offset: 0xE109B0 VA: 0x180E123B0
	internal void <.cctor>b__2_299(string str) { }

	// RVA: 0xE12560 Offset: 0xE10B60 VA: 0x180E12560
	internal void <.cctor>b__2_300(ConsoleSystem.Arg arg) { }

	// RVA: 0xE125B0 Offset: 0xE10BB0 VA: 0x180E125B0
	internal void <.cctor>b__2_301(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12610 Offset: 0xE10C10 VA: 0x180E12610
	internal void <.cctor>b__2_302(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12670 Offset: 0xE10C70 VA: 0x180E12670
	internal string <.cctor>b__2_303() { }

	// RVA: 0xE126D0 Offset: 0xE10CD0 VA: 0x180E126D0
	internal void <.cctor>b__2_304(string str) { }

	// RVA: 0xE12770 Offset: 0xE10D70 VA: 0x180E12770
	internal void <.cctor>b__2_305(ConsoleSystem.Arg arg) { }

	// RVA: 0xE127D0 Offset: 0xE10DD0 VA: 0x180E127D0
	internal string <.cctor>b__2_306() { }

	// RVA: 0xE12830 Offset: 0xE10E30 VA: 0x180E12830
	internal void <.cctor>b__2_307(string str) { }

	// RVA: 0xE128D0 Offset: 0xE10ED0 VA: 0x180E128D0
	internal void <.cctor>b__2_308(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12930 Offset: 0xE10F30 VA: 0x180E12930
	internal string <.cctor>b__2_309() { }

	// RVA: 0xE12A10 Offset: 0xE11010 VA: 0x180E12A10
	internal void <.cctor>b__2_310(string str) { }

	// RVA: 0xE12AB0 Offset: 0xE110B0 VA: 0x180E12AB0
	internal void <.cctor>b__2_311(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12B10 Offset: 0xE11110 VA: 0x180E12B10
	internal string <.cctor>b__2_312() { }

	// RVA: 0xE12B70 Offset: 0xE11170 VA: 0x180E12B70
	internal void <.cctor>b__2_313(string str) { }

	// RVA: 0xE12C10 Offset: 0xE11210 VA: 0x180E12C10
	internal void <.cctor>b__2_314(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12C70 Offset: 0xE11270 VA: 0x180E12C70
	internal void <.cctor>b__2_315(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12CD0 Offset: 0xE112D0 VA: 0x180E12CD0
	internal string <.cctor>b__2_316() { }

	// RVA: 0xE12D30 Offset: 0xE11330 VA: 0x180E12D30
	internal void <.cctor>b__2_317(string str) { }

	// RVA: 0xE12DD0 Offset: 0xE113D0 VA: 0x180E12DD0
	internal string <.cctor>b__2_318() { }

	// RVA: 0xE12E30 Offset: 0xE11430 VA: 0x180E12E30
	internal void <.cctor>b__2_319(string str) { }

	// RVA: 0xE12F60 Offset: 0xE11560 VA: 0x180E12F60
	internal string <.cctor>b__2_320() { }

	// RVA: 0xE12FC0 Offset: 0xE115C0 VA: 0x180E12FC0
	internal void <.cctor>b__2_321(string str) { }

	// RVA: 0xE13070 Offset: 0xE11670 VA: 0x180E13070
	internal string <.cctor>b__2_322() { }

	// RVA: 0xE130D0 Offset: 0xE116D0 VA: 0x180E130D0
	internal void <.cctor>b__2_323(string str) { }

	// RVA: 0xE13180 Offset: 0xE11780 VA: 0x180E13180
	internal string <.cctor>b__2_324() { }

	// RVA: 0xE131E0 Offset: 0xE117E0 VA: 0x180E131E0
	internal void <.cctor>b__2_325(string str) { }

	// RVA: 0xE13290 Offset: 0xE11890 VA: 0x180E13290
	internal string <.cctor>b__2_326() { }

	// RVA: 0xE132F0 Offset: 0xE118F0 VA: 0x180E132F0
	internal void <.cctor>b__2_327(string str) { }

	// RVA: 0xE133A0 Offset: 0xE119A0 VA: 0x180E133A0
	internal string <.cctor>b__2_328() { }

	// RVA: 0xE13450 Offset: 0xE11A50 VA: 0x180E13450
	internal void <.cctor>b__2_329(string str) { }

	// RVA: 0xE13550 Offset: 0xE11B50 VA: 0x180E13550
	internal string <.cctor>b__2_330() { }

	// RVA: 0xE135B0 Offset: 0xE11BB0 VA: 0x180E135B0
	internal void <.cctor>b__2_331(string str) { }

	// RVA: 0xE13660 Offset: 0xE11C60 VA: 0x180E13660
	internal string <.cctor>b__2_332() { }

	// RVA: 0xE136C0 Offset: 0xE11CC0 VA: 0x180E136C0
	internal void <.cctor>b__2_333(string str) { }

	// RVA: 0xE13760 Offset: 0xE11D60 VA: 0x180E13760
	internal string <.cctor>b__2_334() { }

	// RVA: 0xE137C0 Offset: 0xE11DC0 VA: 0x180E137C0
	internal void <.cctor>b__2_335(string str) { }

	// RVA: 0xE13840 Offset: 0xE11E40 VA: 0x180E13840
	internal string <.cctor>b__2_336() { }

	// RVA: 0xE138A0 Offset: 0xE11EA0 VA: 0x180E138A0
	internal void <.cctor>b__2_337(string str) { }

	// RVA: 0xE13920 Offset: 0xE11F20 VA: 0x180E13920
	internal void <.cctor>b__2_338(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13930 Offset: 0xE11F30 VA: 0x180E13930
	internal void <.cctor>b__2_339(ConsoleSystem.Arg arg) { }

	// RVA: 0xE139F0 Offset: 0xE11FF0 VA: 0x180E139F0
	internal void <.cctor>b__2_340(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13A00 Offset: 0xE12000 VA: 0x180E13A00
	internal void <.cctor>b__2_341(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13A10 Offset: 0xE12010 VA: 0x180E13A10
	internal void <.cctor>b__2_342(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13A20 Offset: 0xE12020 VA: 0x180E13A20
	internal void <.cctor>b__2_343(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13A30 Offset: 0xE12030 VA: 0x180E13A30
	internal string <.cctor>b__2_344() { }

	// RVA: 0xE13A90 Offset: 0xE12090 VA: 0x180E13A90
	internal void <.cctor>b__2_345(string str) { }

	// RVA: 0xE13B30 Offset: 0xE12130 VA: 0x180E13B30
	internal string <.cctor>b__2_346() { }

	// RVA: 0xE13B90 Offset: 0xE12190 VA: 0x180E13B90
	internal void <.cctor>b__2_347(string str) { }

	// RVA: 0xE13C30 Offset: 0xE12230 VA: 0x180E13C30
	internal string <.cctor>b__2_348() { }

	// RVA: 0xE13C90 Offset: 0xE12290 VA: 0x180E13C90
	internal void <.cctor>b__2_349(string str) { }

	// RVA: 0xE13DB0 Offset: 0xE123B0 VA: 0x180E13DB0
	internal void <.cctor>b__2_350(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13E10 Offset: 0xE12410 VA: 0x180E13E10
	internal string <.cctor>b__2_351() { }

	// RVA: 0xE13E70 Offset: 0xE12470 VA: 0x180E13E70
	internal void <.cctor>b__2_352(string str) { }

	// RVA: 0xE13F10 Offset: 0xE12510 VA: 0x180E13F10
	internal string <.cctor>b__2_353() { }

	// RVA: 0xE13F70 Offset: 0xE12570 VA: 0x180E13F70
	internal void <.cctor>b__2_354(string str) { }

	// RVA: 0xE14010 Offset: 0xE12610 VA: 0x180E14010
	internal string <.cctor>b__2_355() { }

	// RVA: 0xE14070 Offset: 0xE12670 VA: 0x180E14070
	internal void <.cctor>b__2_356(string str) { }

	// RVA: 0xE14110 Offset: 0xE12710 VA: 0x180E14110
	internal void <.cctor>b__2_357(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14170 Offset: 0xE12770 VA: 0x180E14170
	internal string <.cctor>b__2_358() { }

	// RVA: 0xE141F0 Offset: 0xE127F0 VA: 0x180E141F0
	internal void <.cctor>b__2_359(string str) { }

	// RVA: 0xE14350 Offset: 0xE12950 VA: 0x180E14350
	internal string <.cctor>b__2_360() { }

	// RVA: 0xE143D0 Offset: 0xE129D0 VA: 0x180E143D0
	internal void <.cctor>b__2_361(string str) { }

	// RVA: 0xE14480 Offset: 0xE12A80 VA: 0x180E14480
	internal string <.cctor>b__2_362() { }

	// RVA: 0xE14500 Offset: 0xE12B00 VA: 0x180E14500
	internal void <.cctor>b__2_363(string str) { }

	// RVA: 0xE145B0 Offset: 0xE12BB0 VA: 0x180E145B0
	internal string <.cctor>b__2_364() { }

	// RVA: 0xE14610 Offset: 0xE12C10 VA: 0x180E14610
	internal void <.cctor>b__2_365(string str) { }

	// RVA: 0xE146C0 Offset: 0xE12CC0 VA: 0x180E146C0
	internal void <.cctor>b__2_366(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14730 Offset: 0xE12D30 VA: 0x180E14730
	internal void <.cctor>b__2_367(ConsoleSystem.Arg arg) { }

	// RVA: 0xE147A0 Offset: 0xE12DA0 VA: 0x180E147A0
	internal void <.cctor>b__2_368(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14810 Offset: 0xE12E10 VA: 0x180E14810
	internal void <.cctor>b__2_369(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14900 Offset: 0xE12F00 VA: 0x180E14900
	internal void <.cctor>b__2_370(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14960 Offset: 0xE12F60 VA: 0x180E14960
	internal void <.cctor>b__2_371(ConsoleSystem.Arg arg) { }

	// RVA: 0xE149C0 Offset: 0xE12FC0 VA: 0x180E149C0
	internal string <.cctor>b__2_372() { }

	// RVA: 0xE14A20 Offset: 0xE13020 VA: 0x180E14A20
	internal void <.cctor>b__2_373(string str) { }

	// RVA: 0xE14AC0 Offset: 0xE130C0 VA: 0x180E14AC0
	internal string <.cctor>b__2_374() { }

	// RVA: 0xE14B20 Offset: 0xE13120 VA: 0x180E14B20
	internal void <.cctor>b__2_375(string str) { }

	// RVA: 0xE14BC0 Offset: 0xE131C0 VA: 0x180E14BC0
	internal string <.cctor>b__2_376() { }

	// RVA: 0xE14C40 Offset: 0xE13240 VA: 0x180E14C40
	internal void <.cctor>b__2_377(string str) { }

	// RVA: 0xE14CF0 Offset: 0xE132F0 VA: 0x180E14CF0
	internal string <.cctor>b__2_378() { }

	// RVA: 0xE14D50 Offset: 0xE13350 VA: 0x180E14D50
	internal void <.cctor>b__2_379(string str) { }

	// RVA: 0xE14E90 Offset: 0xE13490 VA: 0x180E14E90
	internal string <.cctor>b__2_380() { }

	// RVA: 0xE14EF0 Offset: 0xE134F0 VA: 0x180E14EF0
	internal void <.cctor>b__2_381(string str) { }

	// RVA: 0xE14F90 Offset: 0xE13590 VA: 0x180E14F90
	internal string <.cctor>b__2_382() { }

	// RVA: 0xE15010 Offset: 0xE13610 VA: 0x180E15010
	internal void <.cctor>b__2_383(string str) { }

	// RVA: 0xE150C0 Offset: 0xE136C0 VA: 0x180E150C0
	internal void <.cctor>b__2_384(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15120 Offset: 0xE13720 VA: 0x180E15120
	internal void <.cctor>b__2_385(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15180 Offset: 0xE13780 VA: 0x180E15180
	internal void <.cctor>b__2_386(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15250 Offset: 0xE13850 VA: 0x180E15250
	internal void <.cctor>b__2_387(ConsoleSystem.Arg arg) { }

	// RVA: 0xE152A0 Offset: 0xE138A0 VA: 0x180E152A0
	internal void <.cctor>b__2_388(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15300 Offset: 0xE13900 VA: 0x180E15300
	internal string <.cctor>b__2_389() { }

	// RVA: 0xE15400 Offset: 0xE13A00 VA: 0x180E15400
	internal void <.cctor>b__2_390(string str) { }

	// RVA: 0xE154B0 Offset: 0xE13AB0 VA: 0x180E154B0
	internal void <.cctor>b__2_391(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15510 Offset: 0xE13B10 VA: 0x180E15510
	internal void <.cctor>b__2_392(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15570 Offset: 0xE13B70 VA: 0x180E15570
	internal string <.cctor>b__2_393() { }

	// RVA: 0xE155F0 Offset: 0xE13BF0 VA: 0x180E155F0
	internal void <.cctor>b__2_394(string str) { }

	// RVA: 0xE156A0 Offset: 0xE13CA0 VA: 0x180E156A0
	internal string <.cctor>b__2_395() { }

	// RVA: 0xE15720 Offset: 0xE13D20 VA: 0x180E15720
	internal void <.cctor>b__2_396(string str) { }

	// RVA: 0xE157D0 Offset: 0xE13DD0 VA: 0x180E157D0
	internal string <.cctor>b__2_397() { }

	// RVA: 0xE15830 Offset: 0xE13E30 VA: 0x180E15830
	internal void <.cctor>b__2_398(string str) { }

	// RVA: 0xE158D0 Offset: 0xE13ED0 VA: 0x180E158D0
	internal void <.cctor>b__2_399(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15A90 Offset: 0xE14090 VA: 0x180E15A90
	internal string <.cctor>b__2_400() { }

	// RVA: 0xE15B10 Offset: 0xE14110 VA: 0x180E15B10
	internal void <.cctor>b__2_401(string str) { }

	// RVA: 0xE15B80 Offset: 0xE14180 VA: 0x180E15B80
	internal string <.cctor>b__2_402() { }

	// RVA: 0xE15BE0 Offset: 0xE141E0 VA: 0x180E15BE0
	internal void <.cctor>b__2_403(string str) { }

	// RVA: 0xE15C60 Offset: 0xE14260 VA: 0x180E15C60
	internal void <.cctor>b__2_404(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15CC0 Offset: 0xE142C0 VA: 0x180E15CC0
	internal void <.cctor>b__2_405(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15D20 Offset: 0xE14320 VA: 0x180E15D20
	internal void <.cctor>b__2_406(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15D80 Offset: 0xE14380 VA: 0x180E15D80
	internal string <.cctor>b__2_407() { }

	// RVA: 0xE15DE0 Offset: 0xE143E0 VA: 0x180E15DE0
	internal void <.cctor>b__2_408(string str) { }

	// RVA: 0xE15E80 Offset: 0xE14480 VA: 0x180E15E80
	internal void <.cctor>b__2_409(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15F60 Offset: 0xE14560 VA: 0x180E15F60
	internal string <.cctor>b__2_410() { }

	// RVA: 0xE15FC0 Offset: 0xE145C0 VA: 0x180E15FC0
	internal void <.cctor>b__2_411(string str) { }

	// RVA: 0xE16040 Offset: 0xE14640 VA: 0x180E16040
	internal void <.cctor>b__2_412(ConsoleSystem.Arg arg) { }

	// RVA: 0xE160A0 Offset: 0xE146A0 VA: 0x180E160A0
	internal string <.cctor>b__2_413() { }

	// RVA: 0xE16100 Offset: 0xE14700 VA: 0x180E16100
	internal void <.cctor>b__2_414(string str) { }

	// RVA: 0xE161A0 Offset: 0xE147A0 VA: 0x180E161A0
	internal string <.cctor>b__2_415() { }

	// RVA: 0xE16200 Offset: 0xE14800 VA: 0x180E16200
	internal void <.cctor>b__2_416(string str) { }

	// RVA: 0xE162A0 Offset: 0xE148A0 VA: 0x180E162A0
	internal void <.cctor>b__2_417(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16300 Offset: 0xE14900 VA: 0x180E16300
	internal string <.cctor>b__2_418() { }

	// RVA: 0xE16360 Offset: 0xE14960 VA: 0x180E16360
	internal void <.cctor>b__2_419(string str) { }

	// RVA: 0xE164B0 Offset: 0xE14AB0 VA: 0x180E164B0
	internal string <.cctor>b__2_420() { }

	// RVA: 0xE16510 Offset: 0xE14B10 VA: 0x180E16510
	internal void <.cctor>b__2_421(string str) { }

	// RVA: 0xE165B0 Offset: 0xE14BB0 VA: 0x180E165B0
	internal string <.cctor>b__2_422() { }

	// RVA: 0xE16660 Offset: 0xE14C60 VA: 0x180E16660
	internal void <.cctor>b__2_423(string str) { }

	// RVA: 0xE166F0 Offset: 0xE14CF0 VA: 0x180E166F0
	internal string <.cctor>b__2_424() { }

	// RVA: 0xE16750 Offset: 0xE14D50 VA: 0x180E16750
	internal void <.cctor>b__2_425(string str) { }

	// RVA: 0xE167F0 Offset: 0xE14DF0 VA: 0x180E167F0
	internal void <.cctor>b__2_426(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16840 Offset: 0xE14E40 VA: 0x180E16840
	internal string <.cctor>b__2_427() { }

	// RVA: 0xE168A0 Offset: 0xE14EA0 VA: 0x180E168A0
	internal void <.cctor>b__2_428(string str) { }

	// RVA: 0xE16940 Offset: 0xE14F40 VA: 0x180E16940
	internal string <.cctor>b__2_429() { }

	// RVA: 0xE16A70 Offset: 0xE15070 VA: 0x180E16A70
	internal void <.cctor>b__2_430(string str) { }

	// RVA: 0xE16AF0 Offset: 0xE150F0 VA: 0x180E16AF0
	internal void <.cctor>b__2_431(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16B80 Offset: 0xE15180 VA: 0x180E16B80
	internal void <.cctor>b__2_432(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16BF0 Offset: 0xE151F0 VA: 0x180E16BF0
	internal void <.cctor>b__2_433(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16C80 Offset: 0xE15280 VA: 0x180E16C80
	internal void <.cctor>b__2_434(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16CF0 Offset: 0xE152F0 VA: 0x180E16CF0
	internal void <.cctor>b__2_435(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16D40 Offset: 0xE15340 VA: 0x180E16D40
	internal void <.cctor>b__2_436(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16DD0 Offset: 0xE153D0 VA: 0x180E16DD0
	internal void <.cctor>b__2_437(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16E20 Offset: 0xE15420 VA: 0x180E16E20
	internal void <.cctor>b__2_438(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16E90 Offset: 0xE15490 VA: 0x180E16E90
	internal string <.cctor>b__2_439() { }

	// RVA: 0xE16FA0 Offset: 0xE155A0 VA: 0x180E16FA0
	internal void <.cctor>b__2_440(string str) { }

	// RVA: 0xE17040 Offset: 0xE15640 VA: 0x180E17040
	internal void <.cctor>b__2_441(ConsoleSystem.Arg arg) { }

	// RVA: 0xE170D0 Offset: 0xE156D0 VA: 0x180E170D0
	internal void <.cctor>b__2_442(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17140 Offset: 0xE15740 VA: 0x180E17140
	internal string <.cctor>b__2_443() { }

	// RVA: 0xE171A0 Offset: 0xE157A0 VA: 0x180E171A0
	internal void <.cctor>b__2_444(string str) { }

	// RVA: 0xE17250 Offset: 0xE15850 VA: 0x180E17250
	internal void <.cctor>b__2_445(ConsoleSystem.Arg arg) { }

	// RVA: 0xE172B0 Offset: 0xE158B0 VA: 0x180E172B0
	internal void <.cctor>b__2_446(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17320 Offset: 0xE15920 VA: 0x180E17320
	internal string <.cctor>b__2_447() { }

	// RVA: 0xE173D0 Offset: 0xE159D0 VA: 0x180E173D0
	internal void <.cctor>b__2_448(string str) { }

	// RVA: 0xE17450 Offset: 0xE15A50 VA: 0x180E17450
	internal string <.cctor>b__2_449() { }

	// RVA: 0xE17530 Offset: 0xE15B30 VA: 0x180E17530
	internal void <.cctor>b__2_450(string str) { }

	// RVA: 0xE175D0 Offset: 0xE15BD0 VA: 0x180E175D0
	internal string <.cctor>b__2_451() { }

	// RVA: 0xE17630 Offset: 0xE15C30 VA: 0x180E17630
	internal void <.cctor>b__2_452(string str) { }

	// RVA: 0xE176D0 Offset: 0xE15CD0 VA: 0x180E176D0
	internal void <.cctor>b__2_453(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17730 Offset: 0xE15D30 VA: 0x180E17730
	internal string <.cctor>b__2_454() { }

	// RVA: 0xE17790 Offset: 0xE15D90 VA: 0x180E17790
	internal void <.cctor>b__2_455(string str) { }

	// RVA: 0xE17830 Offset: 0xE15E30 VA: 0x180E17830
	internal string <.cctor>b__2_456() { }

	// RVA: 0xE17890 Offset: 0xE15E90 VA: 0x180E17890
	internal void <.cctor>b__2_457(string str) { }

	// RVA: 0xE17930 Offset: 0xE15F30 VA: 0x180E17930
	internal string <.cctor>b__2_458() { }

	// RVA: 0xE17990 Offset: 0xE15F90 VA: 0x180E17990
	internal void <.cctor>b__2_459(string str) { }

	// RVA: 0xE17AE0 Offset: 0xE160E0 VA: 0x180E17AE0
	internal string <.cctor>b__2_460() { }

	// RVA: 0xE17B40 Offset: 0xE16140 VA: 0x180E17B40
	internal void <.cctor>b__2_461(string str) { }

	// RVA: 0xE17BE0 Offset: 0xE161E0 VA: 0x180E17BE0
	internal string <.cctor>b__2_462() { }

	// RVA: 0xE17C40 Offset: 0xE16240 VA: 0x180E17C40
	internal void <.cctor>b__2_463(string str) { }

	// RVA: 0xE17CE0 Offset: 0xE162E0 VA: 0x180E17CE0
	internal string <.cctor>b__2_464() { }

	// RVA: 0xE17D40 Offset: 0xE16340 VA: 0x180E17D40
	internal void <.cctor>b__2_465(string str) { }

	// RVA: 0xE17DE0 Offset: 0xE163E0 VA: 0x180E17DE0
	internal string <.cctor>b__2_466() { }

	// RVA: 0xE17E40 Offset: 0xE16440 VA: 0x180E17E40
	internal void <.cctor>b__2_467(string str) { }

	// RVA: 0xE17EE0 Offset: 0xE164E0 VA: 0x180E17EE0
	internal string <.cctor>b__2_468() { }

	// RVA: 0xE17F40 Offset: 0xE16540 VA: 0x180E17F40
	internal void <.cctor>b__2_469(string str) { }

	// RVA: 0xE18060 Offset: 0xE16660 VA: 0x180E18060
	internal string <.cctor>b__2_470() { }

	// RVA: 0xE180C0 Offset: 0xE166C0 VA: 0x180E180C0
	internal void <.cctor>b__2_471(string str) { }

	// RVA: 0xE18160 Offset: 0xE16760 VA: 0x180E18160
	internal string <.cctor>b__2_472() { }

	// RVA: 0xE181C0 Offset: 0xE167C0 VA: 0x180E181C0
	internal void <.cctor>b__2_473(string str) { }

	// RVA: 0xE18260 Offset: 0xE16860 VA: 0x180E18260
	internal string <.cctor>b__2_474() { }

	// RVA: 0xE182C0 Offset: 0xE168C0 VA: 0x180E182C0
	internal void <.cctor>b__2_475(string str) { }

	// RVA: 0xE18360 Offset: 0xE16960 VA: 0x180E18360
	internal string <.cctor>b__2_476() { }

	// RVA: 0xE183C0 Offset: 0xE169C0 VA: 0x180E183C0
	internal void <.cctor>b__2_477(string str) { }

	// RVA: 0xE18460 Offset: 0xE16A60 VA: 0x180E18460
	internal void <.cctor>b__2_478(ConsoleSystem.Arg arg) { }

	// RVA: 0xE184C0 Offset: 0xE16AC0 VA: 0x180E184C0
	internal void <.cctor>b__2_479(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18580 Offset: 0xE16B80 VA: 0x180E18580
	internal void <.cctor>b__2_480(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18590 Offset: 0xE16B90 VA: 0x180E18590
	internal void <.cctor>b__2_481(ConsoleSystem.Arg arg) { }

	// RVA: 0xE185F0 Offset: 0xE16BF0 VA: 0x180E185F0
	internal void <.cctor>b__2_482(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18600 Offset: 0xE16C00 VA: 0x180E18600
	internal void <.cctor>b__2_483(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18610 Offset: 0xE16C10 VA: 0x180E18610
	internal void <.cctor>b__2_484(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18620 Offset: 0xE16C20 VA: 0x180E18620
	internal void <.cctor>b__2_485(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18630 Offset: 0xE16C30 VA: 0x180E18630
	internal void <.cctor>b__2_486(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18640 Offset: 0xE16C40 VA: 0x180E18640
	internal void <.cctor>b__2_487(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18650 Offset: 0xE16C50 VA: 0x180E18650
	internal void <.cctor>b__2_488(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18660 Offset: 0xE16C60 VA: 0x180E18660
	internal void <.cctor>b__2_489(ConsoleSystem.Arg arg) { }

	// RVA: 0xE186F0 Offset: 0xE16CF0 VA: 0x180E186F0
	internal void <.cctor>b__2_490(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18700 Offset: 0xE16D00 VA: 0x180E18700
	internal void <.cctor>b__2_491(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18710 Offset: 0xE16D10 VA: 0x180E18710
	internal string <.cctor>b__2_492() { }

	// RVA: 0xE18730 Offset: 0xE16D30 VA: 0x180E18730
	internal void <.cctor>b__2_493(string str) { }

	// RVA: 0xE18790 Offset: 0xE16D90 VA: 0x180E18790
	internal string <.cctor>b__2_494() { }

	// RVA: 0xE187C0 Offset: 0xE16DC0 VA: 0x180E187C0
	internal void <.cctor>b__2_495(string str) { }

	// RVA: 0xE18820 Offset: 0xE16E20 VA: 0x180E18820
	internal string <.cctor>b__2_496() { }

	// RVA: 0xE18850 Offset: 0xE16E50 VA: 0x180E18850
	internal void <.cctor>b__2_497(string str) { }

	// RVA: 0xE188B0 Offset: 0xE16EB0 VA: 0x180E188B0
	internal string <.cctor>b__2_498() { }

	// RVA: 0xE188E0 Offset: 0xE16EE0 VA: 0x180E188E0
	internal void <.cctor>b__2_499(string str) { }

	// RVA: 0xE18A70 Offset: 0xE17070 VA: 0x180E18A70
	internal string <.cctor>b__2_500() { }

	// RVA: 0xE18AE0 Offset: 0xE170E0 VA: 0x180E18AE0
	internal void <.cctor>b__2_501(string str) { }

	// RVA: 0xE18B90 Offset: 0xE17190 VA: 0x180E18B90
	internal string <.cctor>b__2_502() { }

	// RVA: 0xE18C00 Offset: 0xE17200 VA: 0x180E18C00
	internal void <.cctor>b__2_503(string str) { }

	// RVA: 0xE18CB0 Offset: 0xE172B0 VA: 0x180E18CB0
	internal string <.cctor>b__2_504() { }

	// RVA: 0xE18D00 Offset: 0xE17300 VA: 0x180E18D00
	internal void <.cctor>b__2_505(string str) { }

	// RVA: 0xE18D60 Offset: 0xE17360 VA: 0x180E18D60
	internal string <.cctor>b__2_506() { }

	// RVA: 0xE18D80 Offset: 0xE17380 VA: 0x180E18D80
	internal void <.cctor>b__2_507(string str) { }

	// RVA: 0xE18DE0 Offset: 0xE173E0 VA: 0x180E18DE0
	internal void <.cctor>b__2_508(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18E40 Offset: 0xE17440 VA: 0x180E18E40
	internal string <.cctor>b__2_509() { }

	// RVA: 0xE18F70 Offset: 0xE17570 VA: 0x180E18F70
	internal void <.cctor>b__2_510(string str) { }

	// RVA: 0xE18FF0 Offset: 0xE175F0 VA: 0x180E18FF0
	internal string <.cctor>b__2_511() { }

	// RVA: 0xE19050 Offset: 0xE17650 VA: 0x180E19050
	internal void <.cctor>b__2_512(string str) { }

	// RVA: 0xE190F0 Offset: 0xE176F0 VA: 0x180E190F0
	internal void <.cctor>b__2_513(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19140 Offset: 0xE17740 VA: 0x180E19140
	internal string <.cctor>b__2_514() { }

	// RVA: 0xE191A0 Offset: 0xE177A0 VA: 0x180E191A0
	internal void <.cctor>b__2_515(string str) { }

	// RVA: 0xE19240 Offset: 0xE17840 VA: 0x180E19240
	internal string <.cctor>b__2_516() { }

	// RVA: 0xE192A0 Offset: 0xE178A0 VA: 0x180E192A0
	internal void <.cctor>b__2_517(string str) { }

	// RVA: 0xE19320 Offset: 0xE17920 VA: 0x180E19320
	internal string <.cctor>b__2_518() { }

	// RVA: 0xE19380 Offset: 0xE17980 VA: 0x180E19380
	internal void <.cctor>b__2_519(string str) { }

	// RVA: 0xE194B0 Offset: 0xE17AB0 VA: 0x180E194B0
	internal string <.cctor>b__2_520() { }

	// RVA: 0xE19510 Offset: 0xE17B10 VA: 0x180E19510
	internal void <.cctor>b__2_521(string str) { }

	// RVA: 0xE19590 Offset: 0xE17B90 VA: 0x180E19590
	internal void <.cctor>b__2_522(ConsoleSystem.Arg arg) { }

	// RVA: 0xE195E0 Offset: 0xE17BE0 VA: 0x180E195E0
	internal string <.cctor>b__2_523() { }

	// RVA: 0xE19640 Offset: 0xE17C40 VA: 0x180E19640
	internal void <.cctor>b__2_524(string str) { }

	// RVA: 0xE196E0 Offset: 0xE17CE0 VA: 0x180E196E0
	internal string <.cctor>b__2_525() { }

	// RVA: 0xE19740 Offset: 0xE17D40 VA: 0x180E19740
	internal void <.cctor>b__2_526(string str) { }

	// RVA: 0xE197C0 Offset: 0xE17DC0 VA: 0x180E197C0
	internal string <.cctor>b__2_527() { }

	// RVA: 0xE19870 Offset: 0xE17E70 VA: 0x180E19870
	internal void <.cctor>b__2_528(string str) { }

	// RVA: 0xE198F0 Offset: 0xE17EF0 VA: 0x180E198F0
	internal string <.cctor>b__2_529() { }

	// RVA: 0xE19A20 Offset: 0xE18020 VA: 0x180E19A20
	internal void <.cctor>b__2_530(string str) { }

	// RVA: 0xE19AA0 Offset: 0xE180A0 VA: 0x180E19AA0
	internal void <.cctor>b__2_531(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19B00 Offset: 0xE18100 VA: 0x180E19B00
	internal string <.cctor>b__2_532() { }

	// RVA: 0xE19BB0 Offset: 0xE181B0 VA: 0x180E19BB0
	internal void <.cctor>b__2_533(string str) { }

	// RVA: 0xE19C40 Offset: 0xE18240 VA: 0x180E19C40
	internal string <.cctor>b__2_534() { }

	// RVA: 0xE19CA0 Offset: 0xE182A0 VA: 0x180E19CA0
	internal void <.cctor>b__2_535(string str) { }

	// RVA: 0xE19D80 Offset: 0xE18380 VA: 0x180E19D80
	internal void <.cctor>b__2_536(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19DE0 Offset: 0xE183E0 VA: 0x180E19DE0
	internal void <.cctor>b__2_537(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19E40 Offset: 0xE18440 VA: 0x180E19E40
	internal string <.cctor>b__2_538() { }

	// RVA: 0xE19EA0 Offset: 0xE184A0 VA: 0x180E19EA0
	internal void <.cctor>b__2_539(string str) { }

	// RVA: 0xE19FF0 Offset: 0xE185F0 VA: 0x180E19FF0
	internal void <.cctor>b__2_540(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A050 Offset: 0xE18650 VA: 0x180E1A050
	internal string <.cctor>b__2_541() { }

	// RVA: 0xE1A0B0 Offset: 0xE186B0 VA: 0x180E1A0B0
	internal void <.cctor>b__2_542(string str) { }

	// RVA: 0xE1A150 Offset: 0xE18750 VA: 0x180E1A150
	internal string <.cctor>b__2_543() { }

	// RVA: 0xE1A1C0 Offset: 0xE187C0 VA: 0x180E1A1C0
	internal void <.cctor>b__2_544(string str) { }

	// RVA: 0xE1A220 Offset: 0xE18820 VA: 0x180E1A220
	internal string <.cctor>b__2_545() { }

	// RVA: 0xE1A280 Offset: 0xE18880 VA: 0x180E1A280
	internal void <.cctor>b__2_546(string str) { }

	// RVA: 0xE1A320 Offset: 0xE18920 VA: 0x180E1A320
	internal string <.cctor>b__2_547() { }

	// RVA: 0xE1A380 Offset: 0xE18980 VA: 0x180E1A380
	internal void <.cctor>b__2_548(string str) { }

	// RVA: 0xE1A420 Offset: 0xE18A20 VA: 0x180E1A420
	internal void <.cctor>b__2_549(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A500 Offset: 0xE18B00 VA: 0x180E1A500
	internal string <.cctor>b__2_550() { }

	// RVA: 0xE1A560 Offset: 0xE18B60 VA: 0x180E1A560
	internal void <.cctor>b__2_551(string str) { }

	// RVA: 0xE1A600 Offset: 0xE18C00 VA: 0x180E1A600
	internal string <.cctor>b__2_552() { }

	// RVA: 0xE1A660 Offset: 0xE18C60 VA: 0x180E1A660
	internal void <.cctor>b__2_553(string str) { }

	// RVA: 0xE1A700 Offset: 0xE18D00 VA: 0x180E1A700
	internal string <.cctor>b__2_554() { }

	// RVA: 0xE1A7B0 Offset: 0xE18DB0 VA: 0x180E1A7B0
	internal void <.cctor>b__2_555(string str) { }

	// RVA: 0xE1A830 Offset: 0xE18E30 VA: 0x180E1A830
	internal void <.cctor>b__2_556(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A890 Offset: 0xE18E90 VA: 0x180E1A890
	internal void <.cctor>b__2_557(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A8F0 Offset: 0xE18EF0 VA: 0x180E1A8F0
	internal void <.cctor>b__2_558(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A950 Offset: 0xE18F50 VA: 0x180E1A950
	internal string <.cctor>b__2_559() { }

	// RVA: 0xE1AA60 Offset: 0xE19060 VA: 0x180E1AA60
	internal void <.cctor>b__2_560(string str) { }

	// RVA: 0xE1AB00 Offset: 0xE19100 VA: 0x180E1AB00
	internal string <.cctor>b__2_561() { }

	// RVA: 0xE1ABB0 Offset: 0xE191B0 VA: 0x180E1ABB0
	internal void <.cctor>b__2_562(string str) { }

	// RVA: 0xE1AC90 Offset: 0xE19290 VA: 0x180E1AC90
	internal string <.cctor>b__2_563() { }

	// RVA: 0xE1ACF0 Offset: 0xE192F0 VA: 0x180E1ACF0
	internal void <.cctor>b__2_564(string str) { }

	// RVA: 0xE1AD90 Offset: 0xE19390 VA: 0x180E1AD90
	internal string <.cctor>b__2_565() { }

	// RVA: 0xE1ADF0 Offset: 0xE193F0 VA: 0x180E1ADF0
	internal void <.cctor>b__2_566(string str) { }

	// RVA: 0xE1AE90 Offset: 0xE19490 VA: 0x180E1AE90
	internal string <.cctor>b__2_567() { }

	// RVA: 0xE1AEF0 Offset: 0xE194F0 VA: 0x180E1AEF0
	internal void <.cctor>b__2_568(string str) { }

	// RVA: 0xE1AF90 Offset: 0xE19590 VA: 0x180E1AF90
	internal string <.cctor>b__2_569() { }

	// RVA: 0xE1B070 Offset: 0xE19670 VA: 0x180E1B070
	internal void <.cctor>b__2_570(string str) { }

	// RVA: 0xE1B110 Offset: 0xE19710 VA: 0x180E1B110
	internal string <.cctor>b__2_571() { }

	// RVA: 0xE1B170 Offset: 0xE19770 VA: 0x180E1B170
	internal void <.cctor>b__2_572(string str) { }

	// RVA: 0xE1B210 Offset: 0xE19810 VA: 0x180E1B210
	internal void <.cctor>b__2_573(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B270 Offset: 0xE19870 VA: 0x180E1B270
	internal string <.cctor>b__2_574() { }

	// RVA: 0xE1B2D0 Offset: 0xE198D0 VA: 0x180E1B2D0
	internal void <.cctor>b__2_575(string str) { }

	// RVA: 0xE1B370 Offset: 0xE19970 VA: 0x180E1B370
	internal void <.cctor>b__2_576(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B3D0 Offset: 0xE199D0 VA: 0x180E1B3D0
	internal void <.cctor>b__2_577(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B430 Offset: 0xE19A30 VA: 0x180E1B430
	internal void <.cctor>b__2_578(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B490 Offset: 0xE19A90 VA: 0x180E1B490
	internal void <.cctor>b__2_579(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B5A0 Offset: 0xE19BA0 VA: 0x180E1B5A0
	internal string <.cctor>b__2_580() { }

	// RVA: 0xE1B600 Offset: 0xE19C00 VA: 0x180E1B600
	internal void <.cctor>b__2_581(string str) { }

	// RVA: 0xE1B6A0 Offset: 0xE19CA0 VA: 0x180E1B6A0
	internal string <.cctor>b__2_582() { }

	// RVA: 0xE1B700 Offset: 0xE19D00 VA: 0x180E1B700
	internal void <.cctor>b__2_583(string str) { }

	// RVA: 0xE1B7B0 Offset: 0xE19DB0 VA: 0x180E1B7B0
	internal void <.cctor>b__2_584(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B810 Offset: 0xE19E10 VA: 0x180E1B810
	internal string <.cctor>b__2_585() { }

	// RVA: 0xE1B870 Offset: 0xE19E70 VA: 0x180E1B870
	internal void <.cctor>b__2_586(string str) { }

	// RVA: 0xE1B910 Offset: 0xE19F10 VA: 0x180E1B910
	internal void <.cctor>b__2_587(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B960 Offset: 0xE19F60 VA: 0x180E1B960
	internal string <.cctor>b__2_588() { }

	// RVA: 0xE1BA10 Offset: 0xE1A010 VA: 0x180E1BA10
	internal void <.cctor>b__2_589(string str) { }

	// RVA: 0xE1BB10 Offset: 0xE1A110 VA: 0x180E1BB10
	internal string <.cctor>b__2_590() { }

	// RVA: 0xE1BB70 Offset: 0xE1A170 VA: 0x180E1BB70
	internal void <.cctor>b__2_591(string str) { }

	// RVA: 0xE1BC10 Offset: 0xE1A210 VA: 0x180E1BC10
	internal string <.cctor>b__2_592() { }

	// RVA: 0xE1BCC0 Offset: 0xE1A2C0 VA: 0x180E1BCC0
	internal void <.cctor>b__2_593(string str) { }

	// RVA: 0xE1BD40 Offset: 0xE1A340 VA: 0x180E1BD40
	internal string <.cctor>b__2_594() { }

	// RVA: 0xE1BDA0 Offset: 0xE1A3A0 VA: 0x180E1BDA0
	internal void <.cctor>b__2_595(string str) { }

	// RVA: 0xE1BE40 Offset: 0xE1A440 VA: 0x180E1BE40
	internal string <.cctor>b__2_596() { }

	// RVA: 0xE1BEA0 Offset: 0xE1A4A0 VA: 0x180E1BEA0
	internal void <.cctor>b__2_597(string str) { }

	// RVA: 0xE1BF40 Offset: 0xE1A540 VA: 0x180E1BF40
	internal string <.cctor>b__2_598() { }

	// RVA: 0xE1BFA0 Offset: 0xE1A5A0 VA: 0x180E1BFA0
	internal void <.cctor>b__2_599(string str) { }

	// RVA: 0xE1C150 Offset: 0xE1A750 VA: 0x180E1C150
	internal string <.cctor>b__2_600() { }

	// RVA: 0xE1C1B0 Offset: 0xE1A7B0 VA: 0x180E1C1B0
	internal void <.cctor>b__2_601(string str) { }

	// RVA: 0xE1C250 Offset: 0xE1A850 VA: 0x180E1C250
	internal string <.cctor>b__2_602() { }

	// RVA: 0xE1C2B0 Offset: 0xE1A8B0 VA: 0x180E1C2B0
	internal void <.cctor>b__2_603(string str) { }

	// RVA: 0xE1C350 Offset: 0xE1A950 VA: 0x180E1C350
	internal string <.cctor>b__2_604() { }

	// RVA: 0xE1C3B0 Offset: 0xE1A9B0 VA: 0x180E1C3B0
	internal void <.cctor>b__2_605(string str) { }

	// RVA: 0xE1C450 Offset: 0xE1AA50 VA: 0x180E1C450
	internal string <.cctor>b__2_606() { }

	// RVA: 0xE1C4B0 Offset: 0xE1AAB0 VA: 0x180E1C4B0
	internal void <.cctor>b__2_607(string str) { }

	// RVA: 0xE1C550 Offset: 0xE1AB50 VA: 0x180E1C550
	internal string <.cctor>b__2_608() { }

	// RVA: 0xE1C5B0 Offset: 0xE1ABB0 VA: 0x180E1C5B0
	internal void <.cctor>b__2_609(string str) { }

	// RVA: 0xE1C6E0 Offset: 0xE1ACE0 VA: 0x180E1C6E0
	internal string <.cctor>b__2_610() { }

	// RVA: 0xE1C740 Offset: 0xE1AD40 VA: 0x180E1C740
	internal void <.cctor>b__2_611(string str) { }

	// RVA: 0xE1C7F0 Offset: 0xE1ADF0 VA: 0x180E1C7F0
	internal string <.cctor>b__2_612() { }

	// RVA: 0xE1C850 Offset: 0xE1AE50 VA: 0x180E1C850
	internal void <.cctor>b__2_613(string str) { }

	// RVA: 0xE1C8F0 Offset: 0xE1AEF0 VA: 0x180E1C8F0
	internal string <.cctor>b__2_614() { }

	// RVA: 0xE1C950 Offset: 0xE1AF50 VA: 0x180E1C950
	internal void <.cctor>b__2_615(string str) { }

	// RVA: 0xE1CA00 Offset: 0xE1B000 VA: 0x180E1CA00
	internal void <.cctor>b__2_616(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CA60 Offset: 0xE1B060 VA: 0x180E1CA60
	internal void <.cctor>b__2_617(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CAC0 Offset: 0xE1B0C0 VA: 0x180E1CAC0
	internal string <.cctor>b__2_618() { }

	// RVA: 0xE1CB20 Offset: 0xE1B120 VA: 0x180E1CB20
	internal void <.cctor>b__2_619(string str) { }

	// RVA: 0xE1CC80 Offset: 0xE1B280 VA: 0x180E1CC80
	internal string <.cctor>b__2_620() { }

	// RVA: 0xE1CCE0 Offset: 0xE1B2E0 VA: 0x180E1CCE0
	internal void <.cctor>b__2_621(string str) { }

	// RVA: 0xE1CD80 Offset: 0xE1B380 VA: 0x180E1CD80
	internal void <.cctor>b__2_622(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CDE0 Offset: 0xE1B3E0 VA: 0x180E1CDE0
	internal string <.cctor>b__2_623() { }

	// RVA: 0xE1CE40 Offset: 0xE1B440 VA: 0x180E1CE40
	internal void <.cctor>b__2_624(string str) { }

	// RVA: 0xE1CEF0 Offset: 0xE1B4F0 VA: 0x180E1CEF0
	internal string <.cctor>b__2_625() { }

	// RVA: 0xE1CFA0 Offset: 0xE1B5A0 VA: 0x180E1CFA0
	internal void <.cctor>b__2_626(string str) { }

	// RVA: 0xE1D030 Offset: 0xE1B630 VA: 0x180E1D030
	internal string <.cctor>b__2_627() { }

	// RVA: 0xE1D090 Offset: 0xE1B690 VA: 0x180E1D090
	internal void <.cctor>b__2_628(string str) { }

	// RVA: 0xE1D130 Offset: 0xE1B730 VA: 0x180E1D130
	internal string <.cctor>b__2_629() { }

	// RVA: 0xE1D210 Offset: 0xE1B810 VA: 0x180E1D210
	internal void <.cctor>b__2_630(string str) { }

	// RVA: 0xE1D2B0 Offset: 0xE1B8B0 VA: 0x180E1D2B0
	internal string <.cctor>b__2_631() { }

	// RVA: 0xE1D360 Offset: 0xE1B960 VA: 0x180E1D360
	internal void <.cctor>b__2_632(string str) { }

	// RVA: 0xE1D3E0 Offset: 0xE1B9E0 VA: 0x180E1D3E0
	internal string <.cctor>b__2_633() { }

	// RVA: 0xE1D480 Offset: 0xE1BA80 VA: 0x180E1D480
	internal void <.cctor>b__2_634(string str) { }

	// RVA: 0xE1D540 Offset: 0xE1BB40 VA: 0x180E1D540
	internal string <.cctor>b__2_635() { }

	// RVA: 0xE1D5F0 Offset: 0xE1BBF0 VA: 0x180E1D5F0
	internal void <.cctor>b__2_636(string str) { }

	// RVA: 0xE1D6C0 Offset: 0xE1BCC0 VA: 0x180E1D6C0
	internal string <.cctor>b__2_637() { }

	// RVA: 0xE1D760 Offset: 0xE1BD60 VA: 0x180E1D760
	internal void <.cctor>b__2_638(string str) { }

	// RVA: 0xE1D820 Offset: 0xE1BE20 VA: 0x180E1D820
	internal string <.cctor>b__2_639() { }

	// RVA: 0xE1D930 Offset: 0xE1BF30 VA: 0x180E1D930
	internal void <.cctor>b__2_640(string str) { }

	// RVA: 0xE1D9F0 Offset: 0xE1BFF0 VA: 0x180E1D9F0
	internal string <.cctor>b__2_641() { }

	// RVA: 0xE1DA50 Offset: 0xE1C050 VA: 0x180E1DA50
	internal void <.cctor>b__2_642(string str) { }

	// RVA: 0xE1DAE0 Offset: 0xE1C0E0 VA: 0x180E1DAE0
	internal string <.cctor>b__2_643() { }

	// RVA: 0xE1DB40 Offset: 0xE1C140 VA: 0x180E1DB40
	internal void <.cctor>b__2_644(string str) { }

	// RVA: 0xE1DBC0 Offset: 0xE1C1C0 VA: 0x180E1DBC0
	internal string <.cctor>b__2_645() { }

	// RVA: 0xE1DC70 Offset: 0xE1C270 VA: 0x180E1DC70
	internal void <.cctor>b__2_646(string str) { }

	// RVA: 0xE1DCF0 Offset: 0xE1C2F0 VA: 0x180E1DCF0
	internal string <.cctor>b__2_647() { }

	// RVA: 0xE1DD50 Offset: 0xE1C350 VA: 0x180E1DD50
	internal void <.cctor>b__2_648(string str) { }

	// RVA: 0xE1DDD0 Offset: 0xE1C3D0 VA: 0x180E1DDD0
	internal string <.cctor>b__2_649() { }

	// RVA: 0xE1DEB0 Offset: 0xE1C4B0 VA: 0x180E1DEB0
	internal void <.cctor>b__2_650(string str) { }

	// RVA: 0xE1DF50 Offset: 0xE1C550 VA: 0x180E1DF50
	internal string <.cctor>b__2_651() { }

	// RVA: 0xE1DFB0 Offset: 0xE1C5B0 VA: 0x180E1DFB0
	internal void <.cctor>b__2_652(string str) { }

	// RVA: 0xE1E050 Offset: 0xE1C650 VA: 0x180E1E050
	internal string <.cctor>b__2_653() { }

	// RVA: 0xE1E0B0 Offset: 0xE1C6B0 VA: 0x180E1E0B0
	internal void <.cctor>b__2_654(string str) { }

	// RVA: 0xE1E150 Offset: 0xE1C750 VA: 0x180E1E150
	internal string <.cctor>b__2_655() { }

	// RVA: 0xE1E200 Offset: 0xE1C800 VA: 0x180E1E200
	internal void <.cctor>b__2_656(string str) { }

	// RVA: 0xE1E290 Offset: 0xE1C890 VA: 0x180E1E290
	internal void <.cctor>b__2_657(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E2F0 Offset: 0xE1C8F0 VA: 0x180E1E2F0
	internal void <.cctor>b__2_658(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E350 Offset: 0xE1C950 VA: 0x180E1E350
	internal void <.cctor>b__2_659(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E450 Offset: 0xE1CA50 VA: 0x180E1E450
	internal string <.cctor>b__2_660() { }

	// RVA: 0xE1E500 Offset: 0xE1CB00 VA: 0x180E1E500
	internal void <.cctor>b__2_661(string str) { }

	// RVA: 0xE1E580 Offset: 0xE1CB80 VA: 0x180E1E580
	internal void <.cctor>b__2_662(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E5E0 Offset: 0xE1CBE0 VA: 0x180E1E5E0
	internal string <.cctor>b__2_663() { }

	// RVA: 0xE1E690 Offset: 0xE1CC90 VA: 0x180E1E690
	internal void <.cctor>b__2_664(string str) { }

	// RVA: 0xE1E710 Offset: 0xE1CD10 VA: 0x180E1E710
	internal void <.cctor>b__2_665(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E770 Offset: 0xE1CD70 VA: 0x180E1E770
	internal string <.cctor>b__2_666() { }

	// RVA: 0xE1E7D0 Offset: 0xE1CDD0 VA: 0x180E1E7D0
	internal void <.cctor>b__2_667(string str) { }

	// RVA: 0xE1E850 Offset: 0xE1CE50 VA: 0x180E1E850
	internal string <.cctor>b__2_668() { }

	// RVA: 0xE1E8B0 Offset: 0xE1CEB0 VA: 0x180E1E8B0
	internal void <.cctor>b__2_669(string str) { }

	// RVA: 0xE1E9B0 Offset: 0xE1CFB0 VA: 0x180E1E9B0
	internal string <.cctor>b__2_670() { }

	// RVA: 0xE1EA60 Offset: 0xE1D060 VA: 0x180E1EA60
	internal void <.cctor>b__2_671(string str) { }

	// RVA: 0xE1EAF0 Offset: 0xE1D0F0 VA: 0x180E1EAF0
	internal string <.cctor>b__2_672() { }

	// RVA: 0xE1EB50 Offset: 0xE1D150 VA: 0x180E1EB50
	internal void <.cctor>b__2_673(string str) { }

	// RVA: 0xE1EBF0 Offset: 0xE1D1F0 VA: 0x180E1EBF0
	internal string <.cctor>b__2_674() { }

	// RVA: 0xE1EC50 Offset: 0xE1D250 VA: 0x180E1EC50
	internal void <.cctor>b__2_675(string str) { }

	// RVA: 0xE1ECF0 Offset: 0xE1D2F0 VA: 0x180E1ECF0
	internal string <.cctor>b__2_676() { }

	// RVA: 0xE1EDA0 Offset: 0xE1D3A0 VA: 0x180E1EDA0
	internal void <.cctor>b__2_677(string str) { }

	// RVA: 0xE1EE20 Offset: 0xE1D420 VA: 0x180E1EE20
	internal string <.cctor>b__2_678() { }

	// RVA: 0xE1EE80 Offset: 0xE1D480 VA: 0x180E1EE80
	internal void <.cctor>b__2_679(string str) { }

	// RVA: 0xE1EFB0 Offset: 0xE1D5B0 VA: 0x180E1EFB0
	internal string <.cctor>b__2_680() { }

	// RVA: 0xE1F060 Offset: 0xE1D660 VA: 0x180E1F060
	internal void <.cctor>b__2_681(string str) { }

	// RVA: 0xE1F0F0 Offset: 0xE1D6F0 VA: 0x180E1F0F0
	internal string <.cctor>b__2_682() { }

	// RVA: 0xE1F150 Offset: 0xE1D750 VA: 0x180E1F150
	internal void <.cctor>b__2_683(string str) { }

	// RVA: 0xE1F1F0 Offset: 0xE1D7F0 VA: 0x180E1F1F0
	internal string <.cctor>b__2_684() { }

	// RVA: 0xE1F250 Offset: 0xE1D850 VA: 0x180E1F250
	internal void <.cctor>b__2_685(string str) { }

	// RVA: 0xE1F2F0 Offset: 0xE1D8F0 VA: 0x180E1F2F0
	internal string <.cctor>b__2_686() { }

	// RVA: 0xE1F350 Offset: 0xE1D950 VA: 0x180E1F350
	internal void <.cctor>b__2_687(string str) { }

	// RVA: 0xE1F3F0 Offset: 0xE1D9F0 VA: 0x180E1F3F0
	internal string <.cctor>b__2_688() { }

	// RVA: 0xE1F450 Offset: 0xE1DA50 VA: 0x180E1F450
	internal void <.cctor>b__2_689(string str) { }

	// RVA: 0xE1F570 Offset: 0xE1DB70 VA: 0x180E1F570
	internal string <.cctor>b__2_690() { }

	// RVA: 0xE1F5D0 Offset: 0xE1DBD0 VA: 0x180E1F5D0
	internal void <.cctor>b__2_691(string str) { }

	// RVA: 0xE1F670 Offset: 0xE1DC70 VA: 0x180E1F670
	internal string <.cctor>b__2_692() { }

	// RVA: 0xE1F6D0 Offset: 0xE1DCD0 VA: 0x180E1F6D0
	internal void <.cctor>b__2_693(string str) { }

	// RVA: 0xE1F750 Offset: 0xE1DD50 VA: 0x180E1F750
	internal string <.cctor>b__2_694() { }

	// RVA: 0xE1F800 Offset: 0xE1DE00 VA: 0x180E1F800
	internal void <.cctor>b__2_695(string str) { }

	// RVA: 0xE1F880 Offset: 0xE1DE80 VA: 0x180E1F880
	internal string <.cctor>b__2_696() { }

	// RVA: 0xE1F8E0 Offset: 0xE1DEE0 VA: 0x180E1F8E0
	internal void <.cctor>b__2_697(string str) { }

	// RVA: 0xE1F980 Offset: 0xE1DF80 VA: 0x180E1F980
	internal string <.cctor>b__2_698() { }

	// RVA: 0xE1FA30 Offset: 0xE1E030 VA: 0x180E1FA30
	internal void <.cctor>b__2_699(string str) { }

	// RVA: 0xE1FBF0 Offset: 0xE1E1F0 VA: 0x180E1FBF0
	internal string <.cctor>b__2_700() { }

	// RVA: 0xE1FCA0 Offset: 0xE1E2A0 VA: 0x180E1FCA0
	internal void <.cctor>b__2_701(string str) { }

	// RVA: 0xE1FD20 Offset: 0xE1E320 VA: 0x180E1FD20
	internal void <.cctor>b__2_702(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1FD80 Offset: 0xE1E380 VA: 0x180E1FD80
	internal string <.cctor>b__2_703() { }

	// RVA: 0xE1FE30 Offset: 0xE1E430 VA: 0x180E1FE30
	internal void <.cctor>b__2_704(string str) { }

	// RVA: 0xE1FEC0 Offset: 0xE1E4C0 VA: 0x180E1FEC0
	internal string <.cctor>b__2_705() { }

	// RVA: 0xE1FF70 Offset: 0xE1E570 VA: 0x180E1FF70
	internal void <.cctor>b__2_706(string str) { }

	// RVA: 0xE20000 Offset: 0xE1E600 VA: 0x180E20000
	internal string <.cctor>b__2_707() { }

	// RVA: 0xE20080 Offset: 0xE1E680 VA: 0x180E20080
	internal void <.cctor>b__2_708(string str) { }

	// RVA: 0xE200F0 Offset: 0xE1E6F0 VA: 0x180E200F0
	internal string <.cctor>b__2_709() { }

	// RVA: 0xE201F0 Offset: 0xE1E7F0 VA: 0x180E201F0
	internal void <.cctor>b__2_710(string str) { }

	// RVA: 0xE20250 Offset: 0xE1E850 VA: 0x180E20250
	internal void <.cctor>b__2_711(ConsoleSystem.Arg arg) { }

	// RVA: 0xE202B0 Offset: 0xE1E8B0 VA: 0x180E202B0
	internal string <.cctor>b__2_712() { }

	// RVA: 0xE20330 Offset: 0xE1E930 VA: 0x180E20330
	internal void <.cctor>b__2_713(string str) { }

	// RVA: 0xE203A0 Offset: 0xE1E9A0 VA: 0x180E203A0
	internal string <.cctor>b__2_714() { }

	// RVA: 0xE20420 Offset: 0xE1EA20 VA: 0x180E20420
	internal void <.cctor>b__2_715(string str) { }

	// RVA: 0xE20490 Offset: 0xE1EA90 VA: 0x180E20490
	internal string <.cctor>b__2_716() { }

	// RVA: 0xE20510 Offset: 0xE1EB10 VA: 0x180E20510
	internal void <.cctor>b__2_717(string str) { }

	// RVA: 0xE20580 Offset: 0xE1EB80 VA: 0x180E20580
	internal string <.cctor>b__2_718() { }

	// RVA: 0xE205E0 Offset: 0xE1EBE0 VA: 0x180E205E0
	internal void <.cctor>b__2_719(string str) { }

	// RVA: 0xE20730 Offset: 0xE1ED30 VA: 0x180E20730
	internal string <.cctor>b__2_720() { }

	// RVA: 0xE20790 Offset: 0xE1ED90 VA: 0x180E20790
	internal void <.cctor>b__2_721(string str) { }

	// RVA: 0xE20830 Offset: 0xE1EE30 VA: 0x180E20830
	internal string <.cctor>b__2_722() { }

	// RVA: 0xE20890 Offset: 0xE1EE90 VA: 0x180E20890
	internal void <.cctor>b__2_723(string str) { }

	// RVA: 0xE20940 Offset: 0xE1EF40 VA: 0x180E20940
	internal string <.cctor>b__2_724() { }

	// RVA: 0xE209A0 Offset: 0xE1EFA0 VA: 0x180E209A0
	internal void <.cctor>b__2_725(string str) { }

	// RVA: 0xE20A40 Offset: 0xE1F040 VA: 0x180E20A40
	internal string <.cctor>b__2_726() { }

	// RVA: 0xE20AA0 Offset: 0xE1F0A0 VA: 0x180E20AA0
	internal void <.cctor>b__2_727(string str) { }

	// RVA: 0xE20B40 Offset: 0xE1F140 VA: 0x180E20B40
	internal void <.cctor>b__2_728(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20BB0 Offset: 0xE1F1B0 VA: 0x180E20BB0
	internal void <.cctor>b__2_729(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20C90 Offset: 0xE1F290 VA: 0x180E20C90
	internal string <.cctor>b__2_730() { }

	// RVA: 0xE20CF0 Offset: 0xE1F2F0 VA: 0x180E20CF0
	internal void <.cctor>b__2_731(string str) { }

	// RVA: 0xE20D90 Offset: 0xE1F390 VA: 0x180E20D90
	internal string <.cctor>b__2_732() { }

	// RVA: 0xE20DF0 Offset: 0xE1F3F0 VA: 0x180E20DF0
	internal void <.cctor>b__2_733(string str) { }

	// RVA: 0xE20EA0 Offset: 0xE1F4A0 VA: 0x180E20EA0
	internal string <.cctor>b__2_734() { }

	// RVA: 0xE20F00 Offset: 0xE1F500 VA: 0x180E20F00
	internal void <.cctor>b__2_735(string str) { }

	// RVA: 0xE20FB0 Offset: 0xE1F5B0 VA: 0x180E20FB0
	internal string <.cctor>b__2_736() { }

	// RVA: 0xE21010 Offset: 0xE1F610 VA: 0x180E21010
	internal void <.cctor>b__2_737(string str) { }

	// RVA: 0xE210B0 Offset: 0xE1F6B0 VA: 0x180E210B0
	internal string <.cctor>b__2_738() { }

	// RVA: 0xE21110 Offset: 0xE1F710 VA: 0x180E21110
	internal void <.cctor>b__2_739(string str) { }

	// RVA: 0xE21260 Offset: 0xE1F860 VA: 0x180E21260
	internal string <.cctor>b__2_740() { }

	// RVA: 0xE212C0 Offset: 0xE1F8C0 VA: 0x180E212C0
	internal void <.cctor>b__2_741(string str) { }

	// RVA: 0xE21360 Offset: 0xE1F960 VA: 0x180E21360
	internal string <.cctor>b__2_742() { }

	// RVA: 0xE213C0 Offset: 0xE1F9C0 VA: 0x180E213C0
	internal void <.cctor>b__2_743(string str) { }

	// RVA: 0xE21470 Offset: 0xE1FA70 VA: 0x180E21470
	internal void <.cctor>b__2_744(ConsoleSystem.Arg arg) { }

	// RVA: 0xE214D0 Offset: 0xE1FAD0 VA: 0x180E214D0
	internal void <.cctor>b__2_745(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21530 Offset: 0xE1FB30 VA: 0x180E21530
	internal string <.cctor>b__2_746() { }

	// RVA: 0xE215E0 Offset: 0xE1FBE0 VA: 0x180E215E0
	internal void <.cctor>b__2_747(string str) { }

	// RVA: 0xE21660 Offset: 0xE1FC60 VA: 0x180E21660
	internal string <.cctor>b__2_748() { }

	// RVA: 0xE21710 Offset: 0xE1FD10 VA: 0x180E21710
	internal void <.cctor>b__2_749(string str) { }

	// RVA: 0xE21870 Offset: 0xE1FE70 VA: 0x180E21870
	internal void <.cctor>b__2_750(ConsoleSystem.Arg arg) { }

	// RVA: 0xE218D0 Offset: 0xE1FED0 VA: 0x180E218D0
	internal void <.cctor>b__2_751(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21930 Offset: 0xE1FF30 VA: 0x180E21930
	internal void <.cctor>b__2_752(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21990 Offset: 0xE1FF90 VA: 0x180E21990
	internal void <.cctor>b__2_753(ConsoleSystem.Arg arg) { }

	// RVA: 0xE219F0 Offset: 0xE1FFF0 VA: 0x180E219F0
	internal void <.cctor>b__2_754(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21A50 Offset: 0xE20050 VA: 0x180E21A50
	internal void <.cctor>b__2_755(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21AB0 Offset: 0xE200B0 VA: 0x180E21AB0
	internal void <.cctor>b__2_756(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21B10 Offset: 0xE20110 VA: 0x180E21B10
	internal string <.cctor>b__2_757() { }

	// RVA: 0xE21B70 Offset: 0xE20170 VA: 0x180E21B70
	internal void <.cctor>b__2_758(string str) { }

	// RVA: 0xE21C10 Offset: 0xE20210 VA: 0x180E21C10
	internal void <.cctor>b__2_759(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21D20 Offset: 0xE20320 VA: 0x180E21D20
	internal void <.cctor>b__2_760(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21D80 Offset: 0xE20380 VA: 0x180E21D80
	internal void <.cctor>b__2_761(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21DE0 Offset: 0xE203E0 VA: 0x180E21DE0
	internal void <.cctor>b__2_762(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21E40 Offset: 0xE20440 VA: 0x180E21E40
	internal void <.cctor>b__2_763(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21E90 Offset: 0xE20490 VA: 0x180E21E90
	internal void <.cctor>b__2_764(ConsoleSystem.Arg arg) { }

	// RVA: 0xE21EE0 Offset: 0xE204E0 VA: 0x180E21EE0
	internal string <.cctor>b__2_765() { }

	// RVA: 0xE21F90 Offset: 0xE20590 VA: 0x180E21F90
	internal void <.cctor>b__2_766(string str) { }

	// RVA: 0xE22020 Offset: 0xE20620 VA: 0x180E22020
	internal void <.cctor>b__2_767(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22080 Offset: 0xE20680 VA: 0x180E22080
	internal void <.cctor>b__2_768(ConsoleSystem.Arg arg) { }

	// RVA: 0xE220D0 Offset: 0xE206D0 VA: 0x180E220D0
	internal void <.cctor>b__2_769(ConsoleSystem.Arg arg) { }

	// RVA: 0xE221A0 Offset: 0xE207A0 VA: 0x180E221A0
	internal void <.cctor>b__2_770(ConsoleSystem.Arg arg) { }

	// RVA: 0xE221F0 Offset: 0xE207F0 VA: 0x180E221F0
	internal void <.cctor>b__2_771(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22200 Offset: 0xE20800 VA: 0x180E22200
	internal void <.cctor>b__2_772(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22210 Offset: 0xE20810 VA: 0x180E22210
	internal void <.cctor>b__2_773(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22220 Offset: 0xE20820 VA: 0x180E22220
	internal void <.cctor>b__2_774(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22230 Offset: 0xE20830 VA: 0x180E22230
	internal string <.cctor>b__2_775() { }

	// RVA: 0xE22290 Offset: 0xE20890 VA: 0x180E22290
	internal void <.cctor>b__2_776(string str) { }

	// RVA: 0xE22330 Offset: 0xE20930 VA: 0x180E22330
	internal string <.cctor>b__2_777() { }

	// RVA: 0xE22390 Offset: 0xE20990 VA: 0x180E22390
	internal void <.cctor>b__2_778(string str) { }

	// RVA: 0xE22440 Offset: 0xE20A40 VA: 0x180E22440
	internal string <.cctor>b__2_779() { }

	// RVA: 0xE22550 Offset: 0xE20B50 VA: 0x180E22550
	internal void <.cctor>b__2_780(string str) { }

	// RVA: 0xE22600 Offset: 0xE20C00 VA: 0x180E22600
	internal string <.cctor>b__2_781() { }

	// RVA: 0xE22660 Offset: 0xE20C60 VA: 0x180E22660
	internal void <.cctor>b__2_782(string str) { }

	// RVA: 0xE22710 Offset: 0xE20D10 VA: 0x180E22710
	internal string <.cctor>b__2_783() { }

	// RVA: 0xE22770 Offset: 0xE20D70 VA: 0x180E22770
	internal void <.cctor>b__2_784(string str) { }

	// RVA: 0xE22800 Offset: 0xE20E00 VA: 0x180E22800
	internal string <.cctor>b__2_785() { }

	// RVA: 0xE228A0 Offset: 0xE20EA0 VA: 0x180E228A0
	internal void <.cctor>b__2_786(string str) { }

	// RVA: 0xE22960 Offset: 0xE20F60 VA: 0x180E22960
	internal string <.cctor>b__2_787() { }

	// RVA: 0xE229C0 Offset: 0xE20FC0 VA: 0x180E229C0
	internal void <.cctor>b__2_788(string str) { }

	// RVA: 0xE22A60 Offset: 0xE21060 VA: 0x180E22A60
	internal string <.cctor>b__2_789() { }

	// RVA: 0xE22B40 Offset: 0xE21140 VA: 0x180E22B40
	internal void <.cctor>b__2_790(string str) { }

	// RVA: 0xE22BD0 Offset: 0xE211D0 VA: 0x180E22BD0
	internal string <.cctor>b__2_791() { }

	// RVA: 0xE22C30 Offset: 0xE21230 VA: 0x180E22C30
	internal void <.cctor>b__2_792(string str) { }

	// RVA: 0xE22CC0 Offset: 0xE212C0 VA: 0x180E22CC0
	internal string <.cctor>b__2_793() { }

	// RVA: 0xE22D20 Offset: 0xE21320 VA: 0x180E22D20
	internal void <.cctor>b__2_794(string str) { }

	// RVA: 0xE22DB0 Offset: 0xE213B0 VA: 0x180E22DB0
	internal string <.cctor>b__2_795() { }

	// RVA: 0xE22E10 Offset: 0xE21410 VA: 0x180E22E10
	internal void <.cctor>b__2_796(string str) { }

	// RVA: 0xE22EA0 Offset: 0xE214A0 VA: 0x180E22EA0
	internal string <.cctor>b__2_797() { }

	// RVA: 0xE22F40 Offset: 0xE21540 VA: 0x180E22F40
	internal void <.cctor>b__2_798(string str) { }

	// RVA: 0xE22FC0 Offset: 0xE215C0 VA: 0x180E22FC0
	internal void <.cctor>b__2_799(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23140 Offset: 0xE21740 VA: 0x180E23140
	internal void <.cctor>b__2_800(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23170 Offset: 0xE21770 VA: 0x180E23170
	internal void <.cctor>b__2_801(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23180 Offset: 0xE21780 VA: 0x180E23180
	internal void <.cctor>b__2_802(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23190 Offset: 0xE21790 VA: 0x180E23190
	internal void <.cctor>b__2_803(ConsoleSystem.Arg arg) { }

	// RVA: 0xE231A0 Offset: 0xE217A0 VA: 0x180E231A0
	internal string <.cctor>b__2_804() { }

	// RVA: 0xE23250 Offset: 0xE21850 VA: 0x180E23250
	internal void <.cctor>b__2_805(string str) { }

	// RVA: 0xE232E0 Offset: 0xE218E0 VA: 0x180E232E0
	internal string <.cctor>b__2_806() { }

	// RVA: 0xE23340 Offset: 0xE21940 VA: 0x180E23340
	internal void <.cctor>b__2_807(string str) { }

	// RVA: 0xE233E0 Offset: 0xE219E0 VA: 0x180E233E0
	internal void <.cctor>b__2_808(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23440 Offset: 0xE21A40 VA: 0x180E23440
	internal string <.cctor>b__2_809() { }

	// RVA: 0xE23520 Offset: 0xE21B20 VA: 0x180E23520
	internal void <.cctor>b__2_810(string str) { }

	// RVA: 0xE235C0 Offset: 0xE21BC0 VA: 0x180E235C0
	internal string <.cctor>b__2_811() { }

	// RVA: 0xE23620 Offset: 0xE21C20 VA: 0x180E23620
	internal void <.cctor>b__2_812(string str) { }

	// RVA: 0xE236C0 Offset: 0xE21CC0 VA: 0x180E236C0
	internal string <.cctor>b__2_813() { }

	// RVA: 0xE23720 Offset: 0xE21D20 VA: 0x180E23720
	internal void <.cctor>b__2_814(string str) { }

	// RVA: 0xE237C0 Offset: 0xE21DC0 VA: 0x180E237C0
	internal string <.cctor>b__2_815() { }

	// RVA: 0xE23820 Offset: 0xE21E20 VA: 0x180E23820
	internal void <.cctor>b__2_816(string str) { }

	// RVA: 0xE238C0 Offset: 0xE21EC0 VA: 0x180E238C0
	internal string <.cctor>b__2_817() { }

	// RVA: 0xE23940 Offset: 0xE21F40 VA: 0x180E23940
	internal void <.cctor>b__2_818(string str) { }

	// RVA: 0xE239B0 Offset: 0xE21FB0 VA: 0x180E239B0
	internal string <.cctor>b__2_819() { }

	// RVA: 0xE23AE0 Offset: 0xE220E0 VA: 0x180E23AE0
	internal void <.cctor>b__2_820(string str) { }

	// RVA: 0xE23B50 Offset: 0xE22150 VA: 0x180E23B50
	internal string <.cctor>b__2_821() { }

	// RVA: 0xE23BB0 Offset: 0xE221B0 VA: 0x180E23BB0
	internal void <.cctor>b__2_822(string str) { }

	// RVA: 0xE23C60 Offset: 0xE22260 VA: 0x180E23C60
	internal void <.cctor>b__2_823(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23C70 Offset: 0xE22270 VA: 0x180E23C70
	internal void <.cctor>b__2_824(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23C80 Offset: 0xE22280 VA: 0x180E23C80
	internal void <.cctor>b__2_825(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23C90 Offset: 0xE22290 VA: 0x180E23C90
	internal void <.cctor>b__2_826(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23CA0 Offset: 0xE222A0 VA: 0x180E23CA0
	internal void <.cctor>b__2_827(ConsoleSystem.Arg arg) { }

	// RVA: 0xE23CB0 Offset: 0xE222B0 VA: 0x180E23CB0
	internal string <.cctor>b__2_828() { }

	// RVA: 0xE23D10 Offset: 0xE22310 VA: 0x180E23D10
	internal void <.cctor>b__2_829(string str) { }

	// RVA: 0xE23E30 Offset: 0xE22430 VA: 0x180E23E30
	internal string <.cctor>b__2_830() { }

	// RVA: 0xE23EE0 Offset: 0xE224E0 VA: 0x180E23EE0
	internal void <.cctor>b__2_831(string str) { }

	// RVA: 0xE23F70 Offset: 0xE22570 VA: 0x180E23F70
	internal string <.cctor>b__2_832() { }

	// RVA: 0xE23FD0 Offset: 0xE225D0 VA: 0x180E23FD0
	internal void <.cctor>b__2_833(string str) { }

	// RVA: 0xE24070 Offset: 0xE22670 VA: 0x180E24070
	internal string <.cctor>b__2_834() { }

	// RVA: 0xE240D0 Offset: 0xE226D0 VA: 0x180E240D0
	internal void <.cctor>b__2_835(string str) { }

	// RVA: 0xE24150 Offset: 0xE22750 VA: 0x180E24150
	internal string <.cctor>b__2_836() { }

	// RVA: 0xE241B0 Offset: 0xE227B0 VA: 0x180E241B0
	internal void <.cctor>b__2_837(string str) { }

	// RVA: 0xE24250 Offset: 0xE22850 VA: 0x180E24250
	internal string <.cctor>b__2_838() { }

	// RVA: 0xE242B0 Offset: 0xE228B0 VA: 0x180E242B0
	internal void <.cctor>b__2_839(string str) { }

	// RVA: 0xE243F0 Offset: 0xE229F0 VA: 0x180E243F0
	internal string <.cctor>b__2_840() { }

	// RVA: 0xE24450 Offset: 0xE22A50 VA: 0x180E24450
	internal void <.cctor>b__2_841(string str) { }

	// RVA: 0xE244F0 Offset: 0xE22AF0 VA: 0x180E244F0
	internal string <.cctor>b__2_842() { }

	// RVA: 0xE24550 Offset: 0xE22B50 VA: 0x180E24550
	internal void <.cctor>b__2_843(string str) { }

	// RVA: 0xE245E0 Offset: 0xE22BE0 VA: 0x180E245E0
	internal void <.cctor>b__2_844(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24640 Offset: 0xE22C40 VA: 0x180E24640
	internal void <.cctor>b__2_845(ConsoleSystem.Arg arg) { }

	// RVA: 0xE246A0 Offset: 0xE22CA0 VA: 0x180E246A0
	internal void <.cctor>b__2_846(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24700 Offset: 0xE22D00 VA: 0x180E24700
	internal string <.cctor>b__2_847() { }

	// RVA: 0xE24760 Offset: 0xE22D60 VA: 0x180E24760
	internal void <.cctor>b__2_848(string str) { }

	// RVA: 0xE24800 Offset: 0xE22E00 VA: 0x180E24800
	internal string <.cctor>b__2_849() { }

	// RVA: 0xE248E0 Offset: 0xE22EE0 VA: 0x180E248E0
	internal void <.cctor>b__2_850(string str) { }

	// RVA: 0xE24980 Offset: 0xE22F80 VA: 0x180E24980
	internal string <.cctor>b__2_851() { }

	// RVA: 0xE249E0 Offset: 0xE22FE0 VA: 0x180E249E0
	internal void <.cctor>b__2_852(string str) { }

	// RVA: 0xE24A80 Offset: 0xE23080 VA: 0x180E24A80
	internal string <.cctor>b__2_853() { }

	// RVA: 0xE24AE0 Offset: 0xE230E0 VA: 0x180E24AE0
	internal void <.cctor>b__2_854(string str) { }

	// RVA: 0xE24B90 Offset: 0xE23190 VA: 0x180E24B90
	internal string <.cctor>b__2_855() { }

	// RVA: 0xE24BF0 Offset: 0xE231F0 VA: 0x180E24BF0
	internal void <.cctor>b__2_856(string str) { }

	// RVA: 0xE24CA0 Offset: 0xE232A0 VA: 0x180E24CA0
	internal void <.cctor>b__2_857(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24D00 Offset: 0xE23300 VA: 0x180E24D00
	internal string <.cctor>b__2_858() { }

	// RVA: 0xE24D60 Offset: 0xE23360 VA: 0x180E24D60
	internal void <.cctor>b__2_859(string str) { }

	// RVA: 0xE24EC0 Offset: 0xE234C0 VA: 0x180E24EC0
	internal string <.cctor>b__2_860() { }

	// RVA: 0xE24F20 Offset: 0xE23520 VA: 0x180E24F20
	internal void <.cctor>b__2_861(string str) { }

	// RVA: 0xE24FD0 Offset: 0xE235D0 VA: 0x180E24FD0
	internal string <.cctor>b__2_862() { }

	// RVA: 0xE25030 Offset: 0xE23630 VA: 0x180E25030
	internal void <.cctor>b__2_863(string str) { }

	// RVA: 0xE250E0 Offset: 0xE236E0 VA: 0x180E250E0
	internal void <.cctor>b__2_864(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25140 Offset: 0xE23740 VA: 0x180E25140
	internal string <.cctor>b__2_865() { }

	// RVA: 0xE251A0 Offset: 0xE237A0 VA: 0x180E251A0
	internal void <.cctor>b__2_866(string str) { }

	// RVA: 0xE25240 Offset: 0xE23840 VA: 0x180E25240
	internal string <.cctor>b__2_867() { }

	// RVA: 0xE252A0 Offset: 0xE238A0 VA: 0x180E252A0
	internal void <.cctor>b__2_868(string str) { }

	// RVA: 0xE25340 Offset: 0xE23940 VA: 0x180E25340
	internal string <.cctor>b__2_869() { }

	// RVA: 0xE25420 Offset: 0xE23A20 VA: 0x180E25420
	internal void <.cctor>b__2_870(string str) { }

	// RVA: 0xE254C0 Offset: 0xE23AC0 VA: 0x180E254C0
	internal string <.cctor>b__2_871() { }

	// RVA: 0xE25520 Offset: 0xE23B20 VA: 0x180E25520
	internal void <.cctor>b__2_872(string str) { }

	// RVA: 0xE255C0 Offset: 0xE23BC0 VA: 0x180E255C0
	internal string <.cctor>b__2_873() { }

	// RVA: 0xE25670 Offset: 0xE23C70 VA: 0x180E25670
	internal void <.cctor>b__2_874(string str) { }

	// RVA: 0xE256F0 Offset: 0xE23CF0 VA: 0x180E256F0
	internal string <.cctor>b__2_875() { }

	// RVA: 0xE25750 Offset: 0xE23D50 VA: 0x180E25750
	internal void <.cctor>b__2_876(string str) { }

	// RVA: 0xE25800 Offset: 0xE23E00 VA: 0x180E25800
	internal string <.cctor>b__2_877() { }

	// RVA: 0xE25860 Offset: 0xE23E60 VA: 0x180E25860
	internal void <.cctor>b__2_878(string str) { }

	// RVA: 0xE25910 Offset: 0xE23F10 VA: 0x180E25910
	internal string <.cctor>b__2_879() { }

	// RVA: 0xE25A20 Offset: 0xE24020 VA: 0x180E25A20
	internal void <.cctor>b__2_880(string str) { }

	// RVA: 0xE25AD0 Offset: 0xE240D0 VA: 0x180E25AD0
	internal string <.cctor>b__2_881() { }

	// RVA: 0xE25B30 Offset: 0xE24130 VA: 0x180E25B30
	internal void <.cctor>b__2_882(string str) { }

	// RVA: 0xE25BE0 Offset: 0xE241E0 VA: 0x180E25BE0
	internal string <.cctor>b__2_883() { }

	// RVA: 0xE25C40 Offset: 0xE24240 VA: 0x180E25C40
	internal void <.cctor>b__2_884(string str) { }

	// RVA: 0xE25CE0 Offset: 0xE242E0 VA: 0x180E25CE0
	internal void <.cctor>b__2_885(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25D40 Offset: 0xE24340 VA: 0x180E25D40
	internal void <.cctor>b__2_886(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25DA0 Offset: 0xE243A0 VA: 0x180E25DA0
	internal void <.cctor>b__2_887(ConsoleSystem.Arg arg) { }

	// RVA: 0xE25E00 Offset: 0xE24400 VA: 0x180E25E00
	internal string <.cctor>b__2_888() { }

	// RVA: 0xE25E60 Offset: 0xE24460 VA: 0x180E25E60
	internal void <.cctor>b__2_889(string str) { }

	// RVA: 0xE25F80 Offset: 0xE24580 VA: 0x180E25F80
	internal string <.cctor>b__2_890() { }

	// RVA: 0xE25FE0 Offset: 0xE245E0 VA: 0x180E25FE0
	internal void <.cctor>b__2_891(string str) { }

	// RVA: 0xE26080 Offset: 0xE24680 VA: 0x180E26080
	internal void <.cctor>b__2_892(ConsoleSystem.Arg arg) { }

	// RVA: 0xE260E0 Offset: 0xE246E0 VA: 0x180E260E0
	internal string <.cctor>b__2_893() { }

	// RVA: 0xE26140 Offset: 0xE24740 VA: 0x180E26140
	internal void <.cctor>b__2_894(string str) { }

	// RVA: 0xE261E0 Offset: 0xE247E0 VA: 0x180E261E0
	internal string <.cctor>b__2_895() { }

	// RVA: 0xE26240 Offset: 0xE24840 VA: 0x180E26240
	internal void <.cctor>b__2_896(string str) { }

	// RVA: 0xE262E0 Offset: 0xE248E0 VA: 0x180E262E0
	internal void <.cctor>b__2_897(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26340 Offset: 0xE24940 VA: 0x180E26340
	internal void <.cctor>b__2_898(ConsoleSystem.Arg arg) { }

	// RVA: 0xE263A0 Offset: 0xE249A0 VA: 0x180E263A0
	internal void <.cctor>b__2_899(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26530 Offset: 0xE24B30 VA: 0x180E26530
	internal void <.cctor>b__2_900(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26530 Offset: 0xE24B30 VA: 0x180E26530
	internal void <.cctor>b__2_901(ConsoleSystem.Arg arg) { }

	// RVA: 0xE26540 Offset: 0xE24B40 VA: 0x180E26540
	internal string <.cctor>b__2_902() { }

	// RVA: 0xE265A0 Offset: 0xE24BA0 VA: 0x180E265A0
	internal void <.cctor>b__2_903(string str) { }

	// RVA: 0xE26640 Offset: 0xE24C40 VA: 0x180E26640
	internal string <.cctor>b__2_904() { }

	// RVA: 0xE266A0 Offset: 0xE24CA0 VA: 0x180E266A0
	internal void <.cctor>b__2_905(string str) { }

	// RVA: 0xE26740 Offset: 0xE24D40 VA: 0x180E26740
	internal string <.cctor>b__2_906() { }

	// RVA: 0xE267E0 Offset: 0xE24DE0 VA: 0x180E267E0
	internal void <.cctor>b__2_907(string str) { }

	// RVA: 0xE26860 Offset: 0xE24E60 VA: 0x180E26860
	internal string <.cctor>b__2_908() { }

	// RVA: 0xE268C0 Offset: 0xE24EC0 VA: 0x180E268C0
	internal void <.cctor>b__2_909(string str) { }

	// RVA: 0xE269C0 Offset: 0xE24FC0 VA: 0x180E269C0
	internal string <.cctor>b__2_910() { }

	// RVA: 0xE26A70 Offset: 0xE25070 VA: 0x180E26A70
	internal void <.cctor>b__2_911(string str) { }

	// RVA: 0xE26B00 Offset: 0xE25100 VA: 0x180E26B00
	internal string <.cctor>b__2_912() { }

	// RVA: 0xE26B60 Offset: 0xE25160 VA: 0x180E26B60
	internal void <.cctor>b__2_913(string str) { }

	// RVA: 0xE26C20 Offset: 0xE25220 VA: 0x180E26C20
	internal string <.cctor>b__2_914() { }

	// RVA: 0xE26C80 Offset: 0xE25280 VA: 0x180E26C80
	internal void <.cctor>b__2_915(string str) { }

	// RVA: 0xE26D40 Offset: 0xE25340 VA: 0x180E26D40
	internal string <.cctor>b__2_916() { }

	// RVA: 0xE26DC0 Offset: 0xE253C0 VA: 0x180E26DC0
	internal void <.cctor>b__2_917(string str) { }

	// RVA: 0xE26E30 Offset: 0xE25430 VA: 0x180E26E30
	internal string <.cctor>b__2_918() { }

	// RVA: 0xE26E90 Offset: 0xE25490 VA: 0x180E26E90
	internal void <.cctor>b__2_919(string str) { }

	// RVA: 0xE27000 Offset: 0xE25600 VA: 0x180E27000
	internal string <.cctor>b__2_920() { }

	// RVA: 0xE27060 Offset: 0xE25660 VA: 0x180E27060
	internal void <.cctor>b__2_921(string str) { }

	// RVA: 0xE27100 Offset: 0xE25700 VA: 0x180E27100
	internal string <.cctor>b__2_922() { }

	// RVA: 0xE27160 Offset: 0xE25760 VA: 0x180E27160
	internal void <.cctor>b__2_923(string str) { }

	// RVA: 0xE27200 Offset: 0xE25800 VA: 0x180E27200
	internal string <.cctor>b__2_924() { }

	// RVA: 0xE27260 Offset: 0xE25860 VA: 0x180E27260
	internal void <.cctor>b__2_925(string str) { }

	// RVA: 0xE27300 Offset: 0xE25900 VA: 0x180E27300
	internal string <.cctor>b__2_926() { }

	// RVA: 0xE27360 Offset: 0xE25960 VA: 0x180E27360
	internal void <.cctor>b__2_927(string str) { }

	// RVA: 0xE27410 Offset: 0xE25A10 VA: 0x180E27410
	internal void <.cctor>b__2_928(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27440 Offset: 0xE25A40 VA: 0x180E27440
	internal void <.cctor>b__2_929(ConsoleSystem.Arg arg) { }

	// RVA: 0xE274D0 Offset: 0xE25AD0 VA: 0x180E274D0
	internal string <.cctor>b__2_930() { }

	// RVA: 0xE27530 Offset: 0xE25B30 VA: 0x180E27530
	internal void <.cctor>b__2_931(string str) { }

	// RVA: 0xE275E0 Offset: 0xE25BE0 VA: 0x180E275E0
	internal void <.cctor>b__2_932(ConsoleSystem.Arg arg) { }

	// RVA: 0xE27640 Offset: 0xE25C40 VA: 0x180E27640
	internal string <.cctor>b__2_933() { }

	// RVA: 0xE276A0 Offset: 0xE25CA0 VA: 0x180E276A0
	internal void <.cctor>b__2_934(string str) { }

	// RVA: 0xE27720 Offset: 0xE25D20 VA: 0x180E27720
	internal string <.cctor>b__2_935() { }

	// RVA: 0xE27780 Offset: 0xE25D80 VA: 0x180E27780
	internal void <.cctor>b__2_936(string str) { }

	// RVA: 0xE27820 Offset: 0xE25E20 VA: 0x180E27820
	internal string <.cctor>b__2_937() { }

	// RVA: 0xE278D0 Offset: 0xE25ED0 VA: 0x180E278D0
	internal void <.cctor>b__2_938(string str) { }

	// RVA: 0xE27950 Offset: 0xE25F50 VA: 0x180E27950
	internal string <.cctor>b__2_939() { }

	// RVA: 0xE27AB0 Offset: 0xE260B0 VA: 0x180E27AB0
	internal void <.cctor>b__2_940(string str) { }

	// RVA: 0xE27B40 Offset: 0xE26140 VA: 0x180E27B40
	internal string <.cctor>b__2_941() { }

	// RVA: 0xE27BA0 Offset: 0xE261A0 VA: 0x180E27BA0
	internal void <.cctor>b__2_942(string str) { }

	// RVA: 0xE27C40 Offset: 0xE26240 VA: 0x180E27C40
	internal string <.cctor>b__2_943() { }

	// RVA: 0xE27CA0 Offset: 0xE262A0 VA: 0x180E27CA0
	internal void <.cctor>b__2_944(string str) { }

	// RVA: 0xE27D40 Offset: 0xE26340 VA: 0x180E27D40
	internal string <.cctor>b__2_945() { }

	// RVA: 0xE27DA0 Offset: 0xE263A0 VA: 0x180E27DA0
	internal void <.cctor>b__2_946(string str) { }

	// RVA: 0xE27E40 Offset: 0xE26440 VA: 0x180E27E40
	internal string <.cctor>b__2_947() { }

	// RVA: 0xE27EA0 Offset: 0xE264A0 VA: 0x180E27EA0
	internal void <.cctor>b__2_948(string str) { }

	// RVA: 0xE27F40 Offset: 0xE26540 VA: 0x180E27F40
	internal string <.cctor>b__2_949() { }

	// RVA: 0xE28020 Offset: 0xE26620 VA: 0x180E28020
	internal void <.cctor>b__2_950(string str) { }

	// RVA: 0xE280C0 Offset: 0xE266C0 VA: 0x180E280C0
	internal string <.cctor>b__2_951() { }

	// RVA: 0xE28120 Offset: 0xE26720 VA: 0x180E28120
	internal void <.cctor>b__2_952(string str) { }

	// RVA: 0xE281C0 Offset: 0xE267C0 VA: 0x180E281C0
	internal string <.cctor>b__2_953() { }

	// RVA: 0xE28220 Offset: 0xE26820 VA: 0x180E28220
	internal void <.cctor>b__2_954(string str) { }

	// RVA: 0xE282C0 Offset: 0xE268C0 VA: 0x180E282C0
	internal string <.cctor>b__2_955() { }

	// RVA: 0xE28320 Offset: 0xE26920 VA: 0x180E28320
	internal void <.cctor>b__2_956(string str) { }

	// RVA: 0xE283C0 Offset: 0xE269C0 VA: 0x180E283C0
	internal string <.cctor>b__2_957() { }

	// RVA: 0xE28420 Offset: 0xE26A20 VA: 0x180E28420
	internal void <.cctor>b__2_958(string str) { }

	// RVA: 0xE284B0 Offset: 0xE26AB0 VA: 0x180E284B0
	internal string <.cctor>b__2_959() { }

	// RVA: 0xE285C0 Offset: 0xE26BC0 VA: 0x180E285C0
	internal void <.cctor>b__2_960(string str) { }

	// RVA: 0xE28650 Offset: 0xE26C50 VA: 0x180E28650
	internal string <.cctor>b__2_961() { }

	// RVA: 0xE286B0 Offset: 0xE26CB0 VA: 0x180E286B0
	internal void <.cctor>b__2_962(string str) { }

	// RVA: 0xE28740 Offset: 0xE26D40 VA: 0x180E28740
	internal string <.cctor>b__2_963() { }

	// RVA: 0xE287A0 Offset: 0xE26DA0 VA: 0x180E287A0
	internal void <.cctor>b__2_964(string str) { }

	// RVA: 0xE28830 Offset: 0xE26E30 VA: 0x180E28830
	internal string <.cctor>b__2_965() { }

	// RVA: 0xE28890 Offset: 0xE26E90 VA: 0x180E28890
	internal void <.cctor>b__2_966(string str) { }

	// RVA: 0xE28920 Offset: 0xE26F20 VA: 0x180E28920
	internal string <.cctor>b__2_967() { }

	// RVA: 0xE28980 Offset: 0xE26F80 VA: 0x180E28980
	internal void <.cctor>b__2_968(string str) { }

	// RVA: 0xE28A10 Offset: 0xE27010 VA: 0x180E28A10
	internal string <.cctor>b__2_969() { }

	// RVA: 0xE28AF0 Offset: 0xE270F0 VA: 0x180E28AF0
	internal void <.cctor>b__2_970(string str) { }

	// RVA: 0xE28B80 Offset: 0xE27180 VA: 0x180E28B80
	internal string <.cctor>b__2_971() { }

	// RVA: 0xE28BE0 Offset: 0xE271E0 VA: 0x180E28BE0
	internal void <.cctor>b__2_972(string str) { }

	// RVA: 0xE28C70 Offset: 0xE27270 VA: 0x180E28C70
	internal string <.cctor>b__2_973() { }

	// RVA: 0xE28CD0 Offset: 0xE272D0 VA: 0x180E28CD0
	internal void <.cctor>b__2_974(string str) { }

	// RVA: 0xE28D60 Offset: 0xE27360 VA: 0x180E28D60
	internal string <.cctor>b__2_975() { }

	// RVA: 0xE28DC0 Offset: 0xE273C0 VA: 0x180E28DC0
	internal void <.cctor>b__2_976(string str) { }

	// RVA: 0xE28E50 Offset: 0xE27450 VA: 0x180E28E50
	internal string <.cctor>b__2_977() { }

	// RVA: 0xE28EB0 Offset: 0xE274B0 VA: 0x180E28EB0
	internal void <.cctor>b__2_978(string str) { }

	// RVA: 0xE28F40 Offset: 0xE27540 VA: 0x180E28F40
	internal string <.cctor>b__2_979() { }

	// RVA: 0xE29050 Offset: 0xE27650 VA: 0x180E29050
	internal void <.cctor>b__2_980(string str) { }

	// RVA: 0xE290E0 Offset: 0xE276E0 VA: 0x180E290E0
	internal string <.cctor>b__2_981() { }

	// RVA: 0xE29140 Offset: 0xE27740 VA: 0x180E29140
	internal void <.cctor>b__2_982(string str) { }

	// RVA: 0xE291D0 Offset: 0xE277D0 VA: 0x180E291D0
	internal string <.cctor>b__2_983() { }

	// RVA: 0xE29230 Offset: 0xE27830 VA: 0x180E29230
	internal void <.cctor>b__2_984(string str) { }

	// RVA: 0xE292C0 Offset: 0xE278C0 VA: 0x180E292C0
	internal string <.cctor>b__2_985() { }

	// RVA: 0xE29320 Offset: 0xE27920 VA: 0x180E29320
	internal void <.cctor>b__2_986(string str) { }

	// RVA: 0xE293B0 Offset: 0xE279B0 VA: 0x180E293B0
	internal string <.cctor>b__2_987() { }

	// RVA: 0xE29410 Offset: 0xE27A10 VA: 0x180E29410
	internal void <.cctor>b__2_988(string str) { }

	// RVA: 0xE294A0 Offset: 0xE27AA0 VA: 0x180E294A0
	internal string <.cctor>b__2_989() { }

	// RVA: 0xE29580 Offset: 0xE27B80 VA: 0x180E29580
	internal void <.cctor>b__2_990(string str) { }

	// RVA: 0xE29610 Offset: 0xE27C10 VA: 0x180E29610
	internal string <.cctor>b__2_991() { }

	// RVA: 0xE29670 Offset: 0xE27C70 VA: 0x180E29670
	internal void <.cctor>b__2_992(string str) { }

	// RVA: 0xE29700 Offset: 0xE27D00 VA: 0x180E29700
	internal void <.cctor>b__2_993(ConsoleSystem.Arg arg) { }

	// RVA: 0xE29760 Offset: 0xE27D60 VA: 0x180E29760
	internal string <.cctor>b__2_994() { }

	// RVA: 0xE297C0 Offset: 0xE27DC0 VA: 0x180E297C0
	internal void <.cctor>b__2_995(string str) { }

	// RVA: 0xE29850 Offset: 0xE27E50 VA: 0x180E29850
	internal string <.cctor>b__2_996() { }

	// RVA: 0xE298B0 Offset: 0xE27EB0 VA: 0x180E298B0
	internal void <.cctor>b__2_997(string str) { }

	// RVA: 0xE29940 Offset: 0xE27F40 VA: 0x180E29940
	internal string <.cctor>b__2_998() { }

	// RVA: 0xE299A0 Offset: 0xE27FA0 VA: 0x180E299A0
	internal void <.cctor>b__2_999(string str) { }

	// RVA: 0xE07C00 Offset: 0xE06200 VA: 0x180E07C00
	internal string <.cctor>b__2_1000() { }

	// RVA: 0xE07C60 Offset: 0xE06260 VA: 0x180E07C60
	internal void <.cctor>b__2_1001(string str) { }

	// RVA: 0xE07CF0 Offset: 0xE062F0 VA: 0x180E07CF0
	internal void <.cctor>b__2_1002(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07D50 Offset: 0xE06350 VA: 0x180E07D50
	internal void <.cctor>b__2_1003(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07DB0 Offset: 0xE063B0 VA: 0x180E07DB0
	internal string <.cctor>b__2_1004() { }

	// RVA: 0xE07E10 Offset: 0xE06410 VA: 0x180E07E10
	internal void <.cctor>b__2_1005(string str) { }

	// RVA: 0xE07EA0 Offset: 0xE064A0 VA: 0x180E07EA0
	internal string <.cctor>b__2_1006() { }

	// RVA: 0xE07F00 Offset: 0xE06500 VA: 0x180E07F00
	internal void <.cctor>b__2_1007(string str) { }

	// RVA: 0xE07F90 Offset: 0xE06590 VA: 0x180E07F90
	internal string <.cctor>b__2_1008() { }

	// RVA: 0xE07FF0 Offset: 0xE065F0 VA: 0x180E07FF0
	internal void <.cctor>b__2_1009(string str) { }

	// RVA: 0xE08100 Offset: 0xE06700 VA: 0x180E08100
	internal void <.cctor>b__2_1010(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08110 Offset: 0xE06710 VA: 0x180E08110
	internal string <.cctor>b__2_1011() { }

	// RVA: 0xE08170 Offset: 0xE06770 VA: 0x180E08170
	internal void <.cctor>b__2_1012(string str) { }

	// RVA: 0xE08210 Offset: 0xE06810 VA: 0x180E08210
	internal void <.cctor>b__2_1013(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08270 Offset: 0xE06870 VA: 0x180E08270
	internal void <.cctor>b__2_1014(ConsoleSystem.Arg arg) { }

	// RVA: 0xE082D0 Offset: 0xE068D0 VA: 0x180E082D0
	internal void <.cctor>b__2_1015(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08330 Offset: 0xE06930 VA: 0x180E08330
	internal void <.cctor>b__2_1016(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08390 Offset: 0xE06990 VA: 0x180E08390
	internal string <.cctor>b__2_1017() { }

	// RVA: 0xE083F0 Offset: 0xE069F0 VA: 0x180E083F0
	internal void <.cctor>b__2_1018(string str) { }

	// RVA: 0xE08490 Offset: 0xE06A90 VA: 0x180E08490
	internal void <.cctor>b__2_1019(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08550 Offset: 0xE06B50 VA: 0x180E08550
	internal string <.cctor>b__2_1020() { }

	// RVA: 0xE085B0 Offset: 0xE06BB0 VA: 0x180E085B0
	internal void <.cctor>b__2_1021(string str) { }

	// RVA: 0xE08650 Offset: 0xE06C50 VA: 0x180E08650
	internal string <.cctor>b__2_1022() { }

	// RVA: 0xE086B0 Offset: 0xE06CB0 VA: 0x180E086B0
	internal void <.cctor>b__2_1023(string str) { }

	// RVA: 0xE08760 Offset: 0xE06D60 VA: 0x180E08760
	internal string <.cctor>b__2_1024() { }

	// RVA: 0xE087C0 Offset: 0xE06DC0 VA: 0x180E087C0
	internal void <.cctor>b__2_1025(string str) { }

	// RVA: 0xE08870 Offset: 0xE06E70 VA: 0x180E08870
	internal string <.cctor>b__2_1026() { }

	// RVA: 0xE088D0 Offset: 0xE06ED0 VA: 0x180E088D0
	internal void <.cctor>b__2_1027(string str) { }

	// RVA: 0xE08970 Offset: 0xE06F70 VA: 0x180E08970
	internal string <.cctor>b__2_1028() { }

	// RVA: 0xE08990 Offset: 0xE06F90 VA: 0x180E08990
	internal void <.cctor>b__2_1029(string str) { }

	// RVA: 0xE08A70 Offset: 0xE07070 VA: 0x180E08A70
	internal string <.cctor>b__2_1030() { }

	// RVA: 0xE08A90 Offset: 0xE07090 VA: 0x180E08A90
	internal void <.cctor>b__2_1031(string str) { }

	// RVA: 0xE08AF0 Offset: 0xE070F0 VA: 0x180E08AF0
	internal string <.cctor>b__2_1032() { }

	// RVA: 0xE08B10 Offset: 0xE07110 VA: 0x180E08B10
	internal void <.cctor>b__2_1033(string str) { }

	// RVA: 0xE08B70 Offset: 0xE07170 VA: 0x180E08B70
	internal string <.cctor>b__2_1034() { }

	// RVA: 0xE08B90 Offset: 0xE07190 VA: 0x180E08B90
	internal void <.cctor>b__2_1035(string str) { }

	// RVA: 0xE08BF0 Offset: 0xE071F0 VA: 0x180E08BF0
	internal string <.cctor>b__2_1036() { }

	// RVA: 0xE08C10 Offset: 0xE07210 VA: 0x180E08C10
	internal void <.cctor>b__2_1037(string str) { }

	// RVA: 0xE08C70 Offset: 0xE07270 VA: 0x180E08C70
	internal string <.cctor>b__2_1038() { }

	// RVA: 0xE08C90 Offset: 0xE07290 VA: 0x180E08C90
	internal void <.cctor>b__2_1039(string str) { }

	// RVA: 0xE08DA0 Offset: 0xE073A0 VA: 0x180E08DA0
	internal string <.cctor>b__2_1040() { }

	// RVA: 0xE08DC0 Offset: 0xE073C0 VA: 0x180E08DC0
	internal void <.cctor>b__2_1041(string str) { }

	// RVA: 0xE08E20 Offset: 0xE07420 VA: 0x180E08E20
	internal string <.cctor>b__2_1042() { }

	// RVA: 0xE08E40 Offset: 0xE07440 VA: 0x180E08E40
	internal void <.cctor>b__2_1043(string str) { }

	// RVA: 0xE08EA0 Offset: 0xE074A0 VA: 0x180E08EA0
	internal void <.cctor>b__2_1044(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08EB0 Offset: 0xE074B0 VA: 0x180E08EB0
	internal void <.cctor>b__2_1045(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08EE0 Offset: 0xE074E0 VA: 0x180E08EE0
	internal string <.cctor>b__2_1046() { }

	// RVA: 0xE08F40 Offset: 0xE07540 VA: 0x180E08F40
	internal void <.cctor>b__2_1047(string str) { }

	// RVA: 0xE08FE0 Offset: 0xE075E0 VA: 0x180E08FE0
	internal string <.cctor>b__2_1048() { }

	// RVA: 0xE09040 Offset: 0xE07640 VA: 0x180E09040
	internal void <.cctor>b__2_1049(string str) { }

	// RVA: 0xE09160 Offset: 0xE07760 VA: 0x180E09160
	internal string <.cctor>b__2_1050() { }

	// RVA: 0xE091C0 Offset: 0xE077C0 VA: 0x180E091C0
	internal void <.cctor>b__2_1051(string str) { }

	// RVA: 0xE09270 Offset: 0xE07870 VA: 0x180E09270
	internal string <.cctor>b__2_1052() { }

	// RVA: 0xE092D0 Offset: 0xE078D0 VA: 0x180E092D0
	internal void <.cctor>b__2_1053(string str) { }

	// RVA: 0xE09370 Offset: 0xE07970 VA: 0x180E09370
	internal string <.cctor>b__2_1054() { }

	// RVA: 0xE093D0 Offset: 0xE079D0 VA: 0x180E093D0
	internal void <.cctor>b__2_1055(string str) { }

	// RVA: 0xE09480 Offset: 0xE07A80 VA: 0x180E09480
	internal void <.cctor>b__2_1056(ConsoleSystem.Arg arg) { }

	// RVA: 0xE094D0 Offset: 0xE07AD0 VA: 0x180E094D0
	internal void <.cctor>b__2_1057(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09590 Offset: 0xE07B90 VA: 0x180E09590
	internal void <.cctor>b__2_1058(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09610 Offset: 0xE07C10 VA: 0x180E09610
	internal string <.cctor>b__2_1059() { }

	// RVA: 0xE09720 Offset: 0xE07D20 VA: 0x180E09720
	internal void <.cctor>b__2_1060(string str) { }

	// RVA: 0xE097C0 Offset: 0xE07DC0 VA: 0x180E097C0
	internal void <.cctor>b__2_1061(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09860 Offset: 0xE07E60 VA: 0x180E09860
	internal void <.cctor>b__2_1062(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09920 Offset: 0xE07F20 VA: 0x180E09920
	internal string <.cctor>b__2_1063() { }

	// RVA: 0xE09980 Offset: 0xE07F80 VA: 0x180E09980
	internal void <.cctor>b__2_1064(string str) { }

	// RVA: 0xE09A20 Offset: 0xE08020 VA: 0x180E09A20
	internal string <.cctor>b__2_1065() { }

	// RVA: 0xE09A80 Offset: 0xE08080 VA: 0x180E09A80
	internal void <.cctor>b__2_1066(string str) { }

	// RVA: 0xE09B30 Offset: 0xE08130 VA: 0x180E09B30
	internal void <.cctor>b__2_1067(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09B90 Offset: 0xE08190 VA: 0x180E09B90
	internal string <.cctor>b__2_1068() { }

	// RVA: 0xE09BF0 Offset: 0xE081F0 VA: 0x180E09BF0
	internal void <.cctor>b__2_1069(string str) { }

	// RVA: 0xE09D10 Offset: 0xE08310 VA: 0x180E09D10
	internal string <.cctor>b__2_1070() { }

	// RVA: 0xE09DC0 Offset: 0xE083C0 VA: 0x180E09DC0
	internal void <.cctor>b__2_1071(string str) { }

	// RVA: 0xE09EA0 Offset: 0xE084A0 VA: 0x180E09EA0
	internal string <.cctor>b__2_1072() { }

	// RVA: 0xE09F00 Offset: 0xE08500 VA: 0x180E09F00
	internal void <.cctor>b__2_1073(string str) { }

	// RVA: 0xE09FB0 Offset: 0xE085B0 VA: 0x180E09FB0
	internal string <.cctor>b__2_1074() { }

	// RVA: 0xE0A010 Offset: 0xE08610 VA: 0x180E0A010
	internal void <.cctor>b__2_1075(string str) { }

	// RVA: 0xE0A0C0 Offset: 0xE086C0 VA: 0x180E0A0C0
	internal void <.cctor>b__2_1076(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A0D0 Offset: 0xE086D0 VA: 0x180E0A0D0
	internal void <.cctor>b__2_1077(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A0E0 Offset: 0xE086E0 VA: 0x180E0A0E0
	internal void <.cctor>b__2_1078(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A0F0 Offset: 0xE086F0 VA: 0x180E0A0F0
	internal void <.cctor>b__2_1079(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A1B0 Offset: 0xE087B0 VA: 0x180E0A1B0
	internal void <.cctor>b__2_1080(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A210 Offset: 0xE08810 VA: 0x180E0A210
	internal void <.cctor>b__2_1081(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A270 Offset: 0xE08870 VA: 0x180E0A270
	internal void <.cctor>b__2_1082(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A2D0 Offset: 0xE088D0 VA: 0x180E0A2D0
	internal void <.cctor>b__2_1083(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A330 Offset: 0xE08930 VA: 0x180E0A330
	internal void <.cctor>b__2_1084(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A390 Offset: 0xE08990 VA: 0x180E0A390
	internal string <.cctor>b__2_1085() { }

	// RVA: 0xE0A3F0 Offset: 0xE089F0 VA: 0x180E0A3F0
	internal void <.cctor>b__2_1086(string str) { }

	// RVA: 0xE0A490 Offset: 0xE08A90 VA: 0x180E0A490
	internal string <.cctor>b__2_1087() { }

	// RVA: 0xE0A540 Offset: 0xE08B40 VA: 0x180E0A540
	internal void <.cctor>b__2_1088(string str) { }

	// RVA: 0xE0A5C0 Offset: 0xE08BC0 VA: 0x180E0A5C0
	internal void <.cctor>b__2_1089(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A6A0 Offset: 0xE08CA0 VA: 0x180E0A6A0
	internal void <.cctor>b__2_1090(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A700 Offset: 0xE08D00 VA: 0x180E0A700
	internal string <.cctor>b__2_1091() { }

	// RVA: 0xE0A760 Offset: 0xE08D60 VA: 0x180E0A760
	internal void <.cctor>b__2_1092(string str) { }

	// RVA: 0xE0A800 Offset: 0xE08E00 VA: 0x180E0A800
	internal string <.cctor>b__2_1093() { }

	// RVA: 0xE0A860 Offset: 0xE08E60 VA: 0x180E0A860
	internal void <.cctor>b__2_1094(string str) { }

	// RVA: 0xE0A910 Offset: 0xE08F10 VA: 0x180E0A910
	internal string <.cctor>b__2_1095() { }

	// RVA: 0xE0A970 Offset: 0xE08F70 VA: 0x180E0A970
	internal void <.cctor>b__2_1096(string str) { }

	// RVA: 0xE0AA20 Offset: 0xE09020 VA: 0x180E0AA20
	internal string <.cctor>b__2_1097() { }

	// RVA: 0xE0AA80 Offset: 0xE09080 VA: 0x180E0AA80
	internal void <.cctor>b__2_1098(string str) { }

	// RVA: 0xE0AB20 Offset: 0xE09120 VA: 0x180E0AB20
	internal string <.cctor>b__2_1099() { }

	// RVA: 0xE0ACB0 Offset: 0xE092B0 VA: 0x180E0ACB0
	internal void <.cctor>b__2_1100(string str) { }

	// RVA: 0xE0AD60 Offset: 0xE09360 VA: 0x180E0AD60
	internal string <.cctor>b__2_1101() { }

	// RVA: 0xE0ADC0 Offset: 0xE093C0 VA: 0x180E0ADC0
	internal void <.cctor>b__2_1102(string str) { }

	// RVA: 0xE0AE50 Offset: 0xE09450 VA: 0x180E0AE50
	internal string <.cctor>b__2_1103() { }

	// RVA: 0xE0AEB0 Offset: 0xE094B0 VA: 0x180E0AEB0
	internal void <.cctor>b__2_1104(string str) { }

	// RVA: 0xE0AF40 Offset: 0xE09540 VA: 0x180E0AF40
	internal void <.cctor>b__2_1105(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0AFA0 Offset: 0xE095A0 VA: 0x180E0AFA0
	internal void <.cctor>b__2_1106(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B000 Offset: 0xE09600 VA: 0x180E0B000
	internal string <.cctor>b__2_1107() { }

	// RVA: 0xE0B060 Offset: 0xE09660 VA: 0x180E0B060
	internal void <.cctor>b__2_1108(string str) { }

	// RVA: 0xE0B100 Offset: 0xE09700 VA: 0x180E0B100
	internal string <.cctor>b__2_1109() { }

	// RVA: 0xE0B1C0 Offset: 0xE097C0 VA: 0x180E0B1C0
	internal void <.cctor>b__2_1110(string str) { }

	// RVA: 0xE0B260 Offset: 0xE09860 VA: 0x180E0B260
	internal string <.cctor>b__2_1111() { }

	// RVA: 0xE0B2E0 Offset: 0xE098E0 VA: 0x180E0B2E0
	internal void <.cctor>b__2_1112(string str) { }

	// RVA: 0xE0B340 Offset: 0xE09940 VA: 0x180E0B340
	internal void <.cctor>b__2_1113(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B390 Offset: 0xE09990 VA: 0x180E0B390
	internal void <.cctor>b__2_1114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B3F0 Offset: 0xE099F0 VA: 0x180E0B3F0
	internal void <.cctor>b__2_1115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B450 Offset: 0xE09A50 VA: 0x180E0B450
	internal string <.cctor>b__2_1116() { }

	// RVA: 0xE0B500 Offset: 0xE09B00 VA: 0x180E0B500
	internal void <.cctor>b__2_1117(string str) { }

	// RVA: 0xE0B580 Offset: 0xE09B80 VA: 0x180E0B580
	internal string <.cctor>b__2_1118() { }

	// RVA: 0xE0B5E0 Offset: 0xE09BE0 VA: 0x180E0B5E0
	internal void <.cctor>b__2_1119(string str) { }

	// RVA: 0xE0B730 Offset: 0xE09D30 VA: 0x180E0B730
	internal string <.cctor>b__2_1120() { }

	// RVA: 0xE0B790 Offset: 0xE09D90 VA: 0x180E0B790
	internal void <.cctor>b__2_1121(string str) { }

	// RVA: 0xE0B830 Offset: 0xE09E30 VA: 0x180E0B830
	internal string <.cctor>b__2_1122() { }

	// RVA: 0xE0B890 Offset: 0xE09E90 VA: 0x180E0B890
	internal void <.cctor>b__2_1123(string str) { }

	// RVA: 0xE0B930 Offset: 0xE09F30 VA: 0x180E0B930
	internal string <.cctor>b__2_1124() { }

	// RVA: 0xE0B990 Offset: 0xE09F90 VA: 0x180E0B990
	internal void <.cctor>b__2_1125(string str) { }

	// RVA: 0xE0BA40 Offset: 0xE0A040 VA: 0x180E0BA40
	internal string <.cctor>b__2_1126() { }

	// RVA: 0xE0BAA0 Offset: 0xE0A0A0 VA: 0x180E0BAA0
	internal void <.cctor>b__2_1127(string str) { }

	// RVA: 0xE0BB40 Offset: 0xE0A140 VA: 0x180E0BB40
	internal string <.cctor>b__2_1128() { }

	// RVA: 0xE0BBA0 Offset: 0xE0A1A0 VA: 0x180E0BBA0
	internal void <.cctor>b__2_1129(string str) { }

	// RVA: 0xE0BCA0 Offset: 0xE0A2A0 VA: 0x180E0BCA0
	internal string <.cctor>b__2_1130() { }

	// RVA: 0xE0BD00 Offset: 0xE0A300 VA: 0x180E0BD00
	internal void <.cctor>b__2_1131(string str) { }

	// RVA: 0xE0BDA0 Offset: 0xE0A3A0 VA: 0x180E0BDA0
	internal string <.cctor>b__2_1132() { }

	// RVA: 0xE0BE00 Offset: 0xE0A400 VA: 0x180E0BE00
	internal void <.cctor>b__2_1133(string str) { }

	// RVA: 0xE0BEA0 Offset: 0xE0A4A0 VA: 0x180E0BEA0
	internal void <.cctor>b__2_1134(ConsoleSystem.Arg arg) { }

}

public static class ConsoleNetwork // TypeDefIndex: 9370
{	// Methods

	// RVA: 0x6AE070 Offset: 0x6AC670 VA: 0x1806AE070
	internal static void Init() { }

	// RVA: 0x6ADE30 Offset: 0x6AC430 VA: 0x1806ADE30
	public static bool ClientRunOnServer(string strCommand) { }

	// RVA: 0x6AE200 Offset: 0x6AC800 VA: 0x1806AE200
	internal static void OnConsoleMessageFromServer(Message packet) { }

	// RVA: 0x6AE100 Offset: 0x6AC700 VA: 0x1806AE100
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

	// RVA: 0x6AE2E0 Offset: 0x6AC8E0 VA: 0x1806AE2E0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6AEB30 Offset: 0x6AD130 VA: 0x1806AEB30
	protected void OnEnable() { }

	// RVA: 0x6AEA30 Offset: 0x6AD030 VA: 0x1806AEA30
	protected void OnDisable() { }

	// RVA: 0x6AFFE0 Offset: 0x6AE5E0 VA: 0x1806AFFE0
	protected void Update() { }

	// RVA: 0x6AFB00 Offset: 0x6AE100 VA: 0x1806AFB00
	public void SetTextSize(float newSize) { }

	// RVA: 0x6AE5C0 Offset: 0x6ACBC0 VA: 0x1806AE5C0
	public void CloseAutocomplete() { }

	// RVA: 0x6AEDF0 Offset: 0x6AD3F0 VA: 0x1806AEDF0
	public void OnTextTypes(string str) { }

	// RVA: 0x6AE280 Offset: 0x6AC880 VA: 0x1806AE280
	private void AutocompleteButtonClicked(Button button) { }

	// RVA: 0x6AED10 Offset: 0x6AD310 VA: 0x1806AED10
	private void OnOpenDevTools() { }

	// RVA: 0x6AF4E0 Offset: 0x6ADAE0 VA: 0x1806AF4E0
	private void OutputHandler_OnMessage(string message, string stack, LogType type = 0) { }

	// RVA: 0x6AE9A0 Offset: 0x6ACFA0 VA: 0x1806AE9A0
	private void Log(string message) { }

	// RVA: 0x6AF9B0 Offset: 0x6ADFB0 VA: 0x1806AF9B0
	private void Refresh() { }

	// RVA: 0x6AE860 Offset: 0x6ACE60 VA: 0x1806AE860
	private void LoadHistory(int delta) { }

	// RVA: 0x6AFBE0 Offset: 0x6AE1E0 VA: 0x1806AFBE0
	public void SubmitCommand(string command) { }

	// RVA: 0x6AFA00 Offset: 0x6AE000 VA: 0x1806AFA00
	private void SelectInputField(bool updateAutoComplete = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x7F4C0 Offset: 0x7E8C0 VA: 0x18007F4C0
	// RVA: 0x6AFA80 Offset: 0x6AE080 VA: 0x1806AFA80
	private IEnumerator SetSelected(bool updateAutoComplete = False) { }

	// RVA: 0x6AE560 Offset: 0x6ACB60 VA: 0x1806AE560
	public void ClearContents() { }

	// RVA: 0x6AE6D0 Offset: 0x6ACCD0 VA: 0x1806AE6D0
	public void Copy() { }

	// RVA: 0x6AF420 Offset: 0x6ADA20 VA: 0x1806AF420
	public void OpenLogFolder() { }

	// RVA: 0x6AF360 Offset: 0x6AD960 VA: 0x1806AF360
	public void OpenLogFile() { }

	// RVA: 0x6B0470 Offset: 0x6AEA70 VA: 0x1806B0470
	public void .ctor() { }

}

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 10837
{	// Fields
	public Button btn; // 0x10
	public ConsoleUI <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8EE0 Offset: 0x6C74E0 VA: 0x1806C8EE0
	internal void <Awake>b__0() { }

}

private sealed class ConsoleUI.<>c__DisplayClass22_0 // TypeDefIndex: 10838
{	// Fields
	public string str; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6C8F40 Offset: 0x6C7540 VA: 0x1806C8F40
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C8C00 Offset: 0x6C7200 VA: 0x1806C8C00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6C8DE0 Offset: 0x6C73E0 VA: 0x1806C8DE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ConsoleInput // TypeDefIndex: 11681
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Action<string> OnInputText; // 0x10
	public string inputString; // 0x18
	public string[] statusText; // 0x20
	internal float nextUpdate; // 0x28

	// Properties
	public bool valid { get; }
	public int lineWidth { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8E89E0 Offset: 0x8E6FE0 VA: 0x1808E89E0
	public void add_OnInputText(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8E8B20 Offset: 0x8E7120 VA: 0x1808E8B20
	public void remove_OnInputText(Action<string> value) { }

	// RVA: 0x8E8AD0 Offset: 0x8E70D0 VA: 0x1808E8AD0
	public bool get_valid() { }

	// RVA: 0x8E8A80 Offset: 0x8E7080 VA: 0x1808E8A80
	public int get_lineWidth() { }

	// RVA: 0x8E7F90 Offset: 0x8E6590 VA: 0x1808E7F90
	public void ClearLine(int numLines) { }

	// RVA: 0x8E81F0 Offset: 0x8E67F0 VA: 0x1808E81F0
	public void RedrawInputLine() { }

	// RVA: 0x8E8060 Offset: 0x8E6660 VA: 0x1808E8060
	internal void OnBackspace() { }

	// RVA: 0x8E81A0 Offset: 0x8E67A0 VA: 0x1808E81A0
	internal void OnEscape() { }

	// RVA: 0x8E80C0 Offset: 0x8E66C0 VA: 0x1808E80C0
	internal void OnEnter() { }

	// RVA: 0x8E8570 Offset: 0x8E6B70 VA: 0x1808E8570
	public void Update() { }

	// RVA: 0x8E8830 Offset: 0x8E6E30 VA: 0x1808E8830
	public void .ctor() { }

}

public class ConsoleWindow // TypeDefIndex: 11682
{	// Fields
	private TextWriter oldOutput; // 0x10
	private const int STD_INPUT_HANDLE = -10;
	private const int STD_OUTPUT_HANDLE = -11;

	// Methods

	// RVA: 0x8E8DE0 Offset: 0x8E73E0 VA: 0x1808E8DE0
	public void Initialize() { }

	// RVA: 0x8E9250 Offset: 0x8E7850 VA: 0x1808E9250
	public void Shutdown() { }

	// RVA: 0x8E91C0 Offset: 0x8E77C0 VA: 0x1808E91C0
	public void SetTitle(string strName) { }

	// RVA: 0x8E8C40 Offset: 0x8E7240 VA: 0x1808E8C40
	private static extern bool AttachConsole(uint dwProcessId) { }

	// RVA: 0x8E8BC0 Offset: 0x8E71C0 VA: 0x1808E8BC0
	private static extern bool AllocConsole() { }

	// RVA: 0x8E8CD0 Offset: 0x8E72D0 VA: 0x1808E8CD0
	private static extern bool FreeConsole() { }

	// RVA: 0x8E8D50 Offset: 0x8E7350 VA: 0x1808E8D50
	private static extern IntPtr GetStdHandle(int nStdHandle) { }

	// RVA: 0x8E9120 Offset: 0x8E7720 VA: 0x1808E9120
	private static extern bool SetConsoleTitleA(string lpConsoleTitle) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class Console : ConsoleSystem // TypeDefIndex: 11894
{	// Fields
	[ClientVar] // RVA: 0x909C0 Offset: 0x8FDC0 VA: 0x1800909C0
	[HelpAttribute] // RVA: 0x909C0 Offset: 0x8FDC0 VA: 0x1800909C0
	public static bool erroroverlay; // 0x2B11160

	// Methods

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D47D0 Offset: 0x6D2DD0 VA: 0x1806D47D0
	public static void clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x6D4840 Offset: 0x6D2E40 VA: 0x1806D4840
	public static void copy(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D4770 Offset: 0x6D2D70 VA: 0x1806D4770
	public void .ctor() { }

	// RVA: 0x6D4730 Offset: 0x6D2D30 VA: 0x1806D4730
	private static void .cctor() { }

}


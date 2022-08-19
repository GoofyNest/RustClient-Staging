internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 393
{	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private ConsoleColor bgcolor; // 0xD4
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public ConsoleColor BackgroundColor { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { get; set; }
	public int CursorTop { get; set; }
	public bool KeyAvailable { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x18C0DD0 Offset: 0x18BF3D0 VA: 0x1818C0DD0
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x18C0A20 Offset: 0x18BF020 VA: 0x1818C0A20
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18C10E0 Offset: 0x18BF6E0 VA: 0x1818C10E0
	private void WriteConsole(string str) { }

	// RVA: 0x18C1580 Offset: 0x18BFB80 VA: 0x1818C1580
	public void .ctor(string term) { }

	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0 Slot: 14
	public bool get_Initialized() { }

	// RVA: 0x18BF660 Offset: 0x18BDC60 VA: 0x1818BF660 Slot: 15
	public void Init() { }

	// RVA: 0x18BF400 Offset: 0x18BDA00 VA: 0x1818BF400
	private void IncrementX() { }

	// RVA: 0x18C1110 Offset: 0x18BF710 VA: 0x1818C1110
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18C12F0 Offset: 0x18BF8F0 VA: 0x1818C12F0
	public void WriteSpecialKey(char c) { }

	// RVA: 0x18BFFC0 Offset: 0x18BE5C0 VA: 0x1818BFFC0
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18BFF70 Offset: 0x18BE570 VA: 0x1818BFF70
	public bool IsSpecialKey(char c) { }

	// RVA: 0x18BC170 Offset: 0x18BA770 VA: 0x1818BC170
	private void ChangeColor(string format, ConsoleColor color) { }

	// RVA: 0x18C1B10 Offset: 0x18C0110 VA: 0x1818C1B10 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x18C1D00 Offset: 0x18C0300 VA: 0x1818C1D00 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x18C1BE0 Offset: 0x18C01E0 VA: 0x1818C1BE0 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x18C1E10 Offset: 0x18C0410 VA: 0x1818C1E10 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x18BED80 Offset: 0x18BD380 VA: 0x1818BED80
	private void GetCursorPosition() { }

	// RVA: 0x18C1B50 Offset: 0x18C0150 VA: 0x1818C1B50 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x18C1B80 Offset: 0x18C0180 VA: 0x1818C1B80 Slot: 16
	public int get_CursorLeft() { }

	// RVA: 0x18C1D50 Offset: 0x18C0350 VA: 0x1818C1D50 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x18C1BB0 Offset: 0x18C01B0 VA: 0x1818C1BB0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x18C1DB0 Offset: 0x18C03B0 VA: 0x1818C1DB0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x18C1C20 Offset: 0x18C0220 VA: 0x1818C1C20 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x18BC2F0 Offset: 0x18BA8F0 VA: 0x1818BC2F0
	private void CheckWindowDimensions() { }

	// RVA: 0x18C1CA0 Offset: 0x18C02A0 VA: 0x1818C1CA0 Slot: 17
	public int get_WindowHeight() { }

	// RVA: 0x18C1CD0 Offset: 0x18C02D0 VA: 0x1818C1CD0 Slot: 18
	public int get_WindowWidth() { }

	// RVA: 0x18BC050 Offset: 0x18BA650 VA: 0x1818BC050
	private void AddToBuffer(int b) { }

	// RVA: 0x18BC150 Offset: 0x18BA750 VA: 0x1818BC150
	private void AdjustBuffer() { }

	// RVA: 0x18BC470 Offset: 0x18BAA70 VA: 0x1818BC470
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x18BF060 Offset: 0x18BD660 VA: 0x1818BF060
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x18C01C0 Offset: 0x18BE7C0 VA: 0x1818C01C0
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x18BFF30 Offset: 0x18BE530 VA: 0x1818BFF30
	private bool InputPending() { }

	// RVA: 0x18C00C0 Offset: 0x18BE6C0 VA: 0x1818C00C0
	private void QueueEcho(char c) { }

	// RVA: 0x18BEBF0 Offset: 0x18BD1F0 VA: 0x1818BEBF0
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x18BEBA0 Offset: 0x18BD1A0 VA: 0x1818BEBA0
	private void EchoFlush() { }

	// RVA: 0x18C06E0 Offset: 0x18BECE0 VA: 0x1818C06E0
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18C03D0 Offset: 0x18BE9D0 VA: 0x1818C03D0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18C0480 Offset: 0x18BEA80 VA: 0x1818C0480 Slot: 19
	public string ReadLine() { }

	// RVA: 0x18C0490 Offset: 0x18BEA90 VA: 0x1818C0490
	public string ReadToEnd() { }

	// RVA: 0x18C04A0 Offset: 0x18BEAA0 VA: 0x1818C04A0
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x18C0BC0 Offset: 0x18BF1C0 VA: 0x1818C0BC0 Slot: 20
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x18BC5B0 Offset: 0x18BABB0 VA: 0x1818BC5B0
	private void CreateKeyMap() { }

	// RVA: 0x18BF490 Offset: 0x18BDA90 VA: 0x1818BF490
	private void InitKeys() { }

	// RVA: 0x18BC000 Offset: 0x18BA600 VA: 0x1818BC000
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x18C1340 Offset: 0x18BF940 VA: 0x1818C1340
	private static void .cctor() { }

}


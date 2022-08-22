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

	// RVA: 0x18C0770 Offset: 0x18BED70 VA: 0x1818C0770
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x18C03C0 Offset: 0x18BE9C0 VA: 0x1818C03C0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18C0A80 Offset: 0x18BF080 VA: 0x1818C0A80
	private void WriteConsole(string str) { }

	// RVA: 0x18C0F20 Offset: 0x18BF520 VA: 0x1818C0F20
	public void .ctor(string term) { }

	// RVA: 0xC2BF70 Offset: 0xC2A570 VA: 0x180C2BF70 Slot: 14
	public bool get_Initialized() { }

	// RVA: 0x18BF000 Offset: 0x18BD600 VA: 0x1818BF000 Slot: 15
	public void Init() { }

	// RVA: 0x18BEDA0 Offset: 0x18BD3A0 VA: 0x1818BEDA0
	private void IncrementX() { }

	// RVA: 0x18C0AB0 Offset: 0x18BF0B0 VA: 0x1818C0AB0
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18C0C90 Offset: 0x18BF290 VA: 0x1818C0C90
	public void WriteSpecialKey(char c) { }

	// RVA: 0x18BF960 Offset: 0x18BDF60 VA: 0x1818BF960
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18BF910 Offset: 0x18BDF10 VA: 0x1818BF910
	public bool IsSpecialKey(char c) { }

	// RVA: 0x18BBB10 Offset: 0x18BA110 VA: 0x1818BBB10
	private void ChangeColor(string format, ConsoleColor color) { }

	// RVA: 0x18C14B0 Offset: 0x18BFAB0 VA: 0x1818C14B0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x18C16A0 Offset: 0x18BFCA0 VA: 0x1818C16A0 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x18C1580 Offset: 0x18BFB80 VA: 0x1818C1580 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x18C17B0 Offset: 0x18BFDB0 VA: 0x1818C17B0 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x18BE720 Offset: 0x18BCD20 VA: 0x1818BE720
	private void GetCursorPosition() { }

	// RVA: 0x18C14F0 Offset: 0x18BFAF0 VA: 0x1818C14F0 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x18C1520 Offset: 0x18BFB20 VA: 0x1818C1520 Slot: 16
	public int get_CursorLeft() { }

	// RVA: 0x18C16F0 Offset: 0x18BFCF0 VA: 0x1818C16F0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x18C1550 Offset: 0x18BFB50 VA: 0x1818C1550 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x18C1750 Offset: 0x18BFD50 VA: 0x1818C1750 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x18C15C0 Offset: 0x18BFBC0 VA: 0x1818C15C0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x18BBC90 Offset: 0x18BA290 VA: 0x1818BBC90
	private void CheckWindowDimensions() { }

	// RVA: 0x18C1640 Offset: 0x18BFC40 VA: 0x1818C1640 Slot: 17
	public int get_WindowHeight() { }

	// RVA: 0x18C1670 Offset: 0x18BFC70 VA: 0x1818C1670 Slot: 18
	public int get_WindowWidth() { }

	// RVA: 0x18BB9F0 Offset: 0x18B9FF0 VA: 0x1818BB9F0
	private void AddToBuffer(int b) { }

	// RVA: 0x18BBAF0 Offset: 0x18BA0F0 VA: 0x1818BBAF0
	private void AdjustBuffer() { }

	// RVA: 0x18BBE10 Offset: 0x18BA410 VA: 0x1818BBE10
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x18BEA00 Offset: 0x18BD000 VA: 0x1818BEA00
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x18BFB60 Offset: 0x18BE160 VA: 0x1818BFB60
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x18BF8D0 Offset: 0x18BDED0 VA: 0x1818BF8D0
	private bool InputPending() { }

	// RVA: 0x18BFA60 Offset: 0x18BE060 VA: 0x1818BFA60
	private void QueueEcho(char c) { }

	// RVA: 0x18BE590 Offset: 0x18BCB90 VA: 0x1818BE590
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x18BE540 Offset: 0x18BCB40 VA: 0x1818BE540
	private void EchoFlush() { }

	// RVA: 0x18C0080 Offset: 0x18BE680 VA: 0x1818C0080
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18BFD70 Offset: 0x18BE370 VA: 0x1818BFD70 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18BFE20 Offset: 0x18BE420 VA: 0x1818BFE20 Slot: 19
	public string ReadLine() { }

	// RVA: 0x18BFE30 Offset: 0x18BE430 VA: 0x1818BFE30
	public string ReadToEnd() { }

	// RVA: 0x18BFE40 Offset: 0x18BE440 VA: 0x1818BFE40
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x18C0560 Offset: 0x18BEB60 VA: 0x1818C0560 Slot: 20
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x18BBF50 Offset: 0x18BA550 VA: 0x1818BBF50
	private void CreateKeyMap() { }

	// RVA: 0x18BEE30 Offset: 0x18BD430 VA: 0x1818BEE30
	private void InitKeys() { }

	// RVA: 0x18BB9A0 Offset: 0x18B9FA0 VA: 0x1818BB9A0
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x18C0CE0 Offset: 0x18BF2E0 VA: 0x1818C0CE0
	private static void .cctor() { }

}


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

	// RVA: 0x18C0D90 Offset: 0x18BF390 VA: 0x1818C0D90
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x18C09E0 Offset: 0x18BEFE0 VA: 0x1818C09E0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18C10A0 Offset: 0x18BF6A0 VA: 0x1818C10A0
	private void WriteConsole(string str) { }

	// RVA: 0x18C1540 Offset: 0x18BFB40 VA: 0x1818C1540
	public void .ctor(string term) { }

	// RVA: 0xC2B7E0 Offset: 0xC29DE0 VA: 0x180C2B7E0 Slot: 14
	public bool get_Initialized() { }

	// RVA: 0x18BF620 Offset: 0x18BDC20 VA: 0x1818BF620 Slot: 15
	public void Init() { }

	// RVA: 0x18BF3C0 Offset: 0x18BD9C0 VA: 0x1818BF3C0
	private void IncrementX() { }

	// RVA: 0x18C10D0 Offset: 0x18BF6D0 VA: 0x1818C10D0
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18C12B0 Offset: 0x18BF8B0 VA: 0x1818C12B0
	public void WriteSpecialKey(char c) { }

	// RVA: 0x18BFF80 Offset: 0x18BE580 VA: 0x1818BFF80
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18BFF30 Offset: 0x18BE530 VA: 0x1818BFF30
	public bool IsSpecialKey(char c) { }

	// RVA: 0x18BC130 Offset: 0x18BA730 VA: 0x1818BC130
	private void ChangeColor(string format, ConsoleColor color) { }

	// RVA: 0x18C1AD0 Offset: 0x18C00D0 VA: 0x1818C1AD0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x18C1CC0 Offset: 0x18C02C0 VA: 0x1818C1CC0 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x18C1BA0 Offset: 0x18C01A0 VA: 0x1818C1BA0 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x18C1DD0 Offset: 0x18C03D0 VA: 0x1818C1DD0 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x18BED40 Offset: 0x18BD340 VA: 0x1818BED40
	private void GetCursorPosition() { }

	// RVA: 0x18C1B10 Offset: 0x18C0110 VA: 0x1818C1B10 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x18C1B40 Offset: 0x18C0140 VA: 0x1818C1B40 Slot: 16
	public int get_CursorLeft() { }

	// RVA: 0x18C1D10 Offset: 0x18C0310 VA: 0x1818C1D10 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x18C1B70 Offset: 0x18C0170 VA: 0x1818C1B70 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x18C1D70 Offset: 0x18C0370 VA: 0x1818C1D70 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x18C1BE0 Offset: 0x18C01E0 VA: 0x1818C1BE0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x18BC2B0 Offset: 0x18BA8B0 VA: 0x1818BC2B0
	private void CheckWindowDimensions() { }

	// RVA: 0x18C1C60 Offset: 0x18C0260 VA: 0x1818C1C60 Slot: 17
	public int get_WindowHeight() { }

	// RVA: 0x18C1C90 Offset: 0x18C0290 VA: 0x1818C1C90 Slot: 18
	public int get_WindowWidth() { }

	// RVA: 0x18BC010 Offset: 0x18BA610 VA: 0x1818BC010
	private void AddToBuffer(int b) { }

	// RVA: 0x18BC110 Offset: 0x18BA710 VA: 0x1818BC110
	private void AdjustBuffer() { }

	// RVA: 0x18BC430 Offset: 0x18BAA30 VA: 0x1818BC430
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x18BF020 Offset: 0x18BD620 VA: 0x1818BF020
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x18C0180 Offset: 0x18BE780 VA: 0x1818C0180
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x18BFEF0 Offset: 0x18BE4F0 VA: 0x1818BFEF0
	private bool InputPending() { }

	// RVA: 0x18C0080 Offset: 0x18BE680 VA: 0x1818C0080
	private void QueueEcho(char c) { }

	// RVA: 0x18BEBB0 Offset: 0x18BD1B0 VA: 0x1818BEBB0
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x18BEB60 Offset: 0x18BD160 VA: 0x1818BEB60
	private void EchoFlush() { }

	// RVA: 0x18C06A0 Offset: 0x18BECA0 VA: 0x1818C06A0
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18C0390 Offset: 0x18BE990 VA: 0x1818C0390 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18C0440 Offset: 0x18BEA40 VA: 0x1818C0440 Slot: 19
	public string ReadLine() { }

	// RVA: 0x18C0450 Offset: 0x18BEA50 VA: 0x1818C0450
	public string ReadToEnd() { }

	// RVA: 0x18C0460 Offset: 0x18BEA60 VA: 0x1818C0460
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x18C0B80 Offset: 0x18BF180 VA: 0x1818C0B80 Slot: 20
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x18BC570 Offset: 0x18BAB70 VA: 0x1818BC570
	private void CreateKeyMap() { }

	// RVA: 0x18BF450 Offset: 0x18BDA50 VA: 0x1818BF450
	private void InitKeys() { }

	// RVA: 0x18BBFC0 Offset: 0x18BA5C0 VA: 0x1818BBFC0
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x18C1300 Offset: 0x18BF900 VA: 0x1818C1300
	private static void .cctor() { }

}


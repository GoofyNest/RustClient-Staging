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

	// RVA: 0x18C1050 Offset: 0x18BF650 VA: 0x1818C1050
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x18C0CA0 Offset: 0x18BF2A0 VA: 0x1818C0CA0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18C1360 Offset: 0x18BF960 VA: 0x1818C1360
	private void WriteConsole(string str) { }

	// RVA: 0x18C1800 Offset: 0x18BFE00 VA: 0x1818C1800
	public void .ctor(string term) { }

	// RVA: 0xC2BAA0 Offset: 0xC2A0A0 VA: 0x180C2BAA0 Slot: 14
	public bool get_Initialized() { }

	// RVA: 0x18BF8E0 Offset: 0x18BDEE0 VA: 0x1818BF8E0 Slot: 15
	public void Init() { }

	// RVA: 0x18BF680 Offset: 0x18BDC80 VA: 0x1818BF680
	private void IncrementX() { }

	// RVA: 0x18C1390 Offset: 0x18BF990 VA: 0x1818C1390
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18C1570 Offset: 0x18BFB70 VA: 0x1818C1570
	public void WriteSpecialKey(char c) { }

	// RVA: 0x18C0240 Offset: 0x18BE840 VA: 0x1818C0240
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18C01F0 Offset: 0x18BE7F0 VA: 0x1818C01F0
	public bool IsSpecialKey(char c) { }

	// RVA: 0x18BC3F0 Offset: 0x18BA9F0 VA: 0x1818BC3F0
	private void ChangeColor(string format, ConsoleColor color) { }

	// RVA: 0x18C1D90 Offset: 0x18C0390 VA: 0x1818C1D90 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x18C1F80 Offset: 0x18C0580 VA: 0x1818C1F80 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x18C1E60 Offset: 0x18C0460 VA: 0x1818C1E60 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x18C2090 Offset: 0x18C0690 VA: 0x1818C2090 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x18BF000 Offset: 0x18BD600 VA: 0x1818BF000
	private void GetCursorPosition() { }

	// RVA: 0x18C1DD0 Offset: 0x18C03D0 VA: 0x1818C1DD0 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x18C1E00 Offset: 0x18C0400 VA: 0x1818C1E00 Slot: 16
	public int get_CursorLeft() { }

	// RVA: 0x18C1FD0 Offset: 0x18C05D0 VA: 0x1818C1FD0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x18C1E30 Offset: 0x18C0430 VA: 0x1818C1E30 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x18C2030 Offset: 0x18C0630 VA: 0x1818C2030 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x18C1EA0 Offset: 0x18C04A0 VA: 0x1818C1EA0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x18BC570 Offset: 0x18BAB70 VA: 0x1818BC570
	private void CheckWindowDimensions() { }

	// RVA: 0x18C1F20 Offset: 0x18C0520 VA: 0x1818C1F20 Slot: 17
	public int get_WindowHeight() { }

	// RVA: 0x18C1F50 Offset: 0x18C0550 VA: 0x1818C1F50 Slot: 18
	public int get_WindowWidth() { }

	// RVA: 0x18BC2D0 Offset: 0x18BA8D0 VA: 0x1818BC2D0
	private void AddToBuffer(int b) { }

	// RVA: 0x18BC3D0 Offset: 0x18BA9D0 VA: 0x1818BC3D0
	private void AdjustBuffer() { }

	// RVA: 0x18BC6F0 Offset: 0x18BACF0 VA: 0x1818BC6F0
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x18BF2E0 Offset: 0x18BD8E0 VA: 0x1818BF2E0
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x18C0440 Offset: 0x18BEA40 VA: 0x1818C0440
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x18C01B0 Offset: 0x18BE7B0 VA: 0x1818C01B0
	private bool InputPending() { }

	// RVA: 0x18C0340 Offset: 0x18BE940 VA: 0x1818C0340
	private void QueueEcho(char c) { }

	// RVA: 0x18BEE70 Offset: 0x18BD470 VA: 0x1818BEE70
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x18BEE20 Offset: 0x18BD420 VA: 0x1818BEE20
	private void EchoFlush() { }

	// RVA: 0x18C0960 Offset: 0x18BEF60 VA: 0x1818C0960
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18C0650 Offset: 0x18BEC50 VA: 0x1818C0650 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18C0700 Offset: 0x18BED00 VA: 0x1818C0700 Slot: 19
	public string ReadLine() { }

	// RVA: 0x18C0710 Offset: 0x18BED10 VA: 0x1818C0710
	public string ReadToEnd() { }

	// RVA: 0x18C0720 Offset: 0x18BED20 VA: 0x1818C0720
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x18C0E40 Offset: 0x18BF440 VA: 0x1818C0E40 Slot: 20
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x18BC830 Offset: 0x18BAE30 VA: 0x1818BC830
	private void CreateKeyMap() { }

	// RVA: 0x18BF710 Offset: 0x18BDD10 VA: 0x1818BF710
	private void InitKeys() { }

	// RVA: 0x18BC280 Offset: 0x18BA880 VA: 0x1818BC280
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x18C15C0 Offset: 0x18BFBC0 VA: 0x1818C15C0
	private static void .cctor() { }

}


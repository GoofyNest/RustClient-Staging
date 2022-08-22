internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 428
{	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Properties
	public ConsoleColor BackgroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { get; set; }
	public int CursorTop { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public bool KeyAvailable { get; }

	// Methods

	// RVA: 0x214A320 Offset: 0x2148920 VA: 0x18214A320
	public void .ctor() { }

	// RVA: 0x2149C00 Offset: 0x2148200 VA: 0x182149C00
	private static ConsoleColor GetForeground(short attr) { }

	// RVA: 0x2149B50 Offset: 0x2148150 VA: 0x182149B50
	private static ConsoleColor GetBackground(short attr) { }

	// RVA: 0x2149B40 Offset: 0x2148140 VA: 0x182149B40
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	// RVA: 0x2149B30 Offset: 0x2148130 VA: 0x182149B30
	private static short GetAttrBackground(int attr, ConsoleColor color) { }

	// RVA: 0x214A400 Offset: 0x2148A00 VA: 0x18214A400 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x214AA50 Offset: 0x2149050 VA: 0x18214AA50 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x214A4A0 Offset: 0x2148AA0 VA: 0x18214A4A0 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x214A540 Offset: 0x2148B40 VA: 0x18214A540 Slot: 14
	public int get_CursorLeft() { }

	// RVA: 0x214AB20 Offset: 0x2149120 VA: 0x18214AB20 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x214A5E0 Offset: 0x2148BE0 VA: 0x18214A5E0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x214ABF0 Offset: 0x21491F0 VA: 0x18214ABF0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x214A690 Offset: 0x2148C90 VA: 0x18214A690 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x214ACC0 Offset: 0x21492C0 VA: 0x18214ACC0 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x214A730 Offset: 0x2148D30 VA: 0x18214A730 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x2149EF0 Offset: 0x21484F0 VA: 0x182149EF0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x214A270 Offset: 0x2148870 VA: 0x18214A270 Slot: 15
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x2149CA0 Offset: 0x21482A0 VA: 0x182149CA0
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x2149C10 Offset: 0x2148210 VA: 0x182149C10
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x2149B60 Offset: 0x2148160 VA: 0x182149B60
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x214A130 Offset: 0x2148730 VA: 0x18214A130
	private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

	// RVA: 0x214A1D0 Offset: 0x21487D0 VA: 0x18214A1D0
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

	// RVA: 0x2149CD0 Offset: 0x21482D0 VA: 0x182149CD0
	private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

	// RVA: 0x2149DE0 Offset: 0x21483E0 VA: 0x182149DE0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}


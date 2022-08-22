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

	// RVA: 0x214AE00 Offset: 0x2149400 VA: 0x18214AE00
	public void .ctor() { }

	// RVA: 0x214A6E0 Offset: 0x2148CE0 VA: 0x18214A6E0
	private static ConsoleColor GetForeground(short attr) { }

	// RVA: 0x214A630 Offset: 0x2148C30 VA: 0x18214A630
	private static ConsoleColor GetBackground(short attr) { }

	// RVA: 0x214A620 Offset: 0x2148C20 VA: 0x18214A620
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	// RVA: 0x214A610 Offset: 0x2148C10 VA: 0x18214A610
	private static short GetAttrBackground(int attr, ConsoleColor color) { }

	// RVA: 0x214AEE0 Offset: 0x21494E0 VA: 0x18214AEE0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x214B530 Offset: 0x2149B30 VA: 0x18214B530 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x214AF80 Offset: 0x2149580 VA: 0x18214AF80 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x214B020 Offset: 0x2149620 VA: 0x18214B020 Slot: 14
	public int get_CursorLeft() { }

	// RVA: 0x214B600 Offset: 0x2149C00 VA: 0x18214B600 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x214B0C0 Offset: 0x21496C0 VA: 0x18214B0C0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x214B6D0 Offset: 0x2149CD0 VA: 0x18214B6D0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x214B170 Offset: 0x2149770 VA: 0x18214B170 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x214B7A0 Offset: 0x2149DA0 VA: 0x18214B7A0 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x214B210 Offset: 0x2149810 VA: 0x18214B210 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x214A9D0 Offset: 0x2148FD0 VA: 0x18214A9D0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x214AD50 Offset: 0x2149350 VA: 0x18214AD50 Slot: 15
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x214A780 Offset: 0x2148D80 VA: 0x18214A780
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x214A6F0 Offset: 0x2148CF0 VA: 0x18214A6F0
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x214A640 Offset: 0x2148C40 VA: 0x18214A640
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x214AC10 Offset: 0x2149210 VA: 0x18214AC10
	private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

	// RVA: 0x214ACB0 Offset: 0x21492B0 VA: 0x18214ACB0
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

	// RVA: 0x214A7B0 Offset: 0x2148DB0 VA: 0x18214A7B0
	private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

	// RVA: 0x214A8C0 Offset: 0x2148EC0 VA: 0x18214A8C0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}


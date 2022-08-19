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

	// RVA: 0x214A4E0 Offset: 0x2148AE0 VA: 0x18214A4E0
	public void .ctor() { }

	// RVA: 0x2149DC0 Offset: 0x21483C0 VA: 0x182149DC0
	private static ConsoleColor GetForeground(short attr) { }

	// RVA: 0x2149D10 Offset: 0x2148310 VA: 0x182149D10
	private static ConsoleColor GetBackground(short attr) { }

	// RVA: 0x2149D00 Offset: 0x2148300 VA: 0x182149D00
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	// RVA: 0x2149CF0 Offset: 0x21482F0 VA: 0x182149CF0
	private static short GetAttrBackground(int attr, ConsoleColor color) { }

	// RVA: 0x214A5C0 Offset: 0x2148BC0 VA: 0x18214A5C0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x214AC10 Offset: 0x2149210 VA: 0x18214AC10 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x214A660 Offset: 0x2148C60 VA: 0x18214A660 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x214A700 Offset: 0x2148D00 VA: 0x18214A700 Slot: 14
	public int get_CursorLeft() { }

	// RVA: 0x214ACE0 Offset: 0x21492E0 VA: 0x18214ACE0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x214A7A0 Offset: 0x2148DA0 VA: 0x18214A7A0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x214ADB0 Offset: 0x21493B0 VA: 0x18214ADB0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x214A850 Offset: 0x2148E50 VA: 0x18214A850 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x214AE80 Offset: 0x2149480 VA: 0x18214AE80 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x214A8F0 Offset: 0x2148EF0 VA: 0x18214A8F0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x214A0B0 Offset: 0x21486B0 VA: 0x18214A0B0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x214A430 Offset: 0x2148A30 VA: 0x18214A430 Slot: 15
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x2149E60 Offset: 0x2148460 VA: 0x182149E60
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x2149DD0 Offset: 0x21483D0 VA: 0x182149DD0
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x2149D20 Offset: 0x2148320 VA: 0x182149D20
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x214A2F0 Offset: 0x21488F0 VA: 0x18214A2F0
	private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

	// RVA: 0x214A390 Offset: 0x2148990 VA: 0x18214A390
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

	// RVA: 0x2149E90 Offset: 0x2148490 VA: 0x182149E90
	private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

	// RVA: 0x2149FA0 Offset: 0x21485A0 VA: 0x182149FA0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}


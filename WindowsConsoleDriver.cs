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

	// RVA: 0x214A5E0 Offset: 0x2148BE0 VA: 0x18214A5E0
	public void .ctor() { }

	// RVA: 0x2149EC0 Offset: 0x21484C0 VA: 0x182149EC0
	private static ConsoleColor GetForeground(short attr) { }

	// RVA: 0x2149E10 Offset: 0x2148410 VA: 0x182149E10
	private static ConsoleColor GetBackground(short attr) { }

	// RVA: 0x2149E00 Offset: 0x2148400 VA: 0x182149E00
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	// RVA: 0x2149DF0 Offset: 0x21483F0 VA: 0x182149DF0
	private static short GetAttrBackground(int attr, ConsoleColor color) { }

	// RVA: 0x214A6C0 Offset: 0x2148CC0 VA: 0x18214A6C0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x214AD10 Offset: 0x2149310 VA: 0x18214AD10 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x214A760 Offset: 0x2148D60 VA: 0x18214A760 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x214A800 Offset: 0x2148E00 VA: 0x18214A800 Slot: 14
	public int get_CursorLeft() { }

	// RVA: 0x214ADE0 Offset: 0x21493E0 VA: 0x18214ADE0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x214A8A0 Offset: 0x2148EA0 VA: 0x18214A8A0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x214AEB0 Offset: 0x21494B0 VA: 0x18214AEB0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x214A950 Offset: 0x2148F50 VA: 0x18214A950 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x214AF80 Offset: 0x2149580 VA: 0x18214AF80 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x214A9F0 Offset: 0x2148FF0 VA: 0x18214A9F0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x214A1B0 Offset: 0x21487B0 VA: 0x18214A1B0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x214A530 Offset: 0x2148B30 VA: 0x18214A530 Slot: 15
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x2149F60 Offset: 0x2148560 VA: 0x182149F60
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x2149ED0 Offset: 0x21484D0 VA: 0x182149ED0
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x2149E20 Offset: 0x2148420 VA: 0x182149E20
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x214A3F0 Offset: 0x21489F0 VA: 0x18214A3F0
	private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

	// RVA: 0x214A490 Offset: 0x2148A90 VA: 0x18214A490
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

	// RVA: 0x2149F90 Offset: 0x2148590 VA: 0x182149F90
	private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

	// RVA: 0x214A0A0 Offset: 0x21486A0 VA: 0x18214A0A0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}


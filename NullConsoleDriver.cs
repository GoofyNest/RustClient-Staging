internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 378
{	// Fields
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; // 0x13B10

	// Properties
	public ConsoleColor BackgroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { set; }
	public int CursorTop { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public bool KeyAvailable { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x16778C0 Offset: 0x1675EC0 VA: 0x1816778C0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void .ctor() { }

	// RVA: 0x1677930 Offset: 0x1675F30 VA: 0x181677930
	private static void .cctor() { }

}


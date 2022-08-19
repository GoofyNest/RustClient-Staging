internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 681
{	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1637FA0 Offset: 0x16365A0 VA: 0x181637FA0
	private static void .cctor() { }

	// RVA: 0x1638030 Offset: 0x1636630 VA: 0x181638030
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1637AF0 Offset: 0x16360F0 VA: 0x181637AF0 Slot: 9
	public override int Peek() { }

	// RVA: 0x1637D40 Offset: 0x1636340 VA: 0x181637D40 Slot: 10
	public override int Read() { }

	// RVA: 0x1637DA0 Offset: 0x16363A0 VA: 0x181637DA0 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x16378C0 Offset: 0x1635EC0 VA: 0x1816378C0
	private bool CheckEOL(char current) { }

	// RVA: 0x1637BC0 Offset: 0x16361C0 VA: 0x181637BC0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1637C20 Offset: 0x1636220 VA: 0x181637C20 Slot: 12
	public override string ReadToEnd() { }

}


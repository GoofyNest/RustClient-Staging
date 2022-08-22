internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 681
{	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1638260 Offset: 0x1636860 VA: 0x181638260
	private static void .cctor() { }

	// RVA: 0x16382F0 Offset: 0x16368F0 VA: 0x1816382F0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1637DB0 Offset: 0x16363B0 VA: 0x181637DB0 Slot: 9
	public override int Peek() { }

	// RVA: 0x1638000 Offset: 0x1636600 VA: 0x181638000 Slot: 10
	public override int Read() { }

	// RVA: 0x1638060 Offset: 0x1636660 VA: 0x181638060 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x1637B80 Offset: 0x1636180 VA: 0x181637B80
	private bool CheckEOL(char current) { }

	// RVA: 0x1637E80 Offset: 0x1636480 VA: 0x181637E80 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1637EE0 Offset: 0x16364E0 VA: 0x181637EE0 Slot: 12
	public override string ReadToEnd() { }

}


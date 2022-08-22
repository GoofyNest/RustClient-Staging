internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 681
{	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1625580 Offset: 0x1623B80 VA: 0x181625580
	private static void .cctor() { }

	// RVA: 0x1625610 Offset: 0x1623C10 VA: 0x181625610
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x16250D0 Offset: 0x16236D0 VA: 0x1816250D0 Slot: 9
	public override int Peek() { }

	// RVA: 0x1625320 Offset: 0x1623920 VA: 0x181625320 Slot: 10
	public override int Read() { }

	// RVA: 0x1625380 Offset: 0x1623980 VA: 0x181625380 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x1624EA0 Offset: 0x16234A0 VA: 0x181624EA0
	private bool CheckEOL(char current) { }

	// RVA: 0x16251A0 Offset: 0x16237A0 VA: 0x1816251A0 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1625200 Offset: 0x1623800 VA: 0x181625200 Slot: 12
	public override string ReadToEnd() { }

}


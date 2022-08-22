internal class Bootstring // TypeDefIndex: 744
{	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x10D0350 Offset: 0x10CE950 VA: 0x1810D0350
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x10CFF50 Offset: 0x10CE550 VA: 0x1810CFF50
	public string Encode(string s, int offset) { }

	// RVA: 0x10CFF30 Offset: 0x10CE530 VA: 0x1810CFF30
	private char EncodeDigit(int d) { }

	// RVA: 0x10CFC20 Offset: 0x10CE220 VA: 0x1810CFC20
	private int DecodeDigit(char c) { }

	// RVA: 0x10CFBB0 Offset: 0x10CE1B0 VA: 0x1810CFBB0
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x10CFC50 Offset: 0x10CE250 VA: 0x1810CFC50
	public string Decode(string s, int offset) { }

}


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

	// RVA: 0x10CF8E0 Offset: 0x10CDEE0 VA: 0x1810CF8E0
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x10CF4E0 Offset: 0x10CDAE0 VA: 0x1810CF4E0
	public string Encode(string s, int offset) { }

	// RVA: 0x10CF4C0 Offset: 0x10CDAC0 VA: 0x1810CF4C0
	private char EncodeDigit(int d) { }

	// RVA: 0x10CF1B0 Offset: 0x10CD7B0 VA: 0x1810CF1B0
	private int DecodeDigit(char c) { }

	// RVA: 0x10CF140 Offset: 0x10CD740 VA: 0x1810CF140
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x10CF1E0 Offset: 0x10CD7E0 VA: 0x1810CF1E0
	public string Decode(string s, int offset) { }

}


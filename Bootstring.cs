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

	// RVA: 0x10CF620 Offset: 0x10CDC20 VA: 0x1810CF620
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x10CF220 Offset: 0x10CD820 VA: 0x1810CF220
	public string Encode(string s, int offset) { }

	// RVA: 0x10CF200 Offset: 0x10CD800 VA: 0x1810CF200
	private char EncodeDigit(int d) { }

	// RVA: 0x10CEEF0 Offset: 0x10CD4F0 VA: 0x1810CEEF0
	private int DecodeDigit(char c) { }

	// RVA: 0x10CEE80 Offset: 0x10CD480 VA: 0x1810CEE80
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x10CEF20 Offset: 0x10CD520 VA: 0x1810CEF20
	public string Decode(string s, int offset) { }

}


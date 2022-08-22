internal sealed class RegexBoyerMoore // TypeDefIndex: 2604
{	// Fields
	internal int[] _positive; // 0x10
	internal int[] _negativeASCII; // 0x18
	internal int[][] _negativeUnicode; // 0x20
	internal string _pattern; // 0x28
	internal int _lowASCII; // 0x30
	internal int _highASCII; // 0x34
	internal bool _rightToLeft; // 0x38
	internal bool _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40
	internal const int infinite = 2147483647;

	// Methods

	// RVA: 0x14C2110 Offset: 0x14C0710 VA: 0x1814C2110
	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x14C1C40 Offset: 0x14C0240 VA: 0x1814C1C40
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x14C1BC0 Offset: 0x14C01C0 VA: 0x1814C1BC0
	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x14C1D70 Offset: 0x14C0370 VA: 0x1814C1D70
	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 3
	public override string ToString() { }

}


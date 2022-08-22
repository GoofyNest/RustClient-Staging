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

	// RVA: 0x14C11E0 Offset: 0x14BF7E0 VA: 0x1814C11E0
	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x14C0D10 Offset: 0x14BF310 VA: 0x1814C0D10
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x14C0C90 Offset: 0x14BF290 VA: 0x1814C0C90
	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x14C0E40 Offset: 0x14BF440 VA: 0x1814C0E40
	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 3
	public override string ToString() { }

}


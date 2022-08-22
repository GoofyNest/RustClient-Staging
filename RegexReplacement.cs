internal sealed class RegexReplacement // TypeDefIndex: 2628
{	// Fields
	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	// Properties
	internal string Pattern { get; }

	// Methods

	// RVA: 0x16B5840 Offset: 0x16B3E40 VA: 0x1816B5840
	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x16B56C0 Offset: 0x16B3CC0 VA: 0x1816B56C0
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x16B5540 Offset: 0x16B3B40 VA: 0x1816B5540
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string get_Pattern() { }

	// RVA: 0x16B4FA0 Offset: 0x16B35A0 VA: 0x1816B4FA0
	internal string Replace(Regex regex, string input, int count, int startat) { }

}


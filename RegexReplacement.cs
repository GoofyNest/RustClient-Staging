internal sealed class RegexReplacement // TypeDefIndex: 2628
{	// Fields
	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	// Properties
	internal string Pattern { get; }

	// Methods

	// RVA: 0x16B7C50 Offset: 0x16B6250 VA: 0x1816B7C50
	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x16B7AD0 Offset: 0x16B60D0 VA: 0x1816B7AD0
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x16B7950 Offset: 0x16B5F50 VA: 0x1816B7950
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Pattern() { }

	// RVA: 0x16B73B0 Offset: 0x16B59B0 VA: 0x1816B73B0
	internal string Replace(Regex regex, string input, int count, int startat) { }

}


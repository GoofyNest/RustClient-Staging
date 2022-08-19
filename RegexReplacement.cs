internal sealed class RegexReplacement // TypeDefIndex: 2628
{	// Fields
	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	// Properties
	internal string Pattern { get; }

	// Methods

	// RVA: 0x16B7990 Offset: 0x16B5F90 VA: 0x1816B7990
	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x16B7810 Offset: 0x16B5E10 VA: 0x1816B7810
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x16B7690 Offset: 0x16B5C90 VA: 0x1816B7690
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string get_Pattern() { }

	// RVA: 0x16B70F0 Offset: 0x16B56F0 VA: 0x1816B70F0
	internal string Replace(Regex regex, string input, int count, int startat) { }

}


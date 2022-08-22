public struct StringConcat // TypeDefIndex: 2430
{	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x237FC0 Offset: 0x2373C0 VA: 0x180237FC0
	public void Clear() { }

	// RVA: 0x1D1040 Offset: 0x1D0440 VA: 0x1801D1040
	internal int get_Count() { }

	// RVA: 0x238160 Offset: 0x237560 VA: 0x180238160
	public string GetResult() { }

	// RVA: 0x237FE0 Offset: 0x2373E0 VA: 0x180237FE0
	internal void ConcatNoDelimiter(string s) { }

}


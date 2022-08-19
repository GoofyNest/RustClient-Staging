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

	// RVA: 0x238040 Offset: 0x237440 VA: 0x180238040
	public void Clear() { }

	// RVA: 0x1D10C0 Offset: 0x1D04C0 VA: 0x1801D10C0
	internal int get_Count() { }

	// RVA: 0x2381E0 Offset: 0x2375E0 VA: 0x1802381E0
	public string GetResult() { }

	// RVA: 0x238060 Offset: 0x237460 VA: 0x180238060
	internal void ConcatNoDelimiter(string s) { }

}


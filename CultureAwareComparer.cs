internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private CompareOptions _options; // 0x1C


	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	public override int Compare(string x, string y) { }

	public override bool Equals(string x, string y) { }

	public override int GetHashCode(string obj) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}


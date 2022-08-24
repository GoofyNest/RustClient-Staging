internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	private CompareOptions _options; // 0x1C


	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	public override int Compare(string x, string y) { }

	public override bool Equals(string x, string y) { }

	public override int GetHashCode(string obj) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}


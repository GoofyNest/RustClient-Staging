internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x1792380 Offset: 0x1790980 VA: 0x181792380
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x1792140 Offset: 0x1790740 VA: 0x181792140 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x17921A0 Offset: 0x17907A0 VA: 0x1817921A0 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x17922B0 Offset: 0x17908B0 VA: 0x1817922B0 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x1792200 Offset: 0x1790800 VA: 0x181792200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1792340 Offset: 0x1790940 VA: 0x181792340 Slot: 2
	public override int GetHashCode() { }

}


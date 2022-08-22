internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x1794790 Offset: 0x1792D90 VA: 0x181794790
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x1794550 Offset: 0x1792B50 VA: 0x181794550 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x17945B0 Offset: 0x1792BB0 VA: 0x1817945B0 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x17946C0 Offset: 0x1792CC0 VA: 0x1817946C0 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x1794610 Offset: 0x1792C10 VA: 0x181794610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1794750 Offset: 0x1792D50 VA: 0x181794750 Slot: 2
	public override int GetHashCode() { }

}


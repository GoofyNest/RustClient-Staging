internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B620 Offset: 0x7AA20 VA: 0x18007B620
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x17920C0 Offset: 0x17906C0 VA: 0x1817920C0
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x1791E80 Offset: 0x1790480 VA: 0x181791E80 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x1791EE0 Offset: 0x17904E0 VA: 0x181791EE0 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x1791FF0 Offset: 0x17905F0 VA: 0x181791FF0 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x1791F40 Offset: 0x1790540 VA: 0x181791F40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1792080 Offset: 0x1790680 VA: 0x181792080 Slot: 2
	public override int GetHashCode() { }

}


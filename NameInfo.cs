internal sealed class NameInfo // TypeDefIndex: 1124
{	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11F63F0 Offset: 0x11F49F0 VA: 0x1811F63F0
	internal void Init() { }

	// RVA: 0x11F6450 Offset: 0x11F4A50 VA: 0x1811F6450
	public bool get_IsSealed() { }

	// RVA: 0x11F6490 Offset: 0x11F4A90 VA: 0x1811F6490
	public string get_NIname() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_NIname(string value) { }

}

internal sealed class NameInfo : ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo> // TypeDefIndex: 1525
{	// Fields
	private static int lastIdentity; // 0x0
	internal readonly string name; // 0x10
	internal readonly EventTags tags; // 0x18
	internal readonly int identity; // 0x1C
	internal readonly byte[] nameMetadata; // 0x20

	// Methods

	// RVA: 0x10E47D0 Offset: 0x10E2DD0 VA: 0x1810E47D0
	internal static void ReserveEventIDsBelow(int eventId) { }

	// RVA: 0x10E48E0 Offset: 0x10E2EE0 VA: 0x1810E48E0
	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	// RVA: 0x10E4750 Offset: 0x10E2D50 VA: 0x1810E4750 Slot: 4
	public override int Compare(NameInfo other) { }

	// RVA: 0x10E4780 Offset: 0x10E2D80 VA: 0x1810E4780 Slot: 5
	public override int Compare(KeyValuePair<string, EventTags> key) { }

	// RVA: 0x10E4650 Offset: 0x10E2C50 VA: 0x1810E4650
	private int Compare(string otherName, EventTags otherTags) { }

	// RVA: 0x10E48A0 Offset: 0x10E2EA0 VA: 0x1810E48A0
	private static void .cctor() { }

}


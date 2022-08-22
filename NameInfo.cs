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

	// RVA: 0x11F6A90 Offset: 0x11F5090 VA: 0x1811F6A90
	internal void Init() { }

	// RVA: 0x11F6AF0 Offset: 0x11F50F0 VA: 0x1811F6AF0
	public bool get_IsSealed() { }

	// RVA: 0x11F6B30 Offset: 0x11F5130 VA: 0x1811F6B30
	public string get_NIname() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
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

	// RVA: 0x10E5240 Offset: 0x10E3840 VA: 0x1810E5240
	internal static void ReserveEventIDsBelow(int eventId) { }

	// RVA: 0x10E5350 Offset: 0x10E3950 VA: 0x1810E5350
	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	// RVA: 0x10E51C0 Offset: 0x10E37C0 VA: 0x1810E51C0 Slot: 4
	public override int Compare(NameInfo other) { }

	// RVA: 0x10E51F0 Offset: 0x10E37F0 VA: 0x1810E51F0 Slot: 5
	public override int Compare(KeyValuePair<string, EventTags> key) { }

	// RVA: 0x10E50C0 Offset: 0x10E36C0 VA: 0x1810E50C0
	private int Compare(string otherName, EventTags otherTags) { }

	// RVA: 0x10E5310 Offset: 0x10E3910 VA: 0x1810E5310
	private static void .cctor() { }

}


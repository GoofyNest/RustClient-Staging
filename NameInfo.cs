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

	// RVA: 0x11F6130 Offset: 0x11F4730 VA: 0x1811F6130
	internal void Init() { }

	// RVA: 0x11F6190 Offset: 0x11F4790 VA: 0x1811F6190
	public bool get_IsSealed() { }

	// RVA: 0x11F61D0 Offset: 0x11F47D0 VA: 0x1811F61D0
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

	// RVA: 0x10E4510 Offset: 0x10E2B10 VA: 0x1810E4510
	internal static void ReserveEventIDsBelow(int eventId) { }

	// RVA: 0x10E4620 Offset: 0x10E2C20 VA: 0x1810E4620
	public void .ctor(string name, EventTags tags, int typeMetadataSize) { }

	// RVA: 0x10E4490 Offset: 0x10E2A90 VA: 0x1810E4490 Slot: 4
	public override int Compare(NameInfo other) { }

	// RVA: 0x10E44C0 Offset: 0x10E2AC0 VA: 0x1810E44C0 Slot: 5
	public override int Compare(KeyValuePair<string, EventTags> key) { }

	// RVA: 0x10E4390 Offset: 0x10E2990 VA: 0x1810E4390
	private int Compare(string otherName, EventTags otherTags) { }

	// RVA: 0x10E45E0 Offset: 0x10E2BE0 VA: 0x1810E45E0
	private static void .cctor() { }

}


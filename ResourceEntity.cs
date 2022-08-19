public class ResourceEntity : BaseEntity // TypeDefIndex: 9676
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x83F10 Offset: 0x83310 VA: 0x180083F10
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x83F70 Offset: 0x83370 VA: 0x180083F70
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C

	// Methods

	// RVA: 0x4C39D0 Offset: 0x4C1FD0 VA: 0x1804C39D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4C3910 Offset: 0x4C1F10 VA: 0x1804C3910 Slot: 28
	public override void InitShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x4C3A20 Offset: 0x4C2020 VA: 0x1804C3A20
	public void .ctor() { }

}


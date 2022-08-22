public class ResourceEntity : BaseEntity // TypeDefIndex: 9676
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x83F80 Offset: 0x83380 VA: 0x180083F80
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x83FE0 Offset: 0x833E0 VA: 0x180083FE0
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C

	// Methods

	// RVA: 0x4C3960 Offset: 0x4C1F60 VA: 0x1804C3960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4C38A0 Offset: 0x4C1EA0 VA: 0x1804C38A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x4C39B0 Offset: 0x4C1FB0 VA: 0x1804C39B0
	public void .ctor() { }

}


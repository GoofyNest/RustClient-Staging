public class ResourceEntity : BaseEntity // TypeDefIndex: 9676
{	[FormerlySerializedAsAttribute] // RVA: 0x84050 Offset: 0x83450 VA: 0x180084050
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x840F0 Offset: 0x834F0 VA: 0x1800840F0
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void InitShared() { }

	public override void OnAttacked(HitInfo info) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}


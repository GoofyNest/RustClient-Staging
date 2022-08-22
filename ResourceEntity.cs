public class ResourceEntity : BaseEntity // TypeDefIndex: 9676
{	[FormerlySerializedAsAttribute] // RVA: 0x83F80 Offset: 0x83380 VA: 0x180083F80
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x83FE0 Offset: 0x833E0 VA: 0x180083FE0
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void InitShared() { }

	public override void OnAttacked(HitInfo info) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}


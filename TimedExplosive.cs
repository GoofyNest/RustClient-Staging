public class TimedExplosive : BaseEntity // TypeDefIndex: 9684
{	// Fields
	public float timerAmountMin; // 0x168
	public float timerAmountMax; // 0x16C
	public float minExplosionRadius; // 0x170
	public float explosionRadius; // 0x174
	public bool explodeOnContact; // 0x178
	public bool canStick; // 0x179
	public bool onlyDamageParent; // 0x17A
	public GameObjectRef explosionEffect; // 0x180
	[TooltipAttribute] // RVA: 0x842D0 Offset: 0x836D0 VA: 0x1800842D0
	public GameObjectRef underwaterExplosionEffect; // 0x188
	public GameObjectRef stickEffect; // 0x190
	public GameObjectRef bounceEffect; // 0x198
	public bool explosionUsesForward; // 0x1A0
	public bool waterCausesExplosion; // 0x1A1
	public List<DamageTypeEntry> damageTypes; // 0x1A8
	private float lastBounceTime; // 0x1B0

	// Methods

	// RVA: 0x88A7D0 Offset: 0x888DD0 VA: 0x18088A7D0 Slot: 61
	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x88A820 Offset: 0x888E20 VA: 0x18088A820 Slot: 131
	public virtual void SetCollisionEnabled(bool wantsCollision) { }

	// RVA: 0x88A8C0 Offset: 0x888EC0 VA: 0x18088A8C0
	public void .ctor() { }

}


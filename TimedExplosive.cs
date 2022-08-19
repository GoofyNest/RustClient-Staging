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
	[TooltipAttribute] // RVA: 0x84210 Offset: 0x83610 VA: 0x180084210
	public GameObjectRef underwaterExplosionEffect; // 0x188
	public GameObjectRef stickEffect; // 0x190
	public GameObjectRef bounceEffect; // 0x198
	public bool explosionUsesForward; // 0x1A0
	public bool waterCausesExplosion; // 0x1A1
	public List<DamageTypeEntry> damageTypes; // 0x1A8
	private float lastBounceTime; // 0x1B0

	// Methods

	// RVA: 0x88A6C0 Offset: 0x888CC0 VA: 0x18088A6C0 Slot: 61
	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x88A710 Offset: 0x888D10 VA: 0x18088A710 Slot: 131
	public virtual void SetCollisionEnabled(bool wantsCollision) { }

	// RVA: 0x88A7B0 Offset: 0x888DB0 VA: 0x18088A7B0
	public void .ctor() { }

}


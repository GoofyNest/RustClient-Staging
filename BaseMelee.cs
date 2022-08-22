public class BaseMelee : AttackEntity // TypeDefIndex: 8523
{	// Fields
	[HeaderAttribute] // RVA: 0xA2BB0 Offset: 0xA1FB0 VA: 0x1800A2BB0
	public bool canThrowAsProjectile; // 0x280
	public bool canAiHearIt; // 0x281
	public bool onlyThrowAsProjectile; // 0x282
	[HeaderAttribute] // RVA: 0xA2CD0 Offset: 0xA20D0 VA: 0x1800A2CD0
	public DamageProperties damageProperties; // 0x288
	public List<DamageTypeEntry> damageTypes; // 0x290
	public float maxDistance; // 0x298
	public float attackRadius; // 0x29C
	public bool isAutomatic; // 0x2A0
	public bool blockSprintOnAttack; // 0x2A1
	[HeaderAttribute] // RVA: 0x787C0 Offset: 0x77BC0 VA: 0x1800787C0
	public GameObjectRef strikeFX; // 0x2A8
	public bool useStandardHitEffects; // 0x2B0
	[HeaderAttribute] // RVA: 0x71780 Offset: 0x70B80 VA: 0x180071780
	public float aiStrikeDelay; // 0x2B4
	public GameObjectRef swingEffect; // 0x2B8
	public List<BaseMelee.MaterialFX> materialStrikeFX; // 0x2C0
	[HeaderAttribute] // RVA: 0xA2E80 Offset: 0xA2280 VA: 0x1800A2E80
	[RangeAttribute] // RVA: 0xA2E80 Offset: 0xA2280 VA: 0x1800A2E80
	public float heartStress; // 0x2C8
	public ResourceDispenser.GatherProperties gathering; // 0x2D0
	private bool throwReady; // 0x2D8

	// Properties
	protected virtual bool CanAttack { get; }
	protected virtual bool CanThrow { get; }

	// Methods

	// RVA: 0xA46AB0 Offset: 0xA450B0 VA: 0x180A46AB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86C910 Offset: 0x86AF10 VA: 0x18086C910 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xA45DD0 Offset: 0xA443D0 VA: 0x180A45DD0
	internal void DoThrow() { }

	// RVA: 0xA45790 Offset: 0xA43D90 VA: 0x180A45790
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0xA464C0 Offset: 0xA44AC0 VA: 0x180A464C0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA45940 Offset: 0xA43F40 VA: 0x180A45940 Slot: 160
	public virtual void DoAttackShared(HitInfo info) { }

	// RVA: 0xA466D0 Offset: 0xA44CD0 VA: 0x180A466D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 161
	protected virtual bool get_CanAttack() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 162
	protected virtual bool get_CanThrow() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 163
	public virtual void ClientAttack() { }

	// RVA: 0xA466B0 Offset: 0xA44CB0 VA: 0x180A466B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0xA46C60 Offset: 0xA45260 VA: 0x180A46C60 Slot: 164
	protected virtual void ProcessAttack(HitTest hit) { }

	// RVA: 0xA45B90 Offset: 0xA44190 VA: 0x180A45B90 Slot: 165
	protected virtual void DoAttack() { }

	// RVA: 0xA46430 Offset: 0xA44A30 VA: 0x180A46430 Slot: 166
	public virtual void DoViewmodelImpact(HitTest test) { }

	// RVA: 0xA46BA0 Offset: 0xA451A0 VA: 0x180A46BA0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA46FA0 Offset: 0xA455A0 VA: 0x180A46FA0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA46EF0 Offset: 0xA454F0 VA: 0x180A46EF0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA46520 Offset: 0xA44B20 VA: 0x180A46520
	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 167
	public virtual bool CanHit(HitTest info) { }

	// RVA: 0xA47050 Offset: 0xA45650 VA: 0x180A47050
	public float TotalDamage() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 154
	public override bool CanBeUsedInWater() { }

	// RVA: 0xA46550 Offset: 0xA44B50 VA: 0x180A46550
	public string GetStrikeEffectPath(string materialName) { }

	// RVA: 0xA471B0 Offset: 0xA457B0 VA: 0x180A471B0
	public void .ctor() { }

}

public class BaseMelee.MaterialFX // TypeDefIndex: 8524
{	// Fields
	public string materialName; // 0x10
	public GameObjectRef fx; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


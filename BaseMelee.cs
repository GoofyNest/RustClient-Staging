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

	// RVA: 0xA465C0 Offset: 0xA44BC0 VA: 0x180A465C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8895D0 Offset: 0x887BD0 VA: 0x1808895D0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xA458E0 Offset: 0xA43EE0 VA: 0x180A458E0
	internal void DoThrow() { }

	// RVA: 0xA452A0 Offset: 0xA438A0 VA: 0x180A452A0
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0xA45FD0 Offset: 0xA445D0 VA: 0x180A45FD0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA45450 Offset: 0xA43A50 VA: 0x180A45450 Slot: 160
	public virtual void DoAttackShared(HitInfo info) { }

	// RVA: 0xA461E0 Offset: 0xA447E0 VA: 0x180A461E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	protected virtual bool get_CanAttack() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	protected virtual bool get_CanThrow() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 163
	public virtual void ClientAttack() { }

	// RVA: 0xA461C0 Offset: 0xA447C0 VA: 0x180A461C0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0xA46770 Offset: 0xA44D70 VA: 0x180A46770 Slot: 164
	protected virtual void ProcessAttack(HitTest hit) { }

	// RVA: 0xA456A0 Offset: 0xA43CA0 VA: 0x180A456A0 Slot: 165
	protected virtual void DoAttack() { }

	// RVA: 0xA45F40 Offset: 0xA44540 VA: 0x180A45F40 Slot: 166
	public virtual void DoViewmodelImpact(HitTest test) { }

	// RVA: 0xA466B0 Offset: 0xA44CB0 VA: 0x180A466B0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA46AB0 Offset: 0xA450B0 VA: 0x180A46AB0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA46A00 Offset: 0xA45000 VA: 0x180A46A00 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA46030 Offset: 0xA44630 VA: 0x180A46030
	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 167
	public virtual bool CanHit(HitTest info) { }

	// RVA: 0xA46B60 Offset: 0xA45160 VA: 0x180A46B60
	public float TotalDamage() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 154
	public override bool CanBeUsedInWater() { }

	// RVA: 0xA46060 Offset: 0xA44660 VA: 0x180A46060
	public string GetStrikeEffectPath(string materialName) { }

	// RVA: 0xA46CC0 Offset: 0xA452C0 VA: 0x180A46CC0
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


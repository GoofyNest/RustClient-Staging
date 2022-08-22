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

	// RVA: 0xA46300 Offset: 0xA44900 VA: 0x180A46300 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8894C0 Offset: 0x887AC0 VA: 0x1808894C0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xA45620 Offset: 0xA43C20 VA: 0x180A45620
	internal void DoThrow() { }

	// RVA: 0xA44FE0 Offset: 0xA435E0 VA: 0x180A44FE0
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity) { }

	// RVA: 0xA45D10 Offset: 0xA44310 VA: 0x180A45D10 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0xA45190 Offset: 0xA43790 VA: 0x180A45190 Slot: 160
	public virtual void DoAttackShared(HitInfo info) { }

	// RVA: 0xA45F20 Offset: 0xA44520 VA: 0x180A45F20 Slot: 138
	public override void OnInput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	protected virtual bool get_CanAttack() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	protected virtual bool get_CanThrow() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 163
	public virtual void ClientAttack() { }

	// RVA: 0xA45F00 Offset: 0xA44500 VA: 0x180A45F00 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0xA464B0 Offset: 0xA44AB0 VA: 0x180A464B0 Slot: 164
	protected virtual void ProcessAttack(HitTest hit) { }

	// RVA: 0xA453E0 Offset: 0xA439E0 VA: 0x180A453E0 Slot: 165
	protected virtual void DoAttack() { }

	// RVA: 0xA45C80 Offset: 0xA44280 VA: 0x180A45C80 Slot: 166
	public virtual void DoViewmodelImpact(HitTest test) { }

	// RVA: 0xA463F0 Offset: 0xA449F0 VA: 0x180A463F0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xA467F0 Offset: 0xA44DF0 VA: 0x180A467F0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA46740 Offset: 0xA44D40 VA: 0x180A46740 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA45D70 Offset: 0xA44370 VA: 0x180A45D70
	public ResourceDispenser.GatherPropertyEntry GetGatherInfoFromIndex(ResourceDispenser.GatherType index) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 167
	public virtual bool CanHit(HitTest info) { }

	// RVA: 0xA468A0 Offset: 0xA44EA0 VA: 0x180A468A0
	public float TotalDamage() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 154
	public override bool CanBeUsedInWater() { }

	// RVA: 0xA45DA0 Offset: 0xA443A0 VA: 0x180A45DA0
	public string GetStrikeEffectPath(string materialName) { }

	// RVA: 0xA46A00 Offset: 0xA45000 VA: 0x180A46A00
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


public class BaseCombatEntity : BaseEntity // TypeDefIndex: 8319
{	private Option __menuOption_Menu_Pickup; // 0x168
	[HeaderAttribute] // RVA: 0xB4FD0 Offset: 0xB43D0 VA: 0x1800B4FD0
	public SkeletonProperties skeletonProperties; // 0x1C0
	public ProtectionProperties baseProtection; // 0x1C8
	public float startHealth; // 0x1D0
	public BaseCombatEntity.Pickup pickup; // 0x1D8
	public BaseCombatEntity.Repair repair; // 0x1F8
	public bool ShowHealthInfo; // 0x220
	public BaseCombatEntity.LifeState lifestate; // 0x224
	public bool sendsHitNotification; // 0x228
	public bool sendsMeleeHitNotification; // 0x229
	public bool markAttackerHostile; // 0x22A
	protected float _health; // 0x22C
	protected float _maxHealth; // 0x230
	public BaseCombatEntity.Faction faction; // 0x234
	protected float deathTime; // 0x238
	private int lastNotifyFrame; // 0x23C

	public override bool HasMenuOptions { get; }
	public float SecondsSinceDeath { get; }
	public float healthFraction { get; }
	public float health { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void HitNotify(BaseEntity.RPCMessage rpc) { }

	protected override void ClientInit(Entity info) { }

	public virtual bool DisplayHealthInfo(BasePlayer player) { }

	internal override Transform GetEyeTransform() { }

	protected virtual void OnLifeStateChanged() { }

	protected virtual int GetPickupCount() { }

	public virtual bool CanPickup(BasePlayer player) { }

	public virtual void OnPickedUp(Item createdItem, BasePlayer player) { }

	public virtual void OnPickedUpPreItemMove(Item createdItem, BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB65D0 Offset: 0xB59D0 VA: 0x1800B65D0
	[BaseEntity.Menu.Description] // RVA: 0xB65D0 Offset: 0xB59D0 VA: 0x1800B65D0
	[BaseEntity.Menu.Icon] // RVA: 0xB65D0 Offset: 0xB59D0 VA: 0x1800B65D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB65D0 Offset: 0xB59D0 VA: 0x1800B65D0
	public void Menu_Pickup(BasePlayer player) { }

	public void Menu_Pickup_TimeStart() { }

	public bool Menu_Pickup_If(BasePlayer player) { }

	public virtual List<ItemAmount> BuildCost() { }

	public virtual bool IsDead() { }

	public virtual bool IsAlive() { }

	public BaseCombatEntity.Faction GetFaction() { }

	public virtual bool IsFriendly(BaseCombatEntity other) { }

	public float get_SecondsSinceDeath() { }

	public float get_healthFraction() { }

	public override void ResetState() { }

	public override void DestroyShared() { }

	public virtual float GetThreatLevel() { }

	public override float PenetrationResistance(HitInfo info) { }

	public virtual void ScaleDamage(HitInfo info) { }

	public HitArea SkeletonLookup(uint boneID) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float get_health() { }

	public void set_health(float value) { }

	public override float Health() { }

	public override float MaxHealth() { }

	public virtual float StartHealth() { }

	public virtual float StartMaxHealth() { }

	public void SetMaxHealth(float newMax) { }

	public void DoHitNotify(HitInfo info) { }

	public override void OnAttacked(HitInfo info) { }

	public void .ctor() { }

}

public struct BaseCombatEntity.Pickup // TypeDefIndex: 8320
{	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition itemTarget; // 0x8
	public int itemCount; // 0x10
	[TooltipAttribute] // RVA: 0xB6B60 Offset: 0xB5F60 VA: 0x1800B6B60
	public bool setConditionFromHealth; // 0x14
	[TooltipAttribute] // RVA: 0xB6C50 Offset: 0xB6050 VA: 0x1800B6C50
	public float subtractCondition; // 0x18
	[TooltipAttribute] // RVA: 0xB6CC0 Offset: 0xB60C0 VA: 0x1800B6CC0
	public bool requireBuildingPrivilege; // 0x1C
	[TooltipAttribute] // RVA: 0xB6DE0 Offset: 0xB61E0 VA: 0x1800B6DE0
	public bool requireHammer; // 0x1D
	[TooltipAttribute] // RVA: 0xB6F50 Offset: 0xB6350 VA: 0x1800B6F50
	public bool requireEmptyInv; // 0x1E

}

public struct BaseCombatEntity.Repair // TypeDefIndex: 8321
{	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7740 Offset: 0xA6B40 VA: 0x1800A7740
	public ItemDefinition itemTarget; // 0x8
	public GameObjectRef repairEffect; // 0x10
	public GameObjectRef repairFullEffect; // 0x18
	public GameObjectRef repairFailedEffect; // 0x20

}

public enum BaseCombatEntity.LifeState // TypeDefIndex: 8322
{	public int value__; // 0x0
	public const BaseCombatEntity.LifeState Alive = 0;
	public const BaseCombatEntity.LifeState Dead = 1;

}

public enum BaseCombatEntity.Faction // TypeDefIndex: 8323
{	public int value__; // 0x0
	public const BaseCombatEntity.Faction Default = 0;
	public const BaseCombatEntity.Faction Player = 1;
	public const BaseCombatEntity.Faction Bandit = 2;
	public const BaseCombatEntity.Faction Scientist = 3;
	public const BaseCombatEntity.Faction Horror = 4;

}


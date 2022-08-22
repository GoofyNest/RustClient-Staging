public class BaseCombatEntity : BaseEntity // TypeDefIndex: 8319
{	// Fields
	private Option __menuOption_Menu_Pickup; // 0x168
	[HeaderAttribute] // RVA: 0xB4D40 Offset: 0xB4140 VA: 0x1800B4D40
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

	// Properties
	public override bool HasMenuOptions { get; }
	public float SecondsSinceDeath { get; }
	public float healthFraction { get; }
	public float health { get; set; }

	// Methods

	// RVA: 0x7A2E20 Offset: 0x7A1420 VA: 0x1807A2E20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A4020 Offset: 0x7A2620 VA: 0x1807A4020 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A3570 Offset: 0x7A1B70 VA: 0x1807A3570 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7A3180 Offset: 0x7A1780 VA: 0x1807A3180
	public void HitNotify(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x7A2830 Offset: 0x7A0E30 VA: 0x1807A2830 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x506480 Offset: 0x504A80 VA: 0x180506480 Slot: 131
	public virtual bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7A2D00 Offset: 0x7A1300 VA: 0x1807A2D00 Slot: 71
	internal override Transform GetEyeTransform() { }

	// RVA: 0x7A3540 Offset: 0x7A1B40 VA: 0x1807A3540 Slot: 132
	protected virtual void OnLifeStateChanged() { }

	// RVA: 0x7A3160 Offset: 0x7A1760 VA: 0x1807A3160 Slot: 133
	protected virtual int GetPickupCount() { }

	// RVA: 0x7A2790 Offset: 0x7A0D90 VA: 0x1807A2790 Slot: 134
	public virtual bool CanPickup(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void OnPickedUp(Item createdItem, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 136
	public virtual void OnPickedUpPreItemMove(Item createdItem, BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.Description] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.Icon] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	// RVA: 0x7A3410 Offset: 0x7A1A10 VA: 0x1807A3410
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Pickup_TimeStart() { }

	// RVA: 0x7A33F0 Offset: 0x7A19F0 VA: 0x1807A33F0
	public bool Menu_Pickup_If(BasePlayer player) { }

	// RVA: 0x7A26C0 Offset: 0x7A0CC0 VA: 0x1807A26C0 Slot: 137
	public virtual List<ItemAmount> BuildCost() { }

	// RVA: 0x7A3330 Offset: 0x7A1930 VA: 0x1807A3330 Slot: 138
	public virtual bool IsDead() { }

	// RVA: 0x7A3320 Offset: 0x7A1920 VA: 0x1807A3320 Slot: 139
	public virtual bool IsAlive() { }

	// RVA: 0x7A2E10 Offset: 0x7A1410 VA: 0x1807A2E10
	public BaseCombatEntity.Faction GetFaction() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 140
	public virtual bool IsFriendly(BaseCombatEntity other) { }

	// RVA: 0x7A40E0 Offset: 0x7A26E0 VA: 0x1807A40E0
	public float get_SecondsSinceDeath() { }

	// RVA: 0x7A4100 Offset: 0x7A2700 VA: 0x1807A4100
	public float get_healthFraction() { }

	// RVA: 0x7A3BB0 Offset: 0x7A21B0 VA: 0x1807A3BB0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7A2910 Offset: 0x7A0F10 VA: 0x1807A2910 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 141
	public virtual float GetThreatLevel() { }

	// RVA: 0x7A3B20 Offset: 0x7A2120 VA: 0x1807A3B20 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7A3CB0 Offset: 0x7A22B0 VA: 0x1807A3CB0 Slot: 142
	public virtual void ScaleDamage(HitInfo info) { }

	// RVA: 0x7A3DF0 Offset: 0x7A23F0 VA: 0x1807A3DF0
	public HitArea SkeletonLookup(uint boneID) { }

	// RVA: 0x7A3340 Offset: 0x7A1940 VA: 0x1807A3340 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7A3170 Offset: 0x7A1770 VA: 0x1807A3170
	public float get_health() { }

	// RVA: 0x7A4150 Offset: 0x7A2750 VA: 0x1807A4150
	public void set_health(float value) { }

	// RVA: 0x7A3170 Offset: 0x7A1770 VA: 0x1807A3170 Slot: 110
	public override float Health() { }

	// RVA: 0x7A33E0 Offset: 0x7A19E0 VA: 0x1807A33E0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x745BD0 Offset: 0x7441D0 VA: 0x180745BD0 Slot: 143
	public virtual float StartHealth() { }

	// RVA: 0x7A3EA0 Offset: 0x7A24A0 VA: 0x1807A3EA0 Slot: 144
	public virtual float StartMaxHealth() { }

	// RVA: 0x7A3D60 Offset: 0x7A2360 VA: 0x1807A3D60
	public void SetMaxHealth(float newMax) { }

	// RVA: 0x7A2930 Offset: 0x7A0F30 VA: 0x1807A2930
	public void DoHitNotify(HitInfo info) { }

	// RVA: 0x7A3450 Offset: 0x7A1A50 VA: 0x1807A3450 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7A3EC0 Offset: 0x7A24C0 VA: 0x1807A3EC0
	public void .ctor() { }

}

public struct BaseCombatEntity.Pickup // TypeDefIndex: 8320
{	// Fields
	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemTarget; // 0x8
	public int itemCount; // 0x10
	[TooltipAttribute] // RVA: 0xB6990 Offset: 0xB5D90 VA: 0x1800B6990
	public bool setConditionFromHealth; // 0x14
	[TooltipAttribute] // RVA: 0xB6AB0 Offset: 0xB5EB0 VA: 0x1800B6AB0
	public float subtractCondition; // 0x18
	[TooltipAttribute] // RVA: 0xB6B10 Offset: 0xB5F10 VA: 0x1800B6B10
	public bool requireBuildingPrivilege; // 0x1C
	[TooltipAttribute] // RVA: 0xB6C60 Offset: 0xB6060 VA: 0x1800B6C60
	public bool requireHammer; // 0x1D
	[TooltipAttribute] // RVA: 0xB6E00 Offset: 0xB6200 VA: 0x1800B6E00
	public bool requireEmptyInv; // 0x1E

}

public struct BaseCombatEntity.Repair // TypeDefIndex: 8321
{	// Fields
	public bool enabled; // 0x0
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemTarget; // 0x8
	public GameObjectRef repairEffect; // 0x10
	public GameObjectRef repairFullEffect; // 0x18
	public GameObjectRef repairFailedEffect; // 0x20

}

public enum BaseCombatEntity.LifeState // TypeDefIndex: 8322
{	// Fields
	public int value__; // 0x0
	public const BaseCombatEntity.LifeState Alive = 0;
	public const BaseCombatEntity.LifeState Dead = 1;

}

public enum BaseCombatEntity.Faction // TypeDefIndex: 8323
{	// Fields
	public int value__; // 0x0
	public const BaseCombatEntity.Faction Default = 0;
	public const BaseCombatEntity.Faction Player = 1;
	public const BaseCombatEntity.Faction Bandit = 2;
	public const BaseCombatEntity.Faction Scientist = 3;
	public const BaseCombatEntity.Faction Horror = 4;

}


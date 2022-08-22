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

	// RVA: 0x7D73F0 Offset: 0x7D59F0 VA: 0x1807D73F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D85F0 Offset: 0x7D6BF0 VA: 0x1807D85F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D7B40 Offset: 0x7D6140 VA: 0x1807D7B40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D7750 Offset: 0x7D5D50 VA: 0x1807D7750
	public void HitNotify(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x7D6E00 Offset: 0x7D5400 VA: 0x1807D6E00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5064F0 Offset: 0x504AF0 VA: 0x1805064F0 Slot: 131
	public virtual bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7D72D0 Offset: 0x7D58D0 VA: 0x1807D72D0 Slot: 71
	internal override Transform GetEyeTransform() { }

	// RVA: 0x7D7B10 Offset: 0x7D6110 VA: 0x1807D7B10 Slot: 132
	protected virtual void OnLifeStateChanged() { }

	// RVA: 0x7D7730 Offset: 0x7D5D30 VA: 0x1807D7730 Slot: 133
	protected virtual int GetPickupCount() { }

	// RVA: 0x7D6D60 Offset: 0x7D5360 VA: 0x1807D6D60 Slot: 134
	public virtual bool CanPickup(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void OnPickedUp(Item createdItem, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 136
	public virtual void OnPickedUpPreItemMove(Item createdItem, BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.Description] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.Icon] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	// RVA: 0x7D79E0 Offset: 0x7D5FE0 VA: 0x1807D79E0
	public void Menu_Pickup(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Pickup_TimeStart() { }

	// RVA: 0x7D79C0 Offset: 0x7D5FC0 VA: 0x1807D79C0
	public bool Menu_Pickup_If(BasePlayer player) { }

	// RVA: 0x7D6C90 Offset: 0x7D5290 VA: 0x1807D6C90 Slot: 137
	public virtual List<ItemAmount> BuildCost() { }

	// RVA: 0x7D7900 Offset: 0x7D5F00 VA: 0x1807D7900 Slot: 138
	public virtual bool IsDead() { }

	// RVA: 0x7D78F0 Offset: 0x7D5EF0 VA: 0x1807D78F0 Slot: 139
	public virtual bool IsAlive() { }

	// RVA: 0x7D73E0 Offset: 0x7D59E0 VA: 0x1807D73E0
	public BaseCombatEntity.Faction GetFaction() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 140
	public virtual bool IsFriendly(BaseCombatEntity other) { }

	// RVA: 0x7D86B0 Offset: 0x7D6CB0 VA: 0x1807D86B0
	public float get_SecondsSinceDeath() { }

	// RVA: 0x7D86D0 Offset: 0x7D6CD0 VA: 0x1807D86D0
	public float get_healthFraction() { }

	// RVA: 0x7D8180 Offset: 0x7D6780 VA: 0x1807D8180 Slot: 27
	public override void ResetState() { }

	// RVA: 0x7D6EE0 Offset: 0x7D54E0 VA: 0x1807D6EE0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 141
	public virtual float GetThreatLevel() { }

	// RVA: 0x7D80F0 Offset: 0x7D66F0 VA: 0x1807D80F0 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7D8280 Offset: 0x7D6880 VA: 0x1807D8280 Slot: 142
	public virtual void ScaleDamage(HitInfo info) { }

	// RVA: 0x7D83C0 Offset: 0x7D69C0 VA: 0x1807D83C0
	public HitArea SkeletonLookup(uint boneID) { }

	// RVA: 0x7D7910 Offset: 0x7D5F10 VA: 0x1807D7910 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D7740 Offset: 0x7D5D40 VA: 0x1807D7740
	public float get_health() { }

	// RVA: 0x7D8720 Offset: 0x7D6D20 VA: 0x1807D8720
	public void set_health(float value) { }

	// RVA: 0x7D7740 Offset: 0x7D5D40 VA: 0x1807D7740 Slot: 110
	public override float Health() { }

	// RVA: 0x7D79B0 Offset: 0x7D5FB0 VA: 0x1807D79B0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x745B70 Offset: 0x744170 VA: 0x180745B70 Slot: 143
	public virtual float StartHealth() { }

	// RVA: 0x7D8470 Offset: 0x7D6A70 VA: 0x1807D8470 Slot: 144
	public virtual float StartMaxHealth() { }

	// RVA: 0x7D8330 Offset: 0x7D6930 VA: 0x1807D8330
	public void SetMaxHealth(float newMax) { }

	// RVA: 0x7D6F00 Offset: 0x7D5500 VA: 0x1807D6F00
	public void DoHitNotify(HitInfo info) { }

	// RVA: 0x7D7A20 Offset: 0x7D6020 VA: 0x1807D7A20 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7D8490 Offset: 0x7D6A90 VA: 0x1807D8490
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


public class TrainCarUnloadable : TrainCar // TypeDefIndex: 8470
{	// Fields
	private Option __menuOption_Menu_Open; // 0x538
	[HeaderAttribute] // RVA: 0x93FE0 Offset: 0x933E0 VA: 0x180093FE0
	[SerializeField] // RVA: 0x93FE0 Offset: 0x933E0 VA: 0x180093FE0
	private GameObjectRef storagePrefab; // 0x590
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BoxCollider[] unloadingAreas; // 0x598
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainCarFuelHatches fuelHatches; // 0x5A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform orePlaneVisuals; // 0x5A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform orePlaneColliderDetailed; // 0x5B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform orePlaneColliderWorld; // 0x5B8
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	public float vacuumStretchPercent; // 0x5C0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystemContainer unloadingFXContainer; // 0x5C8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem unloadingFX; // 0x5D0
	public TrainCarUnloadable.WagonType wagonType; // 0x5D8
	private int lootTypeIndex; // 0x5DC
	private List<EntityRef<LootContainer>> lootContainers; // 0x5E0
	private Vector3 _oreScale; // 0x5E8
	private float animPercent; // 0x5F4
	private float prevAnimTime; // 0x5F8
	[ServerVar] // RVA: 0x945B0 Offset: 0x939B0 VA: 0x1800945B0
	public static float decayminutesafterunload; // 0x0
	private List<MeshRenderer> orePlaneRenderers; // 0x600
	private float clientOrePercentFull; // 0x608

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA0CE80 Offset: 0xA0B480 VA: 0x180A0CE80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA0E820 Offset: 0xA0CE20 VA: 0x180A0E820 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA0D610 Offset: 0xA0BC10 VA: 0x180A0D610 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0D490 Offset: 0xA0BA90 VA: 0x180A0D490 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA0D3A0 Offset: 0xA0B9A0 VA: 0x180A0D3A0 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA0D200 Offset: 0xA0B800 VA: 0x180A0D200 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA0D1C0 Offset: 0xA0B7C0 VA: 0x180A0D1C0
	public bool IsEmpty() { }

	// RVA: 0xA0E5E0 Offset: 0xA0CBE0 VA: 0x180A0E5E0
	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0xA0CB00 Offset: 0xA0B100 VA: 0x180A0CB00 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA0CD80 Offset: 0xA0B380 VA: 0x180A0CD80
	public int GetFilledLootAmount() { }

	// RVA: 0xA0E440 Offset: 0xA0CA40 VA: 0x180A0E440
	public void SetVisualOreLevel(float percent) { }

	// RVA: 0xA0CA00 Offset: 0xA0B000 VA: 0x180A0CA00
	private void AnimateUnload(float startPercent) { }

	// RVA: 0xA0E650 Offset: 0xA0CC50 VA: 0x180A0E650
	private void UnloadAnimTick() { }

	// RVA: 0xA0CCB0 Offset: 0xA0B2B0 VA: 0x180A0CCB0
	private void EndUnloadAnim() { }

	// RVA: 0xA0D190 Offset: 0xA0B790 VA: 0x180A0D190
	public float GetOrePercent() { }

	// RVA: 0xA0CB50 Offset: 0xA0B150 VA: 0x180A0CB50 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA0CC20 Offset: 0xA0B220 VA: 0x180A0CC20 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA0E1F0 Offset: 0xA0C7F0 VA: 0x180A0E1F0
	private void SetOreMat() { }

	// RVA: 0xA0E010 Offset: 0xA0C610 VA: 0x180A0E010
	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xA0D360 Offset: 0xA0B960 VA: 0x180A0D360
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xA0D290 Offset: 0xA0B890 VA: 0x180A0D290
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0DE80 Offset: 0xA0C480 VA: 0x180A0DE80
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0DFB0 Offset: 0xA0C5B0 VA: 0x180A0DFB0
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA0E710 Offset: 0xA0CD10 VA: 0x180A0E710
	public void .ctor() { }

	// RVA: 0xA0E6D0 Offset: 0xA0CCD0 VA: 0x180A0E6D0
	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 8471
{	// Fields
	public int value__; // 0x0
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}


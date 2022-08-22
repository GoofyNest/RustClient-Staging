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

	// RVA: 0xA0CBC0 Offset: 0xA0B1C0 VA: 0x180A0CBC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA0E560 Offset: 0xA0CB60 VA: 0x180A0E560 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA0D350 Offset: 0xA0B950 VA: 0x180A0D350 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0D1D0 Offset: 0xA0B7D0 VA: 0x180A0D1D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA0D0E0 Offset: 0xA0B6E0 VA: 0x180A0D0E0 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA0CF40 Offset: 0xA0B540 VA: 0x180A0CF40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA0CF00 Offset: 0xA0B500 VA: 0x180A0CF00
	public bool IsEmpty() { }

	// RVA: 0xA0E320 Offset: 0xA0C920 VA: 0x180A0E320
	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0xA0C840 Offset: 0xA0AE40 VA: 0x180A0C840 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA0CAC0 Offset: 0xA0B0C0 VA: 0x180A0CAC0
	public int GetFilledLootAmount() { }

	// RVA: 0xA0E180 Offset: 0xA0C780 VA: 0x180A0E180
	public void SetVisualOreLevel(float percent) { }

	// RVA: 0xA0C740 Offset: 0xA0AD40 VA: 0x180A0C740
	private void AnimateUnload(float startPercent) { }

	// RVA: 0xA0E390 Offset: 0xA0C990 VA: 0x180A0E390
	private void UnloadAnimTick() { }

	// RVA: 0xA0C9F0 Offset: 0xA0AFF0 VA: 0x180A0C9F0
	private void EndUnloadAnim() { }

	// RVA: 0xA0CED0 Offset: 0xA0B4D0 VA: 0x180A0CED0
	public float GetOrePercent() { }

	// RVA: 0xA0C890 Offset: 0xA0AE90 VA: 0x180A0C890 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA0C960 Offset: 0xA0AF60 VA: 0x180A0C960 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA0DF30 Offset: 0xA0C530 VA: 0x180A0DF30
	private void SetOreMat() { }

	// RVA: 0xA0DD50 Offset: 0xA0C350 VA: 0x180A0DD50
	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xA0D0A0 Offset: 0xA0B6A0 VA: 0x180A0D0A0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xA0CFD0 Offset: 0xA0B5D0 VA: 0x180A0CFD0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0DBC0 Offset: 0xA0C1C0 VA: 0x180A0DBC0
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0DCF0 Offset: 0xA0C2F0 VA: 0x180A0DCF0
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA0E450 Offset: 0xA0CA50 VA: 0x180A0E450
	public void .ctor() { }

	// RVA: 0xA0E410 Offset: 0xA0CA10 VA: 0x180A0E410
	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 8471
{	// Fields
	public int value__; // 0x0
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}


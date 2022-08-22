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

	// RVA: 0xA0D370 Offset: 0xA0B970 VA: 0x180A0D370 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA0ED10 Offset: 0xA0D310 VA: 0x180A0ED10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA0DB00 Offset: 0xA0C100 VA: 0x180A0DB00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA0D980 Offset: 0xA0BF80 VA: 0x180A0D980 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA0D890 Offset: 0xA0BE90 VA: 0x180A0D890 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA0D6F0 Offset: 0xA0BCF0 VA: 0x180A0D6F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA0D6B0 Offset: 0xA0BCB0 VA: 0x180A0D6B0
	public bool IsEmpty() { }

	// RVA: 0xA0EAD0 Offset: 0xA0D0D0 VA: 0x180A0EAD0
	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0xA0CFF0 Offset: 0xA0B5F0 VA: 0x180A0CFF0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xA0D270 Offset: 0xA0B870 VA: 0x180A0D270
	public int GetFilledLootAmount() { }

	// RVA: 0xA0E930 Offset: 0xA0CF30 VA: 0x180A0E930
	public void SetVisualOreLevel(float percent) { }

	// RVA: 0xA0CEF0 Offset: 0xA0B4F0 VA: 0x180A0CEF0
	private void AnimateUnload(float startPercent) { }

	// RVA: 0xA0EB40 Offset: 0xA0D140 VA: 0x180A0EB40
	private void UnloadAnimTick() { }

	// RVA: 0xA0D1A0 Offset: 0xA0B7A0 VA: 0x180A0D1A0
	private void EndUnloadAnim() { }

	// RVA: 0xA0D680 Offset: 0xA0BC80 VA: 0x180A0D680
	public float GetOrePercent() { }

	// RVA: 0xA0D040 Offset: 0xA0B640 VA: 0x180A0D040 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA0D110 Offset: 0xA0B710 VA: 0x180A0D110 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xA0E6E0 Offset: 0xA0CCE0 VA: 0x180A0E6E0
	private void SetOreMat() { }

	// RVA: 0xA0E500 Offset: 0xA0CB00 VA: 0x180A0E500
	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Description] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.Icon] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x946C0 Offset: 0x93AC0 VA: 0x1800946C0
	// RVA: 0xA0D850 Offset: 0xA0BE50 VA: 0x180A0D850
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xA0D780 Offset: 0xA0BD80 VA: 0x180A0D780
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0E370 Offset: 0xA0C970 VA: 0x180A0E370
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA0E4A0 Offset: 0xA0CAA0 VA: 0x180A0E4A0
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA0EC00 Offset: 0xA0D200 VA: 0x180A0EC00
	public void .ctor() { }

	// RVA: 0xA0EBC0 Offset: 0xA0D1C0 VA: 0x180A0EBC0
	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 8471
{	// Fields
	public int value__; // 0x0
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}


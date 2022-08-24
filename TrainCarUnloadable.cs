public class TrainCarUnloadable : TrainCar // TypeDefIndex: 8470
{	private Option __menuOption_Menu_Open; // 0x538
	[HeaderAttribute] // RVA: 0x940C0 Offset: 0x934C0 VA: 0x1800940C0
	[SerializeField] // RVA: 0x940C0 Offset: 0x934C0 VA: 0x1800940C0
	private GameObjectRef storagePrefab; // 0x590
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private BoxCollider[] unloadingAreas; // 0x598
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private TrainCarFuelHatches fuelHatches; // 0x5A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform orePlaneVisuals; // 0x5A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform orePlaneColliderDetailed; // 0x5B0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform orePlaneColliderWorld; // 0x5B8
	[SerializeField] // RVA: 0x76750 Offset: 0x75B50 VA: 0x180076750
	[RangeAttribute] // RVA: 0x76750 Offset: 0x75B50 VA: 0x180076750
	public float vacuumStretchPercent; // 0x5C0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystemContainer unloadingFXContainer; // 0x5C8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem unloadingFX; // 0x5D0
	public TrainCarUnloadable.WagonType wagonType; // 0x5D8
	private int lootTypeIndex; // 0x5DC
	private List<EntityRef<LootContainer>> lootContainers; // 0x5E0
	private Vector3 _oreScale; // 0x5E8
	private float animPercent; // 0x5F4
	private float prevAnimTime; // 0x5F8
	[ServerVar] // RVA: 0x94700 Offset: 0x93B00 VA: 0x180094700
	public static float decayminutesafterunload; // 0x0
	private List<MeshRenderer> orePlaneRenderers; // 0x600
	private float clientOrePercentFull; // 0x608

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected override void OnChildAdded(BaseEntity child) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool IsEmpty() { }

	public bool TryGetLootType(out TrainWagonLootData.LootOption lootOption) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public int GetFilledLootAmount() { }

	public void SetVisualOreLevel(float percent) { }

	private void AnimateUnload(float startPercent) { }

	private void UnloadAnimTick() { }

	private void EndUnloadAnim() { }

	public float GetOrePercent() { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	private void SetOreMat() { }

	private void SetClientOrePercent(float percent) { }

	[BaseEntity.Menu] // RVA: 0x94810 Offset: 0x93C10 VA: 0x180094810
	[BaseEntity.Menu.Description] // RVA: 0x94810 Offset: 0x93C10 VA: 0x180094810
	[BaseEntity.Menu.Icon] // RVA: 0x94810 Offset: 0x93C10 VA: 0x180094810
	[BaseEntity.Menu.ShowIf] // RVA: 0x94810 Offset: 0x93C10 VA: 0x180094810
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void RPC_AnimateUnload(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void RPC_StopAnimateUnload(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum TrainCarUnloadable.WagonType // TypeDefIndex: 8471
{	public int value__; // 0x0
	public const TrainCarUnloadable.WagonType Ore = 0;
	public const TrainCarUnloadable.WagonType Lootboxes = 1;
	public const TrainCarUnloadable.WagonType Fuel = 2;

}


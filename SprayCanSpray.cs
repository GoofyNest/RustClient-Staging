public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8454
{	// Fields
	private Option __menuOption_Menu_WaterClear; // 0x258

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA83AE0 Offset: 0xA820E0 VA: 0x180A83AE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA84000 Offset: 0xA82600 VA: 0x180A84000 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA83F10 Offset: 0xA82510 VA: 0x180A83F10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.Description] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.Icon] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	// RVA: 0xA83ED0 Offset: 0xA824D0 VA: 0x180A83ED0
	private void Menu_WaterClear(BasePlayer player) { }

	// RVA: 0xA83DF0 Offset: 0xA823F0 VA: 0x180A83DF0
	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	// RVA: 0x932540 Offset: 0x930B40 VA: 0x180932540
	public void .ctor() { }

}

public class SprayCanSpray_Freehand : SprayCanSpray // TypeDefIndex: 8649
{	// Fields
	public AlignedLineDrawer LineDrawer; // 0x2B0
	public List<AlignedLineDrawer.LinePoint> LinePoints; // 0x2B8
	private Color colour; // 0x2C0
	private float width; // 0x2D0
	private EntityRef<BasePlayer> editingPlayer; // 0x2D8
	public GroundWatch groundWatch; // 0x2E8
	public MeshCollider meshCollider; // 0x2F0
	public const int MaxLinePointLength = 60;
	public const float SimplifyTolerance = 0,008;
	private SprayCan attachedToCan; // 0x2F8
	private bool hasAttachedToSpray; // 0x300
	private TimeSince lastServerUpdate; // 0x304
	private bool firstSpray; // 0x308

	// Properties
	private bool CanDrawSpray { get; }

	// Methods

	// RVA: 0xA831B0 Offset: 0xA817B0 VA: 0x180A831B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA832A0 Offset: 0xA818A0 VA: 0x180A832A0
	public static void RebuildAll() { }

	// RVA: 0xA82B20 Offset: 0xA81120 VA: 0x180A82B20
	public void FinishEditing(bool allowNewSprayImmediately, List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA83550 Offset: 0xA81B50 VA: 0x180A83550
	private void UpdateMeshCollider() { }

	// RVA: 0xA83590 Offset: 0xA81B90 VA: 0x180A83590
	public void UpdatePointsMidSpray(List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA838E0 Offset: 0xA81EE0 VA: 0x180A838E0
	private bool get_CanDrawSpray() { }

	// RVA: 0xA82E30 Offset: 0xA81430 VA: 0x180A82E30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA824F0 Offset: 0xA80AF0 VA: 0x180A824F0
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<LinePoint> to) { }

	// RVA: 0xA82990 Offset: 0xA80F90 VA: 0x180A82990
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<Vector3> to) { }

	// RVA: 0xA82800 Offset: 0xA80E00 VA: 0x180A82800
	private void CopyPoints(List<LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA826A0 Offset: 0xA80CA0 VA: 0x180A826A0
	public static void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA83500 Offset: 0xA81B00 VA: 0x180A83500 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA83850 Offset: 0xA81E50 VA: 0x180A83850
	public void .ctor() { }

}

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8883
{	// Fields
	public DeferredDecal DecalComponent; // 0x2B0
	public GameObject IconPreviewRoot; // 0x2B8
	public Material DefaultMaterial; // 0x2C0

	// Methods

	// RVA: 0xA823D0 Offset: 0xA809D0 VA: 0x180A823D0
	public void WorkshopMode() { }

	// RVA: 0xA822D0 Offset: 0xA808D0 VA: 0x180A822D0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA82210 Offset: 0xA80810 VA: 0x180A82210 Slot: 145
	public void Replace(Material[] find, Material[] replace) { }

	// RVA: 0xA821D0 Offset: 0xA807D0 VA: 0x180A821D0 Slot: 146
	public void PreRender() { }

	// RVA: 0xA82190 Offset: 0xA80790 VA: 0x180A82190 Slot: 147
	public void PostRender() { }

	// RVA: 0xA823A0 Offset: 0xA809A0 VA: 0x180A823A0 Slot: 148
	public void Show() { }

	// RVA: 0xA82160 Offset: 0xA80760 VA: 0x180A82160 Slot: 149
	public void Hide() { }

	// RVA: 0x932540 Offset: 0x930B40 VA: 0x180932540
	public void .ctor() { }

}


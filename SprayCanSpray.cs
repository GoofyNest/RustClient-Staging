public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8454
{	// Fields
	private Option __menuOption_Menu_WaterClear; // 0x258

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA83610 Offset: 0xA81C10 VA: 0x180A83610 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA83B30 Offset: 0xA82130 VA: 0x180A83B30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA83A40 Offset: 0xA82040 VA: 0x180A83A40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.Description] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.Icon] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DA10 Offset: 0x8CE10 VA: 0x18008DA10
	// RVA: 0xA83A00 Offset: 0xA82000 VA: 0x180A83A00
	private void Menu_WaterClear(BasePlayer player) { }

	// RVA: 0xA83920 Offset: 0xA81F20 VA: 0x180A83920
	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	// RVA: 0x932030 Offset: 0x930630 VA: 0x180932030
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

	// RVA: 0xA82CE0 Offset: 0xA812E0 VA: 0x180A82CE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA82DD0 Offset: 0xA813D0 VA: 0x180A82DD0
	public static void RebuildAll() { }

	// RVA: 0xA82650 Offset: 0xA80C50 VA: 0x180A82650
	public void FinishEditing(bool allowNewSprayImmediately, List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA83080 Offset: 0xA81680 VA: 0x180A83080
	private void UpdateMeshCollider() { }

	// RVA: 0xA830C0 Offset: 0xA816C0 VA: 0x180A830C0
	public void UpdatePointsMidSpray(List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA83410 Offset: 0xA81A10 VA: 0x180A83410
	private bool get_CanDrawSpray() { }

	// RVA: 0xA82960 Offset: 0xA80F60 VA: 0x180A82960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA82020 Offset: 0xA80620 VA: 0x180A82020
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<LinePoint> to) { }

	// RVA: 0xA824C0 Offset: 0xA80AC0 VA: 0x180A824C0
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<Vector3> to) { }

	// RVA: 0xA82330 Offset: 0xA80930 VA: 0x180A82330
	private void CopyPoints(List<LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA821D0 Offset: 0xA807D0 VA: 0x180A821D0
	public static void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA83030 Offset: 0xA81630 VA: 0x180A83030 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA83380 Offset: 0xA81980 VA: 0x180A83380
	public void .ctor() { }

}

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8883
{	// Fields
	public DeferredDecal DecalComponent; // 0x2B0
	public GameObject IconPreviewRoot; // 0x2B8
	public Material DefaultMaterial; // 0x2C0

	// Methods

	// RVA: 0xA81F00 Offset: 0xA80500 VA: 0x180A81F00
	public void WorkshopMode() { }

	// RVA: 0xA81E00 Offset: 0xA80400 VA: 0x180A81E00 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA81D40 Offset: 0xA80340 VA: 0x180A81D40 Slot: 145
	public void Replace(Material[] find, Material[] replace) { }

	// RVA: 0xA81D00 Offset: 0xA80300 VA: 0x180A81D00 Slot: 146
	public void PreRender() { }

	// RVA: 0xA81CC0 Offset: 0xA802C0 VA: 0x180A81CC0 Slot: 147
	public void PostRender() { }

	// RVA: 0xA81ED0 Offset: 0xA804D0 VA: 0x180A81ED0 Slot: 148
	public void Show() { }

	// RVA: 0xA81C90 Offset: 0xA80290 VA: 0x180A81C90 Slot: 149
	public void Hide() { }

	// RVA: 0x932030 Offset: 0x930630 VA: 0x180932030
	public void .ctor() { }

}


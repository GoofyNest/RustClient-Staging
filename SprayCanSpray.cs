public class SprayCanSpray : DecayEntity, ISplashable // TypeDefIndex: 8454
{	// Fields
	private Option __menuOption_Menu_WaterClear; // 0x258

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA83350 Offset: 0xA81950 VA: 0x180A83350 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA83870 Offset: 0xA81E70 VA: 0x180A83870 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA83780 Offset: 0xA81D80 VA: 0x180A83780 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8D990 Offset: 0x8CD90 VA: 0x18008D990
	[BaseEntity.Menu.Description] // RVA: 0x8D990 Offset: 0x8CD90 VA: 0x18008D990
	[BaseEntity.Menu.Icon] // RVA: 0x8D990 Offset: 0x8CD90 VA: 0x18008D990
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D990 Offset: 0x8CD90 VA: 0x18008D990
	// RVA: 0xA83740 Offset: 0xA81D40 VA: 0x180A83740
	private void Menu_WaterClear(BasePlayer player) { }

	// RVA: 0xA83660 Offset: 0xA81C60 VA: 0x180A83660
	private bool Menu_WaterClear_ShowIf(BasePlayer player) { }

	// RVA: 0x931F20 Offset: 0x930520 VA: 0x180931F20
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

	// RVA: 0xA82A20 Offset: 0xA81020 VA: 0x180A82A20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA82B10 Offset: 0xA81110 VA: 0x180A82B10
	public static void RebuildAll() { }

	// RVA: 0xA82390 Offset: 0xA80990 VA: 0x180A82390
	public void FinishEditing(bool allowNewSprayImmediately, List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA82DC0 Offset: 0xA813C0 VA: 0x180A82DC0
	private void UpdateMeshCollider() { }

	// RVA: 0xA82E00 Offset: 0xA81400 VA: 0x180A82E00
	public void UpdatePointsMidSpray(List<AlignedLineDrawer.LinePoint> points) { }

	// RVA: 0xA83150 Offset: 0xA81750 VA: 0x180A83150
	private bool get_CanDrawSpray() { }

	// RVA: 0xA826A0 Offset: 0xA80CA0 VA: 0x180A826A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA81D60 Offset: 0xA80360 VA: 0x180A81D60
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<LinePoint> to) { }

	// RVA: 0xA82200 Offset: 0xA80800 VA: 0x180A82200
	private void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<Vector3> to) { }

	// RVA: 0xA82070 Offset: 0xA80670 VA: 0x180A82070
	private void CopyPoints(List<LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA81F10 Offset: 0xA80510 VA: 0x180A81F10
	public static void CopyPoints(List<AlignedLineDrawer.LinePoint> from, List<AlignedLineDrawer.LinePoint> to) { }

	// RVA: 0xA82D70 Offset: 0xA81370 VA: 0x180A82D70 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA830C0 Offset: 0xA816C0 VA: 0x180A830C0
	public void .ctor() { }

}

public class SprayCanSpray_Decal : SprayCanSpray, ICustomMaterialReplacer, IPropRenderNotify, INotifyLOD // TypeDefIndex: 8883
{	// Fields
	public DeferredDecal DecalComponent; // 0x2B0
	public GameObject IconPreviewRoot; // 0x2B8
	public Material DefaultMaterial; // 0x2C0

	// Methods

	// RVA: 0xA81C40 Offset: 0xA80240 VA: 0x180A81C40
	public void WorkshopMode() { }

	// RVA: 0xA81B40 Offset: 0xA80140 VA: 0x180A81B40 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA81A80 Offset: 0xA80080 VA: 0x180A81A80 Slot: 145
	public void Replace(Material[] find, Material[] replace) { }

	// RVA: 0xA81A40 Offset: 0xA80040 VA: 0x180A81A40 Slot: 146
	public void PreRender() { }

	// RVA: 0xA81A00 Offset: 0xA80000 VA: 0x180A81A00 Slot: 147
	public void PostRender() { }

	// RVA: 0xA81C10 Offset: 0xA80210 VA: 0x180A81C10 Slot: 148
	public void Show() { }

	// RVA: 0xA819D0 Offset: 0xA7FFD0 VA: 0x180A819D0 Slot: 149
	public void Hide() { }

	// RVA: 0x931F20 Offset: 0x930520 VA: 0x180931F20
	public void .ctor() { }

}


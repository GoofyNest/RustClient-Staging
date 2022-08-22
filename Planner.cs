public class Planner : HeldEntity // TypeDefIndex: 8615
{	// Fields
	private Vector3 rotationOffset; // 0x1F8
	private bool hasAppliedStartingRotation; // 0x204
	public Construction currentConstruction; // 0x208
	internal Planner.Guide guide; // 0x210
	public BaseEntity[] buildableList; // 0x218

	// Properties
	public bool isTypeDeployable { get; }

	// Methods

	// RVA: 0x91C500 Offset: 0x91AB00 VA: 0x18091C500 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91CA00 Offset: 0x91B000 VA: 0x18091CA00 Slot: 27
	public override void ResetState() { }

	// RVA: 0x91C250 Offset: 0x91A850 VA: 0x18091C250 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x91BEC0 Offset: 0x91A4C0 VA: 0x18091BEC0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x91C270 Offset: 0x91A870 VA: 0x18091C270 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x91C290 Offset: 0x91A890 VA: 0x18091C290 Slot: 138
	public override void OnInput() { }

	// RVA: 0x91C5F0 Offset: 0x91ABF0 VA: 0x18091C5F0
	private void OpenComponentMenu() { }

	// RVA: 0x91CB40 Offset: 0x91B140 VA: 0x18091CB40
	private void SwitchConstruction(Construction c) { }

	// RVA: 0x91A940 Offset: 0x918F40 VA: 0x18091A940
	private void DoBuild() { }

	// RVA: 0x91CA80 Offset: 0x91B080 VA: 0x18091CA80
	private void SetDefaultPlan() { }

	// RVA: 0x91BE40 Offset: 0x91A440 VA: 0x18091BE40 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x91CBD0 Offset: 0x91B1D0 VA: 0x18091CBD0
	private void UpdateGuide() { }

	// RVA: 0x91A830 Offset: 0x918E30 VA: 0x18091A830
	private void CloseGuide() { }

	// RVA: 0x91B010 Offset: 0x919610 VA: 0x18091B010
	internal void FillPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91B7E0 Offset: 0x919DE0 VA: 0x18091B7E0
	internal void FindTerrainPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91B0F0 Offset: 0x9196F0 VA: 0x18091B0F0
	internal bool FindAppropriateHandle(ref Construction.Target target, Construction component) { }

	// RVA: 0x91BDB0 Offset: 0x91A3B0 VA: 0x18091BDB0
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x91BD10 Offset: 0x91A310 VA: 0x18091BD10
	public Deployable GetDeployable() { }

	// RVA: 0x91CED0 Offset: 0x91B4D0 VA: 0x18091CED0
	public bool get_isTypeDeployable() { }

	// RVA: 0x91CE00 Offset: 0x91B400 VA: 0x18091CE00
	public void .ctor() { }

}

public class Planner.Guide // TypeDefIndex: 8616
{	// Fields
	public GameObject guideObject; // 0x10
	public Construction.Target lastPlacement; // 0x18
	private Construction component; // 0x80
	private Material goodMat; // 0x88
	private Material neutralMat; // 0x90
	private Material badMat; // 0x98
	private bool wasTransparent; // 0xA0
	private Planner.Guide.PlacementState lastPlacementState; // 0xA4

	// Methods

	// RVA: 0x905D10 Offset: 0x904310 VA: 0x180905D10
	public bool IsValid() { }

	// RVA: 0x905F10 Offset: 0x904510 VA: 0x180905F10
	private void UpdateComponent(Construction c) { }

	// RVA: 0x906150 Offset: 0x904750 VA: 0x180906150
	public void Update(ref Construction.Target placement, Construction currentComponent) { }

	// RVA: 0x905A90 Offset: 0x904090 VA: 0x180905A90
	public void BecomeValid() { }

	// RVA: 0x905A40 Offset: 0x904040 VA: 0x180905A40
	public void BecomeNeutral() { }

	// RVA: 0x9059F0 Offset: 0x903FF0 VA: 0x1809059F0
	public void BecomeInvalid(bool force = False) { }

	// RVA: 0x905E20 Offset: 0x904420 VA: 0x180905E20
	public void Shutdown() { }

	// RVA: 0x905BE0 Offset: 0x9041E0 VA: 0x180905BE0
	private Material CacheMaterialInstance(Material asset, ref Material inst) { }

	// RVA: 0x905D70 Offset: 0x904370 VA: 0x180905D70
	private void ReleaseMaterialInstance(ref Material mat) { }

	// RVA: 0x905B60 Offset: 0x904160 VA: 0x180905B60
	private Material CacheGoodMaterial() { }

	// RVA: 0x905C90 Offset: 0x904290 VA: 0x180905C90
	private Material CacheNeutralMaterial() { }

	// RVA: 0x905AE0 Offset: 0x9040E0 VA: 0x180905AE0
	private Material CacheBadMaterial() { }

	// RVA: 0x9060B0 Offset: 0x9046B0 VA: 0x1809060B0
	private void UpdateGuideTransparency(bool transparent) { }

	// RVA: 0x906D80 Offset: 0x905380 VA: 0x180906D80
	public void .ctor() { }

}

private enum Planner.Guide.PlacementState // TypeDefIndex: 8617
{	// Fields
	public int value__; // 0x0
	public const Planner.Guide.PlacementState Invalid = 0;
	public const Planner.Guide.PlacementState Neutral = 1;
	public const Planner.Guide.PlacementState Valid = 2;

}

private sealed class Planner.<>c__DisplayClass9_0 // TypeDefIndex: 8618
{	// Fields
	public Construction construction; // 0x10
	public Planner <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x920B50 Offset: 0x91F150 VA: 0x180920B50
	internal void <OpenComponentMenu>b__0(BasePlayer ply) { }

}


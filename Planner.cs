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

	// RVA: 0x91CA10 Offset: 0x91B010 VA: 0x18091CA10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91CF10 Offset: 0x91B510 VA: 0x18091CF10 Slot: 27
	public override void ResetState() { }

	// RVA: 0x91C760 Offset: 0x91AD60 VA: 0x18091C760 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x91C3D0 Offset: 0x91A9D0 VA: 0x18091C3D0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x91C780 Offset: 0x91AD80 VA: 0x18091C780 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x91C7A0 Offset: 0x91ADA0 VA: 0x18091C7A0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x91CB00 Offset: 0x91B100 VA: 0x18091CB00
	private void OpenComponentMenu() { }

	// RVA: 0x91D050 Offset: 0x91B650 VA: 0x18091D050
	private void SwitchConstruction(Construction c) { }

	// RVA: 0x91AE50 Offset: 0x919450 VA: 0x18091AE50
	private void DoBuild() { }

	// RVA: 0x91CF90 Offset: 0x91B590 VA: 0x18091CF90
	private void SetDefaultPlan() { }

	// RVA: 0x91C350 Offset: 0x91A950 VA: 0x18091C350 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x91D0E0 Offset: 0x91B6E0 VA: 0x18091D0E0
	private void UpdateGuide() { }

	// RVA: 0x91AD40 Offset: 0x919340 VA: 0x18091AD40
	private void CloseGuide() { }

	// RVA: 0x91B520 Offset: 0x919B20 VA: 0x18091B520
	internal void FillPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91BCF0 Offset: 0x91A2F0 VA: 0x18091BCF0
	internal void FindTerrainPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91B600 Offset: 0x919C00 VA: 0x18091B600
	internal bool FindAppropriateHandle(ref Construction.Target target, Construction component) { }

	// RVA: 0x91C2C0 Offset: 0x91A8C0 VA: 0x18091C2C0
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x91C220 Offset: 0x91A820 VA: 0x18091C220
	public Deployable GetDeployable() { }

	// RVA: 0x91D3E0 Offset: 0x91B9E0 VA: 0x18091D3E0
	public bool get_isTypeDeployable() { }

	// RVA: 0x91D310 Offset: 0x91B910 VA: 0x18091D310
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

	// RVA: 0x906220 Offset: 0x904820 VA: 0x180906220
	public bool IsValid() { }

	// RVA: 0x906420 Offset: 0x904A20 VA: 0x180906420
	private void UpdateComponent(Construction c) { }

	// RVA: 0x906660 Offset: 0x904C60 VA: 0x180906660
	public void Update(ref Construction.Target placement, Construction currentComponent) { }

	// RVA: 0x905FA0 Offset: 0x9045A0 VA: 0x180905FA0
	public void BecomeValid() { }

	// RVA: 0x905F50 Offset: 0x904550 VA: 0x180905F50
	public void BecomeNeutral() { }

	// RVA: 0x905F00 Offset: 0x904500 VA: 0x180905F00
	public void BecomeInvalid(bool force = False) { }

	// RVA: 0x906330 Offset: 0x904930 VA: 0x180906330
	public void Shutdown() { }

	// RVA: 0x9060F0 Offset: 0x9046F0 VA: 0x1809060F0
	private Material CacheMaterialInstance(Material asset, ref Material inst) { }

	// RVA: 0x906280 Offset: 0x904880 VA: 0x180906280
	private void ReleaseMaterialInstance(ref Material mat) { }

	// RVA: 0x906070 Offset: 0x904670 VA: 0x180906070
	private Material CacheGoodMaterial() { }

	// RVA: 0x9061A0 Offset: 0x9047A0 VA: 0x1809061A0
	private Material CacheNeutralMaterial() { }

	// RVA: 0x905FF0 Offset: 0x9045F0 VA: 0x180905FF0
	private Material CacheBadMaterial() { }

	// RVA: 0x9065C0 Offset: 0x904BC0 VA: 0x1809065C0
	private void UpdateGuideTransparency(bool transparent) { }

	// RVA: 0x907290 Offset: 0x905890 VA: 0x180907290
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

	// RVA: 0x921060 Offset: 0x91F660 VA: 0x180921060
	internal void <OpenComponentMenu>b__0(BasePlayer ply) { }

}


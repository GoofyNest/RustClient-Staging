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

	// RVA: 0x91C3F0 Offset: 0x91A9F0 VA: 0x18091C3F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91C8F0 Offset: 0x91AEF0 VA: 0x18091C8F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x91C140 Offset: 0x91A740 VA: 0x18091C140 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x91BDB0 Offset: 0x91A3B0 VA: 0x18091BDB0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x91C160 Offset: 0x91A760 VA: 0x18091C160 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x91C180 Offset: 0x91A780 VA: 0x18091C180 Slot: 138
	public override void OnInput() { }

	// RVA: 0x91C4E0 Offset: 0x91AAE0 VA: 0x18091C4E0
	private void OpenComponentMenu() { }

	// RVA: 0x91CA30 Offset: 0x91B030 VA: 0x18091CA30
	private void SwitchConstruction(Construction c) { }

	// RVA: 0x91A830 Offset: 0x918E30 VA: 0x18091A830
	private void DoBuild() { }

	// RVA: 0x91C970 Offset: 0x91AF70 VA: 0x18091C970
	private void SetDefaultPlan() { }

	// RVA: 0x91BD30 Offset: 0x91A330 VA: 0x18091BD30 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x91CAC0 Offset: 0x91B0C0 VA: 0x18091CAC0
	private void UpdateGuide() { }

	// RVA: 0x91A720 Offset: 0x918D20 VA: 0x18091A720
	private void CloseGuide() { }

	// RVA: 0x91AF00 Offset: 0x919500 VA: 0x18091AF00
	internal void FillPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91B6D0 Offset: 0x919CD0 VA: 0x18091B6D0
	internal void FindTerrainPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x91AFE0 Offset: 0x9195E0 VA: 0x18091AFE0
	internal bool FindAppropriateHandle(ref Construction.Target target, Construction component) { }

	// RVA: 0x91BCA0 Offset: 0x91A2A0 VA: 0x18091BCA0
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x91BC00 Offset: 0x91A200 VA: 0x18091BC00
	public Deployable GetDeployable() { }

	// RVA: 0x91CDC0 Offset: 0x91B3C0 VA: 0x18091CDC0
	public bool get_isTypeDeployable() { }

	// RVA: 0x91CCF0 Offset: 0x91B2F0 VA: 0x18091CCF0
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

	// RVA: 0x905C00 Offset: 0x904200 VA: 0x180905C00
	public bool IsValid() { }

	// RVA: 0x905E00 Offset: 0x904400 VA: 0x180905E00
	private void UpdateComponent(Construction c) { }

	// RVA: 0x906040 Offset: 0x904640 VA: 0x180906040
	public void Update(ref Construction.Target placement, Construction currentComponent) { }

	// RVA: 0x905980 Offset: 0x903F80 VA: 0x180905980
	public void BecomeValid() { }

	// RVA: 0x905930 Offset: 0x903F30 VA: 0x180905930
	public void BecomeNeutral() { }

	// RVA: 0x9058E0 Offset: 0x903EE0 VA: 0x1809058E0
	public void BecomeInvalid(bool force = False) { }

	// RVA: 0x905D10 Offset: 0x904310 VA: 0x180905D10
	public void Shutdown() { }

	// RVA: 0x905AD0 Offset: 0x9040D0 VA: 0x180905AD0
	private Material CacheMaterialInstance(Material asset, ref Material inst) { }

	// RVA: 0x905C60 Offset: 0x904260 VA: 0x180905C60
	private void ReleaseMaterialInstance(ref Material mat) { }

	// RVA: 0x905A50 Offset: 0x904050 VA: 0x180905A50
	private Material CacheGoodMaterial() { }

	// RVA: 0x905B80 Offset: 0x904180 VA: 0x180905B80
	private Material CacheNeutralMaterial() { }

	// RVA: 0x9059D0 Offset: 0x903FD0 VA: 0x1809059D0
	private Material CacheBadMaterial() { }

	// RVA: 0x905FA0 Offset: 0x9045A0 VA: 0x180905FA0
	private void UpdateGuideTransparency(bool transparent) { }

	// RVA: 0x906C70 Offset: 0x905270 VA: 0x180906C70
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

	// RVA: 0x920A40 Offset: 0x91F040 VA: 0x180920A40
	internal void <OpenComponentMenu>b__0(BasePlayer ply) { }

}


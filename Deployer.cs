public class Deployer : HeldEntity // TypeDefIndex: 8564
{	// Fields
	private string placementError; // 0x1F8

	// Methods

	// RVA: 0x97B790 Offset: 0x979D90 VA: 0x18097B790 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97B250 Offset: 0x979850 VA: 0x18097B250
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x97B050 Offset: 0x979650 VA: 0x18097B050
	public Deployable GetDeployable() { }

	// RVA: 0x97B410 Offset: 0x979A10 VA: 0x18097B410 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97BE90 Offset: 0x97A490 VA: 0x18097BE90
	private void UpdateGuide() { }

	// RVA: 0x97BC80 Offset: 0x97A280 VA: 0x18097BC80
	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97B880 Offset: 0x979E80 VA: 0x18097B880
	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97B4E0 Offset: 0x979AE0 VA: 0x18097B4E0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97B4C0 Offset: 0x979AC0 VA: 0x18097B4C0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x97B500 Offset: 0x979B00 VA: 0x18097B500 Slot: 138
	public override void OnInput() { }

	// RVA: 0x97B150 Offset: 0x979750 VA: 0x18097B150
	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir) { }

	// RVA: 0x97B2E0 Offset: 0x9798E0 VA: 0x18097B2E0
	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot) { }

	// RVA: 0x97AB20 Offset: 0x979120 VA: 0x18097AB20
	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance) { }

	// RVA: 0x97BFF0 Offset: 0x97A5F0 VA: 0x18097BFF0
	public void .ctor() { }

}


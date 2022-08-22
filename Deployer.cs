public class Deployer : HeldEntity // TypeDefIndex: 8564
{	// Fields
	private string placementError; // 0x1F8

	// Methods

	// RVA: 0x97BC90 Offset: 0x97A290 VA: 0x18097BC90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97B750 Offset: 0x979D50 VA: 0x18097B750
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x97B550 Offset: 0x979B50 VA: 0x18097B550
	public Deployable GetDeployable() { }

	// RVA: 0x97B910 Offset: 0x979F10 VA: 0x18097B910 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97C390 Offset: 0x97A990 VA: 0x18097C390
	private void UpdateGuide() { }

	// RVA: 0x97C180 Offset: 0x97A780 VA: 0x18097C180
	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97BD80 Offset: 0x97A380 VA: 0x18097BD80
	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97B9E0 Offset: 0x979FE0 VA: 0x18097B9E0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97B9C0 Offset: 0x979FC0 VA: 0x18097B9C0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x97BA00 Offset: 0x97A000 VA: 0x18097BA00 Slot: 138
	public override void OnInput() { }

	// RVA: 0x97B650 Offset: 0x979C50 VA: 0x18097B650
	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir) { }

	// RVA: 0x97B7E0 Offset: 0x979DE0 VA: 0x18097B7E0
	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot) { }

	// RVA: 0x97B020 Offset: 0x979620 VA: 0x18097B020
	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance) { }

	// RVA: 0x97C4F0 Offset: 0x97AAF0 VA: 0x18097C4F0
	public void .ctor() { }

}


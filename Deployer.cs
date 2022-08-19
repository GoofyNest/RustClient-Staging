public class Deployer : HeldEntity // TypeDefIndex: 8564
{	// Fields
	private string placementError; // 0x1F8

	// Methods

	// RVA: 0x97B680 Offset: 0x979C80 VA: 0x18097B680 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97B140 Offset: 0x979740 VA: 0x18097B140
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x97AF40 Offset: 0x979540 VA: 0x18097AF40
	public Deployable GetDeployable() { }

	// RVA: 0x97B300 Offset: 0x979900 VA: 0x18097B300 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97BD80 Offset: 0x97A380 VA: 0x18097BD80
	private void UpdateGuide() { }

	// RVA: 0x97BB70 Offset: 0x97A170 VA: 0x18097BB70
	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97B770 Offset: 0x979D70 VA: 0x18097B770
	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable) { }

	// RVA: 0x97B3D0 Offset: 0x9799D0 VA: 0x18097B3D0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97B3B0 Offset: 0x9799B0 VA: 0x18097B3B0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x97B3F0 Offset: 0x9799F0 VA: 0x18097B3F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x97B040 Offset: 0x979640 VA: 0x18097B040
	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir) { }

	// RVA: 0x97B1D0 Offset: 0x9797D0 VA: 0x18097B1D0
	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot) { }

	// RVA: 0x97AA10 Offset: 0x979010 VA: 0x18097AA10
	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance) { }

	// RVA: 0x97BEE0 Offset: 0x97A4E0 VA: 0x18097BEE0
	public void .ctor() { }

}


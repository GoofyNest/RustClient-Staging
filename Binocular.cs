public class Binocular : AttackEntity // TypeDefIndex: 9462
{	// Fields
	public float[] fovs; // 0x280
	public GameObjectRef fovChangeEffect; // 0x288
	public float smoothSpeed; // 0x290
	private bool vmVisible; // 0x294
	private bool isAiming; // 0x295
	private float timeAiming; // 0x298
	private int currentFovIndex; // 0x29C

	// Methods

	// RVA: 0x511C70 Offset: 0x510270 VA: 0x180511C70
	public bool IsAiming() { }

	// RVA: 0x511C90 Offset: 0x510290 VA: 0x180511C90 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x5121E0 Offset: 0x5107E0 VA: 0x1805121E0 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x511980 Offset: 0x50FF80 VA: 0x180511980
	public void ClearOverlays() { }

	// RVA: 0x511D70 Offset: 0x510370 VA: 0x180511D70 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x5119E0 Offset: 0x50FFE0 VA: 0x1805119E0
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x5124B0 Offset: 0x510AB0 VA: 0x1805124B0
	public void SetViewmodelVisiblity(bool visible) { }

	// RVA: 0x512250 Offset: 0x510850 VA: 0x180512250 Slot: 138
	public override void OnInput() { }

	// RVA: 0x5125C0 Offset: 0x510BC0 VA: 0x1805125C0
	public void .ctor() { }

}


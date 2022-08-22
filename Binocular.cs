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

	// RVA: 0x511C00 Offset: 0x510200 VA: 0x180511C00
	public bool IsAiming() { }

	// RVA: 0x511C20 Offset: 0x510220 VA: 0x180511C20 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x512170 Offset: 0x510770 VA: 0x180512170 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x511910 Offset: 0x50FF10 VA: 0x180511910
	public void ClearOverlays() { }

	// RVA: 0x511D00 Offset: 0x510300 VA: 0x180511D00 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x511970 Offset: 0x50FF70 VA: 0x180511970
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x512440 Offset: 0x510A40 VA: 0x180512440
	public void SetViewmodelVisiblity(bool visible) { }

	// RVA: 0x5121E0 Offset: 0x5107E0 VA: 0x1805121E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x512550 Offset: 0x510B50 VA: 0x180512550
	public void .ctor() { }

}


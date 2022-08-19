public class CameraTool : HeldEntity // TypeDefIndex: 8542
{	// Fields
	public GameObjectRef screenshotEffect; // 0x1F8
	public float cameraFOV; // 0x200
	public float focalDistance; // 0x204
	internal float focalDistanceSmooth; // 0x208

	// Methods

	// RVA: 0x6FCBB0 Offset: 0x6FB1B0 VA: 0x1806FCBB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6FC6D0 Offset: 0x6FACD0 VA: 0x1806FC6D0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x6FC960 Offset: 0x6FAF60 VA: 0x1806FC960 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x6FCB00 Offset: 0x6FB100 VA: 0x1806FCB00 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6FC850 Offset: 0x6FAE50 VA: 0x1806FC850 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x6FCCA0 Offset: 0x6FB2A0 VA: 0x1806FCCA0
	public void .ctor() { }

}


public class CameraTool : HeldEntity // TypeDefIndex: 8542
{	// Fields
	public GameObjectRef screenshotEffect; // 0x1F8
	public float cameraFOV; // 0x200
	public float focalDistance; // 0x204
	internal float focalDistanceSmooth; // 0x208

	// Methods

	// RVA: 0x6FCCC0 Offset: 0x6FB2C0 VA: 0x1806FCCC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6FC7E0 Offset: 0x6FADE0 VA: 0x1806FC7E0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x6FCA70 Offset: 0x6FB070 VA: 0x1806FCA70 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x6FCC10 Offset: 0x6FB210 VA: 0x1806FCC10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6FC960 Offset: 0x6FAF60 VA: 0x1806FC960 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x6FCDB0 Offset: 0x6FB3B0 VA: 0x1806FCDB0
	public void .ctor() { }

}


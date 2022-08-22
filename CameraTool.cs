public class CameraTool : HeldEntity // TypeDefIndex: 8542
{	// Fields
	public GameObjectRef screenshotEffect; // 0x1F8
	public float cameraFOV; // 0x200
	public float focalDistance; // 0x204
	internal float focalDistanceSmooth; // 0x208

	// Methods

	// RVA: 0x6FCC10 Offset: 0x6FB210 VA: 0x1806FCC10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6FC730 Offset: 0x6FAD30 VA: 0x1806FC730 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x6FC9C0 Offset: 0x6FAFC0 VA: 0x1806FC9C0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x6FCB60 Offset: 0x6FB160 VA: 0x1806FCB60 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6FC8B0 Offset: 0x6FAEB0 VA: 0x1806FC8B0 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x6FCD00 Offset: 0x6FB300 VA: 0x1806FCD00
	public void .ctor() { }

}


public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 8611
{	// Fields
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private int frequency; // 0x168
	public float beepRepeat; // 0x16C
	public GameObjectRef pagerEffect; // 0x170
	public GameObjectRef silentEffect; // 0x178
	private bool wasOn; // 0x180

	// Methods

	// RVA: 0x85A0C0 Offset: 0x8586C0 VA: 0x18085A0C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x85A000 Offset: 0x858600 VA: 0x18085A000 Slot: 132
	public int GetFrequency() { }

	// RVA: 0x85A070 Offset: 0x858670 VA: 0x18085A070
	public void OnParentDestroying() { }

	// RVA: 0x85A010 Offset: 0x858610 VA: 0x18085A010 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x85A1B0 Offset: 0x8587B0 VA: 0x18085A1B0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x859D50 Offset: 0x858350 VA: 0x180859D50
	public void Beep() { }

	// RVA: 0x859E90 Offset: 0x858490 VA: 0x180859E90
	public void BeginAlarm() { }

	// RVA: 0x859F90 Offset: 0x858590 VA: 0x180859F90
	public void EndAlarm() { }

	// RVA: 0x859F40 Offset: 0x858540 VA: 0x180859F40 Slot: 131
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x85A400 Offset: 0x858A00 VA: 0x18085A400
	public void .ctor() { }

	// RVA: 0x85A3C0 Offset: 0x8589C0 VA: 0x18085A3C0
	private static void .cctor() { }

}


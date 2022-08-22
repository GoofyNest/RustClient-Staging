public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 8611
{	// Fields
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private int frequency; // 0x168
	public float beepRepeat; // 0x16C
	public GameObjectRef pagerEffect; // 0x170
	public GameObjectRef silentEffect; // 0x178
	private bool wasOn; // 0x180

	// Methods

	// RVA: 0x85A1D0 Offset: 0x8587D0 VA: 0x18085A1D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x85A110 Offset: 0x858710 VA: 0x18085A110 Slot: 132
	public int GetFrequency() { }

	// RVA: 0x85A180 Offset: 0x858780 VA: 0x18085A180
	public void OnParentDestroying() { }

	// RVA: 0x85A120 Offset: 0x858720 VA: 0x18085A120 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x85A2C0 Offset: 0x8588C0 VA: 0x18085A2C0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x859E60 Offset: 0x858460 VA: 0x180859E60
	public void Beep() { }

	// RVA: 0x859FA0 Offset: 0x8585A0 VA: 0x180859FA0
	public void BeginAlarm() { }

	// RVA: 0x85A0A0 Offset: 0x8586A0 VA: 0x18085A0A0
	public void EndAlarm() { }

	// RVA: 0x85A050 Offset: 0x858650 VA: 0x18085A050 Slot: 131
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x85A510 Offset: 0x858B10 VA: 0x18085A510
	public void .ctor() { }

	// RVA: 0x85A4D0 Offset: 0x858AD0 VA: 0x18085A4D0
	private static void .cctor() { }

}


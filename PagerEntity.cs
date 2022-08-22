public class PagerEntity : BaseEntity, IRFObject // TypeDefIndex: 8611
{	// Fields
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private int frequency; // 0x168
	public float beepRepeat; // 0x16C
	public GameObjectRef pagerEffect; // 0x170
	public GameObjectRef silentEffect; // 0x178
	private bool wasOn; // 0x180

	// Methods

	// RVA: 0x875930 Offset: 0x873F30 VA: 0x180875930 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x875870 Offset: 0x873E70 VA: 0x180875870 Slot: 132
	public int GetFrequency() { }

	// RVA: 0x8758E0 Offset: 0x873EE0 VA: 0x1808758E0
	public void OnParentDestroying() { }

	// RVA: 0x875880 Offset: 0x873E80 VA: 0x180875880 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x875A20 Offset: 0x874020 VA: 0x180875A20 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8755C0 Offset: 0x873BC0 VA: 0x1808755C0
	public void Beep() { }

	// RVA: 0x875700 Offset: 0x873D00 VA: 0x180875700
	public void BeginAlarm() { }

	// RVA: 0x875800 Offset: 0x873E00 VA: 0x180875800
	public void EndAlarm() { }

	// RVA: 0x8757B0 Offset: 0x873DB0 VA: 0x1808757B0 Slot: 131
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x875C70 Offset: 0x874270 VA: 0x180875C70
	public void .ctor() { }

	// RVA: 0x875C30 Offset: 0x874230 VA: 0x180875C30
	private static void .cctor() { }

}


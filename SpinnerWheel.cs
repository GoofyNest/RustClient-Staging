public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6337
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 spin; // 0x14

	// Methods

	// RVA: 0x1DB8F10 Offset: 0x1DB7510 VA: 0x181DB8F10
	public static void ResetToPool(SpinnerWheel instance) { }

	// RVA: 0x1DB8F90 Offset: 0x1DB7590 VA: 0x181DB8F90
	public void ResetToPool() { }

	// RVA: 0x1DB8DE0 Offset: 0x1DB73E0 VA: 0x181DB8DE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB8430 Offset: 0x1DB6A30 VA: 0x181DB8430
	public void CopyTo(SpinnerWheel instance) { }

	// RVA: 0x1DB8460 Offset: 0x1DB6A60 VA: 0x181DB8460
	public SpinnerWheel Copy() { }

	// RVA: 0x1DB8D60 Offset: 0x1DB7360 VA: 0x181DB8D60
	public static SpinnerWheel Deserialize(Stream stream) { }

	// RVA: 0x1DB86F0 Offset: 0x1DB6CF0 VA: 0x181DB86F0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB8960 Offset: 0x1DB6F60 VA: 0x181DB8960
	public static SpinnerWheel DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB8C40 Offset: 0x1DB7240 VA: 0x181DB8C40
	public static SpinnerWheel Deserialize(byte[] buffer) { }

	// RVA: 0x1DB8ED0 Offset: 0x1DB74D0 VA: 0x181DB8ED0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB9590 Offset: 0x1DB7B90 VA: 0x181DB9590 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB95B0 Offset: 0x1DB7BB0 VA: 0x181DB95B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SpinnerWheel previous) { }

	// RVA: 0x1DB8EF0 Offset: 0x1DB74F0 VA: 0x181DB8EF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB89F0 Offset: 0x1DB6FF0 VA: 0x181DB89F0
	public static SpinnerWheel Deserialize(byte[] buffer, SpinnerWheel instance, bool isDelta = False) { }

	// RVA: 0x1DB8AF0 Offset: 0x1DB70F0 VA: 0x181DB8AF0
	public static SpinnerWheel Deserialize(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB84D0 Offset: 0x1DB6AD0 VA: 0x181DB84D0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB8770 Offset: 0x1DB6D70 VA: 0x181DB8770
	public static SpinnerWheel DeserializeLength(Stream stream, int length, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB9010 Offset: 0x1DB7610 VA: 0x181DB9010
	public static void SerializeDelta(Stream stream, SpinnerWheel instance, SpinnerWheel previous) { }

	// RVA: 0x1DB9410 Offset: 0x1DB7A10 VA: 0x181DB9410
	public static void Serialize(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1DB9580 Offset: 0x1DB7B80 VA: 0x181DB9580
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB9590 Offset: 0x1DB7B90 VA: 0x181DB9590
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB9300 Offset: 0x1DB7900 VA: 0x181DB9300
	public static byte[] SerializeToBytes(SpinnerWheel instance) { }

	// RVA: 0x1DB9250 Offset: 0x1DB7850 VA: 0x181DB9250
	public static void SerializeLengthDelimited(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class SpinnerWheel : Signage // TypeDefIndex: 8452
{	// Fields
	private Option __menuOption_Menu_LockSpin; // 0x3D0
	private Option __menuOption_Menu_Spin; // 0x428
	private Option __menuOption_Menu_UnlockSpin; // 0x480
	public Transform wheel; // 0x4D8
	public float velocity; // 0x4E0
	public Quaternion targetRotation; // 0x4E4
	[HeaderAttribute] // RVA: 0x8CC90 Offset: 0x8C090 VA: 0x18008CC90
	public SoundDefinition spinLoopSoundDef; // 0x4F8
	public SoundDefinition spinStartSoundDef; // 0x500
	public SoundDefinition spinAccentSoundDef; // 0x508
	public SoundDefinition spinStopSoundDef; // 0x510
	public float minTimeBetweenSpinAccentSounds; // 0x518
	public float spinAccentAngleDelta; // 0x51C
	private Sound spinSound; // 0x520
	private SoundModulation.Modulator spinSoundGain; // 0x528
	private float angleRotated; // 0x530
	private float lastSpinSound; // 0x534
	private float clientSpinSpeed; // 0x538

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA7F580 Offset: 0xA7DB80 VA: 0x180A7F580 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA80A60 Offset: 0xA7F060 VA: 0x180A80A60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA800C0 Offset: 0xA7E6C0 VA: 0x180A800C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 173
	public virtual bool AllowPlayerSpins() { }

	// RVA: 0xA7FDD0 Offset: 0xA7E3D0 VA: 0x180A7FDD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7F570 Offset: 0xA7DB70 VA: 0x180A7F570 Slot: 174
	public virtual float GetMaxSpinSpeed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 175
	public virtual void Update_Server() { }

	// RVA: 0xA80690 Offset: 0xA7EC90 VA: 0x180A80690
	public void Update_Client() { }

	// RVA: 0xA801B0 Offset: 0xA7E7B0 VA: 0x180A801B0
	private void UpdateSound() { }

	// RVA: 0xA80970 Offset: 0xA7EF70 VA: 0x180A80970
	public void Update() { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool AnyoneSpin() { }

	[BaseEntity.Menu] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Description] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Icon] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	// RVA: 0xA7FFD0 Offset: 0xA7E5D0 VA: 0x180A7FFD0
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0xA7FF60 Offset: 0xA7E560 VA: 0x180A7FF60
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.Description] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.Icon] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	// RVA: 0xA80070 Offset: 0xA7E670 VA: 0x180A80070
	public void Menu_UnlockSpin(BasePlayer player) { }

	// RVA: 0xA80010 Offset: 0xA7E610 VA: 0x180A80010
	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.Description] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.Icon] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	// RVA: 0xA7FF10 Offset: 0xA7E510 VA: 0x180A7FF10
	public void Menu_LockSpin(BasePlayer player) { }

	// RVA: 0xA7FEB0 Offset: 0xA7E4B0 VA: 0x180A7FEB0
	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	// RVA: 0xA809C0 Offset: 0xA7EFC0 VA: 0x180A809C0
	public void .ctor() { }

}


public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6337
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 spin; // 0x14

	// Methods

	// RVA: 0x1DB8E10 Offset: 0x1DB7410 VA: 0x181DB8E10
	public static void ResetToPool(SpinnerWheel instance) { }

	// RVA: 0x1DB8E90 Offset: 0x1DB7490 VA: 0x181DB8E90
	public void ResetToPool() { }

	// RVA: 0x1DB8CE0 Offset: 0x1DB72E0 VA: 0x181DB8CE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB8330 Offset: 0x1DB6930 VA: 0x181DB8330
	public void CopyTo(SpinnerWheel instance) { }

	// RVA: 0x1DB8360 Offset: 0x1DB6960 VA: 0x181DB8360
	public SpinnerWheel Copy() { }

	// RVA: 0x1DB8C60 Offset: 0x1DB7260 VA: 0x181DB8C60
	public static SpinnerWheel Deserialize(Stream stream) { }

	// RVA: 0x1DB85F0 Offset: 0x1DB6BF0 VA: 0x181DB85F0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB8860 Offset: 0x1DB6E60 VA: 0x181DB8860
	public static SpinnerWheel DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB8B40 Offset: 0x1DB7140 VA: 0x181DB8B40
	public static SpinnerWheel Deserialize(byte[] buffer) { }

	// RVA: 0x1DB8DD0 Offset: 0x1DB73D0 VA: 0x181DB8DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB9490 Offset: 0x1DB7A90 VA: 0x181DB9490 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB94B0 Offset: 0x1DB7AB0 VA: 0x181DB94B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SpinnerWheel previous) { }

	// RVA: 0x1DB8DF0 Offset: 0x1DB73F0 VA: 0x181DB8DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB88F0 Offset: 0x1DB6EF0 VA: 0x181DB88F0
	public static SpinnerWheel Deserialize(byte[] buffer, SpinnerWheel instance, bool isDelta = False) { }

	// RVA: 0x1DB89F0 Offset: 0x1DB6FF0 VA: 0x181DB89F0
	public static SpinnerWheel Deserialize(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB83D0 Offset: 0x1DB69D0 VA: 0x181DB83D0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB8670 Offset: 0x1DB6C70 VA: 0x181DB8670
	public static SpinnerWheel DeserializeLength(Stream stream, int length, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB8F10 Offset: 0x1DB7510 VA: 0x181DB8F10
	public static void SerializeDelta(Stream stream, SpinnerWheel instance, SpinnerWheel previous) { }

	// RVA: 0x1DB9310 Offset: 0x1DB7910 VA: 0x181DB9310
	public static void Serialize(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1DB9480 Offset: 0x1DB7A80 VA: 0x181DB9480
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB9490 Offset: 0x1DB7A90 VA: 0x181DB9490
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB9200 Offset: 0x1DB7800 VA: 0x181DB9200
	public static byte[] SerializeToBytes(SpinnerWheel instance) { }

	// RVA: 0x1DB9150 Offset: 0x1DB7750 VA: 0x181DB9150
	public static void SerializeLengthDelimited(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[HeaderAttribute] // RVA: 0x8CC10 Offset: 0x8C010 VA: 0x18008CC10
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

	// RVA: 0xA7F2C0 Offset: 0xA7D8C0 VA: 0x180A7F2C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA807A0 Offset: 0xA7EDA0 VA: 0x180A807A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA7FE00 Offset: 0xA7E400 VA: 0x180A7FE00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 173
	public virtual bool AllowPlayerSpins() { }

	// RVA: 0xA7FB10 Offset: 0xA7E110 VA: 0x180A7FB10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7F2B0 Offset: 0xA7D8B0 VA: 0x180A7F2B0 Slot: 174
	public virtual float GetMaxSpinSpeed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 175
	public virtual void Update_Server() { }

	// RVA: 0xA803D0 Offset: 0xA7E9D0 VA: 0x180A803D0
	public void Update_Client() { }

	// RVA: 0xA7FEF0 Offset: 0xA7E4F0 VA: 0x180A7FEF0
	private void UpdateSound() { }

	// RVA: 0xA806B0 Offset: 0xA7ECB0 VA: 0x180A806B0
	public void Update() { }

	// RVA: 0x50CC40 Offset: 0x50B240 VA: 0x18050CC40
	public bool AnyoneSpin() { }

	[BaseEntity.Menu] // RVA: 0x8CCB0 Offset: 0x8C0B0 VA: 0x18008CCB0
	[BaseEntity.Menu.Description] // RVA: 0x8CCB0 Offset: 0x8C0B0 VA: 0x18008CCB0
	[BaseEntity.Menu.Icon] // RVA: 0x8CCB0 Offset: 0x8C0B0 VA: 0x18008CCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CCB0 Offset: 0x8C0B0 VA: 0x18008CCB0
	// RVA: 0xA7FD10 Offset: 0xA7E310 VA: 0x180A7FD10
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0xA7FCA0 Offset: 0xA7E2A0 VA: 0x180A7FCA0
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	[BaseEntity.Menu.Description] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	[BaseEntity.Menu.Icon] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	// RVA: 0xA7FDB0 Offset: 0xA7E3B0 VA: 0x180A7FDB0
	public void Menu_UnlockSpin(BasePlayer player) { }

	// RVA: 0xA7FD50 Offset: 0xA7E350 VA: 0x180A7FD50
	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D100 Offset: 0x8C500 VA: 0x18008D100
	[BaseEntity.Menu.Description] // RVA: 0x8D100 Offset: 0x8C500 VA: 0x18008D100
	[BaseEntity.Menu.Icon] // RVA: 0x8D100 Offset: 0x8C500 VA: 0x18008D100
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D100 Offset: 0x8C500 VA: 0x18008D100
	// RVA: 0xA7FC50 Offset: 0xA7E250 VA: 0x180A7FC50
	public void Menu_LockSpin(BasePlayer player) { }

	// RVA: 0xA7FBF0 Offset: 0xA7E1F0 VA: 0x180A7FBF0
	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	// RVA: 0xA80700 Offset: 0xA7ED00 VA: 0x180A80700
	public void .ctor() { }

}


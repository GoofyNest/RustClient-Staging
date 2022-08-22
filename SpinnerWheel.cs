public class SpinnerWheel : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6337
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 spin; // 0x14

	// Methods

	// RVA: 0x1DB9700 Offset: 0x1DB7D00 VA: 0x181DB9700
	public static void ResetToPool(SpinnerWheel instance) { }

	// RVA: 0x1DB9780 Offset: 0x1DB7D80 VA: 0x181DB9780
	public void ResetToPool() { }

	// RVA: 0x1DB95D0 Offset: 0x1DB7BD0 VA: 0x181DB95D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB8C20 Offset: 0x1DB7220 VA: 0x181DB8C20
	public void CopyTo(SpinnerWheel instance) { }

	// RVA: 0x1DB8C50 Offset: 0x1DB7250 VA: 0x181DB8C50
	public SpinnerWheel Copy() { }

	// RVA: 0x1DB9550 Offset: 0x1DB7B50 VA: 0x181DB9550
	public static SpinnerWheel Deserialize(Stream stream) { }

	// RVA: 0x1DB8EE0 Offset: 0x1DB74E0 VA: 0x181DB8EE0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB9150 Offset: 0x1DB7750 VA: 0x181DB9150
	public static SpinnerWheel DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB9430 Offset: 0x1DB7A30 VA: 0x181DB9430
	public static SpinnerWheel Deserialize(byte[] buffer) { }

	// RVA: 0x1DB96C0 Offset: 0x1DB7CC0 VA: 0x181DB96C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB9D80 Offset: 0x1DB8380 VA: 0x181DB9D80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB9DA0 Offset: 0x1DB83A0 VA: 0x181DB9DA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SpinnerWheel previous) { }

	// RVA: 0x1DB96E0 Offset: 0x1DB7CE0 VA: 0x181DB96E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB91E0 Offset: 0x1DB77E0 VA: 0x181DB91E0
	public static SpinnerWheel Deserialize(byte[] buffer, SpinnerWheel instance, bool isDelta = False) { }

	// RVA: 0x1DB92E0 Offset: 0x1DB78E0 VA: 0x181DB92E0
	public static SpinnerWheel Deserialize(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB8CC0 Offset: 0x1DB72C0 VA: 0x181DB8CC0
	public static SpinnerWheel DeserializeLengthDelimited(Stream stream, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB8F60 Offset: 0x1DB7560 VA: 0x181DB8F60
	public static SpinnerWheel DeserializeLength(Stream stream, int length, SpinnerWheel instance, bool isDelta) { }

	// RVA: 0x1DB9800 Offset: 0x1DB7E00 VA: 0x181DB9800
	public static void SerializeDelta(Stream stream, SpinnerWheel instance, SpinnerWheel previous) { }

	// RVA: 0x1DB9C00 Offset: 0x1DB8200 VA: 0x181DB9C00
	public static void Serialize(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x1DB9D70 Offset: 0x1DB8370 VA: 0x181DB9D70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB9D80 Offset: 0x1DB8380 VA: 0x181DB9D80
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB9AF0 Offset: 0x1DB80F0 VA: 0x181DB9AF0
	public static byte[] SerializeToBytes(SpinnerWheel instance) { }

	// RVA: 0x1DB9A40 Offset: 0x1DB8040 VA: 0x181DB9A40
	public static void SerializeLengthDelimited(Stream stream, SpinnerWheel instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0xA7FA50 Offset: 0xA7E050 VA: 0x180A7FA50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA80F30 Offset: 0xA7F530 VA: 0x180A80F30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA80590 Offset: 0xA7EB90 VA: 0x180A80590 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 173
	public virtual bool AllowPlayerSpins() { }

	// RVA: 0xA802A0 Offset: 0xA7E8A0 VA: 0x180A802A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7FA40 Offset: 0xA7E040 VA: 0x180A7FA40 Slot: 174
	public virtual float GetMaxSpinSpeed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 175
	public virtual void Update_Server() { }

	// RVA: 0xA80B60 Offset: 0xA7F160 VA: 0x180A80B60
	public void Update_Client() { }

	// RVA: 0xA80680 Offset: 0xA7EC80 VA: 0x180A80680
	private void UpdateSound() { }

	// RVA: 0xA80E40 Offset: 0xA7F440 VA: 0x180A80E40
	public void Update() { }

	// RVA: 0x50CBD0 Offset: 0x50B1D0 VA: 0x18050CBD0
	public bool AnyoneSpin() { }

	[BaseEntity.Menu] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Description] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.Icon] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CD30 Offset: 0x8C130 VA: 0x18008CD30
	// RVA: 0xA804A0 Offset: 0xA7EAA0 VA: 0x180A804A0
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0xA80430 Offset: 0xA7EA30 VA: 0x180A80430
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.Description] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.Icon] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	[BaseEntity.Menu.ShowIf] // RVA: 0x8CF50 Offset: 0x8C350 VA: 0x18008CF50
	// RVA: 0xA80540 Offset: 0xA7EB40 VA: 0x180A80540
	public void Menu_UnlockSpin(BasePlayer player) { }

	// RVA: 0xA804E0 Offset: 0xA7EAE0 VA: 0x180A804E0
	public bool Menu_UnlockSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.Description] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.Icon] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D180 Offset: 0x8C580 VA: 0x18008D180
	// RVA: 0xA803E0 Offset: 0xA7E9E0 VA: 0x180A803E0
	public void Menu_LockSpin(BasePlayer player) { }

	// RVA: 0xA80380 Offset: 0xA7E980 VA: 0x180A80380
	public bool Menu_LockSpin_ShowIf(BasePlayer player) { }

	// RVA: 0xA80E90 Offset: 0xA7F490 VA: 0x180A80E90
	public void .ctor() { }

}


public class MicrophoneStand : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6417
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int microphoneMode; // 0x14
	public uint IORef; // 0x18

	// Methods

	// RVA: 0x1F46BC0 Offset: 0x1F451C0 VA: 0x181F46BC0
	public static void ResetToPool(MicrophoneStand instance) { }

	// RVA: 0x1F46C40 Offset: 0x1F45240 VA: 0x181F46C40
	public void ResetToPool() { }

	// RVA: 0x1F46920 Offset: 0x1F44F20 VA: 0x181F46920 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(MicrophoneStand instance) { }

	// RVA: 0x1F45B20 Offset: 0x1F44120 VA: 0x181F45B20
	public MicrophoneStand Copy() { }

	// RVA: 0x1F46760 Offset: 0x1F44D60 VA: 0x181F46760
	public static MicrophoneStand Deserialize(Stream stream) { }

	// RVA: 0x1F45B90 Offset: 0x1F44190 VA: 0x181F45B90
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F45E60 Offset: 0x1F44460 VA: 0x181F45E60
	public static MicrophoneStand DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F464F0 Offset: 0x1F44AF0 VA: 0x181F464F0
	public static MicrophoneStand Deserialize(byte[] buffer) { }

	// RVA: 0x1F46A20 Offset: 0x1F45020 VA: 0x181F46A20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F47100 Offset: 0x1F45700 VA: 0x181F47100 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F47120 Offset: 0x1F45720 VA: 0x181F47120 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MicrophoneStand previous) { }

	// RVA: 0x1F46BA0 Offset: 0x1F451A0 VA: 0x181F46BA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F462A0 Offset: 0x1F448A0 VA: 0x181F462A0
	public static MicrophoneStand Deserialize(byte[] buffer, MicrophoneStand instance, bool isDelta = False) { }

	// RVA: 0x1F46120 Offset: 0x1F44720 VA: 0x181F46120
	public static MicrophoneStand Deserialize(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F45C10 Offset: 0x1F44210 VA: 0x181F45C10
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F45EF0 Offset: 0x1F444F0 VA: 0x181F45EF0
	public static MicrophoneStand DeserializeLength(Stream stream, int length, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F46CC0 Offset: 0x1F452C0 VA: 0x181F46CC0
	public static void SerializeDelta(Stream stream, MicrophoneStand instance, MicrophoneStand previous) { }

	// RVA: 0x1F46FF0 Offset: 0x1F455F0 VA: 0x181F46FF0
	public static void Serialize(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1F470F0 Offset: 0x1F456F0 VA: 0x181F470F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F47100 Offset: 0x1F45700 VA: 0x181F47100
	public void ToProto(Stream stream) { }

	// RVA: 0x1F46EE0 Offset: 0x1F454E0 VA: 0x181F46EE0
	public static byte[] SerializeToBytes(MicrophoneStand instance) { }

	// RVA: 0x1F46E30 Offset: 0x1F45430 VA: 0x181F46E30
	public static void SerializeLengthDelimited(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class MicrophoneStand : BaseMountable // TypeDefIndex: 8605
{	// Fields
	public VoiceProcessor VoiceProcessor; // 0x320
	public AudioSource VoiceSource; // 0x328
	private MicrophoneStand.SpeechMode currentSpeechMode; // 0x330
	public AudioMixerGroup NormalMix; // 0x338
	public AudioMixerGroup HighPitchMix; // 0x340
	public AudioMixerGroup LowPitchMix; // 0x348
	public Translate.Phrase NormalPhrase; // 0x350
	public Translate.Phrase NormalDescPhrase; // 0x358
	public Translate.Phrase HighPitchPhrase; // 0x360
	public Translate.Phrase HighPitchDescPhrase; // 0x368
	public Translate.Phrase LowPitchPhrase; // 0x370
	public Translate.Phrase LowPitchDescPhrase; // 0x378
	public GameObjectRef IOSubEntity; // 0x380
	public Transform IOSubEntitySpawnPos; // 0x388
	public bool IsStatic; // 0x390
	public EntityRef<IOEntity> ioEntity; // 0x398

	// Methods

	// RVA: 0x96C020 Offset: 0x96A620 VA: 0x18096C020 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x96C360 Offset: 0x96A960 VA: 0x18096C360
	private void Update() { }

	// RVA: 0x96BCF0 Offset: 0x96A2F0 VA: 0x18096BCF0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x96C110 Offset: 0x96A710 VA: 0x18096C110
	public bool Receive(byte[] data) { }

	// RVA: 0x96BB90 Offset: 0x96A190 VA: 0x18096BB90 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x96BBC0 Offset: 0x96A1C0 VA: 0x18096BBC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x96C3B0 Offset: 0x96A9B0 VA: 0x18096C3B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x96C270 Offset: 0x96A870 VA: 0x18096C270
	private void <OnClientInput>b__19_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x96C2C0 Offset: 0x96A8C0 VA: 0x18096C2C0
	private void <OnClientInput>b__19_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x96C310 Offset: 0x96A910 VA: 0x18096C310
	private void <OnClientInput>b__19_2(BasePlayer ply) { }

}

public enum MicrophoneStand.SpeechMode // TypeDefIndex: 8606
{	// Fields
	public int value__; // 0x0
	public const MicrophoneStand.SpeechMode Normal = 0;
	public const MicrophoneStand.SpeechMode HighPitch = 1;
	public const MicrophoneStand.SpeechMode LowPitch = 2;

}


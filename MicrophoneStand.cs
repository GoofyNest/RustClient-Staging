public class MicrophoneStand : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6417
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int microphoneMode; // 0x14
	public uint IORef; // 0x18

	// Methods

	// RVA: 0x1F474E0 Offset: 0x1F45AE0 VA: 0x181F474E0
	public static void ResetToPool(MicrophoneStand instance) { }

	// RVA: 0x1F47560 Offset: 0x1F45B60 VA: 0x181F47560
	public void ResetToPool() { }

	// RVA: 0x1F47240 Offset: 0x1F45840 VA: 0x181F47240 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(MicrophoneStand instance) { }

	// RVA: 0x1F46440 Offset: 0x1F44A40 VA: 0x181F46440
	public MicrophoneStand Copy() { }

	// RVA: 0x1F47080 Offset: 0x1F45680 VA: 0x181F47080
	public static MicrophoneStand Deserialize(Stream stream) { }

	// RVA: 0x1F464B0 Offset: 0x1F44AB0 VA: 0x181F464B0
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F46780 Offset: 0x1F44D80 VA: 0x181F46780
	public static MicrophoneStand DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F46E10 Offset: 0x1F45410 VA: 0x181F46E10
	public static MicrophoneStand Deserialize(byte[] buffer) { }

	// RVA: 0x1F47340 Offset: 0x1F45940 VA: 0x181F47340
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F47A20 Offset: 0x1F46020 VA: 0x181F47A20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F47A40 Offset: 0x1F46040 VA: 0x181F47A40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MicrophoneStand previous) { }

	// RVA: 0x1F474C0 Offset: 0x1F45AC0 VA: 0x181F474C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F46BC0 Offset: 0x1F451C0 VA: 0x181F46BC0
	public static MicrophoneStand Deserialize(byte[] buffer, MicrophoneStand instance, bool isDelta = False) { }

	// RVA: 0x1F46A40 Offset: 0x1F45040 VA: 0x181F46A40
	public static MicrophoneStand Deserialize(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F46530 Offset: 0x1F44B30 VA: 0x181F46530
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F46810 Offset: 0x1F44E10 VA: 0x181F46810
	public static MicrophoneStand DeserializeLength(Stream stream, int length, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F475E0 Offset: 0x1F45BE0 VA: 0x181F475E0
	public static void SerializeDelta(Stream stream, MicrophoneStand instance, MicrophoneStand previous) { }

	// RVA: 0x1F47910 Offset: 0x1F45F10 VA: 0x181F47910
	public static void Serialize(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1F47A10 Offset: 0x1F46010 VA: 0x181F47A10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F47A20 Offset: 0x1F46020 VA: 0x181F47A20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F47800 Offset: 0x1F45E00 VA: 0x181F47800
	public static byte[] SerializeToBytes(MicrophoneStand instance) { }

	// RVA: 0x1F47750 Offset: 0x1F45D50 VA: 0x181F47750
	public static void SerializeLengthDelimited(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x96C630 Offset: 0x96AC30 VA: 0x18096C630 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x96C970 Offset: 0x96AF70 VA: 0x18096C970
	private void Update() { }

	// RVA: 0x96C300 Offset: 0x96A900 VA: 0x18096C300 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x96C720 Offset: 0x96AD20 VA: 0x18096C720
	public bool Receive(byte[] data) { }

	// RVA: 0x96C1A0 Offset: 0x96A7A0 VA: 0x18096C1A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x96C1D0 Offset: 0x96A7D0 VA: 0x18096C1D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x96C9C0 Offset: 0x96AFC0 VA: 0x18096C9C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C880 Offset: 0x96AE80 VA: 0x18096C880
	private void <OnClientInput>b__19_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C8D0 Offset: 0x96AED0 VA: 0x18096C8D0
	private void <OnClientInput>b__19_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C920 Offset: 0x96AF20 VA: 0x18096C920
	private void <OnClientInput>b__19_2(BasePlayer ply) { }

}

public enum MicrophoneStand.SpeechMode // TypeDefIndex: 8606
{	// Fields
	public int value__; // 0x0
	public const MicrophoneStand.SpeechMode Normal = 0;
	public const MicrophoneStand.SpeechMode HighPitch = 1;
	public const MicrophoneStand.SpeechMode LowPitch = 2;

}


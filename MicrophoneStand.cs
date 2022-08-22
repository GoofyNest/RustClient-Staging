public class MicrophoneStand : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6417
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int microphoneMode; // 0x14
	public uint IORef; // 0x18

	// Methods

	// RVA: 0x1F46CC0 Offset: 0x1F452C0 VA: 0x181F46CC0
	public static void ResetToPool(MicrophoneStand instance) { }

	// RVA: 0x1F46D40 Offset: 0x1F45340 VA: 0x181F46D40
	public void ResetToPool() { }

	// RVA: 0x1F46A20 Offset: 0x1F45020 VA: 0x181F46A20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(MicrophoneStand instance) { }

	// RVA: 0x1F45C20 Offset: 0x1F44220 VA: 0x181F45C20
	public MicrophoneStand Copy() { }

	// RVA: 0x1F46860 Offset: 0x1F44E60 VA: 0x181F46860
	public static MicrophoneStand Deserialize(Stream stream) { }

	// RVA: 0x1F45C90 Offset: 0x1F44290 VA: 0x181F45C90
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F45F60 Offset: 0x1F44560 VA: 0x181F45F60
	public static MicrophoneStand DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F465F0 Offset: 0x1F44BF0 VA: 0x181F465F0
	public static MicrophoneStand Deserialize(byte[] buffer) { }

	// RVA: 0x1F46B20 Offset: 0x1F45120 VA: 0x181F46B20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F47200 Offset: 0x1F45800 VA: 0x181F47200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F47220 Offset: 0x1F45820 VA: 0x181F47220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MicrophoneStand previous) { }

	// RVA: 0x1F46CA0 Offset: 0x1F452A0 VA: 0x181F46CA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F463A0 Offset: 0x1F449A0 VA: 0x181F463A0
	public static MicrophoneStand Deserialize(byte[] buffer, MicrophoneStand instance, bool isDelta = False) { }

	// RVA: 0x1F46220 Offset: 0x1F44820 VA: 0x181F46220
	public static MicrophoneStand Deserialize(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F45D10 Offset: 0x1F44310 VA: 0x181F45D10
	public static MicrophoneStand DeserializeLengthDelimited(Stream stream, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F45FF0 Offset: 0x1F445F0 VA: 0x181F45FF0
	public static MicrophoneStand DeserializeLength(Stream stream, int length, MicrophoneStand instance, bool isDelta) { }

	// RVA: 0x1F46DC0 Offset: 0x1F453C0 VA: 0x181F46DC0
	public static void SerializeDelta(Stream stream, MicrophoneStand instance, MicrophoneStand previous) { }

	// RVA: 0x1F470F0 Offset: 0x1F456F0 VA: 0x181F470F0
	public static void Serialize(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1F471F0 Offset: 0x1F457F0 VA: 0x181F471F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F47200 Offset: 0x1F45800 VA: 0x181F47200
	public void ToProto(Stream stream) { }

	// RVA: 0x1F46FE0 Offset: 0x1F455E0 VA: 0x181F46FE0
	public static byte[] SerializeToBytes(MicrophoneStand instance) { }

	// RVA: 0x1F46F30 Offset: 0x1F45530 VA: 0x181F46F30
	public static void SerializeLengthDelimited(Stream stream, MicrophoneStand instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x96C130 Offset: 0x96A730 VA: 0x18096C130 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x96C470 Offset: 0x96AA70 VA: 0x18096C470
	private void Update() { }

	// RVA: 0x96BE00 Offset: 0x96A400 VA: 0x18096BE00 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x96C220 Offset: 0x96A820 VA: 0x18096C220
	public bool Receive(byte[] data) { }

	// RVA: 0x96BCA0 Offset: 0x96A2A0 VA: 0x18096BCA0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x96BCD0 Offset: 0x96A2D0 VA: 0x18096BCD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x96C4C0 Offset: 0x96AAC0 VA: 0x18096C4C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C380 Offset: 0x96A980 VA: 0x18096C380
	private void <OnClientInput>b__19_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C3D0 Offset: 0x96A9D0 VA: 0x18096C3D0
	private void <OnClientInput>b__19_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x96C420 Offset: 0x96AA20 VA: 0x18096C420
	private void <OnClientInput>b__19_2(BasePlayer ply) { }

}

public enum MicrophoneStand.SpeechMode // TypeDefIndex: 8606
{	// Fields
	public int value__; // 0x0
	public const MicrophoneStand.SpeechMode Normal = 0;
	public const MicrophoneStand.SpeechMode HighPitch = 1;
	public const MicrophoneStand.SpeechMode LowPitch = 2;

}


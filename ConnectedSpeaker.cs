public class ConnectedSpeaker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6414
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint connectedTo; // 0x14

	// Methods

	// RVA: 0x20B26B0 Offset: 0x20B0CB0 VA: 0x1820B26B0
	public static void ResetToPool(ConnectedSpeaker instance) { }

	// RVA: 0x20B2730 Offset: 0x20B0D30 VA: 0x1820B2730
	public void ResetToPool() { }

	// RVA: 0x20B2580 Offset: 0x20B0B80 VA: 0x1820B2580 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ConnectedSpeaker instance) { }

	// RVA: 0x20B1C00 Offset: 0x20B0200 VA: 0x1820B1C00
	public ConnectedSpeaker Copy() { }

	// RVA: 0x20B2400 Offset: 0x20B0A00 VA: 0x1820B2400
	public static ConnectedSpeaker Deserialize(Stream stream) { }

	// RVA: 0x20B1C70 Offset: 0x20B0270 VA: 0x1820B1C70
	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B2110 Offset: 0x20B0710 VA: 0x1820B2110
	public static ConnectedSpeaker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B21A0 Offset: 0x20B07A0 VA: 0x1820B21A0
	public static ConnectedSpeaker Deserialize(byte[] buffer) { }

	// RVA: 0x20B2670 Offset: 0x20B0C70 VA: 0x1820B2670
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B2C00 Offset: 0x20B1200 VA: 0x1820B2C00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B2CD0 Offset: 0x20B12D0 VA: 0x1820B2CD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ConnectedSpeaker previous) { }

	// RVA: 0x20B2690 Offset: 0x20B0C90 VA: 0x1820B2690 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B2480 Offset: 0x20B0A80 VA: 0x1820B2480
	public static ConnectedSpeaker Deserialize(byte[] buffer, ConnectedSpeaker instance, bool isDelta = False) { }

	// RVA: 0x20B22C0 Offset: 0x20B08C0 VA: 0x1820B22C0
	public static ConnectedSpeaker Deserialize(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20B1CF0 Offset: 0x20B02F0 VA: 0x1820B1CF0
	public static ConnectedSpeaker DeserializeLengthDelimited(Stream stream, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20B1F10 Offset: 0x20B0510 VA: 0x1820B1F10
	public static ConnectedSpeaker DeserializeLength(Stream stream, int length, ConnectedSpeaker instance, bool isDelta) { }

	// RVA: 0x20B27B0 Offset: 0x20B0DB0 VA: 0x1820B27B0
	public static void SerializeDelta(Stream stream, ConnectedSpeaker instance, ConnectedSpeaker previous) { }

	// RVA: 0x20B2B20 Offset: 0x20B1120 VA: 0x1820B2B20
	public static void Serialize(Stream stream, ConnectedSpeaker instance) { }

	// RVA: 0x20B2BF0 Offset: 0x20B11F0 VA: 0x1820B2BF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B2C00 Offset: 0x20B1200 VA: 0x1820B2C00
	public void ToProto(Stream stream) { }

	// RVA: 0x20B2970 Offset: 0x20B0F70 VA: 0x1820B2970
	public static byte[] SerializeToBytes(ConnectedSpeaker instance) { }

	// RVA: 0x20B28C0 Offset: 0x20B0EC0 VA: 0x1820B28C0
	public static void SerializeLengthDelimited(Stream stream, ConnectedSpeaker instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ConnectedSpeaker : IOEntity // TypeDefIndex: 8563
{	// Fields
	public AudioSource SoundSource; // 0x288
	private EntityRef<IOEntity> connectedTo; // 0x290
	public VoiceProcessor VoiceProcessor; // 0x2A0
	private ShoutcastStreamer connectedToStreamer; // 0x2A8
	private VoiceProcessor connectedToProcessor; // 0x2B0
	private bool isPlayingStreamedAudio; // 0x2B8
	private uint currentReadIndex; // 0x2BC

	// Methods

	// RVA: 0x2FAC50 Offset: 0x2F9250 VA: 0x1802FAC50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x2FB650 Offset: 0x2F9C50 VA: 0x1802FB650 Slot: 27
	public override void ResetState() { }

	// RVA: 0x2FBA00 Offset: 0x2FA000 VA: 0x1802FBA00
	public void SetAudio(Sound sound) { }

	// RVA: 0x2FBC70 Offset: 0x2FA270 VA: 0x1802FBC70
	public void StopPlaying() { }

	// RVA: 0x2FAAB0 Offset: 0x2F90B0 VA: 0x1802FAAB0
	private void OnAudioRead(float[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA6C0 Offset: 0x2F8CC0 VA: 0x1802FA6C0
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA830 Offset: 0x2F8E30 VA: 0x1802FA830
	private void Client_StopPlayingAudio(BaseEntity.RPCMessage msg) { }

	// RVA: 0x2FA5D0 Offset: 0x2F8BD0 VA: 0x1802FA5D0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x2FB740 Offset: 0x2F9D40 VA: 0x1802FB740
	public void SetAudio(AudioClip clip, float time) { }

	// RVA: 0x2FB7B0 Offset: 0x2F9DB0 VA: 0x1802FB7B0
	public void SetAudio(ShoutcastStreamer streamer, AudioClip clip, float time) { }

	// RVA: 0x2FBE60 Offset: 0x2FA460 VA: 0x1802FBE60
	private void UpdatePlaylist() { }

	// RVA: 0x2FBB80 Offset: 0x2FA180 VA: 0x1802FBB80
	public void SetAudio(VoiceProcessor processor) { }

	// RVA: 0x2FC050 Offset: 0x2FA650 VA: 0x1802FC050
	private void VoiceUpdate() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 GetWorldPosition() { }

	// RVA: 0x2FA9A0 Offset: 0x2F8FA0 VA: 0x1802FA9A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x2FAB90 Offset: 0x2F9190 VA: 0x1802FAB90 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x2FAA30 Offset: 0x2F9030 VA: 0x1802FAA30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x2FC080 Offset: 0x2FA680 VA: 0x1802FC080
	public void .ctor() { }

}


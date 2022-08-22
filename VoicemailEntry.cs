public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1E4FF20 Offset: 0x1E4E520 VA: 0x181E4FF20
	public static void ResetToPool(VoicemailEntry instance) { }

	// RVA: 0x1E4FE70 Offset: 0x1E4E470 VA: 0x181E4FE70
	public void ResetToPool() { }

	// RVA: 0x1E4FB60 Offset: 0x1E4E160 VA: 0x181E4FB60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4EB70 Offset: 0x1E4D170 VA: 0x181E4EB70
	public void CopyTo(VoicemailEntry instance) { }

	// RVA: 0x1E4EBC0 Offset: 0x1E4D1C0 VA: 0x181E4EBC0
	public VoicemailEntry Copy() { }

	// RVA: 0x1E4F960 Offset: 0x1E4DF60 VA: 0x181E4F960
	public static VoicemailEntry Deserialize(Stream stream) { }

	// RVA: 0x1E4EEE0 Offset: 0x1E4D4E0 VA: 0x181E4EEE0
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4EF60 Offset: 0x1E4D560 VA: 0x181E4EF60
	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4F4F0 Offset: 0x1E4DAF0 VA: 0x181E4F4F0
	public static VoicemailEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E4FC90 Offset: 0x1E4E290 VA: 0x181E4FC90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E506B0 Offset: 0x1E4ECB0 VA: 0x181E506B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E506D0 Offset: 0x1E4ECD0 VA: 0x181E506D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	// RVA: 0x1E4FE50 Offset: 0x1E4E450 VA: 0x181E4FE50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4F260 Offset: 0x1E4D860 VA: 0x181E4F260
	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	// RVA: 0x1E4F7A0 Offset: 0x1E4DDA0 VA: 0x181E4F7A0
	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4EC50 Offset: 0x1E4D250 VA: 0x181E4EC50
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4EFF0 Offset: 0x1E4D5F0 VA: 0x181E4EFF0
	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4FFD0 Offset: 0x1E4E5D0 VA: 0x181E4FFD0
	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	// RVA: 0x1E50470 Offset: 0x1E4EA70 VA: 0x181E50470
	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1E506A0 Offset: 0x1E4ECA0 VA: 0x181E506A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E506B0 Offset: 0x1E4ECB0 VA: 0x181E506B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E50360 Offset: 0x1E4E960 VA: 0x181E50360
	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	// RVA: 0x1E50270 Offset: 0x1E4E870 VA: 0x181E50270
	public static void SerializeLengthDelimited(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VoicemailEntry : MonoBehaviour // TypeDefIndex: 10902
{	// Fields
	public GameObject PlayingRoot; // 0x18
	public RustText DisplayName; // 0x20
	public RustIcon PlayIcon; // 0x28
	public RustSlider ProgressSlider; // 0x30
	private bool playingState; // 0x38
	private uint cachedId; // 0x3C
	private VoicemailDialog parentDialog; // 0x40
	private float lastTime; // 0x48

	// Methods

	// RVA: 0x803030 Offset: 0x801630 VA: 0x180803030
	public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

	// RVA: 0x802FA0 Offset: 0x8015A0 VA: 0x180802FA0
	public void OnClickedPlay() { }

	// RVA: 0x802E10 Offset: 0x801410 VA: 0x180802E10
	public void CancelPlay() { }

	// RVA: 0x803390 Offset: 0x801990 VA: 0x180803390
	private void UpdateIcon() { }

	// RVA: 0x802E60 Offset: 0x801460 VA: 0x180802E60
	public void OnClickedDelete() { }

	// RVA: 0x803420 Offset: 0x801A20 VA: 0x180803420
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}


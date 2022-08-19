public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1E500E0 Offset: 0x1E4E6E0 VA: 0x181E500E0
	public static void ResetToPool(VoicemailEntry instance) { }

	// RVA: 0x1E50030 Offset: 0x1E4E630 VA: 0x181E50030
	public void ResetToPool() { }

	// RVA: 0x1E4FD20 Offset: 0x1E4E320 VA: 0x181E4FD20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4ED30 Offset: 0x1E4D330 VA: 0x181E4ED30
	public void CopyTo(VoicemailEntry instance) { }

	// RVA: 0x1E4ED80 Offset: 0x1E4D380 VA: 0x181E4ED80
	public VoicemailEntry Copy() { }

	// RVA: 0x1E4FB20 Offset: 0x1E4E120 VA: 0x181E4FB20
	public static VoicemailEntry Deserialize(Stream stream) { }

	// RVA: 0x1E4F0A0 Offset: 0x1E4D6A0 VA: 0x181E4F0A0
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4F120 Offset: 0x1E4D720 VA: 0x181E4F120
	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4F6B0 Offset: 0x1E4DCB0 VA: 0x181E4F6B0
	public static VoicemailEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E4FE50 Offset: 0x1E4E450 VA: 0x181E4FE50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E50870 Offset: 0x1E4EE70 VA: 0x181E50870 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E50890 Offset: 0x1E4EE90 VA: 0x181E50890 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	// RVA: 0x1E50010 Offset: 0x1E4E610 VA: 0x181E50010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4F420 Offset: 0x1E4DA20 VA: 0x181E4F420
	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	// RVA: 0x1E4F960 Offset: 0x1E4DF60 VA: 0x181E4F960
	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4EE10 Offset: 0x1E4D410 VA: 0x181E4EE10
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4F1B0 Offset: 0x1E4D7B0 VA: 0x181E4F1B0
	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E50190 Offset: 0x1E4E790 VA: 0x181E50190
	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	// RVA: 0x1E50630 Offset: 0x1E4EC30 VA: 0x181E50630
	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1E50860 Offset: 0x1E4EE60 VA: 0x181E50860
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E50870 Offset: 0x1E4EE70 VA: 0x181E50870
	public void ToProto(Stream stream) { }

	// RVA: 0x1E50520 Offset: 0x1E4EB20 VA: 0x181E50520
	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	// RVA: 0x1E50430 Offset: 0x1E4EA30 VA: 0x181E50430
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


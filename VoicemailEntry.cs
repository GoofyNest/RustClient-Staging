public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1E50A00 Offset: 0x1E4F000 VA: 0x181E50A00
	public static void ResetToPool(VoicemailEntry instance) { }

	// RVA: 0x1E50950 Offset: 0x1E4EF50 VA: 0x181E50950
	public void ResetToPool() { }

	// RVA: 0x1E50640 Offset: 0x1E4EC40 VA: 0x181E50640 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4F650 Offset: 0x1E4DC50 VA: 0x181E4F650
	public void CopyTo(VoicemailEntry instance) { }

	// RVA: 0x1E4F6A0 Offset: 0x1E4DCA0 VA: 0x181E4F6A0
	public VoicemailEntry Copy() { }

	// RVA: 0x1E50440 Offset: 0x1E4EA40 VA: 0x181E50440
	public static VoicemailEntry Deserialize(Stream stream) { }

	// RVA: 0x1E4F9C0 Offset: 0x1E4DFC0 VA: 0x181E4F9C0
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4FA40 Offset: 0x1E4E040 VA: 0x181E4FA40
	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4FFD0 Offset: 0x1E4E5D0 VA: 0x181E4FFD0
	public static VoicemailEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E50770 Offset: 0x1E4ED70 VA: 0x181E50770
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E51190 Offset: 0x1E4F790 VA: 0x181E51190 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E511B0 Offset: 0x1E4F7B0 VA: 0x181E511B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	// RVA: 0x1E50930 Offset: 0x1E4EF30 VA: 0x181E50930 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4FD40 Offset: 0x1E4E340 VA: 0x181E4FD40
	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	// RVA: 0x1E50280 Offset: 0x1E4E880 VA: 0x181E50280
	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4F730 Offset: 0x1E4DD30 VA: 0x181E4F730
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4FAD0 Offset: 0x1E4E0D0 VA: 0x181E4FAD0
	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E50AB0 Offset: 0x1E4F0B0 VA: 0x181E50AB0
	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	// RVA: 0x1E50F50 Offset: 0x1E4F550 VA: 0x181E50F50
	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1E51180 Offset: 0x1E4F780 VA: 0x181E51180
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E51190 Offset: 0x1E4F790 VA: 0x181E51190
	public void ToProto(Stream stream) { }

	// RVA: 0x1E50E40 Offset: 0x1E4F440 VA: 0x181E50E40
	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	// RVA: 0x1E50D50 Offset: 0x1E4F350 VA: 0x181E50D50
	public static void SerializeLengthDelimited(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x8036D0 Offset: 0x801CD0 VA: 0x1808036D0
	public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

	// RVA: 0x803640 Offset: 0x801C40 VA: 0x180803640
	public void OnClickedPlay() { }

	// RVA: 0x8034B0 Offset: 0x801AB0 VA: 0x1808034B0
	public void CancelPlay() { }

	// RVA: 0x803A30 Offset: 0x802030 VA: 0x180803A30
	private void UpdateIcon() { }

	// RVA: 0x803500 Offset: 0x801B00 VA: 0x180803500
	public void OnClickedDelete() { }

	// RVA: 0x803AC0 Offset: 0x8020C0 VA: 0x180803AC0
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}


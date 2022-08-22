public class VoicemailEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6415
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint audioId; // 0x14
	public string userName; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1E501E0 Offset: 0x1E4E7E0 VA: 0x181E501E0
	public static void ResetToPool(VoicemailEntry instance) { }

	// RVA: 0x1E50130 Offset: 0x1E4E730 VA: 0x181E50130
	public void ResetToPool() { }

	// RVA: 0x1E4FE20 Offset: 0x1E4E420 VA: 0x181E4FE20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4EE30 Offset: 0x1E4D430 VA: 0x181E4EE30
	public void CopyTo(VoicemailEntry instance) { }

	// RVA: 0x1E4EE80 Offset: 0x1E4D480 VA: 0x181E4EE80
	public VoicemailEntry Copy() { }

	// RVA: 0x1E4FC20 Offset: 0x1E4E220 VA: 0x181E4FC20
	public static VoicemailEntry Deserialize(Stream stream) { }

	// RVA: 0x1E4F1A0 Offset: 0x1E4D7A0 VA: 0x181E4F1A0
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4F220 Offset: 0x1E4D820 VA: 0x181E4F220
	public static VoicemailEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4F7B0 Offset: 0x1E4DDB0 VA: 0x181E4F7B0
	public static VoicemailEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E4FF50 Offset: 0x1E4E550 VA: 0x181E4FF50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E50970 Offset: 0x1E4EF70 VA: 0x181E50970 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E50990 Offset: 0x1E4EF90 VA: 0x181E50990 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VoicemailEntry previous) { }

	// RVA: 0x1E50110 Offset: 0x1E4E710 VA: 0x181E50110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4F520 Offset: 0x1E4DB20 VA: 0x181E4F520
	public static VoicemailEntry Deserialize(byte[] buffer, VoicemailEntry instance, bool isDelta = False) { }

	// RVA: 0x1E4FA60 Offset: 0x1E4E060 VA: 0x181E4FA60
	public static VoicemailEntry Deserialize(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4EF10 Offset: 0x1E4D510 VA: 0x181E4EF10
	public static VoicemailEntry DeserializeLengthDelimited(Stream stream, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E4F2B0 Offset: 0x1E4D8B0 VA: 0x181E4F2B0
	public static VoicemailEntry DeserializeLength(Stream stream, int length, VoicemailEntry instance, bool isDelta) { }

	// RVA: 0x1E50290 Offset: 0x1E4E890 VA: 0x181E50290
	public static void SerializeDelta(Stream stream, VoicemailEntry instance, VoicemailEntry previous) { }

	// RVA: 0x1E50730 Offset: 0x1E4ED30 VA: 0x181E50730
	public static void Serialize(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1E50960 Offset: 0x1E4EF60 VA: 0x181E50960
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E50970 Offset: 0x1E4EF70 VA: 0x181E50970
	public void ToProto(Stream stream) { }

	// RVA: 0x1E50620 Offset: 0x1E4EC20 VA: 0x181E50620
	public static byte[] SerializeToBytes(VoicemailEntry instance) { }

	// RVA: 0x1E50530 Offset: 0x1E4EB30 VA: 0x181E50530
	public static void SerializeLengthDelimited(Stream stream, VoicemailEntry instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x803140 Offset: 0x801740 VA: 0x180803140
	public void Populate(VoicemailEntry entry, VoicemailDialog dialog) { }

	// RVA: 0x8030B0 Offset: 0x8016B0 VA: 0x1808030B0
	public void OnClickedPlay() { }

	// RVA: 0x802F20 Offset: 0x801520 VA: 0x180802F20
	public void CancelPlay() { }

	// RVA: 0x8034A0 Offset: 0x801AA0 VA: 0x1808034A0
	private void UpdateIcon() { }

	// RVA: 0x802F70 Offset: 0x801570 VA: 0x180802F70
	public void OnClickedDelete() { }

	// RVA: 0x803530 Offset: 0x801B30 VA: 0x180803530
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}


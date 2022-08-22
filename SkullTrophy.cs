public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18

	// Methods

	// RVA: 0x1E0E3B0 Offset: 0x1E0C9B0 VA: 0x181E0E3B0
	public static void ResetToPool(SkullTrophy instance) { }

	// RVA: 0x1E0E440 Offset: 0x1E0CA40 VA: 0x181E0E440
	public void ResetToPool() { }

	// RVA: 0x1E0E260 Offset: 0x1E0C860 VA: 0x181E0E260 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67B90 Offset: 0x1D66190 VA: 0x181D67B90
	public void CopyTo(SkullTrophy instance) { }

	// RVA: 0x1E0D8C0 Offset: 0x1E0BEC0 VA: 0x181E0D8C0
	public SkullTrophy Copy() { }

	// RVA: 0x1E0E1E0 Offset: 0x1E0C7E0 VA: 0x181E0E1E0
	public static SkullTrophy Deserialize(Stream stream) { }

	// RVA: 0x1E0D940 Offset: 0x1E0BF40 VA: 0x181E0D940
	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0DBE0 Offset: 0x1E0C1E0 VA: 0x181E0DBE0
	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0DE70 Offset: 0x1E0C470 VA: 0x181E0DE70
	public static SkullTrophy Deserialize(byte[] buffer) { }

	// RVA: 0x1E0E370 Offset: 0x1E0C970 VA: 0x181E0E370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0E8B0 Offset: 0x1E0CEB0 VA: 0x181E0E8B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0E8D0 Offset: 0x1E0CED0 VA: 0x181E0E8D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	// RVA: 0x1E0E390 Offset: 0x1E0C990 VA: 0x181E0E390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0E0E0 Offset: 0x1E0C6E0 VA: 0x181E0E0E0
	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	// RVA: 0x1E0DF90 Offset: 0x1E0C590 VA: 0x181E0DF90
	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0D9C0 Offset: 0x1E0BFC0 VA: 0x181E0D9C0
	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0DC70 Offset: 0x1E0C270 VA: 0x181E0DC70
	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0E4D0 Offset: 0x1E0CAD0 VA: 0x181E0E4D0
	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	// RVA: 0x1E0E7B0 Offset: 0x1E0CDB0 VA: 0x181E0E7B0
	public static void Serialize(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1E0E8A0 Offset: 0x1E0CEA0 VA: 0x181E0E8A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0E8B0 Offset: 0x1E0CEB0 VA: 0x181E0E8B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0E6A0 Offset: 0x1E0CCA0 VA: 0x181E0E6A0
	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	// RVA: 0x1E0E5F0 Offset: 0x1E0CBF0 VA: 0x181E0E5F0
	public static void SerializeLengthDelimited(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class SkullTrophy : StorageContainer // TypeDefIndex: 8795
{	// Fields
	public RustText NameText; // 0x3D0
	public TextProOnACircle CircleModifier; // 0x3D8
	public int AngleModifierMinCharCount; // 0x3E0
	public int AngleModifierMaxCharCount; // 0x3E4
	public int AngleModifierMinArcAngle; // 0x3E8
	public int AngleModifierMaxArcAngle; // 0x3EC
	public float SunsetTime; // 0x3F0
	public float SunriseTime; // 0x3F4
	public MeshRenderer[] SkullRenderers; // 0x3F8
	public Material[] DaySkull; // 0x400
	public Material[] NightSkull; // 0x408
	public Material[] NoSkull; // 0x410

	// Properties
	private bool IsNightTime { get; }

	// Methods

	// RVA: 0x5A5CE0 Offset: 0x5A42E0 VA: 0x1805A5CE0
	private void UpdateVisual(string playerName) { }

	// RVA: 0x5A5BA0 Offset: 0x5A41A0 VA: 0x1805A5BA0
	private void ApplySkullMaterials(Material[] mats) { }

	// RVA: 0x5A5C90 Offset: 0x5A4290 VA: 0x1805A5C90
	private void UpdateLights() { }

	// RVA: 0x5A6020 Offset: 0x5A4620 VA: 0x1805A6020
	private bool get_IsNightTime() { }

	// RVA: 0x5A5C20 Offset: 0x5A4220 VA: 0x1805A5C20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A5F90 Offset: 0x5A4590 VA: 0x1805A5F90
	public void .ctor() { }

}


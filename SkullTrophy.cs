public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18

	// Methods

	// RVA: 0x1E0EE90 Offset: 0x1E0D490 VA: 0x181E0EE90
	public static void ResetToPool(SkullTrophy instance) { }

	// RVA: 0x1E0EF20 Offset: 0x1E0D520 VA: 0x181E0EF20
	public void ResetToPool() { }

	// RVA: 0x1E0ED40 Offset: 0x1E0D340 VA: 0x181E0ED40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D68640 Offset: 0x1D66C40 VA: 0x181D68640
	public void CopyTo(SkullTrophy instance) { }

	// RVA: 0x1E0E3A0 Offset: 0x1E0C9A0 VA: 0x181E0E3A0
	public SkullTrophy Copy() { }

	// RVA: 0x1E0ECC0 Offset: 0x1E0D2C0 VA: 0x181E0ECC0
	public static SkullTrophy Deserialize(Stream stream) { }

	// RVA: 0x1E0E420 Offset: 0x1E0CA20 VA: 0x181E0E420
	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0E6C0 Offset: 0x1E0CCC0 VA: 0x181E0E6C0
	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0E950 Offset: 0x1E0CF50 VA: 0x181E0E950
	public static SkullTrophy Deserialize(byte[] buffer) { }

	// RVA: 0x1E0EE50 Offset: 0x1E0D450 VA: 0x181E0EE50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0F390 Offset: 0x1E0D990 VA: 0x181E0F390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0F3B0 Offset: 0x1E0D9B0 VA: 0x181E0F3B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	// RVA: 0x1E0EE70 Offset: 0x1E0D470 VA: 0x181E0EE70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0EBC0 Offset: 0x1E0D1C0 VA: 0x181E0EBC0
	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	// RVA: 0x1E0EA70 Offset: 0x1E0D070 VA: 0x181E0EA70
	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0E4A0 Offset: 0x1E0CAA0 VA: 0x181E0E4A0
	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0E750 Offset: 0x1E0CD50 VA: 0x181E0E750
	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0EFB0 Offset: 0x1E0D5B0 VA: 0x181E0EFB0
	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	// RVA: 0x1E0F290 Offset: 0x1E0D890 VA: 0x181E0F290
	public static void Serialize(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1E0F380 Offset: 0x1E0D980 VA: 0x181E0F380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0F390 Offset: 0x1E0D990 VA: 0x181E0F390
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0F180 Offset: 0x1E0D780 VA: 0x181E0F180
	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	// RVA: 0x1E0F0D0 Offset: 0x1E0D6D0 VA: 0x181E0F0D0
	public static void SerializeLengthDelimited(Stream stream, SkullTrophy instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x5A5C70 Offset: 0x5A4270 VA: 0x1805A5C70
	private void UpdateVisual(string playerName) { }

	// RVA: 0x5A5B30 Offset: 0x5A4130 VA: 0x1805A5B30
	private void ApplySkullMaterials(Material[] mats) { }

	// RVA: 0x5A5C20 Offset: 0x5A4220 VA: 0x1805A5C20
	private void UpdateLights() { }

	// RVA: 0x5A5FB0 Offset: 0x5A45B0 VA: 0x1805A5FB0
	private bool get_IsNightTime() { }

	// RVA: 0x5A5BB0 Offset: 0x5A41B0 VA: 0x1805A5BB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A5F20 Offset: 0x5A4520 VA: 0x1805A5F20
	public void .ctor() { }

}


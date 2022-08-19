public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18

	// Methods

	// RVA: 0x1E0E570 Offset: 0x1E0CB70 VA: 0x181E0E570
	public static void ResetToPool(SkullTrophy instance) { }

	// RVA: 0x1E0E600 Offset: 0x1E0CC00 VA: 0x181E0E600
	public void ResetToPool() { }

	// RVA: 0x1E0E420 Offset: 0x1E0CA20 VA: 0x181E0E420 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67D50 Offset: 0x1D66350 VA: 0x181D67D50
	public void CopyTo(SkullTrophy instance) { }

	// RVA: 0x1E0DA80 Offset: 0x1E0C080 VA: 0x181E0DA80
	public SkullTrophy Copy() { }

	// RVA: 0x1E0E3A0 Offset: 0x1E0C9A0 VA: 0x181E0E3A0
	public static SkullTrophy Deserialize(Stream stream) { }

	// RVA: 0x1E0DB00 Offset: 0x1E0C100 VA: 0x181E0DB00
	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0DDA0 Offset: 0x1E0C3A0 VA: 0x181E0DDA0
	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0E030 Offset: 0x1E0C630 VA: 0x181E0E030
	public static SkullTrophy Deserialize(byte[] buffer) { }

	// RVA: 0x1E0E530 Offset: 0x1E0CB30 VA: 0x181E0E530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0EA70 Offset: 0x1E0D070 VA: 0x181E0EA70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0EA90 Offset: 0x1E0D090 VA: 0x181E0EA90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	// RVA: 0x1E0E550 Offset: 0x1E0CB50 VA: 0x181E0E550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0E2A0 Offset: 0x1E0C8A0 VA: 0x181E0E2A0
	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	// RVA: 0x1E0E150 Offset: 0x1E0C750 VA: 0x181E0E150
	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0DB80 Offset: 0x1E0C180 VA: 0x181E0DB80
	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0DE30 Offset: 0x1E0C430 VA: 0x181E0DE30
	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0E690 Offset: 0x1E0CC90 VA: 0x181E0E690
	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	// RVA: 0x1E0E970 Offset: 0x1E0CF70 VA: 0x181E0E970
	public static void Serialize(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1E0EA60 Offset: 0x1E0D060 VA: 0x181E0EA60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0EA70 Offset: 0x1E0D070 VA: 0x181E0EA70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0E860 Offset: 0x1E0CE60 VA: 0x181E0E860
	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	// RVA: 0x1E0E7B0 Offset: 0x1E0CDB0 VA: 0x181E0E7B0
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


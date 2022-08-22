public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18

	// Methods

	// RVA: 0x1E0E670 Offset: 0x1E0CC70 VA: 0x181E0E670
	public static void ResetToPool(SkullTrophy instance) { }

	// RVA: 0x1E0E700 Offset: 0x1E0CD00 VA: 0x181E0E700
	public void ResetToPool() { }

	// RVA: 0x1E0E520 Offset: 0x1E0CB20 VA: 0x181E0E520 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D67E50 Offset: 0x1D66450 VA: 0x181D67E50
	public void CopyTo(SkullTrophy instance) { }

	// RVA: 0x1E0DB80 Offset: 0x1E0C180 VA: 0x181E0DB80
	public SkullTrophy Copy() { }

	// RVA: 0x1E0E4A0 Offset: 0x1E0CAA0 VA: 0x181E0E4A0
	public static SkullTrophy Deserialize(Stream stream) { }

	// RVA: 0x1E0DC00 Offset: 0x1E0C200 VA: 0x181E0DC00
	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0DEA0 Offset: 0x1E0C4A0 VA: 0x181E0DEA0
	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0E130 Offset: 0x1E0C730 VA: 0x181E0E130
	public static SkullTrophy Deserialize(byte[] buffer) { }

	// RVA: 0x1E0E630 Offset: 0x1E0CC30 VA: 0x181E0E630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0EB70 Offset: 0x1E0D170 VA: 0x181E0EB70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0EB90 Offset: 0x1E0D190 VA: 0x181E0EB90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	// RVA: 0x1E0E650 Offset: 0x1E0CC50 VA: 0x181E0E650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0E3A0 Offset: 0x1E0C9A0 VA: 0x181E0E3A0
	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	// RVA: 0x1E0E250 Offset: 0x1E0C850 VA: 0x181E0E250
	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0DC80 Offset: 0x1E0C280 VA: 0x181E0DC80
	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0DF30 Offset: 0x1E0C530 VA: 0x181E0DF30
	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E0E790 Offset: 0x1E0CD90 VA: 0x181E0E790
	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	// RVA: 0x1E0EA70 Offset: 0x1E0D070 VA: 0x181E0EA70
	public static void Serialize(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1E0EB60 Offset: 0x1E0D160 VA: 0x181E0EB60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0EB70 Offset: 0x1E0D170 VA: 0x181E0EB70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0E960 Offset: 0x1E0CF60 VA: 0x181E0E960
	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	// RVA: 0x1E0E8B0 Offset: 0x1E0CEB0 VA: 0x181E0E8B0
	public static void SerializeLengthDelimited(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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


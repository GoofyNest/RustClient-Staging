public class Modifier : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6448
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int source; // 0x18
	public float value; // 0x1C
	public float timeRemaing; // 0x20
	public float duration; // 0x24

	// Methods

	// RVA: 0x1F55920 Offset: 0x1F53F20 VA: 0x181F55920
	public static void ResetToPool(Modifier instance) { }

	// RVA: 0x1F559D0 Offset: 0x1F53FD0 VA: 0x181F559D0
	public void ResetToPool() { }

	// RVA: 0x1F55580 Offset: 0x1F53B80 VA: 0x181F55580 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E219A0 Offset: 0x1E1FFA0 VA: 0x181E219A0
	public void CopyTo(Modifier instance) { }

	// RVA: 0x1F54250 Offset: 0x1F52850 VA: 0x181F54250
	public Modifier Copy() { }

	// RVA: 0x1F552F0 Offset: 0x1F538F0 VA: 0x181F552F0
	public static Modifier Deserialize(Stream stream) { }

	// RVA: 0x1F54600 Offset: 0x1F52C00 VA: 0x181F54600
	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F54990 Offset: 0x1F52F90 VA: 0x181F54990
	public static Modifier DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F54A20 Offset: 0x1F53020 VA: 0x181F54A20
	public static Modifier Deserialize(byte[] buffer) { }

	// RVA: 0x1F556B0 Offset: 0x1F53CB0 VA: 0x181F556B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F56050 Offset: 0x1F54650 VA: 0x181F56050 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F56070 Offset: 0x1F54670 VA: 0x181F56070 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	// RVA: 0x1F55900 Offset: 0x1F53F00 VA: 0x181F55900 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F54FC0 Offset: 0x1F535C0 VA: 0x181F54FC0
	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	// RVA: 0x1F54D70 Offset: 0x1F53370 VA: 0x181F54D70
	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F542D0 Offset: 0x1F528D0 VA: 0x181F542D0
	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54680 Offset: 0x1F52C80 VA: 0x181F54680
	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	// RVA: 0x1F55A80 Offset: 0x1F54080 VA: 0x181F55A80
	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	// RVA: 0x1F55ED0 Offset: 0x1F544D0 VA: 0x181F55ED0
	public static void Serialize(Stream stream, Modifier instance) { }

	// RVA: 0x1F56040 Offset: 0x1F54640 VA: 0x181F56040
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F56050 Offset: 0x1F54650 VA: 0x181F56050
	public void ToProto(Stream stream) { }

	// RVA: 0x1F55DC0 Offset: 0x1F543C0 VA: 0x181F55DC0
	public static byte[] SerializeToBytes(Modifier instance) { }

	// RVA: 0x1F55D10 Offset: 0x1F54310 VA: 0x181F55D10
	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Modifier // TypeDefIndex: 9623
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Modifier.ModifierType <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Modifier.ModifierSource <Source>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Value>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Duration>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <TimeRemaining>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <Expired>k__BackingField; // 0x24
	private float lastClientUpdateTimestamp; // 0x28

	// Properties
	public Modifier.ModifierType Type { get; set; }
	public Modifier.ModifierSource Source { get; set; }
	public float Value { get; set; }
	public float Duration { get; set; }
	public float TimeRemaining { get; set; }
	public bool Expired { get; set; }
	public float ClientEstimatedTimeRemaining { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public Modifier.ModifierType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Type(Modifier.ModifierType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public Modifier.ModifierSource get_Source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_Source(Modifier.ModifierSource value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746C0 Offset: 0x772CC0 VA: 0x1807746C0
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774690 Offset: 0x772C90 VA: 0x180774690
	public bool get_Expired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746D0 Offset: 0x772CD0 VA: 0x1807746D0
	private void set_Expired(bool value) { }

	// RVA: 0x7745E0 Offset: 0x772BE0 VA: 0x1807745E0
	public float get_ClientEstimatedTimeRemaining() { }

	// RVA: 0x7744A0 Offset: 0x772AA0 VA: 0x1807744A0
	public void Init(Modifier.ModifierType type, Modifier.ModifierSource source, float value, float duration, float remaining) { }

	// RVA: 0x7745A0 Offset: 0x772BA0 VA: 0x1807745A0
	public void Tick(BaseCombatEntity ownerEntity, float delta) { }

	// RVA: 0x774520 Offset: 0x772B20 VA: 0x180774520
	public Modifier Save() { }

	// RVA: 0x7744F0 Offset: 0x772AF0 VA: 0x1807744F0
	public void Load(Modifier m) { }

	// RVA: 0x7745C0 Offset: 0x772BC0 VA: 0x1807745C0
	public void .ctor() { }

}

public enum Modifier.ModifierType // TypeDefIndex: 9624
{	// Fields
	public int value__; // 0x0
	public const Modifier.ModifierType Wood_Yield = 0;
	public const Modifier.ModifierType Ore_Yield = 1;
	public const Modifier.ModifierType Radiation_Resistance = 2;
	public const Modifier.ModifierType Radiation_Exposure_Resistance = 3;
	public const Modifier.ModifierType Max_Health = 4;
	public const Modifier.ModifierType Scrap_Yield = 5;

}

public enum Modifier.ModifierSource // TypeDefIndex: 9625
{	// Fields
	public int value__; // 0x0
	public const Modifier.ModifierSource Tea = 0;

}


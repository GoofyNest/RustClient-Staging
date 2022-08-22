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

	// RVA: 0x1F55BE0 Offset: 0x1F541E0 VA: 0x181F55BE0
	public static void ResetToPool(Modifier instance) { }

	// RVA: 0x1F55C90 Offset: 0x1F54290 VA: 0x181F55C90
	public void ResetToPool() { }

	// RVA: 0x1F55840 Offset: 0x1F53E40 VA: 0x181F55840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21C60 Offset: 0x1E20260 VA: 0x181E21C60
	public void CopyTo(Modifier instance) { }

	// RVA: 0x1F54510 Offset: 0x1F52B10 VA: 0x181F54510
	public Modifier Copy() { }

	// RVA: 0x1F555B0 Offset: 0x1F53BB0 VA: 0x181F555B0
	public static Modifier Deserialize(Stream stream) { }

	// RVA: 0x1F548C0 Offset: 0x1F52EC0 VA: 0x181F548C0
	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F54C50 Offset: 0x1F53250 VA: 0x181F54C50
	public static Modifier DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F54CE0 Offset: 0x1F532E0 VA: 0x181F54CE0
	public static Modifier Deserialize(byte[] buffer) { }

	// RVA: 0x1F55970 Offset: 0x1F53F70 VA: 0x181F55970
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F56310 Offset: 0x1F54910 VA: 0x181F56310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F56330 Offset: 0x1F54930 VA: 0x181F56330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	// RVA: 0x1F55BC0 Offset: 0x1F541C0 VA: 0x181F55BC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F55280 Offset: 0x1F53880 VA: 0x181F55280
	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	// RVA: 0x1F55030 Offset: 0x1F53630 VA: 0x181F55030
	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54590 Offset: 0x1F52B90 VA: 0x181F54590
	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54940 Offset: 0x1F52F40 VA: 0x181F54940
	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	// RVA: 0x1F55D40 Offset: 0x1F54340 VA: 0x181F55D40
	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	// RVA: 0x1F56190 Offset: 0x1F54790 VA: 0x181F56190
	public static void Serialize(Stream stream, Modifier instance) { }

	// RVA: 0x1F56300 Offset: 0x1F54900 VA: 0x181F56300
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F56310 Offset: 0x1F54910 VA: 0x181F56310
	public void ToProto(Stream stream) { }

	// RVA: 0x1F56080 Offset: 0x1F54680 VA: 0x181F56080
	public static byte[] SerializeToBytes(Modifier instance) { }

	// RVA: 0x1F55FD0 Offset: 0x1F545D0 VA: 0x181F55FD0
	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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
	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774800 Offset: 0x772E00 VA: 0x180774800
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747D0 Offset: 0x772DD0 VA: 0x1807747D0
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747B0 Offset: 0x772DB0 VA: 0x1807747B0
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747F0 Offset: 0x772DF0 VA: 0x1807747F0
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747A0 Offset: 0x772DA0 VA: 0x1807747A0
	public bool get_Expired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7747E0 Offset: 0x772DE0 VA: 0x1807747E0
	private void set_Expired(bool value) { }

	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public float get_ClientEstimatedTimeRemaining() { }

	// RVA: 0x7745B0 Offset: 0x772BB0 VA: 0x1807745B0
	public void Init(Modifier.ModifierType type, Modifier.ModifierSource source, float value, float duration, float remaining) { }

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public void Tick(BaseCombatEntity ownerEntity, float delta) { }

	// RVA: 0x774630 Offset: 0x772C30 VA: 0x180774630
	public Modifier Save() { }

	// RVA: 0x774600 Offset: 0x772C00 VA: 0x180774600
	public void Load(Modifier m) { }

	// RVA: 0x7746D0 Offset: 0x772CD0 VA: 0x1807746D0
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


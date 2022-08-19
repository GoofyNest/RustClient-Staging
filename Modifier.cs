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

	// RVA: 0x1F55AE0 Offset: 0x1F540E0 VA: 0x181F55AE0
	public static void ResetToPool(Modifier instance) { }

	// RVA: 0x1F55B90 Offset: 0x1F54190 VA: 0x181F55B90
	public void ResetToPool() { }

	// RVA: 0x1F55740 Offset: 0x1F53D40 VA: 0x181F55740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E21B60 Offset: 0x1E20160 VA: 0x181E21B60
	public void CopyTo(Modifier instance) { }

	// RVA: 0x1F54410 Offset: 0x1F52A10 VA: 0x181F54410
	public Modifier Copy() { }

	// RVA: 0x1F554B0 Offset: 0x1F53AB0 VA: 0x181F554B0
	public static Modifier Deserialize(Stream stream) { }

	// RVA: 0x1F547C0 Offset: 0x1F52DC0 VA: 0x181F547C0
	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F54B50 Offset: 0x1F53150 VA: 0x181F54B50
	public static Modifier DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F54BE0 Offset: 0x1F531E0 VA: 0x181F54BE0
	public static Modifier Deserialize(byte[] buffer) { }

	// RVA: 0x1F55870 Offset: 0x1F53E70 VA: 0x181F55870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F56210 Offset: 0x1F54810 VA: 0x181F56210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F56230 Offset: 0x1F54830 VA: 0x181F56230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	// RVA: 0x1F55AC0 Offset: 0x1F540C0 VA: 0x181F55AC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F55180 Offset: 0x1F53780 VA: 0x181F55180
	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	// RVA: 0x1F54F30 Offset: 0x1F53530 VA: 0x181F54F30
	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54490 Offset: 0x1F52A90 VA: 0x181F54490
	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54840 Offset: 0x1F52E40 VA: 0x181F54840
	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	// RVA: 0x1F55C40 Offset: 0x1F54240 VA: 0x181F55C40
	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	// RVA: 0x1F56090 Offset: 0x1F54690 VA: 0x181F56090
	public static void Serialize(Stream stream, Modifier instance) { }

	// RVA: 0x1F56200 Offset: 0x1F54800 VA: 0x181F56200
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F56210 Offset: 0x1F54810 VA: 0x181F56210
	public void ToProto(Stream stream) { }

	// RVA: 0x1F55F80 Offset: 0x1F54580 VA: 0x181F55F80
	public static byte[] SerializeToBytes(Modifier instance) { }

	// RVA: 0x1F55ED0 Offset: 0x1F544D0 VA: 0x181F55ED0
	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Modifier // TypeDefIndex: 9623
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Modifier.ModifierType <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Modifier.ModifierSource <Source>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Value>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Duration>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <TimeRemaining>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public Modifier.ModifierType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Type(Modifier.ModifierType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public Modifier.ModifierSource get_Source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_Source(Modifier.ModifierSource value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746C0 Offset: 0x772CC0 VA: 0x1807746C0
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x774690 Offset: 0x772C90 VA: 0x180774690
	public bool get_Expired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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


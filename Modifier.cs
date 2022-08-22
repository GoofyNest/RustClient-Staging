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

	// RVA: 0x1F56400 Offset: 0x1F54A00 VA: 0x181F56400
	public static void ResetToPool(Modifier instance) { }

	// RVA: 0x1F564B0 Offset: 0x1F54AB0 VA: 0x181F564B0
	public void ResetToPool() { }

	// RVA: 0x1F56060 Offset: 0x1F54660 VA: 0x181F56060 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E22480 Offset: 0x1E20A80 VA: 0x181E22480
	public void CopyTo(Modifier instance) { }

	// RVA: 0x1F54D30 Offset: 0x1F53330 VA: 0x181F54D30
	public Modifier Copy() { }

	// RVA: 0x1F55DD0 Offset: 0x1F543D0 VA: 0x181F55DD0
	public static Modifier Deserialize(Stream stream) { }

	// RVA: 0x1F550E0 Offset: 0x1F536E0 VA: 0x181F550E0
	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F55470 Offset: 0x1F53A70 VA: 0x181F55470
	public static Modifier DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F55500 Offset: 0x1F53B00 VA: 0x181F55500
	public static Modifier Deserialize(byte[] buffer) { }

	// RVA: 0x1F56190 Offset: 0x1F54790 VA: 0x181F56190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F56B30 Offset: 0x1F55130 VA: 0x181F56B30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F56B50 Offset: 0x1F55150 VA: 0x181F56B50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	// RVA: 0x1F563E0 Offset: 0x1F549E0 VA: 0x181F563E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F55AA0 Offset: 0x1F540A0 VA: 0x181F55AA0
	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	// RVA: 0x1F55850 Offset: 0x1F53E50 VA: 0x181F55850
	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F54DB0 Offset: 0x1F533B0 VA: 0x181F54DB0
	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F55160 Offset: 0x1F53760 VA: 0x181F55160
	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	// RVA: 0x1F56560 Offset: 0x1F54B60 VA: 0x181F56560
	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	// RVA: 0x1F569B0 Offset: 0x1F54FB0 VA: 0x181F569B0
	public static void Serialize(Stream stream, Modifier instance) { }

	// RVA: 0x1F56B20 Offset: 0x1F55120 VA: 0x181F56B20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F56B30 Offset: 0x1F55130 VA: 0x181F56B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F568A0 Offset: 0x1F54EA0 VA: 0x181F568A0
	public static byte[] SerializeToBytes(Modifier instance) { }

	// RVA: 0x1F567F0 Offset: 0x1F54DF0 VA: 0x181F567F0
	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_Type(Modifier.ModifierType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public Modifier.ModifierSource get_Source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	private void set_Source(Modifier.ModifierSource value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774750 Offset: 0x772D50 VA: 0x180774750
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774720 Offset: 0x772D20 VA: 0x180774720
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774740 Offset: 0x772D40 VA: 0x180774740
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public bool get_Expired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774730 Offset: 0x772D30 VA: 0x180774730
	private void set_Expired(bool value) { }

	// RVA: 0x774640 Offset: 0x772C40 VA: 0x180774640
	public float get_ClientEstimatedTimeRemaining() { }

	// RVA: 0x774500 Offset: 0x772B00 VA: 0x180774500
	public void Init(Modifier.ModifierType type, Modifier.ModifierSource source, float value, float duration, float remaining) { }

	// RVA: 0x774600 Offset: 0x772C00 VA: 0x180774600
	public void Tick(BaseCombatEntity ownerEntity, float delta) { }

	// RVA: 0x774580 Offset: 0x772B80 VA: 0x180774580
	public Modifier Save() { }

	// RVA: 0x774550 Offset: 0x772B50 VA: 0x180774550
	public void Load(Modifier m) { }

	// RVA: 0x774620 Offset: 0x772C20 VA: 0x180774620
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


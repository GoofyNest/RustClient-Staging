public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24

	// Methods

	// RVA: 0x1F8CC60 Offset: 0x1F8B260 VA: 0x181F8CC60
	public static void ResetToPool(NeonSign instance) { }

	// RVA: 0x1F8CE50 Offset: 0x1F8B450 VA: 0x181F8CE50
	public void ResetToPool() { }

	// RVA: 0x1F8CBA0 Offset: 0x1F8B1A0 VA: 0x181F8CBA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8BB90 Offset: 0x1F8A190 VA: 0x181F8BB90
	public void CopyTo(NeonSign instance) { }

	// RVA: 0x1F8BD40 Offset: 0x1F8A340 VA: 0x181F8BD40
	public NeonSign Copy() { }

	// RVA: 0x1F8CA20 Offset: 0x1F8B020 VA: 0x181F8CA20
	public static NeonSign Deserialize(Stream stream) { }

	// RVA: 0x1F8BF40 Offset: 0x1F8A540 VA: 0x181F8BF40
	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8C300 Offset: 0x1F8A900 VA: 0x181F8C300
	public static NeonSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8C6A0 Offset: 0x1F8ACA0 VA: 0x181F8C6A0
	public static NeonSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F8CC20 Offset: 0x1F8B220 VA: 0x181F8CC20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8D720 Offset: 0x1F8BD20 VA: 0x181F8D720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8D740 Offset: 0x1F8BD40 VA: 0x181F8D740 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	// RVA: 0x1F8CC40 Offset: 0x1F8B240 VA: 0x181F8CC40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8CAA0 Offset: 0x1F8B0A0 VA: 0x181F8CAA0
	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	// RVA: 0x1F8C7C0 Offset: 0x1F8ADC0 VA: 0x181F8C7C0
	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8BFC0 Offset: 0x1F8A5C0 VA: 0x181F8BFC0
	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8C390 Offset: 0x1F8A990 VA: 0x181F8C390
	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8D040 Offset: 0x1F8B640 VA: 0x181F8D040
	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	// RVA: 0x1F8D4C0 Offset: 0x1F8BAC0 VA: 0x181F8D4C0
	public static void Serialize(Stream stream, NeonSign instance) { }

	// RVA: 0x1F8D710 Offset: 0x1F8BD10 VA: 0x181F8D710
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8D720 Offset: 0x1F8BD20 VA: 0x181F8D720
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8D3B0 Offset: 0x1F8B9B0 VA: 0x181F8D3B0
	public static byte[] SerializeToBytes(NeonSign instance) { }

	// RVA: 0x1F8D300 Offset: 0x1F8B900 VA: 0x181F8D300
	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class NeonSign.Lights : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6393
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Color topLeft; // 0x14
	public Color topRight; // 0x24
	public Color bottomLeft; // 0x34
	public Color bottomRight; // 0x44

	// Methods

	// RVA: 0x1F83DF0 Offset: 0x1F823F0 VA: 0x181F83DF0
	public static void ResetToPool(NeonSign.Lights instance) { }

	// RVA: 0x1F83E90 Offset: 0x1F82490 VA: 0x181F83E90
	public void ResetToPool() { }

	// RVA: 0x1F83B70 Offset: 0x1F82170 VA: 0x181F83B70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F82AB0 Offset: 0x1F810B0 VA: 0x181F82AB0
	public void CopyTo(NeonSign.Lights instance) { }

	// RVA: 0x1F82AF0 Offset: 0x1F810F0 VA: 0x181F82AF0
	public NeonSign.Lights Copy() { }

	// RVA: 0x1F83760 Offset: 0x1F81D60 VA: 0x181F83760
	public static NeonSign.Lights Deserialize(Stream stream) { }

	// RVA: 0x1F82E30 Offset: 0x1F81430 VA: 0x181F82E30
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F82EB0 Offset: 0x1F814B0 VA: 0x181F82EB0
	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F831E0 Offset: 0x1F817E0 VA: 0x181F831E0
	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	// RVA: 0x1F83BF0 Offset: 0x1F821F0 VA: 0x181F83BF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F849B0 Offset: 0x1F82FB0 VA: 0x181F849B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F849D0 Offset: 0x1F82FD0 VA: 0x181F849D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	// RVA: 0x1F83DD0 Offset: 0x1F823D0 VA: 0x181F83DD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F834B0 Offset: 0x1F81AB0 VA: 0x181F834B0
	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	// RVA: 0x1F83980 Offset: 0x1F81F80 VA: 0x181F83980
	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F82B70 Offset: 0x1F81170 VA: 0x181F82B70
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F82F40 Offset: 0x1F81540 VA: 0x181F82F40
	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F83F30 Offset: 0x1F82530 VA: 0x181F83F30
	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	// RVA: 0x1F84600 Offset: 0x1F82C00 VA: 0x181F84600
	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1F849A0 Offset: 0x1F82FA0 VA: 0x181F849A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F849B0 Offset: 0x1F82FB0 VA: 0x181F849B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F844F0 Offset: 0x1F82AF0 VA: 0x181F844F0
	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	// RVA: 0x1F84440 Offset: 0x1F82A40 VA: 0x181F84440
	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class NeonSign : Signage // TypeDefIndex: 8424
{	// Fields
	private Option __menuOption_SwitchToFastSpeed; // 0x3D0
	private Option __menuOption_SwitchToMediumSpeed; // 0x428
	private Option __menuOption_SwitchToSlowSpeed; // 0x480
	private const float FastSpeed = 0,5;
	private const float MediumSpeed = 1;
	private const float SlowSpeed = 2;
	private const float MinSpeed = 0,5;
	private const float MaxSpeed = 5;
	[HeaderAttribute] // RVA: 0x7AED0 Offset: 0x7A2D0 VA: 0x18007AED0
	public Light topLeft; // 0x4D8
	public Light topRight; // 0x4E0
	public Light bottomLeft; // 0x4E8
	public Light bottomRight; // 0x4F0
	public float lightIntensity; // 0x4F8
	[RangeAttribute] // RVA: 0x7AF00 Offset: 0x7A300 VA: 0x18007AF00
	public int powerConsumption; // 0x4FC
	public Material activeMaterial; // 0x500
	public Material inactiveMaterial; // 0x508
	private float animationSpeed; // 0x510
	private int currentFrame; // 0x514
	private List<NeonSign.Lights> frameLighting; // 0x518
	public AmbienceEmitter ambientSoundEmitter; // 0x520
	public SoundDefinition switchSoundDef; // 0x528

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7CC540 Offset: 0x7CAB40 VA: 0x1807CC540 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7CE530 Offset: 0x7CCB30 VA: 0x1807CE530 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7CCFD0 Offset: 0x7CB5D0 VA: 0x1807CCFD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7CC3D0 Offset: 0x7CA9D0 VA: 0x1807CC3D0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7CCFB0 Offset: 0x7CB5B0 VA: 0x1807CCFB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7CDE80 Offset: 0x7CC480 VA: 0x1807CDE80
	public void UpdateNeonDisplay() { }

	// RVA: 0x7CDB20 Offset: 0x7CC120 VA: 0x1807CDB20
	private void UpdateLights() { }

	// RVA: 0x7CE390 Offset: 0x7CC990 VA: 0x1807CE390
	private void UpdateSounds() { }

	// RVA: 0x7CCFA0 Offset: 0x7CB5A0 VA: 0x1807CCFA0 Slot: 171
	protected override void OnEnterTextureRange() { }

	// RVA: 0x7CD420 Offset: 0x7CBA20 VA: 0x1807CD420 Slot: 169
	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Description] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Icon] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	// RVA: 0x7CDAD0 Offset: 0x7CC0D0 VA: 0x1807CDAD0
	public void SwitchToSlowSpeed(BasePlayer player) { }

	// RVA: 0x7CDA10 Offset: 0x7CC010 VA: 0x1807CDA10
	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Description] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Icon] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	// RVA: 0x7CD9C0 Offset: 0x7CBFC0 VA: 0x1807CD9C0
	public void SwitchToMediumSpeed(BasePlayer player) { }

	// RVA: 0x7CD900 Offset: 0x7CBF00 VA: 0x1807CD900
	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Description] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Icon] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	// RVA: 0x7CD8B0 Offset: 0x7CBEB0 VA: 0x1807CD8B0
	public void SwitchToFastSpeed(BasePlayer player) { }

	// RVA: 0x7CD7F0 Offset: 0x7CBDF0 VA: 0x1807CD7F0
	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CD7B0 Offset: 0x7CBDB0 VA: 0x1807CD7B0
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7CCCE0 Offset: 0x7CB2E0 VA: 0x1807CCCE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7CC3E0 Offset: 0x7CA9E0 VA: 0x1807CC3E0
	private void EnsureInitialized() { }

	// RVA: 0x7CC2F0 Offset: 0x7CA8F0 VA: 0x1807CC2F0
	private static Color ClampColor(Color color) { }

	// RVA: 0x7CE4C0 Offset: 0x7CCAC0 VA: 0x1807CE4C0
	public void .ctor() { }

}


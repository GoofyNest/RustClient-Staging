public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24

	// Methods

	// RVA: 0x1F8C9A0 Offset: 0x1F8AFA0 VA: 0x181F8C9A0
	public static void ResetToPool(NeonSign instance) { }

	// RVA: 0x1F8CB90 Offset: 0x1F8B190 VA: 0x181F8CB90
	public void ResetToPool() { }

	// RVA: 0x1F8C8E0 Offset: 0x1F8AEE0 VA: 0x181F8C8E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8B8D0 Offset: 0x1F89ED0 VA: 0x181F8B8D0
	public void CopyTo(NeonSign instance) { }

	// RVA: 0x1F8BA80 Offset: 0x1F8A080 VA: 0x181F8BA80
	public NeonSign Copy() { }

	// RVA: 0x1F8C760 Offset: 0x1F8AD60 VA: 0x181F8C760
	public static NeonSign Deserialize(Stream stream) { }

	// RVA: 0x1F8BC80 Offset: 0x1F8A280 VA: 0x181F8BC80
	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8C040 Offset: 0x1F8A640 VA: 0x181F8C040
	public static NeonSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8C3E0 Offset: 0x1F8A9E0 VA: 0x181F8C3E0
	public static NeonSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F8C960 Offset: 0x1F8AF60 VA: 0x181F8C960
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8D460 Offset: 0x1F8BA60 VA: 0x181F8D460 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8D480 Offset: 0x1F8BA80 VA: 0x181F8D480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	// RVA: 0x1F8C980 Offset: 0x1F8AF80 VA: 0x181F8C980 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8C7E0 Offset: 0x1F8ADE0 VA: 0x181F8C7E0
	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	// RVA: 0x1F8C500 Offset: 0x1F8AB00 VA: 0x181F8C500
	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8BD00 Offset: 0x1F8A300 VA: 0x181F8BD00
	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8C0D0 Offset: 0x1F8A6D0 VA: 0x181F8C0D0
	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8CD80 Offset: 0x1F8B380 VA: 0x181F8CD80
	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	// RVA: 0x1F8D200 Offset: 0x1F8B800 VA: 0x181F8D200
	public static void Serialize(Stream stream, NeonSign instance) { }

	// RVA: 0x1F8D450 Offset: 0x1F8BA50 VA: 0x181F8D450
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8D460 Offset: 0x1F8BA60 VA: 0x181F8D460
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8D0F0 Offset: 0x1F8B6F0 VA: 0x181F8D0F0
	public static byte[] SerializeToBytes(NeonSign instance) { }

	// RVA: 0x1F8D040 Offset: 0x1F8B640 VA: 0x181F8D040
	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F83B30 Offset: 0x1F82130 VA: 0x181F83B30
	public static void ResetToPool(NeonSign.Lights instance) { }

	// RVA: 0x1F83BD0 Offset: 0x1F821D0 VA: 0x181F83BD0
	public void ResetToPool() { }

	// RVA: 0x1F838B0 Offset: 0x1F81EB0 VA: 0x181F838B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F827F0 Offset: 0x1F80DF0 VA: 0x181F827F0
	public void CopyTo(NeonSign.Lights instance) { }

	// RVA: 0x1F82830 Offset: 0x1F80E30 VA: 0x181F82830
	public NeonSign.Lights Copy() { }

	// RVA: 0x1F834A0 Offset: 0x1F81AA0 VA: 0x181F834A0
	public static NeonSign.Lights Deserialize(Stream stream) { }

	// RVA: 0x1F82B70 Offset: 0x1F81170 VA: 0x181F82B70
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F82BF0 Offset: 0x1F811F0 VA: 0x181F82BF0
	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F82F20 Offset: 0x1F81520 VA: 0x181F82F20
	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	// RVA: 0x1F83930 Offset: 0x1F81F30 VA: 0x181F83930
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F846F0 Offset: 0x1F82CF0 VA: 0x181F846F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F84710 Offset: 0x1F82D10 VA: 0x181F84710 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	// RVA: 0x1F83B10 Offset: 0x1F82110 VA: 0x181F83B10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F831F0 Offset: 0x1F817F0 VA: 0x181F831F0
	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	// RVA: 0x1F836C0 Offset: 0x1F81CC0 VA: 0x181F836C0
	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F828B0 Offset: 0x1F80EB0 VA: 0x181F828B0
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F82C80 Offset: 0x1F81280 VA: 0x181F82C80
	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F83C70 Offset: 0x1F82270 VA: 0x181F83C70
	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	// RVA: 0x1F84340 Offset: 0x1F82940 VA: 0x181F84340
	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1F846E0 Offset: 0x1F82CE0 VA: 0x181F846E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F846F0 Offset: 0x1F82CF0 VA: 0x181F846F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F84230 Offset: 0x1F82830 VA: 0x181F84230
	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	// RVA: 0x1F84180 Offset: 0x1F82780 VA: 0x181F84180
	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x7CC430 Offset: 0x7CAA30 VA: 0x1807CC430 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7CE420 Offset: 0x7CCA20 VA: 0x1807CE420 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7CCEC0 Offset: 0x7CB4C0 VA: 0x1807CCEC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7CC2C0 Offset: 0x7CA8C0 VA: 0x1807CC2C0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7CCEA0 Offset: 0x7CB4A0 VA: 0x1807CCEA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7CDD70 Offset: 0x7CC370 VA: 0x1807CDD70
	public void UpdateNeonDisplay() { }

	// RVA: 0x7CDA10 Offset: 0x7CC010 VA: 0x1807CDA10
	private void UpdateLights() { }

	// RVA: 0x7CE280 Offset: 0x7CC880 VA: 0x1807CE280
	private void UpdateSounds() { }

	// RVA: 0x7CCE90 Offset: 0x7CB490 VA: 0x1807CCE90 Slot: 171
	protected override void OnEnterTextureRange() { }

	// RVA: 0x7CD310 Offset: 0x7CB910 VA: 0x1807CD310 Slot: 169
	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Description] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Icon] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	// RVA: 0x7CD9C0 Offset: 0x7CBFC0 VA: 0x1807CD9C0
	public void SwitchToSlowSpeed(BasePlayer player) { }

	// RVA: 0x7CD900 Offset: 0x7CBF00 VA: 0x1807CD900
	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Description] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Icon] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	// RVA: 0x7CD8B0 Offset: 0x7CBEB0 VA: 0x1807CD8B0
	public void SwitchToMediumSpeed(BasePlayer player) { }

	// RVA: 0x7CD7F0 Offset: 0x7CBDF0 VA: 0x1807CD7F0
	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Description] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Icon] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	// RVA: 0x7CD7A0 Offset: 0x7CBDA0 VA: 0x1807CD7A0
	public void SwitchToFastSpeed(BasePlayer player) { }

	// RVA: 0x7CD6E0 Offset: 0x7CBCE0 VA: 0x1807CD6E0
	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CD6A0 Offset: 0x7CBCA0 VA: 0x1807CD6A0
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7CCBD0 Offset: 0x7CB1D0 VA: 0x1807CCBD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7CC2D0 Offset: 0x7CA8D0 VA: 0x1807CC2D0
	private void EnsureInitialized() { }

	// RVA: 0x7CC1E0 Offset: 0x7CA7E0 VA: 0x1807CC1E0
	private static Color ClampColor(Color color) { }

	// RVA: 0x7CE3B0 Offset: 0x7CC9B0 VA: 0x1807CE3B0
	public void .ctor() { }

}


public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24

	// Methods

	// RVA: 0x1F8CB60 Offset: 0x1F8B160 VA: 0x181F8CB60
	public static void ResetToPool(NeonSign instance) { }

	// RVA: 0x1F8CD50 Offset: 0x1F8B350 VA: 0x181F8CD50
	public void ResetToPool() { }

	// RVA: 0x1F8CAA0 Offset: 0x1F8B0A0 VA: 0x181F8CAA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8BA90 Offset: 0x1F8A090 VA: 0x181F8BA90
	public void CopyTo(NeonSign instance) { }

	// RVA: 0x1F8BC40 Offset: 0x1F8A240 VA: 0x181F8BC40
	public NeonSign Copy() { }

	// RVA: 0x1F8C920 Offset: 0x1F8AF20 VA: 0x181F8C920
	public static NeonSign Deserialize(Stream stream) { }

	// RVA: 0x1F8BE40 Offset: 0x1F8A440 VA: 0x181F8BE40
	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8C200 Offset: 0x1F8A800 VA: 0x181F8C200
	public static NeonSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8C5A0 Offset: 0x1F8ABA0 VA: 0x181F8C5A0
	public static NeonSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F8CB20 Offset: 0x1F8B120 VA: 0x181F8CB20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8D620 Offset: 0x1F8BC20 VA: 0x181F8D620 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8D640 Offset: 0x1F8BC40 VA: 0x181F8D640 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	// RVA: 0x1F8CB40 Offset: 0x1F8B140 VA: 0x181F8CB40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8C9A0 Offset: 0x1F8AFA0 VA: 0x181F8C9A0
	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	// RVA: 0x1F8C6C0 Offset: 0x1F8ACC0 VA: 0x181F8C6C0
	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8BEC0 Offset: 0x1F8A4C0 VA: 0x181F8BEC0
	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8C290 Offset: 0x1F8A890 VA: 0x181F8C290
	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8CF40 Offset: 0x1F8B540 VA: 0x181F8CF40
	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	// RVA: 0x1F8D3C0 Offset: 0x1F8B9C0 VA: 0x181F8D3C0
	public static void Serialize(Stream stream, NeonSign instance) { }

	// RVA: 0x1F8D610 Offset: 0x1F8BC10 VA: 0x181F8D610
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8D620 Offset: 0x1F8BC20 VA: 0x181F8D620
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8D2B0 Offset: 0x1F8B8B0 VA: 0x181F8D2B0
	public static byte[] SerializeToBytes(NeonSign instance) { }

	// RVA: 0x1F8D200 Offset: 0x1F8B800 VA: 0x181F8D200
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

	// RVA: 0x1F83CF0 Offset: 0x1F822F0 VA: 0x181F83CF0
	public static void ResetToPool(NeonSign.Lights instance) { }

	// RVA: 0x1F83D90 Offset: 0x1F82390 VA: 0x181F83D90
	public void ResetToPool() { }

	// RVA: 0x1F83A70 Offset: 0x1F82070 VA: 0x181F83A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F829B0 Offset: 0x1F80FB0 VA: 0x181F829B0
	public void CopyTo(NeonSign.Lights instance) { }

	// RVA: 0x1F829F0 Offset: 0x1F80FF0 VA: 0x181F829F0
	public NeonSign.Lights Copy() { }

	// RVA: 0x1F83660 Offset: 0x1F81C60 VA: 0x181F83660
	public static NeonSign.Lights Deserialize(Stream stream) { }

	// RVA: 0x1F82D30 Offset: 0x1F81330 VA: 0x181F82D30
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F82DB0 Offset: 0x1F813B0 VA: 0x181F82DB0
	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F830E0 Offset: 0x1F816E0 VA: 0x181F830E0
	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	// RVA: 0x1F83AF0 Offset: 0x1F820F0 VA: 0x181F83AF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F848B0 Offset: 0x1F82EB0 VA: 0x181F848B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F848D0 Offset: 0x1F82ED0 VA: 0x181F848D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	// RVA: 0x1F83CD0 Offset: 0x1F822D0 VA: 0x181F83CD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F833B0 Offset: 0x1F819B0 VA: 0x181F833B0
	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	// RVA: 0x1F83880 Offset: 0x1F81E80 VA: 0x181F83880
	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F82A70 Offset: 0x1F81070 VA: 0x181F82A70
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F82E40 Offset: 0x1F81440 VA: 0x181F82E40
	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F83E30 Offset: 0x1F82430 VA: 0x181F83E30
	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	// RVA: 0x1F84500 Offset: 0x1F82B00 VA: 0x181F84500
	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1F848A0 Offset: 0x1F82EA0 VA: 0x181F848A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F848B0 Offset: 0x1F82EB0 VA: 0x181F848B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F843F0 Offset: 0x1F829F0 VA: 0x181F843F0
	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	// RVA: 0x1F84340 Offset: 0x1F82940 VA: 0x181F84340
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
	[HeaderAttribute] // RVA: 0x7AE00 Offset: 0x7A200 VA: 0x18007AE00
	public Light topLeft; // 0x4D8
	public Light topRight; // 0x4E0
	public Light bottomLeft; // 0x4E8
	public Light bottomRight; // 0x4F0
	public float lightIntensity; // 0x4F8
	[RangeAttribute] // RVA: 0x7AE30 Offset: 0x7A230 VA: 0x18007AE30
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

	[BaseEntity.Menu] // RVA: 0x7B160 Offset: 0x7A560 VA: 0x18007B160
	[BaseEntity.Menu.Description] // RVA: 0x7B160 Offset: 0x7A560 VA: 0x18007B160
	[BaseEntity.Menu.Icon] // RVA: 0x7B160 Offset: 0x7A560 VA: 0x18007B160
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B160 Offset: 0x7A560 VA: 0x18007B160
	// RVA: 0x7CD9C0 Offset: 0x7CBFC0 VA: 0x1807CD9C0
	public void SwitchToSlowSpeed(BasePlayer player) { }

	// RVA: 0x7CD900 Offset: 0x7CBF00 VA: 0x1807CD900
	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B500 Offset: 0x7A900 VA: 0x18007B500
	[BaseEntity.Menu.Description] // RVA: 0x7B500 Offset: 0x7A900 VA: 0x18007B500
	[BaseEntity.Menu.Icon] // RVA: 0x7B500 Offset: 0x7A900 VA: 0x18007B500
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B500 Offset: 0x7A900 VA: 0x18007B500
	// RVA: 0x7CD8B0 Offset: 0x7CBEB0 VA: 0x1807CD8B0
	public void SwitchToMediumSpeed(BasePlayer player) { }

	// RVA: 0x7CD7F0 Offset: 0x7CBDF0 VA: 0x1807CD7F0
	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B880 Offset: 0x7AC80 VA: 0x18007B880
	[BaseEntity.Menu.Description] // RVA: 0x7B880 Offset: 0x7AC80 VA: 0x18007B880
	[BaseEntity.Menu.Icon] // RVA: 0x7B880 Offset: 0x7AC80 VA: 0x18007B880
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B880 Offset: 0x7AC80 VA: 0x18007B880
	// RVA: 0x7CD7A0 Offset: 0x7CBDA0 VA: 0x1807CD7A0
	public void SwitchToFastSpeed(BasePlayer player) { }

	// RVA: 0x7CD6E0 Offset: 0x7CBCE0 VA: 0x1807CD6E0
	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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


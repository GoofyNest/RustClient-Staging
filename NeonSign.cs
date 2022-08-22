public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24

	// Methods

	// RVA: 0x1F8D480 Offset: 0x1F8BA80 VA: 0x181F8D480
	public static void ResetToPool(NeonSign instance) { }

	// RVA: 0x1F8D670 Offset: 0x1F8BC70 VA: 0x181F8D670
	public void ResetToPool() { }

	// RVA: 0x1F8D3C0 Offset: 0x1F8B9C0 VA: 0x181F8D3C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F8C3B0 Offset: 0x1F8A9B0 VA: 0x181F8C3B0
	public void CopyTo(NeonSign instance) { }

	// RVA: 0x1F8C560 Offset: 0x1F8AB60 VA: 0x181F8C560
	public NeonSign Copy() { }

	// RVA: 0x1F8D240 Offset: 0x1F8B840 VA: 0x181F8D240
	public static NeonSign Deserialize(Stream stream) { }

	// RVA: 0x1F8C760 Offset: 0x1F8AD60 VA: 0x181F8C760
	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8CB20 Offset: 0x1F8B120 VA: 0x181F8CB20
	public static NeonSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8CEC0 Offset: 0x1F8B4C0 VA: 0x181F8CEC0
	public static NeonSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F8D440 Offset: 0x1F8BA40 VA: 0x181F8D440
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8DF40 Offset: 0x1F8C540 VA: 0x181F8DF40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8DF60 Offset: 0x1F8C560 VA: 0x181F8DF60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	// RVA: 0x1F8D460 Offset: 0x1F8BA60 VA: 0x181F8D460 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8D2C0 Offset: 0x1F8B8C0 VA: 0x181F8D2C0
	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	// RVA: 0x1F8CFE0 Offset: 0x1F8B5E0 VA: 0x181F8CFE0
	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8C7E0 Offset: 0x1F8ADE0 VA: 0x181F8C7E0
	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8CBB0 Offset: 0x1F8B1B0 VA: 0x181F8CBB0
	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F8D860 Offset: 0x1F8BE60 VA: 0x181F8D860
	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	// RVA: 0x1F8DCE0 Offset: 0x1F8C2E0 VA: 0x181F8DCE0
	public static void Serialize(Stream stream, NeonSign instance) { }

	// RVA: 0x1F8DF30 Offset: 0x1F8C530 VA: 0x181F8DF30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8DF40 Offset: 0x1F8C540 VA: 0x181F8DF40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8DBD0 Offset: 0x1F8C1D0 VA: 0x181F8DBD0
	public static byte[] SerializeToBytes(NeonSign instance) { }

	// RVA: 0x1F8DB20 Offset: 0x1F8C120 VA: 0x181F8DB20
	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F84610 Offset: 0x1F82C10 VA: 0x181F84610
	public static void ResetToPool(NeonSign.Lights instance) { }

	// RVA: 0x1F846B0 Offset: 0x1F82CB0 VA: 0x181F846B0
	public void ResetToPool() { }

	// RVA: 0x1F84390 Offset: 0x1F82990 VA: 0x181F84390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F832D0 Offset: 0x1F818D0 VA: 0x181F832D0
	public void CopyTo(NeonSign.Lights instance) { }

	// RVA: 0x1F83310 Offset: 0x1F81910 VA: 0x181F83310
	public NeonSign.Lights Copy() { }

	// RVA: 0x1F83F80 Offset: 0x1F82580 VA: 0x181F83F80
	public static NeonSign.Lights Deserialize(Stream stream) { }

	// RVA: 0x1F83650 Offset: 0x1F81C50 VA: 0x181F83650
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F836D0 Offset: 0x1F81CD0 VA: 0x181F836D0
	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F83A00 Offset: 0x1F82000 VA: 0x181F83A00
	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	// RVA: 0x1F84410 Offset: 0x1F82A10 VA: 0x181F84410
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F851D0 Offset: 0x1F837D0 VA: 0x181F851D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F851F0 Offset: 0x1F837F0 VA: 0x181F851F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	// RVA: 0x1F845F0 Offset: 0x1F82BF0 VA: 0x181F845F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F83CD0 Offset: 0x1F822D0 VA: 0x181F83CD0
	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	// RVA: 0x1F841A0 Offset: 0x1F827A0 VA: 0x181F841A0
	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F83390 Offset: 0x1F81990 VA: 0x181F83390
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F83760 Offset: 0x1F81D60 VA: 0x181F83760
	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F84750 Offset: 0x1F82D50 VA: 0x181F84750
	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	// RVA: 0x1F84E20 Offset: 0x1F83420 VA: 0x181F84E20
	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1F851C0 Offset: 0x1F837C0 VA: 0x181F851C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F851D0 Offset: 0x1F837D0 VA: 0x181F851D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F84D10 Offset: 0x1F83310 VA: 0x181F84D10
	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	// RVA: 0x1F84C60 Offset: 0x1F83260 VA: 0x181F84C60
	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x7EA930 Offset: 0x7E8F30 VA: 0x1807EA930 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7EC920 Offset: 0x7EAF20 VA: 0x1807EC920 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7EB3C0 Offset: 0x7E99C0 VA: 0x1807EB3C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7EA7C0 Offset: 0x7E8DC0 VA: 0x1807EA7C0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7EB3A0 Offset: 0x7E99A0 VA: 0x1807EB3A0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7EC270 Offset: 0x7EA870 VA: 0x1807EC270
	public void UpdateNeonDisplay() { }

	// RVA: 0x7EBF10 Offset: 0x7EA510 VA: 0x1807EBF10
	private void UpdateLights() { }

	// RVA: 0x7EC780 Offset: 0x7EAD80 VA: 0x1807EC780
	private void UpdateSounds() { }

	// RVA: 0x7EB390 Offset: 0x7E9990 VA: 0x1807EB390 Slot: 171
	protected override void OnEnterTextureRange() { }

	// RVA: 0x7EB810 Offset: 0x7E9E10 VA: 0x1807EB810 Slot: 169
	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Description] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.Icon] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B260 Offset: 0x7A660 VA: 0x18007B260
	// RVA: 0x7EBEC0 Offset: 0x7EA4C0 VA: 0x1807EBEC0
	public void SwitchToSlowSpeed(BasePlayer player) { }

	// RVA: 0x7EBE00 Offset: 0x7EA400 VA: 0x1807EBE00
	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Description] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.Icon] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B610 Offset: 0x7AA10 VA: 0x18007B610
	// RVA: 0x7EBDB0 Offset: 0x7EA3B0 VA: 0x1807EBDB0
	public void SwitchToMediumSpeed(BasePlayer player) { }

	// RVA: 0x7EBCF0 Offset: 0x7EA2F0 VA: 0x1807EBCF0
	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Description] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.Icon] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B950 Offset: 0x7AD50 VA: 0x18007B950
	// RVA: 0x7EBCA0 Offset: 0x7EA2A0 VA: 0x1807EBCA0
	public void SwitchToFastSpeed(BasePlayer player) { }

	// RVA: 0x7EBBE0 Offset: 0x7EA1E0 VA: 0x1807EBBE0
	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EBBA0 Offset: 0x7EA1A0 VA: 0x1807EBBA0
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7EB0D0 Offset: 0x7E96D0 VA: 0x1807EB0D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7EA7D0 Offset: 0x7E8DD0 VA: 0x1807EA7D0
	private void EnsureInitialized() { }

	// RVA: 0x7EA6E0 Offset: 0x7E8CE0 VA: 0x1807EA6E0
	private static Color ClampColor(Color color) { }

	// RVA: 0x7EC8B0 Offset: 0x7EAEB0 VA: 0x1807EC8B0
	public void .ctor() { }

}


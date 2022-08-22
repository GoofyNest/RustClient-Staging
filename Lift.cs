public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1F1F2A0 Offset: 0x1F1D8A0 VA: 0x181F1F2A0
	public static void ResetToPool(Lift instance) { }

	// RVA: 0x1F1F220 Offset: 0x1F1D820 VA: 0x181F1F220
	public void ResetToPool() { }

	// RVA: 0x1F1F0F0 Offset: 0x1F1D6F0 VA: 0x181F1F0F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(Lift instance) { }

	// RVA: 0x1F1E770 Offset: 0x1F1CD70 VA: 0x181F1E770
	public Lift Copy() { }

	// RVA: 0x1F1EF30 Offset: 0x1F1D530 VA: 0x181F1EF30
	public static Lift Deserialize(Stream stream) { }

	// RVA: 0x1F1EA00 Offset: 0x1F1D000 VA: 0x181F1EA00
	public static Lift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1EC80 Offset: 0x1F1D280 VA: 0x181F1EC80
	public static Lift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1ED10 Offset: 0x1F1D310 VA: 0x181F1ED10
	public static Lift Deserialize(byte[] buffer) { }

	// RVA: 0x1F1F1E0 Offset: 0x1F1D7E0 VA: 0x181F1F1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1F770 Offset: 0x1F1DD70 VA: 0x181F1F770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1F840 Offset: 0x1F1DE40 VA: 0x181F1F840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	// RVA: 0x1F1F200 Offset: 0x1F1D800 VA: 0x181F1F200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1EE30 Offset: 0x1F1D430 VA: 0x181F1EE30
	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	// RVA: 0x1F1EFB0 Offset: 0x1F1D5B0 VA: 0x181F1EFB0
	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1E7E0 Offset: 0x1F1CDE0 VA: 0x181F1E7E0
	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1EA80 Offset: 0x1F1D080 VA: 0x181F1EA80
	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	// RVA: 0x1F1F320 Offset: 0x1F1D920 VA: 0x181F1F320
	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	// RVA: 0x1F1F690 Offset: 0x1F1DC90 VA: 0x181F1F690
	public static void Serialize(Stream stream, Lift instance) { }

	// RVA: 0x1F1F760 Offset: 0x1F1DD60 VA: 0x181F1F760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1F770 Offset: 0x1F1DD70 VA: 0x181F1F770
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1F4E0 Offset: 0x1F1DAE0 VA: 0x181F1F4E0
	public static byte[] SerializeToBytes(Lift instance) { }

	// RVA: 0x1F1F430 Offset: 0x1F1DA30 VA: 0x181F1F430
	public static void SerializeLengthDelimited(Stream stream, Lift instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Lift : AnimatedBuildingBlock // TypeDefIndex: 8403
{	// Fields
	private Option __menuOption_Menu_UseLift; // 0x270
	public GameObjectRef triggerPrefab; // 0x2C8
	public string triggerBone; // 0x2D0
	public float resetDelay; // 0x2D8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x68E980 Offset: 0x68CF80 VA: 0x18068E980 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x68EDC0 Offset: 0x68D3C0 VA: 0x18068EDC0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x68ECB0 Offset: 0x68D2B0 VA: 0x18068ECB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x68EC70 Offset: 0x68D270 VA: 0x18068EC70
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x49BBD0 Offset: 0x49A1D0 VA: 0x18049BBD0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x68EDA0 Offset: 0x68D3A0 VA: 0x18068EDA0
	public void .ctor() { }

}


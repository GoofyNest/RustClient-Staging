public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1F1E980 Offset: 0x1F1CF80 VA: 0x181F1E980
	public static void ResetToPool(Lift instance) { }

	// RVA: 0x1F1E900 Offset: 0x1F1CF00 VA: 0x181F1E900
	public void ResetToPool() { }

	// RVA: 0x1F1E7D0 Offset: 0x1F1CDD0 VA: 0x181F1E7D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(Lift instance) { }

	// RVA: 0x1F1DE50 Offset: 0x1F1C450 VA: 0x181F1DE50
	public Lift Copy() { }

	// RVA: 0x1F1E610 Offset: 0x1F1CC10 VA: 0x181F1E610
	public static Lift Deserialize(Stream stream) { }

	// RVA: 0x1F1E0E0 Offset: 0x1F1C6E0 VA: 0x181F1E0E0
	public static Lift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1E360 Offset: 0x1F1C960 VA: 0x181F1E360
	public static Lift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1E3F0 Offset: 0x1F1C9F0 VA: 0x181F1E3F0
	public static Lift Deserialize(byte[] buffer) { }

	// RVA: 0x1F1E8C0 Offset: 0x1F1CEC0 VA: 0x181F1E8C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1EE50 Offset: 0x1F1D450 VA: 0x181F1EE50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1EF20 Offset: 0x1F1D520 VA: 0x181F1EF20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	// RVA: 0x1F1E8E0 Offset: 0x1F1CEE0 VA: 0x181F1E8E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1E510 Offset: 0x1F1CB10 VA: 0x181F1E510
	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	// RVA: 0x1F1E690 Offset: 0x1F1CC90 VA: 0x181F1E690
	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1DEC0 Offset: 0x1F1C4C0 VA: 0x181F1DEC0
	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1E160 Offset: 0x1F1C760 VA: 0x181F1E160
	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	// RVA: 0x1F1EA00 Offset: 0x1F1D000 VA: 0x181F1EA00
	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	// RVA: 0x1F1ED70 Offset: 0x1F1D370 VA: 0x181F1ED70
	public static void Serialize(Stream stream, Lift instance) { }

	// RVA: 0x1F1EE40 Offset: 0x1F1D440 VA: 0x181F1EE40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1EE50 Offset: 0x1F1D450 VA: 0x181F1EE50
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1EBC0 Offset: 0x1F1D1C0 VA: 0x181F1EBC0
	public static byte[] SerializeToBytes(Lift instance) { }

	// RVA: 0x1F1EB10 Offset: 0x1F1D110 VA: 0x181F1EB10
	public static void SerializeLengthDelimited(Stream stream, Lift instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x68E8E0 Offset: 0x68CEE0 VA: 0x18068E8E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x68ED20 Offset: 0x68D320 VA: 0x18068ED20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x68EC10 Offset: 0x68D210 VA: 0x18068EC10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7DB50 Offset: 0x7CF50 VA: 0x18007DB50
	[BaseEntity.Menu.Description] // RVA: 0x7DB50 Offset: 0x7CF50 VA: 0x18007DB50
	[BaseEntity.Menu.Icon] // RVA: 0x7DB50 Offset: 0x7CF50 VA: 0x18007DB50
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DB50 Offset: 0x7CF50 VA: 0x18007DB50
	// RVA: 0x68EBD0 Offset: 0x68D1D0 VA: 0x18068EBD0
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x49BBD0 Offset: 0x49A1D0 VA: 0x18049BBD0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x68ED00 Offset: 0x68D300 VA: 0x18068ED00
	public void .ctor() { }

}


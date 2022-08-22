public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1F1EA80 Offset: 0x1F1D080 VA: 0x181F1EA80
	public static void ResetToPool(Lift instance) { }

	// RVA: 0x1F1EA00 Offset: 0x1F1D000 VA: 0x181F1EA00
	public void ResetToPool() { }

	// RVA: 0x1F1E8D0 Offset: 0x1F1CED0 VA: 0x181F1E8D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(Lift instance) { }

	// RVA: 0x1F1DF50 Offset: 0x1F1C550 VA: 0x181F1DF50
	public Lift Copy() { }

	// RVA: 0x1F1E710 Offset: 0x1F1CD10 VA: 0x181F1E710
	public static Lift Deserialize(Stream stream) { }

	// RVA: 0x1F1E1E0 Offset: 0x1F1C7E0 VA: 0x181F1E1E0
	public static Lift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1E460 Offset: 0x1F1CA60 VA: 0x181F1E460
	public static Lift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1E4F0 Offset: 0x1F1CAF0 VA: 0x181F1E4F0
	public static Lift Deserialize(byte[] buffer) { }

	// RVA: 0x1F1E9C0 Offset: 0x1F1CFC0 VA: 0x181F1E9C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1EF50 Offset: 0x1F1D550 VA: 0x181F1EF50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1F020 Offset: 0x1F1D620 VA: 0x181F1F020 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	// RVA: 0x1F1E9E0 Offset: 0x1F1CFE0 VA: 0x181F1E9E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1E610 Offset: 0x1F1CC10 VA: 0x181F1E610
	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	// RVA: 0x1F1E790 Offset: 0x1F1CD90 VA: 0x181F1E790
	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1DFC0 Offset: 0x1F1C5C0 VA: 0x181F1DFC0
	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1E260 Offset: 0x1F1C860 VA: 0x181F1E260
	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	// RVA: 0x1F1EB00 Offset: 0x1F1D100 VA: 0x181F1EB00
	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	// RVA: 0x1F1EE70 Offset: 0x1F1D470 VA: 0x181F1EE70
	public static void Serialize(Stream stream, Lift instance) { }

	// RVA: 0x1F1EF40 Offset: 0x1F1D540 VA: 0x181F1EF40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1EF50 Offset: 0x1F1D550 VA: 0x181F1EF50
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1ECC0 Offset: 0x1F1D2C0 VA: 0x181F1ECC0
	public static byte[] SerializeToBytes(Lift instance) { }

	// RVA: 0x1F1EC10 Offset: 0x1F1D210 VA: 0x181F1EC10
	public static void SerializeLengthDelimited(Stream stream, Lift instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x68E9F0 Offset: 0x68CFF0 VA: 0x18068E9F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x68EE30 Offset: 0x68D430 VA: 0x18068EE30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x68ED20 Offset: 0x68D320 VA: 0x18068ED20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x68ECE0 Offset: 0x68D2E0 VA: 0x18068ECE0
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x49BBD0 Offset: 0x49A1D0 VA: 0x18049BBD0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x68EE10 Offset: 0x68D410 VA: 0x18068EE10
	public void .ctor() { }

}


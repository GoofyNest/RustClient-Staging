public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1F1E7C0 Offset: 0x1F1CDC0 VA: 0x181F1E7C0
	public static void ResetToPool(Lift instance) { }

	// RVA: 0x1F1E740 Offset: 0x1F1CD40 VA: 0x181F1E740
	public void ResetToPool() { }

	// RVA: 0x1F1E610 Offset: 0x1F1CC10 VA: 0x181F1E610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(Lift instance) { }

	// RVA: 0x1F1DC90 Offset: 0x1F1C290 VA: 0x181F1DC90
	public Lift Copy() { }

	// RVA: 0x1F1E450 Offset: 0x1F1CA50 VA: 0x181F1E450
	public static Lift Deserialize(Stream stream) { }

	// RVA: 0x1F1DF20 Offset: 0x1F1C520 VA: 0x181F1DF20
	public static Lift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1E1A0 Offset: 0x1F1C7A0 VA: 0x181F1E1A0
	public static Lift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1E230 Offset: 0x1F1C830 VA: 0x181F1E230
	public static Lift Deserialize(byte[] buffer) { }

	// RVA: 0x1F1E700 Offset: 0x1F1CD00 VA: 0x181F1E700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1EC90 Offset: 0x1F1D290 VA: 0x181F1EC90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1ED60 Offset: 0x1F1D360 VA: 0x181F1ED60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	// RVA: 0x1F1E720 Offset: 0x1F1CD20 VA: 0x181F1E720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1E350 Offset: 0x1F1C950 VA: 0x181F1E350
	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	// RVA: 0x1F1E4D0 Offset: 0x1F1CAD0 VA: 0x181F1E4D0
	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1DD00 Offset: 0x1F1C300 VA: 0x181F1DD00
	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F1DFA0 Offset: 0x1F1C5A0 VA: 0x181F1DFA0
	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	// RVA: 0x1F1E840 Offset: 0x1F1CE40 VA: 0x181F1E840
	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	// RVA: 0x1F1EBB0 Offset: 0x1F1D1B0 VA: 0x181F1EBB0
	public static void Serialize(Stream stream, Lift instance) { }

	// RVA: 0x1F1EC80 Offset: 0x1F1D280 VA: 0x181F1EC80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1EC90 Offset: 0x1F1D290 VA: 0x181F1EC90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1EA00 Offset: 0x1F1D000 VA: 0x181F1EA00
	public static byte[] SerializeToBytes(Lift instance) { }

	// RVA: 0x1F1E950 Offset: 0x1F1CF50 VA: 0x181F1E950
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

	[BaseEntity.Menu] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Description] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.Icon] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DC20 Offset: 0x7D020 VA: 0x18007DC20
	// RVA: 0x68EBD0 Offset: 0x68D1D0 VA: 0x18068EBD0
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x49BBD0 Offset: 0x49A1D0 VA: 0x18049BBD0
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x68ED00 Offset: 0x68D300 VA: 0x18068ED00
	public void .ctor() { }

}


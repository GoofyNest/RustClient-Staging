public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seatID; // 0x14

	// Methods

	// RVA: 0x1DACF20 Offset: 0x1DAB520 VA: 0x181DACF20
	public static void ResetToPool(SleepingBagCamper instance) { }

	// RVA: 0x1DACFA0 Offset: 0x1DAB5A0 VA: 0x181DACFA0
	public void ResetToPool() { }

	// RVA: 0x1DACDF0 Offset: 0x1DAB3F0 VA: 0x181DACDF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(SleepingBagCamper instance) { }

	// RVA: 0x1DAC470 Offset: 0x1DAAA70 VA: 0x181DAC470
	public SleepingBagCamper Copy() { }

	// RVA: 0x1DACD70 Offset: 0x1DAB370 VA: 0x181DACD70
	public static SleepingBagCamper Deserialize(Stream stream) { }

	// RVA: 0x1DAC700 Offset: 0x1DAAD00 VA: 0x181DAC700
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAC780 Offset: 0x1DAAD80 VA: 0x181DAC780
	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DACC50 Offset: 0x1DAB250 VA: 0x181DACC50
	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	// RVA: 0x1DACEE0 Offset: 0x1DAB4E0 VA: 0x181DACEE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAD470 Offset: 0x1DABA70 VA: 0x181DAD470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAD540 Offset: 0x1DABB40 VA: 0x181DAD540 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	// RVA: 0x1DACF00 Offset: 0x1DAB500 VA: 0x181DACF00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DACB50 Offset: 0x1DAB150 VA: 0x181DACB50
	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	// RVA: 0x1DACA10 Offset: 0x1DAB010 VA: 0x181DACA10
	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC4E0 Offset: 0x1DAAAE0 VA: 0x181DAC4E0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC810 Offset: 0x1DAAE10 VA: 0x181DAC810
	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAD020 Offset: 0x1DAB620 VA: 0x181DAD020
	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	// RVA: 0x1DAD390 Offset: 0x1DAB990 VA: 0x181DAD390
	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1DAD460 Offset: 0x1DABA60 VA: 0x181DAD460
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAD470 Offset: 0x1DABA70 VA: 0x181DAD470
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAD1E0 Offset: 0x1DAB7E0 VA: 0x181DAD1E0
	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	// RVA: 0x1DAD130 Offset: 0x1DAB730 VA: 0x181DAD130
	public static void SerializeLengthDelimited(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class SleepingBagCamper : SleepingBag // TypeDefIndex: 8639
{	// Fields
	public EntityRef<BaseVehicleSeat> AssociatedSeat; // 0x450

	// Methods

	// RVA: 0x5A7C20 Offset: 0x5A6220 VA: 0x1805A7C20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5A7A70 Offset: 0x5A6070 VA: 0x1805A7A70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A7BB0 Offset: 0x5A61B0 VA: 0x1805A7BB0 Slot: 148
	public override bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A7B70 Offset: 0x5A6170 VA: 0x1805A7B70
	public void Menu_ClearBed(BasePlayer player) { }

	// RVA: 0x5A7B60 Offset: 0x5A6160 VA: 0x1805A7B60
	public bool Menu_ClearBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A7A40 Offset: 0x5A6040 VA: 0x1805A7A40 Slot: 145
	public override bool CanRename_Test(BasePlayer player) { }

	// RVA: 0x5A7D10 Offset: 0x5A6310 VA: 0x1805A7D10
	public void .ctor() { }

}


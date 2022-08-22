public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seatID; // 0x14

	// Methods

	// RVA: 0x1DACC60 Offset: 0x1DAB260 VA: 0x181DACC60
	public static void ResetToPool(SleepingBagCamper instance) { }

	// RVA: 0x1DACCE0 Offset: 0x1DAB2E0 VA: 0x181DACCE0
	public void ResetToPool() { }

	// RVA: 0x1DACB30 Offset: 0x1DAB130 VA: 0x181DACB30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(SleepingBagCamper instance) { }

	// RVA: 0x1DAC1B0 Offset: 0x1DAA7B0 VA: 0x181DAC1B0
	public SleepingBagCamper Copy() { }

	// RVA: 0x1DACAB0 Offset: 0x1DAB0B0 VA: 0x181DACAB0
	public static SleepingBagCamper Deserialize(Stream stream) { }

	// RVA: 0x1DAC440 Offset: 0x1DAAA40 VA: 0x181DAC440
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAC4C0 Offset: 0x1DAAAC0 VA: 0x181DAC4C0
	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAC990 Offset: 0x1DAAF90 VA: 0x181DAC990
	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	// RVA: 0x1DACC20 Offset: 0x1DAB220 VA: 0x181DACC20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAD1B0 Offset: 0x1DAB7B0 VA: 0x181DAD1B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAD280 Offset: 0x1DAB880 VA: 0x181DAD280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	// RVA: 0x1DACC40 Offset: 0x1DAB240 VA: 0x181DACC40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAC890 Offset: 0x1DAAE90 VA: 0x181DAC890
	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	// RVA: 0x1DAC750 Offset: 0x1DAAD50 VA: 0x181DAC750
	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC220 Offset: 0x1DAA820 VA: 0x181DAC220
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC550 Offset: 0x1DAAB50 VA: 0x181DAC550
	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DACD60 Offset: 0x1DAB360 VA: 0x181DACD60
	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	// RVA: 0x1DAD0D0 Offset: 0x1DAB6D0 VA: 0x181DAD0D0
	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1DAD1A0 Offset: 0x1DAB7A0 VA: 0x181DAD1A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAD1B0 Offset: 0x1DAB7B0 VA: 0x181DAD1B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DACF20 Offset: 0x1DAB520 VA: 0x181DACF20
	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	// RVA: 0x1DACE70 Offset: 0x1DAB470 VA: 0x181DACE70
	public static void SerializeLengthDelimited(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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


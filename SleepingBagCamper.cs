public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seatID; // 0x14

	// Methods

	// RVA: 0x1DACE20 Offset: 0x1DAB420 VA: 0x181DACE20
	public static void ResetToPool(SleepingBagCamper instance) { }

	// RVA: 0x1DACEA0 Offset: 0x1DAB4A0 VA: 0x181DACEA0
	public void ResetToPool() { }

	// RVA: 0x1DACCF0 Offset: 0x1DAB2F0 VA: 0x181DACCF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(SleepingBagCamper instance) { }

	// RVA: 0x1DAC370 Offset: 0x1DAA970 VA: 0x181DAC370
	public SleepingBagCamper Copy() { }

	// RVA: 0x1DACC70 Offset: 0x1DAB270 VA: 0x181DACC70
	public static SleepingBagCamper Deserialize(Stream stream) { }

	// RVA: 0x1DAC600 Offset: 0x1DAAC00 VA: 0x181DAC600
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAC680 Offset: 0x1DAAC80 VA: 0x181DAC680
	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DACB50 Offset: 0x1DAB150 VA: 0x181DACB50
	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	// RVA: 0x1DACDE0 Offset: 0x1DAB3E0 VA: 0x181DACDE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAD370 Offset: 0x1DAB970 VA: 0x181DAD370 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAD440 Offset: 0x1DABA40 VA: 0x181DAD440 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	// RVA: 0x1DACE00 Offset: 0x1DAB400 VA: 0x181DACE00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DACA50 Offset: 0x1DAB050 VA: 0x181DACA50
	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	// RVA: 0x1DAC910 Offset: 0x1DAAF10 VA: 0x181DAC910
	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC3E0 Offset: 0x1DAA9E0 VA: 0x181DAC3E0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAC710 Offset: 0x1DAAD10 VA: 0x181DAC710
	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DACF20 Offset: 0x1DAB520 VA: 0x181DACF20
	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	// RVA: 0x1DAD290 Offset: 0x1DAB890 VA: 0x181DAD290
	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1DAD360 Offset: 0x1DAB960 VA: 0x181DAD360
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAD370 Offset: 0x1DAB970 VA: 0x181DAD370
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAD0E0 Offset: 0x1DAB6E0 VA: 0x181DAD0E0
	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	// RVA: 0x1DAD030 Offset: 0x1DAB630 VA: 0x181DAD030
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


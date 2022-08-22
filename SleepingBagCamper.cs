public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seatID; // 0x14

	// Methods

	// RVA: 0x1DAD710 Offset: 0x1DABD10 VA: 0x181DAD710
	public static void ResetToPool(SleepingBagCamper instance) { }

	// RVA: 0x1DAD790 Offset: 0x1DABD90 VA: 0x181DAD790
	public void ResetToPool() { }

	// RVA: 0x1DAD5E0 Offset: 0x1DABBE0 VA: 0x181DAD5E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(SleepingBagCamper instance) { }

	// RVA: 0x1DACC60 Offset: 0x1DAB260 VA: 0x181DACC60
	public SleepingBagCamper Copy() { }

	// RVA: 0x1DAD560 Offset: 0x1DABB60 VA: 0x181DAD560
	public static SleepingBagCamper Deserialize(Stream stream) { }

	// RVA: 0x1DACEF0 Offset: 0x1DAB4F0 VA: 0x181DACEF0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DACF70 Offset: 0x1DAB570 VA: 0x181DACF70
	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAD440 Offset: 0x1DABA40 VA: 0x181DAD440
	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	// RVA: 0x1DAD6D0 Offset: 0x1DABCD0 VA: 0x181DAD6D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DADC60 Offset: 0x1DAC260 VA: 0x181DADC60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DADD30 Offset: 0x1DAC330 VA: 0x181DADD30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	// RVA: 0x1DAD6F0 Offset: 0x1DABCF0 VA: 0x181DAD6F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAD340 Offset: 0x1DAB940 VA: 0x181DAD340
	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	// RVA: 0x1DAD200 Offset: 0x1DAB800 VA: 0x181DAD200
	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DACCD0 Offset: 0x1DAB2D0 VA: 0x181DACCD0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAD000 Offset: 0x1DAB600 VA: 0x181DAD000
	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DAD810 Offset: 0x1DABE10 VA: 0x181DAD810
	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	// RVA: 0x1DADB80 Offset: 0x1DAC180 VA: 0x181DADB80
	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1DADC50 Offset: 0x1DAC250 VA: 0x181DADC50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DADC60 Offset: 0x1DAC260 VA: 0x181DADC60
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAD9D0 Offset: 0x1DABFD0 VA: 0x181DAD9D0
	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	// RVA: 0x1DAD920 Offset: 0x1DABF20 VA: 0x181DAD920
	public static void SerializeLengthDelimited(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class SleepingBagCamper : SleepingBag // TypeDefIndex: 8639
{	// Fields
	public EntityRef<BaseVehicleSeat> AssociatedSeat; // 0x450

	// Methods

	// RVA: 0x5A7BB0 Offset: 0x5A61B0 VA: 0x1805A7BB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5A7A00 Offset: 0x5A6000 VA: 0x1805A7A00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5A7B40 Offset: 0x5A6140 VA: 0x1805A7B40 Slot: 148
	public override bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A7B00 Offset: 0x5A6100 VA: 0x1805A7B00
	public void Menu_ClearBed(BasePlayer player) { }

	// RVA: 0x5A7AF0 Offset: 0x5A60F0 VA: 0x1805A7AF0
	public bool Menu_ClearBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5A79D0 Offset: 0x5A5FD0 VA: 0x1805A79D0 Slot: 145
	public override bool CanRename_Test(BasePlayer player) { }

	// RVA: 0x5A7CA0 Offset: 0x5A62A0 VA: 0x1805A7CA0
	public void .ctor() { }

}


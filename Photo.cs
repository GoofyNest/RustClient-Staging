public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong photographerSteamId; // 0x18
	public uint imageCrc; // 0x20

	// Methods

	// RVA: 0x1EAB3A0 Offset: 0x1EA99A0 VA: 0x181EAB3A0
	public static void ResetToPool(Photo instance) { }

	// RVA: 0x1EAB320 Offset: 0x1EA9920 VA: 0x181EAB320
	public void ResetToPool() { }

	// RVA: 0x1EAB080 Offset: 0x1EA9680 VA: 0x181EAB080 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAA250 Offset: 0x1EA8850 VA: 0x181EAA250
	public void CopyTo(Photo instance) { }

	// RVA: 0x1EAA280 Offset: 0x1EA8880 VA: 0x181EAA280
	public Photo Copy() { }

	// RVA: 0x1EAAAF0 Offset: 0x1EA90F0 VA: 0x181EAAAF0
	public static Photo Deserialize(Stream stream) { }

	// RVA: 0x1EAA540 Offset: 0x1EA8B40 VA: 0x181EAA540
	public static Photo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAA7F0 Offset: 0x1EA8DF0 VA: 0x181EAA7F0
	public static Photo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAA880 Offset: 0x1EA8E80 VA: 0x181EAA880
	public static Photo Deserialize(byte[] buffer) { }

	// RVA: 0x1EAB180 Offset: 0x1EA9780 VA: 0x181EAB180
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAB860 Offset: 0x1EA9E60 VA: 0x181EAB860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAB880 Offset: 0x1EA9E80 VA: 0x181EAB880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	// RVA: 0x1EAB300 Offset: 0x1EA9900 VA: 0x181EAB300 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAAE30 Offset: 0x1EA9430 VA: 0x181EAAE30
	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	// RVA: 0x1EAACB0 Offset: 0x1EA92B0 VA: 0x181EAACB0
	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA2F0 Offset: 0x1EA88F0 VA: 0x181EAA2F0
	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA5C0 Offset: 0x1EA8BC0 VA: 0x181EAA5C0
	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	// RVA: 0x1EAB420 Offset: 0x1EA9A20 VA: 0x181EAB420
	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	// RVA: 0x1EAB750 Offset: 0x1EA9D50 VA: 0x181EAB750
	public static void Serialize(Stream stream, Photo instance) { }

	// RVA: 0x1EAB850 Offset: 0x1EA9E50 VA: 0x181EAB850
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAB860 Offset: 0x1EA9E60 VA: 0x181EAB860
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAB640 Offset: 0x1EA9C40 VA: 0x181EAB640
	public static byte[] SerializeToBytes(Photo instance) { }

	// RVA: 0x1EAB590 Offset: 0x1EA9B90 VA: 0x181EAB590
	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}


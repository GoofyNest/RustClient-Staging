public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong photographerSteamId; // 0x18
	public uint imageCrc; // 0x20

	// Methods

	// RVA: 0x1EAB2A0 Offset: 0x1EA98A0 VA: 0x181EAB2A0
	public static void ResetToPool(Photo instance) { }

	// RVA: 0x1EAB220 Offset: 0x1EA9820 VA: 0x181EAB220
	public void ResetToPool() { }

	// RVA: 0x1EAAF80 Offset: 0x1EA9580 VA: 0x181EAAF80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAA150 Offset: 0x1EA8750 VA: 0x181EAA150
	public void CopyTo(Photo instance) { }

	// RVA: 0x1EAA180 Offset: 0x1EA8780 VA: 0x181EAA180
	public Photo Copy() { }

	// RVA: 0x1EAA9F0 Offset: 0x1EA8FF0 VA: 0x181EAA9F0
	public static Photo Deserialize(Stream stream) { }

	// RVA: 0x1EAA440 Offset: 0x1EA8A40 VA: 0x181EAA440
	public static Photo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAA6F0 Offset: 0x1EA8CF0 VA: 0x181EAA6F0
	public static Photo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAA780 Offset: 0x1EA8D80 VA: 0x181EAA780
	public static Photo Deserialize(byte[] buffer) { }

	// RVA: 0x1EAB080 Offset: 0x1EA9680 VA: 0x181EAB080
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAB760 Offset: 0x1EA9D60 VA: 0x181EAB760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAB780 Offset: 0x1EA9D80 VA: 0x181EAB780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	// RVA: 0x1EAB200 Offset: 0x1EA9800 VA: 0x181EAB200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAAD30 Offset: 0x1EA9330 VA: 0x181EAAD30
	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	// RVA: 0x1EAABB0 Offset: 0x1EA91B0 VA: 0x181EAABB0
	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA1F0 Offset: 0x1EA87F0 VA: 0x181EAA1F0
	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA4C0 Offset: 0x1EA8AC0 VA: 0x181EAA4C0
	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	// RVA: 0x1EAB320 Offset: 0x1EA9920 VA: 0x181EAB320
	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	// RVA: 0x1EAB650 Offset: 0x1EA9C50 VA: 0x181EAB650
	public static void Serialize(Stream stream, Photo instance) { }

	// RVA: 0x1EAB750 Offset: 0x1EA9D50 VA: 0x181EAB750
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAB760 Offset: 0x1EA9D60 VA: 0x181EAB760
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAB540 Offset: 0x1EA9B40 VA: 0x181EAB540
	public static byte[] SerializeToBytes(Photo instance) { }

	// RVA: 0x1EAB490 Offset: 0x1EA9A90 VA: 0x181EAB490
	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}


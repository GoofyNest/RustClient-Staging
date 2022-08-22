public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong photographerSteamId; // 0x18
	public uint imageCrc; // 0x20

	// Methods

	// RVA: 0x1EAB0E0 Offset: 0x1EA96E0 VA: 0x181EAB0E0
	public static void ResetToPool(Photo instance) { }

	// RVA: 0x1EAB060 Offset: 0x1EA9660 VA: 0x181EAB060
	public void ResetToPool() { }

	// RVA: 0x1EAADC0 Offset: 0x1EA93C0 VA: 0x181EAADC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA9F90 Offset: 0x1EA8590 VA: 0x181EA9F90
	public void CopyTo(Photo instance) { }

	// RVA: 0x1EA9FC0 Offset: 0x1EA85C0 VA: 0x181EA9FC0
	public Photo Copy() { }

	// RVA: 0x1EAA830 Offset: 0x1EA8E30 VA: 0x181EAA830
	public static Photo Deserialize(Stream stream) { }

	// RVA: 0x1EAA280 Offset: 0x1EA8880 VA: 0x181EAA280
	public static Photo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAA530 Offset: 0x1EA8B30 VA: 0x181EAA530
	public static Photo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAA5C0 Offset: 0x1EA8BC0 VA: 0x181EAA5C0
	public static Photo Deserialize(byte[] buffer) { }

	// RVA: 0x1EAAEC0 Offset: 0x1EA94C0 VA: 0x181EAAEC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAB5A0 Offset: 0x1EA9BA0 VA: 0x181EAB5A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAB5C0 Offset: 0x1EA9BC0 VA: 0x181EAB5C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	// RVA: 0x1EAB040 Offset: 0x1EA9640 VA: 0x181EAB040 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAAB70 Offset: 0x1EA9170 VA: 0x181EAAB70
	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	// RVA: 0x1EAA9F0 Offset: 0x1EA8FF0 VA: 0x181EAA9F0
	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA030 Offset: 0x1EA8630 VA: 0x181EAA030
	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAA300 Offset: 0x1EA8900 VA: 0x181EAA300
	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	// RVA: 0x1EAB160 Offset: 0x1EA9760 VA: 0x181EAB160
	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	// RVA: 0x1EAB490 Offset: 0x1EA9A90 VA: 0x181EAB490
	public static void Serialize(Stream stream, Photo instance) { }

	// RVA: 0x1EAB590 Offset: 0x1EA9B90 VA: 0x181EAB590
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAB5A0 Offset: 0x1EA9BA0 VA: 0x181EAB5A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAB380 Offset: 0x1EA9980 VA: 0x181EAB380
	public static byte[] SerializeToBytes(Photo instance) { }

	// RVA: 0x1EAB2D0 Offset: 0x1EA98D0 VA: 0x181EAB2D0
	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}


public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong photographerSteamId; // 0x18
	public uint imageCrc; // 0x20

	// Methods

	// RVA: 0x1EABBC0 Offset: 0x1EAA1C0 VA: 0x181EABBC0
	public static void ResetToPool(Photo instance) { }

	// RVA: 0x1EABB40 Offset: 0x1EAA140 VA: 0x181EABB40
	public void ResetToPool() { }

	// RVA: 0x1EAB8A0 Offset: 0x1EA9EA0 VA: 0x181EAB8A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAAA70 Offset: 0x1EA9070 VA: 0x181EAAA70
	public void CopyTo(Photo instance) { }

	// RVA: 0x1EAAAA0 Offset: 0x1EA90A0 VA: 0x181EAAAA0
	public Photo Copy() { }

	// RVA: 0x1EAB310 Offset: 0x1EA9910 VA: 0x181EAB310
	public static Photo Deserialize(Stream stream) { }

	// RVA: 0x1EAAD60 Offset: 0x1EA9360 VA: 0x181EAAD60
	public static Photo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAB010 Offset: 0x1EA9610 VA: 0x181EAB010
	public static Photo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EAB0A0 Offset: 0x1EA96A0 VA: 0x181EAB0A0
	public static Photo Deserialize(byte[] buffer) { }

	// RVA: 0x1EAB9A0 Offset: 0x1EA9FA0 VA: 0x181EAB9A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAC080 Offset: 0x1EAA680 VA: 0x181EAC080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAC0A0 Offset: 0x1EAA6A0 VA: 0x181EAC0A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	// RVA: 0x1EABB20 Offset: 0x1EAA120 VA: 0x181EABB20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAB650 Offset: 0x1EA9C50 VA: 0x181EAB650
	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	// RVA: 0x1EAB4D0 Offset: 0x1EA9AD0 VA: 0x181EAB4D0
	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAAB10 Offset: 0x1EA9110 VA: 0x181EAAB10
	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EAADE0 Offset: 0x1EA93E0 VA: 0x181EAADE0
	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	// RVA: 0x1EABC40 Offset: 0x1EAA240 VA: 0x181EABC40
	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	// RVA: 0x1EABF70 Offset: 0x1EAA570 VA: 0x181EABF70
	public static void Serialize(Stream stream, Photo instance) { }

	// RVA: 0x1EAC070 Offset: 0x1EAA670 VA: 0x181EAC070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAC080 Offset: 0x1EAA680 VA: 0x181EAC080
	public void ToProto(Stream stream) { }

	// RVA: 0x1EABE60 Offset: 0x1EAA460 VA: 0x181EABE60
	public static byte[] SerializeToBytes(Photo instance) { }

	// RVA: 0x1EABDB0 Offset: 0x1EAA3B0 VA: 0x181EABDB0
	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}


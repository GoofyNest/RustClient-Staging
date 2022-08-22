public class Vector3Serialized // TypeDefIndex: 6285
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector3 instance) { }

	// RVA: 0x1E4CEA0 Offset: 0x1E4B4A0 VA: 0x181E4CEA0
	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	// RVA: 0x1E4CFD0 Offset: 0x1E4B5D0 VA: 0x181E4CFD0
	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4C6C0 Offset: 0x1E4ACC0 VA: 0x181E4C6C0
	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4CAC0 Offset: 0x1E4B0C0 VA: 0x181E4CAC0
	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4D2F0 Offset: 0x1E4B8F0 VA: 0x181E4D2F0
	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	// RVA: 0x1E4D700 Offset: 0x1E4BD00 VA: 0x181E4D700
	public static void Serialize(Stream stream, Vector3 instance) { }

	// RVA: 0x1E4D5E0 Offset: 0x1E4BBE0 VA: 0x181E4D5E0
	public static byte[] SerializeToBytes(Vector3 instance) { }

	// RVA: 0x1E4D4E0 Offset: 0x1E4BAE0 VA: 0x181E4D4E0
	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


public class Vector3Serialized // TypeDefIndex: 6285
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector3 instance) { }

	// RVA: 0x1E4D980 Offset: 0x1E4BF80 VA: 0x181E4D980
	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	// RVA: 0x1E4DAB0 Offset: 0x1E4C0B0 VA: 0x181E4DAB0
	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4D1A0 Offset: 0x1E4B7A0 VA: 0x181E4D1A0
	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4D5A0 Offset: 0x1E4BBA0 VA: 0x181E4D5A0
	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4DDD0 Offset: 0x1E4C3D0 VA: 0x181E4DDD0
	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	// RVA: 0x1E4E1E0 Offset: 0x1E4C7E0 VA: 0x181E4E1E0
	public static void Serialize(Stream stream, Vector3 instance) { }

	// RVA: 0x1E4E0C0 Offset: 0x1E4C6C0 VA: 0x181E4E0C0
	public static byte[] SerializeToBytes(Vector3 instance) { }

	// RVA: 0x1E4DFC0 Offset: 0x1E4C5C0 VA: 0x181E4DFC0
	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


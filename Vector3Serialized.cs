public class Vector3Serialized // TypeDefIndex: 6285
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector3 instance) { }

	// RVA: 0x1E4D060 Offset: 0x1E4B660 VA: 0x181E4D060
	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	// RVA: 0x1E4D190 Offset: 0x1E4B790 VA: 0x181E4D190
	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4C880 Offset: 0x1E4AE80 VA: 0x181E4C880
	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4CC80 Offset: 0x1E4B280 VA: 0x181E4CC80
	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4D4B0 Offset: 0x1E4BAB0 VA: 0x181E4D4B0
	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	// RVA: 0x1E4D8C0 Offset: 0x1E4BEC0 VA: 0x181E4D8C0
	public static void Serialize(Stream stream, Vector3 instance) { }

	// RVA: 0x1E4D7A0 Offset: 0x1E4BDA0 VA: 0x181E4D7A0
	public static byte[] SerializeToBytes(Vector3 instance) { }

	// RVA: 0x1E4D6A0 Offset: 0x1E4BCA0 VA: 0x181E4D6A0
	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


public class Vector3Serialized // TypeDefIndex: 6285
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector3 instance) { }

	// RVA: 0x1E4D160 Offset: 0x1E4B760 VA: 0x181E4D160
	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	// RVA: 0x1E4D290 Offset: 0x1E4B890 VA: 0x181E4D290
	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4C980 Offset: 0x1E4AF80 VA: 0x181E4C980
	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4CD80 Offset: 0x1E4B380 VA: 0x181E4CD80
	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E4D5B0 Offset: 0x1E4BBB0 VA: 0x181E4D5B0
	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	// RVA: 0x1E4D9C0 Offset: 0x1E4BFC0 VA: 0x181E4D9C0
	public static void Serialize(Stream stream, Vector3 instance) { }

	// RVA: 0x1E4D8A0 Offset: 0x1E4BEA0 VA: 0x181E4D8A0
	public static byte[] SerializeToBytes(Vector3 instance) { }

	// RVA: 0x1E4D7A0 Offset: 0x1E4BDA0 VA: 0x181E4D7A0
	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


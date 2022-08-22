public class RaySerialized // TypeDefIndex: 6286
{	// Methods

	// RVA: 0x1E49630 Offset: 0x1E47C30 VA: 0x181E49630
	public static void ResetToPool(Ray instance) { }

	// RVA: 0x1E49360 Offset: 0x1E47960 VA: 0x181E49360
	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	// RVA: 0x1E49130 Offset: 0x1E47730 VA: 0x181E49130
	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48B30 Offset: 0x1E47130 VA: 0x181E48B30
	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E48E40 Offset: 0x1E47440 VA: 0x181E48E40
	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E49690 Offset: 0x1E47C90 VA: 0x181E49690
	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	// RVA: 0x1E49D60 Offset: 0x1E48360 VA: 0x181E49D60
	public static void Serialize(Stream stream, Ray instance) { }

	// RVA: 0x1E49C30 Offset: 0x1E48230 VA: 0x181E49C30
	public static byte[] SerializeToBytes(Ray instance) { }

	// RVA: 0x1E49B20 Offset: 0x1E48120 VA: 0x181E49B20
	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


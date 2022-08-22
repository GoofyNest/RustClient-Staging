internal sealed class SharedStatics // TypeDefIndex: 298
{	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x18AF150 Offset: 0x18AD750 VA: 0x1818AF150
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x18AF370 Offset: 0x18AD970 VA: 0x1818AF370
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x18AF4C0 Offset: 0x18ADAC0 VA: 0x1818AF4C0
	private static void .cctor() { }

}


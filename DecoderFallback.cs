public abstract class DecoderFallback // TypeDefIndex: 439
{	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static DecoderFallback replacementFallback; // 0x0
	private static DecoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x18ABE90 Offset: 0x18AA490 VA: 0x1818ABE90
	private static object get_InternalSyncObject() { }

	// RVA: 0x18ABF20 Offset: 0x18AA520 VA: 0x1818ABF20
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x18ABCD0 Offset: 0x18AA2D0 VA: 0x1818ABCD0
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}


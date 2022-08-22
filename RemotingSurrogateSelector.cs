public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 1257
{	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x148B310 Offset: 0x1489910 VA: 0x18148B310 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x148B510 Offset: 0x1489B10 VA: 0x18148B510
	private static void .cctor() { }

}


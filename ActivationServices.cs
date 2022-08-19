internal class ActivationServices // TypeDefIndex: 1202
{	// Fields
	private static IActivator _constructionActivator; // 0x13FA0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0xFDB580 Offset: 0xFD9B80 VA: 0x180FDB580
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0xFDA5E0 Offset: 0xFD8BE0 VA: 0x180FDA5E0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0xFDB4C0 Offset: 0xFD9AC0 VA: 0x180FDB4C0
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDA790 Offset: 0xFD8D90 VA: 0x180FDA790
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0xFDAF70 Offset: 0xFD9570 VA: 0x180FDAF70
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDB350 Offset: 0xFD9950 VA: 0x180FDB350
	public static object CreateProxyForType(Type type) { }

	// RVA: 0xFDA780 Offset: 0xFD8D80 VA: 0x180FDA780
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0xFDB4B0 Offset: 0xFD9AB0 VA: 0x180FDB4B0
	public static void EnableProxyActivation(Type type, bool enable) { }

}


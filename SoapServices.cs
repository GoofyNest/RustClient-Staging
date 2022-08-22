public class SoapServices // TypeDefIndex: 1150
{	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x1205FA0 Offset: 0x12045A0 VA: 0x181205FA0
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x1206000 Offset: 0x1204600 VA: 0x181206000
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x1205FD0 Offset: 0x12045D0 VA: 0x181205FD0
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x1204C40 Offset: 0x1203240 VA: 0x181204C40
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x1205020 Offset: 0x1203620 VA: 0x181205020
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x1204ED0 Offset: 0x12034D0 VA: 0x181204ED0
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x1205080 Offset: 0x1203680 VA: 0x181205080
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x1205190 Offset: 0x1203790 VA: 0x181205190
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x1205240 Offset: 0x1203840 VA: 0x181205240
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x12052F0 Offset: 0x12038F0 VA: 0x1812052F0
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x12053E0 Offset: 0x12039E0 VA: 0x1812053E0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x12054A0 Offset: 0x1203AA0 VA: 0x1812054A0
	public static void PreLoad(Type type) { }

	// RVA: 0x1205B30 Offset: 0x1204130 VA: 0x181205B30
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x1205CD0 Offset: 0x12042D0 VA: 0x181205CD0
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x1204E40 Offset: 0x1203440 VA: 0x181204E40
	private static string EncodeNs(string ns) { }

	// RVA: 0x1205E70 Offset: 0x1204470 VA: 0x181205E70
	private static void .cctor() { }

}

private class SoapServices.TypeInfo // TypeDefIndex: 1151
{	// Fields
	public Hashtable Attributes; // 0x10
	public Hashtable Elements; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


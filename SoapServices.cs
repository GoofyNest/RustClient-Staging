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

	// RVA: 0x1205640 Offset: 0x1203C40 VA: 0x181205640
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x12056A0 Offset: 0x1203CA0 VA: 0x1812056A0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x1205670 Offset: 0x1203C70 VA: 0x181205670
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x12042E0 Offset: 0x12028E0 VA: 0x1812042E0
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x12046C0 Offset: 0x1202CC0 VA: 0x1812046C0
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x1204570 Offset: 0x1202B70 VA: 0x181204570
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x1204720 Offset: 0x1202D20 VA: 0x181204720
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x1204830 Offset: 0x1202E30 VA: 0x181204830
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x12048E0 Offset: 0x1202EE0 VA: 0x1812048E0
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x1204990 Offset: 0x1202F90 VA: 0x181204990
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x1204A80 Offset: 0x1203080 VA: 0x181204A80
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x1204B40 Offset: 0x1203140 VA: 0x181204B40
	public static void PreLoad(Type type) { }

	// RVA: 0x12051D0 Offset: 0x12037D0 VA: 0x1812051D0
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x1205370 Offset: 0x1203970 VA: 0x181205370
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x12044E0 Offset: 0x1202AE0 VA: 0x1812044E0
	private static string EncodeNs(string ns) { }

	// RVA: 0x1205510 Offset: 0x1203B10 VA: 0x181205510
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


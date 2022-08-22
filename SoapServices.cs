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

	// RVA: 0x1205900 Offset: 0x1203F00 VA: 0x181205900
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x1205960 Offset: 0x1203F60 VA: 0x181205960
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x1205930 Offset: 0x1203F30 VA: 0x181205930
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x12045A0 Offset: 0x1202BA0 VA: 0x1812045A0
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x1204980 Offset: 0x1202F80 VA: 0x181204980
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x1204830 Offset: 0x1202E30 VA: 0x181204830
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x12049E0 Offset: 0x1202FE0 VA: 0x1812049E0
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x1204AF0 Offset: 0x12030F0 VA: 0x181204AF0
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x1204BA0 Offset: 0x12031A0 VA: 0x181204BA0
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x1204C50 Offset: 0x1203250 VA: 0x181204C50
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x1204D40 Offset: 0x1203340 VA: 0x181204D40
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x1204E00 Offset: 0x1203400 VA: 0x181204E00
	public static void PreLoad(Type type) { }

	// RVA: 0x1205490 Offset: 0x1203A90 VA: 0x181205490
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x1205630 Offset: 0x1203C30 VA: 0x181205630
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x12047A0 Offset: 0x1202DA0 VA: 0x1812047A0
	private static string EncodeNs(string ns) { }

	// RVA: 0x12057D0 Offset: 0x1203DD0 VA: 0x1812057D0
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


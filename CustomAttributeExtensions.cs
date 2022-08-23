public static class CustomAttributeExtensions // TypeDefIndex: 502
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA1C0 Offset: 0xBD87C0 VA: 0x180BDA1C0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	|-CustomAttributeExtensions.GetCustomAttribute<NeutralResourcesLanguageAttribute>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDA100 Offset: 0xBD8700 VA: 0x180BDA100
	|-CustomAttributeExtensions.GetCustomAttribute<ButtonGroupAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<LabelAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<XmlTypeConvertorAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<RangeAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFFC0 Offset: 0xCFE5C0 VA: 0x180CFFFC0
	|-CustomAttributeExtensions.GetCustomAttributes<OptionAttribute>
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

}


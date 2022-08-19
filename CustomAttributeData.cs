public class CustomAttributeData // TypeDefIndex: 560
{	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18C79D0 Offset: 0x18C5FD0 VA: 0x1818C79D0
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x18C7270 Offset: 0x18C5870 VA: 0x1818C7270
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x18C7280 Offset: 0x18C5880 VA: 0x1818C7280
	private void ResolveArguments() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x18C7AA0 Offset: 0x18C60A0 VA: 0x1818C7AA0 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x18C7AC0 Offset: 0x18C60C0 VA: 0x1818C7AC0 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x18C6DB0 Offset: 0x18C53B0 VA: 0x1818C6DB0
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x18C6E10 Offset: 0x18C5410 VA: 0x1818C6E10
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x18C6C90 Offset: 0x18C5290 VA: 0x1818C6C90
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x18C6D50 Offset: 0x18C5350 VA: 0x1818C6D50
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x18C6CF0 Offset: 0x18C52F0 VA: 0x1818C6CF0
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50
	public Type get_AttributeType() { }

	// RVA: 0x18C73E0 Offset: 0x18C59E0 VA: 0x1818C73E0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A377E0 Offset: 0x1A35DE0 VA: 0x181A377E0
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x1A37580 Offset: 0x1A35B80 VA: 0x181A37580
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1A376C0 Offset: 0x1A35CC0 VA: 0x181A376C0
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x18C6820 Offset: 0x18C4E20 VA: 0x1818C6820 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C6E70 Offset: 0x18C5470 VA: 0x1818C6E70 Slot: 2
	public override int GetHashCode() { }

}

private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 561
{	// Fields
	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}


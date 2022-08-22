public class CustomAttributeData // TypeDefIndex: 560
{	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18C7C50 Offset: 0x18C6250 VA: 0x1818C7C50
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x18C74F0 Offset: 0x18C5AF0 VA: 0x1818C74F0
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x18C7500 Offset: 0x18C5B00 VA: 0x1818C7500
	private void ResolveArguments() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x18C7D20 Offset: 0x18C6320 VA: 0x1818C7D20 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x18C7D40 Offset: 0x18C6340 VA: 0x1818C7D40 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x18C7030 Offset: 0x18C5630 VA: 0x1818C7030
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x18C7090 Offset: 0x18C5690 VA: 0x1818C7090
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x18C6F10 Offset: 0x18C5510 VA: 0x1818C6F10
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x18C6FD0 Offset: 0x18C55D0 VA: 0x1818C6FD0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x18C6F70 Offset: 0x18C5570 VA: 0x1818C6F70
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10
	public Type get_AttributeType() { }

	// RVA: 0x18C7660 Offset: 0x18C5C60 VA: 0x1818C7660 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37A60 Offset: 0x1A36060 VA: 0x181A37A60
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x1A37800 Offset: 0x1A35E00 VA: 0x181A37800
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1A37940 Offset: 0x1A35F40 VA: 0x181A37940
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x18C6AA0 Offset: 0x18C50A0 VA: 0x1818C6AA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18C70F0 Offset: 0x18C56F0 VA: 0x1818C70F0 Slot: 2
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


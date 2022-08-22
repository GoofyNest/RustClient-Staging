public abstract class Attribute // TypeDefIndex: 174
{	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x155CE20 Offset: 0x155B420 VA: 0x18155CE20
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x155CD80 Offset: 0x155B380 VA: 0x18155CD80
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x155CFC0 Offset: 0x155B5C0 VA: 0x18155CFC0
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x155CEC0 Offset: 0x155B4C0 VA: 0x18155CEC0
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155CF40 Offset: 0x155B540 VA: 0x18155CF40
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155BA90 Offset: 0x155A090 VA: 0x18155BA90
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x155BF20 Offset: 0x155A520 VA: 0x18155BF20
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x155C200 Offset: 0x155A800 VA: 0x18155C200
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x155D770 Offset: 0x155BD70 VA: 0x18155D770
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x155D450 Offset: 0x155BA50 VA: 0x18155D450
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155B920 Offset: 0x1559F20 VA: 0x18155B920
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x155B7B0 Offset: 0x1559DB0 VA: 0x18155B7B0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155C530 Offset: 0x155AB30 VA: 0x18155C530
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155CA10 Offset: 0x155B010 VA: 0x18155CA10
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x155C8E0 Offset: 0x155AEE0 VA: 0x18155C8E0
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x155BCD0 Offset: 0x155A2D0 VA: 0x18155BCD0
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x155CBB0 Offset: 0x155B1B0 VA: 0x18155CBB0
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x155BAA0 Offset: 0x155A0A0 VA: 0x18155BAA0
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x155C7E0 Offset: 0x155ADE0 VA: 0x18155C7E0
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x155C420 Offset: 0x155AA20 VA: 0x18155C420
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x155B870 Offset: 0x1559E70 VA: 0x18155B870
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x155B9D0 Offset: 0x1559FD0 VA: 0x18155B9D0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x155B480 Offset: 0x1559A80 VA: 0x18155B480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x155B270 Offset: 0x1559870 VA: 0x18155B270
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x155CBC0 Offset: 0x155B1C0 VA: 0x18155CBC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DD3D0 Offset: 0x10DB9D0 VA: 0x1810DD3D0 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x155D780 Offset: 0x155BD80 VA: 0x18155D780 Slot: 5
	public virtual bool Match(object obj) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public virtual bool IsDefaultAttribute() { }

}

public enum AttributeTargets // TypeDefIndex: 175
{	// Fields
	public int value__; // 0x0
	public const AttributeTargets Assembly = 1;
	public const AttributeTargets Module = 2;
	public const AttributeTargets Class = 4;
	public const AttributeTargets Struct = 8;
	public const AttributeTargets Enum = 16;
	public const AttributeTargets Constructor = 32;
	public const AttributeTargets Method = 64;
	public const AttributeTargets Property = 128;
	public const AttributeTargets Field = 256;
	public const AttributeTargets Event = 512;
	public const AttributeTargets Interface = 1024;
	public const AttributeTargets Parameter = 2048;
	public const AttributeTargets Delegate = 4096;
	public const AttributeTargets ReturnValue = 8192;
	public const AttributeTargets GenericParameter = 16384;
	public const AttributeTargets All = 32767;

}

public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 176
{	// Fields
	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x155B230 Offset: 0x1559830 VA: 0x18155B230
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0xA115B0 Offset: 0xA0FBB0 VA: 0x180A115B0
	public bool get_AllowMultiple() { }

	// RVA: 0xA115D0 Offset: 0xA0FBD0 VA: 0x180A115D0
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x13A4790 Offset: 0x13A2D90 VA: 0x1813A4790
	public bool get_Inherited() { }

	// RVA: 0x155B260 Offset: 0x1559860 VA: 0x18155B260
	public void set_Inherited(bool value) { }

	// RVA: 0x155B1C0 Offset: 0x15597C0 VA: 0x18155B1C0
	private static void .cctor() { }

}

internal enum AttributeProperties // TypeDefIndex: 1863
{	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;

}

internal class AttributePSVIInfo // TypeDefIndex: 1943
{	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x12E3CD0 Offset: 0x12E22D0 VA: 0x1812E3CD0
	internal void .ctor() { }

	// RVA: 0x12E3C40 Offset: 0x12E2240 VA: 0x1812E3C40
	internal void Reset() { }

}

internal enum AttributeMatchState // TypeDefIndex: 2279
{	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;

}

public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 2666
{	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable _defaultAttributes; // 0x8
	private Attribute[] _attributes; // 0x10
	private static object internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x15BCA60 Offset: 0x15BB060 VA: 0x1815BCA60
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 8
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x15BC990 Offset: 0x15BAF90 VA: 0x1815BC990
	public int get_Count() { }

	// RVA: 0x15BCB40 Offset: 0x15BB140 VA: 0x1815BCB40 Slot: 9
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x15BC330 Offset: 0x15BA930 VA: 0x1815BC330
	public bool Contains(Attribute attribute) { }

	// RVA: 0x15BC440 Offset: 0x15BAA40 VA: 0x1815BC440
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x15BC960 Offset: 0x15BAF60 VA: 0x1815BC960
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15BC990 Offset: 0x15BAF90 VA: 0x1815BC990 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15BC3B0 Offset: 0x15BA9B0 VA: 0x1815BC3B0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15BC960 Offset: 0x15BAF60 VA: 0x1815BC960 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15BC9C0 Offset: 0x15BAFC0 VA: 0x1815BC9C0
	private static void .cctor() { }

}

private struct AttributeCollection.AttributeEntry // TypeDefIndex: 2667
{	// Fields
	public Type type; // 0x0
	public int index; // 0x8

}

public class AttributeProviderAttribute : Attribute // TypeDefIndex: 2668
{	// Fields
	private string _typeName; // 0x10
	private string _propertyName; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_TypeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_PropertyName() { }

}

internal class AttributeHelperEngine // TypeDefIndex: 3492
{	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180C7D0 Offset: 0x180ADD0 VA: 0x18180C7D0
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180C8B0 Offset: 0x180AEB0 VA: 0x18180C8B0
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x180C6D0 Offset: 0x180ACD0 VA: 0x18180C6D0
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180C5A0 Offset: 0x180ABA0 VA: 0x18180C5A0
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180C660 Offset: 0x180AC60 VA: 0x18180C660
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159D840 Offset: 0x159BE40 VA: 0x18159D840
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	// RVA: 0x180CC70 Offset: 0x180B270 VA: 0x18180CC70
	private static void .cctor() { }

}


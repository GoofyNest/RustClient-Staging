public abstract class Attribute // TypeDefIndex: 174
{	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x155DA90 Offset: 0x155C090 VA: 0x18155DA90
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x155D9F0 Offset: 0x155BFF0 VA: 0x18155D9F0
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x155DC30 Offset: 0x155C230 VA: 0x18155DC30
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x155DB30 Offset: 0x155C130 VA: 0x18155DB30
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155DBB0 Offset: 0x155C1B0 VA: 0x18155DBB0
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155C700 Offset: 0x155AD00 VA: 0x18155C700
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x155CB90 Offset: 0x155B190 VA: 0x18155CB90
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x155CE70 Offset: 0x155B470 VA: 0x18155CE70
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x155E3E0 Offset: 0x155C9E0 VA: 0x18155E3E0
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x155E0C0 Offset: 0x155C6C0 VA: 0x18155E0C0
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155C590 Offset: 0x155AB90 VA: 0x18155C590
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x155C420 Offset: 0x155AA20 VA: 0x18155C420
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155D1A0 Offset: 0x155B7A0 VA: 0x18155D1A0
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155D680 Offset: 0x155BC80 VA: 0x18155D680
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x155D550 Offset: 0x155BB50 VA: 0x18155D550
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x155C940 Offset: 0x155AF40 VA: 0x18155C940
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x155D820 Offset: 0x155BE20 VA: 0x18155D820
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x155C710 Offset: 0x155AD10 VA: 0x18155C710
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x155D450 Offset: 0x155BA50 VA: 0x18155D450
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x155D090 Offset: 0x155B690 VA: 0x18155D090
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x155C4E0 Offset: 0x155AAE0 VA: 0x18155C4E0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x155C640 Offset: 0x155AC40 VA: 0x18155C640
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x155C0F0 Offset: 0x155A6F0 VA: 0x18155C0F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x155BEE0 Offset: 0x155A4E0 VA: 0x18155BEE0
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x155D830 Offset: 0x155BE30 VA: 0x18155D830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DC6A0 Offset: 0x10DACA0 VA: 0x1810DC6A0 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x155E3F0 Offset: 0x155C9F0 VA: 0x18155E3F0 Slot: 5
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

	// RVA: 0x155BEA0 Offset: 0x155A4A0 VA: 0x18155BEA0
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0xA10E00 Offset: 0xA0F400 VA: 0x180A10E00
	public bool get_AllowMultiple() { }

	// RVA: 0xA10E20 Offset: 0xA0F420 VA: 0x180A10E20
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x13A53D0 Offset: 0x13A39D0 VA: 0x1813A53D0
	public bool get_Inherited() { }

	// RVA: 0x155BED0 Offset: 0x155A4D0 VA: 0x18155BED0
	public void set_Inherited(bool value) { }

	// RVA: 0x155BE30 Offset: 0x155A430 VA: 0x18155BE30
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

	// RVA: 0x12DD560 Offset: 0x12DBB60 VA: 0x1812DD560
	internal void .ctor() { }

	// RVA: 0x12DD4D0 Offset: 0x12DBAD0 VA: 0x1812DD4D0
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

	// RVA: 0x15BD6D0 Offset: 0x15BBCD0 VA: 0x1815BD6D0
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 8
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x15BD600 Offset: 0x15BBC00 VA: 0x1815BD600
	public int get_Count() { }

	// RVA: 0x15BD7B0 Offset: 0x15BBDB0 VA: 0x1815BD7B0 Slot: 9
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x15BCFA0 Offset: 0x15BB5A0 VA: 0x1815BCFA0
	public bool Contains(Attribute attribute) { }

	// RVA: 0x15BD0B0 Offset: 0x15BB6B0 VA: 0x1815BD0B0
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x15BD5D0 Offset: 0x15BBBD0 VA: 0x1815BD5D0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15BD600 Offset: 0x15BBC00 VA: 0x1815BD600 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15BD020 Offset: 0x15BB620 VA: 0x1815BD020 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15BD5D0 Offset: 0x15BBBD0 VA: 0x1815BD5D0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15BD630 Offset: 0x15BBC30 VA: 0x1815BD630
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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181F0D0 Offset: 0x181D6D0 VA: 0x18181F0D0
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181F1B0 Offset: 0x181D7B0 VA: 0x18181F1B0
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x181EFD0 Offset: 0x181D5D0 VA: 0x18181EFD0
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181EEA0 Offset: 0x181D4A0 VA: 0x18181EEA0
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x181EF60 Offset: 0x181D560 VA: 0x18181EF60
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E4B0 Offset: 0x159CAB0 VA: 0x18159E4B0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	// RVA: 0x181F570 Offset: 0x181DB70 VA: 0x18181F570
	private static void .cctor() { }

}


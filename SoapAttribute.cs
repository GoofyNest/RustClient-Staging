public class SoapAttribute : Attribute // TypeDefIndex: 1210
{
// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject // TypeDefIndex: 1209

// Namespace: System.Runtime.Remoting.Metadata
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
public class SoapAttribute : Attribute // TypeDefIndex: 1210
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }

}


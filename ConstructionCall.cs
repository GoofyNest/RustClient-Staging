public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1232
{	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x1472990 Offset: 0x1470F90 VA: 0x181472990
	internal void .ctor(Type type) { }

	// RVA: 0x1472A00 Offset: 0x1471000 VA: 0x181472A00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14725C0 Offset: 0x1470BC0 VA: 0x1814725C0 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x118D200 Offset: 0x118B800 VA: 0x18118D200
	internal bool get_IsContextOk() { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x1472AB0 Offset: 0x14710B0 VA: 0x181472AB0 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x1472B80 Offset: 0x1471180 VA: 0x181472B80 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x14726D0 Offset: 0x1470CD0 VA: 0x1814726D0 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x14724C0 Offset: 0x1470AC0 VA: 0x1814724C0 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1472BF0 Offset: 0x14711F0 VA: 0x181472BF0 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x5743A0 Offset: 0x5729A0 VA: 0x1805743A0
	internal void set_SourceProxy(RemotingProxy value) { }

}


public class ViewModel : MonoBehaviour, IClientComponent // TypeDefIndex: 9251
{	// Fields
	public GameObjectRef viewModelPrefab; // 0x18
	public HeldEntity targetEntity; // 0x20
	public BaseViewModel instance; // 0x28

	// Properties
	public bool ironSights { set; }

	// Methods

	// RVA: 0xADEE60 Offset: 0xADD460 VA: 0x180ADEE60
	public void Deploy(BaseEntity parent) { }

	// RVA: 0xADF1D0 Offset: 0xADD7D0 VA: 0x180ADF1D0
	public void OnDisable() { }

	// RVA: 0xADF160 Offset: 0xADD760 VA: 0x180ADF160
	public void Holster() { }

	// RVA: 0xADECF0 Offset: 0xADD2F0 VA: 0x180ADECF0
	public void Clear() { }

	// RVA: 0xADF240 Offset: 0xADD840 VA: 0x180ADF240
	public void OnFrame() { }

	// RVA: 0xADF3A0 Offset: 0xADD9A0 VA: 0x180ADF3A0
	public void Play(string name, int layer = 0) { }

	// RVA: 0xADF4D0 Offset: 0xADDAD0 VA: 0x180ADF4D0
	public void ResetTrigger(string name) { }

	// RVA: 0xADF440 Offset: 0xADDA40 VA: 0x180ADF440
	public void ResetTrigger(int hash) { }

	// RVA: 0xADF7E0 Offset: 0xADDDE0 VA: 0x180ADF7E0
	public void Trigger(string name) { }

	// RVA: 0xADF870 Offset: 0xADDE70 VA: 0x180ADF870
	public void Trigger(int hash) { }

	// RVA: 0xADEDC0 Offset: 0xADD3C0 VA: 0x180ADEDC0
	public void CrossFade(string name, float duration = 0,2) { }

	// RVA: 0xADF600 Offset: 0xADDC00 VA: 0x180ADF600
	public void SetBool(string name, bool bState) { }

	// RVA: 0xADF560 Offset: 0xADDB60 VA: 0x180ADF560
	public void SetBool(int hash, bool bState) { }

	// RVA: 0xADF740 Offset: 0xADDD40 VA: 0x180ADF740
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0xADF6A0 Offset: 0xADDCA0 VA: 0x180ADF6A0
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0xADF900 Offset: 0xADDF00 VA: 0x180ADF900
	public void set_ironSights(bool value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

